using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZagrosDesktop
{
    public partial class frmSelect : Form
        {
        public frmSelect ()
            {
            InitializeComponent ();
            }
        private void frmSelect_Load (object sender, EventArgs e)
            {
            string t = ZagrApp.DialogType;
            Grid_Select.DataSource = DB.DS.Tables [t];
            switch (t)
                {
                case "tblPersons":
                        {
                        try
                            {
                            for (int i = 0; i < Grid_Select.Columns.Count; i++)
                                {
                                Grid_Select.Columns [i].SortMode = DataGridViewColumnSortMode.Programmatic;
                                }
                            }
                        catch { }
                        Grid_Select.Columns [0].Visible = false;   // 0  ID
                        Grid_Select.Columns [1].Width = 90;        // 1  Title
                        Grid_Select.Columns [2].Width = 170;       // 2  Name
                        Grid_Select.Columns [3].Width = 100;       // 3  Tel
                        Grid_Select.Columns [4].Width = 150;       // 4  Note
                        break;
                        }
                case "tblUnits":
                        {
                        try
                            {
                            for (int i = 0; i < Grid_Select.Columns.Count; i++)
                                {
                                Grid_Select.Columns [i].SortMode = DataGridViewColumnSortMode.Programmatic;
                                }
                            }
                        catch { }
                        Grid_Select.Columns [0].Width = 40;        // 0  ID
                        Grid_Select.Columns [1].Width = 80;        // 1  Name
                        Grid_Select.Columns [2].Width = 60;        // 2  Area
                        Grid_Select.Columns [3].Width = 100;       // 3  Parking
                        Grid_Select.Columns [4].Width = 80;        // 4  ElecNr
                        Grid_Select.Columns [5].Width = 80;        // 5  GassNr
                        break;
                        }
                }

            }
        private void Grid_Select_CellDoubleClick (object sender, DataGridViewCellEventArgs e)
            {
            lbl_Select_Click (null, null);
            }
        private void lbl_Select_Click (object sender, EventArgs e)
            {
            if (Grid_Select.SelectedRows [0].Index >= 0)
                {
                ZagrApp.DialogOutput = Grid_Select.SelectedRows [0].Cells [0].Value.ToString ();
                CustomInput.Cancelled = false;
                Dispose ();
                }
            else
                {
                MessageBox.Show ("Select an item from list");
                }
            }
        private void lbl_Cancel_Click (object sender, EventArgs e)
            {
            CustomInput.Cancelled = true;
            Dispose ();
            }
        }
    }
