namespace Inventory_Manager
{
    partial class frmTrackEvent
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTrackEvent));
            this.dgvLocation = new System.Windows.Forms.DataGridView();
            this.dgvBox = new System.Windows.Forms.DataGridView();
            this.dgvEvent = new System.Windows.Forms.DataGridView();
            this.lblEventDate = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblEventInfo = new System.Windows.Forms.Label();
            this.lblBoxInfo = new System.Windows.Forms.Label();
            this.lblLocationInfo = new System.Windows.Forms.Label();
            this.lblEventName = new System.Windows.Forms.Label();
            this.txtEventName = new System.Windows.Forms.TextBox();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.btnTrack = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.lblLocationName = new System.Windows.Forms.Label();
            this.dtpEventDate = new System.Windows.Forms.DateTimePicker();
            this.cbxLocation = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvent)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLocation
            // 
            this.dgvLocation.AllowUserToAddRows = false;
            this.dgvLocation.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLocation.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLocation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLocation.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvLocation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvLocation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvLocation.Location = new System.Drawing.Point(265, 330);
            this.dgvLocation.Name = "dgvLocation";
            this.dgvLocation.ReadOnly = true;
            this.dgvLocation.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvLocation.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLocation.Size = new System.Drawing.Size(520, 88);
            this.dgvLocation.TabIndex = 41;
            this.dgvLocation.TabStop = false;
            // 
            // dgvBox
            // 
            this.dgvBox.AllowUserToAddRows = false;
            this.dgvBox.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBox.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBox.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBox.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvBox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvBox.Location = new System.Drawing.Point(265, 211);
            this.dgvBox.Name = "dgvBox";
            this.dgvBox.ReadOnly = true;
            this.dgvBox.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvBox.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvBox.Size = new System.Drawing.Size(450, 88);
            this.dgvBox.TabIndex = 42;
            this.dgvBox.TabStop = false;
            // 
            // dgvEvent
            // 
            this.dgvEvent.AllowUserToAddRows = false;
            this.dgvEvent.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEvent.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvEvent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEvent.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvEvent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvEvent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvEvent.Location = new System.Drawing.Point(265, 93);
            this.dgvEvent.Name = "dgvEvent";
            this.dgvEvent.ReadOnly = true;
            this.dgvEvent.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvEvent.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvEvent.Size = new System.Drawing.Size(520, 88);
            this.dgvEvent.TabIndex = 43;
            this.dgvEvent.TabStop = false;
            // 
            // lblEventDate
            // 
            this.lblEventDate.AutoSize = true;
            this.lblEventDate.Font = new System.Drawing.Font("Kristen ITC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventDate.Location = new System.Drawing.Point(59, 480);
            this.lblEventDate.Name = "lblEventDate";
            this.lblEventDate.Size = new System.Drawing.Size(130, 28);
            this.lblEventDate.TabIndex = 35;
            this.lblEventDate.Text = "Event Date:";
            this.lblEventDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Kristen ITC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(301, 50);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(153, 28);
            this.lblHeader.TabIndex = 36;
            this.lblHeader.Text = "Track Event(s)";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEventInfo
            // 
            this.lblEventInfo.AutoSize = true;
            this.lblEventInfo.Font = new System.Drawing.Font("Kristen ITC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventInfo.Location = new System.Drawing.Point(50, 129);
            this.lblEventInfo.Name = "lblEventInfo";
            this.lblEventInfo.Size = new System.Drawing.Size(198, 28);
            this.lblEventInfo.TabIndex = 37;
            this.lblEventInfo.Text = "Event Information:";
            this.lblEventInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBoxInfo
            // 
            this.lblBoxInfo.AutoSize = true;
            this.lblBoxInfo.Font = new System.Drawing.Font("Kristen ITC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBoxInfo.Location = new System.Drawing.Point(69, 247);
            this.lblBoxInfo.Name = "lblBoxInfo";
            this.lblBoxInfo.Size = new System.Drawing.Size(179, 28);
            this.lblBoxInfo.TabIndex = 38;
            this.lblBoxInfo.Text = "Box Information:";
            this.lblBoxInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLocationInfo
            // 
            this.lblLocationInfo.AutoSize = true;
            this.lblLocationInfo.Font = new System.Drawing.Font("Kristen ITC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocationInfo.Location = new System.Drawing.Point(18, 356);
            this.lblLocationInfo.Name = "lblLocationInfo";
            this.lblLocationInfo.Size = new System.Drawing.Size(230, 28);
            this.lblLocationInfo.TabIndex = 39;
            this.lblLocationInfo.Text = "Location Information:";
            this.lblLocationInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEventName
            // 
            this.lblEventName.AutoSize = true;
            this.lblEventName.Font = new System.Drawing.Font("Kristen ITC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventName.Location = new System.Drawing.Point(52, 437);
            this.lblEventName.Name = "lblEventName";
            this.lblEventName.Size = new System.Drawing.Size(137, 28);
            this.lblEventName.TabIndex = 40;
            this.lblEventName.Text = "Event Name:";
            this.lblEventName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtEventName
            // 
            this.txtEventName.Font = new System.Drawing.Font("Kristen ITC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEventName.Location = new System.Drawing.Point(203, 434);
            this.txtEventName.Name = "txtEventName";
            this.txtEventName.Size = new System.Drawing.Size(352, 35);
            this.txtEventName.TabIndex = 0;
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnMainMenu.Location = new System.Drawing.Point(584, 544);
            this.btnMainMenu.Margin = new System.Windows.Forms.Padding(0);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(200, 75);
            this.btnMainMenu.TabIndex = 6;
            this.btnMainMenu.Tag = "Menu";
            this.btnMainMenu.Text = "Main Menu";
            this.btnMainMenu.UseVisualStyleBackColor = true;
            // 
            // btnTrack
            // 
            this.btnTrack.Location = new System.Drawing.Point(162, 570);
            this.btnTrack.Margin = new System.Windows.Forms.Padding(0);
            this.btnTrack.Name = "btnTrack";
            this.btnTrack.Size = new System.Drawing.Size(118, 49);
            this.btnTrack.TabIndex = 3;
            this.btnTrack.Text = "Track";
            this.btnTrack.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(299, 570);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(0);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(118, 49);
            this.btnPrint.TabIndex = 4;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // lblLocationName
            // 
            this.lblLocationName.AutoSize = true;
            this.lblLocationName.Font = new System.Drawing.Font("Kristen ITC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocationName.Location = new System.Drawing.Point(20, 520);
            this.lblLocationName.Name = "lblLocationName";
            this.lblLocationName.Size = new System.Drawing.Size(169, 28);
            this.lblLocationName.TabIndex = 35;
            this.lblLocationName.Text = "Location Name:";
            this.lblLocationName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpEventDate
            // 
            this.dtpEventDate.Font = new System.Drawing.Font("Kristen ITC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEventDate.Location = new System.Drawing.Point(203, 475);
            this.dtpEventDate.Name = "dtpEventDate";
            this.dtpEventDate.Size = new System.Drawing.Size(352, 35);
            this.dtpEventDate.TabIndex = 1;
            // 
            // cbxLocation
            // 
            this.cbxLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLocation.Font = new System.Drawing.Font("Kristen ITC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxLocation.FormattingEnabled = true;
            this.cbxLocation.Location = new System.Drawing.Point(203, 517);
            this.cbxLocation.Name = "cbxLocation";
            this.cbxLocation.Size = new System.Drawing.Size(352, 36);
            this.cbxLocation.TabIndex = 2;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(437, 570);
            this.btnClear.Margin = new System.Windows.Forms.Padding(0);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(118, 49);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // frmTrackEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 628);
            this.Controls.Add(this.cbxLocation);
            this.Controls.Add(this.dtpEventDate);
            this.Controls.Add(this.dgvLocation);
            this.Controls.Add(this.dgvBox);
            this.Controls.Add(this.dgvEvent);
            this.Controls.Add(this.lblLocationName);
            this.Controls.Add(this.lblEventDate);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.lblEventInfo);
            this.Controls.Add(this.lblBoxInfo);
            this.Controls.Add(this.lblLocationInfo);
            this.Controls.Add(this.lblEventName);
            this.Controls.Add(this.txtEventName);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnTrack);
            this.Controls.Add(this.btnPrint);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmTrackEvent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Track Event";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLocation;
        private System.Windows.Forms.DataGridView dgvBox;
        private System.Windows.Forms.DataGridView dgvEvent;
        public System.Windows.Forms.Label lblEventDate;
        public System.Windows.Forms.Label lblHeader;
        public System.Windows.Forms.Label lblEventInfo;
        public System.Windows.Forms.Label lblBoxInfo;
        public System.Windows.Forms.Label lblLocationInfo;
        public System.Windows.Forms.Label lblEventName;
        public System.Windows.Forms.TextBox txtEventName;
        public System.Windows.Forms.Button btnMainMenu;
        public System.Windows.Forms.Button btnTrack;
        public System.Windows.Forms.Button btnPrint;
        public System.Windows.Forms.Label lblLocationName;
        private System.Windows.Forms.DateTimePicker dtpEventDate;
        private System.Windows.Forms.ComboBox cbxLocation;
        public System.Windows.Forms.Button btnClear;
    }
}