using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Inventory_Manager
{
    public partial class frmAddDOT : Form
    {
        private static Form mainMenu;
        private DataTable trailerSet = new DataTable();

        public frmAddDOT(Form menuForm)
        {
            InitializeComponent();
            Styler.stylePage(this);

            mainMenu = menuForm;

            btnMainMenu.MouseClick += btnMainMenu_Click;
            btnAddDOT.MouseClick += btnAddDOT_MouseClick;
            txtDOT.KeyDown += txtAllBoxes_PressEnter;
            cbxTrailer.KeyDown += txtAllBoxes_PressEnter;

            trailerSet = DBLink.getProcedure("Get_Trailers");

            trailerSet.Columns.Add("comboDisplay", typeof(string));

            foreach (DataRow row in trailerSet.Rows)
            {
                row[3] =  row[1].ToString() + ", " + row[2].ToString();
            }

            cbxTrailer.DataSource = trailerSet;
            cbxTrailer.DisplayMember = trailerSet.Columns[3].ColumnName;
            if (cbxTrailer.Items.Count > 0)
            {
                cbxTrailer.SelectedIndex = 0;
            }
        }

        private void txtAllBoxes_PressEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAddDOT_MouseClick(sender, new MouseEventArgs(MouseButtons.Left, 1, 0, 0, 0));
            }
        }

        private void btnAddDOT_MouseClick(object sender, MouseEventArgs e)
        {

            if (txtDOT.Text == "")
            {
                MessageBox.Show("A DOT Number Must Be Provided.", "Inventory Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDOT.Focus();
            }
            else
            {
                int trailerID = 0;

                for (int i = 0; i < trailerSet.Rows.Count; i++)
                {
                    if (cbxTrailer.SelectedIndex == i)
                    {
                        trailerID = (int)trailerSet.Rows[i][0];
                    }
                }

                int insertResult = DBLink.setProcedure("Add_New_DOT", new List<Param>(new[] {
                                                                                   new Param("@Trailer_ID", trailerID, typeof(int)),
                                                                                   new Param("@USDOT_Number", txtDOT.Text, typeof(string)),
                                                                                   new Param("@DOT_Issue_Date", dtpIssueDate.Value.Date, typeof(DateTime))
                                                                                    }));

                if (insertResult == 1)
                {
                    txtDOT.Clear();
                    if (cbxTrailer.Items.Count > 0)
                    {
                        cbxTrailer.SelectedIndex = 0;
                    }
                }
                txtDOT.Focus();
            }
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            mainMenu.Show();
            Hide();
        }

        private void frmAddDOT_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainMenu.Show();
        }
    }
}
