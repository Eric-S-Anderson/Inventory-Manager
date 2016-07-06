namespace Inventory_Manager
{
    partial class frmTrackFood
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTrackFood));
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.gbxType = new System.Windows.Forms.GroupBox();
            this.rdbVitamin = new System.Windows.Forms.RadioButton();
            this.rdbVegetable = new System.Windows.Forms.RadioButton();
            this.rdbSoy = new System.Windows.Forms.RadioButton();
            this.rdbRice = new System.Windows.Forms.RadioButton();
            this.lblLotNumber = new System.Windows.Forms.Label();
            this.txtLotNumber = new System.Windows.Forms.TextBox();
            this.lblBoxNumber = new System.Windows.Forms.Label();
            this.nudBoxNumber = new System.Windows.Forms.NumericUpDown();
            this.btnTrack = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblShippedBoxes = new System.Windows.Forms.Label();
            this.lblEventBoxes = new System.Windows.Forms.Label();
            this.lblOnHamd = new System.Windows.Forms.Label();
            this.dgvOnHand = new System.Windows.Forms.DataGridView();
            this.dgvEvent = new System.Windows.Forms.DataGridView();
            this.dgvShipped = new System.Windows.Forms.DataGridView();
            this.ckbUseBox = new System.Windows.Forms.CheckBox();
            this.gbxType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBoxNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOnHand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShipped)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnMainMenu.Location = new System.Drawing.Point(549, 536);
            this.btnMainMenu.Margin = new System.Windows.Forms.Padding(0);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(200, 75);
            this.btnMainMenu.TabIndex = 6;
            this.btnMainMenu.Tag = "Menu";
            this.btnMainMenu.Text = "Main Menu";
            this.btnMainMenu.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(297, 562);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(0);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(118, 49);
            this.btnPrint.TabIndex = 5;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // gbxType
            // 
            this.gbxType.Controls.Add(this.rdbVitamin);
            this.gbxType.Controls.Add(this.rdbVegetable);
            this.gbxType.Controls.Add(this.rdbSoy);
            this.gbxType.Controls.Add(this.rdbRice);
            this.gbxType.Location = new System.Drawing.Point(160, 498);
            this.gbxType.Name = "gbxType";
            this.gbxType.Size = new System.Drawing.Size(255, 49);
            this.gbxType.TabIndex = 3;
            this.gbxType.TabStop = false;
            this.gbxType.Text = "Type";
            // 
            // rdbVitamin
            // 
            this.rdbVitamin.AutoSize = true;
            this.rdbVitamin.Location = new System.Drawing.Point(187, 19);
            this.rdbVitamin.Name = "rdbVitamin";
            this.rdbVitamin.Size = new System.Drawing.Size(59, 17);
            this.rdbVitamin.TabIndex = 5;
            this.rdbVitamin.TabStop = true;
            this.rdbVitamin.Text = "Vitamin";
            this.rdbVitamin.UseVisualStyleBackColor = true;
            // 
            // rdbVegetable
            // 
            this.rdbVegetable.AutoSize = true;
            this.rdbVegetable.Location = new System.Drawing.Point(108, 19);
            this.rdbVegetable.Name = "rdbVegetable";
            this.rdbVegetable.Size = new System.Drawing.Size(73, 17);
            this.rdbVegetable.TabIndex = 4;
            this.rdbVegetable.TabStop = true;
            this.rdbVegetable.Text = "Vegetable";
            this.rdbVegetable.UseVisualStyleBackColor = true;
            // 
            // rdbSoy
            // 
            this.rdbSoy.AutoSize = true;
            this.rdbSoy.Location = new System.Drawing.Point(59, 19);
            this.rdbSoy.Name = "rdbSoy";
            this.rdbSoy.Size = new System.Drawing.Size(43, 17);
            this.rdbSoy.TabIndex = 3;
            this.rdbSoy.TabStop = true;
            this.rdbSoy.Text = "Soy";
            this.rdbSoy.UseVisualStyleBackColor = true;
            // 
            // rdbRice
            // 
            this.rdbRice.AutoSize = true;
            this.rdbRice.Location = new System.Drawing.Point(6, 19);
            this.rdbRice.Name = "rdbRice";
            this.rdbRice.Size = new System.Drawing.Size(47, 17);
            this.rdbRice.TabIndex = 2;
            this.rdbRice.TabStop = true;
            this.rdbRice.Text = "Rice";
            this.rdbRice.UseVisualStyleBackColor = true;
            // 
            // lblLotNumber
            // 
            this.lblLotNumber.AutoSize = true;
            this.lblLotNumber.Font = new System.Drawing.Font("Kristen ITC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLotNumber.Location = new System.Drawing.Point(15, 457);
            this.lblLotNumber.Name = "lblLotNumber";
            this.lblLotNumber.Size = new System.Drawing.Size(139, 28);
            this.lblLotNumber.TabIndex = 23;
            this.lblLotNumber.Text = "Lot Number:";
            this.lblLotNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtLotNumber
            // 
            this.txtLotNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLotNumber.Location = new System.Drawing.Point(166, 455);
            this.txtLotNumber.Name = "txtLotNumber";
            this.txtLotNumber.Size = new System.Drawing.Size(322, 30);
            this.txtLotNumber.TabIndex = 0;
            // 
            // lblBoxNumber
            // 
            this.lblBoxNumber.AutoSize = true;
            this.lblBoxNumber.Font = new System.Drawing.Font("Kristen ITC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBoxNumber.Location = new System.Drawing.Point(508, 457);
            this.lblBoxNumber.Name = "lblBoxNumber";
            this.lblBoxNumber.Size = new System.Drawing.Size(141, 28);
            this.lblBoxNumber.TabIndex = 23;
            this.lblBoxNumber.Text = "Box Number:";
            this.lblBoxNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nudBoxNumber
            // 
            this.nudBoxNumber.Font = new System.Drawing.Font("Kristen ITC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudBoxNumber.Location = new System.Drawing.Point(664, 455);
            this.nudBoxNumber.Name = "nudBoxNumber";
            this.nudBoxNumber.Size = new System.Drawing.Size(85, 35);
            this.nudBoxNumber.TabIndex = 1;
            this.nudBoxNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnTrack
            // 
            this.btnTrack.Location = new System.Drawing.Point(160, 562);
            this.btnTrack.Margin = new System.Windows.Forms.Padding(0);
            this.btnTrack.Name = "btnTrack";
            this.btnTrack.Size = new System.Drawing.Size(118, 49);
            this.btnTrack.TabIndex = 4;
            this.btnTrack.Text = "Track";
            this.btnTrack.UseVisualStyleBackColor = true;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Kristen ITC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(302, 44);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(124, 28);
            this.lblHeader.TabIndex = 23;
            this.lblHeader.Text = "Track Food";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblShippedBoxes
            // 
            this.lblShippedBoxes.AutoSize = true;
            this.lblShippedBoxes.Font = new System.Drawing.Font("Kristen ITC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShippedBoxes.Location = new System.Drawing.Point(66, 365);
            this.lblShippedBoxes.Name = "lblShippedBoxes";
            this.lblShippedBoxes.Size = new System.Drawing.Size(161, 28);
            this.lblShippedBoxes.TabIndex = 23;
            this.lblShippedBoxes.Text = "Boxes Shipped:";
            this.lblShippedBoxes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEventBoxes
            // 
            this.lblEventBoxes.AutoSize = true;
            this.lblEventBoxes.Font = new System.Drawing.Font("Kristen ITC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventBoxes.Location = new System.Drawing.Point(35, 256);
            this.lblEventBoxes.Name = "lblEventBoxes";
            this.lblEventBoxes.Size = new System.Drawing.Size(192, 28);
            this.lblEventBoxes.TabIndex = 23;
            this.lblEventBoxes.Text = "Boxes At Event(s):";
            this.lblEventBoxes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblOnHamd
            // 
            this.lblOnHamd.AutoSize = true;
            this.lblOnHamd.Font = new System.Drawing.Font("Kristen ITC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOnHamd.Location = new System.Drawing.Point(56, 137);
            this.lblOnHamd.Name = "lblOnHamd";
            this.lblOnHamd.Size = new System.Drawing.Size(171, 28);
            this.lblOnHamd.TabIndex = 23;
            this.lblOnHamd.Text = "Boxes On Hand:";
            this.lblOnHamd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgvOnHand
            // 
            this.dgvOnHand.AllowUserToAddRows = false;
            this.dgvOnHand.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOnHand.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOnHand.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOnHand.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvOnHand.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvOnHand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvOnHand.Location = new System.Drawing.Point(338, 111);
            this.dgvOnHand.Name = "dgvOnHand";
            this.dgvOnHand.ReadOnly = true;
            this.dgvOnHand.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvOnHand.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvOnHand.Size = new System.Drawing.Size(300, 88);
            this.dgvOnHand.TabIndex = 27;
            this.dgvOnHand.TabStop = false;
            // 
            // dgvEvent
            // 
            this.dgvEvent.AllowUserToAddRows = false;
            this.dgvEvent.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEvent.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEvent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEvent.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvEvent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvEvent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvEvent.Location = new System.Drawing.Point(262, 229);
            this.dgvEvent.Name = "dgvEvent";
            this.dgvEvent.ReadOnly = true;
            this.dgvEvent.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvEvent.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvEvent.Size = new System.Drawing.Size(452, 88);
            this.dgvEvent.TabIndex = 27;
            this.dgvEvent.TabStop = false;
            // 
            // dgvShipped
            // 
            this.dgvShipped.AllowUserToAddRows = false;
            this.dgvShipped.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvShipped.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvShipped.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvShipped.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvShipped.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvShipped.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvShipped.Location = new System.Drawing.Point(297, 347);
            this.dgvShipped.Name = "dgvShipped";
            this.dgvShipped.ReadOnly = true;
            this.dgvShipped.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvShipped.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvShipped.Size = new System.Drawing.Size(383, 88);
            this.dgvShipped.TabIndex = 27;
            this.dgvShipped.TabStop = false;
            // 
            // ckbUseBox
            // 
            this.ckbUseBox.AutoSize = true;
            this.ckbUseBox.Location = new System.Drawing.Point(643, 498);
            this.ckbUseBox.Name = "ckbUseBox";
            this.ckbUseBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ckbUseBox.Size = new System.Drawing.Size(106, 17);
            this.ckbUseBox.TabIndex = 2;
            this.ckbUseBox.Text = "Use Box Number";
            this.ckbUseBox.UseVisualStyleBackColor = true;
            // 
            // frmTrackFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 620);
            this.Controls.Add(this.ckbUseBox);
            this.Controls.Add(this.dgvShipped);
            this.Controls.Add(this.dgvEvent);
            this.Controls.Add(this.dgvOnHand);
            this.Controls.Add(this.nudBoxNumber);
            this.Controls.Add(this.lblBoxNumber);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.lblOnHamd);
            this.Controls.Add(this.lblEventBoxes);
            this.Controls.Add(this.lblShippedBoxes);
            this.Controls.Add(this.lblLotNumber);
            this.Controls.Add(this.txtLotNumber);
            this.Controls.Add(this.gbxType);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.btnTrack);
            this.Controls.Add(this.btnPrint);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmTrackFood";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Track Food";
            this.gbxType.ResumeLayout(false);
            this.gbxType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBoxNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOnHand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShipped)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnMainMenu;
        public System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.GroupBox gbxType;
        private System.Windows.Forms.RadioButton rdbVitamin;
        private System.Windows.Forms.RadioButton rdbVegetable;
        private System.Windows.Forms.RadioButton rdbSoy;
        private System.Windows.Forms.RadioButton rdbRice;
        public System.Windows.Forms.Label lblLotNumber;
        public System.Windows.Forms.TextBox txtLotNumber;
        public System.Windows.Forms.Label lblBoxNumber;
        private System.Windows.Forms.NumericUpDown nudBoxNumber;
        public System.Windows.Forms.Button btnTrack;
        public System.Windows.Forms.Label lblHeader;
        public System.Windows.Forms.Label lblShippedBoxes;
        public System.Windows.Forms.Label lblEventBoxes;
        public System.Windows.Forms.Label lblOnHamd;
        private System.Windows.Forms.DataGridView dgvOnHand;
        private System.Windows.Forms.DataGridView dgvEvent;
        private System.Windows.Forms.DataGridView dgvShipped;
        private System.Windows.Forms.CheckBox ckbUseBox;
    }
}