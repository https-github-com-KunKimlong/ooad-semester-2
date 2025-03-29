namespace PetShop
{
    partial class CreatePetFrm
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
            txt_name = new TextBox();
            label3 = new Label();
            rbMale = new RadioButton();
            rbFemale = new RadioButton();
            panel1 = new Panel();
            label4 = new Label();
            label5 = new Label();
            dateTimePicker1 = new DateTimePicker();
            price = new TextBox();
            label6 = new Label();
            label7 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            label8 = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(192, 32);
            label1.Name = "label1";
            label1.Size = new Size(292, 42);
            label1.TabIndex = 0;
            label1.Text = "From Create Pet";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 13.8F);
            label2.Location = new Point(40, 131);
            label2.Name = "label2";
            label2.Size = new Size(78, 29);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // txt_name
            // 
            txt_name.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_name.Location = new Point(206, 118);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(242, 42);
            txt_name.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 13.8F);
            label3.Location = new Point(40, 194);
            label3.Name = "label3";
            label3.Size = new Size(94, 29);
            label3.TabIndex = 3;
            label3.Text = "Gender";
            // 
            // rbMale
            // 
            rbMale.AutoSize = true;
            rbMale.Checked = true;
            rbMale.FlatStyle = FlatStyle.System;
            rbMale.Font = new Font("Times New Roman", 16.2F);
            rbMale.Location = new Point(2, 9);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(102, 38);
            rbMale.TabIndex = 4;
            rbMale.TabStop = true;
            rbMale.Text = "Male";
            rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            rbFemale.AutoSize = true;
            rbFemale.FlatStyle = FlatStyle.System;
            rbFemale.Font = new Font("Times New Roman", 16.2F);
            rbFemale.Location = new Point(117, 9);
            rbFemale.Name = "rbFemale";
            rbFemale.Size = new Size(125, 38);
            rbFemale.TabIndex = 5;
            rbFemale.Text = "Female";
            rbFemale.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(rbFemale);
            panel1.Controls.Add(rbMale);
            panel1.Location = new Point(208, 173);
            panel1.Name = "panel1";
            panel1.Size = new Size(240, 50);
            panel1.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 13.8F);
            label4.Location = new Point(46, 327);
            label4.Name = "label4";
            label4.Size = new Size(0, 29);
            label4.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 13.8F);
            label5.Location = new Point(40, 246);
            label5.Name = "label5";
            label5.Size = new Size(149, 29);
            label5.TabIndex = 9;
            label5.Text = "On sale date";
            label5.Click += label5_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Times New Roman", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(206, 239);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(242, 39);
            dateTimePicker1.TabIndex = 10;
            // 
            // price
            // 
            price.Font = new Font("Microsoft Sans Serif", 16.2F);
            price.Location = new Point(647, 109);
            price.Name = "price";
            price.Size = new Size(242, 38);
            price.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 13.8F);
            label6.Location = new Point(479, 131);
            label6.Name = "label6";
            label6.Size = new Size(69, 29);
            label6.TabIndex = 11;
            label6.Text = "Price";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 13.8F);
            label7.Location = new Point(479, 189);
            label7.Name = "label7";
            label7.Size = new Size(106, 29);
            label7.TabIndex = 13;
            label7.Text = "Discount";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Microsoft Sans Serif", 16.2F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "5", "10", "15", "20", "30", "50" });
            comboBox1.Location = new Point(647, 172);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(242, 39);
            comboBox1.TabIndex = 14;
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Microsoft Sans Serif", 16.2F);
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "None", "Khmer New Years", "Pchum Ben Festival", "Water Festival" });
            comboBox2.Location = new Point(647, 230);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(242, 39);
            comboBox2.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 13.8F);
            label8.Location = new Point(479, 243);
            label8.Name = "label8";
            label8.Size = new Size(172, 29);
            label8.TabIndex = 15;
            label8.Text = "Discount Event";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.weebly;
            pictureBox1.Location = new Point(52, 327);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(227, 212);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Pink;
            button1.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(58, 559);
            button1.Name = "button1";
            button1.Size = new Size(217, 57);
            button1.TabIndex = 18;
            button1.Text = "Choose Image";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(254, 47, 8);
            button2.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(387, 405);
            button2.Name = "button2";
            button2.Size = new Size(198, 57);
            button2.TabIndex = 19;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(234, 221, 1);
            button3.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(636, 405);
            button3.Name = "button3";
            button3.Size = new Size(198, 57);
            button3.TabIndex = 20;
            button3.Text = "Save";
            button3.UseVisualStyleBackColor = false;
            // 
            // CreatePetFrm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(912, 639);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(comboBox2);
            Controls.Add(label8);
            Controls.Add(comboBox1);
            Controls.Add(label7);
            Controls.Add(price);
            Controls.Add(label6);
            Controls.Add(dateTimePicker1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(txt_name);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CreatePetFrm";
            Text = "CreatePetFrm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txt_name;
        private Label label3;
        private RadioButton rbMale;
        private RadioButton rbFemale;
        private Panel panel1;
        private Label label4;
        private Label label5;
        private DateTimePicker dateTimePicker1;
        private TextBox price;
        private Label label6;
        private Label label7;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label8;
        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}