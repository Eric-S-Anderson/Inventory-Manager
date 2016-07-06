namespace Inventory_Manager
{
    partial class frmAddDOT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddDOT));
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.btnAddDOT = new System.Windows.Forms.Button();
            this.lblDOT = new System.Windows.Forms.Label();
            this.txtDOT = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpIssueDate = new System.Windows.Forms.DateTimePicker();
            this.lblTrailer = new System.Windows.Forms.Label();
            this.cbxTrailer = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Kristen ITC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(112, 48);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(273, 28);
            this.lblHeader.TabIndex = 10;
            this.lblHeader.Text = "Add A New DOT Number";
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnMainMenu.Location = new System.Drawing.Point(265, 224);
            this.btnMainMenu.Margin = new System.Windows.Forms.Padding(0);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(200, 75);
            this.btnMainMenu.TabIndex = 4;
            this.btnMainMenu.Tag = "Menu";
            this.btnMainMenu.Text = "Main Menu";
            this.btnMainMenu.UseVisualStyleBackColor = true;
            // 
            // btnAddDOT
            // 
            this.btnAddDOT.Location = new System.Drawing.Point(54, 224);
            this.btnAddDOT.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddDOT.Name = "btnAddDOT";
            this.btnAddDOT.Size = new System.Drawing.Size(200, 75);
            this.btnAddDOT.TabIndex = 3;
            this.btnAddDOT.Text = "Add DOT Number";
            this.btnAddDOT.UseVisualStyleBackColor = true;
            // 
            // lblDOT
            // 
            this.lblDOT.AutoSize = true;
            this.lblDOT.Font = new System.Drawing.Font("Kristen ITC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOT.Location = new System.Drawing.Point(15, 98);
            this.lblDOT.Name = "lblDOT";
            this.lblDOT.Size = new System.Drawing.Size(154, 28);
            this.lblDOT.TabIndex = 9;
            this.lblDOT.Text = "DOT Number:";
            // 
            // txtDOT
            // 
            this.txtDOT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDOT.Location = new System.Drawing.Point(187, 96);
            this.txtDOT.Name = "txtDOT";
            this.txtDOT.Size = new System.Drawing.Size(278, 30);
            this.txtDOT.TabIndex = 0;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Kristen ITC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(14, 141);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(123, 28);
            this.lblDate.TabIndex = 9;
            this.lblDate.Text = "Issue Date:";
            // 
            // dtpIssueDate
            // 
            this.dtpIssueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpIssueDate.Location = new System.Drawing.Point(143, 137);
            this.dtpIssueDate.Name = "dtpIssueDate";
            this.dtpIssueDate.Size = new System.Drawing.Size(322, 30);
            this.dtpIssueDate.TabIndex = 1;
            // 
            // lblTrailer
            // 
            this.lblTrailer.AutoSize = true;
            this.lblTrailer.Font = new System.Drawing.Font("Kristen ITC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrailer.Location = new System.Drawing.Point(15, 181);
            this.lblTrailer.Name = "lblTrailer";
            this.lblTrailer.Size = new System.Drawing.Size(84, 28);
            this.lblTrailer.TabIndex = 9;
            this.lblTrailer.Text = "Trailer:";
            // 
            // cbxTrailer
            // 
            this.cbxTrailer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTrailer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTrailer.FormattingEnabled = true;
            this.cbxTrailer.Location = new System.Drawing.Point(105, 179);
            this.cbxTrailer.Name = "cbxTrailer";
            this.cbxTrailer.Size = new System.Drawing.Size(360, 33);
            this.cbxTrailer.TabIndex = 2;
            // 
            // frmAddDOT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 308);
            this.Controls.Add(this.cbxTrailer);
            this.Controls.Add(this.dtpIssueDate);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.btnAddDOT);
            this.Controls.Add(this.lblTrailer);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblDOT);
            this.Controls.Add(this.txtDOT);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmAddDOT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add DOT";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAddDOT_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.Button btnAddDOT;
        private System.Windows.Forms.Label lblDOT;
        private System.Windows.Forms.TextBox txtDOT;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpIssueDate;
        private System.Windows.Forms.Label lblTrailer;
        private System.Windows.Forms.ComboBox cbxTrailer;
    }
}