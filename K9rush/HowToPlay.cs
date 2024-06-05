using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace K9rush
{
    public partial class HowToPlay : Form
    {
        public HowToPlay()
        {

            InitializeComponent();

            //Set the StartPosition property to Manual
            this.StartPosition = FormStartPosition.Manual;

            // Set the location of the form to (100, 100)
            this.Location = new Point(700, 200);

        }



        private void BackBtn_Click(object sender, EventArgs e)
        {
            // Close the HowToPlayForm
            this.Close();

        }

       
    }
}
