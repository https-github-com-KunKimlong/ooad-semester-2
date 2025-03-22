namespace PetShop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            btn_logout = new Button();
            animal = new Label();
            accessories = new Label();
            food = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = Properties.Resources.pet_shop_logo_vector;
            pictureBox1.Location = new Point(64, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(159, 163);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 24F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(280, 72);
            label1.Name = "label1";
            label1.Size = new Size(170, 45);
            label1.TabIndex = 2;
            label1.Text = "Pet Shop";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, -8);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(207, 197);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.assessories;
            pictureBox3.Location = new Point(0, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(199, 184);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.foods;
            pictureBox4.Location = new Point(0, 0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(193, 184);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 5;
            pictureBox4.TabStop = false;
            // 
            // btn_logout
            // 
            btn_logout.BackColor = Color.FromArgb(255, 134, 134);
            btn_logout.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btn_logout.Location = new Point(563, 532);
            btn_logout.Name = "btn_logout";
            btn_logout.Size = new Size(193, 56);
            btn_logout.TabIndex = 6;
            btn_logout.Text = "Logout";
            btn_logout.UseVisualStyleBackColor = false;
            // 
            // animal
            // 
            animal.AutoSize = true;
            animal.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            animal.Location = new Point(55, 197);
            animal.Name = "animal";
            animal.Size = new Size(101, 34);
            animal.TabIndex = 7;
            animal.Text = "Animal";
            // 
            // accessories
            // 
            accessories.AutoSize = true;
            accessories.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            accessories.Location = new Point(27, 195);
            accessories.Name = "accessories";
            accessories.Size = new Size(153, 34);
            accessories.TabIndex = 8;
            accessories.Text = "Accessories";
            // 
            // food
            // 
            food.AutoSize = true;
            food.BackColor = Color.FromArgb(255, 134, 134);
            food.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            food.Location = new Point(54, 193);
            food.Name = "food";
            food.Size = new Size(77, 34);
            food.TabIndex = 9;
            food.Text = "Food";
            food.Click += label4_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 134, 134);
            panel1.Controls.Add(animal);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(54, 244);
            panel1.Name = "panel1";
            panel1.Size = new Size(207, 238);
            panel1.TabIndex = 10;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 134, 134);
            panel2.Controls.Add(accessories);
            panel2.Controls.Add(pictureBox3);
            panel2.Location = new Point(312, 244);
            panel2.Name = "panel2";
            panel2.Size = new Size(199, 239);
            panel2.TabIndex = 11;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(255, 134, 134);
            panel3.Controls.Add(food);
            panel3.Controls.Add(pictureBox4);
            panel3.Location = new Point(563, 244);
            panel3.Name = "panel3";
            panel3.Size = new Size(193, 238);
            panel3.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(779, 606);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btn_logout);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Button btn_logout;
        private Label animal;
        private Label accessories;
        private Label food;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
    }
}
