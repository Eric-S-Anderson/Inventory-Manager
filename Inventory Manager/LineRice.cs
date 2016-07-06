using System;
using System.Windows.Forms;

namespace Inventory_Manager
{
    public partial class LineRice : UserControl
    {
        public bool isOverflow = false;

        public LineRice()
        {
            InitializeComponent();
            Styler.styleCompundControl(this);

            btnDelete.MouseClick += btnDelete_Click;
        }

        public LineRice(string controlName)
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

        public string getLotNumber()
        {
            return txtLotNumber.Text;
        }

        public int getQuantity()
        {
            return (int)nudQuantity.Value;
        }

        public void setLotNumber(string lotNumber)
        {
            txtLotNumber.Text = lotNumber;
            txtLotNumber.ReadOnly = true;
        }

        public void setQuantity(int quantity)
        {
            nudQuantity.Value = quantity;
            nudQuantity.ReadOnly = true;
            nudQuantity.Increment = 0;
        }
    }
}
