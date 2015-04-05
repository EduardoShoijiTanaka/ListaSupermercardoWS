﻿using ListaSupermercado2.Models;
using ListaSupermercado2.UnitsOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace ListaSupermercado2.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class LogarWSController : ApiController
    {
        private UnitOfWork _unit = new UnitOfWork();

        public IHttpActionResult Post(Conta conta)
        {
            var user = _unit.ContaRepository.Logar(conta.Usuario, conta.Senha);
            if (user == null)
            {
                return BadRequest("Invalido");
            }
            return null;
        }
    }
}
