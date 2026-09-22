namespace coursework_progect1
{
    partial class Тест
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
            button1 = new Button();
            label1 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            button2 = new Button();
            radioButton5 = new RadioButton();
            label3 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.Location = new Point(1232, 479);
            button1.Name = "button1";
            button1.Size = new Size(192, 64);
            button1.TabIndex = 1;
            button1.Text = "Ответить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(60, 55);
            label1.Name = "label1";
            label1.Size = new Size(95, 32);
            label1.TabIndex = 2;
            label1.Text = "Вопрос";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Segoe UI", 14F);
            radioButton1.Location = new Point(60, 186);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(224, 36);
            radioButton1.TabIndex = 3;
            radioButton1.TabStop = true;
            radioButton1.Text = "Вариант ответа 1";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Segoe UI", 14F);
            radioButton2.Location = new Point(60, 239);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(224, 36);
            radioButton2.TabIndex = 4;
            radioButton2.TabStop = true;
            radioButton2.Text = "Вариант ответа 2";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Font = new Font("Segoe UI", 14F);
            radioButton3.Location = new Point(60, 295);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(224, 36);
            radioButton3.TabIndex = 5;
            radioButton3.TabStop = true;
            radioButton3.Text = "Вариант ответа 3";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Font = new Font("Segoe UI", 14F);
            radioButton4.Location = new Point(60, 355);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(224, 36);
            radioButton4.TabIndex = 6;
            radioButton4.TabStop = true;
            radioButton4.Text = "Вариант ответа 4";
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 19F);
            button2.Location = new Point(1232, 398);
            button2.Name = "button2";
            button2.Size = new Size(192, 64);
            button2.TabIndex = 8;
            button2.Text = "Завершить";
            button2.UseVisualStyleBackColor = true;
            button2.Visible = false;
            button2.Click += button2_Click;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Font = new Font("Segoe UI", 14F);
            radioButton5.Location = new Point(60, 416);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(159, 36);
            radioButton5.TabIndex = 9;
            radioButton5.TabStop = true;
            radioButton5.Text = "Без ответа ";
            radioButton5.UseVisualStyleBackColor = true;
            radioButton5.CheckedChanged += radioButton5_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 19F);
            label3.Location = new Point(467, 186);
            label3.Name = "label3";
            label3.Size = new Size(159, 45);
            label3.TabIndex = 10;
            label3.Text = "Результат";
            label3.Visible = false;
            // 
            // Тест
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1490, 580);
            Controls.Add(label3);
            Controls.Add(radioButton5);
            Controls.Add(button2);
            Controls.Add(radioButton4);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label1);
            Controls.Add(button1);
            ForeColor = SystemColors.ControlText;
            Name = "Тест";
            RightToLeft = RightToLeft.No;
            Text = "Тест";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Label label1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private Button button2;
        private RadioButton radioButton5;
        private Label label3;
    }
}
