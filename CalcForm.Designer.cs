namespace Kyrsach
{
    partial class CalcForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MatrButt2 = new System.Windows.Forms.Button();
            this.sign = new System.Windows.Forms.Label();
            this.equel = new System.Windows.Forms.Label();
            this.AnswButt = new System.Windows.Forms.Button();
            this.MatrButt1 = new System.Windows.Forms.Button();
            this.MatrBox = new System.Windows.Forms.ComboBox();
            this.DoBox = new System.Windows.Forms.ComboBox();
            this.m1Box = new System.Windows.Forms.ComboBox();
            this.n1Box = new System.Windows.Forms.ComboBox();
            this.n2Box = new System.Windows.Forms.ComboBox();
            this.m2Box = new System.Windows.Forms.ComboBox();
            this.CBox = new System.Windows.Forms.TextBox();
            this.detAnsw = new System.Windows.Forms.TextBox();
            this.matr1 = new System.Windows.Forms.DataGridView();
            this.matr2 = new System.Windows.Forms.DataGridView();
            this.matr3 = new System.Windows.Forms.DataGridView();
            this.detRev = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.matr1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matr2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matr3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(10, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Количество матриц";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(410, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Действие";
            // 
            // MatrButt2
            // 
            this.MatrButt2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MatrButt2.Location = new System.Drawing.Point(725, 117);
            this.MatrButt2.Name = "MatrButt2";
            this.MatrButt2.Size = new System.Drawing.Size(40, 32);
            this.MatrButt2.TabIndex = 25;
            this.MatrButt2.Text = "V";
            this.MatrButt2.UseVisualStyleBackColor = true;
            this.MatrButt2.Click += new System.EventHandler(this.MatrButt2_Click);
            // 
            // sign
            // 
            this.sign.AutoSize = true;
            this.sign.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sign.Location = new System.Drawing.Point(381, 310);
            this.sign.Name = "sign";
            this.sign.Size = new System.Drawing.Size(24, 25);
            this.sign.TabIndex = 26;
            this.sign.Text = "*";
            // 
            // equel
            // 
            this.equel.AutoSize = true;
            this.equel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.equel.Location = new System.Drawing.Point(780, 310);
            this.equel.Name = "equel";
            this.equel.Size = new System.Drawing.Size(25, 25);
            this.equel.TabIndex = 29;
            this.equel.Text = "=";
            // 
            // AnswButt
            // 
            this.AnswButt.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AnswButt.Location = new System.Drawing.Point(1060, 116);
            this.AnswButt.Name = "AnswButt";
            this.AnswButt.Size = new System.Drawing.Size(110, 32);
            this.AnswButt.TabIndex = 31;
            this.AnswButt.Text = "Расчёт";
            this.AnswButt.UseVisualStyleBackColor = true;
            this.AnswButt.Click += new System.EventHandler(this.AnswButt_Click);
            // 
            // MatrButt1
            // 
            this.MatrButt1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MatrButt1.Location = new System.Drawing.Point(325, 117);
            this.MatrButt1.Name = "MatrButt1";
            this.MatrButt1.Size = new System.Drawing.Size(40, 32);
            this.MatrButt1.TabIndex = 34;
            this.MatrButt1.Text = "V";
            this.MatrButt1.UseVisualStyleBackColor = true;
            this.MatrButt1.Click += new System.EventHandler(this.MatrButt1_Click);
            // 
            // MatrBox
            // 
            this.MatrBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MatrBox.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MatrBox.FormattingEnabled = true;
            this.MatrBox.Items.AddRange(new object[] {
            "1",
            "2"});
            this.MatrBox.Location = new System.Drawing.Point(15, 50);
            this.MatrBox.Name = "MatrBox";
            this.MatrBox.Size = new System.Drawing.Size(67, 23);
            this.MatrBox.TabIndex = 36;
            this.MatrBox.SelectedIndexChanged += new System.EventHandler(this.MatrBox_SelectedIndexChanged);
            // 
            // DoBox
            // 
            this.DoBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DoBox.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold);
            this.DoBox.FormattingEnabled = true;
            this.DoBox.Location = new System.Drawing.Point(415, 51);
            this.DoBox.Name = "DoBox";
            this.DoBox.Size = new System.Drawing.Size(67, 23);
            this.DoBox.TabIndex = 37;
            this.DoBox.SelectedIndexChanged += new System.EventHandler(this.DoBox_SelectedIndexChanged);
            // 
            // m1Box
            // 
            this.m1Box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m1Box.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold);
            this.m1Box.FormattingEnabled = true;
            this.m1Box.Location = new System.Drawing.Point(15, 116);
            this.m1Box.Name = "m1Box";
            this.m1Box.Size = new System.Drawing.Size(67, 23);
            this.m1Box.TabIndex = 38;
            // 
            // n1Box
            // 
            this.n1Box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.n1Box.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold);
            this.n1Box.FormattingEnabled = true;
            this.n1Box.Location = new System.Drawing.Point(88, 116);
            this.n1Box.Name = "n1Box";
            this.n1Box.Size = new System.Drawing.Size(67, 23);
            this.n1Box.TabIndex = 39;
            // 
            // n2Box
            // 
            this.n2Box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.n2Box.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold);
            this.n2Box.FormattingEnabled = true;
            this.n2Box.Location = new System.Drawing.Point(488, 117);
            this.n2Box.Name = "n2Box";
            this.n2Box.Size = new System.Drawing.Size(67, 23);
            this.n2Box.TabIndex = 41;
            // 
            // m2Box
            // 
            this.m2Box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m2Box.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold);
            this.m2Box.FormattingEnabled = true;
            this.m2Box.Location = new System.Drawing.Point(415, 117);
            this.m2Box.Name = "m2Box";
            this.m2Box.Size = new System.Drawing.Size(67, 23);
            this.m2Box.TabIndex = 40;
            // 
            // CBox
            // 
            this.CBox.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CBox.Location = new System.Drawing.Point(525, 302);
            this.CBox.Name = "CBox";
            this.CBox.Size = new System.Drawing.Size(100, 34);
            this.CBox.TabIndex = 42;
            // 
            // detAnsw
            // 
            this.detAnsw.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.detAnsw.Location = new System.Drawing.Point(874, 302);
            this.detAnsw.Name = "detAnsw";
            this.detAnsw.ReadOnly = true;
            this.detAnsw.Size = new System.Drawing.Size(141, 39);
            this.detAnsw.TabIndex = 43;
            // 
            // matr1
            // 
            this.matr1.AllowUserToAddRows = false;
            this.matr1.AllowUserToDeleteRows = false;
            this.matr1.AllowUserToResizeColumns = false;
            this.matr1.AllowUserToResizeRows = false;
            this.matr1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.matr1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.matr1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.matr1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.matr1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matr1.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.matr1.DefaultCellStyle = dataGridViewCellStyle1;
            this.matr1.Location = new System.Drawing.Point(15, 155);
            this.matr1.Name = "matr1";
            this.matr1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.matr1.RowHeadersVisible = false;
            this.matr1.RowHeadersWidth = 51;
            this.matr1.RowTemplate.Height = 24;
            this.matr1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.matr1.Size = new System.Drawing.Size(350, 325);
            this.matr1.TabIndex = 44;
            // 
            // matr2
            // 
            this.matr2.AllowUserToAddRows = false;
            this.matr2.AllowUserToDeleteRows = false;
            this.matr2.AllowUserToResizeColumns = false;
            this.matr2.AllowUserToResizeRows = false;
            this.matr2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.matr2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.matr2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.matr2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.matr2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matr2.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.matr2.DefaultCellStyle = dataGridViewCellStyle2;
            this.matr2.Location = new System.Drawing.Point(415, 155);
            this.matr2.Name = "matr2";
            this.matr2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.matr2.RowHeadersVisible = false;
            this.matr2.RowHeadersWidth = 51;
            this.matr2.RowTemplate.Height = 24;
            this.matr2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.matr2.Size = new System.Drawing.Size(350, 325);
            this.matr2.TabIndex = 45;
            // 
            // matr3
            // 
            this.matr3.AllowUserToAddRows = false;
            this.matr3.AllowUserToDeleteRows = false;
            this.matr3.AllowUserToResizeColumns = false;
            this.matr3.AllowUserToResizeRows = false;
            this.matr3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.matr3.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.matr3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.matr3.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.matr3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matr3.ColumnHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.matr3.DefaultCellStyle = dataGridViewCellStyle3;
            this.matr3.Location = new System.Drawing.Point(820, 155);
            this.matr3.Name = "matr3";
            this.matr3.ReadOnly = true;
            this.matr3.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.matr3.RowHeadersVisible = false;
            this.matr3.RowHeadersWidth = 51;
            this.matr3.RowTemplate.Height = 24;
            this.matr3.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.matr3.Size = new System.Drawing.Size(350, 325);
            this.matr3.TabIndex = 46;
            // 
            // detRev
            // 
            this.detRev.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.detRev.Location = new System.Drawing.Point(820, 100);
            this.detRev.Name = "detRev";
            this.detRev.ReadOnly = true;
            this.detRev.Size = new System.Drawing.Size(141, 39);
            this.detRev.TabIndex = 47;
            // 
            // CalcForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 504);
            this.Controls.Add(this.detRev);
            this.Controls.Add(this.matr1);
            this.Controls.Add(this.n2Box);
            this.Controls.Add(this.m2Box);
            this.Controls.Add(this.n1Box);
            this.Controls.Add(this.m1Box);
            this.Controls.Add(this.DoBox);
            this.Controls.Add(this.MatrBox);
            this.Controls.Add(this.MatrButt1);
            this.Controls.Add(this.AnswButt);
            this.Controls.Add(this.equel);
            this.Controls.Add(this.sign);
            this.Controls.Add(this.MatrButt2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.detAnsw);
            this.Controls.Add(this.CBox);
            this.Controls.Add(this.matr2);
            this.Controls.Add(this.matr3);
            this.Name = "CalcForm";
            this.Text = "CalcForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CalcForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.matr1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matr2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matr3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button MatrButt2;
        private System.Windows.Forms.Label sign;
        private System.Windows.Forms.Label equel;
        private System.Windows.Forms.Button AnswButt;
        private System.Windows.Forms.Button MatrButt1;
        private System.Windows.Forms.ComboBox MatrBox;
        private System.Windows.Forms.ComboBox DoBox;
        private System.Windows.Forms.ComboBox m1Box;
        private System.Windows.Forms.ComboBox n1Box;
        private System.Windows.Forms.ComboBox n2Box;
        private System.Windows.Forms.ComboBox m2Box;
        private System.Windows.Forms.TextBox CBox;
        private System.Windows.Forms.TextBox detAnsw;
        private System.Windows.Forms.DataGridView matr1;
        private System.Windows.Forms.DataGridView matr2;
        private System.Windows.Forms.DataGridView matr3;
        private System.Windows.Forms.TextBox detRev;
    }
}