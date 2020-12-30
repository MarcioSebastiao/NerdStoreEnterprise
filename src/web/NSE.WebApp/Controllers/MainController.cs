﻿using Microsoft.AspNetCore.Mvc;
using NSE.WebApp.Models;
using System.Linq;

namespace NSE.WebApp.Controllers
{
    public class MainController : Controller
    {
        protected bool ResponsePossuiErros(ResponseResult resposta)
        {
            if (resposta != null && resposta.Errors.Mensagens.Any())
            {
                foreach (var mensagem in resposta.Errors.Mensagens)
                {
                    ModelState.AddModelError(string.Empty, mensagem);
                }
                return true;
            }
            return false;
        }
    }
}
