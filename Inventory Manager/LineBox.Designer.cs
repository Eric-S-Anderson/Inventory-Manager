namespace Inventory_Manager
{
    partial class LineBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LineBox));
            this.cbxBoxCode = new System.Windows.Forms.ComboBox();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxBoxCode
            // 
            this.cbxBoxCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxBoxCode.Font = new System.Drawing.Font("Kristen ITC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxBoxCode.FormattingEnabled = true;
            this.cbxBoxCode.Location = new System.Drawing.Point(0, 0);
            this.cbxBoxCode.Margin = new System.Windows.Forms.Padding(0);
            this.cbxBoxCode.Name = "cbxBoxCode";
            this.cbxBoxCode.Size = new System.Drawing.Size(300, 36);
            this.cbxBoxCode.TabIndex = 0;
            // 
            // nudQuantity
            // 
            this.nudQuantity.Font = new System.Drawing.Font("Kristen ITC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudQuantity.Location = new System.Drawing.Point(300, 0);
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(60, 35);
            this.nudQuantity.TabIndex = 4;
            this.nudQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.BackgroundImage")));
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(360, 0);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(35, 35);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Tag = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // LineBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.nudQuantity);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.cbxBoxCode);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "LineBox";
            this.Size = new System.Drawing.Size(395, 36);
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.Button btnDelete;
        public System.Windows.Forms.ComboBox cbxBoxCode;
    }
}
