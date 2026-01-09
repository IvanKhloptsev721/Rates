namespace Rates
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Fromlabel1 = new System.Windows.Forms.Label();
            this.Tolabel1 = new System.Windows.Forms.Label();
            this.Resultlabel1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.OUtTextBox1 = new System.Windows.Forms.TextBox();
            this.ResultButton1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Fromlabel1
            // 
            this.Fromlabel1.BackColor = System.Drawing.SystemColors.Info;
            this.Fromlabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Fromlabel1.Location = new System.Drawing.Point(88, 56);
            this.Fromlabel1.Name = "Fromlabel1";
            this.Fromlabel1.Size = new System.Drawing.Size(103, 70);
            this.Fromlabel1.TabIndex = 0;
            this.Fromlabel1.Text = "Из";
            this.Fromlabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Tolabel1
            // 
            this.Tolabel1.BackColor = System.Drawing.SystemColors.Info;
            this.Tolabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Tolabel1.Location = new System.Drawing.Point(315, 56);
            this.Tolabel1.Name = "Tolabel1";
            this.Tolabel1.Size = new System.Drawing.Size(103, 70);
            this.Tolabel1.TabIndex = 1;
            this.Tolabel1.Text = "В";
            this.Tolabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Resultlabel1
            // 
            this.Resultlabel1.BackColor = System.Drawing.SystemColors.Info;
            this.Resultlabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Resultlabel1.Location = new System.Drawing.Point(188, 356);
            this.Resultlabel1.Name = "Resultlabel1";
            this.Resultlabel1.Size = new System.Drawing.Size(128, 70);
            this.Resultlabel1.TabIndex = 2;
            this.Resultlabel1.Text = "0";
            this.Resultlabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Resultlabel1.Click += new System.EventHandler(this.Resultlabel1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "USD",
            "RUB"});
            this.comboBox1.Location = new System.Drawing.Point(91, 209);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "RUB",
            "USD"});
            this.comboBox2.Location = new System.Drawing.Point(318, 209);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(100, 21);
            this.comboBox2.TabIndex = 4;
            // 
            // OUtTextBox1
            // 
            this.OUtTextBox1.BackColor = System.Drawing.SystemColors.Info;
            this.OUtTextBox1.Location = new System.Drawing.Point(191, 256);
            this.OUtTextBox1.Name = "OUtTextBox1";
            this.OUtTextBox1.Size = new System.Drawing.Size(125, 20);
            this.OUtTextBox1.TabIndex = 5;
            // 
            // ResultButton1
            // 
            this.ResultButton1.BackColor = System.Drawing.SystemColors.Window;
            this.ResultButton1.Location = new System.Drawing.Point(191, 299);
            this.ResultButton1.Name = "ResultButton1";
            this.ResultButton1.Size = new System.Drawing.Size(125, 35);
            this.ResultButton1.TabIndex = 7;
            this.ResultButton1.Text = "Конвертировать";
            this.ResultButton1.UseVisualStyleBackColor = false;
            this.ResultButton1.Click += new System.EventHandler(this.ResultButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(499, 435);
            this.Controls.Add(this.ResultButton1);
            this.Controls.Add(this.OUtTextBox1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Resultlabel1);
            this.Controls.Add(this.Tolabel1);
            this.Controls.Add(this.Fromlabel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Fromlabel1;
        private System.Windows.Forms.Label Tolabel1;
        private System.Windows.Forms.Label Resultlabel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox OUtTextBox1;
        private System.Windows.Forms.Button ResultButton1;
    }
}

