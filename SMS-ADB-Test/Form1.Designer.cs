namespace SMS_ADB_Test
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label_mydevice = new System.Windows.Forms.Label();
            this.groupbox_main = new System.Windows.Forms.GroupBox();
            this.groupbox_repeat = new System.Windows.Forms.GroupBox();
            this.label_every = new System.Windows.Forms.Label();
            this.RepeatIntervalBox = new System.Windows.Forms.ComboBox();
            this.label_repetitions = new System.Windows.Forms.Label();
            this.NumTimesBox = new System.Windows.Forms.ComboBox();
            this.TimeUnitsBox = new System.Windows.Forms.ComboBox();
            this.checkbox_repeat = new System.Windows.Forms.CheckBox();
            this.label_messagetext = new System.Windows.Forms.Label();
            this.label_phonenumber = new System.Windows.Forms.Label();
            this.SendButton = new System.Windows.Forms.Button();
            this.MessageText = new System.Windows.Forms.TextBox();
            this.PhoneNumber = new System.Windows.Forms.TextBox();
            this.label_for = new System.Windows.Forms.Label();
            this.groupbox_main.SuspendLayout();
            this.groupbox_repeat.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_mydevice
            // 
            this.label_mydevice.AutoSize = true;
            this.label_mydevice.ForeColor = System.Drawing.Color.Red;
            this.label_mydevice.Location = new System.Drawing.Point(30, 30);
            this.label_mydevice.Name = "label_mydevice";
            this.label_mydevice.Size = new System.Drawing.Size(336, 17);
            this.label_mydevice.TabIndex = 13;
            this.label_mydevice.Text = "Please connect a device and restart this application!";
            // 
            // groupbox_main
            // 
            this.groupbox_main.Controls.Add(this.groupbox_repeat);
            this.groupbox_main.Controls.Add(this.checkbox_repeat);
            this.groupbox_main.Controls.Add(this.label_messagetext);
            this.groupbox_main.Controls.Add(this.label_phonenumber);
            this.groupbox_main.Controls.Add(this.SendButton);
            this.groupbox_main.Controls.Add(this.MessageText);
            this.groupbox_main.Controls.Add(this.PhoneNumber);
            this.groupbox_main.Enabled = false;
            this.groupbox_main.Location = new System.Drawing.Point(12, 50);
            this.groupbox_main.Name = "groupbox_main";
            this.groupbox_main.Size = new System.Drawing.Size(420, 292);
            this.groupbox_main.TabIndex = 14;
            this.groupbox_main.TabStop = false;
            // 
            // groupbox_repeat
            // 
            this.groupbox_repeat.Controls.Add(this.label_for);
            this.groupbox_repeat.Controls.Add(this.label_every);
            this.groupbox_repeat.Controls.Add(this.RepeatIntervalBox);
            this.groupbox_repeat.Controls.Add(this.label_repetitions);
            this.groupbox_repeat.Controls.Add(this.NumTimesBox);
            this.groupbox_repeat.Controls.Add(this.TimeUnitsBox);
            this.groupbox_repeat.Enabled = false;
            this.groupbox_repeat.Location = new System.Drawing.Point(31, 135);
            this.groupbox_repeat.Name = "groupbox_repeat";
            this.groupbox_repeat.Size = new System.Drawing.Size(356, 57);
            this.groupbox_repeat.TabIndex = 19;
            this.groupbox_repeat.TabStop = false;
            // 
            // label_every
            // 
            this.label_every.AutoSize = true;
            this.label_every.Location = new System.Drawing.Point(6, 18);
            this.label_every.Name = "label_every";
            this.label_every.Size = new System.Drawing.Size(43, 17);
            this.label_every.TabIndex = 7;
            this.label_every.Text = "every";
            // 
            // RepeatIntervalBox
            // 
            this.RepeatIntervalBox.FormattingEnabled = true;
            this.RepeatIntervalBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.RepeatIntervalBox.Location = new System.Drawing.Point(54, 14);
            this.RepeatIntervalBox.Name = "RepeatIntervalBox";
            this.RepeatIntervalBox.Size = new System.Drawing.Size(42, 24);
            this.RepeatIntervalBox.TabIndex = 6;
            // 
            // label_repetitions
            // 
            this.label_repetitions.AutoSize = true;
            this.label_repetitions.Location = new System.Drawing.Point(272, 18);
            this.label_repetitions.Name = "label_repetitions";
            this.label_repetitions.Size = new System.Drawing.Size(74, 17);
            this.label_repetitions.TabIndex = 8;
            this.label_repetitions.Text = "repetitions";
            // 
            // NumTimesBox
            // 
            this.NumTimesBox.FormattingEnabled = true;
            this.NumTimesBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.NumTimesBox.Location = new System.Drawing.Point(227, 14);
            this.NumTimesBox.Name = "NumTimesBox";
            this.NumTimesBox.Size = new System.Drawing.Size(40, 24);
            this.NumTimesBox.TabIndex = 10;
            // 
            // TimeUnitsBox
            // 
            this.TimeUnitsBox.FormattingEnabled = true;
            this.TimeUnitsBox.Items.AddRange(new object[] {
            "second(s)",
            "minute(s)",
            "hour(s)"});
            this.TimeUnitsBox.Location = new System.Drawing.Point(101, 14);
            this.TimeUnitsBox.Name = "TimeUnitsBox";
            this.TimeUnitsBox.Size = new System.Drawing.Size(91, 24);
            this.TimeUnitsBox.TabIndex = 9;
            // 
            // checkbox_repeat
            // 
            this.checkbox_repeat.AutoSize = true;
            this.checkbox_repeat.Location = new System.Drawing.Point(149, 108);
            this.checkbox_repeat.Name = "checkbox_repeat";
            this.checkbox_repeat.Size = new System.Drawing.Size(76, 21);
            this.checkbox_repeat.TabIndex = 18;
            this.checkbox_repeat.Text = "Repeat";
            this.checkbox_repeat.UseVisualStyleBackColor = true;
            this.checkbox_repeat.CheckedChanged += new System.EventHandler(this.checkbox_repeat_CheckedChanged);
            // 
            // label_messagetext
            // 
            this.label_messagetext.AutoSize = true;
            this.label_messagetext.Location = new System.Drawing.Point(28, 72);
            this.label_messagetext.Name = "label_messagetext";
            this.label_messagetext.Size = new System.Drawing.Size(69, 17);
            this.label_messagetext.TabIndex = 17;
            this.label_messagetext.Text = "Message:";
            // 
            // label_phonenumber
            // 
            this.label_phonenumber.AutoSize = true;
            this.label_phonenumber.Location = new System.Drawing.Point(28, 44);
            this.label_phonenumber.Name = "label_phonenumber";
            this.label_phonenumber.Size = new System.Drawing.Size(71, 17);
            this.label_phonenumber.TabIndex = 16;
            this.label_phonenumber.Text = "Recipient:";
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(148, 212);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(93, 36);
            this.SendButton.TabIndex = 15;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // MessageText
            // 
            this.MessageText.Location = new System.Drawing.Point(126, 69);
            this.MessageText.Multiline = true;
            this.MessageText.Name = "MessageText";
            this.MessageText.Size = new System.Drawing.Size(173, 22);
            this.MessageText.TabIndex = 13;
            this.MessageText.DoubleClick += new System.EventHandler(this.MessageText_ExpandedView);
            this.MessageText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MessageText_MinimizedView);
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.Location = new System.Drawing.Point(126, 41);
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Size = new System.Drawing.Size(173, 22);
            this.PhoneNumber.TabIndex = 14;
            // 
            // label_for
            // 
            this.label_for.AutoSize = true;
            this.label_for.Location = new System.Drawing.Point(197, 18);
            this.label_for.Name = "label_for";
            this.label_for.Size = new System.Drawing.Size(25, 17);
            this.label_for.TabIndex = 11;
            this.label_for.Text = "for";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 346);
            this.Controls.Add(this.groupbox_main);
            this.Controls.Add(this.label_mydevice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Send Texts via ADB";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupbox_main.ResumeLayout(false);
            this.groupbox_main.PerformLayout();
            this.groupbox_repeat.ResumeLayout(false);
            this.groupbox_repeat.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_mydevice;
        private System.Windows.Forms.GroupBox groupbox_main;
        private System.Windows.Forms.GroupBox groupbox_repeat;
        private System.Windows.Forms.Label label_every;
        private System.Windows.Forms.ComboBox RepeatIntervalBox;
        private System.Windows.Forms.Label label_repetitions;
        private System.Windows.Forms.ComboBox NumTimesBox;
        private System.Windows.Forms.ComboBox TimeUnitsBox;
        private System.Windows.Forms.CheckBox checkbox_repeat;
        private System.Windows.Forms.Label label_messagetext;
        private System.Windows.Forms.Label label_phonenumber;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.TextBox MessageText;
        private System.Windows.Forms.TextBox PhoneNumber;
        private System.Windows.Forms.Label label_for;
    }
}

