﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NSE.Catalogo.Models;
using NSE.WebAPI.Core.Controllers;
using NSE.WebAPI.Core.Identidade;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NSE.Catalogo.Controllers
{
    [Authorize]
    public class CatalogoController : MainController
    {
        private readonly IProdutoRepository _produtoRepository;

        public CatalogoController(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        [AllowAnonymous]
        [HttpGet("catalogo/produtos")]
        public async Task<IEnumerable<Produto>> Index()
        {
            return await _produtoRepository.ObterTodos();
        }

        [ClaimsAuthorize("Catalogo", "Ler")]
        [HttpGet("catalogo/produtos/{Id}")]
        public async Task<Produto> ProdutoDetalhe(Guid Id)
        {
            return await _produtoRepository.ObterPorId(Id);
        }
    }
}
