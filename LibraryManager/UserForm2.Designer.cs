namespace LibraryManager
{
    partial class UserForm2
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
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Brown;
            panel1.Controls.Add(label2);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1098, 76);
            panel1.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("StempelGaramond Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(50, 8);
            label2.Name = "label2";
            label2.Size = new Size(321, 42);
            label2.TabIndex = 5;
            label2.Text = "Manchester Library";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("StempelGaramond Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(99, 128);
            label1.Name = "label1";
            label1.Size = new Size(155, 42);
            label1.TabIndex = 6;
            label1.Text = "Authors:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("StempelGaramond Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(600, 128);
            label3.Name = "label3";
            label3.Size = new Size(120, 42);
            label3.TabIndex = 9;
            label3.Text = "Books:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Ivan Vazov", "Nikola Vaptsarov", "Viktor Ugo", "Hristo Smirnenski", "Dimcho Debelqnov", "Aleko Konstantinov", "Willieam Shakespeare", "Peyo Yavorov" });
            comboBox1.Location = new Point(260, 139);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(223, 31);
            comboBox1.TabIndex = 10;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Pod Igoto", "Motorni Pesni", "Kletnici", "Da bude den!", "Bai Ganio", "Hamlet", "Bezsunici", "Spi gradut" });
            comboBox2.Location = new Point(745, 139);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(223, 31);
            comboBox2.TabIndex = 11;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold);
            textBox1.Location = new Point(252, 303);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(195, 34);
            textBox1.TabIndex = 12;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold);
            textBox2.Location = new Point(701, 303);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(195, 34);
            textBox2.TabIndex = 13;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold);
            textBox3.Location = new Point(354, 398);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(195, 34);
            textBox3.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("StempelGaramond Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(84, 291);
            label4.Name = "label4";
            label4.Size = new Size(132, 42);
            label4.TabIndex = 15;
            label4.Text = "Names:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("StempelGaramond Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(533, 292);
            label5.Name = "label5";
            label5.Size = new Size(128, 42);
            label5.TabIndex = 16;
            label5.Text = "Adress:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("StempelGaramond Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(85, 386);
            label6.Name = "label6";
            label6.Size = new Size(263, 42);
            label6.TabIndex = 17;
            label6.Text = "Phone Number:";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Symbol", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(731, 432);
            button1.Name = "button1";
            button1.Size = new Size(152, 59);
            button1.TabIndex = 18;
            button1.Text = "Order";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // UserForm2
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BurlyWood;
            ClientSize = new Size(1005, 566);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(panel1);
            Font = new Font("Segoe UI Historic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UserForm2";
            Text = "UserForm2";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private Label label3;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button1;
    }
}