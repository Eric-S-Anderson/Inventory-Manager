namespace Inventory_Manager
{
    partial class frmDBCon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDBCon));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.txtConnection = new System.Windows.Forms.TextBox();
            this.ofdDBCon = new System.Windows.Forms.OpenFileDialog();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(493, 111);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(118, 49);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(219, 111);
            this.btnTest.Margin = new System.Windows.Forms.Padding(0);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(118, 49);
            this.btnTest.TabIndex = 6;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(356, 111);
            this.btnApply.Margin = new System.Windows.Forms.Padding(0);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(118, 49);
            this.btnApply.TabIndex = 7;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            // 
            // txtConnection
            // 
            this.txtConnection.Font = new System.Drawing.Font("Kristen ITC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConnection.Location = new System.Drawing.Point(13, 58);
            this.txtConnection.Name = "txtConnection";
            this.txtConnection.Size = new System.Drawing.Size(473, 35);
            this.txtConnection.TabIndex = 9;
            // 
            // ofdDBCon
            // 
            this.ofdDBCon.FileName = "openFileDialog1";
            this.ofdDBCon.Filter = "Database Files|*.mdf";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(498, 58);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(0);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(113, 35);
            this.btnBrowse.TabIndex = 6;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Kristen ITC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(199, 18);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(225, 28);
            this.lblHeader.TabIndex = 37;
            this.lblHeader.Text = "Database Connection";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmDBCon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 169);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.txtConnection);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.btnApply);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDBCon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Database Connection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.Button btnTest;
        public System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.TextBox txtConnection;
        private System.Windows.Forms.OpenFileDialog ofdDBCon;
        public System.Windows.Forms.Button btnBrowse;
        public System.Windows.Forms.Label lblHeader;
    }
}