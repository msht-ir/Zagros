using Microsoft.VisualBasic;
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
    public partial class frmSettings : Form
        {
        public frmSettings ()
            {
            InitializeComponent ();
            }
        private void frmSettings_Load (object sender, EventArgs e)
            {
            if (DB.ReadConnectionString ())
                {
                txt_Residential.Text=DB.ResidentialName;
                txt_cnnString.Text = DB.CnnString;
                }
            }
        private void btn_ClearDatabase_Click (object sender, EventArgs e)
            {
            DialogResult myAnsw = MessageBox.Show ("اخطار: همه اطلاعات  اين ديتابيس براي هميشه پاک خواهند شد" + "\n\n ادامه مي دهيد؟\n\nآيا مطمئن هستيد؟", "تاييد کنيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign);
            if (myAnsw == DialogResult.Yes)
                {
                if (DB.ClearTables ())
                    {
                    MessageBox.Show ("ديتابيس پاک شد");
                    }
                }
            }
        private void lbl_Save_Click (object sender, EventArgs e)
            {
            DB.CnnString = txt_cnnString.Text;
            DB.ResidentialName = txt_Residential.Text;
            FileSystem.FileClose ();
            FileSystem.FileOpen (1, Application.StartupPath + @"\cnn.txt", OpenMode.Output);
            FileSystem.PrintLine (1, "ConnectionString");
            FileSystem.PrintLine (1, txt_Residential.Text);
            FileSystem.PrintLine (1, txt_cnnString.Text);
            FileSystem.FileClose ();
            Dispose ();
            }
        private void lbl_Cancel_Click (object sender, EventArgs e)
            {
            Dispose ();
            }
        }
    }
