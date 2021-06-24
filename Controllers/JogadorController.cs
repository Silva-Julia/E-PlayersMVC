using E_PlayersMVC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_PlayersMVC.Controllers
{
    [Route ("Jogador")]
    public class JogadorController : Controller
    {
        Jogador jogadorModel = new Jogador();

        [Route("Listar")]
        public IActionResult Index(){

            ViewBag.Jogadores = jogadorModel.LerTodos();
            return View();
        }

        [Route("Cadastrar")]
        public IActionResult Cadastrar (IFormCollection form){
              Jogador novoJogador = new Jogador();
              novoJogador.IdJogador = form["IdJogador"];
            //   novoJogador.IdEquipe = int.Parse(form["IdEquipe"]);
              novoJogador.Nome = form["Nome"];
              novoJogador.Email = form["Email"];
              novoJogador.Senha = form["Senha"];

              jogadorModel.Criar(novoJogador);
              ViewBag.Jogadores = jogadorModel.LerTodos();

              return LocalRedirect("~/Jogador/Listar");
        }
    }
}