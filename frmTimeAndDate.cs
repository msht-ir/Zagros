using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Windows.Forms;

namespace ZagrosDesktop
    {
    public partial class frmTimeAndDate : Form
        {
        public frmTimeAndDate ()
            {
            InitializeComponent ();
            }
        private void frmTimeAndDate_Load (object sender, EventArgs e)
            {
                //calendar rtl?
                int intYear = Convert.ToInt32 (DateTime.Now.ToString ("yyyy").ToString ());
                if (intYear < 1450)
                    {
                    MC.RightToLeft = RightToLeft.Yes;
                    MC.RightToLeftLayout = true;
                    }
                else
                    {
                    MC.RightToLeft = RightToLeft.No;
                    MC.RightToLeftLayout = false;
                    }
                //reset flag
                MC.SetDate (DateTime.Now);
            txtDateTime.Focus ();
            txtDateTime.SelectionStart = 0;
            txtDateTime.SelectionLength = txtDateTime.Text.Length;
            }
        private void MC_DateSelected (object sender, DateRangeEventArgs e)
            {
            txtDateTime.Text = MC.SelectionStart.Date.ToString ("yyyy.MM.dd");
            txtDateTime.Focus ();
            txtDateTime.SelectionStart = 0;
            txtDateTime.SelectionLength = txtDateTime.Text.Length;
            }
        private void lblSelect_Click (object sender, EventArgs e)
            {
            if (txtDateTime.MaskCompleted)
                {
                ZagrApp.DialogOutput = txtDateTime.Text.Trim ();
                CustomInput.Cancelled = false;
                Dispose ();
                }
            }
        private void lblCancel_Click (object sender, EventArgs e)
            {
            CustomInput.Cancelled = true;
            Dispose ();
            }
        }
    }
