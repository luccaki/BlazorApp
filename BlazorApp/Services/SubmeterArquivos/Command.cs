using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Services
{
    public partial class SubmeterArquivos
    {
        public class Command
        {
            [Required(ErrorMessage = "Necessário inserir um arquivo .srt")]
            public IBrowserFile Arquivo { get; set; }
            [Required(ErrorMessage = "Necessário inserir um offset positivo ou negativo")]
            public char Offset { get; set; }
            [Required(ErrorMessage = "Necessário escolher as horas de Offset"), Range(0, 999, ErrorMessage = "Horas apenas entre 0 e 999")]
            public int Horas { get; set; }
            [Required(ErrorMessage = "Necessário escolher os minutos de Offset"), Range(0, 59, ErrorMessage = "Minutos apenas entre 0 e 59")]
            public int Minutos { get; set; }
            [Required(ErrorMessage = "Necessário escolher os segundos de Offset"), Range(0, 59, ErrorMessage = "Segundos apenas entre 0 e 59")]
            public int Segundos { get; set; }
            [Required(ErrorMessage = "Necessário escolher os milisegundos de Offset"), Range(0, 999, ErrorMessage = "Milisegundos apenas entre .0 e .999")]
            public int Milisegundos { get; set; }
        }
    }
}
