namespace Inventory_Manager
{
    partial class LineRice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LineRice));
            this.btnDelete = new System.Windows.Forms.Button();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.txtLotNumber = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.SuspendLayout();
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
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Tag = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // nudQuantity
            // 
            this.nudQuantity.Font = new System.Drawing.Font("Kristen ITC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudQuantity.Location = new System.Drawing.Point(250, 0);
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(50, 35);
            this.nudQuantity.TabIndex = 2;
            this.nudQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtLotNumber
            // 
            this.txtLotNumber.Font = new System.Drawing.Font("Kristen ITC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLotNumber.Location = new System.Drawing.Point(0, 0);
            this.txtLotNumber.Name = "txtLotNumber";
            this.txtLotNumber.Size = new System.Drawing.Size(250, 35);
            this.txtLotNumber.TabIndex = 0;
            // 
            // LoneQuant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtLotNumber);
            this.Controls.Add(this.nudQuantity);
            this.Controls.Add(this.btnDelete);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "LoneQuant";
            this.Size = new System.Drawing.Size(335, 35);
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.TextBox txtLotNumber;
    }
}
