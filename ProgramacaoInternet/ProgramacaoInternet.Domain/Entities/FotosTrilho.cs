using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacaoInternet.Domain.Entities
{
    public class FotosTrilho
    {
        public int FotosTrilhoId { get; set; }

        public int FotoId { get; set; }

        [Required(ErrorMessage = "Please enter a Photo")]
        public Foto Foto { get; set; }

        public int TrilhoId { get; set; } //mudar para tipo Trilho

        [Required(ErrorMessage = "Please enter a Trail")]
        public Trilho Trilho { get; set; }
    }
}
