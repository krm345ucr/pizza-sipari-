namespace checkbox
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
            label1 = new Label();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox5 = new CheckBox();
            checkBox6 = new CheckBox();
            checkBox7 = new CheckBox();
            checkBox8 = new CheckBox();
            button1 = new Button();
            textBox1 = new TextBox();
            label2 = new Label();
            groupBox1 = new GroupBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 91);
            label1.Name = "label1";
            label1.Size = new Size(777, 20);
            label1.TabIndex = 0;
            label1.Text = "ek malzeme olmaksızın sadece peynir soslu pizza ücreti 75 tl.aşağıda istedğiniz malzemeleri seçip fiyatı hesaplayınız";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(45, 142);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(115, 24);
            checkBox1.TabIndex = 1;
            checkBox1.Text = "zeytin(15 TL)";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(45, 172);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(112, 24);
            checkBox2.TabIndex = 2;
            checkBox2.Text = "sucuk(20 TL)";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(45, 202);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(134, 24);
            checkBox3.TabIndex = 3;
            checkBox3.Text = "domates(15 TL)";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(45, 232);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(123, 24);
            checkBox4.TabIndex = 4;
            checkBox4.Text = "mantar(25 TL)";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(45, 262);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(110, 24);
            checkBox5.TabIndex = 5;
            checkBox5.Text = "kaşar(30 TL)";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Location = new Point(45, 322);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(144, 24);
            checkBox6.TabIndex = 6;
            checkBox6.Text = "yeşil biber(20 TL)";
            checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            checkBox7.AutoSize = true;
            checkBox7.Location = new Point(45, 292);
            checkBox7.Name = "checkBox7";
            checkBox7.Size = new Size(108, 24);
            checkBox7.TabIndex = 7;
            checkBox7.Text = "mısır(10 TL)";
            checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            checkBox8.AutoSize = true;
            checkBox8.Location = new Point(45, 352);
            checkBox8.Name = "checkBox8";
            checkBox8.Size = new Size(159, 24);
            checkBox8.TabIndex = 8;
            checkBox8.Text = "kırmızı biber(20 TL)";
            checkBox8.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(45, 412);
            button1.Name = "button1";
            button1.Size = new Size(180, 29);
            button1.TabIndex = 9;
            button1.Text = "HESAPLA";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(258, 414);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(389, 417);
            label2.Name = "label2";
            label2.Size = new Size(24, 20);
            label2.TabIndex = 11;
            label2.Text = "TL";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(258, 142);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 125);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Hamur Seçiniz";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(23, 89);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(118, 24);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "tam buğdaylı";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(23, 30);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(77, 24);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "normal";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1117, 511);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(checkBox1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(checkBox8);
            Controls.Add(checkBox7);
            Controls.Add(checkBox6);
            Controls.Add(checkBox5);
            Controls.Add(checkBox4);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private CheckBox checkBox5;
        private CheckBox checkBox6;
        private CheckBox checkBox7;
        private CheckBox checkBox8;
        private Button button1;
        private TextBox textBox1;
        private Label label2;
        private GroupBox groupBox1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
    }
}
