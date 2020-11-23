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
    public partial class Form1 : Form
    {
        private List<string> names;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnOpslaan_Click(object sender, EventArgs e)
        {
            //names = (List<string>)lstLootjesNamen.Items;
        }

        private void btnAddName_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            lstLootjesNamen.Items.Add(name);
        }
    }
}
