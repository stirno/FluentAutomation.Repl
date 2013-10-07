namespace FluentAutomation.REPL
{
    partial class REPL
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(REPL));
            this.consoleTextBox = new System.Windows.Forms.RichTextBox();
            this.openSettings = new System.Windows.Forms.Button();
            this.settingsPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel8 = new System.Windows.Forms.FlowLayoutPanel();
            this.defaultWaitUntil = new System.Windows.Forms.MaskedTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.timeBetweenAttempts = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.waitOnAllCommands = new System.Windows.Forms.CheckBox();
            this.waitOnAllExpects = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.defaultWait = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.browserSelection = new System.Windows.Forms.CheckedListBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.windowHeight = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.flowLayoutPanel7 = new System.Windows.Forms.FlowLayoutPanel();
            this.windowWidth = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.minimizeOnStart = new System.Windows.Forms.CheckBox();
            this.settingsPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel8.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.flowLayoutPanel7.SuspendLayout();
            this.flowLayoutPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // consoleTextBox
            // 
            this.consoleTextBox.BackColor = System.Drawing.Color.Black;
            this.consoleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.consoleTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.consoleTextBox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consoleTextBox.ForeColor = System.Drawing.Color.White;
            this.consoleTextBox.Location = new System.Drawing.Point(0, 0);
            this.consoleTextBox.Name = "consoleTextBox";
            this.consoleTextBox.Size = new System.Drawing.Size(724, 390);
            this.consoleTextBox.TabIndex = 0;
            this.consoleTextBox.Text = "";
            this.consoleTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.consoleTextBox_KeyDown);
            // 
            // openSettings
            // 
            this.openSettings.BackColor = System.Drawing.Color.Transparent;
            this.openSettings.Image = ((System.Drawing.Image)(resources.GetObject("openSettings.Image")));
            this.openSettings.Location = new System.Drawing.Point(694, -1);
            this.openSettings.Name = "openSettings";
            this.openSettings.Size = new System.Drawing.Size(26, 23);
            this.openSettings.TabIndex = 1;
            this.openSettings.UseVisualStyleBackColor = false;
            this.openSettings.Click += new System.EventHandler(this.openSettings_Click);
            // 
            // settingsPanel
            // 
            this.settingsPanel.BackColor = System.Drawing.Color.Transparent;
            this.settingsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.settingsPanel.Controls.Add(this.tableLayoutPanel1);
            this.settingsPanel.Location = new System.Drawing.Point(12, 12);
            this.settingsPanel.Name = "settingsPanel";
            this.settingsPanel.Size = new System.Drawing.Size(700, 366);
            this.settingsPanel.TabIndex = 2;
            this.settingsPanel.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.94048F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.05952F));
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel4, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel6, 1, 2);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.01075F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.98925F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(692, 358);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(13, 256);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 21);
            this.label11.TabIndex = 5;
            this.label11.Text = "Other";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Browser Configuration";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 42);
            this.label2.TabIndex = 1;
            this.label2.Text = "Wait Configuration";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.61538F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.38461F));
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel8, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label14, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel3, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel1, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel2, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(147, 119);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.48485F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.51515F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(532, 119);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // flowLayoutPanel8
            // 
            this.flowLayoutPanel8.Controls.Add(this.defaultWaitUntil);
            this.flowLayoutPanel8.Controls.Add(this.label15);
            this.flowLayoutPanel8.Location = new System.Drawing.Point(187, 34);
            this.flowLayoutPanel8.Name = "flowLayoutPanel8";
            this.flowLayoutPanel8.Size = new System.Drawing.Size(200, 25);
            this.flowLayoutPanel8.TabIndex = 11;
            // 
            // defaultWaitUntil
            // 
            this.defaultWaitUntil.Location = new System.Drawing.Point(3, 3);
            this.defaultWaitUntil.Mask = "00000";
            this.defaultWaitUntil.Name = "defaultWaitUntil";
            this.defaultWaitUntil.Size = new System.Drawing.Size(82, 22);
            this.defaultWaitUntil.TabIndex = 0;
            this.defaultWaitUntil.Text = "30000";
            this.defaultWaitUntil.TextChanged += new System.EventHandler(this.defaultWaitUntil_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.SystemColors.Control;
            this.label15.Location = new System.Drawing.Point(91, 6);
            this.label15.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(90, 13);
            this.label15.TabIndex = 1;
            this.label15.Text = "(in Milliseconds)";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(3, 40);
            this.label14.Margin = new System.Windows.Forms.Padding(3, 9, 3, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(140, 13);
            this.label14.TabIndex = 10;
            this.label14.Text = "Default WaitUntil timeout";
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.timeBetweenAttempts);
            this.flowLayoutPanel3.Controls.Add(this.label7);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(187, 65);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(200, 26);
            this.flowLayoutPanel3.TabIndex = 7;
            // 
            // timeBetweenAttempts
            // 
            this.timeBetweenAttempts.Location = new System.Drawing.Point(3, 3);
            this.timeBetweenAttempts.Mask = "00000";
            this.timeBetweenAttempts.Name = "timeBetweenAttempts";
            this.timeBetweenAttempts.Size = new System.Drawing.Size(82, 22);
            this.timeBetweenAttempts.TabIndex = 0;
            this.timeBetweenAttempts.Text = "100";
            this.timeBetweenAttempts.TextChanged += new System.EventHandler(this.timeBetweenAttempts_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(91, 6);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "(in Milliseconds)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 9, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Default Wait";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 71);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 9, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Time between Attempts";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 100);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Automatically Wait on ...";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.waitOnAllCommands);
            this.flowLayoutPanel1.Controls.Add(this.waitOnAllExpects);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(187, 97);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 19);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // waitOnAllCommands
            // 
            this.waitOnAllCommands.AutoSize = true;
            this.waitOnAllCommands.Checked = true;
            this.waitOnAllCommands.CheckState = System.Windows.Forms.CheckState.Checked;
            this.waitOnAllCommands.ForeColor = System.Drawing.SystemColors.Control;
            this.waitOnAllCommands.Location = new System.Drawing.Point(3, 3);
            this.waitOnAllCommands.Name = "waitOnAllCommands";
            this.waitOnAllCommands.Size = new System.Drawing.Size(99, 17);
            this.waitOnAllCommands.TabIndex = 0;
            this.waitOnAllCommands.Text = "All Commands";
            this.waitOnAllCommands.UseVisualStyleBackColor = true;
            this.waitOnAllCommands.CheckedChanged += new System.EventHandler(this.waitOnAllCommands_CheckedChanged);
            // 
            // waitOnAllExpects
            // 
            this.waitOnAllExpects.AutoSize = true;
            this.waitOnAllExpects.Checked = true;
            this.waitOnAllExpects.CheckState = System.Windows.Forms.CheckState.Checked;
            this.waitOnAllExpects.ForeColor = System.Drawing.SystemColors.Control;
            this.waitOnAllExpects.Location = new System.Drawing.Point(108, 3);
            this.waitOnAllExpects.Name = "waitOnAllExpects";
            this.waitOnAllExpects.Size = new System.Drawing.Size(80, 17);
            this.waitOnAllExpects.TabIndex = 1;
            this.waitOnAllExpects.Text = "All Expects";
            this.waitOnAllExpects.UseVisualStyleBackColor = true;
            this.waitOnAllExpects.CheckedChanged += new System.EventHandler(this.waitOnAllExpects_CheckedChanged);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.defaultWait);
            this.flowLayoutPanel2.Controls.Add(this.label6);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(187, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(200, 25);
            this.flowLayoutPanel2.TabIndex = 6;
            // 
            // defaultWait
            // 
            this.defaultWait.Location = new System.Drawing.Point(3, 3);
            this.defaultWait.Mask = "00000";
            this.defaultWait.Name = "defaultWait";
            this.defaultWait.Size = new System.Drawing.Size(82, 22);
            this.defaultWait.TabIndex = 0;
            this.defaultWait.Text = "1000";
            this.defaultWait.TextChanged += new System.EventHandler(this.defaultWait_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(91, 6);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "(in Milliseconds)";
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.browserSelection);
            this.flowLayoutPanel4.Controls.Add(this.tableLayoutPanel3);
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(147, 13);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(532, 100);
            this.flowLayoutPanel4.TabIndex = 4;
            // 
            // browserSelection
            // 
            this.browserSelection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.browserSelection.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.browserSelection.CheckOnClick = true;
            this.browserSelection.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browserSelection.ForeColor = System.Drawing.SystemColors.Control;
            this.browserSelection.FormattingEnabled = true;
            this.browserSelection.Items.AddRange(new object[] {
            "Chrome",
            "Firefox",
            "InternetExplorer",
            "InternetExplorer64",
            "PhantomJS"});
            this.browserSelection.Location = new System.Drawing.Point(6, 3);
            this.browserSelection.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.browserSelection.Name = "browserSelection";
            this.browserSelection.Size = new System.Drawing.Size(204, 85);
            this.browserSelection.TabIndex = 3;
            this.browserSelection.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.browserSelection_ItemCheck);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.69841F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.30159F));
            this.tableLayoutPanel3.Controls.Add(this.flowLayoutPanel5, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label9, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label10, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.flowLayoutPanel7, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(233, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(20, 0, 3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.21429F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.78571F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(252, 56);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.Controls.Add(this.windowHeight);
            this.flowLayoutPanel5.Controls.Add(this.label8);
            this.flowLayoutPanel5.Location = new System.Drawing.Point(97, 27);
            this.flowLayoutPanel5.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(151, 23);
            this.flowLayoutPanel5.TabIndex = 7;
            // 
            // windowHeight
            // 
            this.windowHeight.Location = new System.Drawing.Point(3, 3);
            this.windowHeight.Mask = "00000";
            this.windowHeight.Name = "windowHeight";
            this.windowHeight.Size = new System.Drawing.Size(82, 22);
            this.windowHeight.TabIndex = 0;
            this.windowHeight.TextChanged += new System.EventHandler(this.windowHeight_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(91, 6);
            this.label8.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "(in Pixels)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(3, 6);
            this.label9.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Window Width";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(3, 33);
            this.label10.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 23);
            this.label10.TabIndex = 3;
            this.label10.Text = "Window Height";
            // 
            // flowLayoutPanel7
            // 
            this.flowLayoutPanel7.Controls.Add(this.windowWidth);
            this.flowLayoutPanel7.Controls.Add(this.label12);
            this.flowLayoutPanel7.Location = new System.Drawing.Point(97, 0);
            this.flowLayoutPanel7.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.flowLayoutPanel7.Name = "flowLayoutPanel7";
            this.flowLayoutPanel7.Size = new System.Drawing.Size(151, 24);
            this.flowLayoutPanel7.TabIndex = 6;
            // 
            // windowWidth
            // 
            this.windowWidth.Location = new System.Drawing.Point(3, 3);
            this.windowWidth.Mask = "00000";
            this.windowWidth.Name = "windowWidth";
            this.windowWidth.Size = new System.Drawing.Size(82, 22);
            this.windowWidth.TabIndex = 0;
            this.windowWidth.ValidatingType = typeof(int);
            this.windowWidth.TextChanged += new System.EventHandler(this.windowWidth_TextChanged);
            this.windowWidth.Validating += new System.ComponentModel.CancelEventHandler(this.windowWidth_Validating);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.Control;
            this.label12.Location = new System.Drawing.Point(91, 6);
            this.label12.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "(in Pixels)";
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.Controls.Add(this.minimizeOnStart);
            this.flowLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel6.Location = new System.Drawing.Point(147, 259);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Size = new System.Drawing.Size(532, 65);
            this.flowLayoutPanel6.TabIndex = 6;
            // 
            // minimizeOnStart
            // 
            this.minimizeOnStart.AutoSize = true;
            this.minimizeOnStart.ForeColor = System.Drawing.SystemColors.Control;
            this.minimizeOnStart.Location = new System.Drawing.Point(3, 3);
            this.minimizeOnStart.Name = "minimizeOnStart";
            this.minimizeOnStart.Size = new System.Drawing.Size(207, 17);
            this.minimizeOnStart.TabIndex = 0;
            this.minimizeOnStart.Text = "Minimize All Windows on Test Start";
            this.minimizeOnStart.UseVisualStyleBackColor = true;
            this.minimizeOnStart.CheckedChanged += new System.EventHandler(this.minimizeOnStart_CheckedChanged);
            // 
            // REPL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(724, 390);
            this.Controls.Add(this.openSettings);
            this.Controls.Add(this.settingsPanel);
            this.Controls.Add(this.consoleTextBox);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "REPL";
            this.Text = "FluentAutomation REPL";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.REPL_FormClosing);
            this.Load += new System.EventHandler(this.REPL_Load);
            this.settingsPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.flowLayoutPanel8.ResumeLayout(false);
            this.flowLayoutPanel8.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            this.flowLayoutPanel7.ResumeLayout(false);
            this.flowLayoutPanel7.PerformLayout();
            this.flowLayoutPanel6.ResumeLayout(false);
            this.flowLayoutPanel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox consoleTextBox;
        private System.Windows.Forms.Button openSettings;
        private System.Windows.Forms.Panel settingsPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.MaskedTextBox timeBetweenAttempts;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.CheckBox waitOnAllCommands;
        private System.Windows.Forms.CheckBox waitOnAllExpects;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.MaskedTextBox defaultWait;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.CheckedListBox browserSelection;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.MaskedTextBox windowHeight;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel7;
        private System.Windows.Forms.MaskedTextBox windowWidth;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel8;
        private System.Windows.Forms.MaskedTextBox defaultWaitUntil;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
        private System.Windows.Forms.CheckBox minimizeOnStart;

    }
}