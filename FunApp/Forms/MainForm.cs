using FunApplication.Forms;
using FunApplication.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FunApplication.Forms
{
    public partial class MainForm : Form
    {


        public MainForm()
        {
            InitializeComponent();
        }


        // кнока переходу для пошуку спортсмена
        private void buttonMainFormToSearch_Click(object sender, EventArgs e)
        {
            SearchForm searchForm = new SearchForm();
            searchForm.Show();
            Hide();
        }

        // кнопка для переходу пошуку рекордсмена
        private void buttonToSportsmenRecordForm_Click(object sender, EventArgs e)
        {
            SportsmenRecordForm sportsmenRecordForm = new SportsmenRecordForm();
            sportsmenRecordForm.Show();
            Hide();
        }

        // кнопка для виходу з MainForm
        private void вихідToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
