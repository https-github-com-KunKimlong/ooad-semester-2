namespace PetShop
{
    partial class RegisterEmployeeFrm
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
            em_name = new Label();
            email = new TextBox();
            em_gender = new Label();
            textBox3 = new TextBox();
            em_phone = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            btn_cancel = new Button();
            btn_create = new Button();
            em_male = new RadioButton();
            em_female = new RadioButton();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(134, 41);
            label1.Name = "label1";
            label1.Size = new Size(328, 46);
            label1.TabIndex = 0;
            label1.Text = "Create Employee";
            // 
            // em_name
            // 
            em_name.AutoSize = true;
            em_name.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            em_name.Location = new Point(78, 145);
            em_name.Name = "em_name";
            em_name.Size = new Size(78, 29);
            em_name.TabIndex = 1;
            em_name.Text = "Name";
            // 
            // email
            // 
            email.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            email.Location = new Point(218, 140);
            email.Name = "email";
            email.Size = new Size(305, 34);
            email.TabIndex = 2;
            // 
            // em_gender
            // 
            em_gender.AutoSize = true;
            em_gender.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            em_gender.Location = new Point(62, 192);
            em_gender.Name = "em_gender";
            em_gender.Size = new Size(94, 29);
            em_gender.TabIndex = 3;
            em_gender.Text = "Gender";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(218, 247);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(305, 34);
            textBox3.TabIndex = 6;
            // 
            // em_phone
            // 
            em_phone.AutoSize = true;
            em_phone.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            em_phone.Location = new Point(73, 247);
            em_phone.Name = "em_phone";
            em_phone.Size = new Size(83, 29);
            em_phone.TabIndex = 5;
            em_phone.Text = "Phone";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(218, 306);
            textBox1.Name = "textBox1";
            textBox1.PasswordChar = '*';
            textBox1.Size = new Size(305, 34);
            textBox1.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(62, 306);
            label2.Name = "label2";
            label2.Size = new Size(120, 29);
            label2.TabIndex = 9;
            label2.Text = "Password";
            // 
            // btn_cancel
            // 
            btn_cancel.BackColor = Color.Red;
            btn_cancel.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold);
            btn_cancel.Location = new Point(78, 386);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(170, 45);
            btn_cancel.TabIndex = 11;
            btn_cancel.Text = "Cancel";
            btn_cancel.UseVisualStyleBackColor = false;
            // 
            // btn_create
            // 
            btn_create.BackColor = Color.Gold;
            btn_create.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold);
            btn_create.Location = new Point(292, 386);
            btn_create.Name = "btn_create";
            btn_create.Size = new Size(170, 45);
            btn_create.TabIndex = 12;
            btn_create.Text = "Create";
            btn_create.UseVisualStyleBackColor = false;
            // 
            // em_male
            // 
            em_male.AutoSize = true;
            em_male.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            em_male.Location = new Point(3, 5);
            em_male.Name = "em_male";
            em_male.Size = new Size(97, 36);
            em_male.TabIndex = 7;
            em_male.Text = "Male";
            em_male.UseVisualStyleBackColor = true;
            // 
            // em_female
            // 
            em_female.AutoSize = true;
            em_female.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            em_female.Location = new Point(167, 5);
            em_female.Name = "em_female";
            em_female.Size = new Size(130, 36);
            em_female.TabIndex = 8;
            em_female.Text = "Female";
            em_female.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(em_female);
            panel1.Controls.Add(em_male);
            panel1.Location = new Point(218, 187);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 50);
            panel1.TabIndex = 13;
            // 
            // RegisterEmployeeFrm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 471);
            Controls.Add(panel1);
            Controls.Add(btn_create);
            Controls.Add(btn_cancel);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(textBox3);
            Controls.Add(em_phone);
            Controls.Add(em_gender);
            Controls.Add(email);
            Controls.Add(em_name);
            Controls.Add(label1);
            Name = "RegisterEmployeeFrm";
            Text = "RegisterEmployeeFrm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label em_name;
        private TextBox email;
        private TextBox textBox2;
        private Label em_gender;
        private TextBox textBox3;
        private Label em_phone;
        private TextBox textBox1;
        private Label label2;
        private Button btn_cancel;
        private Button btn_create;
        private RadioButton em_male;
        private RadioButton em_female;
        private Panel panel1;
    }
}