using System;
using System.Data;
using System.Windows.Forms;

namespace Inventory_Manager
{
    public partial class LineBox : UserControl
    {
        private DataTable foodBoxSet = new DataTable();

        public LineBox()
        {
            InitializeComponent();
            Styler.styleCompundControl(this);

            btnDelete.MouseClick += btnDelete_Click;
            cbxBoxCode.SelectedIndexChanged += cbxBoxCode_SelectedIndexChanged;

            populateBoxes();
            cbxBoxCode.SelectedIndex = -1;
            nudQuantity.Value = 0;

        }

        public LineBox(string name)
        {
            InitializeComponent();
            Styler.styleCompundControl(this);

            btnDelete.MouseClick += btnDelete_Click;
            cbxBoxCode.SelectedIndexChanged += cbxBoxCode_SelectedIndexChanged;

            populateBoxes();
            cbxBoxCode.SelectedIndex = -1;
            nudQuantity.Value = 0;

            Name = name;
        }

        private void populateBoxes()
        {
            foodBoxSet = DBLink.getProcedure("Get_Boxes_On_Hand");

            cbxBoxCode.DataSource = foodBoxSet;
            cbxBoxCode.DisplayMember = foodBoxSet.Columns[1].ColumnName;
        }

        private void cbxBoxCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxBoxCode.SelectedIndex >= 0)
            {
                DataRowView selectedRow = (DataRowView)cbxBoxCode.SelectedValue;
                int selectedValue = (int)selectedRow[2];
                nudQuantity.Value = selectedValue;
            }
            
        }

        public int getSelectedId()
        {
            if (cbxBoxCode.SelectedIndex >= 0)
            {
                DataRowView selectedRow = (DataRowView)cbxBoxCode.SelectedValue;
                return (int)selectedRow[0];
            }
            else
            {
                return -1;
            }
        }

        public int getQuantity()
        {
            return (int)nudQuantity.Value;
        }

        public void resetValues()
        {
            cbxBoxCode.SelectedIndex = -1;
            nudQuantity.Value = 0;
        }

        private void btnDelete_Click(object sender, MouseEventArgs e)
        {
            Dispose();
        }

    }
}
