namespace ZagrosDesktop
    {
    partial class frmTimeAndDate
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
            MC = new MonthCalendar ();
            txtDateTime = new MaskedTextBox ();
            panel1 = new Panel ();
            lblSelect = new Label ();
            lblCancel = new Label ();
            panel1.SuspendLayout ();
            SuspendLayout ();
            // 
            // MC
            // 
            MC.CalendarDimensions = new Size (2, 2);
            MC.Location = new Point (18, 18);
            MC.MaxDate = new DateTime (2171, 7, 6, 0, 0, 0, 0);
            MC.MinDate = new DateTime (1971, 3, 21, 0, 0, 0, 0);
            MC.Name = "MC";
            MC.ShowTodayCircle = false;
            MC.TabIndex = 5;
            MC.TrailingForeColor = Color.IndianRed;
            MC.DateSelected += MC_DateSelected;
            // 
            // txtDateTime
            // 
            txtDateTime.BackColor = Color.FromArgb (  253,   253,   253);
            txtDateTime.BorderStyle = BorderStyle.None;
            txtDateTime.Font = new Font ("Consolas", 18F);
            txtDateTime.ForeColor = Color.IndianRed;
            txtDateTime.Location = new Point (232, 339);
            txtDateTime.Mask = "0000.00.00";
            txtDateTime.Name = "txtDateTime";
            txtDateTime.Size = new Size (275, 29);
            txtDateTime.TabIndex = 0;
            txtDateTime.TextAlign = HorizontalAlignment.Center;
            // 
            // panel1
            // 
            panel1.Controls.Add (lblSelect);
            panel1.Controls.Add (lblCancel);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point (0, 408);
            panel1.Name = "panel1";
            panel1.Size = new Size (758, 20);
            panel1.TabIndex = 117;
            // 
            // lblSelect
            // 
            lblSelect.BackColor = Color.DarkSeaGreen;
            lblSelect.Dock = DockStyle.Right;
            lblSelect.Font = new Font ("Segoe UI", 10F);
            lblSelect.ForeColor = Color.White;
            lblSelect.Location = new Point (232, 0);
            lblSelect.Name = "lblSelect";
            lblSelect.Size = new Size (526, 20);
            lblSelect.TabIndex = 23;
            lblSelect.Text = "انتخاب";
            lblSelect.TextAlign = ContentAlignment.MiddleCenter;
            lblSelect.Click += lblSelect_Click;
            // 
            // lblCancel
            // 
            lblCancel.BackColor = Color.WhiteSmoke;
            lblCancel.Dock = DockStyle.Left;
            lblCancel.Font = new Font ("Segoe UI", 10F);
            lblCancel.ForeColor = Color.IndianRed;
            lblCancel.Location = new Point (0, 0);
            lblCancel.Name = "lblCancel";
            lblCancel.Size = new Size (204, 20);
            lblCancel.TabIndex = 22;
            lblCancel.Text = "انصراف";
            lblCancel.TextAlign = ContentAlignment.MiddleCenter;
            lblCancel.Click += lblCancel_Click;
            // 
            // frmTimeAndDate
            // 
            AutoScaleDimensions = new SizeF (7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb (  253,   253,   253);
            ClientSize = new Size (758, 428);
            ControlBox = false;
            Controls.Add (panel1);
            Controls.Add (txtDateTime);
            Controls.Add (MC);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmTimeAndDate";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "انتخاب تاريخ";
            Load += frmTimeAndDate_Load;
            panel1.ResumeLayout (false);
            ResumeLayout (false);
            PerformLayout ();
            }

        #endregion

        private System.Windows.Forms.MonthCalendar MC;
        internal System.Windows.Forms.MaskedTextBox txtDateTime;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSelect;
        private System.Windows.Forms.Label lblCancel;
        }
    }