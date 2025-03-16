namespace ZagrosDesktop
    {
    partial class frmSettings
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
            lbl_Status = new Label ();
            panel1 = new Panel ();
            lbl_Cancel = new Label ();
            lbl_Save = new Label ();
            label5 = new Label ();
            txt_cnnString = new TextBox ();
            btn_ClearDatabase = new Button ();
            label1 = new Label ();
            txt_Residential = new TextBox ();
            panel1.SuspendLayout ();
            SuspendLayout ();
            // 
            // lbl_Status
            // 
            lbl_Status.ForeColor = Color.IndianRed;
            lbl_Status.Location = new Point (12, 401);
            lbl_Status.Name = "lbl_Status";
            lbl_Status.Size = new Size (589, 24);
            lbl_Status.TabIndex = 28;
            lbl_Status.Text = "-";
            lbl_Status.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add (lbl_Cancel);
            panel1.Controls.Add (lbl_Save);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point (0, 189);
            panel1.Name = "panel1";
            panel1.Size = new Size (833, 22);
            panel1.TabIndex = 27;
            // 
            // lbl_Cancel
            // 
            lbl_Cancel.BackColor = Color.WhiteSmoke;
            lbl_Cancel.Dock = DockStyle.Left;
            lbl_Cancel.Font = new Font ("Segoe UI", 11F);
            lbl_Cancel.ForeColor = Color.IndianRed;
            lbl_Cancel.Location = new Point (0, 0);
            lbl_Cancel.Name = "lbl_Cancel";
            lbl_Cancel.Size = new Size (177, 22);
            lbl_Cancel.TabIndex = 17;
            lbl_Cancel.Text = "بازگشت";
            lbl_Cancel.TextAlign = ContentAlignment.MiddleCenter;
            lbl_Cancel.Click += lbl_Cancel_Click;
            // 
            // lbl_Save
            // 
            lbl_Save.BackColor = Color.CornflowerBlue;
            lbl_Save.Dock = DockStyle.Right;
            lbl_Save.Font = new Font ("Segoe UI", 11F);
            lbl_Save.ForeColor = Color.White;
            lbl_Save.Location = new Point (202, 0);
            lbl_Save.Name = "lbl_Save";
            lbl_Save.Size = new Size (631, 22);
            lbl_Save.TabIndex = 16;
            lbl_Save.Text = "ذخيره";
            lbl_Save.TextAlign = ContentAlignment.MiddleCenter;
            lbl_Save.Click += lbl_Save_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font ("Segoe UI", 11F);
            label5.Location = new Point (700, 18);
            label5.Name = "label5";
            label5.Size = new Size (121, 20);
            label5.TabIndex = 24;
            label5.Text = "کد اتصال ديتابيس";
            // 
            // txt_cnnString
            // 
            txt_cnnString.BackColor = Color.WhiteSmoke;
            txt_cnnString.BorderStyle = BorderStyle.FixedSingle;
            txt_cnnString.Font = new Font ("Segoe UI", 11F);
            txt_cnnString.Location = new Point (12, 43);
            txt_cnnString.Name = "txt_cnnString";
            txt_cnnString.Size = new Size (809, 27);
            txt_cnnString.TabIndex = 21;
            // 
            // btn_ClearDatabase
            // 
            btn_ClearDatabase.BackColor = Color.LightCoral;
            btn_ClearDatabase.FlatStyle = FlatStyle.Flat;
            btn_ClearDatabase.ForeColor = Color.White;
            btn_ClearDatabase.Location = new Point (12, 116);
            btn_ClearDatabase.Name = "btn_ClearDatabase";
            btn_ClearDatabase.Size = new Size (147, 28);
            btn_ClearDatabase.TabIndex = 31;
            btn_ClearDatabase.Text = "پاک کردن ديتابيس";
            btn_ClearDatabase.UseVisualStyleBackColor = false;
            btn_ClearDatabase.Click += btn_ClearDatabase_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font ("Segoe UI", 11F);
            label1.Location = new Point (689, 91);
            label1.Name = "label1";
            label1.Size = new Size (132, 20);
            label1.TabIndex = 33;
            label1.Text = "نام مجتمع مسکوني";
            // 
            // txt_Residential
            // 
            txt_Residential.BackColor = Color.WhiteSmoke;
            txt_Residential.BorderStyle = BorderStyle.FixedSingle;
            txt_Residential.Font = new Font ("Segoe UI", 11F);
            txt_Residential.Location = new Point (444, 116);
            txt_Residential.Name = "txt_Residential";
            txt_Residential.RightToLeft = RightToLeft.Yes;
            txt_Residential.Size = new Size (377, 27);
            txt_Residential.TabIndex = 32;
            // 
            // frmSettings
            // 
            AutoScaleDimensions = new SizeF (7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size (833, 211);
            ControlBox = false;
            Controls.Add (label1);
            Controls.Add (txt_Residential);
            Controls.Add (btn_ClearDatabase);
            Controls.Add (lbl_Status);
            Controls.Add (panel1);
            Controls.Add (label5);
            Controls.Add (txt_cnnString);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmSettings";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "تنظيمات";
            Load += frmSettings_Load;
            panel1.ResumeLayout (false);
            ResumeLayout (false);
            PerformLayout ();
            }

        #endregion

        private Label lbl_Status;
        private Panel panel1;
        private Label lbl_Cancel;
        private Label lbl_Save;
        private Label label5;
        private TextBox txt_cnnString;
        private Button btn_ClearDatabase;
        private Label label1;
        private TextBox txt_Residential;
        }
    }