using System;
using System.Collections;
using System.Windows.Forms;

namespace ReproductorMusiaG2_2024_1
{
    public partial class FormReproductor : Form
    {
        private Form formPadre;
        private ArrayList canciones;
        public FormReproductor(Form formPadre)
        {
            InitializeComponent();
            this.formPadre = formPadre;
            canciones = new ArrayList();
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
            CargarCanciones();
            foreach (object cancion in canciones)
            {
                Musica musica = (Musica)cancion;
                lstbCanciones.Items.Add(musica.Titulo);
            }
        }

        private void lstbCanciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            Musica musica = (Musica)canciones[lstbCanciones.SelectedIndex];
            lbTitulo.Text = musica.Titulo;
            lbArtista.Text = musica.Artista;
            lbAlbum.Text = musica.Album;
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAgregar formAgregar = new FormAgregar();
            formAgregar.ShowDialog();
        }
    }
}
