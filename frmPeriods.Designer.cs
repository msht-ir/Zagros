namespace ZagrosDesktop
    {
    partial class frmPeriods
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle ();
            Grid_Periods = new DataGridView ();
            Grid_Data = new DataGridView ();
            panel1 = new Panel ();
            lbl_Exit = new Label ();
            btn_NewPeriod = new Button ();
            btn_EditPeriod = new Button ();
            btn_CalculateCharge = new Button ();
            btn_AddUnit2List = new Button ();
            btn_RemoveUnitFromList = new Button ();
            btn_Note4All = new Button ();
            btn_EditGridDataItem = new Button ();
            btn_AddChargeToAccs = new Button ();
            ((System.ComponentModel.ISupportInitialize) Grid_Periods).BeginInit ();
            ((System.ComponentModel.ISupportInitialize) Grid_Data).BeginInit ();
            panel1.SuspendLayout ();
            SuspendLayout ();
            // 
            // Grid_Periods
            // 
            Grid_Periods.AllowUserToAddRows = false;
            Grid_Periods.AllowUserToDeleteRows = false;
            Grid_Periods.AllowUserToResizeColumns = false;
            Grid_Periods.AllowUserToResizeRows = false;
            Grid_Periods.BackgroundColor = Color.WhiteSmoke;
            Grid_Periods.BorderStyle = BorderStyle.None;
            Grid_Periods.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new Font ("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb (  236,   236,   236);
            dataGridViewCellStyle1.SelectionForeColor = Color.IndianRed;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            Grid_Periods.DefaultCellStyle = dataGridViewCellStyle1;
            Grid_Periods.EditMode = DataGridViewEditMode.EditProgrammatically;
            Grid_Periods.GridColor = Color.WhiteSmoke;
            Grid_Periods.Location = new Point (12, 22);
            Grid_Periods.Name = "Grid_Periods";
            Grid_Periods.RightToLeft = RightToLeft.Yes;
            Grid_Periods.RowHeadersVisible = false;
            Grid_Periods.ScrollBars = ScrollBars.Vertical;
            Grid_Periods.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Grid_Periods.Size = new Size (1270, 248);
            Grid_Periods.TabIndex = 0;
            Grid_Periods.CellClick += Grid_Periods_CellClick;
            Grid_Periods.CellDoubleClick += Grid_Periods_CellDoubleClick;
            // 
            // Grid_Data
            // 
            Grid_Data.AllowUserToAddRows = false;
            Grid_Data.AllowUserToDeleteRows = false;
            Grid_Data.AllowUserToOrderColumns = true;
            Grid_Data.AllowUserToResizeColumns = false;
            Grid_Data.AllowUserToResizeRows = false;
            Grid_Data.BackgroundColor = Color.WhiteSmoke;
            Grid_Data.BorderStyle = BorderStyle.None;
            Grid_Data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new Font ("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb (  236,   236,   236);
            dataGridViewCellStyle2.SelectionForeColor = Color.IndianRed;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            Grid_Data.DefaultCellStyle = dataGridViewCellStyle2;
            Grid_Data.EditMode = DataGridViewEditMode.EditProgrammatically;
            Grid_Data.GridColor = Color.WhiteSmoke;
            Grid_Data.Location = new Point (12, 323);
            Grid_Data.Name = "Grid_Data";
            Grid_Data.RightToLeft = RightToLeft.Yes;
            Grid_Data.RowHeadersVisible = false;
            Grid_Data.ScrollBars = ScrollBars.Vertical;
            Grid_Data.SelectionMode = DataGridViewSelectionMode.CellSelect;
            Grid_Data.Size = new Size (1270, 335);
            Grid_Data.TabIndex = 1;
            Grid_Data.CellDoubleClick += Grid_Data_CellDoubleClick;
            // 
            // panel1
            // 
            panel1.Controls.Add (lbl_Exit);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point (0, 701);
            panel1.Name = "panel1";
            panel1.Size = new Size (1294, 20);
            panel1.TabIndex = 28;
            // 
            // lbl_Exit
            // 
            lbl_Exit.BackColor = Color.LightCoral;
            lbl_Exit.Dock = DockStyle.Bottom;
            lbl_Exit.Font = new Font ("Segoe UI", 10F);
            lbl_Exit.ForeColor = Color.White;
            lbl_Exit.Location = new Point (0, 0);
            lbl_Exit.Name = "lbl_Exit";
            lbl_Exit.Size = new Size (1294, 20);
            lbl_Exit.TabIndex = 17;
            lbl_Exit.Text = "بازگشت";
            lbl_Exit.TextAlign = ContentAlignment.MiddleCenter;
            lbl_Exit.Click += lbl_Exit_Click;
            // 
            // btn_NewPeriod
            // 
            btn_NewPeriod.Location = new Point (154, 276);
            btn_NewPeriod.Name = "btn_NewPeriod";
            btn_NewPeriod.RightToLeft = RightToLeft.Yes;
            btn_NewPeriod.Size = new Size (136, 25);
            btn_NewPeriod.TabIndex = 29;
            btn_NewPeriod.TabStop = false;
            btn_NewPeriod.Text = "دوره جديد";
            btn_NewPeriod.UseVisualStyleBackColor = true;
            btn_NewPeriod.Click += btn_NewPeriod_Click;
            // 
            // btn_EditPeriod
            // 
            btn_EditPeriod.Location = new Point (1146, 276);
            btn_EditPeriod.Name = "btn_EditPeriod";
            btn_EditPeriod.RightToLeft = RightToLeft.Yes;
            btn_EditPeriod.Size = new Size (136, 25);
            btn_EditPeriod.TabIndex = 30;
            btn_EditPeriod.TabStop = false;
            btn_EditPeriod.Text = "ويرايش دوره";
            btn_EditPeriod.UseVisualStyleBackColor = true;
            btn_EditPeriod.Click += btn_EditPeriod_Click;
            // 
            // btn_CalculateCharge
            // 
            btn_CalculateCharge.Location = new Point (12, 276);
            btn_CalculateCharge.Name = "btn_CalculateCharge";
            btn_CalculateCharge.RightToLeft = RightToLeft.Yes;
            btn_CalculateCharge.Size = new Size (136, 25);
            btn_CalculateCharge.TabIndex = 31;
            btn_CalculateCharge.TabStop = false;
            btn_CalculateCharge.Text = "محاسبه شارژ";
            btn_CalculateCharge.UseVisualStyleBackColor = true;
            btn_CalculateCharge.Click += btn_CalculateCharge_Click;
            // 
            // btn_AddUnit2List
            // 
            btn_AddUnit2List.Location = new Point (438, 664);
            btn_AddUnit2List.Name = "btn_AddUnit2List";
            btn_AddUnit2List.RightToLeft = RightToLeft.Yes;
            btn_AddUnit2List.Size = new Size (136, 25);
            btn_AddUnit2List.TabIndex = 32;
            btn_AddUnit2List.TabStop = false;
            btn_AddUnit2List.Text = "افزودن واحد به ليست";
            btn_AddUnit2List.UseVisualStyleBackColor = true;
            btn_AddUnit2List.Click += btn_AddUnit2List_Click;
            // 
            // btn_RemoveUnitFromList
            // 
            btn_RemoveUnitFromList.Location = new Point (296, 664);
            btn_RemoveUnitFromList.Name = "btn_RemoveUnitFromList";
            btn_RemoveUnitFromList.RightToLeft = RightToLeft.Yes;
            btn_RemoveUnitFromList.Size = new Size (136, 25);
            btn_RemoveUnitFromList.TabIndex = 33;
            btn_RemoveUnitFromList.TabStop = false;
            btn_RemoveUnitFromList.Text = "حذف";
            btn_RemoveUnitFromList.UseVisualStyleBackColor = true;
            btn_RemoveUnitFromList.Click += btn_RemoveUnitFromList_Click;
            // 
            // btn_Note4All
            // 
            btn_Note4All.Location = new Point (154, 664);
            btn_Note4All.Name = "btn_Note4All";
            btn_Note4All.RightToLeft = RightToLeft.Yes;
            btn_Note4All.Size = new Size (136, 25);
            btn_Note4All.TabIndex = 34;
            btn_Note4All.TabStop = false;
            btn_Note4All.Text = "يادداشت براي همه";
            btn_Note4All.UseVisualStyleBackColor = true;
            btn_Note4All.Click += btn_Note4All_Click;
            // 
            // btn_EditGridDataItem
            // 
            btn_EditGridDataItem.Location = new Point (1146, 664);
            btn_EditGridDataItem.Name = "btn_EditGridDataItem";
            btn_EditGridDataItem.RightToLeft = RightToLeft.Yes;
            btn_EditGridDataItem.Size = new Size (136, 25);
            btn_EditGridDataItem.TabIndex = 35;
            btn_EditGridDataItem.TabStop = false;
            btn_EditGridDataItem.Text = "ويرايش آيتم";
            btn_EditGridDataItem.UseVisualStyleBackColor = true;
            btn_EditGridDataItem.Click += btn_EditGridDataItem_Click;
            // 
            // btn_AddChargeToAccs
            // 
            btn_AddChargeToAccs.Location = new Point (12, 664);
            btn_AddChargeToAccs.Name = "btn_AddChargeToAccs";
            btn_AddChargeToAccs.RightToLeft = RightToLeft.Yes;
            btn_AddChargeToAccs.Size = new Size (136, 25);
            btn_AddChargeToAccs.TabIndex = 36;
            btn_AddChargeToAccs.TabStop = false;
            btn_AddChargeToAccs.Text = "ثبت شارژها در حساب ها";
            btn_AddChargeToAccs.UseVisualStyleBackColor = true;
            btn_AddChargeToAccs.Click += btn_AddChargeToAccs_Click;
            // 
            // frmPeriods
            // 
            AutoScaleDimensions = new SizeF (7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size (1294, 721);
            ControlBox = false;
            Controls.Add (btn_AddChargeToAccs);
            Controls.Add (btn_EditGridDataItem);
            Controls.Add (btn_Note4All);
            Controls.Add (btn_RemoveUnitFromList);
            Controls.Add (btn_AddUnit2List);
            Controls.Add (btn_CalculateCharge);
            Controls.Add (btn_EditPeriod);
            Controls.Add (btn_NewPeriod);
            Controls.Add (panel1);
            Controls.Add (Grid_Data);
            Controls.Add (Grid_Periods);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmPeriods";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "دوره هاي شارژ";
            Load += frmPeriods_Load;
            ((System.ComponentModel.ISupportInitialize) Grid_Periods).EndInit ();
            ((System.ComponentModel.ISupportInitialize) Grid_Data).EndInit ();
            panel1.ResumeLayout (false);
            ResumeLayout (false);
            }

        #endregion

        private DataGridView Grid_Periods;
        private DataGridView Grid_Data;
        private Panel panel1;
        private Label lbl_Exit;
        private Button btn_NewPeriod;
        private Button btn_EditPeriod;
        private Button btn_CalculateCharge;
        private Button btn_AddUnit2List;
        private Button btn_RemoveUnitFromList;
        private Button btn_Note4All;
        private Button btn_EditGridDataItem;
        private Button btn_AddChargeToAccs;
        }
    }