using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CKarnasProgram1
{
    public partial class Program1 : Form
    {
        public Program1()
        {
            InitializeComponent();
        }

        private void btnLeadDirector_Click(object sender, EventArgs e)
        {
            // instantiate movie object

            Movie aMovie = new Movie();

            // call ShowLeadDirector method and display returned value in lblbResult

            lblResult.Text = aMovie.ShowLeadDirector();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Exit the form

            this.Close();
        }

        private void btnLeadActor_Click(object sender, EventArgs e)
        {
            // instantiate movie object

            Movie aMovie = new Movie();

            // call ShowLeadActor method and display returned value in lblResult

            lblResult.Text = aMovie.ShowLeadActor();
        }

        private void btnLeadActress_Click(object sender, EventArgs e)
        {
            // instantiate movie object

            Movie aMovie = new Movie();

            //call ShowLeadActress method and display returned value in lblResult

            lblResult.Text = aMovie.ShowLeadActress();
        }
    }
}
