using BusinessLayer;
using ServiceLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class MovieForm : Form
    {
        public MovieForm()
        {
            InitializeComponent();
            LoadGenres();
            LoadMovies();
            dgvMovies.SelectionChanged += dgvMovies_SelectionChanged;
        }
        private void LoadGenres()
        {
            cbGenre.DataSource = GenresManager.ReadAll().ToList();
            cbGenre.DisplayMember = "Name";
            cbGenre.ValueMember = "Id";
        }
        private void LoadMovies()
        {
            dgvMovies.DataSource = null;
            dgvMovies.DataSource = MoviesManager.ReadAll().ToList();
        }
        private void ClearFields()
        {
            txtTitle.Clear();
            txtDirector.Clear();
            dtpReleaseDate.Value = DateTime.Now;
            cbGenre.SelectedIndex = 0;
            txtReview.Clear();
            dgvMovies.ClearSelection();
            btnCreate.Enabled = true;
            txtMovieId.Text = ""; // hidden field to track selected MovieAdress
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                var genre = (Genre)cbGenre.SelectedItem;
                var newMovie = new Movie(
                    txtTitle.Text,
                    txtDirector.Text,
                    genre.Id,
                    null,
                    dtpReleaseDate.Value.Year,
                    decimal.Parse(txtReview.Text)
                );
                newMovie.MovieAdress = Guid.NewGuid().ToString();

                MoviesManager.Create(newMovie);
                LoadMovies();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating movie: " + ex.Message);
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            LoadMovies();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtMovieId.Text))
        {
                var movie = MoviesManager.Read(txtMovieId.Text);
                if (movie != null)
                {
                    movie.Title = txtTitle.Text;
                    movie.Director = txtDirector.Text;
                    movie.ReleaseYear = dtpReleaseDate.Value.Year;
                    movie.Genre = (Genre)cbGenre.SelectedItem;
                    movie.Review = decimal.Parse(txtReview.Text);

                    MoviesManager.Update(movie);
                    LoadMovies();
                    ClearFields();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMovieId.Text))
            {
                MoviesManager.Delete(txtMovieId.Text);
                LoadMovies();
                ClearFields();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            ClearFields();

        }
        private void dgvMovies_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMovies.CurrentRow?.DataBoundItem is Movie selected)
            {
                txtTitle.Text = selected.Title;
                txtDirector.Text = selected.Director;
                dtpReleaseDate.Value = new DateTime(selected.ReleaseYear, 1, 1);
                cbGenre.SelectedItem = selected.Genre;
                txtReview.Text = selected.Review.ToString();
                txtMovieId.Text = selected.MovieAdress;
                btnCreate.Enabled = false;
            }
        }
        private void dgvMovies_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void cbGenre_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
