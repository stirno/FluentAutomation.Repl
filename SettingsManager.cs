using ScriptCs.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentAutomation.REPL
{
    public class SettingsManager
    {
        private Func<string, ScriptResult> commandExecutor = null;

        public SettingsManager(Func<string, ScriptResult> commandExecutor)
        {
            this.commandExecutor = commandExecutor;
        }

        private void UpdateSetting(string settingName, string settingValue)
        {
            this.commandExecutor("FluentAutomation.Settings." + settingName + " = " + settingValue);
        }

        private int? windowWidth = null;

        public int? WindowWidth
        {
            get
            {
                if (windowWidth.HasValue)
                    return windowWidth.Value;

                return FluentAutomation.Settings.WindowWidth;
            }

            set
            {
                windowWidth = value;
                this.UpdateSetting("WindowWidth", value.ToString());
            }
        }

        private int? windowHeight = null;

        public int? WindowHeight
        {
            get
            {
                if (windowHeight.HasValue)
                    return windowHeight.Value;

                return FluentAutomation.Settings.WindowHeight;
            }

            set
            {
                windowHeight = value;
                this.UpdateSetting("WindowHeight", value.ToString());
            }
        }

        private double? defaultWaitMilliseconds = null;

        public TimeSpan DefaultWaitTimeout
        {
            get
            {
                if (defaultWaitMilliseconds.HasValue)
                    return TimeSpan.FromMilliseconds(defaultWaitMilliseconds.Value);

                return FluentAutomation.Settings.DefaultWaitTimeout;
            }

            set
            {
                defaultWaitMilliseconds = value.TotalMilliseconds;
                this.UpdateSetting("DefaultWaitTimeout", "TimeSpan.FromMilliseconds(" + defaultWaitMilliseconds.Value + ")");
            }
        }

        private double? defaultWaitUntilMilliseconds = null;

        public TimeSpan DefaultWaitUntilTimeout
        {
            get
            {
                if (defaultWaitUntilMilliseconds.HasValue)
                    return TimeSpan.FromMilliseconds(defaultWaitUntilMilliseconds.Value);

                return FluentAutomation.Settings.DefaultWaitUntilTimeout;
            }

            set
            {
                defaultWaitUntilMilliseconds = value.TotalMilliseconds;
                this.UpdateSetting("DefaultWaitUntilTimeout", "TimeSpan.FromMilliseconds(" + defaultWaitUntilMilliseconds.Value + ")");
            }
        }

        private double? timeBetweenAttempts = null;

        public TimeSpan DefaultWaitUntilThreadSleep
        {
            get
            {
                if (timeBetweenAttempts.HasValue)
                    return TimeSpan.FromMilliseconds(timeBetweenAttempts.Value);

                return FluentAutomation.Settings.DefaultWaitUntilThreadSleep;
            }

            set
            {
                timeBetweenAttempts = value.TotalMilliseconds;
                this.UpdateSetting("DefaultWaitUntilThreadSleep", "TimeSpan.FromMilliseconds(" + timeBetweenAttempts.Value + ")");
            }
        }

        private bool? waitOnAllCommands = null;

        public bool WaitOnAllCommands
        {
            get
            {
                if (waitOnAllCommands.HasValue)
                    return waitOnAllCommands.Value;

                return FluentAutomation.Settings.WaitOnAllCommands;
            }

            set
            {
                waitOnAllCommands = value;
                this.UpdateSetting("WaitOnAllCommands", value.ToString());
            }
        }

        private bool? waitOnAllExpects = null;

        public bool WaitOnAllExpects
        {
            get
            {
                if (waitOnAllExpects.HasValue)
                    return waitOnAllExpects.Value;

                return FluentAutomation.Settings.WaitOnAllExpects;
            }

            set
            {
                waitOnAllExpects = value;
                this.UpdateSetting("WaitOnAllExpects", value.ToString());
            }
        }

        private bool? minimizeAllWindowsOnTestStart = null;

        public bool MinimizeAllWindowsOnTestStart
        {
            get
            {
                if (minimizeAllWindowsOnTestStart.HasValue)
                    return minimizeAllWindowsOnTestStart.Value;

                return FluentAutomation.Settings.MinimizeAllWindowsOnTestStart;
            }

            set
            {
                minimizeAllWindowsOnTestStart = value;
                this.UpdateSetting("MinimizeAllWindowsOnTestStart", value.ToString());
            }
        }
    }
}
