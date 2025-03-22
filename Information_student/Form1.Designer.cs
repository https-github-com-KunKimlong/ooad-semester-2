namespace Information_student
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
            txtName = new TextBox();
            txtSSN = new TextBox();
            label2 = new Label();
            txtMidterm = new TextBox();
            label3 = new Label();
            txtFinal = new TextBox();
            label4 = new Label();
            btnEnter = new Button();
            btnDisplay = new Button();
            btnQuit = new Button();
            lstGrades = new ListView();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 42);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // txtName
            // 
            txtName.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(81, 42);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(658, 26);
            txtName.TabIndex = 1;
            // 
            // txtSSN
            // 
            txtSSN.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtSSN.Location = new Point(81, 132);
            txtSSN.Margin = new Padding(3, 4, 3, 4);
            txtSSN.Name = "txtSSN";
            txtSSN.Size = new Size(156, 26);
            txtSSN.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 136);
            label2.Name = "label2";
            label2.Size = new Size(43, 20);
            label2.TabIndex = 2;
            label2.Text = "SSN";
            // 
            // txtMidterm
            // 
            txtMidterm.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtMidterm.Location = new Point(322, 132);
            txtMidterm.Margin = new Padding(3, 4, 3, 4);
            txtMidterm.Name = "txtMidterm";
            txtMidterm.Size = new Size(177, 26);
            txtMidterm.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(246, 140);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 4;
            label3.Text = "Midterm";
            // 
            // txtFinal
            // 
            txtFinal.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtFinal.Location = new Point(562, 132);
            txtFinal.Margin = new Padding(3, 4, 3, 4);
            txtFinal.Name = "txtFinal";
            txtFinal.Size = new Size(177, 26);
            txtFinal.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(508, 136);
            label4.Name = "label4";
            label4.Size = new Size(45, 20);
            label4.TabIndex = 6;
            label4.Text = "Final";
            // 
            // btnEnter
            // 
            btnEnter.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnEnter.Location = new Point(54, 239);
            btnEnter.Margin = new Padding(3, 4, 3, 4);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(183, 55);
            btnEnter.TabIndex = 8;
            btnEnter.Text = "Enter Information";
            btnEnter.UseVisualStyleBackColor = true;
            btnEnter.Click += btnEnter_Click;
            // 
            // btnDisplay
            // 
            btnDisplay.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnDisplay.Location = new Point(268, 239);
            btnDisplay.Margin = new Padding(3, 4, 3, 4);
            btnDisplay.Name = "btnDisplay";
            btnDisplay.Size = new Size(183, 55);
            btnDisplay.TabIndex = 9;
            btnDisplay.Text = "Display Grade";
            btnDisplay.UseVisualStyleBackColor = true;
            btnDisplay.Click += btnDisplay_Click;
            // 
            // btnQuit
            // 
            btnQuit.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnQuit.Location = new Point(494, 239);
            btnQuit.Margin = new Padding(3, 4, 3, 4);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(183, 55);
            btnQuit.TabIndex = 10;
            btnQuit.Text = "Quit";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click;
            // 
            // lstGrades
            // 
            lstGrades.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lstGrades.Location = new Point(54, 321);
            lstGrades.Margin = new Padding(3, 4, 3, 4);
            lstGrades.Name = "lstGrades";
            lstGrades.Size = new Size(685, 198);
            lstGrades.TabIndex = 11;
            lstGrades.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 562);
            Controls.Add(lstGrades);
            Controls.Add(btnQuit);
            Controls.Add(btnDisplay);
            Controls.Add(btnEnter);
            Controls.Add(txtFinal);
            Controls.Add(label4);
            Controls.Add(txtMidterm);
            Controls.Add(label3);
            Controls.Add(txtSSN);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSSN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMidterm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFinal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.ListView lstGrades;


    }
}
