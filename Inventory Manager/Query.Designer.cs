namespace Inventory_Manager
{
    partial class frmQuery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuery));
            this.txtQuery = new System.Windows.Forms.TextBox();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.btnTable = new System.Windows.Forms.Button();
            this.btnVoid = new System.Windows.Forms.Button();
            this.btnInteger = new System.Windows.Forms.Button();
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.lblHeader = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.SuspendLayout();
            // 
            // txtQuery
            // 
            this.txtQuery.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuery.Location = new System.Drawing.Point(20, 73);
            this.txtQuery.Multiline = true;
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.Size = new System.Drawing.Size(591, 151);
            this.txtQuery.TabIndex = 0;
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnMainMenu.Location = new System.Drawing.Point(411, 539);
            this.btnMainMenu.Margin = new System.Windows.Forms.Padding(0);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(200, 75);
            this.btnMainMenu.TabIndex = 5;
            this.btnMainMenu.Tag = "Menu";
            this.btnMainMenu.Text = "Main Menu";
            this.btnMainMenu.UseVisualStyleBackColor = true;
            // 
            // btnTable
            // 
            this.btnTable.Location = new System.Drawing.Point(392, 244);
            this.btnTable.Margin = new System.Windows.Forms.Padding(0);
            this.btnTable.Name = "btnTable";
            this.btnTable.Size = new System.Drawing.Size(118, 49);
            this.btnTable.TabIndex = 3;
            this.btnTable.Text = "Table";
            this.btnTable.UseVisualStyleBackColor = true;
            // 
            // btnVoid
            // 
            this.btnVoid.Location = new System.Drawing.Point(117, 244);
            this.btnVoid.Margin = new System.Windows.Forms.Padding(0);
            this.btnVoid.Name = "btnVoid";
            this.btnVoid.Size = new System.Drawing.Size(118, 49);
            this.btnVoid.TabIndex = 1;
            this.btnVoid.Text = "Void";
            this.btnVoid.UseVisualStyleBackColor = true;
            // 
            // btnInteger
            // 
            this.btnInteger.Location = new System.Drawing.Point(254, 244);
            this.btnInteger.Margin = new System.Windows.Forms.Padding(0);
            this.btnInteger.Name = "btnInteger";
            this.btnInteger.Size = new System.Drawing.Size(118, 49);
            this.btnInteger.TabIndex = 2;
            this.btnInteger.Text = "Integer";
            this.btnInteger.UseVisualStyleBackColor = true;
            // 
            // dgvResults
            // 
            this.dgvResults.AllowUserToAddRows = false;
            this.dgvResults.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvResults.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResults.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvResults.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvResults.Location = new System.Drawing.Point(20, 316);
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.ReadOnly = true;
            this.dgvResults.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvResults.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvResults.Size = new System.Drawing.Size(591, 194);
            this.dgvResults.TabIndex = 4;
            this.dgvResults.TabStop = false;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Kristen ITC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(233, 33);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(150, 28);
            this.lblHeader.TabIndex = 46;
            this.lblHeader.Text = "Manual Query";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 623);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.dgvResults);
            this.Controls.Add(this.btnTable);
            this.Controls.Add(this.btnVoid);
            this.Controls.Add(this.btnInteger);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.txtQuery);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmQuery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Query";
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtQuery;
        public System.Windows.Forms.Button btnMainMenu;
        public System.Windows.Forms.Button btnTable;
        public System.Windows.Forms.Button btnVoid;
        public System.Windows.Forms.Button btnInteger;
        private System.Windows.Forms.DataGridView dgvResults;
        public System.Windows.Forms.Label lblHeader;
    }
}