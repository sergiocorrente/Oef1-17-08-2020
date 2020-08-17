using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oef1_17_08_2020
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       List<Person> personsList = new List<Person>();

        private void Form1_Load(object sender, EventArgs e)
        {
            personsList.Add(new Person("Johan", 23));
            personsList.Add(new Person("Koen", 44));
            personsList.Add(new Person("Ken"));

            listBox1.DataSource = personsList;

            personsList.Add(new Person("Jonas", 24));

           listBox1.DataSource = null;
           listBox1.DataSource = personsList;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.DataSource != null)
            {
                if (personsList[listBox1.SelectedIndex].Leeftijd >= 0) {
                    textBox1.Text = personsList[listBox1.SelectedIndex].Leeftijd.ToString();
                }
                else { 
                    textBox1.Text = "Niet bekend";
                }
            }
        }

    }
}
