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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnMovies_Click(object sender, EventArgs e)
        {
            var moviesForm = new MovieForm();
            moviesForm.ShowDialog();
        }

        private void btnGenres_Click(object sender, EventArgs e)
        {
            var genresForm = new GenresForm();
            genresForm.ShowDialog();
        }

        private void btnViewers_Click(object sender, EventArgs e)
        {
            var viewersForm = new ViewersForm();
            viewersForm.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
