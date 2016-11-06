namespace Inventory_Manager
{
    partial class frmMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenu));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExitApplication = new System.Windows.Forms.Button();
            this.btnCheckInEvent = new System.Windows.Forms.Button();
            this.btnAddBoxingEvent = new System.Windows.Forms.Button();
            this.btnPrintEvent = new System.Windows.Forms.Button();
            this.btnPrintShipment = new System.Windows.Forms.Button();
            this.btnAddShipment = new System.Windows.Forms.Button();
            this.btnTrackItem = new System.Windows.Forms.Button();
            this.gbxEvent = new System.Windows.Forms.GroupBox();
            this.gbxPrinting = new System.Windows.Forms.GroupBox();
            this.btnTrackEvent = new System.Windows.Forms.Button();
            this.gbxTracking = new System.Windows.Forms.GroupBox();
            this.gbxShipment = new System.Windows.Forms.GroupBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnInventory = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbxEvent.SuspendLayout();
            this.gbxPrinting.SuspendLayout();
            this.gbxTracking.SuspendLayout();
            this.gbxShipment.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Inventory_Manager.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(490, 89);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(315, 176);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnExitApplication
            // 
            this.btnExitApplication.BackColor = System.Drawing.Color.Transparent;
            this.btnExitApplication.BackgroundImage = global::Inventory_Manager.Properties.Resources.Button_7;
            this.btnExitApplication.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExitApplication.FlatAppearance.BorderSize = 0;
            this.btnExitApplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitApplication.Font = new System.Drawing.Font("Kristen ITC", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitApplication.ForeColor = System.Drawing.Color.White;
            this.btnExitApplication.Location = new System.Drawing.Point(605, 461);
            this.btnExitApplication.Margin = new System.Windows.Forms.Padding(5);
            this.btnExitApplication.Name = "btnExitApplication";
            this.btnExitApplication.Size = new System.Drawing.Size(200, 75);
            this.btnExitApplication.TabIndex = 1;
            this.btnExitApplication.Tag = "Exit";
            this.btnExitApplication.Text = "Exit";
            this.btnExitApplication.UseVisualStyleBackColor = false;
            this.btnExitApplication.Click += new System.EventHandler(this.btnExitApplication_Click);
            // 
            // btnCheckInEvent
            // 
            this.btnCheckInEvent.BackColor = System.Drawing.Color.Transparent;
            this.btnCheckInEvent.BackgroundImage = global::Inventory_Manager.Properties.Resources.Button_14;
            this.btnCheckInEvent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCheckInEvent.FlatAppearance.BorderSize = 0;
            this.btnCheckInEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckInEvent.Font = new System.Drawing.Font("Kristen ITC", 15F, System.Drawing.FontStyle.Bold);
            this.btnCheckInEvent.ForeColor = System.Drawing.Color.White;
            this.btnCheckInEvent.Location = new System.Drawing.Point(218, 21);
            this.btnCheckInEvent.Margin = new System.Windows.Forms.Padding(5);
            this.btnCheckInEvent.Name = "btnCheckInEvent";
            this.btnCheckInEvent.Size = new System.Drawing.Size(200, 75);
            this.btnCheckInEvent.TabIndex = 1;
            this.btnCheckInEvent.Text = "Check In Boxing Event";
            this.btnCheckInEvent.UseVisualStyleBackColor = false;
            this.btnCheckInEvent.Click += new System.EventHandler(this.btnCheckInEvent_Click);
            // 
            // btnAddBoxingEvent
            // 
            this.btnAddBoxingEvent.BackColor = System.Drawing.Color.Transparent;
            this.btnAddBoxingEvent.BackgroundImage = global::Inventory_Manager.Properties.Resources.Button_14;
            this.btnAddBoxingEvent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddBoxingEvent.FlatAppearance.BorderSize = 0;
            this.btnAddBoxingEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBoxingEvent.Font = new System.Drawing.Font("Kristen ITC", 15F, System.Drawing.FontStyle.Bold);
            this.btnAddBoxingEvent.ForeColor = System.Drawing.Color.White;
            this.btnAddBoxingEvent.Location = new System.Drawing.Point(8, 21);
            this.btnAddBoxingEvent.Margin = new System.Windows.Forms.Padding(5);
            this.btnAddBoxingEvent.Name = "btnAddBoxingEvent";
            this.btnAddBoxingEvent.Size = new System.Drawing.Size(200, 75);
            this.btnAddBoxingEvent.TabIndex = 1;
            this.btnAddBoxingEvent.Text = "Add Boxing Event";
            this.btnAddBoxingEvent.UseVisualStyleBackColor = false;
            this.btnAddBoxingEvent.Click += new System.EventHandler(this.btnAddBoxingEvent_Click);
            // 
            // btnPrintEvent
            // 
            this.btnPrintEvent.BackColor = System.Drawing.Color.Transparent;
            this.btnPrintEvent.BackgroundImage = global::Inventory_Manager.Properties.Resources.Button_14;
            this.btnPrintEvent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrintEvent.FlatAppearance.BorderSize = 0;
            this.btnPrintEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintEvent.Font = new System.Drawing.Font("Kristen ITC", 15F, System.Drawing.FontStyle.Bold);
            this.btnPrintEvent.ForeColor = System.Drawing.Color.White;
            this.btnPrintEvent.Location = new System.Drawing.Point(8, 21);
            this.btnPrintEvent.Margin = new System.Windows.Forms.Padding(5);
            this.btnPrintEvent.Name = "btnPrintEvent";
            this.btnPrintEvent.Size = new System.Drawing.Size(200, 75);
            this.btnPrintEvent.TabIndex = 1;
            this.btnPrintEvent.Text = "Print Event";
            this.btnPrintEvent.UseVisualStyleBackColor = false;
            this.btnPrintEvent.Click += new System.EventHandler(this.btnAddTrailer_Click);
            // 
            // btnPrintShipment
            // 
            this.btnPrintShipment.BackColor = System.Drawing.Color.Transparent;
            this.btnPrintShipment.BackgroundImage = global::Inventory_Manager.Properties.Resources.Button_14;
            this.btnPrintShipment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrintShipment.FlatAppearance.BorderSize = 0;
            this.btnPrintShipment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintShipment.Font = new System.Drawing.Font("Kristen ITC", 15F, System.Drawing.FontStyle.Bold);
            this.btnPrintShipment.ForeColor = System.Drawing.Color.White;
            this.btnPrintShipment.Location = new System.Drawing.Point(218, 21);
            this.btnPrintShipment.Margin = new System.Windows.Forms.Padding(5);
            this.btnPrintShipment.Name = "btnPrintShipment";
            this.btnPrintShipment.Size = new System.Drawing.Size(200, 75);
            this.btnPrintShipment.TabIndex = 1;
            this.btnPrintShipment.Text = "Print Shipment";
            this.btnPrintShipment.UseVisualStyleBackColor = false;
            this.btnPrintShipment.Click += new System.EventHandler(this.btnAddDOT_Click);
            // 
            // btnAddShipment
            // 
            this.btnAddShipment.BackColor = System.Drawing.Color.Transparent;
            this.btnAddShipment.BackgroundImage = global::Inventory_Manager.Properties.Resources.Button_14;
            this.btnAddShipment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddShipment.FlatAppearance.BorderSize = 0;
            this.btnAddShipment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddShipment.Font = new System.Drawing.Font("Kristen ITC", 15F, System.Drawing.FontStyle.Bold);
            this.btnAddShipment.ForeColor = System.Drawing.Color.White;
            this.btnAddShipment.Location = new System.Drawing.Point(8, 21);
            this.btnAddShipment.Margin = new System.Windows.Forms.Padding(5);
            this.btnAddShipment.Name = "btnAddShipment";
            this.btnAddShipment.Size = new System.Drawing.Size(200, 75);
            this.btnAddShipment.TabIndex = 1;
            this.btnAddShipment.Text = "Add Shipment";
            this.btnAddShipment.UseVisualStyleBackColor = false;
            this.btnAddShipment.Click += new System.EventHandler(this.btnAddShipment_Click);
            // 
            // btnTrackItem
            // 
            this.btnTrackItem.BackColor = System.Drawing.Color.Transparent;
            this.btnTrackItem.BackgroundImage = global::Inventory_Manager.Properties.Resources.Button_14;
            this.btnTrackItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTrackItem.FlatAppearance.BorderSize = 0;
            this.btnTrackItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrackItem.Font = new System.Drawing.Font("Kristen ITC", 15F, System.Drawing.FontStyle.Bold);
            this.btnTrackItem.ForeColor = System.Drawing.Color.White;
            this.btnTrackItem.Location = new System.Drawing.Point(218, 21);
            this.btnTrackItem.Margin = new System.Windows.Forms.Padding(5);
            this.btnTrackItem.Name = "btnTrackItem";
            this.btnTrackItem.Size = new System.Drawing.Size(200, 75);
            this.btnTrackItem.TabIndex = 1;
            this.btnTrackItem.Text = "Track Item(s)";
            this.btnTrackItem.UseVisualStyleBackColor = false;
            this.btnTrackItem.Click += new System.EventHandler(this.btnTrackItem_Click);
            // 
            // gbxEvent
            // 
            this.gbxEvent.Controls.Add(this.btnAddBoxingEvent);
            this.gbxEvent.Controls.Add(this.btnCheckInEvent);
            this.gbxEvent.Location = new System.Drawing.Point(19, 89);
            this.gbxEvent.Name = "gbxEvent";
            this.gbxEvent.Size = new System.Drawing.Size(426, 111);
            this.gbxEvent.TabIndex = 2;
            this.gbxEvent.TabStop = false;
            this.gbxEvent.Text = "Events";
            // 
            // gbxPrinting
            // 
            this.gbxPrinting.Controls.Add(this.btnPrintEvent);
            this.gbxPrinting.Controls.Add(this.btnPrintShipment);
            this.gbxPrinting.Location = new System.Drawing.Point(19, 440);
            this.gbxPrinting.Name = "gbxPrinting";
            this.gbxPrinting.Size = new System.Drawing.Size(426, 111);
            this.gbxPrinting.TabIndex = 3;
            this.gbxPrinting.TabStop = false;
            this.gbxPrinting.Text = "Printing";
            // 
            // btnTrackEvent
            // 
            this.btnTrackEvent.BackColor = System.Drawing.Color.Transparent;
            this.btnTrackEvent.BackgroundImage = global::Inventory_Manager.Properties.Resources.Button_14;
            this.btnTrackEvent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTrackEvent.FlatAppearance.BorderSize = 0;
            this.btnTrackEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrackEvent.Font = new System.Drawing.Font("Kristen ITC", 15F, System.Drawing.FontStyle.Bold);
            this.btnTrackEvent.ForeColor = System.Drawing.Color.White;
            this.btnTrackEvent.Location = new System.Drawing.Point(8, 21);
            this.btnTrackEvent.Margin = new System.Windows.Forms.Padding(5);
            this.btnTrackEvent.Name = "btnTrackEvent";
            this.btnTrackEvent.Size = new System.Drawing.Size(200, 75);
            this.btnTrackEvent.TabIndex = 1;
            this.btnTrackEvent.Text = "Track Event(s)";
            this.btnTrackEvent.UseVisualStyleBackColor = false;
            this.btnTrackEvent.Click += new System.EventHandler(this.btnTrackEvent_Click);
            // 
            // gbxTracking
            // 
            this.gbxTracking.Controls.Add(this.btnTrackEvent);
            this.gbxTracking.Controls.Add(this.btnTrackItem);
            this.gbxTracking.Location = new System.Drawing.Point(19, 323);
            this.gbxTracking.Name = "gbxTracking";
            this.gbxTracking.Size = new System.Drawing.Size(426, 111);
            this.gbxTracking.TabIndex = 4;
            this.gbxTracking.TabStop = false;
            this.gbxTracking.Text = "Tracking";
            // 
            // gbxShipment
            // 
            this.gbxShipment.Controls.Add(this.btnAddShipment);
            this.gbxShipment.Location = new System.Drawing.Point(19, 206);
            this.gbxShipment.Name = "gbxShipment";
            this.gbxShipment.Size = new System.Drawing.Size(218, 111);
            this.gbxShipment.TabIndex = 5;
            this.gbxShipment.TabStop = false;
            this.gbxShipment.Text = "Shipments";
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Kristen ITC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(343, 42);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(125, 28);
            this.lblHeader.TabIndex = 12;
            this.lblHeader.Text = "Main Menu";
            // 
            // btnInventory
            // 
            this.btnInventory.BackColor = System.Drawing.Color.Transparent;
            this.btnInventory.BackgroundImage = global::Inventory_Manager.Properties.Resources.Button_14;
            this.btnInventory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInventory.FlatAppearance.BorderSize = 0;
            this.btnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventory.Font = new System.Drawing.Font("Kristen ITC", 15F, System.Drawing.FontStyle.Bold);
            this.btnInventory.ForeColor = System.Drawing.Color.White;
            this.btnInventory.Location = new System.Drawing.Point(237, 227);
            this.btnInventory.Margin = new System.Windows.Forms.Padding(5);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(200, 75);
            this.btnInventory.TabIndex = 2;
            this.btnInventory.Text = "Check Inventory";
            this.btnInventory.UseVisualStyleBackColor = false;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 570);
            this.Controls.Add(this.btnInventory);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.gbxShipment);
            this.Controls.Add(this.gbxTracking);
            this.Controls.Add(this.gbxPrinting);
            this.Controls.Add(this.gbxEvent);
            this.Controls.Add(this.btnExitApplication);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMainMenu";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMainMenu_FormClosed);
            this.Shown += new System.EventHandler(this.frmMainMenu_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbxEvent.ResumeLayout(false);
            this.gbxPrinting.ResumeLayout(false);
            this.gbxTracking.ResumeLayout(false);
            this.gbxShipment.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnExitApplication;
        private System.Windows.Forms.Button btnCheckInEvent;
        private System.Windows.Forms.Button btnAddBoxingEvent;
        private System.Windows.Forms.Button btnPrintEvent;
        private System.Windows.Forms.Button btnPrintShipment;
        private System.Windows.Forms.Button btnAddShipment;
        private System.Windows.Forms.Button btnTrackItem;
        private System.Windows.Forms.GroupBox gbxEvent;
        private System.Windows.Forms.GroupBox gbxPrinting;
        private System.Windows.Forms.Button btnTrackEvent;
        private System.Windows.Forms.GroupBox gbxTracking;
        private System.Windows.Forms.GroupBox gbxShipment;
        public System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnInventory;
    }
}

