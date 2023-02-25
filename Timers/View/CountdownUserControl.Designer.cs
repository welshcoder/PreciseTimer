namespace CustomTimers.View
{
    partial class CountdownUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose (bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose ();
            }
            base.Dispose (disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ()
        {
            this.tableLayoutPanel16 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel12 = new System.Windows.Forms.TableLayoutPanel();
            this.label48 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.nudHour = new System.Windows.Forms.NumericUpDown();
            this.nudMinute = new System.Windows.Forms.NumericUpDown();
            this.nudSecond = new System.Windows.Forms.NumericUpDown();
            this.nudMillisecond = new System.Windows.Forms.NumericUpDown();
            this.cbxAutoLoop = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.ucTimeDisplay = new CustomTimers.View.TimeDisplayUserControl();
            this.pbrCountdown = new System.Windows.Forms.ProgressBar();
            this.tableLayoutPanel16.SuspendLayout();
            this.tableLayoutPanel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSecond)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMillisecond)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel16
            // 
            this.tableLayoutPanel16.ColumnCount = 1;
            this.tableLayoutPanel16.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel16.Controls.Add(this.tableLayoutPanel12, 0, 0);
            this.tableLayoutPanel16.Controls.Add(this.ucTimeDisplay, 0, 1);
            this.tableLayoutPanel16.Controls.Add(this.panel3, 0, 3);
            this.tableLayoutPanel16.Controls.Add(this.pbrCountdown, 0, 2);
            this.tableLayoutPanel16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel16.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel16.Name = "tableLayoutPanel16";
            this.tableLayoutPanel16.RowCount = 4;
            this.tableLayoutPanel16.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel16.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel16.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel16.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel16.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel16.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel16.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel16.Size = new System.Drawing.Size(596, 448);
            this.tableLayoutPanel16.TabIndex = 3;
            // 
            // tableLayoutPanel12
            // 
            this.tableLayoutPanel12.ColumnCount = 9;
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel12.Controls.Add(this.label48, 7, 0);
            this.tableLayoutPanel12.Controls.Add(this.label47, 5, 0);
            this.tableLayoutPanel12.Controls.Add(this.label46, 3, 0);
            this.tableLayoutPanel12.Controls.Add(this.label45, 1, 0);
            this.tableLayoutPanel12.Controls.Add(this.label31, 0, 1);
            this.tableLayoutPanel12.Controls.Add(this.label32, 2, 1);
            this.tableLayoutPanel12.Controls.Add(this.label33, 4, 1);
            this.tableLayoutPanel12.Controls.Add(this.label34, 6, 1);
            this.tableLayoutPanel12.Controls.Add(this.nudHour, 1, 1);
            this.tableLayoutPanel12.Controls.Add(this.nudMinute, 3, 1);
            this.tableLayoutPanel12.Controls.Add(this.nudSecond, 5, 1);
            this.tableLayoutPanel12.Controls.Add(this.nudMillisecond, 7, 1);
            this.tableLayoutPanel12.Controls.Add(this.cbxAutoLoop, 8, 1);
            this.tableLayoutPanel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel12.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel12.Name = "tableLayoutPanel12";
            this.tableLayoutPanel12.RowCount = 2;
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel12.Size = new System.Drawing.Size(590, 54);
            this.tableLayoutPanel12.TabIndex = 1;
            // 
            // label48
            // 
            this.label48.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label48.AutoSize = true;
            this.label48.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label48.Location = new System.Drawing.Point(390, 3);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(59, 13);
            this.label48.TabIndex = 3;
            this.label48.Text = "Millisecond";
            // 
            // label47
            // 
            this.label47.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label47.AutoSize = true;
            this.label47.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label47.Location = new System.Drawing.Point(298, 3);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(44, 13);
            this.label47.TabIndex = 2;
            this.label47.Text = "Second";
            // 
            // label46
            // 
            this.label46.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label46.AutoSize = true;
            this.label46.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label46.Location = new System.Drawing.Point(200, 3);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(39, 13);
            this.label46.TabIndex = 1;
            this.label46.Text = "Minute";
            // 
            // label45
            // 
            this.label45.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label45.Location = new System.Drawing.Point(105, 3);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(30, 13);
            this.label45.TabIndex = 0;
            this.label45.Text = "Hour";
            this.label45.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Dock = System.Windows.Forms.DockStyle.Left;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(3, 20);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(54, 34);
            this.label31.TabIndex = 4;
            this.label31.Text = "Period";
            this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label32
            // 
            this.label32.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(163, 27);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(14, 20);
            this.label32.TabIndex = 1;
            this.label32.Text = ":";
            // 
            // label33
            // 
            this.label33.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(263, 27);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(14, 20);
            this.label33.TabIndex = 2;
            this.label33.Text = ":";
            // 
            // label34
            // 
            this.label34.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(363, 27);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(14, 20);
            this.label34.TabIndex = 3;
            this.label34.Text = ".";
            // 
            // nudHour
            // 
            this.nudHour.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nudHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudHour.Location = new System.Drawing.Point(83, 24);
            this.nudHour.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudHour.Name = "nudHour";
            this.nudHour.Size = new System.Drawing.Size(74, 26);
            this.nudHour.TabIndex = 5;
            this.nudHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nudMinute
            // 
            this.nudMinute.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nudMinute.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudMinute.Location = new System.Drawing.Point(183, 24);
            this.nudMinute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nudMinute.Name = "nudMinute";
            this.nudMinute.Size = new System.Drawing.Size(74, 26);
            this.nudMinute.TabIndex = 6;
            this.nudMinute.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nudSecond
            // 
            this.nudSecond.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nudSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudSecond.Location = new System.Drawing.Point(283, 24);
            this.nudSecond.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nudSecond.Name = "nudSecond";
            this.nudSecond.Size = new System.Drawing.Size(74, 26);
            this.nudSecond.TabIndex = 7;
            this.nudSecond.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nudMillisecond
            // 
            this.nudMillisecond.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nudMillisecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudMillisecond.Location = new System.Drawing.Point(383, 24);
            this.nudMillisecond.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nudMillisecond.Name = "nudMillisecond";
            this.nudMillisecond.Size = new System.Drawing.Size(74, 26);
            this.nudMillisecond.TabIndex = 8;
            this.nudMillisecond.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbxAutoLoop
            // 
            this.cbxAutoLoop.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cbxAutoLoop.AutoSize = true;
            this.cbxAutoLoop.Location = new System.Drawing.Point(512, 28);
            this.cbxAutoLoop.Name = "cbxAutoLoop";
            this.cbxAutoLoop.Size = new System.Drawing.Size(75, 17);
            this.cbxAutoLoop.TabIndex = 9;
            this.cbxAutoLoop.Tag = "";
            this.cbxAutoLoop.Text = "Auto Loop";
            this.cbxAutoLoop.UseVisualStyleBackColor = true;
            this.cbxAutoLoop.CheckedChanged += new System.EventHandler(this.cbxAutoLoop_CheckedChanged);
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.Controls.Add(this.btnPause);
            this.panel3.Controls.Add(this.btnStart);
            this.panel3.Controls.Add(this.btnReset);
            this.panel3.Controls.Add(this.btnStop);
            this.panel3.Location = new System.Drawing.Point(61, 288);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(473, 61);
            this.panel3.TabIndex = 6;
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(149, 11);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(75, 37);
            this.btnPause.TabIndex = 9;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.BtnPauseClick);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(56, 11);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 37);
            this.btnStart.TabIndex = 8;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStartClick);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(333, 11);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 37);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.BtnResetClick);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(240, 11);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 37);
            this.btnStop.TabIndex = 10;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.BtnStopClick);
            // 
            // ucTimeDisplay
            // 
            this.ucTimeDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucTimeDisplay.Hours = ((uint)(0u));
            this.ucTimeDisplay.Location = new System.Drawing.Point(3, 63);
            this.ucTimeDisplay.Milliseconds = ((uint)(0u));
            this.ucTimeDisplay.Minutes = ((uint)(0u));
            this.ucTimeDisplay.Name = "ucTimeDisplay";
            this.ucTimeDisplay.Seconds = ((uint)(0u));
            this.ucTimeDisplay.Size = new System.Drawing.Size(590, 104);
            this.ucTimeDisplay.TabIndex = 7;
            // 
            // pbrCountdown
            // 
            this.pbrCountdown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbrCountdown.Location = new System.Drawing.Point(3, 173);
            this.pbrCountdown.MarqueeAnimationSpeed = 0;
            this.pbrCountdown.Name = "pbrCountdown";
            this.pbrCountdown.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pbrCountdown.RightToLeftLayout = true;
            this.pbrCountdown.Size = new System.Drawing.Size(590, 14);
            this.pbrCountdown.Step = 1;
            this.pbrCountdown.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbrCountdown.TabIndex = 8;
            // 
            // CountdownUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel16);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "CountdownUserControl";
            this.Size = new System.Drawing.Size(596, 448);
            this.tableLayoutPanel16.ResumeLayout(false);
            this.tableLayoutPanel12.ResumeLayout(false);
            this.tableLayoutPanel12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSecond)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMillisecond)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel16;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel12;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.NumericUpDown nudHour;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.NumericUpDown nudMinute;
        private System.Windows.Forms.NumericUpDown nudSecond;
        private System.Windows.Forms.NumericUpDown nudMillisecond;
        private System.Windows.Forms.CheckBox cbxAutoLoop;
        private TimeDisplayUserControl ucTimeDisplay;
        private System.Windows.Forms.ProgressBar pbrCountdown;
    }
}
