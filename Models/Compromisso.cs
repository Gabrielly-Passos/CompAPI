using Dapper.Contrib.Extensions;
using System; 
using System.Collections.Generic; 
using System.ComponentModel.DataAnnotations;

namespace CompAPI.Models
{   
    [Table("TB_COMPROMISSO")]

    public class Compromisso
    {

        public int Id { get; set; }

        [Required(ErrorMessage="Escolha o tipo de compromisso")]

        public int TipoCompromissoId { get; set; }

        [Required (ErrorMessage="O Campo descrição deve conter até 30 caracteres")]
        [MaxLength(30, ErrorMessage="O campo descrição deve conter até 30 caracteres")]
        [MinLength(10, ErrorMessage="O campo descrinção deve conter pelo menos")]

        public string Descricao { get; set; }

        public string  Localizacao { get; set; }

         [Required(ErrorMessage="A data de início é obrigatória")]

        public DateTime DataInicio { get; set; }

        public DateTime DataTermino { get; set; }

        public bool Visivel { get; set; }

         public int ParticipanteId { get; set; }

         public List<Participante> Participantes { get; set; }


        
    }
}