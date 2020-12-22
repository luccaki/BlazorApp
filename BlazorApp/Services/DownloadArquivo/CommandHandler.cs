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
using Microsoft.AspNetCore.Components.Forms;

namespace BlazorApp.Services
{
    public partial class DownloadArquivo
    {
        public class CommandHandler
        {
            private readonly Context Db = new Context();

            public Arquivos Handle(Command command)
            {
                var Arquivo = Db.Arquivos.SingleOrDefault(x => x.Id == command.Id);
                Arquivo.QtdDownloads++;
                Db.SaveChanges();

                return Arquivo;
            }

            public void Delete(Command command)
            {
                var Arquivo = Db.Arquivos.SingleOrDefault(x => x.Id == command.Id);
                Db.Remove(Arquivo);
                Db.SaveChanges();
            }
        }
    }
}
