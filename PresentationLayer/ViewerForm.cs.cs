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
    public partial class ViewersForm : Form
    {
        public ViewersForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selected = (Viewer)dataGridView1.SelectedRows[0].DataBoundItem;
                txtName.Text = selected.Name;
                txtEmail.Text = selected.Email;
                txtPassword.Text = selected.Password;
                txtPhone.Text = selected.Phone;
                dtpBirthDate.Value = selected.BirthDate;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var viewer = new Viewer(
                txtName.Text,
                txtEmail.Text,
                txtPassword.Text,
                txtPhone.Text,
                dtpBirthDate.Value
            );

            ViewersManager.Create(viewer);
            LoadViewers();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selected = (Viewer)dataGridView1.SelectedRows[0].DataBoundItem;
                selected.Name = txtName.Text;
                selected.Email = txtEmail.Text;
                selected.Password = txtPassword.Text;
                selected.Phone = txtPhone.Text;
                selected.BirthDate = dtpBirthDate.Value;

                ViewersManager.Update(selected);
                LoadViewers();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selected = (Viewer)dataGridView1.SelectedRows[0].DataBoundItem;
                ViewersManager.Delete(selected.ID);
                LoadViewers();
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadViewers();
        }
        private void LoadViewers()
        {
            dataGridView1.DataSource = ViewersManager.ReadAll().ToList();
        }

    }
}
