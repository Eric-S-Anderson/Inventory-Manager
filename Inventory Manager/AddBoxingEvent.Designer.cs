namespace Inventory_Manager
{
    partial class frmAddBoxingEvent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddBoxingEvent));
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.btnAddEvent = new System.Windows.Forms.Button();
            this.lblEventName = new System.Windows.Forms.Label();
            this.txtEventName = new System.Windows.Forms.TextBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblEventDate = new System.Windows.Forms.Label();
            this.dtpEventDate = new System.Windows.Forms.DateTimePicker();
            this.lblPackingLocation = new System.Windows.Forms.Label();
            this.cbxPackingLocation = new System.Windows.Forms.ComboBox();
            this.lblTrailer = new System.Windows.Forms.Label();
            this.btnAddPackingLocation = new System.Windows.Forms.Button();
            this.btnAddTrailer = new System.Windows.Forms.Button();
            this.txtBoxCode = new System.Windows.Forms.TextBox();
            this.lblBoxCode = new System.Windows.Forms.Label();
            this.clbTrailer = new System.Windows.Forms.CheckedListBox();
            this.lblRice = new System.Windows.Forms.Label();
            this.btnAddRice = new System.Windows.Forms.Button();
            this.lblSoy = new System.Windows.Forms.Label();
            this.btnAddSoy = new System.Windows.Forms.Button();
            this.lblVitamin = new System.Windows.Forms.Label();
            this.btnAddVitamin = new System.Windows.Forms.Button();
            this.lblVeggie = new System.Windows.Forms.Label();
            this.btnAddVeggie = new System.Windows.Forms.Button();
            this.lblTrailerColumnOne = new System.Windows.Forms.Label();
            this.lblTrailerColumnTwo = new System.Windows.Forms.Label();
            this.lblRiceColumnOne = new System.Windows.Forms.Label();
            this.lblRiceColumnTwo = new System.Windows.Forms.Label();
            this.lblSoyColumnOne = new System.Windows.Forms.Label();
            this.lblVitaminColumnOne = new System.Windows.Forms.Label();
            this.lblVitaminColumnTwo = new System.Windows.Forms.Label();
            this.lblVeggieColumnOne = new System.Windows.Forms.Label();
            this.lblVeggieColumnTwo = new System.Windows.Forms.Label();
            this.flpRice = new System.Windows.Forms.FlowLayoutPanel();
            this.flpSoy = new System.Windows.Forms.FlowLayoutPanel();
            this.flpVitamin = new System.Windows.Forms.FlowLayoutPanel();
            this.flpVeggie = new System.Windows.Forms.FlowLayoutPanel();
            this.btnGenerateCode = new System.Windows.Forms.Button();
            this.ckbRice = new System.Windows.Forms.CheckBox();
            this.lblckbRice = new System.Windows.Forms.Label();
            this.ckbSoy = new System.Windows.Forms.CheckBox();
            this.lblckbSoy = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnMainMenu.Location = new System.Drawing.Point(858, 751);
            this.btnMainMenu.Margin = new System.Windows.Forms.Padding(0);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(200, 75);
            this.btnMainMenu.TabIndex = 19;
            this.btnMainMenu.Tag = "Menu";
            this.btnMainMenu.Text = "Main Menu";
            this.btnMainMenu.UseVisualStyleBackColor = true;
            // 
            // btnAddEvent
            // 
            this.btnAddEvent.Location = new System.Drawing.Point(647, 751);
            this.btnAddEvent.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddEvent.Name = "btnAddEvent";
            this.btnAddEvent.Size = new System.Drawing.Size(200, 75);
            this.btnAddEvent.TabIndex = 18;
            this.btnAddEvent.Text = "Add Event";
            this.btnAddEvent.UseVisualStyleBackColor = true;
            this.btnAddEvent.Click += new System.EventHandler(this.btnAddEvent_Click);
            // 
            // lblEventName
            // 
            this.lblEventName.AutoSize = true;
            this.lblEventName.Font = new System.Drawing.Font("Kristen ITC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventName.Location = new System.Drawing.Point(26, 128);
            this.lblEventName.Name = "lblEventName";
            this.lblEventName.Size = new System.Drawing.Size(137, 28);
            this.lblEventName.TabIndex = 11;
            this.lblEventName.Text = "Event Name:";
            // 
            // txtEventName
            // 
            this.txtEventName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEventName.Location = new System.Drawing.Point(184, 126);
            this.txtEventName.Name = "txtEventName";
            this.txtEventName.Size = new System.Drawing.Size(322, 30);
            this.txtEventName.TabIndex = 0;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Kristen ITC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(445, 42);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(218, 28);
            this.lblHeader.TabIndex = 11;
            this.lblHeader.Text = "Create A New Event";
            // 
            // lblEventDate
            // 
            this.lblEventDate.AutoSize = true;
            this.lblEventDate.Font = new System.Drawing.Font("Kristen ITC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventDate.Location = new System.Drawing.Point(33, 180);
            this.lblEventDate.Name = "lblEventDate";
            this.lblEventDate.Size = new System.Drawing.Size(130, 28);
            this.lblEventDate.TabIndex = 11;
            this.lblEventDate.Text = "Event Date:";
            // 
            // dtpEventDate
            // 
            this.dtpEventDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEventDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEventDate.Location = new System.Drawing.Point(184, 176);
            this.dtpEventDate.Name = "dtpEventDate";
            this.dtpEventDate.Size = new System.Drawing.Size(322, 30);
            this.dtpEventDate.TabIndex = 1;
            // 
            // lblPackingLocation
            // 
            this.lblPackingLocation.AutoSize = true;
            this.lblPackingLocation.Font = new System.Drawing.Font("Kristen ITC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPackingLocation.Location = new System.Drawing.Point(56, 228);
            this.lblPackingLocation.Name = "lblPackingLocation";
            this.lblPackingLocation.Size = new System.Drawing.Size(107, 28);
            this.lblPackingLocation.TabIndex = 11;
            this.lblPackingLocation.Text = "Location:";
            // 
            // cbxPackingLocation
            // 
            this.cbxPackingLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPackingLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxPackingLocation.FormattingEnabled = true;
            this.cbxPackingLocation.Location = new System.Drawing.Point(184, 226);
            this.cbxPackingLocation.Name = "cbxPackingLocation";
            this.cbxPackingLocation.Size = new System.Drawing.Size(322, 33);
            this.cbxPackingLocation.TabIndex = 2;
            // 
            // lblTrailer
            // 
            this.lblTrailer.AutoSize = true;
            this.lblTrailer.Font = new System.Drawing.Font("Kristen ITC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrailer.Location = new System.Drawing.Point(525, 127);
            this.lblTrailer.Name = "lblTrailer";
            this.lblTrailer.Size = new System.Drawing.Size(84, 28);
            this.lblTrailer.TabIndex = 11;
            this.lblTrailer.Text = "Trailer:";
            // 
            // btnAddPackingLocation
            // 
            this.btnAddPackingLocation.Location = new System.Drawing.Point(525, 224);
            this.btnAddPackingLocation.Name = "btnAddPackingLocation";
            this.btnAddPackingLocation.Size = new System.Drawing.Size(35, 35);
            this.btnAddPackingLocation.TabIndex = 3;
            this.btnAddPackingLocation.Tag = "Add";
            this.btnAddPackingLocation.Text = "+";
            this.btnAddPackingLocation.UseVisualStyleBackColor = true;
            this.btnAddPackingLocation.Click += new System.EventHandler(this.btnAddPackingLocation_Click);
            // 
            // btnAddTrailer
            // 
            this.btnAddTrailer.Location = new System.Drawing.Point(1023, 126);
            this.btnAddTrailer.Name = "btnAddTrailer";
            this.btnAddTrailer.Size = new System.Drawing.Size(35, 35);
            this.btnAddTrailer.TabIndex = 5;
            this.btnAddTrailer.Tag = "Add";
            this.btnAddTrailer.Text = "+";
            this.btnAddTrailer.UseVisualStyleBackColor = true;
            this.btnAddTrailer.Click += new System.EventHandler(this.btnAddTrailer_Click);
            // 
            // txtBoxCode
            // 
            this.txtBoxCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCode.Location = new System.Drawing.Point(388, 684);
            this.txtBoxCode.Name = "txtBoxCode";
            this.txtBoxCode.Size = new System.Drawing.Size(322, 30);
            this.txtBoxCode.TabIndex = 16;
            // 
            // lblBoxCode
            // 
            this.lblBoxCode.AutoSize = true;
            this.lblBoxCode.Font = new System.Drawing.Font("Kristen ITC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBoxCode.Location = new System.Drawing.Point(252, 686);
            this.lblBoxCode.Name = "lblBoxCode";
            this.lblBoxCode.Size = new System.Drawing.Size(115, 28);
            this.lblBoxCode.TabIndex = 11;
            this.lblBoxCode.Text = "Box Code:";
            // 
            // clbTrailer
            // 
            this.clbTrailer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbTrailer.FormattingEnabled = true;
            this.clbTrailer.Location = new System.Drawing.Point(632, 126);
            this.clbTrailer.Name = "clbTrailer";
            this.clbTrailer.Size = new System.Drawing.Size(360, 154);
            this.clbTrailer.TabIndex = 4;
            // 
            // lblRice
            // 
            this.lblRice.AutoSize = true;
            this.lblRice.Font = new System.Drawing.Font("Kristen ITC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRice.Location = new System.Drawing.Point(19, 354);
            this.lblRice.Name = "lblRice";
            this.lblRice.Size = new System.Drawing.Size(62, 28);
            this.lblRice.TabIndex = 11;
            this.lblRice.Text = "Rice:";
            // 
            // btnAddRice
            // 
            this.btnAddRice.Location = new System.Drawing.Point(487, 354);
            this.btnAddRice.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddRice.Name = "btnAddRice";
            this.btnAddRice.Size = new System.Drawing.Size(35, 35);
            this.btnAddRice.TabIndex = 7;
            this.btnAddRice.Tag = "Add";
            this.btnAddRice.Text = "+";
            this.btnAddRice.UseVisualStyleBackColor = true;
            this.btnAddRice.Click += new System.EventHandler(this.btnAddRice_Click);
            // 
            // lblSoy
            // 
            this.lblSoy.AutoSize = true;
            this.lblSoy.Font = new System.Drawing.Font("Kristen ITC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoy.Location = new System.Drawing.Point(30, 530);
            this.lblSoy.Name = "lblSoy";
            this.lblSoy.Size = new System.Drawing.Size(51, 28);
            this.lblSoy.TabIndex = 11;
            this.lblSoy.Text = "Soy:";
            // 
            // btnAddSoy
            // 
            this.btnAddSoy.Location = new System.Drawing.Point(487, 530);
            this.btnAddSoy.Name = "btnAddSoy";
            this.btnAddSoy.Size = new System.Drawing.Size(35, 35);
            this.btnAddSoy.TabIndex = 12;
            this.btnAddSoy.Tag = "Add";
            this.btnAddSoy.Text = "+";
            this.btnAddSoy.UseVisualStyleBackColor = true;
            this.btnAddSoy.Click += new System.EventHandler(this.btnAddSoy_Click);
            // 
            // lblVitamin
            // 
            this.lblVitamin.AutoSize = true;
            this.lblVitamin.Font = new System.Drawing.Font("Kristen ITC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVitamin.Location = new System.Drawing.Point(533, 356);
            this.lblVitamin.Name = "lblVitamin";
            this.lblVitamin.Size = new System.Drawing.Size(93, 28);
            this.lblVitamin.TabIndex = 11;
            this.lblVitamin.Text = "Vitamin:";
            // 
            // btnAddVitamin
            // 
            this.btnAddVitamin.Location = new System.Drawing.Point(1023, 356);
            this.btnAddVitamin.Name = "btnAddVitamin";
            this.btnAddVitamin.Size = new System.Drawing.Size(35, 35);
            this.btnAddVitamin.TabIndex = 10;
            this.btnAddVitamin.Tag = "Add";
            this.btnAddVitamin.Text = "+";
            this.btnAddVitamin.UseVisualStyleBackColor = true;
            this.btnAddVitamin.Click += new System.EventHandler(this.btnAddVitamin_Click);
            // 
            // lblVeggie
            // 
            this.lblVeggie.AutoSize = true;
            this.lblVeggie.Font = new System.Drawing.Font("Kristen ITC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVeggie.Location = new System.Drawing.Point(543, 531);
            this.lblVeggie.Name = "lblVeggie";
            this.lblVeggie.Size = new System.Drawing.Size(83, 28);
            this.lblVeggie.TabIndex = 11;
            this.lblVeggie.Text = "Veggie:";
            // 
            // btnAddVeggie
            // 
            this.btnAddVeggie.Location = new System.Drawing.Point(1023, 531);
            this.btnAddVeggie.Name = "btnAddVeggie";
            this.btnAddVeggie.Size = new System.Drawing.Size(35, 35);
            this.btnAddVeggie.TabIndex = 15;
            this.btnAddVeggie.Tag = "Add";
            this.btnAddVeggie.Text = "+";
            this.btnAddVeggie.UseVisualStyleBackColor = true;
            this.btnAddVeggie.Click += new System.EventHandler(this.btnAddVeggie_Click);
            // 
            // lblTrailerColumnOne
            // 
            this.lblTrailerColumnOne.AutoSize = true;
            this.lblTrailerColumnOne.Font = new System.Drawing.Font("Kristen ITC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrailerColumnOne.Location = new System.Drawing.Point(668, 95);
            this.lblTrailerColumnOne.Name = "lblTrailerColumnOne";
            this.lblTrailerColumnOne.Size = new System.Drawing.Size(68, 28);
            this.lblTrailerColumnOne.TabIndex = 11;
            this.lblTrailerColumnOne.Text = "Name";
            // 
            // lblTrailerColumnTwo
            // 
            this.lblTrailerColumnTwo.AutoSize = true;
            this.lblTrailerColumnTwo.Font = new System.Drawing.Font("Kristen ITC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrailerColumnTwo.Location = new System.Drawing.Point(853, 95);
            this.lblTrailerColumnTwo.Name = "lblTrailerColumnTwo";
            this.lblTrailerColumnTwo.Size = new System.Drawing.Size(53, 28);
            this.lblTrailerColumnTwo.TabIndex = 11;
            this.lblTrailerColumnTwo.Text = "VIN";
            // 
            // lblRiceColumnOne
            // 
            this.lblRiceColumnOne.AutoSize = true;
            this.lblRiceColumnOne.Font = new System.Drawing.Font("Kristen ITC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRiceColumnOne.Location = new System.Drawing.Point(130, 323);
            this.lblRiceColumnOne.Name = "lblRiceColumnOne";
            this.lblRiceColumnOne.Size = new System.Drawing.Size(68, 28);
            this.lblRiceColumnOne.TabIndex = 11;
            this.lblRiceColumnOne.Text = "Lot #";
            // 
            // lblRiceColumnTwo
            // 
            this.lblRiceColumnTwo.AutoSize = true;
            this.lblRiceColumnTwo.Font = new System.Drawing.Font("Kristen ITC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRiceColumnTwo.Location = new System.Drawing.Point(294, 323);
            this.lblRiceColumnTwo.Name = "lblRiceColumnTwo";
            this.lblRiceColumnTwo.Size = new System.Drawing.Size(98, 28);
            this.lblRiceColumnTwo.TabIndex = 11;
            this.lblRiceColumnTwo.Text = "Quantity";
            // 
            // lblSoyColumnOne
            // 
            this.lblSoyColumnOne.AutoSize = true;
            this.lblSoyColumnOne.Font = new System.Drawing.Font("Kristen ITC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoyColumnOne.Location = new System.Drawing.Point(240, 499);
            this.lblSoyColumnOne.Name = "lblSoyColumnOne";
            this.lblSoyColumnOne.Size = new System.Drawing.Size(68, 28);
            this.lblSoyColumnOne.TabIndex = 11;
            this.lblSoyColumnOne.Text = "Bag #";
            // 
            // lblVitaminColumnOne
            // 
            this.lblVitaminColumnOne.AutoSize = true;
            this.lblVitaminColumnOne.Font = new System.Drawing.Font("Kristen ITC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVitaminColumnOne.Location = new System.Drawing.Point(685, 324);
            this.lblVitaminColumnOne.Name = "lblVitaminColumnOne";
            this.lblVitaminColumnOne.Size = new System.Drawing.Size(68, 28);
            this.lblVitaminColumnOne.TabIndex = 11;
            this.lblVitaminColumnOne.Text = "Lot #";
            // 
            // lblVitaminColumnTwo
            // 
            this.lblVitaminColumnTwo.AutoSize = true;
            this.lblVitaminColumnTwo.Font = new System.Drawing.Font("Kristen ITC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVitaminColumnTwo.Location = new System.Drawing.Point(862, 324);
            this.lblVitaminColumnTwo.Name = "lblVitaminColumnTwo";
            this.lblVitaminColumnTwo.Size = new System.Drawing.Size(70, 28);
            this.lblVitaminColumnTwo.TabIndex = 11;
            this.lblVitaminColumnTwo.Text = "Box #";
            // 
            // lblVeggieColumnOne
            // 
            this.lblVeggieColumnOne.AutoSize = true;
            this.lblVeggieColumnOne.Font = new System.Drawing.Font("Kristen ITC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVeggieColumnOne.Location = new System.Drawing.Point(685, 500);
            this.lblVeggieColumnOne.Name = "lblVeggieColumnOne";
            this.lblVeggieColumnOne.Size = new System.Drawing.Size(68, 28);
            this.lblVeggieColumnOne.TabIndex = 11;
            this.lblVeggieColumnOne.Text = "Lot #";
            // 
            // lblVeggieColumnTwo
            // 
            this.lblVeggieColumnTwo.AutoSize = true;
            this.lblVeggieColumnTwo.Font = new System.Drawing.Font("Kristen ITC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVeggieColumnTwo.Location = new System.Drawing.Point(862, 499);
            this.lblVeggieColumnTwo.Name = "lblVeggieColumnTwo";
            this.lblVeggieColumnTwo.Size = new System.Drawing.Size(70, 28);
            this.lblVeggieColumnTwo.TabIndex = 11;
            this.lblVeggieColumnTwo.Text = "Box #";
            // 
            // flpRice
            // 
            this.flpRice.AutoScroll = true;
            this.flpRice.BackColor = System.Drawing.SystemColors.ControlLight;
            this.flpRice.Location = new System.Drawing.Point(100, 354);
            this.flpRice.Margin = new System.Windows.Forms.Padding(0);
            this.flpRice.Name = "flpRice";
            this.flpRice.Size = new System.Drawing.Size(360, 105);
            this.flpRice.TabIndex = 6;
            // 
            // flpSoy
            // 
            this.flpSoy.AutoScroll = true;
            this.flpSoy.BackColor = System.Drawing.SystemColors.ControlLight;
            this.flpSoy.Location = new System.Drawing.Point(100, 529);
            this.flpSoy.Margin = new System.Windows.Forms.Padding(0);
            this.flpSoy.Name = "flpSoy";
            this.flpSoy.Size = new System.Drawing.Size(360, 105);
            this.flpSoy.TabIndex = 11;
            // 
            // flpVitamin
            // 
            this.flpVitamin.AutoScroll = true;
            this.flpVitamin.BackColor = System.Drawing.SystemColors.ControlLight;
            this.flpVitamin.Location = new System.Drawing.Point(632, 356);
            this.flpVitamin.Margin = new System.Windows.Forms.Padding(0);
            this.flpVitamin.Name = "flpVitamin";
            this.flpVitamin.Size = new System.Drawing.Size(360, 105);
            this.flpVitamin.TabIndex = 9;
            // 
            // flpVeggie
            // 
            this.flpVeggie.AutoScroll = true;
            this.flpVeggie.BackColor = System.Drawing.SystemColors.ControlLight;
            this.flpVeggie.Location = new System.Drawing.Point(632, 530);
            this.flpVeggie.Margin = new System.Windows.Forms.Padding(0);
            this.flpVeggie.Name = "flpVeggie";
            this.flpVeggie.Size = new System.Drawing.Size(360, 105);
            this.flpVeggie.TabIndex = 14;
            // 
            // btnGenerateCode
            // 
            this.btnGenerateCode.Font = new System.Drawing.Font("Kristen ITC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateCode.Location = new System.Drawing.Point(732, 681);
            this.btnGenerateCode.Name = "btnGenerateCode";
            this.btnGenerateCode.Size = new System.Drawing.Size(200, 38);
            this.btnGenerateCode.TabIndex = 17;
            this.btnGenerateCode.Tag = "Generate";
            this.btnGenerateCode.Text = "Auto-Generate";
            this.btnGenerateCode.UseVisualStyleBackColor = true;
            this.btnGenerateCode.Click += new System.EventHandler(this.btnGenerateCode_Click);
            // 
            // ckbRice
            // 
            this.ckbRice.AutoSize = true;
            this.ckbRice.Location = new System.Drawing.Point(497, 407);
            this.ckbRice.Margin = new System.Windows.Forms.Padding(0);
            this.ckbRice.Name = "ckbRice";
            this.ckbRice.Size = new System.Drawing.Size(15, 14);
            this.ckbRice.TabIndex = 8;
            this.ckbRice.UseVisualStyleBackColor = true;
            // 
            // lblckbRice
            // 
            this.lblckbRice.Location = new System.Drawing.Point(479, 425);
            this.lblckbRice.Name = "lblckbRice";
            this.lblckbRice.Size = new System.Drawing.Size(50, 26);
            this.lblckbRice.TabIndex = 22;
            this.lblckbRice.Tag = "Checkbox";
            this.lblckbRice.Text = "Use Overflow";
            this.lblckbRice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ckbSoy
            // 
            this.ckbSoy.AutoSize = true;
            this.ckbSoy.Location = new System.Drawing.Point(497, 577);
            this.ckbSoy.Margin = new System.Windows.Forms.Padding(0);
            this.ckbSoy.Name = "ckbSoy";
            this.ckbSoy.Size = new System.Drawing.Size(15, 14);
            this.ckbSoy.TabIndex = 13;
            this.ckbSoy.UseVisualStyleBackColor = true;
            // 
            // lblckbSoy
            // 
            this.lblckbSoy.Location = new System.Drawing.Point(479, 595);
            this.lblckbSoy.Name = "lblckbSoy";
            this.lblckbSoy.Size = new System.Drawing.Size(50, 26);
            this.lblckbSoy.TabIndex = 22;
            this.lblckbSoy.Tag = "Checkbox";
            this.lblckbSoy.Text = "Use Overflow";
            this.lblckbSoy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmAddBoxingEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 835);
            this.Controls.Add(this.lblckbSoy);
            this.Controls.Add(this.ckbSoy);
            this.Controls.Add(this.lblckbRice);
            this.Controls.Add(this.ckbRice);
            this.Controls.Add(this.btnGenerateCode);
            this.Controls.Add(this.flpVeggie);
            this.Controls.Add(this.flpVitamin);
            this.Controls.Add(this.flpSoy);
            this.Controls.Add(this.flpRice);
            this.Controls.Add(this.clbTrailer);
            this.Controls.Add(this.btnAddSoy);
            this.Controls.Add(this.btnAddVeggie);
            this.Controls.Add(this.btnAddVitamin);
            this.Controls.Add(this.btnAddTrailer);
            this.Controls.Add(this.btnAddRice);
            this.Controls.Add(this.btnAddPackingLocation);
            this.Controls.Add(this.cbxPackingLocation);
            this.Controls.Add(this.dtpEventDate);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.lblSoy);
            this.Controls.Add(this.lblVeggie);
            this.Controls.Add(this.lblVitamin);
            this.Controls.Add(this.lblTrailer);
            this.Controls.Add(this.lblTrailerColumnTwo);
            this.Controls.Add(this.lblRiceColumnTwo);
            this.Controls.Add(this.lblSoyColumnOne);
            this.Controls.Add(this.lblVeggieColumnTwo);
            this.Controls.Add(this.lblVitaminColumnTwo);
            this.Controls.Add(this.lblVeggieColumnOne);
            this.Controls.Add(this.lblVitaminColumnOne);
            this.Controls.Add(this.lblRiceColumnOne);
            this.Controls.Add(this.lblTrailerColumnOne);
            this.Controls.Add(this.lblRice);
            this.Controls.Add(this.lblPackingLocation);
            this.Controls.Add(this.lblEventDate);
            this.Controls.Add(this.lblBoxCode);
            this.Controls.Add(this.lblEventName);
            this.Controls.Add(this.txtBoxCode);
            this.Controls.Add(this.txtEventName);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.btnAddEvent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmAddBoxingEvent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Boxing Event";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnMainMenu;
        public System.Windows.Forms.Button btnAddEvent;
        public System.Windows.Forms.Label lblEventName;
        public System.Windows.Forms.TextBox txtEventName;
        public System.Windows.Forms.Label lblHeader;
        public System.Windows.Forms.Label lblEventDate;
        public System.Windows.Forms.DateTimePicker dtpEventDate;
        public System.Windows.Forms.Label lblPackingLocation;
        public System.Windows.Forms.ComboBox cbxPackingLocation;
        public System.Windows.Forms.Label lblTrailer;
        public System.Windows.Forms.Button btnAddPackingLocation;
        public System.Windows.Forms.Button btnAddTrailer;
        public System.Windows.Forms.TextBox txtBoxCode;
        public System.Windows.Forms.Label lblBoxCode;
        public System.Windows.Forms.CheckedListBox clbTrailer;
        public System.Windows.Forms.Label lblRice;
        public System.Windows.Forms.Button btnAddRice;
        public System.Windows.Forms.Label lblSoy;
        public System.Windows.Forms.Button btnAddSoy;
        public System.Windows.Forms.Label lblVitamin;
        public System.Windows.Forms.Button btnAddVitamin;
        public System.Windows.Forms.Label lblVeggie;
        public System.Windows.Forms.Button btnAddVeggie;
        public System.Windows.Forms.Label lblVitaminColumnOne;
        public System.Windows.Forms.Label lblVitaminColumnTwo;
        public System.Windows.Forms.Label lblVeggieColumnOne;
        public System.Windows.Forms.Label lblVeggieColumnTwo;
        public System.Windows.Forms.Label lblSoyColumnOne;
        public System.Windows.Forms.Label lblRiceColumnTwo;
        public System.Windows.Forms.Label lblRiceColumnOne;
        public System.Windows.Forms.Label lblTrailerColumnTwo;
        public System.Windows.Forms.Label lblTrailerColumnOne;
        public System.Windows.Forms.FlowLayoutPanel flpRice;
        public System.Windows.Forms.FlowLayoutPanel flpSoy;
        public System.Windows.Forms.FlowLayoutPanel flpVitamin;
        public System.Windows.Forms.FlowLayoutPanel flpVeggie;
        public System.Windows.Forms.Button btnGenerateCode;
        public System.Windows.Forms.Label lblckbRice;
        public System.Windows.Forms.CheckBox ckbRice;
        public System.Windows.Forms.CheckBox ckbSoy;
        public System.Windows.Forms.Label lblckbSoy;
    }
}