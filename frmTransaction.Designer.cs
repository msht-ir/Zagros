namespace ZagrosDesktop
    {
    partial class frmTransaction
        {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose (bool disposing)
            {
            if (disposing && (components != null))
                {
                components.Dispose ();
                }
            base.Dispose (disposing);
            }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ()
            {
            cbo_Periods = new ComboBox ();
            lbl_Periods = new Label ();
            lbl_Units = new Label ();
            cbo_Units = new ComboBox ();
            txt_Datum = new MaskedTextBox ();
            txt_Amount = new TextBox ();
            label4 = new Label ();
            label5 = new Label ();
            txt_Subject = new TextBox ();
            label6 = new Label ();
            txt_Note = new TextBox ();
            chk_Done = new CheckBox ();
            lbl_Cats = new Label ();
            cbo_Cats = new ComboBox ();
            panel1 = new Panel ();
            lbl_Cancel = new Label ();
            lbl_Save = new Label ();
            panel2 = new Panel ();
            panel3 = new Panel ();
            opt_Exp = new RadioButton ();
            opt_Pay = new RadioButton ();
            mntCal = new MonthCalendar ();
            lbl_Status = new Label ();
            panel1.SuspendLayout ();
            panel2.SuspendLayout ();
            panel3.SuspendLayout ();
            SuspendLayout ();
            // 
            // cbo_Periods
            // 
            cbo_Periods.BackColor = Color.White;
            cbo_Periods.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo_Periods.FlatStyle = FlatStyle.Flat;
            cbo_Periods.Font = new Font ("Segoe UI", 11F);
            cbo_Periods.FormattingEnabled = true;
            cbo_Periods.Location = new Point (361, 32);
            cbo_Periods.Name = "cbo_Periods";
            cbo_Periods.Size = new Size (121, 28);
            cbo_Periods.TabIndex = 0;
            // 
            // lbl_Periods
            // 
            lbl_Periods.AutoSize = true;
            lbl_Periods.Font = new Font ("Segoe UI", 11F);
            lbl_Periods.Location = new Point (520, 35);
            lbl_Periods.Name = "lbl_Periods";
            lbl_Periods.Size = new Size (38, 20);
            lbl_Periods.TabIndex = 1;
            lbl_Periods.Text = "دوره";
            // 
            // lbl_Units
            // 
            lbl_Units.AutoSize = true;
            lbl_Units.Font = new Font ("Segoe UI", 11F);
            lbl_Units.Location = new Point (520, 35);
            lbl_Units.Name = "lbl_Units";
            lbl_Units.Size = new Size (38, 20);
            lbl_Units.TabIndex = 3;
            lbl_Units.Text = "واحد";
            // 
            // cbo_Units
            // 
            cbo_Units.BackColor = Color.White;
            cbo_Units.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo_Units.FlatStyle = FlatStyle.Flat;
            cbo_Units.Font = new Font ("Segoe UI", 11F);
            cbo_Units.FormattingEnabled = true;
            cbo_Units.Location = new Point (361, 32);
            cbo_Units.Name = "cbo_Units";
            cbo_Units.Size = new Size (121, 28);
            cbo_Units.TabIndex = 2;
            cbo_Units.SelectedIndexChanged += cbo_Units_SelectedIndexChanged;
            // 
            // txt_Datum
            // 
            txt_Datum.BackColor = Color.WhiteSmoke;
            txt_Datum.BorderStyle = BorderStyle.FixedSingle;
            txt_Datum.Font = new Font ("Courier New", 9F);
            txt_Datum.Location = new Point (258, 222);
            txt_Datum.Mask = "0000.00.00";
            txt_Datum.Name = "txt_Datum";
            txt_Datum.Size = new Size (102, 21);
            txt_Datum.TabIndex = 4;
            txt_Datum.TextAlign = HorizontalAlignment.Center;
            // 
            // txt_Amount
            // 
            txt_Amount.BackColor = Color.WhiteSmoke;
            txt_Amount.BorderStyle = BorderStyle.FixedSingle;
            txt_Amount.Font = new Font ("Segoe UI", 14F);
            txt_Amount.Location = new Point (341, 435);
            txt_Amount.Name = "txt_Amount";
            txt_Amount.Size = new Size (141, 32);
            txt_Amount.TabIndex = 0;
            txt_Amount.Text = "0";
            txt_Amount.TextAlign = HorizontalAlignment.Center;
            txt_Amount.KeyDown += txt_Amount_KeyDown;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font ("Segoe UI", 11F);
            label4.Location = new Point (527, 437);
            label4.Name = "label4";
            label4.Size = new Size (37, 20);
            label4.TabIndex = 7;
            label4.Text = "مبلغ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font ("Segoe UI", 11F);
            label5.Location = new Point (519, 486);
            label5.Name = "label5";
            label5.Size = new Size (45, 20);
            label5.TabIndex = 9;
            label5.Text = "عنوان";
            // 
            // txt_Subject
            // 
            txt_Subject.BackColor = Color.WhiteSmoke;
            txt_Subject.BorderStyle = BorderStyle.FixedSingle;
            txt_Subject.Font = new Font ("Segoe UI", 11F);
            txt_Subject.Location = new Point (122, 484);
            txt_Subject.Name = "txt_Subject";
            txt_Subject.RightToLeft = RightToLeft.Yes;
            txt_Subject.Size = new Size (360, 27);
            txt_Subject.TabIndex = 1;
            txt_Subject.KeyDown += txt_Subject_KeyDown;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font ("Segoe UI", 11F);
            label6.Location = new Point (495, 529);
            label6.Name = "label6";
            label6.Size = new Size (69, 20);
            label6.TabIndex = 11;
            label6.Text = "توضيحات";
            // 
            // txt_Note
            // 
            txt_Note.BackColor = Color.WhiteSmoke;
            txt_Note.BorderStyle = BorderStyle.FixedSingle;
            txt_Note.Font = new Font ("Segoe UI", 11F);
            txt_Note.Location = new Point (122, 527);
            txt_Note.Name = "txt_Note";
            txt_Note.RightToLeft = RightToLeft.Yes;
            txt_Note.Size = new Size (360, 27);
            txt_Note.TabIndex = 2;
            txt_Note.Text = "-";
            txt_Note.KeyDown += txt_Note_KeyDown;
            // 
            // chk_Done
            // 
            chk_Done.AutoSize = true;
            chk_Done.Checked = true;
            chk_Done.CheckState = CheckState.Checked;
            chk_Done.Font = new Font ("Segoe UI", 11F);
            chk_Done.Location = new Point (242, 571);
            chk_Done.Name = "chk_Done";
            chk_Done.RightToLeft = RightToLeft.Yes;
            chk_Done.Size = new Size (141, 24);
            chk_Done.TabIndex = 12;
            chk_Done.Text = "تراکنش انجام شده";
            chk_Done.UseVisualStyleBackColor = true;
            // 
            // lbl_Cats
            // 
            lbl_Cats.AutoSize = true;
            lbl_Cats.Font = new Font ("Segoe UI", 11F);
            lbl_Cats.Location = new Point (509, 74);
            lbl_Cats.Name = "lbl_Cats";
            lbl_Cats.Size = new Size (49, 20);
            lbl_Cats.TabIndex = 14;
            lbl_Cats.Text = "حساب";
            // 
            // cbo_Cats
            // 
            cbo_Cats.BackColor = Color.White;
            cbo_Cats.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo_Cats.FlatStyle = FlatStyle.Flat;
            cbo_Cats.Font = new Font ("Segoe UI", 11F);
            cbo_Cats.FormattingEnabled = true;
            cbo_Cats.Location = new Point (122, 71);
            cbo_Cats.Name = "cbo_Cats";
            cbo_Cats.RightToLeft = RightToLeft.Yes;
            cbo_Cats.Size = new Size (360, 28);
            cbo_Cats.TabIndex = 13;
            cbo_Cats.SelectedIndexChanged += cbo_Cats_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add (lbl_Cancel);
            panel1.Controls.Add (lbl_Save);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point (0, 642);
            panel1.Name = "panel1";
            panel1.Size = new Size (613, 22);
            panel1.TabIndex = 15;
            // 
            // lbl_Cancel
            // 
            lbl_Cancel.BackColor = Color.WhiteSmoke;
            lbl_Cancel.Dock = DockStyle.Left;
            lbl_Cancel.Font = new Font ("Segoe UI", 11F);
            lbl_Cancel.ForeColor = Color.IndianRed;
            lbl_Cancel.Location = new Point (0, 0);
            lbl_Cancel.Name = "lbl_Cancel";
            lbl_Cancel.Size = new Size (155, 22);
            lbl_Cancel.TabIndex = 17;
            lbl_Cancel.Text = "انصراف";
            lbl_Cancel.TextAlign = ContentAlignment.MiddleCenter;
            lbl_Cancel.Click += lbl_Cancel_Click;
            // 
            // lbl_Save
            // 
            lbl_Save.BackColor = Color.CornflowerBlue;
            lbl_Save.Dock = DockStyle.Right;
            lbl_Save.Font = new Font ("Segoe UI", 11F);
            lbl_Save.ForeColor = Color.White;
            lbl_Save.Location = new Point (161, 0);
            lbl_Save.Name = "lbl_Save";
            lbl_Save.Size = new Size (452, 22);
            lbl_Save.TabIndex = 16;
            lbl_Save.Text = "ذخيره";
            lbl_Save.TextAlign = ContentAlignment.MiddleCenter;
            lbl_Save.Click += lbl_Save_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add (cbo_Cats);
            panel2.Controls.Add (cbo_Periods);
            panel2.Controls.Add (lbl_Cats);
            panel2.Controls.Add (lbl_Periods);
            panel2.Controls.Add (cbo_Units);
            panel2.Controls.Add (lbl_Units);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point (0, 60);
            panel2.Name = "panel2";
            panel2.Size = new Size (613, 128);
            panel2.TabIndex = 16;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add (opt_Exp);
            panel3.Controls.Add (opt_Pay);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point (0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size (613, 60);
            panel3.TabIndex = 17;
            // 
            // opt_Exp
            // 
            opt_Exp.AutoSize = true;
            opt_Exp.Checked = true;
            opt_Exp.Font = new Font ("Segoe UI", 11F);
            opt_Exp.Location = new Point (361, 16);
            opt_Exp.Name = "opt_Exp";
            opt_Exp.RightToLeft = RightToLeft.Yes;
            opt_Exp.Size = new Size (90, 24);
            opt_Exp.TabIndex = 1;
            opt_Exp.TabStop = true;
            opt_Exp.Text = "ثبت هزينه";
            opt_Exp.UseVisualStyleBackColor = true;
            opt_Exp.CheckedChanged += opt_Exp_CheckedChanged;
            // 
            // opt_Pay
            // 
            opt_Pay.AutoSize = true;
            opt_Pay.Font = new Font ("Segoe UI", 11F);
            opt_Pay.Location = new Point (157, 16);
            opt_Pay.Name = "opt_Pay";
            opt_Pay.RightToLeft = RightToLeft.Yes;
            opt_Pay.Size = new Size (147, 24);
            opt_Pay.TabIndex = 0;
            opt_Pay.Text = "ثبت پرداخت واحدها";
            opt_Pay.UseVisualStyleBackColor = true;
            // 
            // mntCal
            // 
            mntCal.Location = new Point (122, 248);
            mntCal.Name = "mntCal";
            mntCal.TabIndex = 18;
            mntCal.DateSelected += mntCal_DateSelected;
            // 
            // lbl_Status
            // 
            lbl_Status.ForeColor = Color.IndianRed;
            lbl_Status.Location = new Point (12, 610);
            lbl_Status.Name = "lbl_Status";
            lbl_Status.Size = new Size (589, 24);
            lbl_Status.TabIndex = 19;
            lbl_Status.Text = "-";
            lbl_Status.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmTransaction
            // 
            AutoScaleDimensions = new SizeF (7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size (613, 664);
            ControlBox = false;
            Controls.Add (lbl_Status);
            Controls.Add (mntCal);
            Controls.Add (panel1);
            Controls.Add (chk_Done);
            Controls.Add (label6);
            Controls.Add (txt_Note);
            Controls.Add (label5);
            Controls.Add (txt_Subject);
            Controls.Add (label4);
            Controls.Add (txt_Amount);
            Controls.Add (txt_Datum);
            Controls.Add (panel2);
            Controls.Add (panel3);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmTransaction";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ثبت";
            Load += frmTransaction_Load;
            panel1.ResumeLayout (false);
            panel2.ResumeLayout (false);
            panel2.PerformLayout ();
            panel3.ResumeLayout (false);
            panel3.PerformLayout ();
            ResumeLayout (false);
            PerformLayout ();
            }

        #endregion

        private ComboBox cbo_Periods;
        private Label lbl_Periods;
        private Label lbl_Units;
        private ComboBox cbo_Units;
        private MaskedTextBox txt_Datum;
        private TextBox txt_Amount;
        private Label label4;
        private Label label5;
        private TextBox txt_Subject;
        private Label label6;
        private TextBox txt_Note;
        private CheckBox chk_Done;
        private Label lbl_Cats;
        private ComboBox cbo_Cats;
        private Panel panel1;
        private Label lbl_Save;
        private Label lbl_Cancel;
        private Panel panel2;
        private Panel panel3;
        private RadioButton opt_Exp;
        private RadioButton opt_Pay;
        private MonthCalendar mntCal;
        private Label lbl_Status;
        }
    }
