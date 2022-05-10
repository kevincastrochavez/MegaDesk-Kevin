using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Kevin
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addQuote = new AddQuote();
            addQuote.Tag = this;
            addQuote.Show();

            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            var viewAllQuotes = new ViewAllQuotes();
            viewAllQuotes.Tag = this;
            viewAllQuotes.Show();

            this.Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var searchQuotes = new SearchQuotes();
            searchQuotes.Tag = this;
            searchQuotes.Show();

            this.Hide();
        }

        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
