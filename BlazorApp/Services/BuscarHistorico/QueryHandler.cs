using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BlazorApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp.Services
{
    public partial class BuscarHistorico
    {
        public class QueryHandler
        {
            private readonly Context Db = new Context();

            public List<Arquivos> Handle()
            {
                return Db.Arquivos.OrderByDescending(x => x.EnviadoEm).ToList();
            }
        }
    }
}
