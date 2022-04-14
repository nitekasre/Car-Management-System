
namespace Assignment6_2
{
    partial class formStart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formStart));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblClass1 = new System.Windows.Forms.Label();
            this.lblClass2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblClass3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTitle.Font = new System.Drawing.Font("Yu Gothic UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblTitle.Location = new System.Drawing.Point(216, 304);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(362, 45);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "S.H.I.E.L.D. Car Inventory";
            // 
            // lblClass1
            // 
            this.lblClass1.AutoSize = true;
            this.lblClass1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblClass1.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClass1.ForeColor = System.Drawing.Color.Firebrick;
            this.lblClass1.Location = new System.Drawing.Point(312, 352);
            this.lblClass1.Name = "lblClass1";
            this.lblClass1.Size = new System.Drawing.Size(169, 21);
            this.lblClass1.TabIndex = 2;
            this.lblClass1.Text = "CLASSIFIED NETWORK";
            // 
            // lblClass2
            // 
            this.lblClass2.AutoSize = true;
            this.lblClass2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblClass2.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClass2.ForeColor = System.Drawing.Color.IndianRed;
            this.lblClass2.Location = new System.Drawing.Point(312, 376);
            this.lblClass2.Name = "lblClass2";
            this.lblClass2.Size = new System.Drawing.Size(169, 21);
            this.lblClass2.TabIndex = 3;
            this.lblClass2.Text = "CLASSIFIED NETWORK";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(136, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 472);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblClass3
            // 
            this.lblClass3.AutoSize = true;
            this.lblClass3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblClass3.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClass3.ForeColor = System.Drawing.Color.LightCoral;
            this.lblClass3.Location = new System.Drawing.Point(312, 400);
            this.lblClass3.Name = "lblClass3";
            this.lblClass3.Size = new System.Drawing.Size(169, 21);
            this.lblClass3.TabIndex = 4;
            this.lblClass3.Text = "CLASSIFIED NETWORK";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formMenu,
            this.exitToolStripMenuItem1});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.optionsToolStripMenuItem.Text = "Program Menu";
            // 
            // formMenu
            // 
            this.formMenu.Name = "formMenu";
            this.formMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.formMenu.Size = new System.Drawing.Size(207, 22);
            this.formMenu.Text = "Update Inventory";
            this.formMenu.Click += new System.EventHandler(this.formMenu_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(207, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // formStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblClass3);
            this.Controls.Add(this.lblClass2);
            this.Controls.Add(this.lblClass1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "formStart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Assignment 6.2: Car Inventory";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblClass1;
        private System.Windows.Forms.Label lblClass2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblClass3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formMenu;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
    }
}

