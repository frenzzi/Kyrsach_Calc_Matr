namespace Kyrsach
{
    partial class LogForm
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
            this.LogPass = new System.Windows.Forms.TextBox();
            this.LogLog = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LogButt = new System.Windows.Forms.Button();
            this.RegButt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LogPass
            // 
            this.LogPass.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogPass.Location = new System.Drawing.Point(232, 271);
            this.LogPass.Name = "LogPass";
            this.LogPass.Size = new System.Drawing.Size(305, 57);
            this.LogPass.TabIndex = 20;
            this.LogPass.UseSystemPasswordChar = true;
            // 
            // LogLog
            // 
            this.LogLog.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogLog.Location = new System.Drawing.Point(232, 138);
            this.LogLog.Multiline = true;
            this.LogLog.Name = "LogLog";
            this.LogLog.Size = new System.Drawing.Size(305, 64);
            this.LogLog.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(277, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 38);
            this.label1.TabIndex = 22;
            this.label1.Text = "Авторизация";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(347, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 25);
            this.label2.TabIndex = 23;
            this.label2.Text = "Логин";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(347, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 25);
            this.label3.TabIndex = 24;
            this.label3.Text = "Пароль";
            // 
            // LogButt
            // 
            this.LogButt.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogButt.Location = new System.Drawing.Point(427, 371);
            this.LogButt.Name = "LogButt";
            this.LogButt.Size = new System.Drawing.Size(110, 32);
            this.LogButt.TabIndex = 32;
            this.LogButt.Text = "Войти";
            this.LogButt.UseVisualStyleBackColor = true;
            this.LogButt.Click += new System.EventHandler(this.LogButt_Click);
            // 
            // RegButt
            // 
            this.RegButt.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegButt.Location = new System.Drawing.Point(232, 371);
            this.RegButt.Name = "RegButt";
            this.RegButt.Size = new System.Drawing.Size(174, 32);
            this.RegButt.TabIndex = 33;
            this.RegButt.Text = "Регистрация";
            this.RegButt.UseVisualStyleBackColor = true;
            this.RegButt.Click += new System.EventHandler(this.RegButt_Click);
            // 
            // LogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RegButt);
            this.Controls.Add(this.LogButt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LogPass);
            this.Controls.Add(this.LogLog);
            this.Name = "LogForm";
            this.Text = "LogForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LogForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox LogPass;
        private System.Windows.Forms.TextBox LogLog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button LogButt;
        private System.Windows.Forms.Button RegButt;
    }
}