﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacaoInternet.Domain.Entities
{
    public class EstadoTrilho
    {
        public int EstadoTrihoId { get; set; }

        public int TrihoId { get; set; }
        [Required(ErrorMessage = "Please enter Trail")]
        public Trilho Trilho { get; set; }

        public int EstadoId { get; set; }
        [Required(ErrorMessage = "Please enter State")]
        public Estado Estado { get; set; }


        [RegularExpression(@"(\d{2})(-\d{2}-)\d{4}", ErrorMessage = "Data Inválida! Utilize o formato AAAA-MM-DD")]
        public DateTime DataInicio { get; set; }

        [RegularExpression(@"(\d{2})(-\d{2}-)\d{4})", ErrorMessage = "Data Inválida! Utilize o formato AAAA-MM-DD")]
        public DateTime DataFim { get; set; }

        [StringLength(100, MinimumLength = 3)]
        public String Causa { get; set; }
    }
}
