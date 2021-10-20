using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lists_in_Windows_Forms
{
    public partial class frmUsingLists : Form
    {
            List<int> numbers = new List<int>();
            List<string> heroes = new List<string>();
            Random generator = new Random();
           

        public frmUsingLists()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 20; i++)
                numbers.Add(generator.Next(100));
            lstNumbers.DataSource = numbers;
            lblStatus.Text = ("Status: Program has been launched.");
            
        }

        private void btnSortNumbers_Click(object sender, EventArgs e)
        {



            numbers.Sort();
            lstNumbers.DataSource = null;
            lstNumbers.DataSource = numbers;
            lblStatus.Text = "Status: Numbers Sorted";

        }

        private void btnSortHeroes_Click(object sender, EventArgs e)
        {
            heroes.Sort();
            lstHeroes.DataSource = null;
            lstHeroes.DataSource = heroes;
            lblStatus.Text = (" Status: Heros successfully sorted.");

        }

        private void btnNewNumbers_Click(object sender, EventArgs e)
        {
            numbers.Clear();


            for (int i = 0; i < 20; i++)
                numbers.Add(generator.Next(100));
            lstNumbers.DataSource = numbers;
            lstNumbers.DataSource = null;
            lstNumbers.DataSource = numbers;


            lblStatus.Text = "Status: New Numbers List";


        }

        private void btnNewHeroes_Click(object sender, EventArgs e)
        {
            heroes.Clear();
            heroes.Add("BATMAN");
            heroes.Add("SUPERMAN");
            lstHeroes.DataSource = heroes;

            lblStatus.Text = ("Status: New Hero List");
            lstHeroes.DataSource = null;
            lstHeroes.DataSource = heroes;
        }

        private void btnRemoveNumber_Click(object sender, EventArgs e)
        {
            if (lstNumbers.SelectedIndex >=0)
            {
                numbers.RemoveAt(lstNumbers.SelectedIndex);
                lstNumbers.DataSource = null;
                lstNumbers.DataSource = numbers;
                lblStatus.Text = (" Status: Selected number has been removed.");
            }
            else
            {
                lblStatus.Text = (" Status: ERROR. NO NUMBER SELECTED");
            }
                


            

        }

        private void btnRemoveAllNumbers_Click(object sender, EventArgs e)
        {
            numbers.Clear();
            lstNumbers.DataSource = null;
            lstNumbers.DataSource = numbers;
            lblStatus.Text = (" Status: Numbers Successfuly cleared.");
        }

        private void btnRemoveHero_Click(object sender, EventArgs e)
        {
            
            heroes.Remove(txtRemoveHeroes.Text.ToUpper());

            lstHeroes.DataSource = null;
            lstHeroes.DataSource = heroes;
            lblStatus.Text = (" Status: Hero successfully removed.");

        }

        private void btnAddHero_Click(object sender, EventArgs e)
        {
            heroes.Add((string)txtAddHeroes.Text.ToUpper());
            
            lstHeroes.DataSource = null;
            lstHeroes.DataSource = heroes;

            lblStatus.Text = (" Status: Hero successfully added.");
        }
    }
}


