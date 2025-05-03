namespace PresentationLayer
{
    partial class RankingsForm
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
            cbViewers = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            clbMovies = new CheckedListBox();
            label3 = new Label();
            dtpCreationDate = new DateTimePicker();
            dgvRankings = new DataGridView();
            btnClear = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnRead = new Button();
            btnCreate = new Button();
            txtRankingId = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvRankings).BeginInit();
            SuspendLayout();
            // 
            // cbViewers
            // 
            cbViewers.FormattingEnabled = true;
            cbViewers.Location = new Point(213, 61);
            cbViewers.Name = "cbViewers";
            cbViewers.Size = new Size(121, 23);
            cbViewers.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(141, 65);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 1;
            label1.Text = "Viewers";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(138, 101);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 2;
            label2.Text = "Movies";
            // 
            // clbMovies
            // 
            clbMovies.FormattingEnabled = true;
            clbMovies.Location = new Point(215, 106);
            clbMovies.Name = "clbMovies";
            clbMovies.Size = new Size(120, 94);
            clbMovies.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(130, 231);
            label3.Name = "label3";
            label3.Size = new Size(79, 15);
            label3.TabIndex = 4;
            label3.Text = "Creation Date";
            // 
            // dtpCreationDate
            // 
            dtpCreationDate.Location = new Point(215, 225);
            dtpCreationDate.Name = "dtpCreationDate";
            dtpCreationDate.Size = new Size(200, 23);
            dtpCreationDate.TabIndex = 5;
            dtpCreationDate.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // dgvRankings
            // 
            dgvRankings.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRankings.Location = new Point(350, 50);
            dgvRankings.Name = "dgvRankings";
            dgvRankings.Size = new Size(149, 150);
            dgvRankings.TabIndex = 6;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(554, 165);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 17;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(554, 135);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 16;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(554, 106);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 15;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnRead
            // 
            btnRead.Location = new Point(554, 78);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(75, 23);
            btnRead.TabIndex = 14;
            btnRead.Text = "Read";
            btnRead.UseVisualStyleBackColor = true;
            btnRead.Click += btnRead_Click;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(554, 49);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(75, 23);
            btnCreate.TabIndex = 13;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // txtRankingId
            // 
            txtRankingId.Location = new Point(438, 225);
            txtRankingId.Name = "txtRankingId";
            txtRankingId.Size = new Size(100, 23);
            txtRankingId.TabIndex = 18;
            txtRankingId.Visible = false;
            // 
            // RankingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtRankingId);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnRead);
            Controls.Add(btnCreate);
            Controls.Add(dgvRankings);
            Controls.Add(dtpCreationDate);
            Controls.Add(label3);
            Controls.Add(clbMovies);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbViewers);
            Name = "RankingsForm";
            Text = "RankingsForm";
            ((System.ComponentModel.ISupportInitialize)dgvRankings).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbViewers;
        private Label label1;
        private Label label2;
        private CheckedListBox clbMovies;
        private Label label3;
        private DateTimePicker dtpCreationDate;
        private DataGridView dgvRankings;
        private Button btnClear;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnRead;
        private Button btnCreate;
        private TextBox txtRankingId;
    }
}