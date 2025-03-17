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
    public partial class frmTables : Form
        {
        public string CurrentTableInGrid = "";
        public frmTables ()
            {
            InitializeComponent ();
            }
        private void frmTables_Load (object sender, EventArgs e)
            {
            ZagrApp.RefeedTables (63, false, 0); //{1:Accs 2:Cats 4:Periods 8:PeriodsUnits 16:Persons 32:Units} all=63 //0:all AccCats
            }
        //btns: Units
        private void btn_Units_Click (object sender, EventArgs e)
            {
            ShowData ("tblUnits");
            }
        private void btn_AddNewUnit_Click (object sender, EventArgs e)
            {
            string NewName = "";
            int NewArea = 0;
            CustomInput.InputType = "string";    //number, string
            CustomInput.DefaultValue = "نام/شماره واحد)";
            CustomInput.ReturnValue = "";
            CustomInput.MessageText = "نام/شماره واحد مسکوني جديد را (حداکثر 10 حرف) وارد کنيد ";
            CustomInput.Cancelled = true;
            var frmInputBox1 = new frmInput ();
            frmInputBox1.ShowDialog ();
            if (CustomInput.Cancelled)
                {
                return;
                }
            else
                {
                NewName = CustomInput.ReturnValue.ToString ();
                }
            CustomInput.InputType = "number";    //number, string
            CustomInput.DefaultValue = "120";
            CustomInput.ReturnValue = "";
            CustomInput.MessageText = "متراژ واحد مسکوني جديد را وارد کنيد";
            CustomInput.Cancelled = true;
            var frmInputBox2 = new frmInput ();
            frmInputBox2.ShowDialog ();
            if (CustomInput.Cancelled)
                {
                return;
                }
            else
                {
                NewArea = Convert.ToInt32 (CustomInput.ReturnValue.ToString ());
                }
            ZagrApp.AddNewUnit (NewName, NewArea);
            ZagrApp.RefeedTables (32, false, 0); //all=63 {1:Accs 2:Cats 4:Periods 8:PeriodsUnits 16:Persons 32:Units}
            ShowData ("tblUnits");
            }
        private void btn_EditUnit_Click (object sender, EventArgs e)
            {
            if (Grid_Tables.Rows.Count == 0)
                {
                return;
                }
            if (CurrentTableInGrid == "tblUnits")
                {
                string NewName = "";
                int NewArea = 0;
                int UnitId = Convert.ToInt32 (Grid_Tables.SelectedRows [0].Cells [0].Value.ToString ());
                CustomInput.InputType = "string";    //number, string
                CustomInput.DefaultValue = Grid_Tables.SelectedRows [0].Cells [1].Value.ToString ();
                CustomInput.ReturnValue = "";
                CustomInput.MessageText = "نام/شماره واحد مسکوني (حداکثر 10 حرف) ";
                CustomInput.Cancelled = true;
                var frmInputBox1 = new frmInput ();
                frmInputBox1.ShowDialog ();
                if (CustomInput.Cancelled)
                    {
                    return;
                    }
                else
                    {
                    NewName = CustomInput.ReturnValue.ToString ();
                    }
                CustomInput.InputType = "number";    //number, string
                CustomInput.DefaultValue = Grid_Tables.SelectedRows [0].Cells [2].Value.ToString ();
                CustomInput.ReturnValue = "";
                CustomInput.MessageText = "متراژ واحد مسکوني";
                CustomInput.Cancelled = true;
                var frmInputBox2 = new frmInput ();
                frmInputBox2.ShowDialog ();
                if (CustomInput.Cancelled)
                    {
                    return;
                    }
                else
                    {
                    NewArea = Convert.ToInt32 (CustomInput.ReturnValue.ToString ());
                    }
                ZagrApp.UpdateUnit (NewName, NewArea, UnitId);
                ZagrApp.RefeedTables (32, false, 0); //all=63 {1:Accs 2:Cats 4:Periods 8:PeriodsUnits 16:Persons 32:Units}
                ShowData ("tblUnits");
                }
            }
        //btns: Persons
        private void btn_Persons_Click (object sender, EventArgs e)
            {
            ShowData ("tblPersons");
            }
        private void btn_AddNewPerson_Click (object sender, EventArgs e)
            {
            string PersonName = "";
            string PersonTitle = "";
            string PersonNote = "";
            CustomInput.InputType = "string";    //number, string
            CustomInput.DefaultValue = "نام و نام خانوادگي";
            CustomInput.ReturnValue = "";
            CustomInput.MessageText = "نام و نام خانوادگي فرد جديد را وارد کنيد";
            CustomInput.Cancelled = true;
            var frmInputBox1 = new frmInput ();
            frmInputBox1.ShowDialog ();
            if (CustomInput.Cancelled)
                {
                return;
                }
            else
                {
                PersonName = CustomInput.ReturnValue.ToString ();
                }
            CustomInput.InputType = "string";    //number, string
            CustomInput.DefaultValue = "خانم/آقاي";
            CustomInput.ReturnValue = "";
            CustomInput.MessageText = "عنوان شخص را وارد کنيد";
            CustomInput.Cancelled = true;
            var frmInputBox2 = new frmInput ();
            frmInputBox2.ShowDialog ();
            if (CustomInput.Cancelled)
                {
                return;
                }
            else
                {
                PersonTitle = CustomInput.ReturnValue.ToString ();
                }
            CustomInput.InputType = "string";    //number, string
            CustomInput.DefaultValue = "-";
            CustomInput.ReturnValue = "";
            CustomInput.MessageText = "توضيحات مربوطه به فرد جديد را وارد کنيد";
            CustomInput.Cancelled = true;
            var frmInputBox3 = new frmInput ();
            frmInputBox3.ShowDialog ();
            if (CustomInput.Cancelled)
                {
                return;
                }
            else
                {
                PersonNote = CustomInput.ReturnValue.ToString ();
                }
            ZagrApp.AddNewPerson (PersonTitle, PersonName, PersonNote);
            ZagrApp.RefeedTables (16, false, 0); //all=63 {1:Accs 2:Cats 4:Periods 8:PeriodsUnits 16:Persons 32:Units}
            ShowData ("tblPersons");
            }
        private void btn_EditPerson_Click (object sender, EventArgs e)
            {
            if (Grid_Tables.Rows.Count == 0)
                {
                return;
                }
            if (CurrentTableInGrid == "tblPersons")
                {
                string PersonName = "";
                string PersonTitle = "";
                string PersonNote = "";
                int PersonId = Convert.ToInt32 (Grid_Tables.SelectedRows [0].Cells [0].Value.ToString ());
                CustomInput.InputType = "string";    //number, string
                CustomInput.DefaultValue = Grid_Tables.SelectedRows [0].Cells [2].Value.ToString ();
                CustomInput.ReturnValue = "";
                CustomInput.MessageText = "نام و نام خانوادگي";
                CustomInput.Cancelled = true;
                var frmInputBox1 = new frmInput ();
                frmInputBox1.ShowDialog ();
                if (CustomInput.Cancelled)
                    {
                    return;
                    }
                else
                    {
                    PersonName = CustomInput.ReturnValue.ToString ();
                    }
                CustomInput.InputType = "string";    //number, string
                CustomInput.DefaultValue = Grid_Tables.SelectedRows [0].Cells [1].Value.ToString ();
                CustomInput.ReturnValue = "";
                CustomInput.MessageText = "عنوان شخص";
                CustomInput.Cancelled = true;
                var frmInputBox2 = new frmInput ();
                frmInputBox2.ShowDialog ();
                if (CustomInput.Cancelled)
                    {
                    return;
                    }
                else
                    {
                    PersonTitle = CustomInput.ReturnValue.ToString ();
                    }
                CustomInput.InputType = "string";    //number, string
                CustomInput.DefaultValue = Grid_Tables.SelectedRows [0].Cells [4].Value.ToString ();
                CustomInput.ReturnValue = "";
                CustomInput.MessageText = "توضيحات";
                CustomInput.Cancelled = true;
                var frmInputBox3 = new frmInput ();
                frmInputBox3.ShowDialog ();
                if (CustomInput.Cancelled)
                    {
                    return;
                    }
                else
                    {
                    PersonNote = CustomInput.ReturnValue.ToString ();
                    }
                if (ZagrApp.UpdatePerson (PersonTitle, PersonName, PersonNote, PersonId))
                    {
                    ZagrApp.RefeedTables (16, false, 0); //all=63 {1:Accs 2:Cats 4:Periods 8:PeriodsUnits 16:Persons 32:Units}
                    ShowData ("tblPersons");
                    }
                else
                    {
                    MessageBox.Show ("Error saving updates");
                    }
                }
            }
        //btns: Periods
        private void btn_Periods_Click (object sender, EventArgs e)
            {
            ShowData ("tblPeriods");
            }
        //btns: Cats
        private void btn_Cats_Click (object sender, EventArgs e)
            {
            ShowData ("tblCats");
            }
        //btns: Accs
        private void btn_Accs_Click (object sender, EventArgs e)
            {
            ZagrApp.RefeedTables (1, false, 0); //[0]:all 1:expenses 2:payments 3:charge            
            ShowData ("tblAccs");
            }
        private void btn_DeleteAccItem_Click (object sender, EventArgs e)
            {
            if (Grid_Tables.Rows.Count == 0)
                {
                return;
                }
            if (CurrentTableInGrid == "tblAccs")
                {
                DialogResult myAnsw = MessageBox.Show ("آيتم هاي انتخاب شده از حساب حذف شوند؟", "تاييد کنيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (myAnsw == DialogResult.Yes)
                    {
                    int cnt = 0;
                    foreach (DataGridViewRow r in Grid_Tables.SelectedRows)
                        {
                        //MessageBox.Show ("deleting: " + Grid_Tables [0, r.Index].Value.ToString ());
                        ZagrApp.DeleteTransaction (Convert.ToInt32 (Grid_Tables [0, r.Index].Value));
                        cnt++;
                        }
                    ZagrApp.RefeedTables (1, false, 0); //all=63 {1:Accs 2:Cats 4:Periods 8:PeriodsUnits 16:Persons 32:Units}
                    ShowData ("tblAccs");
                    MessageBox.Show ("تعداد " + cnt.ToString () + " آيتم انتخاب شده توسط شما از حساب حذف شد");
                    }
                }
            }
        private void btn_EditAccItem_Click (object sender, EventArgs e)
            {
            if ((CurrentTableInGrid == "tblAccs") && (Grid_Tables.Rows.Count > 0))
                {
                //0ID 1Date 2Subject  3Amount 4CatID 5PeriodID 6UnitID 7Note
                TransaxnEdit.Id = Convert.ToInt32 (Grid_Tables.Rows [Grid_Tables.SelectedRows [0].Index].Cells [0].Value);
                TransaxnEdit.Datum = Grid_Tables.Rows [Grid_Tables.SelectedRows [0].Index].Cells [1].Value.ToString ();
                TransaxnEdit.Subjectx = Grid_Tables.Rows [Grid_Tables.SelectedRows [0].Index].Cells [2].Value.ToString ();
                TransaxnEdit.Amount = Convert.ToInt32 (Grid_Tables.Rows [Grid_Tables.SelectedRows [0].Index].Cells [3].Value);
                TransaxnEdit.CatId = Convert.ToInt32 (Grid_Tables.Rows [Grid_Tables.SelectedRows [0].Index].Cells [4].Value);
                TransaxnEdit.PeriodId = Convert.ToInt32 (Grid_Tables.Rows [Grid_Tables.SelectedRows [0].Index].Cells [5].Value);
                TransaxnEdit.UnitId = Convert.ToInt32 (Grid_Tables.Rows [Grid_Tables.SelectedRows [0].Index].Cells [6].Value);
                TransaxnEdit.Note = Grid_Tables.Rows [Grid_Tables.SelectedRows [0].Index].Cells [7].Value.ToString ();
                if (TransaxnEdit.CatId == 3)
                    {
                    MessageBox.Show ("شارژهاي صادر شده را نمي توانيد بصورت دستي ويرايش کنيد");
                    return;
                    }
                DialogResult myAnsw = MessageBox.Show ("آيتم انتخاب شده ويرايش شود؟\n\nتوجه: شارژهاي صادره ممکن است بي اعتبار شوند\n\n\nادامه مي دهيد؟", "تاييد کنيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (myAnsw == DialogResult.No)
                    {
                    return;
                    }
                else
                    {
                    //open form
                    ZagrApp.RequestModeNew_Edit = "Edit";
                    var frmTransactions = new frmTransaction ();
                    frmTransactions.ShowDialog ();
                    //refresh grid
                    ZagrApp.RefeedTables (1, false, 0);
                    ShowData ("tblAccs");
                    }
                }
            }
        private void btn_Accs_Expenses_Click (object sender, EventArgs e)
            {
            ZagrApp.RefeedTables (1, false, 1); //0:all [1]:expenses 2:payments 3:charge
            ShowData ("tblAccs");
            }
        private void btn_Accs_Payments_Click (object sender, EventArgs e)
            {
            ZagrApp.RefeedTables (1, false, 2); //0:all 1:expenses [2]:payments 3:charge
            ShowData ("tblAccs");
            }
        private void btn_Accs_Charges_Click (object sender, EventArgs e)
            {
            ZagrApp.RefeedTables (1, false, 3); //0:all 1:expenses 2:payments [3]:charge
            ShowData ("tblAccs");
            }
        //methods
        private void ShowData (string tbl)
            {
            try
                {
                Grid_Tables.DataSource = null;
                Grid_Tables.DataSource = DB.DS.Tables [tbl];
                for (int i = 0; i < Grid_Tables.Columns.Count; i++)
                    {
                    Grid_Tables.Columns [i].SortMode = DataGridViewColumnSortMode.Programmatic;
                    }
                }
            catch { }
            CurrentTableInGrid = tbl;
            switch (tbl)
                {
                case "tblUnits":
                        {
                        Grid_Tables.Columns [0].Width = 80;         // 0  ID
                        Grid_Tables.Columns [1].Width = 100;        // 1  Name
                        Grid_Tables.Columns [2].Width = 100;        // 2  Area
                        Grid_Tables.Columns [3].Width = 100;        // 3  Parking
                        Grid_Tables.Columns [4].Width = 100;        // 3  Elec
                        Grid_Tables.Columns [5].Width = 100;        // 3  Gass
                        break;
                        }
                case "tblPersons":
                        {
                        Grid_Tables.Columns [0].Width = 100;        // 0  ID
                        Grid_Tables.Columns [1].Width = 180;        // 1  Title
                        Grid_Tables.Columns [2].Width = 250;        // 2  Name
                        Grid_Tables.Columns [3].Width = 120;        // 3  Tel
                        Grid_Tables.Columns [4].Width = 500;        // 4  Note
                        break;
                        }
                case "tblCats":
                        {
                        Grid_Tables.Columns [0].Width = 80;         // 0  ID
                        Grid_Tables.Columns [1].Width = 280;        // 1  Title
                        Grid_Tables.Columns [2].Width = 300;        // 2  Note
                        break;
                        }
                case "tblPeriods":
                        {
                        Grid_Tables.Columns [0].Width = 50;        // ID
                        Grid_Tables.Columns [1].Width = 60;        // Name
                        Grid_Tables.Columns [2].Width = 70;        // CntWater
                        Grid_Tables.Columns [3].Width = 70;        // ExpWater
                        Grid_Tables.Columns [4].Width = 70;        // ExpElec
                        Grid_Tables.Columns [5].Width = 70;        // ExpDoorPump
                        Grid_Tables.Columns [6].Width = 70;        // ExpGuard
                        Grid_Tables.Columns [7].Width = 70;        // ExpElev1
                        Grid_Tables.Columns [8].Width = 70;        // ExpElev2
                        Grid_Tables.Columns [9].Width = 70;        // ExpRepair
                        Grid_Tables.Columns [10].Width = 70;       // ExpMisc
                        Grid_Tables.Columns [11].Width = 60;       // PeopleTotal
                        Grid_Tables.Columns [12].Visible = false;  // BookKeeper
                        Grid_Tables.Columns [13].Width = 99;       // Note
                        Grid_Tables.Columns [14].Width = 90;       // DateStart
                        Grid_Tables.Columns [15].Width = 90;       // DateEnd
                        Grid_Tables.Columns [16].Width = 90;       // DateCnt
                        Grid_Tables.Columns [17].Width = 40;       // IsActive
                        break;
                        }
                case "tblAccs":
                        {
                        Grid_Tables.Columns [0].Width = 60;         // 0  ID
                        Grid_Tables.Columns [1].Width = 100;        // 1  Date
                        Grid_Tables.Columns [2].Width = 320;        // 2  Subject
                        Grid_Tables.Columns [3].Width = 100;        // 3  Amount
                        Grid_Tables.Columns [4].Width = 70;         // 4  CatID
                        Grid_Tables.Columns [5].Width = 70;         // 5  PeriodID
                        Grid_Tables.Columns [6].Width = 70;         // 6  UnitID
                        Grid_Tables.Columns [7].Width = 400;        // 7  Note
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
