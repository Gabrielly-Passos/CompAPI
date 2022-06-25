using Dapper.Contrib.Extensions;

namespace CompAPI.Models
{
    public class TipoCompromisso
    {
        [Key]

        public int Id { get; set;}

        public string DescricaoCompromisso { get; set; }
       


    }
}