namespace Employee_Project_2
{
    partial class StoreProcedure
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
            Empidlbl = new Label();
            TXTEmp = new TextBox();
            BTNInsert = new Button();
            BTNUpdate = new Button();
            BTNDelete = new Button();
            BTNClear = new Button();
            LBLempname = new Label();
            Lblempdesig = new Label();
            Lblempdoj = new Label();
            Lblempsal = new Label();
            Lblempdeptno = new Label();
            TXTEmpName = new TextBox();
            TXTSal = new TextBox();
            TXTEmpDOJ = new TextBox();
            TXTEmpDesig = new TextBox();
            TXTEmpDeptNO = new TextBox();
            BTNFind = new Button();
            SuspendLayout();
            // 
            // Empidlbl
            // 
            Empidlbl.AutoSize = true;
            Empidlbl.Location = new Point(220, 46);
            Empidlbl.Name = "Empidlbl";
            Empidlbl.Size = new Size(56, 20);
            Empidlbl.TabIndex = 0;
            Empidlbl.Text = "Emp Id";
            // 
            // TXTEmp
            // 
            TXTEmp.Location = new Point(380, 43);
            TXTEmp.Name = "TXTEmp";
            TXTEmp.Size = new Size(179, 27);
            TXTEmp.TabIndex = 1;
            // 
            // BTNInsert
            // 
            BTNInsert.Location = new Point(298, 378);
            BTNInsert.Name = "BTNInsert";
            BTNInsert.Size = new Size(94, 29);
            BTNInsert.TabIndex = 2;
            BTNInsert.Text = "Insert";
            BTNInsert.UseVisualStyleBackColor = true;
            BTNInsert.Click += BTNInsert_Click;
            // 
            // BTNUpdate
            // 
            BTNUpdate.Location = new Point(398, 378);
            BTNUpdate.Name = "BTNUpdate";
            BTNUpdate.Size = new Size(94, 29);
            BTNUpdate.TabIndex = 3;
            BTNUpdate.Text = "Update";
            BTNUpdate.UseVisualStyleBackColor = true;
            BTNUpdate.Click += BTNUpdate_Click;
            // 
            // BTNDelete
            // 
            BTNDelete.Location = new Point(298, 424);
            BTNDelete.Name = "BTNDelete";
            BTNDelete.Size = new Size(94, 29);
            BTNDelete.TabIndex = 4;
            BTNDelete.Text = "Delete";
            BTNDelete.UseVisualStyleBackColor = true;
            BTNDelete.Click += BTNDelete_Click;
            // 
            // BTNClear
            // 
            BTNClear.Location = new Point(398, 424);
            BTNClear.Name = "BTNClear";
            BTNClear.Size = new Size(94, 29);
            BTNClear.TabIndex = 5;
            BTNClear.Text = "Clear";
            BTNClear.UseVisualStyleBackColor = true;
            BTNClear.Click += BTNClear_Click;
            // 
            // LBLempname
            // 
            LBLempname.AutoSize = true;
            LBLempname.Location = new Point(220, 99);
            LBLempname.Name = "LBLempname";
            LBLempname.Size = new Size(83, 20);
            LBLempname.TabIndex = 6;
            LBLempname.Text = "Emp Name";
            // 
            // Lblempdesig
            // 
            Lblempdesig.AutoSize = true;
            Lblempdesig.Location = new Point(220, 154);
            Lblempdesig.Name = "Lblempdesig";
            Lblempdesig.Size = new Size(123, 20);
            Lblempdesig.TabIndex = 7;
            Lblempdesig.Text = "Emp Designation";
            // 
            // Lblempdoj
            // 
            Lblempdoj.AutoSize = true;
            Lblempdoj.Location = new Point(220, 209);
            Lblempdoj.Name = "Lblempdoj";
            Lblempdoj.Size = new Size(70, 20);
            Lblempdoj.TabIndex = 8;
            Lblempdoj.Text = "Emp DOJ";
            // 
            // Lblempsal
            // 
            Lblempsal.AutoSize = true;
            Lblempsal.Location = new Point(220, 255);
            Lblempsal.Name = "Lblempsal";
            Lblempsal.Size = new Size(83, 20);
            Lblempsal.TabIndex = 9;
            Lblempsal.Text = "Emp Salary";
            // 
            // Lblempdeptno
            // 
            Lblempdeptno.AutoSize = true;
            Lblempdeptno.Location = new Point(220, 307);
            Lblempdeptno.Name = "Lblempdeptno";
            Lblempdeptno.Size = new Size(96, 20);
            Lblempdeptno.TabIndex = 10;
            Lblempdeptno.Text = "Emp DeptNo";
            // 
            // TXTEmpName
            // 
            TXTEmpName.Location = new Point(380, 99);
            TXTEmpName.Name = "TXTEmpName";
            TXTEmpName.Size = new Size(179, 27);
            TXTEmpName.TabIndex = 11;
            // 
            // TXTSal
            // 
            TXTSal.Location = new Point(380, 255);
            TXTSal.Name = "TXTSal";
            TXTSal.Size = new Size(179, 27);
            TXTSal.TabIndex = 12;
            // 
            // TXTEmpDOJ
            // 
            TXTEmpDOJ.Location = new Point(380, 209);
            TXTEmpDOJ.Name = "TXTEmpDOJ";
            TXTEmpDOJ.Size = new Size(179, 27);
            TXTEmpDOJ.TabIndex = 13;
            // 
            // TXTEmpDesig
            // 
            TXTEmpDesig.Location = new Point(380, 154);
            TXTEmpDesig.Name = "TXTEmpDesig";
            TXTEmpDesig.Size = new Size(179, 27);
            TXTEmpDesig.TabIndex = 14;
            // 
            // TXTEmpDeptNO
            // 
            TXTEmpDeptNO.Location = new Point(380, 304);
            TXTEmpDeptNO.Name = "TXTEmpDeptNO";
            TXTEmpDeptNO.Size = new Size(179, 27);
            TXTEmpDeptNO.TabIndex = 15;
            // 
            // BTNFind
            // 
            BTNFind.Location = new Point(348, 477);
            BTNFind.Name = "BTNFind";
            BTNFind.Size = new Size(94, 29);
            BTNFind.TabIndex = 16;
            BTNFind.Text = "Find";
            BTNFind.UseVisualStyleBackColor = true;
            BTNFind.Click += BTNFind_Click;
            // 
            // StoreProcedure
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(809, 556);
            Controls.Add(BTNFind);
            Controls.Add(TXTEmpDeptNO);
            Controls.Add(TXTEmpDesig);
            Controls.Add(TXTEmpDOJ);
            Controls.Add(TXTSal);
            Controls.Add(TXTEmpName);
            Controls.Add(Lblempdeptno);
            Controls.Add(Lblempsal);
            Controls.Add(Lblempdoj);
            Controls.Add(Lblempdesig);
            Controls.Add(LBLempname);
            Controls.Add(BTNClear);
            Controls.Add(BTNDelete);
            Controls.Add(BTNUpdate);
            Controls.Add(BTNInsert);
            Controls.Add(TXTEmp);
            Controls.Add(Empidlbl);
            Name = "StoreProcedure";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Empidlbl;
        private TextBox TXTEmp;
        private Button BTNInsert;
        private Button BTNUpdate;
        private Button BTNDelete;
        private Button BTNClear;
        private Label LBLempname;
        private Label Lblempdesig;
        private Label Lblempdoj;
        private Label Lblempsal;
        private Label Lblempdeptno;
        private TextBox TXTEmpName;
        private TextBox TXTSal;
        private TextBox TXTEmpDOJ;
        private TextBox TXTEmpDesig;
        private TextBox TXTEmpDeptNO;
        private Button BTNFind;
    }
}
