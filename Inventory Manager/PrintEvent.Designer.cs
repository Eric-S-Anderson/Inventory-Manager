﻿namespace Inventory_Manager
{
    partial class frmPrintEvent
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.cbxEvent = new System.Windows.Forms.ComboBox();
            this.lblEventName = new System.Windows.Forms.Label();
            this.lblEventDate = new System.Windows.Forms.Label();
            this.dtpeDate = new Inventory_Manager.DateTimePickerExtended();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(506, 174);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(118, 49);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(368, 174);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(0);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(118, 49);
            this.btnPrint.TabIndex = 6;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Kristen ITC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(250, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(125, 28);
            this.lblHeader.TabIndex = 37;
            this.lblHeader.Text = "Print Event";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbxEvent
            // 
            this.cbxEvent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEvent.Font = new System.Drawing.Font("Kristen ITC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxEvent.FormattingEnabled = true;
            this.cbxEvent.Location = new System.Drawing.Point(167, 113);
            this.cbxEvent.Name = "cbxEvent";
            this.cbxEvent.Size = new System.Drawing.Size(457, 36);
            this.cbxEvent.TabIndex = 38;
            // 
            // lblEventName
            // 
            this.lblEventName.AutoSize = true;
            this.lblEventName.Font = new System.Drawing.Font("Kristen ITC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventName.Location = new System.Drawing.Point(14, 116);
            this.lblEventName.Name = "lblEventName";
            this.lblEventName.Size = new System.Drawing.Size(137, 28);
            this.lblEventName.TabIndex = 39;
            this.lblEventName.Text = "Event Name:";
            this.lblEventName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEventDate
            // 
            this.lblEventDate.AutoSize = true;
            this.lblEventDate.Font = new System.Drawing.Font("Kristen ITC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventDate.Location = new System.Drawing.Point(21, 65);
            this.lblEventDate.Name = "lblEventDate";
            this.lblEventDate.Size = new System.Drawing.Size(130, 28);
            this.lblEventDate.TabIndex = 41;
            this.lblEventDate.Text = "Event Date:";
            this.lblEventDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpeDate
            // 
            this.dtpeDate.AutoSize = true;
            this.dtpeDate.Location = new System.Drawing.Point(167, 62);
            this.dtpeDate.Name = "dtpeDate";
            this.dtpeDate.Size = new System.Drawing.Size(430, 35);
            this.dtpeDate.TabIndex = 42;
            // 
            // frmPrintEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 232);
            this.Controls.Add(this.dtpeDate);
            this.Controls.Add(this.lblEventDate);
            this.Controls.Add(this.cbxEvent);
            this.Controls.Add(this.lblEventName);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnPrint);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmPrintEvent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Print Event";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnClose;
        public System.Windows.Forms.Button btnPrint;
        public System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.ComboBox cbxEvent;
        public System.Windows.Forms.Label lblEventName;
        public System.Windows.Forms.Label lblEventDate;
        private DateTimePickerExtended dtpeDate;
    }
}