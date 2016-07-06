namespace Inventory_Manager
{
    partial class LineVeggie
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LineVeggie));
            this.txtBoxNumber = new System.Windows.Forms.TextBox();
            this.txtLotNumber = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBoxNumber
            // 
            this.txtBoxNumber.Font = new System.Drawing.Font("Kristen ITC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNumber.Location = new System.Drawing.Point(225, 0);
            this.txtBoxNumber.Name = "txtBoxNumber";
            this.txtBoxNumber.Size = new System.Drawing.Size(75, 35);
            this.txtBoxNumber.TabIndex = 1;
            // 
            // txtLotNumber
            // 
            this.txtLotNumber.Font = new System.Drawing.Font("Kristen ITC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLotNumber.Location = new System.Drawing.Point(0, 0);
            this.txtLotNumber.Name = "txtLotNumber";
            this.txtLotNumber.Size = new System.Drawing.Size(225, 35);
            this.txtLotNumber.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.BackgroundImage")));
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(300, 0);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(35, 35);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Tag = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // LineVeggie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtBoxNumber);
            this.Controls.Add(this.txtLotNumber);
            this.Controls.Add(this.btnDelete);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "LineVeggie";
            this.Size = new System.Drawing.Size(335, 35);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxNumber;
        private System.Windows.Forms.TextBox txtLotNumber;
        private System.Windows.Forms.Button btnDelete;
    }
}
