using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gewig_verloor_program
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Naam.Text == "Kete")
            {
                string textBoxContent = Date.Text  + ("    ") + Weight.Text;

                // Specify the file path where you want to write the content
                string filePath = "A:\\Gewig verloor\\Kete\\Gewig.txt";

                try
                {
                    // Use StreamWriter to write the content to the file
                    using (StreamWriter writer = new StreamWriter(filePath, true))
                    {
                        writer.WriteLine(textBoxContent);
                    }

                    MessageBox.Show("Hy het na die file toe geskryf");


                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error writing to file: {ex.Message}");
                }
                
            }
            else if (Naam.Text == "Ruan")
            {
                string textBoxContent = Date.Text + ("    ") + Weight.Text;

                // Specify the file path where you want to write the content
                string filePath = "A:\\Gewig verloor\\Ruan\\Gewig.txt";

                try
                {
                    // Use StreamWriter to write the content to the file
                    using (StreamWriter writer = new StreamWriter(filePath, true))
                    {
                        writer.WriteLine(textBoxContent);
                    }
                    MessageBox.Show("Hy het na die file toe geskryf");


                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error writing to file: {ex.Message}");
                }
                
            }
            
            else if (Naam.Text == "Inge")
            {
                string textBoxContent = Date.Text + ("    ") + Weight.Text;

                // Specify the file path where you want to write the content
                string filePath = "A:\\Gewig verloor\\Inge\\Gewig.txt";

                try
                {
                    // Use StreamWriter to write the content to the file
                    using (StreamWriter writer = new StreamWriter(filePath, true))
                    {
                        writer.WriteLine(textBoxContent);
                    }

                    MessageBox.Show("Hy het na die file toe geskryf");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error writing to file: {ex.Message}");
                }
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Naam.Clear();
            Weight.Clear();
            Naam.Focus();
        }
    }
}
