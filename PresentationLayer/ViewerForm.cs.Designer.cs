namespace PresentationLayer
{
    partial class ViewersForm
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
            txtPhone = new TextBox();
            label5 = new Label();
            dataGridView1 = new DataGridView();
            dtpBirthDate = new DateTimePicker();
            label4 = new Label();
            txtPassword = new TextBox();
            label3 = new Label();
            txtEmail = new TextBox();
            label2 = new Label();
            txtName = new TextBox();
            label1 = new Label();
            btnLoad = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(611, 189);
            txtPhone.Margin = new Padding(3, 4, 3, 4);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(114, 27);
            txtPhone.TabIndex = 33;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(561, 195);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 32;
            label5.Text = "Phone";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(191, 288);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(274, 200);
            dataGridView1.TabIndex = 31;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.Location = new Point(432, 233);
            dtpBirthDate.Margin = new Padding(3, 4, 3, 4);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(228, 27);
            dtpBirthDate.TabIndex = 30;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(361, 233);
            label4.Name = "label4";
            label4.Size = new Size(76, 20);
            label4.TabIndex = 29;
            label4.Text = "Birth Date";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(432, 189);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(114, 27);
            txtPassword.TabIndex = 28;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(361, 195);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 27;
            label3.Text = "Password";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(432, 151);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(114, 27);
            txtEmail.TabIndex = 26;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(382, 156);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 25;
            label2.Text = "Email";
            // 
            // txtName
            // 
            txtName.Location = new Point(432, 112);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(114, 27);
            txtName.TabIndex = 24;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(382, 117);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 23;
            label1.Text = "Name";
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(189, 228);
            btnLoad.Margin = new Padding(3, 4, 3, 4);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(129, 31);
            btnLoad.TabIndex = 22;
            btnLoad.Text = "Load Viewers";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(189, 189);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(129, 31);
            btnDelete.TabIndex = 21;
            btnDelete.Text = "Delete Viewer";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(189, 151);
            btnUpdate.Margin = new Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(129, 31);
            btnUpdate.TabIndex = 20;
            btnUpdate.Text = "Update Viewer";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(189, 112);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(129, 31);
            btnAdd.TabIndex = 19;
            btnAdd.Text = "Add Viewer";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // ViewersForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(txtPhone);
            Controls.Add(label5);
            Controls.Add(dataGridView1);
            Controls.Add(dtpBirthDate);
            Controls.Add(label4);
            Controls.Add(txtPassword);
            Controls.Add(label3);
            Controls.Add(txtEmail);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(label1);
            Controls.Add(btnLoad);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ViewersForm";
            Text = "ViewerForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPhone;
        private Label label5;
        private DataGridView dataGridView1;
        private DateTimePicker dtpBirthDate;
        private Label label4;
        private TextBox txtPassword;
        private Label label3;
        private TextBox txtEmail;
        private Label label2;
        private TextBox txtName;
        private Label label1;
        private Button btnLoad;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
    }
}