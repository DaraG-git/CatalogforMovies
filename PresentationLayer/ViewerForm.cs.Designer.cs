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
            txtPhone.Location = new Point(535, 142);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(100, 23);
            txtPhone.TabIndex = 33;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(491, 146);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 32;
            label5.Text = "Phone";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(167, 216);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(240, 150);
            dataGridView1.TabIndex = 31;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.Location = new Point(378, 175);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(200, 23);
            dtpBirthDate.TabIndex = 30;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(316, 175);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 29;
            label4.Text = "Birth Date";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(378, 142);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(100, 23);
            txtPassword.TabIndex = 28;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(316, 146);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 27;
            label3.Text = "Password";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(378, 113);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 26;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(334, 117);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 25;
            label2.Text = "Email";
            // 
            // txtName
            // 
            txtName.Location = new Point(378, 84);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 24;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(334, 88);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 23;
            label1.Text = "Name";
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(165, 171);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(113, 23);
            btnLoad.TabIndex = 22;
            btnLoad.Text = "Load Viewers";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(165, 142);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(113, 23);
            btnDelete.TabIndex = 21;
            btnDelete.Text = "Delete Viewer";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(165, 113);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(113, 23);
            btnUpdate.TabIndex = 20;
            btnUpdate.Text = "Update Viewer";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(165, 84);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(113, 23);
            btnAdd.TabIndex = 19;
            btnAdd.Text = "Add Viewer";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // ViewersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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