using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BotAceAsh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int nombreDeBouffes;
            if (this.radio_3bouffes.Checked)
            {
                nombreDeBouffes = 3;
            } else
            {
                nombreDeBouffes = 4;
            }

            Autobouffe bot = new Autobouffe(nombreDeBouffes); //lancement de l'autobouffe
            this.WindowState = FormWindowState.Minimized;
            this.Owner = this;
            this.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
