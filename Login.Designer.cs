namespace PetShop
{
    partial class Login
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
            label1 = new Label();
            label2 = new Label();
            txt_email = new TextBox();
            txt_pass = new TextBox();
            label3 = new Label();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 22.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(452, 56);
            label1.Name = "label1";
            label1.Size = new Size(159, 42);
            label1.TabIndex = 1;
            label1.Text = "Pet Shop";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(412, 147);
            label2.Name = "label2";
            label2.Size = new Size(91, 34);
            label2.TabIndex = 3;
            label2.Text = "Email:";
            // 
            // txt_email
            // 
            txt_email.BackColor = Color.Silver;
            txt_email.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            txt_email.Location = new Point(412, 184);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(342, 45);
            txt_email.TabIndex = 4;
            // 
            // txt_pass
            // 
            txt_pass.BackColor = Color.Silver;
            txt_pass.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            txt_pass.Location = new Point(412, 280);
            txt_pass.Name = "txt_pass";
            txt_pass.Size = new Size(342, 45);
            txt_pass.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(412, 243);
            label3.Name = "label3";
            label3.Size = new Size(136, 34);
            label3.TabIndex = 5;
            label3.Text = "Password:";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 134, 134);
            button1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(511, 356);
            button1.Name = "button1";
            button1.Size = new Size(152, 48);
            button1.TabIndex = 7;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.img;
            pictureBox1.Location = new Point(0, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(388, 475);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(781, 477);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(txt_pass);
            Controls.Add(label3);
            Controls.Add(txt_email);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private TextBox txt_email;
        private TextBox txt_pass;
        private Label label3;
        private Button button1;
        private PictureBox pictureBox1;
    }
}