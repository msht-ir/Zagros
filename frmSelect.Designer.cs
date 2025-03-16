namespace ZagrosDesktop
    {
    partial class frmSelect
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle ();
            Grid_Select = new DataGridView ();
            panel1 = new Panel ();
            lbl_Cancel = new Label ();
            lbl_Select = new Label ();
            ((System.ComponentModel.ISupportInitialize) Grid_Select).BeginInit ();
            panel1.SuspendLayout ();
            SuspendLayout ();
            // 
            // Grid_Select
            // 
            Grid_Select.AllowUserToAddRows = false;
            Grid_Select.AllowUserToDeleteRows = false;
            Grid_Select.AllowUserToResizeColumns = false;
            Grid_Select.AllowUserToResizeRows = false;
            Grid_Select.BackgroundColor = Color.WhiteSmoke;
            Grid_Select.BorderStyle = BorderStyle.None;
            Grid_Select.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new Font ("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionForeColor = Color.IndianRed;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            Grid_Select.DefaultCellStyle = dataGridViewCellStyle1;
            Grid_Select.EditMode = DataGridViewEditMode.EditProgrammatically;
            Grid_Select.GridColor = Color.WhiteSmoke;
            Grid_Select.Location = new Point (12, 6);
            Grid_Select.Name = "Grid_Select";
            Grid_Select.RightToLeft = RightToLeft.Yes;
            Grid_Select.RowHeadersVisible = false;
            Grid_Select.ScrollBars = ScrollBars.Vertical;
            Grid_Select.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Grid_Select.Size = new Size (531, 606);
            Grid_Select.TabIndex = 31;
            Grid_Select.CellDoubleClick += Grid_Select_CellDoubleClick;
            // 
            // panel1
            // 
            panel1.Controls.Add (lbl_Cancel);
            panel1.Controls.Add (lbl_Select);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point (0, 647);
            panel1.Name = "panel1";
            panel1.Size = new Size (555, 22);
            panel1.TabIndex = 38;
            // 
            // lbl_Cancel
            // 
            lbl_Cancel.BackColor = Color.WhiteSmoke;
            lbl_Cancel.Dock = DockStyle.Left;
            lbl_Cancel.Font = new Font ("Segoe UI", 11F);
            lbl_Cancel.ForeColor = Color.IndianRed;
            lbl_Cancel.Location = new Point (0, 0);
            lbl_Cancel.Name = "lbl_Cancel";
            lbl_Cancel.Size = new Size (128, 22);
            lbl_Cancel.TabIndex = 17;
            lbl_Cancel.Text = "انصراف";
            lbl_Cancel.TextAlign = ContentAlignment.MiddleCenter;
            lbl_Cancel.Click += lbl_Cancel_Click;
            // 
            // lbl_Select
            // 
            lbl_Select.BackColor = Color.DarkSeaGreen;
            lbl_Select.Dock = DockStyle.Right;
            lbl_Select.Font = new Font ("Segoe UI", 11F);
            lbl_Select.ForeColor = Color.White;
            lbl_Select.Location = new Point (143, 0);
            lbl_Select.Name = "lbl_Select";
            lbl_Select.Size = new Size (412, 22);
            lbl_Select.TabIndex = 16;
            lbl_Select.Text = "اتتخاب";
            lbl_Select.TextAlign = ContentAlignment.MiddleCenter;
            lbl_Select.Click += lbl_Select_Click;
            // 
            // frmSelect
            // 
            AutoScaleDimensions = new SizeF (7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size (555, 669);
            ControlBox = false;
            Controls.Add (panel1);
            Controls.Add (Grid_Select);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmSelect";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "انتخاب";
            Load += frmSelect_Load;
            ((System.ComponentModel.ISupportInitialize) Grid_Select).EndInit ();
            panel1.ResumeLayout (false);
            ResumeLayout (false);
            }

        #endregion
        private DataGridView Grid_Select;
        private Panel panel1;
        private Label lbl_Cancel;
        private Label lbl_Select;
        }
    }