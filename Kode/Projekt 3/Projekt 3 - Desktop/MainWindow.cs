using Projekt_3___Desktop.Controller;
using Projekt_3___Desktop.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_3___Desktop
{
    public partial class MainWindow : Form
    {
        private DesktopController DesktopController;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void lblCountry_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text;
            string genre = cbBoxGenre.Text;
            string country = cbBoxCountry.Text;
            string language = cbBoxLanguage.Text;
            string releaseDate = txtReleaseDate.Text;
            string storyline = txtStoryline.Text;
            string filmingLocation = cbBoxFilmingLocation.Text;
            string information = txtInformation.Text;

            //MessageBox.Show(title + " " + " " + genre + " " + " " + country + " " + " " + language + " " + " " + releaseDate + " " + " " + storyline + " " + " " + filmingLocation + " " + " " + information);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void GetData()
        {
            GetGenre();
            GetCountry();
            GetLanguage();
            GetFilmingLocation();
        }

        private void GetGenre()
        {
           List<Genre> g = DesktopController.GetGenre();
            for (int i = 0; i < g.Count; i++)
            {
                //cbBoxGenre.DataSource = ds.Tables[0];
                cbBoxGenre.ValueMember = g.Select(x => x.Id);
                cbBoxGenre.DisplayMember = g.Select(x => x.Name);
            }
        }

        private void GetCountry()
        {
            DesktopController.GetCountry();
        }

        private void GetLanguage()
        {
            DesktopController.GetLanguage();
        }

        private void GetFilmingLocation()
        {
            DesktopController.GetFilmingLocation();
        }

    }
}
