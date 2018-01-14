﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacaoInternet.Domain.Entities
{
    public class Estado
    {
        public int EstadoId { get; set; }

        [Required(ErrorMessage = "Please enter State name")]
        [StringLength(100, MinimumLength = 3)]
        public string Nome { get; set; }


        [StringLength(1000, MinimumLength = 0)]
        public string Descricao { get; set; }

        public ICollection<EstadoTrilho> EstadosTrilhos { get; set; }
    }
}
