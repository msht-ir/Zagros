using Microsoft.IdentityModel.Tokens;
using Microsoft.VisualBasic;
using System;
using ZagrosDesktop;
namespace ZagrosDesktop
    {
    public partial class frmTransaction : Form
        {
        public frmTransaction ()
            {
            InitializeComponent ();
            }
        private void frmTransaction_Load (object sender, EventArgs e)
            {
            ZagrApp.RefeedTables (4, true);//{1:Accs 2:Cats 4:Periods 8:PeriodsUnits 16:Persons 32:Units}
            //calender setup
            int intYear = Convert.ToInt32 (DateTime.Now.ToString ("yyyy").ToString ());
            if (intYear < 1450)
                {
                mntCal.RightToLeft = RightToLeft.Yes;
                mntCal.RightToLeftLayout = true;
                }
            else
                {
                mntCal.RightToLeft = RightToLeft.No;
                mntCal.RightToLeftLayout = false;
                }
            mntCal.SetDate (DateTime.Now);
            cbo_Periods.DataSource = DB.DS.Tables ["tblPeriods"];
            cbo_Periods.ValueMember = "ID";
            cbo_Periods.DisplayMember = "Name";
            cbo_Units.DataSource = DB.DS.Tables ["tblUnits"];
            cbo_Units.ValueMember = "ID";
            cbo_Units.DisplayMember = "Name";
            cbo_Cats.DataSource = DB.DS.Tables ["tblCats"];
            cbo_Cats.ValueMember = "ID";
            cbo_Cats.DisplayMember = "Title";
            //mode
            switch (ZagrApp.RequestModeNew_Edit)
                {
                case "New":
                        {
                        UseTransactionMode (1); //1:Expenses 2:UnitsPays
                        break;
                        }
                case "Edit":
                        {
                        //0ID 1Date 2Subject 3Amount 4CatID 5PeriodID 6UnitID 7Note
                        switch (TransaxnEdit.CatId)
                            {
                            case 1:
                            case 2:
                                    {
                                    //Unit-payments
                                    opt_Pay.Checked = true; //UseTransactionMode (2); //1:Expenses 2:UnitsPays
                                    break;
                                    }
                            case 3:
                                    {
                                    //unit-charges issued
                                    Dispose ();
                                    break;
                                    }
                            default:
                                    {
                                    //expenses
                                    opt_Exp.Checked = true; //UseTransactionMode (1); //1:Expenses 2:UnitsPays
                                    break;
                                    }
                            }
                        //show data //order of lines below is important: to ovoid unwanted on-change/on-click events
                        cbo_Periods.SelectedValue = TransaxnEdit.PeriodId;
                        cbo_Units.SelectedValue = TransaxnEdit.UnitId;
                        cbo_Cats.SelectedValue = TransaxnEdit.CatId;
                        txt_Datum.Text = TransaxnEdit.Datum;
                        txt_Subject.Text = TransaxnEdit.Subjectx;
                        txt_Amount.Text = TransaxnEdit.Amount.ToString();
                        txt_Note.Text = TransaxnEdit.Note;
                        break;
                        }
                }            
            //focus
            txt_Amount.Focus ();
            txt_Amount.SelectionStart = 0;
            txt_Amount.SelectionLength = txt_Amount.Text.Length;
            }
        private void opt_Exp_CheckedChanged (object sender, EventArgs e)
            {
            ZagrApp.TransactionRequestType = (opt_Exp.Checked) ? 1 : 2;
            UseTransactionMode (ZagrApp.TransactionRequestType);
            }
        private void cbo_Cats_SelectedIndexChanged (object sender, EventArgs e)
            {
            txt_Subject.Text = "»«» : " + cbo_Cats.Text;
            txt_Note.Text = "„œÌ—⁄«„·: ";
            //focus
            txt_Amount.Focus ();
            txt_Amount.SelectionStart = 0;
            txt_Amount.SelectionLength = txt_Amount.Text.Length;
            }
        private void cbo_Units_SelectedIndexChanged (object sender, EventArgs e)
            {
            try
                {
                cbo_Cats.SelectedIndex = 1;
                txt_Subject.Text = "Å—œ«Œ ";
                txt_Note.Text = "Ê«Õœ " + cbo_Units.Text + ": ";
                //focus
                txt_Amount.Focus ();
                txt_Amount.SelectionStart = 0;
                txt_Amount.SelectionLength = txt_Amount.Text.Length;
                }
            catch
                {
                }
            }
        private void mntCal_DateSelected (object sender, DateRangeEventArgs e)
            {
            string tmpDate = mntCal.SelectionStart.ToString ();
            tmpDate = Strings.Mid (tmpDate, 7, 4) + "." + Strings.Mid (tmpDate, 4, 2) + "." + Strings.Left (tmpDate, 2);
            txt_Datum.Text = tmpDate;
            //focus
            txt_Amount.Focus ();
            txt_Amount.SelectionStart = 0;
            txt_Amount.SelectionLength = txt_Amount.Text.Length;
            }
        private void txt_Amount_KeyDown (object sender, KeyEventArgs e)
            {
            if (e.KeyCode == Keys.Enter)
                {
                txt_Subject.Focus ();
                txt_Subject.SelectionStart = 0;
                txt_Subject.SelectionLength = txt_Subject.Text.Length;
                }
            }
        private void txt_Subject_KeyDown (object sender, KeyEventArgs e)
            {
            if (e.KeyCode == Keys.Enter)
                {
                txt_Note.Focus ();
                txt_Note.SelectionStart = 0;
                txt_Note.SelectionLength = txt_Note.Text.Length;
                }
            }
        private void txt_Note_KeyDown (object sender, KeyEventArgs e)
            {
            if (e.KeyCode == Keys.Enter)
                {
                e.SuppressKeyPress = true;
                lbl_Save_Click (null, null);
                }
            }
        //methods
        private void UseTransactionMode (int mode)
            {
            lbl_Periods.Visible = false;
            cbo_Periods.Visible = false;
            lbl_Units.Visible = false;
            cbo_Units.Visible = false;
            lbl_Cats.Visible = false;
            cbo_Cats.Visible = false;

            //txt_Datum.Text = "";
            txt_Subject.Text = "";
            txt_Note.Text = "";
            //txt_Amount.Text = "0";
            if (mode == 1)
                {
                lbl_Periods.Visible = true;
                cbo_Periods.Visible = true;
                lbl_Cats.Visible = true;
                cbo_Cats.Visible = true;
                cbo_Cats.SelectedIndex = 6;
                txt_Subject.Text = "»«» : " + cbo_Cats.Text;
                txt_Note.Text = "„œÌ—⁄«„·:";
                }
            else if (mode == 2)
                {
                lbl_Units.Visible = true;
                cbo_Units.Visible = true;
                cbo_Cats.SelectedIndex = 1;
                txt_Subject.Text = "Å—œ«Œ ";
                txt_Note.Text = "Ê«Õœ " + cbo_Units.Text + ": ";
                }
            }
        private void FocusOnAmount ()
            {
            txt_Amount.Focus ();
            txt_Amount.SelectionStart = 0;
            txt_Amount.SelectionStart = txt_Amount.SelectionLength;
            }
        private bool CheckFormData ()
            {
            try
                {
                if ((int) cbo_Units.Items.Count == 0)
                    {
                    MessageBox.Show ("Â‘œ«—: Ê«ÕœÂ«Ì „”òÊ‰Ì Â‰Ê“  ⁄—Ì› ‰‘œÂ «‰œ");
                    return false;
                    }
                else if ((int) cbo_Periods.Items.Count == 0)
                    {
                    MessageBox.Show ("Â‘œ«—: œÊ—Â ‘«—é Â‰Ê“  ⁄—Ì› ‰‘œÂ «” ");
                    return false;
                    }
                else if (!txt_Datum.MaskCompleted)
                    {
                    txt_Datum.Focus ();
                    txt_Datum.SelectionStart = 0;
                    txt_Datum.SelectionLength = txt_Datum.TextLength;
                    return false;
                    }
                else if (Convert.ToInt32 (txt_Amount.Text) <= 0)
                    {
                    FocusOnAmount ();
                    return false;
                    }
                else
                    {
                    return true;
                    }
                }
            catch (Exception ex)
                {
                MessageBox.Show (ex.ToString ());
                return false;
                }
            }
        //exit
        private void lbl_Save_Click (object sender, EventArgs e)
            {
            if (CheckFormData ())
                {
                DialogResult myAnsw = MessageBox.Show (" —«ò‰‘ ›Êﬁ –ŒÌ—Â ‘Êœø", " «ÌÌœ ò‰Ìœ", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (myAnsw == DialogResult.No)
                    {
                    MessageBox.Show ("«‰’—«› - –ŒÌ—Â ‰‘œ");
                    }
                else
                    {
                    if (ZagrApp.RequestModeNew_Edit == "Edit")
                        {
                        if (!ZagrApp.DeleteTransaction (TransaxnEdit.Id))
                            {
                            MessageBox.Show ("Œÿ« œ— «’·«Õ «ÿ·«⁄«  ﬁ»·Ì «Ì‰  —«ò‰‘");
                            Dispose ();
                            return;
                            }
                        }
                    //create T object
                    Transactionx T = new Transactionx ();
                    ZagrApp.TransactionRequestType = (opt_Exp.Checked) ? 1 : 2;
                    switch (ZagrApp.TransactionRequestType)
                        {
                        case 1:
                                {
                                //exp
                                T.Id = 0;
                                T.Datum = txt_Datum.Text;
                                T.Subjectx = txt_Subject.Text;
                                T.Amount = Convert.ToInt32 (txt_Amount.Text) * (-1); //expenses: negative values
                                T.CatId = (int) cbo_Cats.SelectedValue;
                                T.PeriodId = (int) cbo_Periods.SelectedValue;
                                T.UnitId = 0;
                                T.Note = txt_Note.Text;
                                break;
                                }
                        case 2:
                                {
                                //unitPay
                                T.Id = 0;
                                T.Datum = txt_Datum.Text;
                                T.Subjectx = txt_Subject.Text;
                                T.Amount = Convert.ToInt32 (txt_Amount.Text);
                                T.CatId = (int) cbo_Cats.SelectedValue;
                                T.PeriodId = 0;
                                T.UnitId = (int) cbo_Units.SelectedValue;
                                T.Note = txt_Note.Text;
                                break;
                                }
                        default:
                                {
                                return;
                                }
                        }
                    int r = ZagrApp.AddNewTransaction (T);
                    if (r > 0)
                        {
                        lbl_Cancel_Click (null, null); //exit
                        }
                    else
                        {
                        MessageBox.Show ("Œÿ« œ—  –ŒÌ—Â ”«“Ì - «ÿ·«⁄«  –ŒÌ—Â ‰‘œ");
                        }
                    }
                }
            }
        private void lbl_Cancel_Click (object sender, EventArgs e)
            {
            Dispose ();
            }

        }
    }
