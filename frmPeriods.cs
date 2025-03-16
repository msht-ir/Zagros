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
    public partial class frmPeriods : Form
        {
        public frmPeriods ()
            {
            InitializeComponent ();
            }
        private void frmPeriods_Load (object sender, EventArgs e)
            {
            ZagrApp.RefeedTables (4, false);//{1:Accs 2:Cats 4:Periods 8:PeriodsUnits 16:Persons 32:Units}
            Grid_Periods.DataSource = DB.DS.Tables ["tblPeriods"];
            Grid_Data.DataSource = null;
            FormatGridCols (1); //1:gridPerids 2:gridData
            }
        private void Grid_Periods_CellClick (object sender, DataGridViewCellEventArgs e)
            {
            if (Grid_Periods.Rows.Count == 0)
                {
                return;
                }
            int r = Convert.ToInt32 (Grid_Periods.SelectedRows [0].Cells [0].Value);
            ZagrApp.GetPeriodUnitsData (r);
            Grid_Data.DataSource = DB.DS.Tables ["tblPeriodsUnits"];
            FormatGridCols (2); //1:gridPerids 2:gridData
            }
        private void Grid_Periods_CellDoubleClick (object sender, DataGridViewCellEventArgs e)
            {
            if ((Grid_Periods.Rows.Count > 0) && (Grid_Periods.SelectedRows [0].Index >= 0))
                {
                EditGridPeriodItem ();
                }
            }
        private void Grid_Data_CellDoubleClick (object sender, DataGridViewCellEventArgs e)
            {
            EditGridDataItem ();
            }
        //btns for grid1
        private void btn_EditPeriod_Click (object sender, EventArgs e)
            {
            EditGridPeriodItem ();
            }
        private void btn_NewPeriod_Click (object sender, EventArgs e)
            {
            if (Grid_Data.Rows.Count == 0)
                {
                //first period!
                ZagrApp.RequestModeNew_Edit = "New";
                var frmEditPeriod0 = new frmPeriodEdit ();
                frmEditPeriod0.ShowDialog ();
                if (ZagrApp.DialogOutput == "OK")
                    {
                    //create a new period
                    int newPeriodId = ZagrApp.AddNewPeriod ();
                    int unitid = 0;
                    int ownerid = 0;
                    int residentid = 0;
                    int people = 0;
                    int waterfrom = 0;
                    if (newPeriodId > 0)
                        {
                        //add n units to the new period
                        for (int u = 0; u < (DB.DS.Tables ["tblUnits"].Rows.Count); u++)
                            {
                            unitid = Convert.ToInt32 (DB.DS.Tables ["tblUnits"].Rows [u] [0]);
                            ZagrApp.AddUnit2PeriodsUnits (newPeriodId, unitid, ownerid, residentid, people, waterfrom);
                            }
                        }
                    ZagrApp.RefeedTables (4, true); //{1:Accs 2:Cats 4:Periods 8:PeriodsUnits 16:Persons 32:Units}
                    return;
                    }
                }
            DialogResult myAnsw = MessageBox.Show ("با ايجاد دوره جديد، اطلاعات واحدها از دوره منتخب شما\n\n" + (Grid_Periods [1, Grid_Periods.CurrentRow.Index].Value) + "\n\n در دوره جديد کپي مي شود\n\nاز اين دوره استفاده مي کنيد؟", "تاييد کنيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign);
            if (myAnsw == DialogResult.No)
                {
                return;
                }
            else
                {
                int oldPeriodId = Convert.ToInt32 (Grid_Periods [0, Grid_Periods.CurrentRow.Index].Value);
                //get name of new period
                ZagrApp.RequestModeNew_Edit = "New";
                var frmEditPeriod = new frmPeriodEdit ();
                frmEditPeriod.ShowDialog ();
                if (ZagrApp.DialogOutput == "OK")
                    {
                    //create a new period
                    int newPeriodId = ZagrApp.AddNewPeriod ();
                    int unitid = 0;
                    int ownerid = 0;
                    int residentid = 0;
                    int people = 0;
                    int waterfrom = 0;
                    if (newPeriodId > 0)
                        {
                        //add n units to the new period
                        for (int u = 0; u < (DB.DS.Tables ["tblPeriodsUnits"].Rows.Count); u++)
                            {
                            unitid = Convert.ToInt32 (DB.DS.Tables ["tblPeriodsUnits"].Rows [u] [2]);
                            ownerid = Convert.ToInt32 (DB.DS.Tables ["tblPeriodsUnits"].Rows [u] [3]);
                            residentid = Convert.ToInt32 (DB.DS.Tables ["tblPeriodsUnits"].Rows [u] [5]);
                            people = Convert.ToInt32 (DB.DS.Tables ["tblPeriodsUnits"].Rows [u] [8]);
                            waterfrom = Convert.ToInt32 (DB.DS.Tables ["tblPeriodsUnits"].Rows [u] [9]); //notice: waterTo in old periodUnit goes to waterFrom of the new period
                            ZagrApp.AddUnit2PeriodsUnits (newPeriodId, unitid, ownerid, residentid, people, waterfrom);
                            }
                        }
                    ZagrApp.RefeedTables (4, true); //{1:Accs 2:Cats 4:Periods 8:PeriodsUnits 16:Persons 32:Units}
                    }
                else
                    {
                    MessageBox.Show ("Cancelled by User");
                    }
                }
            }
        private void btn_CalculateCharge_Click (object sender, EventArgs e)
            {
            try
                {
                //if ((Grid_Periods.Rows.Count == 0) || (Grid_Periods.SelectedRows [0].Index == -1))
                if ((Grid_Periods.Rows.Count == 0) || (Grid_Periods.SelectedRows.Count == 0))
                    {
                    return;
                    }
                else
                    {
                    int pid = Convert.ToInt32 (Grid_Periods.SelectedRows [0].Cells [0].Value);
                    Periodx.Name = Grid_Periods.SelectedRows [0].Cells [1].Value.ToString();
                    if (ZagrApp.CalculateCharge (pid))
                        {
                        Grid_Periods.ClearSelection ();
                        Grid_Data.DataSource = null;
                        MessageBox.Show ("شارژ هاي اين دوره محاسبه شد");
                        }
                    else
                        {
                        MessageBox.Show ("Error! Charge did not calculated");
                        }
                    }
                }
            catch (Exception ex)
                {
                MessageBox.Show (ex.ToString ());
                }
            }
        //btns for grid2
        private void btn_EditGridDataItem_Click (object sender, EventArgs e)
            {
            EditGridDataItem ();
            }
        private void btn_AddUnit2List_Click (object sender, EventArgs e)
            {
            if (Grid_Periods.Rows.Count == 0)
                {
                return;
                }
            ZagrApp.DialogType = "tblUnits";
            var frmSel = new frmSelect ();
            frmSel.ShowDialog ();
            if (!CustomInput.Cancelled)
                {
                int periodid = Convert.ToInt32 (Grid_Periods.SelectedRows [0].Cells [0].Value);
                int unitid = Convert.ToInt32 (ZagrApp.DialogOutput);
                ZagrApp.AddUnit2PeriodsUnits (periodid, unitid, 0, 0, 0, 0);
                UpdateGridData (periodid);
                }
            }
        private void btn_RemoveUnitFromList_Click (object sender, EventArgs e)
            {
            if (Grid_Data.Rows.Count == 0)
                {
                return;
                }
            int unitid = Convert.ToInt32 (Grid_Data [0, Grid_Data.SelectedCells [0].RowIndex].Value);
            DialogResult myAnsw = MessageBox.Show ("اين واحد از ليست دوره شارژ حذف شود؟", "تاييد کنيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (myAnsw == DialogResult.Yes)
                {
                if (ZagrApp.RemoveUnitFromPeriodsUnits (unitid))
                    {
                    int periodid = Convert.ToInt32 (Grid_Periods.SelectedRows [0].Cells [0].Value);
                    UpdateGridData (periodid);
                    MessageBox.Show ("Unit Removed, OK");
                    return;
                    }
                else
                    {
                    MessageBox.Show ("Error: didnt removed");
                    }
                }
            else
                {
                MessageBox.Show ("Cancelled: didnt removed");
                }
            }
        private void btn_Note4All_Click (object sender, EventArgs e)
            {
            //Note for all
            if (Grid_Data.Rows.Count == 0)
                {
                return;
                }
            CustomInput.InputType = "string";    //number, string
            CustomInput.DefaultValue = "-";
            CustomInput.ReturnValue = "";
            CustomInput.MessageText = "يادداشت حسابداري مجتمع براي همه واحدهاي اين دوره";
            CustomInput.Cancelled = true;
            var frmInputBox = new frmInput ();
            frmInputBox.ShowDialog ();
            if (!CustomInput.Cancelled)
                {
                int unitid = 0;
                for (int u = 0; u < Grid_Data.Rows.Count; u++)
                    {
                    unitid = Convert.ToInt32 (Grid_Data.Rows [u].Cells [0].Value);
                    ZagrApp.UpdatePeriodsUnitsRecord (unitid, "Note", CustomInput.ReturnValue.ToString ());
                    }
                UpdateGridData (Convert.ToInt32 (Grid_Periods.SelectedRows [0].Cells [0].Value));
                }
            }
        private void btn_AddChargeToAccs_Click (object sender, EventArgs e)
            {
            if (Grid_Data.Rows.Count == 0)
                {
                return;
                }
            if (ZagrApp.AddChargesToAccs ())
                {
                MessageBox.Show ("شارژ ها در حساب ها وارد شد");
                }
            else
                {
                MessageBox.Show ("خطا در ثبت شارژها در حساب ها");
                }
            }
        //methods
        private void EditGridPeriodItem ()
            {
            if (Grid_Periods.Rows.Count == 0)
                {
                return;
                }
            int r = Convert.ToInt32 (Grid_Periods.SelectedRows [0].Cells [0].Value);
            Periodx.Id = r;
            Periodx.Name = (Grid_Periods.SelectedRows [0].Cells [1].Value).ToString ();
            Periodx.CntWater = Convert.ToInt32 (Grid_Periods.SelectedRows [0].Cells [2].Value);
            Periodx.ExpWater = Convert.ToInt32 (Grid_Periods.SelectedRows [0].Cells [3].Value);
            Periodx.ExpElec = Convert.ToInt32 (Grid_Periods.SelectedRows [0].Cells [4].Value);
            Periodx.ExpDoorPump = Convert.ToInt32 (Grid_Periods.SelectedRows [0].Cells [5].Value);
            Periodx.ExpGuard = Convert.ToInt32 (Grid_Periods.SelectedRows [0].Cells [6].Value);
            Periodx.ExpElev1 = Convert.ToInt32 (Grid_Periods.SelectedRows [0].Cells [7].Value);
            Periodx.ExpElev2 = Convert.ToInt32 (Grid_Periods.SelectedRows [0].Cells [8].Value);
            Periodx.ExpRepair = Convert.ToInt32 (Grid_Periods.SelectedRows [0].Cells [9].Value);
            Periodx.ExpMisc = Convert.ToInt32 (Grid_Periods.SelectedRows [0].Cells [10].Value);
            Periodx.PeopleTotal = Convert.ToInt32 (Grid_Periods.SelectedRows [0].Cells [11].Value);
            Periodx.BookKeeper = (Grid_Periods.SelectedRows [0].Cells [12].Value).ToString ();
            Periodx.Note = (Grid_Periods.SelectedRows [0].Cells [13].Value).ToString ();
            Periodx.DateStart = (Grid_Periods.SelectedRows [0].Cells [14].Value).ToString ();
            Periodx.DateEnd = (Grid_Periods.SelectedRows [0].Cells [15].Value).ToString ();
            Periodx.DateCnt = (Grid_Periods.SelectedRows [0].Cells [16].Value).ToString ();
            Periodx.IsActive = Convert.ToBoolean (Grid_Periods.SelectedRows [0].Cells [17].Value);
            //open editor
            ZagrApp.RequestModeNew_Edit = "Edit";
            var frmEditPeriod = new frmPeriodEdit ();
            frmEditPeriod.ShowDialog ();
            if (ZagrApp.DialogOutput == "OK")
                {
                //Update
                if (ZagrApp.UpdatePeriodInfo ())
                    {
                    //refresh grid
                    ZagrApp.RefeedTables (4, false); //{1:Accs 2:Cats 4:Periods 8:PeriodsUnits 16:Persons 32:Units}
                    //MessageBox.Show ("OK Saved");
                    }
                else
                    {
                    MessageBox.Show ("Error, Not Saved");
                    }
                }
            else
                {
                //MessageBox.Show ("Cancelled by User: Not Saved");
                }
            }
        private void EditGridDataItem ()
            {
            try
                {
                if (Grid_Data.Rows.Count == 0)
                    {
                    return;
                    }
                int r = Grid_Data.SelectedCells [0].RowIndex;
                int c = Grid_Data.SelectedCells [0].ColumnIndex;
                int id = Convert.ToInt32 (Grid_Data [0, Grid_Data.SelectedCells [0].RowIndex].Value);
                //0ID 1Period_ID 2Unit_ID 3Owner 4PersonsOwner.Name AS OwnerName 5Resident 6PersonsResident.Name AS ResidentName 7IsRent 8People 9WaterFrom 10WaterTo 11ChargeBill 12PeriodsUnits.Note 13Area
                switch (c)
                    {
                    case 4:
                            {
                            ZagrApp.DialogType = "tblPersons";
                            var frmSel = new frmSelect ();
                            frmSel.ShowDialog ();
                            if (!CustomInput.Cancelled)
                                {
                                ZagrApp.UpdatePeriodsUnitsRecord (id, "Owner", ZagrApp.DialogOutput.ToString ());
                                }
                            UpdateGridData (Convert.ToInt32 (Grid_Periods.SelectedRows [0].Cells [0].Value));
                            break;
                            }
                    case 6:
                            {
                            ZagrApp.DialogType = "tblPersons";
                            var frmSel = new frmSelect ();
                            frmSel.ShowDialog ();
                            if (!CustomInput.Cancelled)
                                {
                                ZagrApp.UpdatePeriodsUnitsRecord (id, "Resident", ZagrApp.DialogOutput.ToString ());
                                }
                            UpdateGridData (Convert.ToInt32 (Grid_Periods.SelectedRows [0].Cells [0].Value));
                            break;
                            }
                    case 7:
                            {
                            //IsRent
                            Grid_Data [7, r].Value = (Convert.ToBoolean (Grid_Data [7, r].Value)) ? false : true;
                            if (Convert.ToBoolean (Grid_Data [7, r].Value))
                                {
                                ZagrApp.UpdatePeriodsUnitsRecord (id, "IsRent", "1");
                                }
                            else
                                {
                                ZagrApp.UpdatePeriodsUnitsRecord (id, "IsRent", "0");
                                }
                            UpdateGridData (Convert.ToInt32 (Grid_Periods.SelectedRows [0].Cells [0].Value));
                            break;
                            }
                    case 8:
                            {
                            //People
                            CustomInput.InputType = "number";    //number, string
                            CustomInput.DefaultValue = (Grid_Data [8, r].Value).ToString ();
                            CustomInput.ReturnValue = "";
                            CustomInput.MessageText = "تعداد افراد ساکنين اين واحد در اين دوره";
                            CustomInput.Cancelled = true;
                            var frmInputBox = new frmInput ();
                            frmInputBox.ShowDialog ();
                            if (!CustomInput.Cancelled)
                                {
                                ZagrApp.UpdatePeriodsUnitsRecord (id, "People", CustomInput.ReturnValue.ToString ());
                                }
                            UpdateGridData (Convert.ToInt32 (Grid_Periods.SelectedRows [0].Cells [0].Value));
                            break;
                            }
                    case 9:
                            {
                            //WaterFrom
                            CustomInput.InputType = "number";    //number, string
                            CustomInput.DefaultValue = (Grid_Data [9, r].Value).ToString ();
                            CustomInput.ReturnValue = "";
                            CustomInput.MessageText = "شماره کنتور آب اين واحد در ابتداي اين دوره";
                            CustomInput.Cancelled = true;
                            var frmInputBox = new frmInput ();
                            frmInputBox.ShowDialog ();
                            if (!CustomInput.Cancelled)
                                {
                                ZagrApp.UpdatePeriodsUnitsRecord (id, "WaterFrom", CustomInput.ReturnValue.ToString ());
                                }
                            UpdateGridData (Convert.ToInt32 (Grid_Periods.SelectedRows [0].Cells [0].Value));
                            break;
                            }
                    case 10:
                            {
                            //WaterTo
                            CustomInput.InputType = "number";    //number, string
                            CustomInput.DefaultValue = (Grid_Data [10, r].Value).ToString ();
                            CustomInput.ReturnValue = "";
                            CustomInput.MessageText = "شماره کنتور آب اين واحد در پايان اين دوره";
                            CustomInput.Cancelled = true;
                            var frmInputBox = new frmInput ();
                            frmInputBox.ShowDialog ();
                            if (!CustomInput.Cancelled)
                                {
                                ZagrApp.UpdatePeriodsUnitsRecord (id, "WaterTo", CustomInput.ReturnValue.ToString ());
                                }
                            UpdateGridData (Convert.ToInt32 (Grid_Periods.SelectedRows [0].Cells [0].Value));
                            break;
                            }
                    case 12:
                            {
                            //Note
                            CustomInput.InputType = "string";    //number, string
                            CustomInput.DefaultValue = (Grid_Data [12, r].Value).ToString ();
                            CustomInput.ReturnValue = "";
                            CustomInput.MessageText = "يادداشت حسابداري مجتمع براي اين واحد در اين دوره";
                            CustomInput.Cancelled = true;
                            var frmInputBox = new frmInput ();
                            frmInputBox.ShowDialog ();
                            if (!CustomInput.Cancelled)
                                {
                                ZagrApp.UpdatePeriodsUnitsRecord (id, "Note", CustomInput.ReturnValue.ToString ());
                                }
                            UpdateGridData (Convert.ToInt32 (Grid_Periods.SelectedRows [0].Cells [0].Value));
                            break;
                            }
                    }
                }
            catch (Exception ex)
                {
                MessageBox.Show (ex.ToString ());
                }
            }
        private void UpdateGridData (int periodid)
            {
            ZagrApp.GetPeriodUnitsData (periodid);
            Grid_Data.DataSource = DB.DS.Tables ["tblPeriodsUnits"];
            FormatGridCols (2); //1:gridPerids 2:gridData
            }
        private void FormatGridCols (int t)
            {
            //t= 1:gridPerids 2:gridData
            switch (t)
                {
                case 1:
                        {
                        try
                            {
                            for (int i = 0; i < Grid_Periods.Columns.Count; i++)
                                {
                                Grid_Periods.Columns [i].SortMode = DataGridViewColumnSortMode.Programmatic;
                                }
                            }
                        catch { }
                        Grid_Periods.Columns [0].Visible = false;   // 0  ID
                        Grid_Periods.Columns [1].Width = 70;        // 1  Name
                        Grid_Periods.Columns [2].Visible = false;   // 2  CntWater
                        Grid_Periods.Columns [3].Width = 70;        // 3  ExpWater
                        Grid_Periods.Columns [4].Width = 70;        // 4  ExpElec
                        Grid_Periods.Columns [5].Width = 70;        // 5  ExpDoorPump
                        Grid_Periods.Columns [6].Width = 60;        // 6  ExpGuard
                        Grid_Periods.Columns [7].Width = 70;        // 7  ExpElev1
                        Grid_Periods.Columns [8].Width = 70;        // 8  ExpElev2
                        Grid_Periods.Columns [9].Width = 70;        // 9  ExpRepair
                        Grid_Periods.Columns [10].Width = 70;       // 10 ExpMisc
                        Grid_Periods.Columns [11].Width = 40;       // 11 PeopleTotal
                        Grid_Periods.Columns [12].Visible = false;  // 12 BookKeeper
                        Grid_Periods.Columns [13].Width = 385;      // 13 Note
                        Grid_Periods.Columns [14].Width = 70;       // 14 1DateStart
                        Grid_Periods.Columns [15].Width = 70;       // 15 DateEnd
                        Grid_Periods.Columns [16].Visible = false;  // 16 DateCnt
                        Grid_Periods.Columns [17].Width = 30;       // 17 IsActive
                        break;
                        }
                case 2:
                        {
                        try
                            {
                            for (int i = 0; i < Grid_Data.Columns.Count; i++)
                                {
                                Grid_Data.Columns [i].SortMode = DataGridViewColumnSortMode.Programmatic;
                                }
                            }
                        catch { }
                        Grid_Data.Columns [0].Width = 70;         // 0  ID
                        Grid_Data.Columns [1].Width = 70;         // 1  Period_ID
                        Grid_Data.Columns [2].Width = 70;         // 2  Unit_ID
                        Grid_Data.Columns [3].Visible = false;    // 3  Owner
                        Grid_Data.Columns [4].Width = 120;        // 4  Owner_Name
                        Grid_Data.Columns [5].Visible = false;    // 5  Resident
                        Grid_Data.Columns [6].Width = 120;        // 6  Resident_Name
                        Grid_Data.Columns [7].Width = 50;         // 7  IsRent
                        Grid_Data.Columns [8].Width = 60;         // 8  People
                        Grid_Data.Columns [9].Width = 120;        // 9  WaterFrom
                        Grid_Data.Columns [10].Width = 120;       // 10 WaterTo
                        Grid_Data.Columns [11].Width = 120;       // 11 ChargeBill
                        Grid_Data.Columns [12].Width = 320;       // 12 Note
                        Grid_Data.Columns [13].Visible = false;   // 13 Area
                        break;
                        }
                }
            }
        //exit
        private void lbl_Exit_Click (object sender, EventArgs e)
            {
            Dispose ();
            }
        }
    }
