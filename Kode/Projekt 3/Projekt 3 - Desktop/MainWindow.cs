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
            CreateMovie();

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
            //int genre = 0;
            //if ( genre > 0)
            //{
            //    genre = ((ComboBoxItem)cbBoxGenre.SelectedItem).HiddenValue;
            //}
            //else
            //{
            //    MessageBox.Show("Please choose a genre");
            //}
            int genre;
            try
            {
                genre = ((ComboBoxItem)cbBoxGenre.SelectedItem).HiddenValue;
            }
            catch (Exception)
            {
                genre = 0;
                MessageBox.Show("Please choose a valid genre");

            }
            int country;
            try
            {
                country = ((ComboBoxItem)cbBoxCountry.SelectedItem).HiddenValue;
            }
            catch (Exception)
            {

                country = 0;
                MessageBox.Show("Please choose a valid country");
            }
            int language;
            try
            {
                language = ((ComboBoxItem)cbBoxLanguage.SelectedItem).HiddenValue;
            }
            catch (Exception)
            {
                language = 0;
                MessageBox.Show("Please choose a valid language");
            }
            
            string storyline = txtStoryline.Text;
            int filmingLocation;
            try
            {
                filmingLocation = ((ComboBoxItem)cbBoxFilmingLocation.SelectedItem).HiddenValue;
            }
            catch (Exception)
            {
                filmingLocation = 0;
                MessageBox.Show("Please choose a valid filming location");
            }
            
            string information = txtInformation.Text;
            bool isMovie = true;
            if (title != "" && storyline != "" && information != "" && genre > 0 && country > 0 && language > 0 && filmingLocation > 0)
            {

                if (DateTime.TryParse(txtReleaseDate.Text, out DateTime date))
                {
                    date = DateTime.ParseExact(txtReleaseDate.Text, "dd-MM-yyyy", null);

                    DC.InsertMovieIntoEntertainment(genre, title, country, language, date, storyline, filmingLocation, information, isMovie);
                    ClearMovie();
                    MessageBox.Show("Your movie is saved!");
                }
                else
                {

                    MessageBox.Show("Date is not correctly written: dd-MM-yyyy");

                }
            }
            else
            {
                MessageBox.Show("Please fill all boxes!");
            }

        }


        private void ClearMovie()
        {
            txtTitle.Clear();
            cbBoxGenre.ResetText();
            cbBoxCountry.ResetText();
            cbBoxLanguage.ResetText();
            txtReleaseDate.Clear();
            txtStoryline.Clear();
            cbBoxFilmingLocation.ResetText();
            txtInformation.Clear();

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
            if (g != null)
            {
                foreach (Genre item in g)
                {
                    int id = item.Id;
                    string name = item.Name;
                    cbBoxGenre.Items.Add(new ComboBoxItem(name, id));

                }
            }


        }

        private void GetCountry()
        {
            List<Country> c = DC.GetCountry();
            if (c != null)
            {
                foreach (Country country in c)
                {
                    int id = country.Id;
                    string name = country.Name;
                    cbBoxCountry.Items.Add(new ComboBoxItem(name, id));
                }
            }

        }

        private void GetLanguage()
        {
            List<Language> l = DC.GetLanguage();
            if (l != null)
            {
                foreach (Language language in l)
                {
                    int id = language.Id;
                    string name = language.Name;
                    cbBoxLanguage.Items.Add(new ComboBoxItem(name, id));
                }
            }

        }

        private void GetFilmingLocation()
        {
            List<FilmingLocation> f = DC.GetFilmingLocation();
            if (f != null)
            {
                foreach (FilmingLocation film in f)
                {
                    int id = film.Id;
                    string name = film.Name;
                    cbBoxFilmingLocation.Items.Add(new ComboBoxItem(name, id));
                }
            }

        }


    }
}
