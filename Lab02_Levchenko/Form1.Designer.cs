namespace Lab02_Levchenko
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_p = new System.Windows.Forms.TextBox();
            this.textBox_key = new System.Windows.Forms.TextBox();
            this.textBox_c = new System.Windows.Forms.TextBox();
            this.button_xor = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.label_p_hex = new System.Windows.Forms.Label();
            this.label_p_10 = new System.Windows.Forms.Label();
            this.label_p_2 = new System.Windows.Forms.Label();
            this.label_key_hex = new System.Windows.Forms.Label();
            this.label_key_10 = new System.Windows.Forms.Label();
            this.label_key_2 = new System.Windows.Forms.Label();
            this.label_c_hex = new System.Windows.Forms.Label();
            this.label_c_10 = new System.Windows.Forms.Label();
            this.label_c_2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox_c_OUT = new System.Windows.Forms.TextBox();
            this.textBox_key_OUT = new System.Windows.Forms.TextBox();
            this.textBox_p_OUT = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(33, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "P =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(19, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Key =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(27, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "C = ";
            // 
            // textBox_p
            // 
            this.textBox_p.Location = new System.Drawing.Point(77, 16);
            this.textBox_p.Name = "textBox_p";
            this.textBox_p.Size = new System.Drawing.Size(100, 22);
            this.textBox_p.TabIndex = 3;
            this.textBox_p.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_key
            // 
            this.textBox_key.Location = new System.Drawing.Point(77, 83);
            this.textBox_key.Name = "textBox_key";
            this.textBox_key.Size = new System.Drawing.Size(100, 22);
            this.textBox_key.TabIndex = 4;
            this.textBox_key.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_c
            // 
            this.textBox_c.Location = new System.Drawing.Point(77, 148);
            this.textBox_c.Name = "textBox_c";
            this.textBox_c.Size = new System.Drawing.Size(100, 22);
            this.textBox_c.TabIndex = 5;
            this.textBox_c.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button_xor
            // 
            this.button_xor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_xor.Location = new System.Drawing.Point(102, 207);
            this.button_xor.Name = "button_xor";
            this.button_xor.Size = new System.Drawing.Size(75, 39);
            this.button_xor.TabIndex = 6;
            this.button_xor.Text = "XOR";
            this.button_xor.UseVisualStyleBackColor = true;
            this.button_xor.Click += new System.EventHandler(this.button_xor_Click);
            // 
            // button_clear
            // 
            this.button_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_clear.Location = new System.Drawing.Point(392, 207);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(112, 37);
            this.button_clear.TabIndex = 7;
            this.button_clear.Text = "Прибрати";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // label_p_hex
            // 
            this.label_p_hex.AutoSize = true;
            this.label_p_hex.Location = new System.Drawing.Point(236, 3);
            this.label_p_hex.Name = "label_p_hex";
            this.label_p_hex.Size = new System.Drawing.Size(13, 16);
            this.label_p_hex.TabIndex = 8;
            this.label_p_hex.Text = "x";
            // 
            // label_p_10
            // 
            this.label_p_10.AutoSize = true;
            this.label_p_10.Location = new System.Drawing.Point(236, 19);
            this.label_p_10.Name = "label_p_10";
            this.label_p_10.Size = new System.Drawing.Size(13, 16);
            this.label_p_10.TabIndex = 9;
            this.label_p_10.Text = "x";
            // 
            // label_p_2
            // 
            this.label_p_2.AutoSize = true;
            this.label_p_2.Location = new System.Drawing.Point(236, 35);
            this.label_p_2.Name = "label_p_2";
            this.label_p_2.Size = new System.Drawing.Size(13, 16);
            this.label_p_2.TabIndex = 10;
            this.label_p_2.Text = "x";
            // 
            // label_key_hex
            // 
            this.label_key_hex.AutoSize = true;
            this.label_key_hex.Location = new System.Drawing.Point(239, 65);
            this.label_key_hex.Name = "label_key_hex";
            this.label_key_hex.Size = new System.Drawing.Size(13, 16);
            this.label_key_hex.TabIndex = 11;
            this.label_key_hex.Text = "x";
            // 
            // label_key_10
            // 
            this.label_key_10.AutoSize = true;
            this.label_key_10.Location = new System.Drawing.Point(239, 83);
            this.label_key_10.Name = "label_key_10";
            this.label_key_10.Size = new System.Drawing.Size(13, 16);
            this.label_key_10.TabIndex = 12;
            this.label_key_10.Text = "x";
            // 
            // label_key_2
            // 
            this.label_key_2.AutoSize = true;
            this.label_key_2.Location = new System.Drawing.Point(239, 99);
            this.label_key_2.Name = "label_key_2";
            this.label_key_2.Size = new System.Drawing.Size(13, 16);
            this.label_key_2.TabIndex = 13;
            this.label_key_2.Text = "x";
            // 
            // label_c_hex
            // 
            this.label_c_hex.AutoSize = true;
            this.label_c_hex.Location = new System.Drawing.Point(236, 134);
            this.label_c_hex.Name = "label_c_hex";
            this.label_c_hex.Size = new System.Drawing.Size(13, 16);
            this.label_c_hex.TabIndex = 14;
            this.label_c_hex.Text = "x";
            // 
            // label_c_10
            // 
            this.label_c_10.AutoSize = true;
            this.label_c_10.Location = new System.Drawing.Point(236, 150);
            this.label_c_10.Name = "label_c_10";
            this.label_c_10.Size = new System.Drawing.Size(13, 16);
            this.label_c_10.TabIndex = 15;
            this.label_c_10.Text = "x";
            // 
            // label_c_2
            // 
            this.label_c_2.AutoSize = true;
            this.label_c_2.Location = new System.Drawing.Point(236, 166);
            this.label_c_2.Name = "label_c_2";
            this.label_c_2.Size = new System.Drawing.Size(13, 16);
            this.label_c_2.TabIndex = 16;
            this.label_c_2.Text = "x";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(204, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "hex:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(202, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "dec:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(207, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "bin:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(205, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 16);
            this.label7.TabIndex = 22;
            this.label7.Text = "bin:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(205, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 16);
            this.label8.TabIndex = 21;
            this.label8.Text = "dec:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(207, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 16);
            this.label9.TabIndex = 20;
            this.label9.Text = "hex:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(205, 166);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 16);
            this.label10.TabIndex = 25;
            this.label10.Text = "bin:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(202, 150);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 16);
            this.label11.TabIndex = 24;
            this.label11.Text = "dec:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(204, 134);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 16);
            this.label12.TabIndex = 23;
            this.label12.Text = "hex:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label13.Location = new System.Drawing.Point(509, 20);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 20);
            this.label13.TabIndex = 26;
            this.label13.Text = "= C";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label14.Location = new System.Drawing.Point(509, 85);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 20);
            this.label14.TabIndex = 27;
            this.label14.Text = "= Key";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label15.Location = new System.Drawing.Point(509, 154);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 20);
            this.label15.TabIndex = 28;
            this.label15.Text = "= P";
            // 
            // textBox_c_OUT
            // 
            this.textBox_c_OUT.Location = new System.Drawing.Point(392, 18);
            this.textBox_c_OUT.Name = "textBox_c_OUT";
            this.textBox_c_OUT.Size = new System.Drawing.Size(100, 22);
            this.textBox_c_OUT.TabIndex = 29;
            // 
            // textBox_key_OUT
            // 
            this.textBox_key_OUT.Location = new System.Drawing.Point(392, 83);
            this.textBox_key_OUT.Name = "textBox_key_OUT";
            this.textBox_key_OUT.Size = new System.Drawing.Size(100, 22);
            this.textBox_key_OUT.TabIndex = 30;
            // 
            // textBox_p_OUT
            // 
            this.textBox_p_OUT.Location = new System.Drawing.Point(392, 154);
            this.textBox_p_OUT.Name = "textBox_p_OUT";
            this.textBox_p_OUT.Size = new System.Drawing.Size(100, 22);
            this.textBox_p_OUT.TabIndex = 31;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 313);
            this.Controls.Add(this.textBox_p_OUT);
            this.Controls.Add(this.textBox_key_OUT);
            this.Controls.Add(this.textBox_c_OUT);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label_c_2);
            this.Controls.Add(this.label_c_10);
            this.Controls.Add(this.label_c_hex);
            this.Controls.Add(this.label_key_2);
            this.Controls.Add(this.label_key_10);
            this.Controls.Add(this.label_key_hex);
            this.Controls.Add(this.label_p_2);
            this.Controls.Add(this.label_p_10);
            this.Controls.Add(this.label_p_hex);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.button_xor);
            this.Controls.Add(this.textBox_c);
            this.Controls.Add(this.textBox_key);
            this.Controls.Add(this.textBox_p);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_p;
        private System.Windows.Forms.TextBox textBox_key;
        private System.Windows.Forms.TextBox textBox_c;
        private System.Windows.Forms.Button button_xor;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Label label_p_hex;
        private System.Windows.Forms.Label label_p_10;
        private System.Windows.Forms.Label label_p_2;
        private System.Windows.Forms.Label label_key_hex;
        private System.Windows.Forms.Label label_key_10;
        private System.Windows.Forms.Label label_key_2;
        private System.Windows.Forms.Label label_c_hex;
        private System.Windows.Forms.Label label_c_10;
        private System.Windows.Forms.Label label_c_2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox_c_OUT;
        private System.Windows.Forms.TextBox textBox_key_OUT;
        private System.Windows.Forms.TextBox textBox_p_OUT;
    }
}

