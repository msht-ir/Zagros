namespace ZagrosDesktop
    {
    partial class frmTables
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle ();
            Grid_Tables = new DataGridView ();
            btn_Units = new Button ();
            btn_Persons = new Button ();
            btn_Periods = new Button ();
            btn_Cats = new Button ();
            panel1 = new Panel ();
            lbl_Exit = new Label ();
            btn_Accs = new Button ();
            btn_AddNewPerson = new Button ();
            btn_AddNewUnit = new Button ();
            btn_EditUnit = new Button ();
            btn_EditPerson = new Button ();
            btn_EditAccItem = new Button ();
            btn_DeleteAccItem = new Button ();
            btn_Accs_Payments = new Button ();
            btn_Accs_Expenses = new Button ();
            btn_Accs_Charges = new Button ();
            ((System.ComponentModel.ISupportInitialize) Grid_Tables).BeginInit ();
            panel1.SuspendLayout ();
            SuspendLayout ();
            // 
            // Grid_Tables
            // 
            Grid_Tables.AllowUserToAddRows = false;
            Grid_Tables.AllowUserToDeleteRows = false;
            Grid_Tables.AllowUserToResizeColumns = false;
            Grid_Tables.AllowUserToResizeRows = false;
            Grid_Tables.BackgroundColor = Color.WhiteSmoke;
            Grid_Tables.BorderStyle = BorderStyle.None;
            Grid_Tables.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle4.Font = new Font ("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb (  236,   236,   236);
            dataGridViewCellStyle4.SelectionForeColor = Color.IndianRed;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            Grid_Tables.DefaultCellStyle = dataGridViewCellStyle4;
            Grid_Tables.EditMode = DataGridViewEditMode.EditProgrammatically;
            Grid_Tables.GridColor = Color.WhiteSmoke;
            Grid_Tables.Location = new Point (12, 12);
            Grid_Tables.Name = "Grid_Tables";
            Grid_Tables.RightToLeft = RightToLeft.Yes;
            Grid_Tables.RowHeadersVisible = false;
            Grid_Tables.ScrollBars = ScrollBars.Vertical;
            Grid_Tables.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Grid_Tables.Size = new Size (1270, 521);
            Grid_Tables.TabIndex = 1;
            // 
            // btn_Units
            // 
            btn_Units.Font = new Font ("Segoe UI", 9F);
            btn_Units.Location = new Point (962, 547);
            btn_Units.Name = "btn_Units";
            btn_Units.RightToLeft = RightToLeft.Yes;
            btn_Units.Size = new Size (112, 28);
            btn_Units.TabIndex = 2;
            btn_Units.Text = "واحدها";
            btn_Units.UseVisualStyleBackColor = true;
            btn_Units.Click += btn_Units_Click;
            // 
            // btn_Persons
            // 
            btn_Persons.Font = new Font ("Segoe UI", 9F);
            btn_Persons.Location = new Point (736, 547);
            btn_Persons.Name = "btn_Persons";
            btn_Persons.RightToLeft = RightToLeft.Yes;
            btn_Persons.Size = new Size (112, 28);
            btn_Persons.TabIndex = 3;
            btn_Persons.Text = "اشخاص";
            btn_Persons.UseVisualStyleBackColor = true;
            btn_Persons.Click += btn_Persons_Click;
            // 
            // btn_Periods
            // 
            btn_Periods.Font = new Font ("Segoe UI", 9F);
            btn_Periods.Location = new Point (12, 547);
            btn_Periods.Name = "btn_Periods";
            btn_Periods.RightToLeft = RightToLeft.Yes;
            btn_Periods.Size = new Size (112, 28);
            btn_Periods.TabIndex = 4;
            btn_Periods.Text = "دوره ها";
            btn_Periods.UseVisualStyleBackColor = true;
            btn_Periods.Click += btn_Periods_Click;
            // 
            // btn_Cats
            // 
            btn_Cats.Font = new Font ("Segoe UI", 9F);
            btn_Cats.Location = new Point (1129, 547);
            btn_Cats.Name = "btn_Cats";
            btn_Cats.RightToLeft = RightToLeft.Yes;
            btn_Cats.Size = new Size (153, 28);
            btn_Cats.TabIndex = 5;
            btn_Cats.Text = "رديف هاي هزينه/درآمد";
            btn_Cats.UseVisualStyleBackColor = true;
            btn_Cats.Click += btn_Cats_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add (lbl_Exit);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point (0, 621);
            panel1.Name = "panel1";
            panel1.Size = new Size (1293, 20);
            panel1.TabIndex = 29;
            // 
            // lbl_Exit
            // 
            lbl_Exit.BackColor = Color.LightCoral;
            lbl_Exit.Dock = DockStyle.Bottom;
            lbl_Exit.Font = new Font ("Segoe UI", 10F);
            lbl_Exit.ForeColor = Color.White;
            lbl_Exit.Location = new Point (0, 0);
            lbl_Exit.Name = "lbl_Exit";
            lbl_Exit.Size = new Size (1293, 20);
            lbl_Exit.TabIndex = 17;
            lbl_Exit.Text = "خروج";
            lbl_Exit.TextAlign = ContentAlignment.MiddleCenter;
            lbl_Exit.Click += lbl_Exit_Click;
            // 
            // btn_Accs
            // 
            btn_Accs.Font = new Font ("Segoe UI", 9F);
            btn_Accs.Location = new Point (493, 547);
            btn_Accs.Name = "btn_Accs";
            btn_Accs.RightToLeft = RightToLeft.Yes;
            btn_Accs.Size = new Size (112, 28);
            btn_Accs.TabIndex = 30;
            btn_Accs.Text = "همه تراکنش ها";
            btn_Accs.UseVisualStyleBackColor = true;
            btn_Accs.Click += btn_Accs_Click;
            // 
            // btn_AddNewPerson
            // 
            btn_AddNewPerson.Font = new Font ("Courier New", 9F);
            btn_AddNewPerson.Location = new Point (704, 547);
            btn_AddNewPerson.Name = "btn_AddNewPerson";
            btn_AddNewPerson.RightToLeft = RightToLeft.Yes;
            btn_AddNewPerson.Size = new Size (26, 28);
            btn_AddNewPerson.TabIndex = 32;
            btn_AddNewPerson.Text = "+";
            btn_AddNewPerson.UseVisualStyleBackColor = true;
            btn_AddNewPerson.Click += btn_AddNewPerson_Click;
            // 
            // btn_AddNewUnit
            // 
            btn_AddNewUnit.Font = new Font ("Courier New", 9F);
            btn_AddNewUnit.Location = new Point (932, 547);
            btn_AddNewUnit.Name = "btn_AddNewUnit";
            btn_AddNewUnit.RightToLeft = RightToLeft.Yes;
            btn_AddNewUnit.Size = new Size (24, 28);
            btn_AddNewUnit.TabIndex = 31;
            btn_AddNewUnit.Text = "+";
            btn_AddNewUnit.UseVisualStyleBackColor = true;
            btn_AddNewUnit.Click += btn_AddNewUnit_Click;
            // 
            // btn_EditUnit
            // 
            btn_EditUnit.Font = new Font ("Courier New", 9F);
            btn_EditUnit.Location = new Point (902, 547);
            btn_EditUnit.Name = "btn_EditUnit";
            btn_EditUnit.RightToLeft = RightToLeft.Yes;
            btn_EditUnit.Size = new Size (24, 28);
            btn_EditUnit.TabIndex = 33;
            btn_EditUnit.Text = "I";
            btn_EditUnit.UseVisualStyleBackColor = true;
            btn_EditUnit.Click += btn_EditUnit_Click;
            // 
            // btn_EditPerson
            // 
            btn_EditPerson.Font = new Font ("Courier New", 9F);
            btn_EditPerson.Location = new Point (674, 547);
            btn_EditPerson.Name = "btn_EditPerson";
            btn_EditPerson.RightToLeft = RightToLeft.Yes;
            btn_EditPerson.Size = new Size (24, 28);
            btn_EditPerson.TabIndex = 34;
            btn_EditPerson.Text = "I";
            btn_EditPerson.UseVisualStyleBackColor = true;
            btn_EditPerson.Click += btn_EditPerson_Click;
            // 
            // btn_EditAccItem
            // 
            btn_EditAccItem.Font = new Font ("Courier New", 9F);
            btn_EditAccItem.Location = new Point (411, 547);
            btn_EditAccItem.Name = "btn_EditAccItem";
            btn_EditAccItem.RightToLeft = RightToLeft.Yes;
            btn_EditAccItem.Size = new Size (24, 28);
            btn_EditAccItem.TabIndex = 35;
            btn_EditAccItem.Text = "I";
            btn_EditAccItem.UseVisualStyleBackColor = true;
            btn_EditAccItem.Click += btn_EditAccItem_Click;
            // 
            // btn_DeleteAccItem
            // 
            btn_DeleteAccItem.BackColor = Color.White;
            btn_DeleteAccItem.Font = new Font ("Segoe UI", 9F);
            btn_DeleteAccItem.ForeColor = Color.IndianRed;
            btn_DeleteAccItem.Location = new Point (441, 547);
            btn_DeleteAccItem.Name = "btn_DeleteAccItem";
            btn_DeleteAccItem.RightToLeft = RightToLeft.Yes;
            btn_DeleteAccItem.Size = new Size (46, 28);
            btn_DeleteAccItem.TabIndex = 36;
            btn_DeleteAccItem.Text = "حذف";
            btn_DeleteAccItem.UseVisualStyleBackColor = false;
            btn_DeleteAccItem.Click += btn_DeleteAccItem_Click;
            // 
            // btn_Accs_Payments
            // 
            btn_Accs_Payments.Font = new Font ("Segoe UI", 9F);
            btn_Accs_Payments.Location = new Point (183, 547);
            btn_Accs_Payments.Name = "btn_Accs_Payments";
            btn_Accs_Payments.RightToLeft = RightToLeft.Yes;
            btn_Accs_Payments.Size = new Size (70, 28);
            btn_Accs_Payments.TabIndex = 37;
            btn_Accs_Payments.Text = "پرداخت ها";
            btn_Accs_Payments.UseVisualStyleBackColor = true;
            btn_Accs_Payments.Click += btn_Accs_Payments_Click;
            // 
            // btn_Accs_Expenses
            // 
            btn_Accs_Expenses.Font = new Font ("Segoe UI", 9F);
            btn_Accs_Expenses.Location = new Point (335, 547);
            btn_Accs_Expenses.Name = "btn_Accs_Expenses";
            btn_Accs_Expenses.RightToLeft = RightToLeft.Yes;
            btn_Accs_Expenses.Size = new Size (70, 28);
            btn_Accs_Expenses.TabIndex = 38;
            btn_Accs_Expenses.Text = "هزينه ها";
            btn_Accs_Expenses.UseVisualStyleBackColor = true;
            btn_Accs_Expenses.Click += btn_Accs_Expenses_Click;
            // 
            // btn_Accs_Charges
            // 
            btn_Accs_Charges.Font = new Font ("Segoe UI", 9F);
            btn_Accs_Charges.Location = new Point (259, 547);
            btn_Accs_Charges.Name = "btn_Accs_Charges";
            btn_Accs_Charges.RightToLeft = RightToLeft.Yes;
            btn_Accs_Charges.Size = new Size (70, 28);
            btn_Accs_Charges.TabIndex = 39;
            btn_Accs_Charges.Text = "شارژها";
            btn_Accs_Charges.UseVisualStyleBackColor = true;
            btn_Accs_Charges.Click += btn_Accs_Charges_Click;
            // 
            // frmTables
            // 
            AutoScaleDimensions = new SizeF (7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size (1293, 641);
            ControlBox = false;
            Controls.Add (btn_Accs_Charges);
            Controls.Add (btn_Accs_Expenses);
            Controls.Add (btn_Accs_Payments);
            Controls.Add (btn_DeleteAccItem);
            Controls.Add (btn_EditAccItem);
            Controls.Add (btn_EditPerson);
            Controls.Add (btn_EditUnit);
            Controls.Add (btn_AddNewPerson);
            Controls.Add (btn_AddNewUnit);
            Controls.Add (btn_Accs);
            Controls.Add (panel1);
            Controls.Add (btn_Cats);
            Controls.Add (btn_Periods);
            Controls.Add (btn_Persons);
            Controls.Add (btn_Units);
            Controls.Add (Grid_Tables);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmTables";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "جدول ها";
            Load += frmTables_Load;
            ((System.ComponentModel.ISupportInitialize) Grid_Tables).EndInit ();
            panel1.ResumeLayout (false);
            ResumeLayout (false);
            }

        #endregion

        private DataGridView Grid_Tables;
        private Button btn_Units;
        private Button btn_Persons;
        private Button btn_Periods;
        private Button btn_Cats;
        private Panel panel1;
        private Label lbl_Exit;
        private Button btn_Accs;
        private Button btn_AddNewPerson;
        private Button btn_AddNewUnit;
        private Button btn_EditUnit;
        private Button btn_EditPerson;
        private Button btn_EditAccItem;
        private Button btn_DeleteAccItem;
        private Button btn_Accs_Payments;
        private Button btn_Accs_Expenses;
        private Button btn_Accs_Charges;
        }
    }