namespace ResponsiJunpro2MelvinWaluyo
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
            label2 = new Label();
            tbNama = new TextBox();
            comboDepartemen = new ComboBox();
            btnInsert = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            dataGridView1 = new DataGridView();
            listBox1 = new ListBox();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            comboJabatan = new ComboBox();
            label4 = new Label();
            numSalary = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSalary).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 100);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 1;
            label1.Text = "Nama";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 135);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 2;
            label2.Text = "Departemen";
            // 
            // tbNama
            // 
            tbNama.Location = new Point(105, 92);
            tbNama.Name = "tbNama";
            tbNama.Size = new Size(189, 23);
            tbNama.TabIndex = 3;
            // 
            // comboDepartemen
            // 
            comboDepartemen.FormattingEnabled = true;
            comboDepartemen.Items.AddRange(new object[] { "HR", "ENG", "DEV", "PM", "FIN" });
            comboDepartemen.Location = new Point(105, 127);
            comboDepartemen.Name = "comboDepartemen";
            comboDepartemen.Size = new Size(188, 23);
            comboDepartemen.TabIndex = 4;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(10, 272);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(109, 23);
            btnInsert.TabIndex = 6;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(183, 272);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(109, 23);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Edit";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(346, 272);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(109, 23);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 310);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(443, 150);
            dataGridView1.TabIndex = 9;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "ID Departemen: ", "HR: HR", "ENG: Engineer", "DEV: Developer", "PM: Product Manager", "FIN: Finance", "", "ID Jabatan:", "1. Intern", "2. Junior", "3. Senior" });
            listBox1.Location = new Point(311, 92);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(146, 169);
            listBox1.TabIndex = 11;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Logo;
            pictureBox1.Location = new Point(105, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(266, 65);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 171);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 13;
            label3.Text = "Jabatan";
            // 
            // comboJabatan
            // 
            comboJabatan.FormattingEnabled = true;
            comboJabatan.Items.AddRange(new object[] { "1", "2", "3" });
            comboJabatan.Location = new Point(105, 163);
            comboJabatan.Name = "comboJabatan";
            comboJabatan.Size = new Size(188, 23);
            comboJabatan.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 246);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 15;
            label4.Text = "Salary";
            // 
            // numSalary
            // 
            numSalary.Location = new Point(105, 238);
            numSalary.Name = "numSalary";
            numSalary.Size = new Size(189, 23);
            numSalary.TabIndex = 17;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(469, 475);
            Controls.Add(numSalary);
            Controls.Add(label4);
            Controls.Add(comboJabatan);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(listBox1);
            Controls.Add(dataGridView1);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(comboDepartemen);
            Controls.Add(tbNama);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSalary).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tbNama;
        private ComboBox comboDepartemen;
        private Button btnInsert;
        private Button btnUpdate;
        private Button btnDelete;
        private DataGridView dataGridView1;
        private ListBox listBox1;
        private PictureBox pictureBox1;
        private Label label3;
        private ComboBox comboJabatan;
        private Label label4;
        private NumericUpDown numSalary;
    }
}
