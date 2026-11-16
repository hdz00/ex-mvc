using Microsoft.AspNetCore.Mvc;
using teste.Models;

namespace teste.Controllers
{
    public class HomeController:Controller
    {
        public IActionResult Index()
        {
            List<Servico> servicos=new List<Servico>
            {
                new Servico
                {
                    Nome="xxx",
                    Descricao="Lorem ipsum dolor sit amet consectetur adipiscing elit.",
                    Preco=500
                },

                new Servico
                {
                    Nome="yyy",
                    Descricao="Lorem ipsum dolor sit amet consectetur adipiscing elit.",
                    Preco=200
                },

                new Servico
                {
                    Nome="zzz",
                    Descricao="Lorem ipsum dolor sit amet consectetur adipiscing elit.",
                    Preco=150
                },

                new Servico
                {
                    Nome="aaa",
                    Descricao="Lorem ipsum dolor sit amet consectetur adipiscing elit.",
                    Preco=100
                },

                new Servico
                {
                    Nome="bbb",
                    Descricao="Lorem ipsum dolor sit amet consectetur adipiscing elit.",
                    Preco=50
                }
            };

            Promocao promocao=new Promocao
            {
                Nome="hhh",
                Descricao="Lorem ipsum dolor sit amet consectetur adipiscing elit.",
                Desconto=20
            };

            HomeViewModel dados=new HomeViewModel
            {
                Servicos=servicos,
                Promocao=promocao
            };

            return View(dados);
        }

        public IActionResult Sobre()
        {
            return View();
        }

        public IActionResult Servicos()
        {
            return View();
        }

        public IActionResult Registro()
        {
            return View();
        }
    }
}