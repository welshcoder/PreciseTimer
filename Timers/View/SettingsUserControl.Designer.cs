using CustomTimers.Common;
using System.Windows.Forms;

namespace CustomTimers.View
{
    public partial class SettingsUserControl : UserControl, IMementoContainer
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxIsTopMost = new System.Windows.Forms.CheckBox();
            this.label42 = new System.Windows.Forms.Label();
            this.cbxIntervalUnit = new System.Windows.Forms.ComboBox();
            this.cbxHighResolution = new System.Windows.Forms.CheckBox();
            this.nudInterval = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.cbxCountdownMessageEnabled = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nudLastSeconds = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCountdownSound = new System.Windows.Forms.Button();
            this.txtCountdownSound = new System.Windows.Forms.TextBox();
            this.cbxCountdownSound = new System.Windows.Forms.CheckBox();
            this.txtSound = new System.Windows.Forms.TextBox();
            this.btnBrowseSound = new System.Windows.Forms.Button();
            this.cbxSoundEnabled = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudInterval)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLastSeconds)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.cbxIsTopMost);
            this.groupBox1.Controls.Add(this.label42);
            this.groupBox1.Controls.Add(this.cbxIntervalUnit);
            this.groupBox1.Controls.Add(this.cbxHighResolution);
            this.groupBox1.Controls.Add(this.nudInterval);
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(591, 87);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "General App Settings";
            // 
            // cbxIsTopMost
            // 
            this.cbxIsTopMost.AutoSize = true;
            this.cbxIsTopMost.Checked = true;
            this.cbxIsTopMost.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxIsTopMost.Location = new System.Drawing.Point(20, 54);
            this.cbxIsTopMost.Name = "cbxIsTopMost";
            this.cbxIsTopMost.Size = new System.Drawing.Size(96, 17);
            this.cbxIsTopMost.TabIndex = 15;
            this.cbxIsTopMost.Text = "Always on Top";
            this.cbxIsTopMost.UseVisualStyleBackColor = false;
            this.cbxIsTopMost.CheckedChanged += new System.EventHandler(this.cbxIsTopMost_CheckedChanged);
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(17, 22);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(42, 13);
            this.label42.TabIndex = 11;
            this.label42.Text = "Interval";
            this.label42.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbxIntervalUnit
            // 
            this.cbxIntervalUnit.FormattingEnabled = true;
            this.cbxIntervalUnit.Location = new System.Drawing.Point(139, 19);
            this.cbxIntervalUnit.Name = "cbxIntervalUnit";
            this.cbxIntervalUnit.Size = new System.Drawing.Size(94, 21);
            this.cbxIntervalUnit.TabIndex = 12;
            this.cbxIntervalUnit.SelectedIndexChanged += new System.EventHandler(this.cbxIntervalUnit_SelectedIndexChanged);
            // 
            // cbxHighResolution
            // 
            this.cbxHighResolution.AutoSize = true;
            this.cbxHighResolution.Location = new System.Drawing.Point(269, 21);
            this.cbxHighResolution.Name = "cbxHighResolution";
            this.cbxHighResolution.Size = new System.Drawing.Size(130, 17);
            this.cbxHighResolution.TabIndex = 13;
            this.cbxHighResolution.Text = "High Resolution Timer";
            this.cbxHighResolution.UseVisualStyleBackColor = true;
            this.cbxHighResolution.CheckedChanged += new System.EventHandler(this.cbxHighResolution_CheckedChanged);
            // 
            // nudInterval
            // 
            this.nudInterval.Location = new System.Drawing.Point(66, 19);
            this.nudInterval.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudInterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudInterval.Name = "nudInterval";
            this.nudInterval.Size = new System.Drawing.Size(67, 20);
            this.nudInterval.TabIndex = 14;
            this.nudInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudInterval.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudInterval.ValueChanged += new System.EventHandler(this.nudInterval_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.txtMessage);
            this.groupBox2.Controls.Add(this.cbxCountdownMessageEnabled);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.nudLastSeconds);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnCountdownSound);
            this.groupBox2.Controls.Add(this.txtCountdownSound);
            this.groupBox2.Controls.Add(this.cbxCountdownSound);
            this.groupBox2.Controls.Add(this.txtSound);
            this.groupBox2.Controls.Add(this.btnBrowseSound);
            this.groupBox2.Controls.Add(this.cbxSoundEnabled);
            this.groupBox2.Location = new System.Drawing.Point(4, 97);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(591, 147);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Countdown Timer Settings";
            // 
            // txtMessage
            // 
            this.txtMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMessage.Enabled = false;
            this.txtMessage.Location = new System.Drawing.Point(139, 117);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(443, 20);
            this.txtMessage.TabIndex = 15;
            this.txtMessage.Text = "Time is Up!";
            this.txtMessage.TextChanged += new System.EventHandler(this.txtMessage_TextChanged);
            // 
            // cbxCountdownMessageEnabled
            // 
            this.cbxCountdownMessageEnabled.AutoSize = true;
            this.cbxCountdownMessageEnabled.Location = new System.Drawing.Point(20, 119);
            this.cbxCountdownMessageEnabled.Name = "cbxCountdownMessageEnabled";
            this.cbxCountdownMessageEnabled.Size = new System.Drawing.Size(105, 17);
            this.cbxCountdownMessageEnabled.TabIndex = 16;
            this.cbxCountdownMessageEnabled.Text = "Ending Message";
            this.cbxCountdownMessageEnabled.UseVisualStyleBackColor = true;
            this.cbxCountdownMessageEnabled.CheckedChanged += new System.EventHandler(this.cbxCountdownMessageEnabled_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(285, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "seconds.";
            // 
            // nudLastSeconds
            // 
            this.nudLastSeconds.Location = new System.Drawing.Point(235, 79);
            this.nudLastSeconds.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLastSeconds.Name = "nudLastSeconds";
            this.nudLastSeconds.Size = new System.Drawing.Size(44, 20);
            this.nudLastSeconds.TabIndex = 13;
            this.nudLastSeconds.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudLastSeconds.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLastSeconds.ValueChanged += new System.EventHandler(this.nudLastSeconds_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Sound for the last";
            // 
            // btnCountdownSound
            // 
            this.btnCountdownSound.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCountdownSound.Location = new System.Drawing.Point(548, 52);
            this.btnCountdownSound.Name = "btnCountdownSound";
            this.btnCountdownSound.Size = new System.Drawing.Size(34, 23);
            this.btnCountdownSound.TabIndex = 11;
            this.btnCountdownSound.Text = "...";
            this.btnCountdownSound.UseVisualStyleBackColor = true;
            this.btnCountdownSound.Click += new System.EventHandler(this.btnCountdownSound_Click);
            // 
            // txtCountdownSound
            // 
            this.txtCountdownSound.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCountdownSound.Location = new System.Drawing.Point(139, 54);
            this.txtCountdownSound.Name = "txtCountdownSound";
            this.txtCountdownSound.Size = new System.Drawing.Size(403, 20);
            this.txtCountdownSound.TabIndex = 10;
            this.txtCountdownSound.TextChanged += new System.EventHandler(this.txtCountdownSound_TextChanged);
            // 
            // cbxCountdownSound
            // 
            this.cbxCountdownSound.AutoSize = true;
            this.cbxCountdownSound.Location = new System.Drawing.Point(20, 56);
            this.cbxCountdownSound.Name = "cbxCountdownSound";
            this.cbxCountdownSound.Size = new System.Drawing.Size(114, 17);
            this.cbxCountdownSound.TabIndex = 9;
            this.cbxCountdownSound.Text = "Countdown Sound";
            this.cbxCountdownSound.UseVisualStyleBackColor = true;
            this.cbxCountdownSound.CheckedChanged += new System.EventHandler(this.cbxCountdownSound_CheckedChanged);
            // 
            // txtSound
            // 
            this.txtSound.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSound.Location = new System.Drawing.Point(139, 19);
            this.txtSound.Name = "txtSound";
            this.txtSound.Size = new System.Drawing.Size(403, 20);
            this.txtSound.TabIndex = 6;
            this.txtSound.Text = "C:\\Windows\\Media\\Afternoon\\Windows Logoff Sound.wav";
            this.txtSound.TextChanged += new System.EventHandler(this.txtSound_TextChanged);
            // 
            // btnBrowseSound
            // 
            this.btnBrowseSound.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseSound.Location = new System.Drawing.Point(548, 17);
            this.btnBrowseSound.Name = "btnBrowseSound";
            this.btnBrowseSound.Size = new System.Drawing.Size(34, 23);
            this.btnBrowseSound.TabIndex = 7;
            this.btnBrowseSound.Text = "...";
            this.btnBrowseSound.UseVisualStyleBackColor = true;
            this.btnBrowseSound.Click += new System.EventHandler(this.btnBrowseSound_Click);
            // 
            // cbxSoundEnabled
            // 
            this.cbxSoundEnabled.AutoSize = true;
            this.cbxSoundEnabled.Checked = true;
            this.cbxSoundEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxSoundEnabled.Location = new System.Drawing.Point(20, 21);
            this.cbxSoundEnabled.Name = "cbxSoundEnabled";
            this.cbxSoundEnabled.Size = new System.Drawing.Size(93, 17);
            this.cbxSoundEnabled.TabIndex = 8;
            this.cbxSoundEnabled.Text = "Ending Sound";
            this.cbxSoundEnabled.UseVisualStyleBackColor = true;
            this.cbxSoundEnabled.CheckedChanged += new System.EventHandler(this.cbxSoundEnabled_CheckedChanged);
            // 
            // SettingsUserControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "SettingsUserControl";
            this.Size = new System.Drawing.Size(598, 302);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudInterval)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLastSeconds)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.ComboBox cbxIntervalUnit;
        private System.Windows.Forms.CheckBox cbxHighResolution;
        private System.Windows.Forms.NumericUpDown nudInterval;
        private System.Windows.Forms.CheckBox cbxIsTopMost;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSound;
        private System.Windows.Forms.Button btnBrowseSound;
        private System.Windows.Forms.CheckBox cbxSoundEnabled;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudLastSeconds;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCountdownSound;
        private System.Windows.Forms.TextBox txtCountdownSound;
        private System.Windows.Forms.CheckBox cbxCountdownSound;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.CheckBox cbxCountdownMessageEnabled;
    }
}
