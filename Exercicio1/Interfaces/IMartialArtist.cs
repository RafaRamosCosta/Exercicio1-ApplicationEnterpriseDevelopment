namespace Exercicio1.Interfaces
{
    public interface IMartialArtist
    {
        public string Name { get; set; }

        public string Graduation { get; set; }

        public string Style { get; set; }

        public void showMartialArtistInfo();

        public void kick();

        public void punch();

        public void defend();
    }
}
