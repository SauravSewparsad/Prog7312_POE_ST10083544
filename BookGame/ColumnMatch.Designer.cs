namespace BookGame
{
    partial class ColumnMatch
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
            this.TimerLB = new System.Windows.Forms.Label();
            this.ScoreLB = new System.Windows.Forms.Label();
            this.CallNumbersListBox = new System.Windows.Forms.ListBox();
            this.DescriptionListBox = new System.Windows.Forms.ListBox();
            this.CheckBT = new System.Windows.Forms.Button();
            this.ResetBT = new System.Windows.Forms.Button();
            this.BackBT = new System.Windows.Forms.Button();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.AboutBT = new System.Windows.Forms.Button();
            this.CloseBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TimerLB
            // 
            this.TimerLB.AutoSize = true;
            this.TimerLB.BackColor = System.Drawing.Color.Transparent;
            this.TimerLB.Font = new System.Drawing.Font("Yu Gothic UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimerLB.ForeColor = System.Drawing.Color.Black;
            this.TimerLB.Location = new System.Drawing.Point(653, 35);
            this.TimerLB.Name = "TimerLB";
            this.TimerLB.Size = new System.Drawing.Size(262, 38);
            this.TimerLB.TabIndex = 1;
            this.TimerLB.Text = "Time remaining: 30";
            // 
            // ScoreLB
            // 
            this.ScoreLB.AutoSize = true;
            this.ScoreLB.BackColor = System.Drawing.Color.Transparent;
            this.ScoreLB.Font = new System.Drawing.Font("Segoe UI Historic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreLB.Location = new System.Drawing.Point(662, 85);
            this.ScoreLB.Name = "ScoreLB";
            this.ScoreLB.Size = new System.Drawing.Size(123, 38);
            this.ScoreLB.TabIndex = 2;
            this.ScoreLB.Text = "Score: 0";
            // 
            // CallNumbersListBox
            // 
            this.CallNumbersListBox.BackColor = System.Drawing.Color.Crimson;
            this.CallNumbersListBox.Font = new System.Drawing.Font("Mongolian Baiti", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CallNumbersListBox.FormattingEnabled = true;
            this.CallNumbersListBox.ItemHeight = 29;
            this.CallNumbersListBox.Items.AddRange(new object[] {
            "100",
            "200",
            "300",
            "400",
            "500",
            "600",
            "700",
            "800",
            "900"});
            this.CallNumbersListBox.Location = new System.Drawing.Point(50, 152);
            this.CallNumbersListBox.Name = "CallNumbersListBox";
            this.CallNumbersListBox.Size = new System.Drawing.Size(324, 294);
            this.CallNumbersListBox.TabIndex = 3;
            this.CallNumbersListBox.SelectedIndexChanged += new System.EventHandler(this.CallNumbersListBox_SelectedIndexChanged);
            // 
            // DescriptionListBox
            // 
            this.DescriptionListBox.BackColor = System.Drawing.Color.SlateBlue;
            this.DescriptionListBox.Font = new System.Drawing.Font("Mongolian Baiti", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionListBox.FormattingEnabled = true;
            this.DescriptionListBox.ItemHeight = 29;
            this.DescriptionListBox.Items.AddRange(new object[] {
            "Philosophy and Psychology",
            "Religion",
            "Social Sciences",
            "Language",
            "Natural Sciences and Mathematics",
            "Technology",
            "Arts and Recreation",
            "Literature",
            "History and Geography"});
            this.DescriptionListBox.Location = new System.Drawing.Point(533, 152);
            this.DescriptionListBox.Name = "DescriptionListBox";
            this.DescriptionListBox.Size = new System.Drawing.Size(448, 294);
            this.DescriptionListBox.TabIndex = 4;
            this.DescriptionListBox.SelectedIndexChanged += new System.EventHandler(this.DescriptionListBox_SelectedIndexChanged);
            // 
            // CheckBT
            // 
            this.CheckBT.BackColor = System.Drawing.Color.Lime;
            this.CheckBT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CheckBT.Location = new System.Drawing.Point(50, 469);
            this.CheckBT.Name = "CheckBT";
            this.CheckBT.Size = new System.Drawing.Size(143, 54);
            this.CheckBT.TabIndex = 5;
            this.CheckBT.Text = "Check Answer";
            this.CheckBT.UseVisualStyleBackColor = false;
            this.CheckBT.Click += new System.EventHandler(this.CheckBT_Click);
            // 
            // ResetBT
            // 
            this.ResetBT.BackColor = System.Drawing.Color.Crimson;
            this.ResetBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetBT.Location = new System.Drawing.Point(391, 469);
            this.ResetBT.Name = "ResetBT";
            this.ResetBT.Size = new System.Drawing.Size(143, 54);
            this.ResetBT.TabIndex = 6;
            this.ResetBT.Text = "Start or Reset";
            this.ResetBT.UseVisualStyleBackColor = false;
            this.ResetBT.Click += new System.EventHandler(this.ResetBT_Click);
            // 
            // BackBT
            // 
            this.BackBT.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BackBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackBT.Location = new System.Drawing.Point(673, 469);
            this.BackBT.Name = "BackBT";
            this.BackBT.Size = new System.Drawing.Size(143, 54);
            this.BackBT.TabIndex = 7;
            this.BackBT.Text = "Back Home";
            this.BackBT.UseVisualStyleBackColor = false;
            this.BackBT.Click += new System.EventHandler(this.BackBT_Click);
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 1000;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // AboutBT
            // 
            this.AboutBT.BackColor = System.Drawing.Color.LightSeaGreen;
            this.AboutBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AboutBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutBT.Location = new System.Drawing.Point(25, 12);
            this.AboutBT.Name = "AboutBT";
            this.AboutBT.Size = new System.Drawing.Size(143, 54);
            this.AboutBT.TabIndex = 8;
            this.AboutBT.Text = "About";
            this.AboutBT.UseVisualStyleBackColor = false;
            this.AboutBT.Click += new System.EventHandler(this.AboutBT_Click);
            // 
            // CloseBT
            // 
            this.CloseBT.BackColor = System.Drawing.Color.Red;
            this.CloseBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseBT.Location = new System.Drawing.Point(231, 12);
            this.CloseBT.Name = "CloseBT";
            this.CloseBT.Size = new System.Drawing.Size(143, 54);
            this.CloseBT.TabIndex = 9;
            this.CloseBT.Text = "Close";
            this.CloseBT.UseVisualStyleBackColor = false;
            this.CloseBT.Click += new System.EventHandler(this.CloseBT_Click);
            // 
            // ColumnMatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BookGame.Properties.Resources.MatchingBackGround;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(993, 552);
            this.Controls.Add(this.CloseBT);
            this.Controls.Add(this.AboutBT);
            this.Controls.Add(this.BackBT);
            this.Controls.Add(this.ResetBT);
            this.Controls.Add(this.CheckBT);
            this.Controls.Add(this.DescriptionListBox);
            this.Controls.Add(this.CallNumbersListBox);
            this.Controls.Add(this.ScoreLB);
            this.Controls.Add(this.TimerLB);
            this.Name = "ColumnMatch";
            this.Text = "ColumnMatch";
            this.Load += new System.EventHandler(this.ColumnMatch_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label TimerLB;
        private System.Windows.Forms.Label ScoreLB;
        private System.Windows.Forms.ListBox CallNumbersListBox;
        private System.Windows.Forms.ListBox DescriptionListBox;
        private System.Windows.Forms.Button CheckBT;
        private System.Windows.Forms.Button ResetBT;
        private System.Windows.Forms.Button BackBT;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Button AboutBT;
        private System.Windows.Forms.Button CloseBT;
    }
}