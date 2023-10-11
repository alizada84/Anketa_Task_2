namespace Anketa_2
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
            panel1 = new Panel();
            btnAdd = new Button();
            btnChange = new Button();
            labelBirthYear = new Label();
            textBox5 = new TextBox();
            labelPhone = new Label();
            textBox4 = new TextBox();
            labelEmail = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            labelSurname = new Label();
            textBox1 = new TextBox();
            labelName = new Label();
            labelAnket = new Label();
            listBox1 = new ListBox();
            panel2 = new Panel();
            labelListBox = new Label();
            textBox6 = new TextBox();
            btnLoad = new Button();
            btnSave = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(btnChange);
            panel1.Controls.Add(labelBirthYear);
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(labelPhone);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(labelEmail);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(labelSurname);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(labelName);
            panel1.Location = new Point(12, 30);
            panel1.Name = "panel1";
            panel1.Size = new Size(463, 460);
            panel1.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(192, 192, 0);
            btnAdd.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.Location = new Point(327, 398);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 35);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnChange
            // 
            btnChange.BackColor = Color.FromArgb(128, 128, 255);
            btnChange.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnChange.Location = new Point(327, 339);
            btnChange.Name = "btnChange";
            btnChange.Size = new Size(100, 35);
            btnChange.TabIndex = 6;
            btnChange.Text = "Change";
            btnChange.UseVisualStyleBackColor = false;
            btnChange.Click += btnChange_Click;
            // 
            // labelBirthYear
            // 
            labelBirthYear.AutoSize = true;
            labelBirthYear.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelBirthYear.Location = new Point(6, 266);
            labelBirthYear.Name = "labelBirthYear";
            labelBirthYear.Size = new Size(98, 28);
            labelBirthYear.TabIndex = 6;
            labelBirthYear.Text = "BirthYear";
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textBox5.Location = new Point(139, 266);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(277, 27);
            textBox5.TabIndex = 5;
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelPhone.Location = new Point(6, 200);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(69, 28);
            labelPhone.TabIndex = 0;
            labelPhone.Text = "Phone";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textBox4.Location = new Point(139, 200);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(277, 27);
            textBox4.TabIndex = 4;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelEmail.Location = new Point(3, 137);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(63, 28);
            labelEmail.TabIndex = 0;
            labelEmail.Text = "Email";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textBox3.Location = new Point(139, 137);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(277, 27);
            textBox3.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textBox2.Location = new Point(139, 77);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(277, 27);
            textBox2.TabIndex = 2;
            // 
            // labelSurname
            // 
            labelSurname.AutoSize = true;
            labelSurname.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelSurname.Location = new Point(3, 77);
            labelSurname.Name = "labelSurname";
            labelSurname.Size = new Size(93, 28);
            labelSurname.TabIndex = 0;
            labelSurname.Text = "Surname";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textBox1.Location = new Point(139, 20);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(277, 27);
            textBox1.TabIndex = 1;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelName.Location = new Point(3, 19);
            labelName.Name = "labelName";
            labelName.Size = new Size(66, 28);
            labelName.TabIndex = 0;
            labelName.Text = "Name";
            // 
            // labelAnket
            // 
            labelAnket.AutoSize = true;
            labelAnket.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelAnket.Location = new Point(12, 9);
            labelAnket.Name = "labelAnket";
            labelAnket.Size = new Size(57, 20);
            labelAnket.TabIndex = 0;
            labelAnket.Text = "Anketa";
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 23;
            listBox1.Location = new Point(498, 86);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(322, 349);
            listBox1.TabIndex = 11;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(labelListBox);
            panel2.Location = new Point(498, 30);
            panel2.Name = "panel2";
            panel2.Size = new Size(322, 57);
            panel2.TabIndex = 2;
            // 
            // labelListBox
            // 
            labelListBox.AutoSize = true;
            labelListBox.Font = new Font("Segoe UI", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelListBox.Location = new Point(107, 11);
            labelListBox.Name = "labelListBox";
            labelListBox.Size = new Size(100, 35);
            labelListBox.TabIndex = 0;
            labelListBox.Text = "ListBox";
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox6.Location = new Point(498, 463);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(322, 34);
            textBox6.TabIndex = 8;
            // 
            // btnLoad
            // 
            btnLoad.BackColor = Color.Violet;
            btnLoad.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnLoad.Location = new Point(498, 514);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(101, 37);
            btnLoad.TabIndex = 9;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = false;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.OliveDrab;
            btnSave.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.Location = new Point(635, 514);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(101, 37);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(832, 563);
            Controls.Add(btnSave);
            Controls.Add(btnLoad);
            Controls.Add(textBox6);
            Controls.Add(panel2);
            Controls.Add(listBox1);
            Controls.Add(labelAnket);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label labelBirthYear;
        private TextBox textBox5;
        private Label labelPhone;
        private TextBox textBox4;
        private Label labelEmail;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label labelSurname;
        private TextBox textBox1;
        private Label labelName;
        private Label labelAnket;
        private Button btnAdd;
        private Button btnChange;
        private ListBox listBox1;
        private Panel panel2;
        private Label labelListBox;
        private TextBox textBox6;
        private Button btnLoad;
        private Button btnSave;
    }
}