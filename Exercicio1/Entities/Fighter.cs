using Exercicio1.Interfaces;

namespace Exercicio1.Entities
{
    internal class Fighter : IMartialArtist
    {
        public string Name { get; set; }

        public string Graduation { get; set; }

        public string Style { get; set; }

        public Fighter(string name, string graduation, string style)
        {
            Name = name;
            Graduation = graduation;
            Style = style;
        }

        public void showMartialArtistInfo()
        {
            Console.WriteLine($"Fighter name: {Name}\nFighter style: {Style}\nFighter graduation: {Graduation}");
        }

        public void kick()
        {
            Console.WriteLine($"Fighter {Name} kicked with the {Style} style!");
        }

        public void punch()
        {
            Console.WriteLine($"Fighter {Name} punched with the {Style} style!");
        }

        public void defend()
        {
            Console.WriteLine($"Fighter {Name} defended with the {Style} style!");
        }

    }
}
