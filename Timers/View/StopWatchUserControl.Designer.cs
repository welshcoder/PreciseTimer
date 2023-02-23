namespace CustomTimers.View
{
    partial class StopWatchUserControl
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSendToCountdown = new System.Windows.Forms.Button();
            this.nudDivisor = new System.Windows.Forms.NumericUpDown();
            this.lblDivisor = new System.Windows.Forms.Label();
            this.ucTimeDisplay = new CustomTimers.View.TimeDisplayUserControl();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDivisor)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.ucTimeDisplay, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(479, 246);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnPause);
            this.panel3.Controls.Add(this.btnStart);
            this.panel3.Controls.Add(this.btnReset);
            this.panel3.Controls.Add(this.btnStop);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 68);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(473, 125);
            this.panel3.TabIndex = 7;
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(149, 11);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(75, 37);
            this.btnPause.TabIndex = 9;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(56, 11);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 37);
            this.btnStart.TabIndex = 8;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(333, 11);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 37);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(240, 11);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 37);
            this.btnStop.TabIndex = 10;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnSendToCountdown, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.nudDivisor, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblDivisor, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 199);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(473, 44);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // btnSendToCountdown
            // 
            this.btnSendToCountdown.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSendToCountdown.Location = new System.Drawing.Point(11, 7);
            this.btnSendToCountdown.Name = "btnSendToCountdown";
            this.btnSendToCountdown.Size = new System.Drawing.Size(126, 29);
            this.btnSendToCountdown.TabIndex = 0;
            this.btnSendToCountdown.Text = "<< Send to Countdown";
            this.btnSendToCountdown.UseVisualStyleBackColor = true;
            this.btnSendToCountdown.Click += new System.EventHandler(this.btnSendToCountdown_Click);
            // 
            // nudDivisor
            // 
            this.nudDivisor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nudDivisor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudDivisor.Location = new System.Drawing.Point(327, 9);
            this.nudDivisor.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDivisor.Name = "nudDivisor";
            this.nudDivisor.Size = new System.Drawing.Size(60, 26);
            this.nudDivisor.TabIndex = 1;
            this.nudDivisor.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblDivisor
            // 
            this.lblDivisor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDivisor.AutoSize = true;
            this.lblDivisor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDivisor.Location = new System.Drawing.Point(152, 14);
            this.lblDivisor.Name = "lblDivisor";
            this.lblDivisor.Size = new System.Drawing.Size(169, 16);
            this.lblDivisor.TabIndex = 2;
            this.lblDivisor.Text = "...after applying a divisor of:";
            // 
            // ucTimeDisplay
            // 
            this.ucTimeDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucTimeDisplay.Location = new System.Drawing.Point(3, 3);
            this.ucTimeDisplay.Name = "ucTimeDisplay";
            this.ucTimeDisplay.Size = new System.Drawing.Size(473, 59);
            this.ucTimeDisplay.TabIndex = 9;
            // 
            // StopWatchUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "StopWatchUserControl";
            this.Size = new System.Drawing.Size(479, 246);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDivisor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnSendToCountdown;
        private System.Windows.Forms.NumericUpDown nudDivisor;
        private System.Windows.Forms.Label lblDivisor;
        private TimeDisplayUserControl ucTimeDisplay;
    }
}
