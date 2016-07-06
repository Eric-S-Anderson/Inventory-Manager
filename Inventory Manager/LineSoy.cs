using System;
using System.Windows.Forms;

namespace Inventory_Manager
{
    public partial class LineSoy : UserControl
    {
        public bool isOverflow = false;

        public LineSoy()
        {
            InitializeComponent();
            Styler.styleCompundControl(this);

            btnDelete.MouseClick += btnDelete_Click;
        }

        public LineSoy(string controlName)
        {
            InitializeComponent();
            Styler.styleCompundControl(this);

            btnDelete.MouseClick += btnDelete_Click;

            Name = controlName;
        }

        private void btnDelete_Click(object sender, MouseEventArgs e)
        {
            Dispose();
        }

        public string getBagNumber()
        {
            return txtBagNumber.Text;
        }

        public void setBagNumber(string bagNumber)
        {
            txtBagNumber.Text = bagNumber;
            txtBagNumber.ReadOnly = true;
        }
    }
}
