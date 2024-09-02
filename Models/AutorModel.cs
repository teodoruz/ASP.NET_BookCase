using System.Text.Json.Serialization;

namespace BookCase_02.Models
{
    public class AutorModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Sobrenome { get; set; }
        [JsonIgnore] // Ignorar durante a serialização JSON
        public ICollection<BookModel> Books { get; private set; } = new List<BookModel>(); // Inicializando a coleção

        public AutorModel(int id, string Name, string Sobrenome)
        {
            this.Id = id;
            this.Name = Name;
            this.Sobrenome = Sobrenome;
            this.Books = new List<BookModel>();
        }
    }
}
