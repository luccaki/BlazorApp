using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Services
{
    public partial class DownloadArquivo
    {
        public class Command
        {
            public int Id { get; set; }
        }
    }
}
