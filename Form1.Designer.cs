namespace WinFormsApp_alg_lab_2
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
            textBox1 = new TextBox();
            label2 = new Label();
            button1 = new Button();
            labelresult = new Label();
            label1 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.Location = new Point(40, 140);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(247, 23);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(40, 113);
            label2.Name = "label2";
            label2.Size = new Size(211, 24);
            label2.TabIndex = 2;
            label2.Text = "Введите ваше число:";
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.ForeColor = Color.Red;
            button1.Location = new Point(40, 196);
            button1.Name = "button1";
            button1.Size = new Size(247, 54);
            button1.TabIndex = 15;
            button1.Text = "РАССЧИТАТЬ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // labelresult
            // 
            labelresult.AutoSize = true;
            labelresult.BackColor = Color.Transparent;
            labelresult.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelresult.ForeColor = Color.Red;
            labelresult.Location = new Point(325, 111);
            labelresult.Name = "labelresult";
            labelresult.Size = new Size(304, 24);
            labelresult.TabIndex = 16;
            labelresult.Tag = "";
            labelresult.Text = "Результаты будут здесь и ниже:";
            labelresult.Click += labelresult_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 36F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(99, 21);
            label1.Name = "label1";
            label1.Size = new Size(418, 55);
            label1.TabIndex = 0;
            label1.Text = "АНАЛИЗ ЧИСЛА";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonHighlight;
            button2.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button2.ForeColor = Color.Red;
            button2.Location = new Point(40, 352);
            button2.Name = "button2";
            button2.Size = new Size(247, 41);
            button2.TabIndex = 17;
            button2.Text = "Помощь, формулировка";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(641, 461);
            Controls.Add(button2);
            Controls.Add(labelresult);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Ulitka soft lab1.1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox1;
        private Label label2;
        private Button button1;
        private Label labelresult;
        private Label label1;
        private Button button2;
    }
}
