namespace LibraryManager
{
    partial class BookStorage
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
            label4 = new Label();
            label1 = new Label();
            label3 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Brown;
            panel1.Controls.Add(label2);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(904, 66);
            panel1.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("StempelGaramond Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(70, 10);
            label2.Name = "label2";
            label2.Size = new Size(321, 42);
            label2.TabIndex = 5;
            label2.Text = "Manchester Library";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label4.ForeColor = SystemColors.Window;
            label4.Location = new Point(91, 157);
            label4.Name = "label4";
            label4.Size = new Size(77, 31);
            label4.TabIndex = 16;
            label4.Text = "Book:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(82, 87);
            label1.Name = "label1";
            label1.Size = new Size(97, 31);
            label1.TabIndex = 17;
            label1.Text = "Author:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label3.ForeColor = SystemColors.Window;
            label3.Location = new Point(469, 87);
            label3.Name = "label3";
            label3.Size = new Size(66, 31);
            label3.TabIndex = 18;
            label3.Text = "Year:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label5.ForeColor = SystemColors.Window;
            label5.Location = new Point(469, 167);
            label5.Name = "label5";
            label5.Size = new Size(73, 31);
            label5.TabIndex = 19;
            label5.Text = "Price:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox1.Location = new Point(198, 91);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(193, 34);
            textBox1.TabIndex = 20;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox2.Location = new Point(198, 161);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(193, 34);
            textBox2.TabIndex = 21;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 12F);
            textBox3.Location = new Point(553, 87);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(161, 34);
            textBox3.TabIndex = 22;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 12F);
            textBox4.Location = new Point(553, 171);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(161, 34);
            textBox4.TabIndex = 23;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            button1.Location = new Point(58, 232);
            button1.Name = "button1";
            button1.Size = new Size(97, 42);
            button1.TabIndex = 24;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            button2.Location = new Point(265, 232);
            button2.Name = "button2";
            button2.Size = new Size(97, 42);
            button2.TabIndex = 25;
            button2.Text = "Edit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            button3.Location = new Point(445, 232);
            button3.Name = "button3";
            button3.Size = new Size(97, 42);
            button3.TabIndex = 26;
            button3.Text = "Save";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            button4.Location = new Point(617, 232);
            button4.Name = "button4";
            button4.Size = new Size(97, 42);
            button4.TabIndex = 27;
            button4.Text = "Delete";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(148, 291);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(566, 227);
            dataGridView1.TabIndex = 28;
            // 
            // BookStorage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BurlyWood;
            ClientSize = new Size(906, 530);
            Controls.Add(dataGridView1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(panel1);
            Name = "BookStorage";
            Text = "BookStorage";
            Load += BookStorage_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label4;
        private Label label1;
        private Label label3;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private DataGridView dataGridView1;
    }
}