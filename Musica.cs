namespace ReproductorMusiaG2_2024_1
{
    public struct Musica
    {
        #region Atributos
        private string artista;
        private string titulo;
        private string album;
        #endregion

        #region Constructor
        public Musica(string artista, string titulo, string album) : this()
        {
            Artista = artista;
            Titulo = titulo;
            Album = album;
        }
        #endregion

        #region Propiedades
        public string Artista { get => artista; set => artista = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Album { get => album; set => album = value; }
        #endregion
    }
}
