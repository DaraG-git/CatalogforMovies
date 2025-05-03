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
    public partial class GenresForm : Form
    {
        public GenresForm()
        {
            InitializeComponent();
            LoadGenres();
        }
        private void LoadGenres()
        {
            lstGenres.DataSource = GenresManager.ReadAll().ToList();
            lstGenres.DisplayMember = "Name";
            lstGenres.ValueMember = "Id";
        }

        private void GenresForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text)) return;

            var genre = new Genre(txtName.Text);
            GenresManager.Create(genre);
            LoadGenres();
            txtName.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lstGenres.SelectedItem is Genre selected)
            {
                selected.Name = txtName.Text;
                GenresManager.Update(selected);
                LoadGenres();
                txtName.Clear();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstGenres.SelectedItem is Genre selected)
            {
                GenresManager.Delete(selected.Id);
                LoadGenres();
                txtName.Clear();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadGenres();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lstGenres_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstGenres.SelectedItem is Genre selected)
            {
                txtName.Text = selected.Name;
            }
        }
    }
}
