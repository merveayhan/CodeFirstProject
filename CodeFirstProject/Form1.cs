using CodeFirstProject.Model.DAL.ORM.Context;
using CodeFirstProject.Model.DAL.ORM.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeFirstProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ProjectContext db = new ProjectContext();
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            AppUser appuser = new AppUser();
            appuser.FirstName = txtAd.Text;
            appuser.LastName = txtSoyad.Text;
            appuser.Phone = maskedTextBox1.Text;
            db.AppUsers.Add(appuser);
            db.SaveChanges();
            dataGridView1.DataSource = db.AppUsers.ToList();

        }
        string name;
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            AppUser appuser = db.AppUsers.FirstOrDefault(x => x.FirstName ==name );
            appuser.FirstName = txtGuncelle.Text;
           
            db.SaveChanges();
            dataGridView1.DataSource = db.AppUsers.ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtGuncelle.Text = dataGridView1.CurrentRow.Cells["FirstName"].Value.ToString();
            name = dataGridView1.CurrentRow.Cells["FirstName"].Value.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.AppUsers.ToList();
        }
    }
}
