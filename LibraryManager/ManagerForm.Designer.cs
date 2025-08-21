namespace LibraryManager
{
    partial class ManagerForm
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
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Brown;
            panel1.Controls.Add(label2);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(794, 66);
            panel1.TabIndex = 5;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("StempelGaramond Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(112, 102);
            label1.Name = "label1";
            label1.Size = new Size(389, 42);
            label1.TabIndex = 6;
            label1.Text = "Enter admin credentials:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("StempelGaramond Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(66, 177);
            label3.Name = "label3";
            label3.Size = new Size(119, 42);
            label3.TabIndex = 7;
            label3.Text = "Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("StempelGaramond Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(15, 259);
            label4.Name = "label4";
            label4.Size = new Size(170, 42);
            label4.TabIndex = 8;
            label4.Text = "Password:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            textBox1.Location = new Point(220, 176);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(259, 38);
            textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            textBox2.Location = new Point(220, 274);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(259, 38);
            textBox2.TabIndex = 10;
            // 
            // button1
            // 
            button1.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(198, 353);
            button1.Name = "button1";
            button1.Size = new Size(163, 52);
            button1.TabIndex = 11;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ManagerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BurlyWood;
            ClientSize = new Size(557, 450);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(panel1);
            ForeColor = SystemColors.ControlDark;
            Name = "ManagerForm";
            Text = "ManagerForm";
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
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
    }
}