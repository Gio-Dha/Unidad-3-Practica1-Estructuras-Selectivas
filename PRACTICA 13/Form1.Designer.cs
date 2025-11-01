namespace PRACTICA_13
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
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label3 = new Label();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 96);
            label1.Name = "label1";
            label1.Size = new Size(966, 18);
            label1.TabIndex = 0;
            label1.Text = "Dado como dato el sueldo de un trabajador, el programa aplica un aumento del 15% si el sueldo es inferior a 400000\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Adobe Heiti Std R", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(92, 250);
            label2.Name = "label2";
            label2.Size = new Size(113, 19);
            label2.TabIndex = 1;
            label2.Text = "Ingresar sueldo";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(233, 250);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(108, 358);
            button1.Name = "button1";
            button1.Size = new Size(101, 30);
            button1.TabIndex = 3;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(289, 358);
            button2.Name = "button2";
            button2.Size = new Size(113, 30);
            button2.TabIndex = 4;
            button2.Text = "Borrar";
            button2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(82, 468);
            label3.Name = "label3";
            label3.Size = new Size(106, 21);
            label3.TabIndex = 5;
            label3.Text = "Nuevo sueldo";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(223, 466);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(989, 666);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
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
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Label label3;
        private TextBox textBox2;
    }
}