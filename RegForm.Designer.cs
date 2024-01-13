namespace Kyrsach
{
    partial class RegForm
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
            this.RegPass_1 = new System.Windows.Forms.TextBox();
            this.RegLog = new System.Windows.Forms.TextBox();
            this.RegPass_2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.RegButt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RegPass_1
            // 
            this.RegPass_1.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegPass_1.Location = new System.Drawing.Point(60, 260);
            this.RegPass_1.Name = "RegPass_1";
            this.RegPass_1.Size = new System.Drawing.Size(288, 57);
            this.RegPass_1.TabIndex = 12;
            this.RegPass_1.UseSystemPasswordChar = true;
            // 
            // RegLog
            // 
            this.RegLog.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegLog.Location = new System.Drawing.Point(249, 127);
            this.RegLog.Multiline = true;
            this.RegLog.Name = "RegLog";
            this.RegLog.Size = new System.Drawing.Size(288, 64);
            this.RegLog.TabIndex = 11;
            // 
            // RegPass_2
            // 
            this.RegPass_2.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegPass_2.Location = new System.Drawing.Point(453, 260);
            this.RegPass_2.Name = "RegPass_2";
            this.RegPass_2.Size = new System.Drawing.Size(288, 57);
            this.RegPass_2.TabIndex = 10;
            this.RegPass_2.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(138, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 25);
            this.label3.TabIndex = 27;
            this.label3.Text = "Пароль";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(355, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 25);
            this.label2.TabIndex = 26;
            this.label2.Text = "Логин";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(299, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 38);
            this.label1.TabIndex = 25;
            this.label1.Text = "Регистрация";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(502, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 25);
            this.label4.TabIndex = 28;
            this.label4.Text = "Повторите пароль";
            // 
            // RegButt
            // 
            this.RegButt.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegButt.Location = new System.Drawing.Point(249, 355);
            this.RegButt.Name = "RegButt";
            this.RegButt.Size = new System.Drawing.Size(288, 41);
            this.RegButt.TabIndex = 33;
            this.RegButt.Text = "Зарегистрироваться";
            this.RegButt.UseVisualStyleBackColor = true;
            this.RegButt.Click += new System.EventHandler(this.RegButt_Click);
            // 
            // RegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RegButt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RegPass_1);
            this.Controls.Add(this.RegLog);
            this.Controls.Add(this.RegPass_2);
            this.Name = "RegForm";
            this.Text = "RegForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RegForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox RegPass_1;
        private System.Windows.Forms.TextBox RegLog;
        private System.Windows.Forms.TextBox RegPass_2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button RegButt;
    }
}