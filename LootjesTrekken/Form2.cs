using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LootjesTrekken
{
    public partial class Form2 : Form
    {
        List<string> emailAdresses;

        public Form2()
        {
            InitializeComponent();
            emailAdresses.Add("victor.langemaire@tutanota.com");
            emailAdresses.Add("leoniebekkernens@gmail.com");
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void btnVersturen_Click(object sender, EventArgs e)
        {

        }
    }
}
