namespace LibraryManager
{
    partial class ManagerForm2
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
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label1 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            button5 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Brown;
            panel1.Controls.Add(label2);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(879, 66);
            panel1.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("StempelGaramond Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(40, 7);
            label2.Name = "label2";
            label2.Size = new Size(321, 42);
            label2.TabIndex = 5;
            label2.Text = "Manchester Library";
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button4.Location = new Point(434, 141);
            button4.Name = "button4";
            button4.Size = new Size(136, 50);
            button4.TabIndex = 25;
            button4.Text = "Save";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button3.Location = new Point(255, 141);
            button3.Name = "button3";
            button3.Size = new Size(135, 50);
            button3.TabIndex = 24;
            button3.Text = "Edit";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button2.Location = new Point(649, 145);
            button2.Name = "button2";
            button2.Size = new Size(154, 46);
            button2.TabIndex = 23;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.Location = new Point(63, 141);
            button1.Name = "button1";
            button1.Size = new Size(144, 50);
            button1.TabIndex = 22;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(201, 230);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(434, 227);
            dataGridView1.TabIndex = 21;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            textBox3.Location = new Point(713, 86);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(120, 34);
            textBox3.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.ForeColor = SystemColors.Window;
            label3.Location = new Point(576, 86);
            label3.Name = "label3";
            label3.Size = new Size(133, 28);
            label3.TabIndex = 19;
            label3.Text = "Employee Id:";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            textBox2.Location = new Point(449, 86);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(121, 34);
            textBox2.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(296, 82);
            label1.Name = "label1";
            label1.Size = new Size(147, 28);
            label1.TabIndex = 17;
            label1.Text = "Second Name:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            textBox1.Location = new Point(149, 82);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(133, 34);
            textBox1.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.ForeColor = SystemColors.Window;
            label4.Location = new Point(28, 82);
            label4.Name = "label4";
            label4.Size = new Size(120, 28);
            label4.TabIndex = 15;
            label4.Text = "First Name:";
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI Variable Display", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button5.Location = new Point(704, 409);
            button5.Name = "button5";
            button5.Size = new Size(167, 48);
            button5.TabIndex = 6;
            button5.Text = "Book Storage";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // ManagerForm2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BurlyWood;
            ClientSize = new Size(883, 469);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(panel1);
            Name = "ManagerForm2";
            Text = "ManagerForm2";
            Load += ManagerForm2_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private DataGridView dataGridView1;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox2;
        private Label label1;
        private TextBox textBox1;
        private Label label4;
        private Button button5;
    }
}