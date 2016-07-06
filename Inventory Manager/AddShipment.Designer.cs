namespace Inventory_Manager
{
    partial class frmAddShipment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddShipment));
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.btnAddShipment = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.flpBox = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddRepository = new System.Windows.Forms.Button();
            this.cbxRepository = new System.Windows.Forms.ComboBox();
            this.dtpShipmentDate = new System.Windows.Forms.DateTimePicker();
            this.lblPackingLocation = new System.Windows.Forms.Label();
            this.lblShipmentDate = new System.Windows.Forms.Label();
            this.btnAddLineBox = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnMainMenu.Location = new System.Drawing.Point(314, 519);
            this.btnMainMenu.Margin = new System.Windows.Forms.Padding(0);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(200, 75);
            this.btnMainMenu.TabIndex = 6;
            this.btnMainMenu.Tag = "Menu";
            this.btnMainMenu.Text = "Main Menu";
            this.btnMainMenu.UseVisualStyleBackColor = true;
            // 
            // btnAddShipment
            // 
            this.btnAddShipment.Location = new System.Drawing.Point(103, 519);
            this.btnAddShipment.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddShipment.Name = "btnAddShipment";
            this.btnAddShipment.Size = new System.Drawing.Size(200, 75);
            this.btnAddShipment.TabIndex = 5;
            this.btnAddShipment.Text = "Add Shipment";
            this.btnAddShipment.UseVisualStyleBackColor = true;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Kristen ITC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(133, 47);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(252, 28);
            this.lblHeader.TabIndex = 22;
            this.lblHeader.Text = "Create A New Shipment";
            // 
            // flpBox
            // 
            this.flpBox.AutoScroll = true;
            this.flpBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.flpBox.Location = new System.Drawing.Point(45, 210);
            this.flpBox.Name = "flpBox";
            this.flpBox.Size = new System.Drawing.Size(415, 290);
            this.flpBox.TabIndex = 3;
            // 
            // btnAddRepository
            // 
            this.btnAddRepository.Location = new System.Drawing.Point(479, 149);
            this.btnAddRepository.Name = "btnAddRepository";
            this.btnAddRepository.Size = new System.Drawing.Size(35, 35);
            this.btnAddRepository.TabIndex = 2;
            this.btnAddRepository.Tag = "Add";
            this.btnAddRepository.Text = "+";
            this.btnAddRepository.UseVisualStyleBackColor = true;
            // 
            // cbxRepository
            // 
            this.cbxRepository.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRepository.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxRepository.FormattingEnabled = true;
            this.cbxRepository.Location = new System.Drawing.Point(138, 151);
            this.cbxRepository.Name = "cbxRepository";
            this.cbxRepository.Size = new System.Drawing.Size(322, 33);
            this.cbxRepository.TabIndex = 1;
            // 
            // dtpShipmentDate
            // 
            this.dtpShipmentDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpShipmentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpShipmentDate.Location = new System.Drawing.Point(138, 101);
            this.dtpShipmentDate.Name = "dtpShipmentDate";
            this.dtpShipmentDate.Size = new System.Drawing.Size(322, 30);
            this.dtpShipmentDate.TabIndex = 0;
            // 
            // lblPackingLocation
            // 
            this.lblPackingLocation.AutoSize = true;
            this.lblPackingLocation.Font = new System.Drawing.Font("Kristen ITC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPackingLocation.Location = new System.Drawing.Point(10, 153);
            this.lblPackingLocation.Name = "lblPackingLocation";
            this.lblPackingLocation.Size = new System.Drawing.Size(122, 28);
            this.lblPackingLocation.TabIndex = 27;
            this.lblPackingLocation.Text = "Repository:";
            // 
            // lblShipmentDate
            // 
            this.lblShipmentDate.AutoSize = true;
            this.lblShipmentDate.Font = new System.Drawing.Font("Kristen ITC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShipmentDate.Location = new System.Drawing.Point(65, 105);
            this.lblShipmentDate.Name = "lblShipmentDate";
            this.lblShipmentDate.Size = new System.Drawing.Size(67, 28);
            this.lblShipmentDate.TabIndex = 28;
            this.lblShipmentDate.Text = "Date:";
            // 
            // btnAddLineBox
            // 
            this.btnAddLineBox.Location = new System.Drawing.Point(479, 210);
            this.btnAddLineBox.Name = "btnAddLineBox";
            this.btnAddLineBox.Size = new System.Drawing.Size(35, 35);
            this.btnAddLineBox.TabIndex = 4;
            this.btnAddLineBox.Tag = "Add";
            this.btnAddLineBox.Text = "+";
            this.btnAddLineBox.UseVisualStyleBackColor = true;
            // 
            // frmAddShipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 607);
            this.Controls.Add(this.btnAddLineBox);
            this.Controls.Add(this.btnAddRepository);
            this.Controls.Add(this.cbxRepository);
            this.Controls.Add(this.dtpShipmentDate);
            this.Controls.Add(this.lblPackingLocation);
            this.Controls.Add(this.lblShipmentDate);
            this.Controls.Add(this.flpBox);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.btnAddShipment);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmAddShipment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Shipment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnMainMenu;
        public System.Windows.Forms.Button btnAddShipment;
        public System.Windows.Forms.Label lblHeader;
        public System.Windows.Forms.Button btnAddRepository;
        public System.Windows.Forms.ComboBox cbxRepository;
        public System.Windows.Forms.DateTimePicker dtpShipmentDate;
        public System.Windows.Forms.Label lblPackingLocation;
        public System.Windows.Forms.Label lblShipmentDate;
        public System.Windows.Forms.Button btnAddLineBox;
        public System.Windows.Forms.FlowLayoutPanel flpBox;
    }
}