namespace BookGame
{
    partial class FindingCallNumbers
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
            this.components = new System.ComponentModel.Container();
            this.ExitBt = new System.Windows.Forms.Button();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.CallTimerLB = new System.Windows.Forms.Label();
            this.TimeTicker = new System.Windows.Forms.Timer(this.components);
            this.ScoringLB = new System.Windows.Forms.Label();
            this.PlayBT = new System.Windows.Forms.Button();
            this.CloseBT = new System.Windows.Forms.Button();
            this.AboutBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ExitBt
            // 
            this.ExitBt.BackColor = System.Drawing.Color.Red;
            this.ExitBt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ExitBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBt.ForeColor = System.Drawing.Color.Black;
            this.ExitBt.Location = new System.Drawing.Point(12, 12);
            this.ExitBt.Name = "ExitBt";
            this.ExitBt.Size = new System.Drawing.Size(89, 45);
            this.ExitBt.TabIndex = 0;
            this.ExitBt.Text = "Exit";
            this.ExitBt.UseVisualStyleBackColor = false;
            this.ExitBt.Click += new System.EventHandler(this.ExitBt_Click);
            // 
            // lblQuestion
            // 
            this.lblQuestion.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(164, 208);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(611, 52);
            this.lblQuestion.TabIndex = 1;
            this.lblQuestion.Text = "Question";
            this.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(71, 332);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(291, 69);
            this.button1.TabIndex = 2;
            this.button1.Tag = "1";
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.checkAnswerEvent);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(583, 332);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(291, 69);
            this.button2.TabIndex = 3;
            this.button2.Tag = "2";
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.checkAnswerEvent);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(71, 437);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(291, 69);
            this.button3.TabIndex = 4;
            this.button3.Tag = "3";
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.checkAnswerEvent);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(583, 437);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(291, 69);
            this.button4.TabIndex = 5;
            this.button4.Tag = "4";
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.checkAnswerEvent);
            // 
            // CallTimerLB
            // 
            this.CallTimerLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CallTimerLB.ForeColor = System.Drawing.Color.Red;
            this.CallTimerLB.Location = new System.Drawing.Point(362, 35);
            this.CallTimerLB.Name = "CallTimerLB";
            this.CallTimerLB.Size = new System.Drawing.Size(213, 52);
            this.CallTimerLB.TabIndex = 6;
            this.CallTimerLB.Text = "Time: 60";
            // 
            // TimeTicker
            // 
            this.TimeTicker.Interval = 1000;
            this.TimeTicker.Tick += new System.EventHandler(this.TimeTicker_Tick);
            // 
            // ScoringLB
            // 
            this.ScoringLB.AutoSize = true;
            this.ScoringLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoringLB.ForeColor = System.Drawing.Color.DarkBlue;
            this.ScoringLB.Location = new System.Drawing.Point(372, 109);
            this.ScoringLB.Name = "ScoringLB";
            this.ScoringLB.Size = new System.Drawing.Size(180, 46);
            this.ScoringLB.TabIndex = 7;
            this.ScoringLB.Text = "PB:0000";
            // 
            // PlayBT
            // 
            this.PlayBT.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayBT.ForeColor = System.Drawing.Color.Orange;
            this.PlayBT.Location = new System.Drawing.Point(390, 167);
            this.PlayBT.Name = "PlayBT";
            this.PlayBT.Size = new System.Drawing.Size(152, 52);
            this.PlayBT.TabIndex = 8;
            this.PlayBT.Text = "Ready?";
            this.PlayBT.UseVisualStyleBackColor = true;
            this.PlayBT.Click += new System.EventHandler(this.PlayBT_Click);
            // 
            // CloseBT
            // 
            this.CloseBT.BackColor = System.Drawing.Color.Red;
            this.CloseBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CloseBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBT.ForeColor = System.Drawing.Color.Black;
            this.CloseBT.Location = new System.Drawing.Point(893, 12);
            this.CloseBT.Name = "CloseBT";
            this.CloseBT.Size = new System.Drawing.Size(89, 45);
            this.CloseBT.TabIndex = 9;
            this.CloseBT.Text = "Close";
            this.CloseBT.UseVisualStyleBackColor = false;
            this.CloseBT.Click += new System.EventHandler(this.CloseBT_Click);
            // 
            // AboutBT
            // 
            this.AboutBT.BackColor = System.Drawing.Color.LightSeaGreen;
            this.AboutBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AboutBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AboutBT.ForeColor = System.Drawing.Color.Black;
            this.AboutBT.Location = new System.Drawing.Point(143, 12);
            this.AboutBT.Name = "AboutBT";
            this.AboutBT.Size = new System.Drawing.Size(89, 45);
            this.AboutBT.TabIndex = 10;
            this.AboutBT.Text = "About";
            this.AboutBT.UseVisualStyleBackColor = false;
            this.AboutBT.Click += new System.EventHandler(this.AboutBT_Click);
            // 
            // FindingCallNumbers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(994, 550);
            this.Controls.Add(this.AboutBT);
            this.Controls.Add(this.CloseBT);
            this.Controls.Add(this.PlayBT);
            this.Controls.Add(this.ScoringLB);
            this.Controls.Add(this.CallTimerLB);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.ExitBt);
            this.Name = "FindingCallNumbers";
            this.Text = "FindingCallNumbers";
            this.Load += new System.EventHandler(this.FindingCallNumbers_Load);
            this.Click += new System.EventHandler(this.checkAnswerEvent);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExitBt;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label CallTimerLB;
        private System.Windows.Forms.Timer TimeTicker;
        private System.Windows.Forms.Label ScoringLB;
        private System.Windows.Forms.Button PlayBT;
        private System.Windows.Forms.Button CloseBT;
        private System.Windows.Forms.Button AboutBT;
    }
}