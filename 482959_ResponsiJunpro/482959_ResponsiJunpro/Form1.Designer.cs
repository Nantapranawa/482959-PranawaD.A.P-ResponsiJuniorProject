namespace _482959_ResponsiJunpro
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
            lblNama = new Label();
            lblDept = new Label();
            txtNama = new TextBox();
            cbDept = new ComboBox();
            btnInsert = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            dgvData = new DataGridView();
            richTextBox1 = new RichTextBox();
            btnLoad = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // lblNama
            // 
            lblNama.AutoSize = true;
            lblNama.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblNama.Location = new Point(31, 74);
            lblNama.Name = "lblNama";
            lblNama.Size = new Size(110, 17);
            lblNama.TabIndex = 0;
            lblNama.Text = "Nama Karyawan :";
            // 
            // lblDept
            // 
            lblDept.AutoSize = true;
            lblDept.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblDept.Location = new Point(31, 128);
            lblDept.Name = "lblDept";
            lblDept.Size = new Size(106, 17);
            lblDept.TabIndex = 1;
            lblDept.Text = "Dep. Karyawan  :";
            // 
            // txtNama
            // 
            txtNama.Location = new Point(173, 71);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(165, 23);
            txtNama.TabIndex = 8;
            // 
            // cbDept
            // 
            cbDept.FormattingEnabled = true;
            cbDept.Location = new Point(173, 127);
            cbDept.Name = "cbDept";
            cbDept.Size = new Size(165, 23);
            cbDept.TabIndex = 9;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(51, 197);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(105, 29);
            btnInsert.TabIndex = 10;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(195, 197);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(105, 29);
            btnEdit.TabIndex = 11;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(329, 198);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(105, 29);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvData
            // 
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(12, 253);
            dgvData.Name = "dgvData";
            dgvData.RowTemplate.Height = 25;
            dgvData.Size = new Size(579, 219);
            dgvData.TabIndex = 13;
            dgvData.CellContentClick += dgvData_CellContentClick;
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox1.ForeColor = SystemColors.WindowText;
            richTextBox1.Location = new Point(444, 42);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(136, 128);
            richTextBox1.TabIndex = 14;
            richTextBox1.Text = "ID Departemen :\n\nHR: HR\nENG: Engineer\nDEV: Developer\nPM: Product M\nFIN: Finance";
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(470, 201);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(75, 23);
            btnLoad.TabIndex = 15;
            btnLoad.Text = "button1";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(603, 484);
            Controls.Add(btnLoad);
            Controls.Add(richTextBox1);
            Controls.Add(dgvData);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnInsert);
            Controls.Add(cbDept);
            Controls.Add(txtNama);
            Controls.Add(lblDept);
            Controls.Add(lblNama);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNama;
        private Label lblDept;
        private TextBox txtNama;
        private ComboBox cbDept;
        private Button btnInsert;
        private Button btnEdit;
        private Button btnDelete;
        private DataGridView dgvData;
        private RichTextBox richTextBox1;
        private Button btnLoad;
    }
}