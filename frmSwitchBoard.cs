using System;
using System.Windows.Forms;
using ZagrosDesktop;

namespace ZagrosDesktop
    {
    public partial class frmSwitchBoard
        {
        public frmSwitchBoard ()
            {
            InitializeComponent ();
            }
        private void frmSwitchBoard_Load (object sender, EventArgs e)
            {
            lbl_ResidentialName.Text = DB.ResidentialName;
            }
        private void btn_Save_Click (object sender, EventArgs e)
            {
            int checks = DB.NotFilledTables ();
            if ((checks & 1) == 1)
                {
                btn_Tables_Click (null, null);
                return;
                }
            else if ((checks & 4) == 4)
                {
                //call frmPeriods
                var frmPeriod = new frmPeriods ();
                frmPeriod.ShowDialog ();
                return;
                }
            else
                {
                ZagrApp.RequestModeNew_Edit = "New";
                var frmTransactions = new frmTransaction ();
                frmTransactions.ShowDialog ();
                }
            }
        private void btn_Periods_Click (object sender, EventArgs e)
            {
            int checks = DB.NotFilledTables ();
            if ((checks & 1) == 1)
                {
                btn_Tables_Click (null, null);
                return;
                }
            else if ((checks & 2) == 2)
                {
                btn_Tables_Click (null, null);
                return;
                }
            else
                {
                var frmPeriod = new frmPeriods ();
                frmPeriod.ShowDialog ();
                }
            }
        private void btn_Tables_Click (object sender, EventArgs e)
            {
            var frmTbl = new frmTables ();
            frmTbl.ShowDialog ();
            }
        private void btn_Settings_DoubleClick (object sender, EventArgs e)
            {
            var frmSetting =  new frmSettings ();
            frmSetting.ShowDialog ();
            lbl_ResidentialName.Text = DB.ResidentialName;
            }
        //exit
        private void lbl_Exit_Click (object sender, EventArgs e)
            {
            Dispose ();
            Application.Exit ();
            }
        private void frmSwitchBoard_FormClosing (object sender, FormClosingEventArgs e)
            {
            if (e.CloseReason == CloseReason.UserClosing)
                {
                e.Cancel = true;
                }
            }
        }
    }