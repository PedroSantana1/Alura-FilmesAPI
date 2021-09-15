using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FilmesApi.Data.Dtos.Gerente
{
    public class UpdateGerenteDto
    {
        [Required]
        public string Nome { get; set; }
    }
}
