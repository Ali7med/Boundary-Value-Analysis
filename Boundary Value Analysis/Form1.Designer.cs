namespace Boundary_Value_Analysis
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BtnGenerate = new Button();
            DGResult = new DataGridView();
            ColOrder = new DataGridViewTextBoxColumn();
            ColYear = new DataGridViewTextBoxColumn();
            ColMonth = new DataGridViewTextBoxColumn();
            ColDay = new DataGridViewTextBoxColumn();
            ColDayOfWeek = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            TxtDate1 = new NumericUpDown();
            TxtDate2 = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)DGResult).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TxtDate1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TxtDate2).BeginInit();
            SuspendLayout();
            // 
            // BtnGenerate
            // 
            BtnGenerate.Location = new Point(713, 411);
            BtnGenerate.Name = "BtnGenerate";
            BtnGenerate.Size = new Size(197, 67);
            BtnGenerate.TabIndex = 0;
            BtnGenerate.Text = "Generate";
            BtnGenerate.UseVisualStyleBackColor = true;
            BtnGenerate.Click += BtnGenerate_Click;
            // 
            // DGResult
            // 
            DGResult.AllowUserToAddRows = false;
            DGResult.AllowUserToDeleteRows = false;
            DGResult.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGResult.BackgroundColor = SystemColors.ButtonHighlight;
            DGResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGResult.Columns.AddRange(new DataGridViewColumn[] { ColOrder, ColYear, ColMonth, ColDay, ColDayOfWeek });
            DGResult.Location = new Point(18, 26);
            DGResult.Name = "DGResult";
            DGResult.ReadOnly = true;
            DGResult.RowTemplate.Height = 25;
            DGResult.Size = new Size(607, 481);
            DGResult.TabIndex = 1;
            // 
            // ColOrder
            // 
            ColOrder.HeaderText = "#";
            ColOrder.Name = "ColOrder";
            ColOrder.ReadOnly = true;
            // 
            // ColYear
            // 
            ColYear.HeaderText = "Year";
            ColYear.Name = "ColYear";
            ColYear.ReadOnly = true;
            // 
            // ColMonth
            // 
            ColMonth.HeaderText = "Month";
            ColMonth.Name = "ColMonth";
            ColMonth.ReadOnly = true;
            // 
            // ColDay
            // 
            ColDay.HeaderText = "Day";
            ColDay.Name = "ColDay";
            ColDay.ReadOnly = true;
            // 
            // ColDayOfWeek
            // 
            ColDayOfWeek.HeaderText = "DayOfWeek";
            ColDayOfWeek.Name = "ColDayOfWeek";
            ColDayOfWeek.ReadOnly = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(693, 168);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 3;
            label1.Text = "Last Year";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(692, 139);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 3;
            label2.Text = "First Year";
            // 
            // label3
            // 
            label3.ForeColor = Color.Red;
            label3.Location = new Point(657, 209);
            label3.Name = "label3";
            label3.Size = new Size(294, 15);
            label3.TabIndex = 3;
            label3.Text = "Note : Must to Input Year with format yyyy ex : 1990";
            // 
            // TxtDate1
            // 
            TxtDate1.Location = new Point(768, 137);
            TxtDate1.Maximum = new decimal(new int[] { 2025, 0, 0, 0 });
            TxtDate1.Minimum = new decimal(new int[] { 1900, 0, 0, 0 });
            TxtDate1.Name = "TxtDate1";
            TxtDate1.Size = new Size(82, 23);
            TxtDate1.TabIndex = 4;
            TxtDate1.Value = new decimal(new int[] { 1900, 0, 0, 0 });
            // 
            // TxtDate2
            // 
            TxtDate2.Location = new Point(768, 166);
            TxtDate2.Maximum = new decimal(new int[] { 2025, 0, 0, 0 });
            TxtDate2.Minimum = new decimal(new int[] { 1900, 0, 0, 0 });
            TxtDate2.Name = "TxtDate2";
            TxtDate2.Size = new Size(82, 23);
            TxtDate2.TabIndex = 4;
            TxtDate2.Value = new decimal(new int[] { 2025, 0, 0, 0 });
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(979, 532);
            Controls.Add(TxtDate2);
            Controls.Add(TxtDate1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(DGResult);
            Controls.Add(BtnGenerate);
            Name = "Form1";
            Text = "Boundary Value Analysis";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)DGResult).EndInit();
            ((System.ComponentModel.ISupportInitialize)TxtDate1).EndInit();
            ((System.ComponentModel.ISupportInitialize)TxtDate2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnGenerate;
        private DataGridView DGResult;
        private Label label1;
        private Label label2;
        private Label label3;
        private DataGridViewTextBoxColumn ColOrder;
        private DataGridViewTextBoxColumn ColYear;
        private DataGridViewTextBoxColumn ColMonth;
        private DataGridViewTextBoxColumn ColDay;
        private DataGridViewTextBoxColumn ColDayOfWeek;
        private NumericUpDown TxtDate1;
        private NumericUpDown TxtDate2;
    }
}