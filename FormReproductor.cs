using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ReproductorMusiaG2_2024_1
{
    public partial class FormReproductor : Form
    {
        private Form formPadre;
        //private ArrayList canciones;
        List<Musica> canciones;
        
        public FormReproductor(Form formPadre)
        {
            InitializeComponent();
            this.formPadre = formPadre;
            //canciones = new ArrayList();
            canciones = new List<Musica>();
        }

        private void FormReproductor_FormClosing(object sender, FormClosingEventArgs e)
        {
            formPadre.Show();
            
        }

        private void CargarCanciones()
        {
            canciones.Add(new Musica("Peso Pluma", "Lady Gaga", "Genesis"));
            canciones.Add(new Musica("Michael Jackson", "Thriller", "Thriller"));
        }

        private void cargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (canciones.Count <= 0)
            {
                CargarCanciones();
                lstbCanciones.Items.Clear();
                foreach (object cancion in canciones)
                {
                    Musica musica = (Musica)cancion;
                    lstbCanciones.Items.Add(musica.Titulo);
                }
                MessageBox.Show("Ya se agrego una vez");
            }
            else
            {
                MessageBox.Show("Ya no se agregan mas canciones repetidas");
            }
        }

        private void lstbCanciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            Musica musica = canciones[lstbCanciones.SelectedIndex];
            lbTitulo.Text = musica.Titulo;
            lbArtista.Text = musica.Artista;
            lbAlbum.Text = musica.Album;
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAgregar formAgregar = new FormAgregar();
            formAgregar.EnviarMusica += AgregarCancion;
            formAgregar.ShowDialog();
        }

        public void AgregarCancion(Musica musica)
        {
            canciones.Add(musica);
            lstbCanciones.Items.Add(musica.Titulo);
        }
    }
}
