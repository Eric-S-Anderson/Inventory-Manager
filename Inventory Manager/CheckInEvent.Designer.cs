namespace Inventory_Manager
{
    partial class frmCheckInEvent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCheckInEvent));
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.btnCheckInEvent = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.cbxEvent = new System.Windows.Forms.ComboBox();
            this.lblEvent = new System.Windows.Forms.Label();
            this.gbxDetails = new System.Windows.Forms.GroupBox();
            this.lblBoxCode = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblBoxCodeDisplay = new System.Windows.Forms.Label();
            this.lblLocationDisplay = new System.Windows.Forms.Label();
            this.lblDateDisplay = new System.Windows.Forms.Label();
            this.lblNameDisplay = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblStayQuantity = new System.Windows.Forms.Label();
            this.lblReturnQuantity = new System.Windows.Forms.Label();
            this.nudStayQuantity = new System.Windows.Forms.NumericUpDown();
            this.nudReturnQuantity = new System.Windows.Forms.NumericUpDown();
            this.lblckbRiceOverflow = new System.Windows.Forms.Label();
            this.ckbRiceOverflow = new System.Windows.Forms.CheckBox();
            this.lblckbSoyOverflow = new System.Windows.Forms.Label();
            this.ckbSoyOverflow = new System.Windows.Forms.CheckBox();
            this.gbxDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStayQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudReturnQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnMainMenu.Location = new System.Drawing.Point(501, 464);
            this.btnMainMenu.Margin = new System.Windows.Forms.Padding(0);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(200, 75);
            this.btnMainMenu.TabIndex = 6;
            this.btnMainMenu.Tag = "Menu";
            this.btnMainMenu.Text = "Main Menu";
            this.btnMainMenu.UseVisualStyleBackColor = true;
            // 
            // btnCheckInEvent
            // 
            this.btnCheckInEvent.Location = new System.Drawing.Point(290, 464);
            this.btnCheckInEvent.Margin = new System.Windows.Forms.Padding(0);
            this.btnCheckInEvent.Name = "btnCheckInEvent";
            this.btnCheckInEvent.Size = new System.Drawing.Size(200, 75);
            this.btnCheckInEvent.TabIndex = 5;
            this.btnCheckInEvent.Text = "Check In Event";
            this.btnCheckInEvent.UseVisualStyleBackColor = true;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Kristen ITC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(274, 55);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(201, 28);
            this.lblHeader.TabIndex = 12;
            this.lblHeader.Text = "Check In An Event";
            // 
            // cbxEvent
            // 
            this.cbxEvent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEvent.Font = new System.Drawing.Font("Kristen ITC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxEvent.FormattingEnabled = true;
            this.cbxEvent.Location = new System.Drawing.Point(95, 104);
            this.cbxEvent.Name = "cbxEvent";
            this.cbxEvent.Size = new System.Drawing.Size(606, 36);
            this.cbxEvent.TabIndex = 0;
            // 
            // lblEvent
            // 
            this.lblEvent.AutoSize = true;
            this.lblEvent.Font = new System.Drawing.Font("Kristen ITC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEvent.Location = new System.Drawing.Point(14, 107);
            this.lblEvent.Name = "lblEvent";
            this.lblEvent.Size = new System.Drawing.Size(75, 28);
            this.lblEvent.TabIndex = 12;
            this.lblEvent.Text = "Event:";
            // 
            // gbxDetails
            // 
            this.gbxDetails.Controls.Add(this.lblBoxCode);
            this.gbxDetails.Controls.Add(this.lblLocation);
            this.gbxDetails.Controls.Add(this.lblDate);
            this.gbxDetails.Controls.Add(this.lblBoxCodeDisplay);
            this.gbxDetails.Controls.Add(this.lblLocationDisplay);
            this.gbxDetails.Controls.Add(this.lblDateDisplay);
            this.gbxDetails.Controls.Add(this.lblNameDisplay);
            this.gbxDetails.Controls.Add(this.lblName);
            this.gbxDetails.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxDetails.Location = new System.Drawing.Point(19, 167);
            this.gbxDetails.Name = "gbxDetails";
            this.gbxDetails.Size = new System.Drawing.Size(682, 161);
            this.gbxDetails.TabIndex = 14;
            this.gbxDetails.TabStop = false;
            this.gbxDetails.Text = "Details";
            // 
            // lblBoxCode
            // 
            this.lblBoxCode.AutoSize = true;
            this.lblBoxCode.Font = new System.Drawing.Font("Kristen ITC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBoxCode.Location = new System.Drawing.Point(332, 107);
            this.lblBoxCode.Name = "lblBoxCode";
            this.lblBoxCode.Size = new System.Drawing.Size(115, 28);
            this.lblBoxCode.TabIndex = 12;
            this.lblBoxCode.Text = "Box Code:";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Kristen ITC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.Location = new System.Drawing.Point(340, 39);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(107, 28);
            this.lblLocation.TabIndex = 12;
            this.lblLocation.Text = "Location:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Kristen ITC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(40, 107);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(67, 28);
            this.lblDate.TabIndex = 12;
            this.lblDate.Text = "Date:";
            // 
            // lblBoxCodeDisplay
            // 
            this.lblBoxCodeDisplay.AutoSize = true;
            this.lblBoxCodeDisplay.Font = new System.Drawing.Font("Kristen ITC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBoxCodeDisplay.Location = new System.Drawing.Point(466, 107);
            this.lblBoxCodeDisplay.Name = "lblBoxCodeDisplay";
            this.lblBoxCodeDisplay.Size = new System.Drawing.Size(182, 28);
            this.lblBoxCodeDisplay.TabIndex = 12;
            this.lblBoxCodeDisplay.Text = "_________________";
            // 
            // lblLocationDisplay
            // 
            this.lblLocationDisplay.AutoSize = true;
            this.lblLocationDisplay.Font = new System.Drawing.Font("Kristen ITC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocationDisplay.Location = new System.Drawing.Point(466, 39);
            this.lblLocationDisplay.Name = "lblLocationDisplay";
            this.lblLocationDisplay.Size = new System.Drawing.Size(182, 28);
            this.lblLocationDisplay.TabIndex = 12;
            this.lblLocationDisplay.Text = "_________________";
            // 
            // lblDateDisplay
            // 
            this.lblDateDisplay.AutoSize = true;
            this.lblDateDisplay.Font = new System.Drawing.Font("Kristen ITC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateDisplay.Location = new System.Drawing.Point(127, 107);
            this.lblDateDisplay.Name = "lblDateDisplay";
            this.lblDateDisplay.Size = new System.Drawing.Size(182, 28);
            this.lblDateDisplay.TabIndex = 12;
            this.lblDateDisplay.Text = "_________________";
            // 
            // lblNameDisplay
            // 
            this.lblNameDisplay.AutoSize = true;
            this.lblNameDisplay.Font = new System.Drawing.Font("Kristen ITC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameDisplay.Location = new System.Drawing.Point(127, 39);
            this.lblNameDisplay.Name = "lblNameDisplay";
            this.lblNameDisplay.Size = new System.Drawing.Size(182, 28);
            this.lblNameDisplay.TabIndex = 12;
            this.lblNameDisplay.Text = "_________________";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Kristen ITC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(33, 39);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(74, 28);
            this.lblName.TabIndex = 12;
            this.lblName.Text = "Name:";
            // 
            // lblStayQuantity
            // 
            this.lblStayQuantity.AutoSize = true;
            this.lblStayQuantity.Font = new System.Drawing.Font("Kristen ITC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStayQuantity.Location = new System.Drawing.Point(190, 352);
            this.lblStayQuantity.Name = "lblStayQuantity";
            this.lblStayQuantity.Size = new System.Drawing.Size(201, 28);
            this.lblStayQuantity.TabIndex = 12;
            this.lblStayQuantity.Text = "Boxes That Stayed:";
            // 
            // lblReturnQuantity
            // 
            this.lblReturnQuantity.AutoSize = true;
            this.lblReturnQuantity.Font = new System.Drawing.Font("Kristen ITC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturnQuantity.Location = new System.Drawing.Point(146, 403);
            this.lblReturnQuantity.Name = "lblReturnQuantity";
            this.lblReturnQuantity.Size = new System.Drawing.Size(245, 28);
            this.lblReturnQuantity.TabIndex = 12;
            this.lblReturnQuantity.Text = "Boxes That Came Back:";
            // 
            // nudStayQuantity
            // 
            this.nudStayQuantity.Font = new System.Drawing.Font("Kristen ITC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudStayQuantity.Location = new System.Drawing.Point(408, 350);
            this.nudStayQuantity.Name = "nudStayQuantity";
            this.nudStayQuantity.Size = new System.Drawing.Size(82, 35);
            this.nudStayQuantity.TabIndex = 1;
            // 
            // nudReturnQuantity
            // 
            this.nudReturnQuantity.Font = new System.Drawing.Font("Kristen ITC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudReturnQuantity.Location = new System.Drawing.Point(408, 401);
            this.nudReturnQuantity.Name = "nudReturnQuantity";
            this.nudReturnQuantity.Size = new System.Drawing.Size(82, 35);
            this.nudReturnQuantity.TabIndex = 2;
            // 
            // lblckbRiceOverflow
            // 
            this.lblckbRiceOverflow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblckbRiceOverflow.Location = new System.Drawing.Point(547, 405);
            this.lblckbRiceOverflow.Name = "lblckbRiceOverflow";
            this.lblckbRiceOverflow.Size = new System.Drawing.Size(52, 28);
            this.lblckbRiceOverflow.TabIndex = 12;
            this.lblckbRiceOverflow.Tag = "Checkbox";
            this.lblckbRiceOverflow.Text = "Rice Overflow";
            this.lblckbRiceOverflow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ckbRiceOverflow
            // 
            this.ckbRiceOverflow.AutoSize = true;
            this.ckbRiceOverflow.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbRiceOverflow.Location = new System.Drawing.Point(566, 388);
            this.ckbRiceOverflow.Name = "ckbRiceOverflow";
            this.ckbRiceOverflow.Size = new System.Drawing.Size(15, 14);
            this.ckbRiceOverflow.TabIndex = 3;
            this.ckbRiceOverflow.UseVisualStyleBackColor = true;
            // 
            // lblckbSoyOverflow
            // 
            this.lblckbSoyOverflow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblckbSoyOverflow.Location = new System.Drawing.Point(605, 405);
            this.lblckbSoyOverflow.Name = "lblckbSoyOverflow";
            this.lblckbSoyOverflow.Size = new System.Drawing.Size(52, 28);
            this.lblckbSoyOverflow.TabIndex = 12;
            this.lblckbSoyOverflow.Tag = "Checkbox";
            this.lblckbSoyOverflow.Text = "Soy Overflow";
            this.lblckbSoyOverflow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ckbSoyOverflow
            // 
            this.ckbSoyOverflow.AutoSize = true;
            this.ckbSoyOverflow.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbSoyOverflow.Location = new System.Drawing.Point(624, 388);
            this.ckbSoyOverflow.Name = "ckbSoyOverflow";
            this.ckbSoyOverflow.Size = new System.Drawing.Size(15, 14);
            this.ckbSoyOverflow.TabIndex = 4;
            this.ckbSoyOverflow.UseVisualStyleBackColor = true;
            // 
            // frmCheckInEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 548);
            this.Controls.Add(this.ckbSoyOverflow);
            this.Controls.Add(this.ckbRiceOverflow);
            this.Controls.Add(this.nudReturnQuantity);
            this.Controls.Add(this.nudStayQuantity);
            this.Controls.Add(this.gbxDetails);
            this.Controls.Add(this.cbxEvent);
            this.Controls.Add(this.lblckbSoyOverflow);
            this.Controls.Add(this.lblReturnQuantity);
            this.Controls.Add(this.lblckbRiceOverflow);
            this.Controls.Add(this.lblStayQuantity);
            this.Controls.Add(this.lblEvent);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.btnCheckInEvent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmCheckInEvent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Check In Boxing Event";
            this.gbxDetails.ResumeLayout(false);
            this.gbxDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStayQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudReturnQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnMainMenu;
        public System.Windows.Forms.Button btnCheckInEvent;
        public System.Windows.Forms.Label lblHeader;
        public System.Windows.Forms.Label lblEvent;
        public System.Windows.Forms.Label lblStayQuantity;
        public System.Windows.Forms.Label lblReturnQuantity;
        public System.Windows.Forms.Label lblckbRiceOverflow;
        public System.Windows.Forms.Label lblckbSoyOverflow;
        public System.Windows.Forms.Label lblLocation;
        public System.Windows.Forms.Label lblDate;
        public System.Windows.Forms.Label lblName;
        public System.Windows.Forms.Label lblBoxCode;
        public System.Windows.Forms.Label lblBoxCodeDisplay;
        public System.Windows.Forms.Label lblLocationDisplay;
        public System.Windows.Forms.Label lblDateDisplay;
        public System.Windows.Forms.Label lblNameDisplay;
        public System.Windows.Forms.ComboBox cbxEvent;
        public System.Windows.Forms.GroupBox gbxDetails;
        public System.Windows.Forms.NumericUpDown nudStayQuantity;
        public System.Windows.Forms.NumericUpDown nudReturnQuantity;
        public System.Windows.Forms.CheckBox ckbRiceOverflow;
        public System.Windows.Forms.CheckBox ckbSoyOverflow;
    }
}