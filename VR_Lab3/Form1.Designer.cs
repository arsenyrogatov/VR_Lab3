namespace VR_Lab3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.arInput_textBox = new System.Windows.Forms.TextBox();
            this.arOutput_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.arProcess_button = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.bmInput_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bwtInput_textBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mtfInput_textBox = new System.Windows.Forms.TextBox();
            this.bmProcess_button = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 9.857143F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Фраза для кодирования";
            // 
            // arInput_textBox
            // 
            this.arInput_textBox.Location = new System.Drawing.Point(14, 46);
            this.arInput_textBox.Multiline = true;
            this.arInput_textBox.Name = "arInput_textBox";
            this.arInput_textBox.Size = new System.Drawing.Size(1236, 114);
            this.arInput_textBox.TabIndex = 1;
            this.arInput_textBox.Text = resources.GetString("arInput_textBox.Text");
            // 
            // arOutput_textBox
            // 
            this.arOutput_textBox.Location = new System.Drawing.Point(14, 204);
            this.arOutput_textBox.Multiline = true;
            this.arOutput_textBox.Name = "arOutput_textBox";
            this.arOutput_textBox.Size = new System.Drawing.Size(1236, 89);
            this.arOutput_textBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 9.857143F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(479, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Результат арифметического кодирования";
            // 
            // arProcess_button
            // 
            this.arProcess_button.AutoSize = true;
            this.arProcess_button.Location = new System.Drawing.Point(14, 299);
            this.arProcess_button.Name = "arProcess_button";
            this.arProcess_button.Size = new System.Drawing.Size(158, 39);
            this.arProcess_button.TabIndex = 4;
            this.arProcess_button.Text = "Кодировать";
            this.arProcess_button.UseVisualStyleBackColor = true;
            this.arProcess_button.Click += new System.EventHandler(this.arProcess_button_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1272, 525);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.arProcess_button);
            this.tabPage1.Controls.Add(this.arInput_textBox);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.arOutput_textBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 37);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1264, 484);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Арифметическое кодирование";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.bmProcess_button);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.mtfInput_textBox);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.bwtInput_textBox);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.bmInput_textBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 37);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1264, 484);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "BWT MTF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 9.857143F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(6, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(318, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Фраза для преобразования";
            // 
            // bmInput_textBox
            // 
            this.bmInput_textBox.Location = new System.Drawing.Point(14, 46);
            this.bmInput_textBox.Multiline = true;
            this.bmInput_textBox.Name = "bmInput_textBox";
            this.bmInput_textBox.Size = new System.Drawing.Size(1236, 114);
            this.bmInput_textBox.TabIndex = 3;
            this.bmInput_textBox.Text = "СПАСАПНРЕКККРОШГРЕЕ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 9.857143F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(6, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "BWT";
            // 
            // bwtInput_textBox
            // 
            this.bwtInput_textBox.Location = new System.Drawing.Point(14, 204);
            this.bwtInput_textBox.Multiline = true;
            this.bwtInput_textBox.Name = "bwtInput_textBox";
            this.bwtInput_textBox.Size = new System.Drawing.Size(1236, 89);
            this.bwtInput_textBox.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 9.857143F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(6, 302);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 29);
            this.label5.TabIndex = 7;
            this.label5.Text = "MTF";
            // 
            // mtfInput_textBox
            // 
            this.mtfInput_textBox.Location = new System.Drawing.Point(14, 336);
            this.mtfInput_textBox.Multiline = true;
            this.mtfInput_textBox.Name = "mtfInput_textBox";
            this.mtfInput_textBox.Size = new System.Drawing.Size(1236, 89);
            this.mtfInput_textBox.TabIndex = 6;
            // 
            // bmProcess_button
            // 
            this.bmProcess_button.AutoSize = true;
            this.bmProcess_button.Location = new System.Drawing.Point(14, 431);
            this.bmProcess_button.Name = "bmProcess_button";
            this.bmProcess_button.Size = new System.Drawing.Size(197, 39);
            this.bmProcess_button.TabIndex = 8;
            this.bmProcess_button.Text = "Преобразовать";
            this.bmProcess_button.UseVisualStyleBackColor = true;
            this.bmProcess_button.Click += new System.EventHandler(this.bmProcess_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(168F, 168F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1296, 552);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Roboto", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лаба3";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox arInput_textBox;
        private System.Windows.Forms.TextBox arOutput_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button arProcess_button;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button bmProcess_button;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox mtfInput_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox bwtInput_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox bmInput_textBox;
    }
}

