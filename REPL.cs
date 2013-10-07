using Newtonsoft.Json;
using ScriptCs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FluentAutomation.REPL
{
    public partial class REPL : Form
    {
        private UserSettings settings = null;
        private StatusViewModel viewModel = null;
        private ScriptServices scriptServices = null;
        private Repl repl = null;
        private SettingsManager settingsManager = null;
        private List<string> commands = new List<string>();
        private int commandIndex = -1;
        private string fluentGuid = string.Empty;
        private bool hasOpenBrowser = false;

        public REPL()
        {
            InitializeComponent();

            this.settings = new UserSettings();
            this.viewModel = new StatusViewModel();

            this.browserSelection.Items.Clear();
            var browserValues = Enum.GetValues(typeof(FluentAutomation.SeleniumWebDriver.Browser)).Cast<FluentAutomation.SeleniumWebDriver.Browser>().ToList();
            browserValues.Sort((x, y) => x.ToString().CompareTo(y.ToString()));

            foreach (var browserValue in browserValues)
            {
                this.browserSelection.Items.Add(browserValue.ToString());
            }

            this.InitRepl();
            this.browserSelection.SetItemChecked(1, true);
        }

        private void REPL_Load(object sender, EventArgs e)
        {
            this.consoleTextBox.Text = this.CreateLine().ToString();
            this.consoleTextBox.Select(this.consoleTextBox.Text.Length, 0);
        }

        private void REPL_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();

            if (this.viewModel.Url != null)
                this.repl.Execute(this.fluentGuid + ".Dispose();");
        }

        private void InitRepl()
        {
            var servicesBuilder = new ReplScriptServicesBuilder(new ScriptConsole(), new Common.Logging.Simple.NoOpLogger()).InMemory(true).Repl(true);
            servicesBuilder.ScriptName("F14N.REPL");

            this.scriptServices = servicesBuilder.Build();
            this.scriptServices.Executor.Initialize(new string[] { }, this.scriptServices.ScriptPackResolver.GetPacks());
            this.scriptServices.Executor.AddReferenceAndImportNamespaces(new[] { typeof(FluentAutomation.FluentTest), typeof(FluentAutomation.SeleniumWebDriver) });

            this.repl = this.scriptServices.Executor as Repl;
            this.settingsManager = new SettingsManager((scriptString) =>
            {
                return this.repl.Execute(scriptString);
            });
        }

        private void SetReplBrowser()
        {
            if (this.browserSelection.CheckedItems.Count == 1)
            {
                var browserValue = this.browserSelection.CheckedItems[0].ToString();
                this.SetReplBrowser(browserValue);
            }
        }

        private void SetReplBrowser(string browser)
        {
            this.SetReplBrowser((FluentAutomation.SeleniumWebDriver.Browser)Enum.Parse(typeof(FluentAutomation.SeleniumWebDriver.Browser), browser));
        }

        private void SetReplBrowser(FluentAutomation.SeleniumWebDriver.Browser browser)
        {
            this.viewModel.Browser = browser;
            this.fluentGuid = "__a" + Guid.NewGuid().ToString().Replace("-", "");

            var result = this.repl.Execute("FluentAutomation.SeleniumWebDriver.Bootstrap(FluentAutomation.SeleniumWebDriver.Browser." + browser.ToString() + "); var " + this.fluentGuid + " = new FluentAutomation.FluentTest(); var I = " + this.fluentGuid + ".I; var Container = " + this.fluentGuid + ".Container;");

            if (result.CompileExceptionInfo != null)
                this.consoleTextBox.Text += "\n" + result.CompileExceptionInfo.SourceException.ToString() + "\n";
            else if (result.ExecuteExceptionInfo != null)
                consoleTextBox.Text += "\n" + result.ExecuteExceptionInfo.SourceException.ToString() + "\n";
        }

        private void UpdateCommand(RichTextBox textBox, string command)
        {
            var lines = textBox.Lines;
            if (lines.Length > 0)
            {
                lines[lines.Length - 1] = this.CreateLine().ToString() + command;
                textBox.Lines = lines;
                textBox.Select(textBox.Text.Length, 0);
            }
        }

        private void consoleTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            var textBox = (RichTextBox)sender;
            var cursorCharacterIndex = textBox.SelectionStart;

            if (e.Control && e.KeyCode == Keys.V)
            {
                textBox.Text += Clipboard.GetText(TextDataFormat.Text);
                textBox.Select(textBox.Text.Length, 0);
                e.SuppressKeyPress = true;
                return;
            }
            else if (e.Control && e.KeyCode == Keys.C)
            {
                return;
            }
            else if (e.Control)
            {
                return;
            }
            else if (e.KeyCode == Keys.PageUp || e.KeyCode == Keys.PageDown)
            {
                e.SuppressKeyPress = true;
                return;
            }

            if (textBox.GetLineFromCharIndex(cursorCharacterIndex) != textBox.GetLineFromCharIndex(textBox.Text.Length - 1))
            {
                textBox.Select(textBox.Text.Length, 0);
                return;
            }

            var preceedingCharacters = "";
            if (cursorCharacterIndex >= 2)
                preceedingCharacters = textBox.Text.Substring(cursorCharacterIndex - 2, 2);

            if (e.KeyCode == Keys.Back)
            {
               if (preceedingCharacters == this.settings.StatusLineSeparator && textBox.SelectionLength == 0)
                    e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.Up)
            {
                e.SuppressKeyPress = true;

                if (this.commandIndex >= 0 && this.commandIndex < this.commands.Count)
                {
                    this.UpdateCommand(textBox, this.commands[this.commandIndex]);
                    if (this.commandIndex > 0) this.commandIndex--;
                }
            }
            else if (e.KeyCode == Keys.Down)
            {
                e.SuppressKeyPress = true;

                if (this.commandIndex >= 0 && this.commandIndex < this.commands.Count)
                {
                    if (this.commandIndex < this.commands.Count - 1)
                    {
                        this.commandIndex++;
                        this.UpdateCommand(textBox, this.commands[this.commandIndex]);
                    }
                    else
                    {
                        this.UpdateCommand(textBox, "");
                    }
                }
            }
            else if (e.KeyCode == Keys.Home)
            {
                e.SuppressKeyPress = true;
                var sepPosition = textBox.Text.LastIndexOf(this.settings.StatusLineSeparator);

                if (e.Modifiers == Keys.Shift)
                    textBox.Select(sepPosition + this.settings.StatusLineSeparator.Length, textBox.SelectionStart);
                else
                    textBox.Select(sepPosition + this.settings.StatusLineSeparator.Length, 0);
            }
            else if (e.KeyCode == Keys.End)
            {
                e.SuppressKeyPress = true;

                if (e.Modifiers == Keys.Shift)
                    textBox.Select(textBox.SelectionStart, textBox.Text.Length - textBox.SelectionStart);
                else
                    textBox.Select(textBox.Text.Length, 0);
            }
            else if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                textBox.Select(textBox.Text.Length, 0);

                var commandLine = textBox.Lines.Last();
                var sepPosition = textBox.Text.LastIndexOf(this.settings.StatusLineSeparator);
                var command = textBox.Text.Substring(sepPosition + this.settings.StatusLineSeparator.Length, textBox.Text.Length - sepPosition - this.settings.StatusLineSeparator.Length);

                this.commands.Add(command);

                // We wait until the last second to init the REPL/browser
                var skipExecute = false;
                if (command.IndexOf("I.Open") != -1)
                {
                    this.viewModel.Url = null; // invalidate viewModel URL so we can re-request it after loading

                    if (this.viewModel.Browser == null)
                        this.SetReplBrowser();

                    this.hasOpenBrowser = true;
                }
                else if ((command.IndexOf("I.") != -1 || command.IndexOf("I") == 0) && this.viewModel.Browser == null)
                {
                    textBox.Text += "\nCall I.Open with a URI before issuing browser commands.\n";
                    skipExecute = true;
                }
                else if (command.IndexOf("I.Press") != -1)
                {
                    textBox.Text += "\nI.Press commands are disabled in the REPL.\n";
                    skipExecute = true;
                }
                else if (command.IndexOf("FluentAutomation.Settings") != -1)
                {
                    textBox.Text += "\nChange settings from the settings panel, not via commands.\n";
                    skipExecute = true;
                }
                else if (command == "cls" || command == "clear")
                {
                    textBox.Text = this.CreateLine().ToString();
                    textBox.Select(textBox.Text.Length, 0);
                    return;
                }
                else if (command == "exit" || command == "close")
                {
                    Application.Exit();
                    return;
                }
                else if (command == "help" || command == "?")
                {
                    var helpText =
                        @"" + Environment.NewLine + 
                        " ----------------------------------------------------------------------------- " + Environment.NewLine +
                        " FluentAutomation REPL Help                                                    " + Environment.NewLine +
                        " ----------------------------------------------------- | --------------------- " + Environment.NewLine +
                        " Actions:                                              |  Other Commands: " + Environment.NewLine +
                        " ----------------------------------------------------- | --------------------- " + Environment.NewLine +
                        " I.Open(url);                                          | cls / clear " + Environment.NewLine +
                        " I.Click(selector); I.Click(x, y);                     | exit " + Environment.NewLine +
                        " I.DoubleClick(selector) / I.DoubleClick(x, y)         | help " + Environment.NewLine +
                        " I.RightClick(selector) / I.RightClick(x, y)           | " + Environment.NewLine +
                        " I.Hover(selector) / I.Hover(x, y)                     | " + Environment.NewLine +
                        " I.Focus(selector)                                     | " + Environment.NewLine +
                        " I.Select(value).From(selector)                        | " + Environment.NewLine +
                        " I.Drag(selector).To(selector) / I.Drag(x, y).To(x, y) | " + Environment.NewLine +
                        " I.Wait(seconds) / I.Wait(TimeSpan)                    | " + Environment.NewLine +
                        " I.WaitUntil(() => expressionSucceeds)                 | " + Environment.NewLine +
                        " I.Find(selector)                                      | " + Environment.NewLine +
                        " I.Type [disabled]                                     | " + Environment.NewLine +
                        " I.Press [disabled]                                    | " + Environment.NewLine +
                        " ----------------------------------------------------- | " + Environment.NewLine +
                        " Expects:                                              | " + Environment.NewLine +
                        " ----------------------------------------------------- | " + Environment.NewLine +
                        " I.Expect.Text(text).In(selector)                      | " + Environment.NewLine +
                        " I.Expect.Value(value).In(selector)                    | " + Environment.NewLine +
                        " I.Expect.Exists(selector)                             | " + Environment.NewLine +
                        " I.Expect.Count(value).Of(selector)                    | " + Environment.NewLine +
                        " I.Expect.Class(value).On(selector)                    | " + Environment.NewLine +
                        " I.Expect.Url(url) / I.Expect.Url((url) => expression) | " + Environment.NewLine +
                        " I.Expect.True(() => expression)                       | " + Environment.NewLine +
                        " I.Expect.False(() => expression)                      | " + Environment.NewLine +
                        " I.Expect.Throws(() => expression)                     | " + Environment.NewLine +
                        " ----------------------------------------------------- | --------------------- " + Environment.NewLine + Environment.NewLine;

                    textBox.Text += helpText;
                    textBox.Select(textBox.Text.Length, 0);
                    this.UpdateCommand(textBox, "");
                    return;
                }

                if (!skipExecute)
                {
                    var scriptResult = this.repl.Execute(command);
                    if (scriptResult.CompileExceptionInfo != null)
                        textBox.Text += "\n" + scriptResult.CompileExceptionInfo.SourceException.ToString() + "\n";
                    else if (scriptResult.ExecuteExceptionInfo != null)
                        textBox.Text += "\n" + scriptResult.ExecuteExceptionInfo.SourceException.ToString() + "\n";
                    else if (this.viewModel.Url == null)
                        if (this.hasOpenBrowser)
                        {
                            this.viewModel.Url = this.GetPageLocation();

                            // Edge case protection when changing browsers, first nav fails sometimes. Retry once.
                            if (this.viewModel.Url.DnsSafeHost == "")
                            {
                                this.repl.Execute(command);
                                this.viewModel.Url = this.GetPageLocation();
                            }
                        }

                    if (scriptResult.ReturnValue != null)
                        textBox.Text += "\n" + JsonConvert.SerializeObject(scriptResult.ReturnValue) + "\n";
                }

                textBox.Text += "\n" + this.CreateLine().ToString();
                textBox.Select(textBox.Text.Length, 0);
                this.Activate();
                this.commandIndex = this.commands.Count - 1;
            }
            else
            {
                this.commandIndex = this.commands.Count - 1;
            }
        }

        private Uri GetPageLocation()
        {
            var scriptResult = this.repl.Execute("Container.Resolve<FluentAutomation.Interfaces.ICommandProvider>().Url");
            if (scriptResult.CompileExceptionInfo != null || scriptResult.ExecuteExceptionInfo != null)
                return null;

            return new Uri(scriptResult.ReturnValue.ToString());
        }

        private StatusLine CreateLine()
        {
            return new StatusLine(this.settings, this.viewModel);
        }

        private void openSettings_Click(object sender, EventArgs e)
        {
            if (this.settingsPanel.Visible)
                this.settingsPanel.Hide();
            else
                this.settingsPanel.Show();
        }

        private void browserSelection_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                foreach (int index in browserSelection.CheckedIndices)
                {
                    browserSelection.SetItemChecked(index, false);
                }

                if (this.viewModel.Url != null)
                    this.hasOpenBrowser = false;

                var uiThreadContext = TaskScheduler.FromCurrentSynchronizationContext();

                Task.Run(() =>
                {
                    if (this.viewModel.Url != null)
                        this.repl.Execute(this.fluentGuid + ".Dispose();");

                    this.InitRepl();
                    this.SetReplBrowser(browserSelection.Items[e.Index].ToString());

                    Task.Factory.StartNew(() =>
                    {
                        this.UpdateCommand(this.consoleTextBox, "");
                    }, System.Threading.CancellationToken.None, TaskCreationOptions.None, uiThreadContext);
                });
            }
        }

        private void minimizeOnStart_CheckedChanged(object sender, EventArgs e)
        {
            this.settingsManager.MinimizeAllWindowsOnTestStart = minimizeOnStart.Checked;
        }

        private void windowWidth_TextChanged(object sender, EventArgs e)
        {
            var windowWidthText = this.windowWidth.Text;
            if (windowWidthText == "")
                this.settingsManager.WindowWidth = null;
            else
                this.settingsManager.WindowWidth = int.Parse(windowWidthText);
        }

        private void windowHeight_TextChanged(object sender, EventArgs e)
        {
            var windowHeightText = this.windowHeight.Text;
            if (windowHeightText == "")
                this.settingsManager.WindowHeight = null;
            else
                this.settingsManager.WindowHeight = int.Parse(windowHeightText);
        }

        private void defaultWait_TextChanged(object sender, EventArgs e)
        {
            this.settingsManager.DefaultWaitTimeout = TimeSpan.FromMilliseconds(double.Parse(this.defaultWait.Text));
        }

        private void defaultWaitUntil_TextChanged(object sender, EventArgs e)
        {
            this.settingsManager.DefaultWaitUntilTimeout = TimeSpan.FromMilliseconds(double.Parse(this.defaultWaitUntil.Text));
        }

        private void timeBetweenAttempts_TextChanged(object sender, EventArgs e)
        {
            this.settingsManager.DefaultWaitUntilThreadSleep = TimeSpan.FromMilliseconds(double.Parse(this.timeBetweenAttempts.Text));
        }

        private void waitOnAllCommands_CheckedChanged(object sender, EventArgs e)
        {
            this.settingsManager.WaitOnAllCommands = waitOnAllCommands.Checked;
        }

        private void waitOnAllExpects_CheckedChanged(object sender, EventArgs e)
        {
            this.settingsManager.WaitOnAllExpects = waitOnAllExpects.Checked;
        }

        private void windowWidth_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.Match(this.windowWidth.Text, @"^\d+$").Success)
                e.Cancel = true;
        }
    }
}
