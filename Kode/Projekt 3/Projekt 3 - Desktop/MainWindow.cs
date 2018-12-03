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
        private DesktopController DC;
        
        public MainWindow()
        {
            InitializeComponent();
            DC = new DesktopController();
            Init();
        }

        private void lblCountry_Click(object sender, EventArgs e)
        {
            
        }

        public void btnSave_Click(object sender, EventArgs e)
        {

            //string title = txtTitle.Text;
            //string genre = cbBoxGenre.Text;
            //string country = cbBoxCountry.Text;
            //string language = cbBoxLanguage.Text;
            //string releaseDate = txtReleaseDate.Text;
            //string storyline = txtStoryline.Text;
            //string filmingLocation = cbBoxFilmingLocation.Text;
            //string information = txtInformation.Text;

            //MessageBox.Show(title + " " + " " + genre + " " + " " + country + " " + " " + language + " " + " " + releaseDate + " " + " " + storyline + " " + " " + filmingLocation + " " + " " + information);

            //reset vinduet
            //spørge om vi er sikker

            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void CreateMovie ()
        {
            string title = txtTitle.Text;
            // int genre = cbBoxGenre.
            // int country = cbBoxCountry.
            // int language = cbBoxlanguage.
            string releaseDate = txtReleaseDate.Text;
            string storyline = txtStoryline.Text;
            // int filmingLocation = cbBoxFilmingLocation.
            string information = txtInformation.Text;

            DC.CreateMovie(genre, title, country, language, releaseDate, storyline, filmingLocation, information);
            
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
           List<Genre> g = DC.GetGenre();
            for (int i = 0; i < g.Count; i++)
            {
                //cbBoxGenre.DataSource = ds.Tables[0];
                //cbBoxGenre.ValueMember = g.Select(x => x.Id);
                //cbBoxGenre.DisplayMember = g.Select(x => x.Name);
            }
        }

        private void GetCountry()
        {
            DC.GetCountry();
        }

        private void GetLanguage()
        {
            DC.GetLanguage();
        }

        private void GetFilmingLocation()
        {
            DC.GetFilmingLocation();
        }

    
    }
}
