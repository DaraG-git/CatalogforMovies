namespace PresentationLayer
{
    partial class MovieForm
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
            txtTitle = new TextBox();
            txtDirector = new TextBox();
            label2 = new Label();
            label3 = new Label();
            dtpReleaseDate = new DateTimePicker();
            cbGenre = new ComboBox();
            label4 = new Label();
            btnCreate = new Button();
            btnRead = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnClear = new Button();
            dgvMovies = new DataGridView();
            txtMovieId = new TextBox();
            txtReview = new TextBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvMovies).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(101, 60);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 0;
            label1.Text = "Title";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(145, 57);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(100, 23);
            txtTitle.TabIndex = 1;
            // 
            // txtDirector
            // 
            txtDirector.Location = new Point(145, 86);
            txtDirector.Name = "txtDirector";
            txtDirector.Size = new Size(100, 23);
            txtDirector.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(90, 89);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 2;
            label2.Text = "Director";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(66, 118);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 4;
            label3.Text = "Release Date";
            // 
            // dtpReleaseDate
            // 
            dtpReleaseDate.Location = new Point(145, 115);
            dtpReleaseDate.Name = "dtpReleaseDate";
            dtpReleaseDate.Size = new Size(200, 23);
            dtpReleaseDate.TabIndex = 5;
            // 
            // cbGenre
            // 
            cbGenre.FormattingEnabled = true;
            cbGenre.Location = new Point(145, 144);
            cbGenre.Name = "cbGenre";
            cbGenre.Size = new Size(121, 23);
            cbGenre.TabIndex = 6;
            cbGenre.SelectedIndexChanged += cbGenre_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(101, 147);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 7;
            label4.Text = "Genre";
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(408, 61);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(75, 23);
            btnCreate.TabIndex = 8;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnRead
            // 
            btnRead.Location = new Point(408, 90);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(75, 23);
            btnRead.TabIndex = 9;
            btnRead.Text = "Read";
            btnRead.UseVisualStyleBackColor = true;
            btnRead.Click += btnRead_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(408, 147);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(408, 118);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(408, 177);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 12;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // dgvMovies
            // 
            dgvMovies.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMovies.Location = new Point(94, 206);
            dgvMovies.Name = "dgvMovies";
            dgvMovies.Size = new Size(240, 150);
            dgvMovies.TabIndex = 13;
            dgvMovies.CellContentClick += dgvMovies_CellContentClick;
            // 
            // txtMovieId
            // 
            txtMovieId.Location = new Point(395, 241);
            txtMovieId.Name = "txtMovieId";
            txtMovieId.Size = new Size(100, 23);
            txtMovieId.TabIndex = 14;
            txtMovieId.Visible = false;
            // 
            // txtReview
            // 
            txtReview.Location = new Point(145, 173);
            txtReview.Name = "txtReview";
            txtReview.Size = new Size(100, 23);
            txtReview.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(95, 176);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 15;
            label5.Text = "Review";
            // 
            // MovieForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtReview);
            Controls.Add(label5);
            Controls.Add(txtMovieId);
            Controls.Add(dgvMovies);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnRead);
            Controls.Add(btnCreate);
            Controls.Add(label4);
            Controls.Add(cbGenre);
            Controls.Add(dtpReleaseDate);
            Controls.Add(label3);
            Controls.Add(txtDirector);
            Controls.Add(label2);
            Controls.Add(txtTitle);
            Controls.Add(label1);
            Name = "MovieForm";
            Text = "MovieForm";
            ((System.ComponentModel.ISupportInitialize)dgvMovies).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtTitle;
        private TextBox txtDirector;
        private Label label2;
        private Label label3;
        private DateTimePicker dtpReleaseDate;
        private ComboBox cbGenre;
        private Label label4;
        private Button btnCreate;
        private Button btnRead;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnClear;
        private DataGridView dgvMovies;
        private TextBox txtMovieId;
        private TextBox txtReview;
        private Label label5;
    }
}