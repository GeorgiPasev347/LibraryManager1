namespace LibraryManager
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
            button1 = new Button();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("StempelGaramond Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(454, 129);
            label1.Name = "label1";
            label1.Size = new Size(157, 42);
            label1.TabIndex = 0;
            label1.Text = "Login as:";
            // 
            // button1
            // 
            button1.Font = new Font("StempelGaramond Roman", 18F, FontStyle.Bold);
            button1.Location = new Point(388, 206);
            button1.Name = "button1";
            button1.Size = new Size(106, 57);
            button1.TabIndex = 1;
            button1.Text = "User";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("StempelGaramond Roman", 18F, FontStyle.Bold);
            button2.Location = new Point(534, 206);
            button2.Name = "button2";
            button2.Size = new Size(149, 57);
            button2.TabIndex = 2;
            button2.Text = "Manager";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.libraryy;
            pictureBox1.Location = new Point(2, 67);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(328, 353);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Brown;
            panel1.Controls.Add(label2);
            panel1.Location = new Point(3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(733, 67);
            panel1.TabIndex = 4;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BurlyWood;
            ClientSize = new Size(734, 418);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label2;
    }
}
