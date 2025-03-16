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
    public partial class frmPeriodEdit : Form
        {
        public frmPeriodEdit ()
            {
            InitializeComponent ();
            }
        private void frmPeriodEdit_Load (object sender, EventArgs e)
            {
            switch (ZagrApp.RequestModeNew_Edit)
                {
                case "New":
                        {
                        txt_Title.Text = "";
                        txt_BookKeeper.Text = "";
                        txt_DatumFrom.Text = "";
                        txt_DatumTo.Text = "";
                        txt_DatumCounter.Text = "";
                        txt_Note.Text = "";
                        chk_Active.Checked = true;
                        break;
                        }
                case "Edit":
                        {
                        txt_Title.Text = Periodx.Name;
                        txt_BookKeeper.Text = Periodx.BookKeeper;
                        txt_DatumFrom.Text = Periodx.DateStart;
                        txt_DatumTo.Text = Periodx.DateEnd;
                        txt_DatumCounter.Text = Periodx.DateCnt;
                        txt_Note.Text = Periodx.Note;
                        chk_Active.Checked = Periodx.IsActive;
                        break;
                        }
                }
            }
        private void txt_Title_KeyDown (object sender, KeyEventArgs e)
            {
            if (e.KeyCode == Keys.Enter)
                {
                txt_BookKeeper.Focus ();
                txt_BookKeeper.SelectionStart = 0;
                txt_BookKeeper.SelectionLength = txt_BookKeeper.Text.Length;
                }
            }
        private void txt_BookKeeper_KeyDown (object sender, KeyEventArgs e)
            {
            if (e.KeyCode == Keys.Enter)
                {
                txt_DatumFrom.Focus ();
                txt_DatumFrom.SelectionStart = 0;
                txt_DatumFrom.SelectionLength = txt_DatumFrom.Text.Length;
                }
            }
        private void txt_DatumFrom_KeyDown (object sender, KeyEventArgs e)
            {
            if (e.KeyCode == Keys.Enter)
                {
                txt_DatumTo.Focus ();
                txt_DatumTo.SelectionStart = 0;
                txt_DatumTo.SelectionLength = txt_DatumTo.Text.Length;
                }
            }
        private void txt_DatumTo_KeyDown (object sender, KeyEventArgs e)
            {
            if (e.KeyCode == Keys.Enter)
                {
                txt_DatumCounter.Focus ();
                txt_DatumCounter.SelectionStart = 0;
                txt_DatumCounter.SelectionLength = txt_DatumCounter.Text.Length;
                }
            }
        private void txt_DatumCounter_KeyDown (object sender, KeyEventArgs e)
            {
            if (e.KeyCode == Keys.Enter)
                {
                txt_Note.Focus ();
                txt_Note.SelectionStart = 0;
                txt_Note.SelectionLength = txt_Note.Text.Length;
                }
            }
        private void lbl_DatumFrom_Click (object sender, EventArgs e)
            {
            var frmDate = new frmTimeAndDate ();
            frmDate.ShowDialog ();
            if (!CustomInput.Cancelled)
                {
                txt_DatumFrom.Text = ZagrApp.DialogOutput.ToString ();
                }
            }
        private void lbl_DatumTo_Click (object sender, EventArgs e)
            {
            var frmDate = new frmTimeAndDate ();
            frmDate.ShowDialog ();
            if (!CustomInput.Cancelled)
                {
                txt_DatumTo.Text = ZagrApp.DialogOutput.ToString ();
                }
            }
        private void lbl_DatumCounter_Click (object sender, EventArgs e)
            {
            var frmDate = new frmTimeAndDate ();
            frmDate.ShowDialog ();
            if (!CustomInput.Cancelled)
                {
                txt_DatumCounter.Text = ZagrApp.DialogOutput.ToString ();
                }
            }
        //exit
        private void lbl_Save_Click (object sender, EventArgs e)
            {
            Periodx.Name = txt_Title.Text;
            Periodx.BookKeeper = txt_BookKeeper.Text;
            Periodx.DateStart = txt_DatumFrom.Text;
            Periodx.DateEnd = txt_DatumTo.Text;
            Periodx.DateCnt = txt_DatumCounter.Text;
            Periodx.Note = txt_Note.Text;
            Periodx.IsActive = chk_Active.Checked;
            //return ok
            ZagrApp.DialogOutput = "OK";
            Dispose ();
            }
        private void lbl_Cancel_Click (object sender, EventArgs e)
            {
            //tag cancel!
            ZagrApp.DialogOutput = "Cancel";
            Dispose ();
            }
        }
    }
