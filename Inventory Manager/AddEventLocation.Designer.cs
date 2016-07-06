namespace Inventory_Manager
{
    partial class frmAddEventLocation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddEventLocation));
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.btnAddLocation = new System.Windows.Forms.Button();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblZip = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.cbxState = new System.Windows.Forms.ComboBox();
            this.txtZip = new System.Windows.Forms.MaskedTextBox();
            this.txtPhone = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(118, 104);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(308, 30);
            this.txtName.TabIndex = 0;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(118, 150);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(308, 30);
            this.txtAddress.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Kristen ITC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(36, 106);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(74, 28);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Kristen ITC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(10, 152);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(100, 28);
            this.lblAddress.TabIndex = 1;
            this.lblAddress.Text = "Address:";
            // 
            // btnAddLocation
            // 
            this.btnAddLocation.Location = new System.Drawing.Point(15, 336);
            this.btnAddLocation.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddLocation.Name = "btnAddLocation";
            this.btnAddLocation.Size = new System.Drawing.Size(200, 75);
            this.btnAddLocation.TabIndex = 6;
            this.btnAddLocation.Text = "Add Location";
            this.btnAddLocation.UseVisualStyleBackColor = true;
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnMainMenu.Location = new System.Drawing.Point(226, 336);
            this.btnMainMenu.Margin = new System.Windows.Forms.Padding(0);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(200, 75);
            this.btnMainMenu.TabIndex = 7;
            this.btnMainMenu.Tag = "Menu";
            this.btnMainMenu.Text = "Main Menu";
            this.btnMainMenu.UseVisualStyleBackColor = true;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Kristen ITC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(89, 49);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(289, 28);
            this.lblHeader.TabIndex = 3;
            this.lblHeader.Text = "Add A New Event Location";
            // 
            // txtCity
            // 
            this.txtCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCity.Location = new System.Drawing.Point(94, 196);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(138, 30);
            this.txtCity.TabIndex = 2;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Kristen ITC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(25, 198);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(59, 28);
            this.lblCity.TabIndex = 1;
            this.lblCity.Text = "City:";
            // 
            // lblZip
            // 
            this.lblZip.AutoSize = true;
            this.lblZip.Font = new System.Drawing.Font("Kristen ITC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZip.Location = new System.Drawing.Point(113, 244);
            this.lblZip.Name = "lblZip";
            this.lblZip.Size = new System.Drawing.Size(113, 28);
            this.lblZip.TabIndex = 1;
            this.lblZip.Text = "Zip Code:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Kristen ITC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(61, 290);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(165, 28);
            this.lblPhone.TabIndex = 1;
            this.lblPhone.Text = "Phone Number:";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Kristen ITC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.Location = new System.Drawing.Point(267, 198);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(70, 28);
            this.lblState.TabIndex = 1;
            this.lblState.Text = "State:";
            // 
            // cbxState
            // 
            this.cbxState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxState.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxState.FormattingEnabled = true;
            this.cbxState.Location = new System.Drawing.Point(343, 196);
            this.cbxState.Name = "cbxState";
            this.cbxState.Size = new System.Drawing.Size(83, 33);
            this.cbxState.TabIndex = 3;
            // 
            // txtZip
            // 
            this.txtZip.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtZip.Location = new System.Drawing.Point(245, 242);
            this.txtZip.Mask = "00000-9999";
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(114, 30);
            this.txtZip.TabIndex = 4;
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(245, 288);
            this.txtPhone.Mask = "(999) 000-0000";
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(147, 30);
            this.txtPhone.TabIndex = 5;
            // 
            // frmAddEventLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnMainMenu;
            this.ClientSize = new System.Drawing.Size(435, 420);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtZip);
            this.Controls.Add(this.cbxState);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.btnAddLocation);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblZip);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmAddEventLocation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Event Location";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAddEventLocation_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Button btnAddLocation;
        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblZip;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.ComboBox cbxState;
        private System.Windows.Forms.MaskedTextBox txtZip;
        private System.Windows.Forms.MaskedTextBox txtPhone;
    }
}