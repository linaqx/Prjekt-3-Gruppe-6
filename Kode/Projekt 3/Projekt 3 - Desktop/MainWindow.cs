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
            DesktopController DC = new DesktopController();
        }



        private void TxtSearch_TextChanged(string search, EventArgs e)
        {

        }

        private void BtnSearch_Click(string searchInput, EventArgs e)
        {
            searchInput = TxtSearch.Text;
            list<Entertainment> tempList = new list<Entertainment>();

            if (searchInput == null)
            {
                DC.ReturnAllEntertainments();

            } else
            {
                DC.ReturnEntertainmentBySearch(searchInput);
            }


        }

        

        private void FindAllEntertainmentsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
