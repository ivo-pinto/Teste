﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacaoInternet.Domain.Entities
{
    public class Dificuldade
    {
        public int DificuldadeId { get; set; }

        [Required(ErrorMessage = "Please enter Dificulty name")]
        [StringLength(100, MinimumLength = 3)]
        public string Nome { get; set; }


        [StringLength(maximumLength: 250, MinimumLength = 0)]
        public string Observacao { get; set; }

        [Required(ErrorMessage = "Please enter Dificulty Value")]
        [Range(minimum: 1, maximum: 5)]
        public int Valor { get; set; }

        public ICollection<Etapa> Etapas { get; set; }
    }
}
