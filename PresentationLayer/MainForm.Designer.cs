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
            btnRankings = new Button();
            btnViewers = new Button();
            SuspendLayout();
            // 
            // btnMovies
            // 
            btnMovies.Location = new Point(216, 68);
            btnMovies.Name = "btnMovies";
            btnMovies.Size = new Size(75, 23);
            btnMovies.TabIndex = 0;
            btnMovies.Text = "Movies";
            btnMovies.UseVisualStyleBackColor = true;
            btnMovies.Click += btnMovies_Click;
            // 
            // btnGenres
            // 
            btnGenres.Location = new Point(216, 97);
            btnGenres.Name = "btnGenres";
            btnGenres.Size = new Size(75, 23);
            btnGenres.TabIndex = 1;
            btnGenres.Text = "Genres";
            btnGenres.UseVisualStyleBackColor = true;
            btnGenres.Click += btnGenres_Click;
            // 
            // btnRankings
            // 
            btnRankings.Location = new Point(216, 155);
            btnRankings.Name = "btnRankings";
            btnRankings.Size = new Size(75, 23);
            btnRankings.TabIndex = 3;
            btnRankings.Text = "Rankings";
            btnRankings.UseVisualStyleBackColor = true;
            btnRankings.Click += btnRankings_Click;
            // 
            // btnViewers
            // 
            btnViewers.Location = new Point(216, 126);
            btnViewers.Name = "btnViewers";
            btnViewers.Size = new Size(75, 23);
            btnViewers.TabIndex = 2;
            btnViewers.Text = "Viewers";
            btnViewers.UseVisualStyleBackColor = true;
            btnViewers.Click += btnViewers_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRankings);
            Controls.Add(btnViewers);
            Controls.Add(btnGenres);
            Controls.Add(btnMovies);
            Name = "MainForm";
            Text = "MainForm";
            ResumeLayout(false);
        }

        #endregion

        private Button btnMovies;
        private Button btnGenres;
        private Button btnRankings;
        private Button btnViewers;
    }
}