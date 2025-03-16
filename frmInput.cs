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
    public partial class frmInput : Form
        {
        public frmInput ()
            {
            InitializeComponent ();
            }
        private void frmInput_Load (object sender, EventArgs e)
            {
            txt_Input.Text = CustomInput.DefaultValue;
            lbl_Message.Text = CustomInput.MessageText;
            }
        private void txt_Input_KeyDown (object sender, KeyEventArgs e)
            {
            if (e.KeyCode == Keys.Enter)
                {
                lbl_OK_Click (null, null);
                }
            }
        //exit
        private void lbl_OK_Click (object sender, EventArgs e)
            {
            //InputType: check?
            CustomInput.ReturnValue = txt_Input.Text.Trim ();
            CustomInput.Cancelled = false;
            Dispose ();
            }
        private void lbl_Cancel_Click (object sender, EventArgs e)
            {
            CustomInput.Cancelled = true;
            Dispose ();
            }
        }
    }
