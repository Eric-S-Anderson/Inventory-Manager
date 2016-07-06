namespace Inventory_Manager
{
    partial class frmAddTrailer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddTrailer));
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.btnAddTrailer = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblVIN = new System.Windows.Forms.Label();
            this.txtVIN = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnMainMenu.Location = new System.Drawing.Point(219, 206);
            this.btnMainMenu.Margin = new System.Windows.Forms.Padding(0);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(200, 75);
            this.btnMainMenu.TabIndex = 3;
            this.btnMainMenu.Tag = "Menu";
            this.btnMainMenu.Text = "Main Menu";
            this.btnMainMenu.UseVisualStyleBackColor = true;
            // 
            // btnAddTrailer
            // 
            this.btnAddTrailer.Location = new System.Drawing.Point(8, 206);
            this.btnAddTrailer.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddTrailer.Name = "btnAddTrailer";
            this.btnAddTrailer.Size = new System.Drawing.Size(200, 75);
            this.btnAddTrailer.TabIndex = 2;
            this.btnAddTrailer.Text = "Add Trailer";
            this.btnAddTrailer.UseVisualStyleBackColor = true;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Kristen ITC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(113, 59);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(203, 28);
            this.lblHeader.TabIndex = 10;
            this.lblHeader.Text = "Add A New Trailer";
            // 
            // lblVIN
            // 
            this.lblVIN.AutoSize = true;
            this.lblVIN.Font = new System.Drawing.Font("Kristen ITC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVIN.Location = new System.Drawing.Point(14, 161);
            this.lblVIN.Name = "lblVIN";
            this.lblVIN.Size = new System.Drawing.Size(59, 28);
            this.lblVIN.TabIndex = 12;
            this.lblVIN.Text = "VIN:";
            // 
            // txtVIN
            // 
            this.txtVIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVIN.Location = new System.Drawing.Point(96, 159);
            this.txtVIN.Name = "txtVIN";
            this.txtVIN.Size = new System.Drawing.Size(308, 30);
            this.txtVIN.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(96, 112);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(308, 30);
            this.txtName.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Kristen ITC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(14, 114);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(74, 28);
            this.lblName.TabIndex = 12;
            this.lblName.Text = "Name:";
            // 
            // frmAddTrailer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 291);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblVIN);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtVIN);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.btnAddTrailer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmAddTrailer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Trailer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAddTrailer_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.Button btnAddTrailer;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblVIN;
        private System.Windows.Forms.TextBox txtVIN;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
    }
}