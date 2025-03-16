using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ZagrosDesktop
    {
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated ()]
    public partial class frmSwitchBoard : Form
    {

        // Form overrides dispose to clean up the component list.
        [DebuggerNonUserCode ()]
        protected override void Dispose (bool disposing)
        {
            try
            {
                if (disposing && components is not null)
                {
                    components.Dispose ();
                }
            }
            finally
            {
                base.Dispose (disposing);
            }
        }

        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer components;

        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
        [DebuggerStepThrough ()]
        private void InitializeComponent ()
            {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager (typeof (frmSwitchBoard));
            btn_Save = new PictureBox ();
            btn_Notes = new PictureBox ();
            lbl_ResidentialName = new Label ();
            btn_Settings = new PictureBox ();
            btn_Periods = new PictureBox ();
            btn_Tables = new PictureBox ();
            Label1 = new Label ();
            Label4 = new Label ();
            Label5 = new Label ();
            Label7 = new Label ();
            Label10 = new Label ();
            label8 = new Label ();
            btn_Report = new PictureBox ();
            panel1 = new Panel ();
            lbl_Exit = new Label ();
            ((System.ComponentModel.ISupportInitialize) btn_Save).BeginInit ();
            ((System.ComponentModel.ISupportInitialize) btn_Notes).BeginInit ();
            ((System.ComponentModel.ISupportInitialize) btn_Settings).BeginInit ();
            ((System.ComponentModel.ISupportInitialize) btn_Periods).BeginInit ();
            ((System.ComponentModel.ISupportInitialize) btn_Tables).BeginInit ();
            ((System.ComponentModel.ISupportInitialize) btn_Report).BeginInit ();
            panel1.SuspendLayout ();
            SuspendLayout ();
            // 
            // btn_Save
            // 
            btn_Save.Image = (Image) resources.GetObject ("btn_Save.Image");
            btn_Save.Location = new Point (331, 273);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new Size (62, 55);
            btn_Save.SizeMode = PictureBoxSizeMode.Zoom;
            btn_Save.TabIndex = 28;
            btn_Save.TabStop = false;
            btn_Save.Click += btn_Save_Click;
            // 
            // btn_Notes
            // 
            btn_Notes.Image = (Image) resources.GetObject ("btn_Notes.Image");
            btn_Notes.Location = new Point (95, 275);
            btn_Notes.Name = "btn_Notes";
            btn_Notes.Size = new Size (60, 53);
            btn_Notes.SizeMode = PictureBoxSizeMode.Zoom;
            btn_Notes.TabIndex = 36;
            btn_Notes.TabStop = false;
            // 
            // lbl_ResidentialName
            // 
            lbl_ResidentialName.BackColor = SystemColors.Control;
            lbl_ResidentialName.Dock = DockStyle.Top;
            lbl_ResidentialName.Font = new Font ("Segoe UI", 32.25F);
            lbl_ResidentialName.ForeColor = Color.DarkGoldenrod;
            lbl_ResidentialName.Location = new Point (0, 0);
            lbl_ResidentialName.Name = "lbl_ResidentialName";
            lbl_ResidentialName.RightToLeft = RightToLeft.No;
            lbl_ResidentialName.Size = new Size (729, 75);
            lbl_ResidentialName.TabIndex = 0;
            lbl_ResidentialName.Text = "زاگرس";
            lbl_ResidentialName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_Settings
            // 
            btn_Settings.Image = (Image) resources.GetObject ("btn_Settings.Image");
            btn_Settings.Location = new Point (561, 275);
            btn_Settings.Name = "btn_Settings";
            btn_Settings.Size = new Size (77, 51);
            btn_Settings.SizeMode = PictureBoxSizeMode.Zoom;
            btn_Settings.TabIndex = 90;
            btn_Settings.TabStop = false;
            btn_Settings.DoubleClick += btn_Settings_DoubleClick;
            // 
            // btn_Periods
            // 
            btn_Periods.Image = (Image) resources.GetObject ("btn_Periods.Image");
            btn_Periods.Location = new Point (334, 125);
            btn_Periods.Name = "btn_Periods";
            btn_Periods.Size = new Size (60, 60);
            btn_Periods.SizeMode = PictureBoxSizeMode.Zoom;
            btn_Periods.TabIndex = 93;
            btn_Periods.TabStop = false;
            btn_Periods.Click += btn_Periods_Click;
            // 
            // btn_Tables
            // 
            btn_Tables.Image = (Image) resources.GetObject ("btn_Tables.Image");
            btn_Tables.Location = new Point (567, 115);
            btn_Tables.Name = "btn_Tables";
            btn_Tables.Size = new Size (84, 71);
            btn_Tables.SizeMode = PictureBoxSizeMode.Zoom;
            btn_Tables.TabIndex = 98;
            btn_Tables.TabStop = false;
            btn_Tables.Click += btn_Tables_Click;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font ("Segoe UI", 11F);
            Label1.Location = new Point (568, 339);
            Label1.Name = "Label1";
            Label1.Size = new Size (64, 20);
            Label1.TabIndex = 99;
            Label1.Text = "تنظيمات";
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Font = new Font ("Segoe UI", 11F);
            Label4.Location = new Point (311, 339);
            Label4.Name = "Label4";
            Label4.Size = new Size (100, 20);
            Label4.TabIndex = 101;
            Label4.Text = "ثبت تراکنش ها";
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.Font = new Font ("Segoe UI", 11F);
            Label5.Location = new Point (577, 189);
            Label5.Name = "Label5";
            Label5.Size = new Size (62, 20);
            Label5.TabIndex = 102;
            Label5.Text = "جدول ها";
            // 
            // Label7
            // 
            Label7.AutoSize = true;
            Label7.Font = new Font ("Segoe UI", 11F);
            Label7.Location = new Point (307, 189);
            Label7.Name = "Label7";
            Label7.Size = new Size (113, 20);
            Label7.TabIndex = 104;
            Label7.Text = "دوره ها و شارژها";
            // 
            // Label10
            // 
            Label10.AutoSize = true;
            Label10.Font = new Font ("Segoe UI", 11F);
            Label10.Location = new Point (92, 339);
            Label10.Name = "Label10";
            Label10.Size = new Size (65, 20);
            Label10.TabIndex = 107;
            Label10.Text = "يادداشت";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font ("Segoe UI", 11F);
            label8.Location = new Point (78, 189);
            label8.Name = "label8";
            label8.Size = new Size (105, 20);
            label8.TabIndex = 116;
            label8.Text = "گزارش و نمودار";
            // 
            // btn_Report
            // 
            btn_Report.Image = (Image) resources.GetObject ("btn_Report.Image");
            btn_Report.Location = new Point (94, 125);
            btn_Report.Name = "btn_Report";
            btn_Report.Size = new Size (69, 57);
            btn_Report.SizeMode = PictureBoxSizeMode.Zoom;
            btn_Report.TabIndex = 113;
            btn_Report.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add (lbl_Exit);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point (0, 418);
            panel1.Name = "panel1";
            panel1.Size = new Size (729, 22);
            panel1.TabIndex = 117;
            // 
            // lbl_Exit
            // 
            lbl_Exit.BackColor = Color.LightCoral;
            lbl_Exit.Dock = DockStyle.Bottom;
            lbl_Exit.Font = new Font ("Segoe UI", 10F);
            lbl_Exit.ForeColor = Color.White;
            lbl_Exit.Location = new Point (0, 0);
            lbl_Exit.Name = "lbl_Exit";
            lbl_Exit.Size = new Size (729, 22);
            lbl_Exit.TabIndex = 17;
            lbl_Exit.Text = "خروج";
            lbl_Exit.TextAlign = ContentAlignment.MiddleCenter;
            lbl_Exit.Click += lbl_Exit_Click;
            // 
            // frmSwitchBoard
            // 
            AutoScaleDimensions = new SizeF (7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size (729, 440);
            Controls.Add (panel1);
            Controls.Add (label8);
            Controls.Add (btn_Report);
            Controls.Add (Label10);
            Controls.Add (Label7);
            Controls.Add (Label5);
            Controls.Add (Label4);
            Controls.Add (Label1);
            Controls.Add (btn_Tables);
            Controls.Add (btn_Periods);
            Controls.Add (btn_Settings);
            Controls.Add (lbl_ResidentialName);
            Controls.Add (btn_Notes);
            Controls.Add (btn_Save);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon) resources.GetObject ("$this.Icon");
            MaximizeBox = false;
            Name = "frmSwitchBoard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SwitchBoard";
            Load += frmSwitchBoard_Load;
            ((System.ComponentModel.ISupportInitialize) btn_Save).EndInit ();
            ((System.ComponentModel.ISupportInitialize) btn_Notes).EndInit ();
            ((System.ComponentModel.ISupportInitialize) btn_Settings).EndInit ();
            ((System.ComponentModel.ISupportInitialize) btn_Periods).EndInit ();
            ((System.ComponentModel.ISupportInitialize) btn_Tables).EndInit ();
            ((System.ComponentModel.ISupportInitialize) btn_Report).EndInit ();
            panel1.ResumeLayout (false);
            ResumeLayout (false);
            PerformLayout ();
            }
        internal PictureBox btn_Save;
        internal PictureBox btn_Notes;
        private Label lbl_ResidentialName;
        internal PictureBox btn_Settings;
        internal PictureBox btn_Periods;
        internal PictureBox btn_Tables;
        internal Label Label1;
        internal Label Label4;
        internal Label Label5;
        internal Label Label7;
        internal Label Label10;
        internal Label label8;
        internal PictureBox btn_Report;
        private Panel panel1;
        private Label lbl_Exit;
        }
}