using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Manager
{
    public partial class LineVitamin : UserControl
    {
        public LineVitamin()
        {
            InitializeComponent();
            Styler.styleCompundControl(this);

            btnDelete.MouseClick += btnDelete_Click;
        }

        public LineVitamin(string controlName)
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

        public string getBoxNumber()
        {
            return txtBoxNumber.Text;
        }
    }
}
