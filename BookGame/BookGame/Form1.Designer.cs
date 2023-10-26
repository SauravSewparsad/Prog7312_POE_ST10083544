namespace BookGame
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
            this.label1 = new System.Windows.Forms.Label();
            this.FindingCallNoBT = new System.Windows.Forms.Button();
            this.IdentifyAreasBT = new System.Windows.Forms.Button();
            this.ReplaceBookBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 82);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome player \r\nSelect your game:";
            // 
            // FindingCallNoBT
            // 
            this.FindingCallNoBT.BackgroundImage = global::BookGame.Properties.Resources.FindingCallNumbersButton;
            this.FindingCallNoBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FindingCallNoBT.Cursor = System.Windows.Forms.Cursors.Default;
            this.FindingCallNoBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FindingCallNoBT.Font = new System.Drawing.Font("Franklin Gothic Medium", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FindingCallNoBT.ForeColor = System.Drawing.Color.Black;
            this.FindingCallNoBT.Location = new System.Drawing.Point(75, 351);
            this.FindingCallNoBT.Name = "FindingCallNoBT";
            this.FindingCallNoBT.Size = new System.Drawing.Size(198, 71);
            this.FindingCallNoBT.TabIndex = 3;
            this.FindingCallNoBT.Text = "Finding Call Numbers";
            this.FindingCallNoBT.UseVisualStyleBackColor = true;
            this.FindingCallNoBT.Click += new System.EventHandler(this.FindingCallNoBT_Click);
            // 
            // IdentifyAreasBT
            // 
            this.IdentifyAreasBT.BackgroundImage = global::BookGame.Properties.Resources.Identifying_areas_button;
            this.IdentifyAreasBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.IdentifyAreasBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IdentifyAreasBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdentifyAreasBT.ForeColor = System.Drawing.Color.Black;
            this.IdentifyAreasBT.Location = new System.Drawing.Point(75, 240);
            this.IdentifyAreasBT.Name = "IdentifyAreasBT";
            this.IdentifyAreasBT.Size = new System.Drawing.Size(198, 71);
            this.IdentifyAreasBT.TabIndex = 2;
            this.IdentifyAreasBT.Text = "Identifying Areas\r\n";
            this.IdentifyAreasBT.UseVisualStyleBackColor = true;
            this.IdentifyAreasBT.Click += new System.EventHandler(this.IdentifyAreasBT_Click);
            // 
            // ReplaceBookBT
            // 
            this.ReplaceBookBT.BackgroundImage = global::BookGame.Properties.Resources.ReplacingBooksBT;
            this.ReplaceBookBT.Cursor = System.Windows.Forms.Cursors.Default;
            this.ReplaceBookBT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ReplaceBookBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReplaceBookBT.ForeColor = System.Drawing.Color.Yellow;
            this.ReplaceBookBT.Location = new System.Drawing.Point(75, 127);
            this.ReplaceBookBT.Name = "ReplaceBookBT";
            this.ReplaceBookBT.Size = new System.Drawing.Size(198, 71);
            this.ReplaceBookBT.TabIndex = 0;
            this.ReplaceBookBT.Text = "Replacing Books";
            this.ReplaceBookBT.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.ReplaceBookBT.UseVisualStyleBackColor = true;
            this.ReplaceBookBT.Click += new System.EventHandler(this.ReplaceBookBT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(369, 450);
            this.Controls.Add(this.FindingCallNoBT);
            this.Controls.Add(this.IdentifyAreasBT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ReplaceBookBT);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ReplaceBookBT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button IdentifyAreasBT;
        private System.Windows.Forms.Button FindingCallNoBT;
    }
}

