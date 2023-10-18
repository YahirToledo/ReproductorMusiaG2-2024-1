using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReproductorMusiaG2_2024_1
{
    public partial class FormReproductor : Form
    {
        Form formPadre;
        public FormReproductor(Form formPadre)
        {
            InitializeComponent();
            this.formPadre = formPadre;
        }

        private void FormReproductor_FormClosing(object sender, FormClosingEventArgs e)
        {
            formPadre.Show();
            
        }
    }
}
