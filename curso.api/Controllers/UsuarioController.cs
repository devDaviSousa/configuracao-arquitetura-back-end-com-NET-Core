﻿using curso.api.Filters;
using curso.api.Models;
using curso.api.Models.Usuarios;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Linq;

namespace curso.api.Controllers
{
    [Route("api/v1/usuario")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        //<summary>
        //Autenticar um usuario
        //</summary>
        //<param name="loginViewModelInput"></param>
        //returns> Retorna status ok</returns>

        [SwaggerResponse(statusCode:200, description:"Sucesso ao autenticar",Type=typeof(LoginViewModelInput))]
        [SwaggerResponse(statusCode:400, description:"Campos Obrigatorio",Type=typeof(ValidaCampoViewModelOutput))]
        [SwaggerResponse(statusCode:500, description:"Erro interno",Type=typeof(ErrorGenericViewModel))]

        [HttpPost]
        [Route("logar")]
        [ValidacaoModelStateCustomizado]
        public IActionResult Logar( LoginViewModelInput loginViewModelInput) {

            //if (!ModelState.IsValid)
            //{
            //    return BadRequest(new ValidaCampoViewModelOutput(ModelState.SelectMany(sm => sm.Value.Errors).Select(s => s.ErrorMessage)));
            //}

            return Ok(loginViewModelInput);
        }


        [HttpPost]
        [Route("registrar")]
        [ValidacaoModelStateCustomizado]

        public IActionResult Registrar(RegistroViewModelInput loginViewModelInput)
        {

           
            return Created("", loginViewModelInput);
        }





    }
}
