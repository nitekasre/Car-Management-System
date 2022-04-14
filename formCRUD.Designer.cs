
namespace Assignment6_2
{
    partial class formCRUD
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formCRUD));
            this.dataCars = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblVIN = new System.Windows.Forms.Label();
            this.lblMake = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblUpgrade = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblAbility = new System.Windows.Forms.Label();
            this.txtVIN = new System.Windows.Forms.TextBox();
            this.txtMake = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.cboAbility = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dateYear = new System.Windows.Forms.DateTimePicker();
            this.pnlControls = new System.Windows.Forms.Panel();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.programMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataCars)).BeginInit();
            this.pnlControls.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataCars
            // 
            this.dataCars.AllowUserToResizeColumns = false;
            this.dataCars.AllowUserToResizeRows = false;
            this.dataCars.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataCars.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataCars.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataCars.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataCars.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataCars.Location = new System.Drawing.Point(368, 168);
            this.dataCars.MultiSelect = false;
            this.dataCars.Name = "dataCars";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataCars.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Black;
            this.dataCars.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataCars.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataCars.Size = new System.Drawing.Size(680, 150);
            this.dataCars.TabIndex = 0;
            this.dataCars.TabStop = false;
            this.dataCars.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataCars_CellContentClick);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnAdd.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(424, 336);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 48);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add/Edit";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblVIN
            // 
            this.lblVIN.AutoSize = true;
            this.lblVIN.BackColor = System.Drawing.Color.Transparent;
            this.lblVIN.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVIN.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblVIN.Location = new System.Drawing.Point(16, 24);
            this.lblVIN.Name = "lblVIN";
            this.lblVIN.Size = new System.Drawing.Size(113, 25);
            this.lblVIN.TabIndex = 2;
            this.lblVIN.Text = "Vehicle VIN:";
            // 
            // lblMake
            // 
            this.lblMake.AutoSize = true;
            this.lblMake.BackColor = System.Drawing.Color.Transparent;
            this.lblMake.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMake.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblMake.Location = new System.Drawing.Point(16, 80);
            this.lblMake.Name = "lblMake";
            this.lblMake.Size = new System.Drawing.Size(128, 25);
            this.lblMake.TabIndex = 3;
            this.lblMake.Text = "Vehicle Make:";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.BackColor = System.Drawing.Color.Transparent;
            this.lblModel.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblModel.Location = new System.Drawing.Point(16, 136);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(136, 25);
            this.lblModel.TabIndex = 4;
            this.lblModel.Text = "Vehicle Model:";
            // 
            // lblUpgrade
            // 
            this.lblUpgrade.AutoSize = true;
            this.lblUpgrade.BackColor = System.Drawing.Color.Transparent;
            this.lblUpgrade.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpgrade.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblUpgrade.Location = new System.Drawing.Point(440, 24);
            this.lblUpgrade.Name = "lblUpgrade";
            this.lblUpgrade.Size = new System.Drawing.Size(131, 25);
            this.lblUpgrade.TabIndex = 5;
            this.lblUpgrade.Text = "Upgrade Year:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblPrice.Location = new System.Drawing.Point(440, 80);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(124, 25);
            this.lblPrice.TabIndex = 6;
            this.lblPrice.Text = "Vehicle Price:";
            // 
            // lblAbility
            // 
            this.lblAbility.AutoSize = true;
            this.lblAbility.BackColor = System.Drawing.Color.Transparent;
            this.lblAbility.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbility.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblAbility.Location = new System.Drawing.Point(440, 136);
            this.lblAbility.Name = "lblAbility";
            this.lblAbility.Size = new System.Drawing.Size(135, 25);
            this.lblAbility.TabIndex = 7;
            this.lblAbility.Text = "Vehicle Ability:";
            // 
            // txtVIN
            // 
            this.txtVIN.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F);
            this.txtVIN.Location = new System.Drawing.Point(176, 24);
            this.txtVIN.Name = "txtVIN";
            this.txtVIN.Size = new System.Drawing.Size(216, 33);
            this.txtVIN.TabIndex = 8;
            this.txtVIN.Leave += new System.EventHandler(this.txtVIN_Leave);
            // 
            // txtMake
            // 
            this.txtMake.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F);
            this.txtMake.Location = new System.Drawing.Point(176, 80);
            this.txtMake.Name = "txtMake";
            this.txtMake.Size = new System.Drawing.Size(216, 33);
            this.txtMake.TabIndex = 9;
            this.txtMake.Leave += new System.EventHandler(this.txtMake_Leave);
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F);
            this.txtPrice.Location = new System.Drawing.Point(584, 80);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(216, 33);
            this.txtPrice.TabIndex = 12;
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            // 
            // cboAbility
            // 
            this.cboAbility.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F);
            this.cboAbility.FormattingEnabled = true;
            this.cboAbility.Location = new System.Drawing.Point(584, 136);
            this.cboAbility.Name = "cboAbility";
            this.cboAbility.Size = new System.Drawing.Size(216, 33);
            this.cboAbility.TabIndex = 13;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSave.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(568, 336);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 48);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save Car";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnUpdate.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(712, 336);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(120, 48);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Update Car";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnDelete.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(856, 336);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 48);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Delete Car";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dateYear
            // 
            this.dateYear.CustomFormat = "YYYY";
            this.dateYear.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F);
            this.dateYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateYear.Location = new System.Drawing.Point(584, 24);
            this.dateYear.Name = "dateYear";
            this.dateYear.Size = new System.Drawing.Size(216, 33);
            this.dateYear.TabIndex = 19;
            this.dateYear.Validating += new System.ComponentModel.CancelEventHandler(this.dateYear_Validating);
            // 
            // pnlControls
            // 
            this.pnlControls.BackColor = System.Drawing.Color.Transparent;
            this.pnlControls.Controls.Add(this.lblVIN);
            this.pnlControls.Controls.Add(this.dateYear);
            this.pnlControls.Controls.Add(this.lblMake);
            this.pnlControls.Controls.Add(this.lblModel);
            this.pnlControls.Controls.Add(this.lblUpgrade);
            this.pnlControls.Controls.Add(this.lblPrice);
            this.pnlControls.Controls.Add(this.lblAbility);
            this.pnlControls.Controls.Add(this.txtVIN);
            this.pnlControls.Controls.Add(this.cboAbility);
            this.pnlControls.Controls.Add(this.txtMake);
            this.pnlControls.Controls.Add(this.txtPrice);
            this.pnlControls.Controls.Add(this.txtModel);
            this.pnlControls.Location = new System.Drawing.Point(296, 400);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(808, 188);
            this.pnlControls.TabIndex = 20;
            // 
            // txtModel
            // 
            this.txtModel.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F);
            this.txtModel.Location = new System.Drawing.Point(176, 136);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(216, 33);
            this.txtModel.TabIndex = 10;
            this.txtModel.TextChanged += new System.EventHandler(this.txtModel_Leave);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programMenuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1212, 24);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // programMenuToolStripMenuItem
            // 
            this.programMenuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenuToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.programMenuToolStripMenuItem.Name = "programMenuToolStripMenuItem";
            this.programMenuToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.programMenuToolStripMenuItem.Text = "Program Menu";
            // 
            // mainMenuToolStripMenuItem
            // 
            this.mainMenuToolStripMenuItem.Name = "mainMenuToolStripMenuItem";
            this.mainMenuToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.mainMenuToolStripMenuItem.Text = "Main Menu";
            this.mainMenuToolStripMenuItem.Click += new System.EventHandler(this.mainMenuToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // formCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1212, 592);
            this.Controls.Add(this.pnlControls);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataCars);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "formCRUD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Inventory";
            this.Load += new System.EventHandler(this.formCRUD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataCars)).EndInit();
            this.pnlControls.ResumeLayout(false);
            this.pnlControls.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataCars;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblVIN;
        private System.Windows.Forms.Label lblMake;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblUpgrade;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblAbility;
        private System.Windows.Forms.TextBox txtVIN;
        private System.Windows.Forms.TextBox txtMake;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.ComboBox cboAbility;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DateTimePicker dateYear;
        private System.Windows.Forms.Panel pnlControls;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem programMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TextBox txtModel;
    }
}