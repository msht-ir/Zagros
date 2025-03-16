namespace ZagrosDesktop
    {
    partial class frmPeriodEdit
        {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ()
            {
            lbl_Cancel = new Label ();
            lbl_Save = new Label ();
            panel1 = new Panel ();
            lbl_DatumCounter = new Label ();
            txt_DatumCounter = new MaskedTextBox ();
            lbl_DatumTo = new Label ();
            txt_DatumTo = new MaskedTextBox ();
            txt_Title = new TextBox ();
            label1 = new Label ();
            chk_Active = new CheckBox ();
            label6 = new Label ();
            txt_Note = new TextBox ();
            txt_BookKeeper = new TextBox ();
            lbl_DatumFrom = new Label ();
            txt_DatumFrom = new MaskedTextBox ();
            label5 = new Label ();
            panel1.SuspendLayout ();
            SuspendLayout ();
            // 
            // lbl_Cancel
            // 
            lbl_Cancel.BackColor = Color.WhiteSmoke;
            lbl_Cancel.Dock = DockStyle.Left;
            lbl_Cancel.Font = new Font ("Segoe UI", 11F);
            lbl_Cancel.ForeColor = Color.IndianRed;
            lbl_Cancel.Location = new Point (0, 0);
            lbl_Cancel.Name = "lbl_Cancel";
            lbl_Cancel.Size = new Size (169, 22);
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
            lbl_Save.Location = new Point (186, 0);
            lbl_Save.Name = "lbl_Save";
            lbl_Save.Size = new Size (505, 22);
            lbl_Save.TabIndex = 16;
            lbl_Save.Text = "تاييد";
            lbl_Save.TextAlign = ContentAlignment.MiddleCenter;
            lbl_Save.Click += lbl_Save_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add (lbl_Cancel);
            panel1.Controls.Add (lbl_Save);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point (0, 266);
            panel1.Name = "panel1";
            panel1.Size = new Size (691, 22);
            panel1.TabIndex = 27;
            // 
            // lbl_DatumCounter
            // 
            lbl_DatumCounter.AutoSize = true;
            lbl_DatumCounter.Font = new Font ("Segoe UI", 11F);
            lbl_DatumCounter.Location = new Point (190, 114);
            lbl_DatumCounter.Name = "lbl_DatumCounter";
            lbl_DatumCounter.Size = new Size (81, 20);
            lbl_DatumCounter.TabIndex = 59;
            lbl_DatumCounter.Text = "قرائت کنتور";
            lbl_DatumCounter.Click += lbl_DatumCounter_Click;
            // 
            // txt_DatumCounter
            // 
            txt_DatumCounter.BackColor = Color.WhiteSmoke;
            txt_DatumCounter.BorderStyle = BorderStyle.FixedSingle;
            txt_DatumCounter.Font = new Font ("Courier New", 11F);
            txt_DatumCounter.Location = new Point (63, 115);
            txt_DatumCounter.Mask = "0000.00.00";
            txt_DatumCounter.Name = "txt_DatumCounter";
            txt_DatumCounter.Size = new Size (121, 24);
            txt_DatumCounter.TabIndex = 4;
            txt_DatumCounter.TextAlign = HorizontalAlignment.Center;
            txt_DatumCounter.KeyDown += txt_DatumCounter_KeyDown;
            // 
            // lbl_DatumTo
            // 
            lbl_DatumTo.AutoSize = true;
            lbl_DatumTo.Font = new Font ("Segoe UI", 11F);
            lbl_DatumTo.Location = new Point (190, 74);
            lbl_DatumTo.Name = "lbl_DatumTo";
            lbl_DatumTo.Size = new Size (18, 20);
            lbl_DatumTo.TabIndex = 57;
            lbl_DatumTo.Text = "تا";
            lbl_DatumTo.Click += lbl_DatumTo_Click;
            // 
            // txt_DatumTo
            // 
            txt_DatumTo.BackColor = Color.WhiteSmoke;
            txt_DatumTo.BorderStyle = BorderStyle.FixedSingle;
            txt_DatumTo.Font = new Font ("Courier New", 11F);
            txt_DatumTo.Location = new Point (63, 75);
            txt_DatumTo.Mask = "0000.00.00";
            txt_DatumTo.Name = "txt_DatumTo";
            txt_DatumTo.Size = new Size (121, 24);
            txt_DatumTo.TabIndex = 3;
            txt_DatumTo.TextAlign = HorizontalAlignment.Center;
            txt_DatumTo.KeyDown += txt_DatumTo_KeyDown;
            // 
            // txt_Title
            // 
            txt_Title.BackColor = Color.WhiteSmoke;
            txt_Title.BorderStyle = BorderStyle.FixedSingle;
            txt_Title.Font = new Font ("Segoe UI", 11F);
            txt_Title.Location = new Point (420, 33);
            txt_Title.Name = "txt_Title";
            txt_Title.Size = new Size (149, 27);
            txt_Title.TabIndex = 0;
            txt_Title.TextAlign = HorizontalAlignment.Center;
            txt_Title.KeyDown += txt_Title_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font ("Segoe UI", 11F);
            label1.Location = new Point (573, 35);
            label1.Name = "label1";
            label1.Size = new Size (60, 20);
            label1.TabIndex = 55;
            label1.Text = "نام دوره";
            // 
            // chk_Active
            // 
            chk_Active.AutoSize = true;
            chk_Active.Checked = true;
            chk_Active.CheckState = CheckState.Checked;
            chk_Active.Font = new Font ("Segoe UI", 11F);
            chk_Active.Location = new Point (310, 217);
            chk_Active.Name = "chk_Active";
            chk_Active.RightToLeft = RightToLeft.Yes;
            chk_Active.Size = new Size (59, 24);
            chk_Active.TabIndex = 6;
            chk_Active.Text = "فعال";
            chk_Active.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font ("Segoe UI", 11F);
            label6.Location = new Point (575, 166);
            label6.Name = "label6";
            label6.Size = new Size (69, 20);
            label6.TabIndex = 52;
            label6.Text = "توضيحات";
            // 
            // txt_Note
            // 
            txt_Note.BackColor = Color.WhiteSmoke;
            txt_Note.BorderStyle = BorderStyle.FixedSingle;
            txt_Note.Font = new Font ("Segoe UI", 11F);
            txt_Note.Location = new Point (63, 164);
            txt_Note.Name = "txt_Note";
            txt_Note.RightToLeft = RightToLeft.Yes;
            txt_Note.Size = new Size (506, 27);
            txt_Note.TabIndex = 5;
            txt_Note.Text = "-";
            // 
            // txt_BookKeeper
            // 
            txt_BookKeeper.BackColor = Color.WhiteSmoke;
            txt_BookKeeper.BorderStyle = BorderStyle.FixedSingle;
            txt_BookKeeper.Font = new Font ("Segoe UI", 11F);
            txt_BookKeeper.Location = new Point (420, 72);
            txt_BookKeeper.Name = "txt_BookKeeper";
            txt_BookKeeper.RightToLeft = RightToLeft.Yes;
            txt_BookKeeper.Size = new Size (149, 27);
            txt_BookKeeper.TabIndex = 1;
            txt_BookKeeper.KeyDown += txt_BookKeeper_KeyDown;
            // 
            // lbl_DatumFrom
            // 
            lbl_DatumFrom.AutoSize = true;
            lbl_DatumFrom.Font = new Font ("Segoe UI", 11F);
            lbl_DatumFrom.Location = new Point (190, 35);
            lbl_DatumFrom.Name = "lbl_DatumFrom";
            lbl_DatumFrom.Size = new Size (53, 20);
            lbl_DatumFrom.TabIndex = 48;
            lbl_DatumFrom.Text = "از تاريخ";
            lbl_DatumFrom.Click += lbl_DatumFrom_Click;
            // 
            // txt_DatumFrom
            // 
            txt_DatumFrom.BackColor = Color.WhiteSmoke;
            txt_DatumFrom.BorderStyle = BorderStyle.FixedSingle;
            txt_DatumFrom.Font = new Font ("Courier New", 11F);
            txt_DatumFrom.Location = new Point (63, 36);
            txt_DatumFrom.Mask = "0000.00.00";
            txt_DatumFrom.Name = "txt_DatumFrom";
            txt_DatumFrom.Size = new Size (121, 24);
            txt_DatumFrom.TabIndex = 2;
            txt_DatumFrom.TextAlign = HorizontalAlignment.Center;
            txt_DatumFrom.KeyDown += txt_DatumFrom_KeyDown;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font ("Segoe UI", 11F);
            label5.Location = new Point (575, 74);
            label5.Name = "label5";
            label5.Size = new Size (58, 20);
            label5.TabIndex = 50;
            label5.Text = "حسابدار";
            // 
            // frmPeriodEdit
            // 
            AutoScaleDimensions = new SizeF (7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size (691, 288);
            ControlBox = false;
            Controls.Add (lbl_DatumCounter);
            Controls.Add (txt_DatumCounter);
            Controls.Add (lbl_DatumTo);
            Controls.Add (txt_DatumTo);
            Controls.Add (txt_Title);
            Controls.Add (label1);
            Controls.Add (chk_Active);
            Controls.Add (label6);
            Controls.Add (txt_Note);
            Controls.Add (txt_BookKeeper);
            Controls.Add (lbl_DatumFrom);
            Controls.Add (txt_DatumFrom);
            Controls.Add (label5);
            Controls.Add (panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmPeriodEdit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmPeriodEdit";
            Load += frmPeriodEdit_Load;
            panel1.ResumeLayout (false);
            ResumeLayout (false);
            PerformLayout ();
            }

        #endregion

        private Label lbl_Cancel;
        private Label lbl_Save;
        private Panel panel1;
        private Label lbl_DatumCounter;
        private MaskedTextBox txt_DatumCounter;
        private Label lbl_DatumTo;
        private MaskedTextBox txt_DatumTo;
        private TextBox txt_Title;
        private Label label1;
        private CheckBox chk_Active;
        private Label label6;
        private TextBox txt_Note;
        private TextBox txt_BookKeeper;
        private Label lbl_DatumFrom;
        private MaskedTextBox txt_DatumFrom;
        private Label label5;
        }
    }