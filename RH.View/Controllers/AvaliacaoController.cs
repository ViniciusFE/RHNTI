using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RH.Control;
using RH.Model;

namespace RH.View.Controllers
{
    public class AvaliacaoController : Controller
    {
        private CAvaliacao _Control;

        public AvaliacaoController()
        {
            _Control = new CAvaliacao();
        }
        // GET: Avaliacao
        public ActionResult Index()
        {
            List<Pessoa> Chefes = _Control.SelecionarTodosChefes();
            ViewBag.Pes_Nome = new SelectList(Chefes, "Pes_ID", "Pes_Nome");
            return View(Chefes);
        }

        public ActionResult MeusFuncionarios(int id)
        {
            Pessoa aPessoa = _Control.SelecionarPessoa(id);
            List<Pessoa> MeusFuncionarios = _Control.SelecionarTodosMeusFuncionarios(aPessoa.Pes_Cargo_Car_ID).OrderBy(p => p.Pes_Cargo_Car_ID).ToList();
            int quantidade = MeusFuncionarios.Count;
            string[,] Dados = new string[quantidade, quantidade * 3];
            int posicao = 0;
            foreach (var x in MeusFuncionarios)
            {
                for (var y = 0; y < 3; y++)
                {
                    if (y == 0)
                    {
                        Dados[posicao, y] = x.Pes_Nome;
                    }

                    else if (y == 1)
                    {
                        Cargo oCargo = _Control.SelecionarCargo(x.Pes_Cargo_Car_ID);
                        Dados[posicao, y] = oCargo.Car_Nome;
                    }

                    else
                    {
                        Dados[posicao, y] = x.Pes_ID.ToString();
                    }
                }
            }
            return Json(Dados);
        }

        public FileContentResult GetImagemUsuario(int id)
        {
            Pessoa aPessoa = _Control.SelecionarPessoa(id);
            return File(aPessoa.Pes_Imagem, aPessoa.Pes_Imagem.GetType().ToString());
        }

        public ActionResult AvaliacaoFuncionario(int id,string Avaliacao)
        {
            Avaliacao aAvaliacao = new Avaliacao()
            {
                Ava_Pessoa_Pes_ID = id,
                Ava_Data = DateTime.Now,
                Ava_Situation = true,
            };
            _Control.CadastrarAvaliacao(aAvaliacao);
            return Json("A avaliação do funcionário foi efetuada com sucesso, obrigado!");
        }
    }
}
