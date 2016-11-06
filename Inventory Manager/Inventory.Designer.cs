namespace Inventory_Manager
{
    partial class frmInventory
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
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.icarusCalendar1 = new Inventory_Manager.IcarusCalendar();
            this.SuspendLayout();
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnMainMenu.Location = new System.Drawing.Point(811, 601);
            this.btnMainMenu.Margin = new System.Windows.Forms.Padding(0);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(200, 75);
            this.btnMainMenu.TabIndex = 5;
            this.btnMainMenu.Tag = "Menu";
            this.btnMainMenu.Text = "Main Menu";
            this.btnMainMenu.UseVisualStyleBackColor = true;
            // 
            // icarusCalendar1
            // 
            this.icarusCalendar1.BackColor = System.Drawing.Color.Transparent;
            this.icarusCalendar1.Location = new System.Drawing.Point(115, 57);
            this.icarusCalendar1.Name = "icarusCalendar1";
            this.icarusCalendar1.Size = new System.Drawing.Size(658, 600);
            this.icarusCalendar1.TabIndex = 6;
            // 
            // frmInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 685);
            this.Controls.Add(this.icarusCalendar1);
            this.Controls.Add(this.btnMainMenu);
            this.Name = "frmInventory";
            this.Text = "Inventory";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btnMainMenu;
        private IcarusCalendar icarusCalendar1;
    }
}