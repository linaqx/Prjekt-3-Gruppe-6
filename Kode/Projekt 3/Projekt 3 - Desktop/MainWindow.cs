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
            GetData();
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

        public void CreateMovie()
        {
            string title = txtTitle.Text;
            int genre = ((ComboBoxItem)cbBoxGenre.SelectedItem).HiddenValue;
            int country = ((ComboBoxItem)cbBoxCountry.SelectedItem).HiddenValue;
            int language = ((ComboBoxItem)cbBoxLanguage.SelectedItem).HiddenValue;
            DateTime date;
            string storyline = txtStoryline.Text;
            int filmingLocation = ((ComboBoxItem)cbBoxFilmingLocation.SelectedItem).HiddenValue;
            string information = txtInformation.Text;
            if (DateTime.TryParse(txtReleaseDate.Text, out date))
            {
                date = DateTime.ParseExact(txtReleaseDate.Text, "yyyy-MM-dd", null);
                DateTime releaseDate = date;
                DC.CreateMovie(genre, title, country, language, releaseDate, storyline, filmingLocation, information);
            }
            else
            {
                Console.WriteLine("Date is not correctly written: yyyy-MM-dd");
                Console.ReadLine();
            }

            

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

            foreach (Genre item in g)
            {
                int id = item.Id;
                string name = item.Name;

                cbBoxGenre.Items.Add(new ComboBoxItem(name, id));
                
            }
        }

        private void GetCountry()
        {
            List<Country> c = DC.GetCountry();
            foreach (Country country in c)
            {
                int id = country.Id;
                string name = country.Name;
                cbBoxCountry.Items.Add(new ComboBoxItem(name, id));
            }
        }

        private void GetLanguage()
        {
            List<Language> l = DC.GetLanguage();
            foreach (Language language in l)
            {
                int id = language.Id;
                string name = language.Name;
                cbBoxCountry.Items.Add(new ComboBoxItem(name, id));
            }
        }

        private void GetFilmingLocation()
        {
            List<FilmingLocation> f = DC.GetFilmingLocation();
            foreach (FilmingLocation film in f)
            {
                int id = film.Id;
                string name = film.Name;
                cbBoxCountry.Items.Add(new ComboBoxItem(name, id));
            }
        }


    }
}
