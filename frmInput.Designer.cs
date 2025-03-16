namespace ZagrosDesktop
    {
    partial class frmInput
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
            panel1 = new Panel ();
            lbl_Cancel = new Label ();
            lbl_OK = new Label ();
            lbl_Message = new Label ();
            txt_Input = new TextBox ();
            panel1.SuspendLayout ();
            SuspendLayout ();
            // 
            // panel1
            // 
            panel1.Controls.Add (lbl_Cancel);
            panel1.Controls.Add (lbl_OK);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point (0, 142);
            panel1.Name = "panel1";
            panel1.Size = new Size (704, 22);
            panel1.TabIndex = 28;
            // 
            // lbl_Cancel
            // 
            lbl_Cancel.BackColor = Color.WhiteSmoke;
            lbl_Cancel.Dock = DockStyle.Left;
            lbl_Cancel.Font = new Font ("Segoe UI", 11F);
            lbl_Cancel.ForeColor = Color.IndianRed;
            lbl_Cancel.Location = new Point (0, 0);
            lbl_Cancel.Name = "lbl_Cancel";
            lbl_Cancel.Size = new Size (140, 22);
            lbl_Cancel.TabIndex = 17;
            lbl_Cancel.Text = "انصراف";
            lbl_Cancel.TextAlign = ContentAlignment.MiddleCenter;
            lbl_Cancel.Click += lbl_Cancel_Click;
            // 
            // lbl_OK
            // 
            lbl_OK.BackColor = Color.CornflowerBlue;
            lbl_OK.Dock = DockStyle.Right;
            lbl_OK.Font = new Font ("Segoe UI", 11F);
            lbl_OK.ForeColor = Color.White;
            lbl_OK.Location = new Point (564, 0);
            lbl_OK.Name = "lbl_OK";
            lbl_OK.Size = new Size (140, 22);
            lbl_OK.TabIndex = 16;
            lbl_OK.Text = "تاييد";
            lbl_OK.TextAlign = ContentAlignment.MiddleCenter;
            lbl_OK.Click += lbl_OK_Click;
            // 
            // lbl_Message
            // 
            lbl_Message.Font = new Font ("Segoe UI", 11F);
            lbl_Message.Location = new Point (12, 26);
            lbl_Message.Name = "lbl_Message";
            lbl_Message.Size = new Size (680, 20);
            lbl_Message.TabIndex = 54;
            lbl_Message.Text = "توضيحات";
            lbl_Message.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txt_Input
            // 
            txt_Input.BackColor = Color.WhiteSmoke;
            txt_Input.BorderStyle = BorderStyle.FixedSingle;
            txt_Input.Font = new Font ("Segoe UI", 11F);
            txt_Input.Location = new Point (69, 60);
            txt_Input.Name = "txt_Input";
            txt_Input.RightToLeft = RightToLeft.Yes;
            txt_Input.Size = new Size (560, 27);
            txt_Input.TabIndex = 53;
            txt_Input.Text = "-";
            txt_Input.TextAlign = HorizontalAlignment.Center;
            txt_Input.KeyDown += txt_Input_KeyDown;
            // 
            // frmInput
            // 
            AutoScaleDimensions = new SizeF (7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size (704, 164);
            ControlBox = false;
            Controls.Add (lbl_Message);
            Controls.Add (txt_Input);
            Controls.Add (panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmInput";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmInput";
            Load += frmInput_Load;
            panel1.ResumeLayout (false);
            ResumeLayout (false);
            PerformLayout ();
            }

        #endregion

        private Panel panel1;
        private Label lbl_Cancel;
        private Label lbl_OK;
        private Label lbl_Message;
        private TextBox txt_Input;
        }
    }