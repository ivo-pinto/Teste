﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacaoInternet.Domain.Entities
{
    public class TipoFoto
    {
        public int TipoFotoId { get; set; }

        [Required(ErrorMessage = "Please enter Trail Name")]
        [StringLength(maximumLength: 100, MinimumLength = 3)]
        public string Nome { get; set; }


        [StringLength(maximumLength: 1000, MinimumLength = 0)]
        public string Descricao { get; set; }

        public ICollection<Foto> Fotos { get; set; }
    }
}
