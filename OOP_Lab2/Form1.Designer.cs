namespace OOP_Lab2
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
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(236, 197);
            label1.Name = "label1";
            label1.Size = new Size(19, 20);
            label1.TabIndex = 0;
            label1.Text = "A";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(354, 197);
            label2.Name = "label2";
            label2.Size = new Size(18, 20);
            label2.TabIndex = 1;
            label2.Text = "B";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(482, 197);
            label3.Name = "label3";
            label3.Size = new Size(18, 20);
            label3.TabIndex = 2;
            label3.Text = "C";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(261, 194);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(63, 27);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(378, 194);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(63, 27);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(506, 194);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(63, 27);
            textBox3.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(327, 121);
            label4.Name = "label4";
            label4.Size = new Size(127, 20);
            label4.TabIndex = 6;
            label4.Text = "ax^2 + bx + c = 0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(372, 324);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(327, 254);
            button1.Name = "button1";
            button1.Size = new Size(114, 31);
            button1.TabIndex = 8;
            button1.Text = "Send";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label4;
        private Label label5;
        private Button button1;
    }
}