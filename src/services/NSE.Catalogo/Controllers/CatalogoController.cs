﻿using Microsoft.AspNetCore.Mvc;
using NSE.Catalogo.Models;
using NSE.WebAPI.Core.Controllers;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NSE.Catalogo.Controllers
{
    public class CatalogoController : MainController
    {
        private readonly IProdutoRepository _produtoRepository;

        public CatalogoController(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        [HttpGet("catalogo/produtos")]
        public async Task<PagedResult<Produto>> Index([FromQuery] int ps = 8, [FromQuery] int page = 1, [FromQuery] string q = null)
        {
            return await _produtoRepository.ObterTodos(ps, page, q);
        }

        [HttpGet("catalogo/produtos/{Id}")]
        public async Task<Produto> ProdutoDetalhe(Guid Id)
        {
            return await _produtoRepository.ObterPorId(Id);
        }

        [HttpGet("catalogo/produtos/lista/{ids}")]
        public async Task<IEnumerable<Produto>> ObterProdutosPorId(string ids)
        {
            return await _produtoRepository.ObterProdutosPorId(ids);
        }
    }
}
