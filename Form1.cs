using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = this.Controls["nameTextBox"].Text;
            string doj = this.Controls["dojPicker"].Text;
            string city = this.Controls["cityPicker"].Text;
            string skills = this.Controls["skillsProvider"].Text;
            string experience=this.Controls["experienceInput"].Text;
            string mobileno = this.Controls["moileInput"].Text;
            string language = this.Controls["languageGroup"].Text;


        }
    }
}
