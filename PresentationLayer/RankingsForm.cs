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
    public partial class RankingsForm : Form
    {
        public RankingsForm()
        {
            InitializeComponent();
            LoadViewers();
            LoadMovies();
            LoadRankings();
        }
        private void LoadViewers()
        {
            cbViewers.Items.Clear();
            var viewers = ViewersManager.ReadAll().ToList();
            cbViewers.DataSource = viewers;
            cbViewers.DisplayMember = "Name";
            cbViewers.ValueMember = "ID";
        }

        private void LoadMovies()
        {
            clbMovies.Items.Clear();
            var movies = MoviesManager.ReadAll().ToList();
            foreach (var movie in movies)
            {
                clbMovies.Items.Add(movie, false);
            }
        }

        private void LoadRankings()
        {
            dgvRankings.DataSource = RankingsManager.ReadAll()
                .Select(r => new
                {
                    r.ID,
                    ViewerName = r.Viewers.Name,
                    r.CreationDate,
                    MovieTitles = string.Join(", ", r.Movies.Select(m => m.Title))
                }).ToList();
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (cbViewers.SelectedItem is not Viewer selectedViewer)
            {
                MessageBox.Show("Please select a viewer.");
                return;
            }

            var selectedMovies = clbMovies.CheckedItems.Cast<Movie>().ToList();
            if (!selectedMovies.Any())
            {
                MessageBox.Show("Please select at least one movie.");
                return;
            }

            var ranking = new Ranking(selectedViewer, dtpCreationDate.Value)
            {
                Movies = selectedMovies
            };

            RankingsManager.Create(ranking);
            LoadRankings();
            ClearForm();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtRankingId.Text, out int id))
            {
                var ranking = RankingsManager.Read(id);
                if (ranking != null)
                {
                    cbViewers.SelectedValue = ranking.Viewers.ID;
                    dtpCreationDate.Value = ranking.CreationDate;

                    // Uncheck all, then check selected
                    for (int i = 0; i < clbMovies.Items.Count; i++)
                    {
                        var movie = clbMovies.Items[i] as Movie;
                        clbMovies.SetItemChecked(i, ranking.Movies.Any(m => m.MovieAdress == movie.MovieAdress));
                    }
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtRankingId.Text, out int id))
            {
                MessageBox.Show("Please enter a valid Ranking ID to update.");
                return;
            }

            var ranking = RankingsManager.Read(id);
            if (ranking == null)
            {
                MessageBox.Show("Ranking not found.");
                return;
            }

            ranking.Viewers = cbViewers.SelectedItem as Viewer;
            ranking.CreationDate = dtpCreationDate.Value;
            ranking.Movies = clbMovies.CheckedItems.Cast<Movie>().ToList();

            RankingsManager.Update(ranking);
            LoadRankings();
            ClearForm();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtRankingId.Text, out int id))
            {
                RankingsManager.Delete(id);
                LoadRankings();
                ClearForm();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }


        private void ClearForm()
        {
            cbViewers.SelectedIndex = -1;
            for (int i = 0; i < clbMovies.Items.Count; i++)
                clbMovies.SetItemChecked(i, false);
            dtpCreationDate.Value = DateTime.Now;
            txtRankingId.Clear();
        }

        private void dgvRankings_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvRankings.SelectedRows.Count > 0)
            {
                var id = dgvRankings.SelectedRows[0].Cells["ID"].Value.ToString();
                txtRankingId.Text = id;
            }
        }
    }
}
