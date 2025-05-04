namespace PresentationLayer
{
    partial class MainForm
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
            btnMovies = new Button();
            btnGenres = new Button();
            btnViewers = new Button();
            SuspendLayout();
            // 
            // btnMovies
            // 
            btnMovies.Location = new Point(247, 91);
            btnMovies.Margin = new Padding(3, 4, 3, 4);
            btnMovies.Name = "btnMovies";
            btnMovies.Size = new Size(86, 31);
            btnMovies.TabIndex = 0;
            btnMovies.Text = "Movies";
            btnMovies.UseVisualStyleBackColor = true;
            btnMovies.Click += btnMovies_Click;
            // 
            // btnGenres
            // 
            btnGenres.Location = new Point(247, 129);
            btnGenres.Margin = new Padding(3, 4, 3, 4);
            btnGenres.Name = "btnGenres";
            btnGenres.Size = new Size(86, 31);
            btnGenres.TabIndex = 1;
            btnGenres.Text = "Genres";
            btnGenres.UseVisualStyleBackColor = true;
            btnGenres.Click += btnGenres_Click;
            // 
            // btnViewers
            // 
            btnViewers.Location = new Point(247, 168);
            btnViewers.Margin = new Padding(3, 4, 3, 4);
            btnViewers.Name = "btnViewers";
            btnViewers.Size = new Size(86, 31);
            btnViewers.TabIndex = 2;
            btnViewers.Text = "Viewers";
            btnViewers.UseVisualStyleBackColor = true;
            btnViewers.Click += btnViewers_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(btnViewers);
            Controls.Add(btnGenres);
            Controls.Add(btnMovies);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnMovies;
        private Button btnGenres;
        private Button btnViewers;
    }
}