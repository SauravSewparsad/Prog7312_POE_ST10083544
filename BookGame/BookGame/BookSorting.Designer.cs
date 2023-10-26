namespace BookGame
{
    partial class BookSorting
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
            System.Windows.Forms.Timer animationTimer;
            this.PlayBT = new System.Windows.Forms.Button();
            this.BottomShelfPanel = new System.Windows.Forms.Panel();
            this.SortBT = new System.Windows.Forms.Button();
            this.CheckBT = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.HomePageBT = new System.Windows.Forms.Button();
            animationTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // PlayBT
            // 
            this.PlayBT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PlayBT.BackColor = System.Drawing.Color.LightSeaGreen;
            this.PlayBT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PlayBT.Location = new System.Drawing.Point(399, 487);
            this.PlayBT.Name = "PlayBT";
            this.PlayBT.Size = new System.Drawing.Size(171, 53);
            this.PlayBT.TabIndex = 1;
            this.PlayBT.Text = "Play ";
            this.PlayBT.UseVisualStyleBackColor = false;
            this.PlayBT.Click += new System.EventHandler(this.PlayBT_Click);
            // 
            // BottomShelfPanel
            // 
            this.BottomShelfPanel.AllowDrop = true;
            this.BottomShelfPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BottomShelfPanel.Location = new System.Drawing.Point(12, 243);
            this.BottomShelfPanel.Name = "BottomShelfPanel";
            this.BottomShelfPanel.Size = new System.Drawing.Size(1311, 150);
            this.BottomShelfPanel.TabIndex = 3;
            // 
            // SortBT
            // 
            this.SortBT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SortBT.BackColor = System.Drawing.Color.LightSeaGreen;
            this.SortBT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SortBT.Location = new System.Drawing.Point(819, 487);
            this.SortBT.Name = "SortBT";
            this.SortBT.Size = new System.Drawing.Size(165, 53);
            this.SortBT.TabIndex = 4;
            this.SortBT.Text = "Sort Books";
            this.SortBT.UseVisualStyleBackColor = false;
            this.SortBT.Click += new System.EventHandler(this.SortBT_Click);
            // 
            // CheckBT
            // 
            this.CheckBT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CheckBT.BackColor = System.Drawing.Color.LightSeaGreen;
            this.CheckBT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CheckBT.Location = new System.Drawing.Point(1145, 487);
            this.CheckBT.Name = "CheckBT";
            this.CheckBT.Size = new System.Drawing.Size(165, 53);
            this.CheckBT.TabIndex = 6;
            this.CheckBT.Text = "Check order";
            this.CheckBT.UseVisualStyleBackColor = false;
            this.CheckBT.Click += new System.EventHandler(this.CheckBT_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.BackColor = System.Drawing.Color.Black;
            this.progressBar1.Location = new System.Drawing.Point(30, 59);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1209, 36);
            this.progressBar1.TabIndex = 8;
            // 
            // HomePageBT
            // 
            this.HomePageBT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.HomePageBT.BackColor = System.Drawing.Color.LightSeaGreen;
            this.HomePageBT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.HomePageBT.Location = new System.Drawing.Point(73, 487);
            this.HomePageBT.Name = "HomePageBT";
            this.HomePageBT.Size = new System.Drawing.Size(171, 53);
            this.HomePageBT.TabIndex = 9;
            this.HomePageBT.Text = "Home";
            this.HomePageBT.UseVisualStyleBackColor = false;
            this.HomePageBT.Click += new System.EventHandler(this.HomePageBT_Click);
            // 
            // BookSorting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BookGame.Properties.Resources.LibraryBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1414, 571);
            this.Controls.Add(this.HomePageBT);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.CheckBT);
            this.Controls.Add(this.SortBT);
            this.Controls.Add(this.BottomShelfPanel);
            this.Controls.Add(this.PlayBT);
            this.Name = "BookSorting";
            this.Text = "BookSorting";
            this.Load += new System.EventHandler(this.BookSorting_Load_1);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button PlayBT;
        private System.Windows.Forms.Panel BottomShelfPanel;
        private System.Windows.Forms.Button SortBT;
        private System.Windows.Forms.Button CheckBT;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button HomePageBT;
    }
}