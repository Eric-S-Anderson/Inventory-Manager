namespace Inventory_Manager
{
    partial class frmAddRepository
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddRepository));
            this.txtPhone = new System.Windows.Forms.MaskedTextBox();
            this.cbxState = new System.Windows.Forms.ComboBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.btnAddLocation = new System.Windows.Forms.Button();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblCountry = new System.Windows.Forms.Label();
            this.cbxCountry = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(234, 287);
            this.txtPhone.Mask = "(999) 000-0000";
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(147, 30);
            this.txtPhone.TabIndex = 5;
            // 
            // cbxState
            // 
            this.cbxState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxState.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxState.FormattingEnabled = true;
            this.cbxState.Location = new System.Drawing.Point(343, 190);
            this.cbxState.Name = "cbxState";
            this.cbxState.Size = new System.Drawing.Size(83, 33);
            this.cbxState.TabIndex = 3;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Kristen ITC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(113, 44);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(241, 28);
            this.lblHeader.TabIndex = 18;
            this.lblHeader.Text = "Add A New Repository";
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnMainMenu.Location = new System.Drawing.Point(226, 330);
            this.btnMainMenu.Margin = new System.Windows.Forms.Padding(0);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(200, 75);
            this.btnMainMenu.TabIndex = 7;
            this.btnMainMenu.Tag = "Menu";
            this.btnMainMenu.Text = "Main Menu";
            this.btnMainMenu.UseVisualStyleBackColor = true;
            // 
            // btnAddLocation
            // 
            this.btnAddLocation.Location = new System.Drawing.Point(15, 330);
            this.btnAddLocation.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddLocation.Name = "btnAddLocation";
            this.btnAddLocation.Size = new System.Drawing.Size(200, 75);
            this.btnAddLocation.TabIndex = 6;
            this.btnAddLocation.Text = "Add Repository";
            this.btnAddLocation.UseVisualStyleBackColor = true;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Kristen ITC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(50, 289);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(165, 28);
            this.lblPhone.TabIndex = 9;
            this.lblPhone.Text = "Phone Number:";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Kristen ITC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.Location = new System.Drawing.Point(267, 192);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(70, 28);
            this.lblState.TabIndex = 11;
            this.lblState.Text = "State:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Kristen ITC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(25, 192);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(59, 28);
            this.lblCity.TabIndex = 12;
            this.lblCity.Text = "City:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Kristen ITC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(10, 146);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(100, 28);
            this.lblAddress.TabIndex = 13;
            this.lblAddress.Text = "Address:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Kristen ITC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(36, 100);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(74, 28);
            this.lblName.TabIndex = 14;
            this.lblName.Text = "Name:";
            // 
            // txtCity
            // 
            this.txtCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCity.Location = new System.Drawing.Point(94, 190);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(138, 30);
            this.txtCity.TabIndex = 2;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(118, 144);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(308, 30);
            this.txtAddress.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(118, 98);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(308, 30);
            this.txtName.TabIndex = 0;
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Font = new System.Drawing.Font("Kristen ITC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountry.Location = new System.Drawing.Point(10, 243);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(99, 28);
            this.lblCountry.TabIndex = 11;
            this.lblCountry.Text = "Country:";
            // 
            // cbxCountry
            // 
            this.cbxCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCountry.FormattingEnabled = true;
            this.cbxCountry.Location = new System.Drawing.Point(118, 241);
            this.cbxCountry.Name = "cbxCountry";
            this.cbxCountry.Size = new System.Drawing.Size(308, 33);
            this.cbxCountry.TabIndex = 4;
            // 
            // frmAddRepository
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 420);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.cbxCountry);
            this.Controls.Add(this.cbxState);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.btnAddLocation);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblCountry);
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
            this.Name = "frmAddRepository";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Repository";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAddEventLocation_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtPhone;
        private System.Windows.Forms.ComboBox cbxState;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.Button btnAddLocation;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.ComboBox cbxCountry;
    }
}