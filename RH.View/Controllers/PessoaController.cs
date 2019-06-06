
using RH.Control;
using RH.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RH.View.Controllers
{
    public class PessoaController : Controller
    {
        private CPessoa DbPessoa = new CPessoa();

        // GET: Funcionario
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MeusFuncionarios()
        {
            List<Pessoa> MeusFuncionarios = DbPessoa.SelecionarTodosFuncionario();
            return View(MeusFuncionarios);
        }

        public ActionResult CadastrarFuncionario()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CadastrarFuncionario(Pessoa oFuncionario, HttpPostedFileBase Imagem)
        {
            if (Imagem != null)
            {

                byte[] Arquivo = new byte[Imagem.ContentLength];
                Imagem.InputStream.Read(Arquivo, 0, Imagem.ContentLength);
                oFuncionario.Pes_Imagem = Arquivo;

            }
            else
            {
                ModelState.AddModelError("Imagem", "Por favor selecione uma foto para o Funcionari");
                return View();
            }

            if (ModelState.IsValid)
            {
                DbPessoa.CadastrarFuncionario(oFuncionario);
                
                return RedirectToAction("MeusFuncionarios");

            }
           

            return View();
        }

    }
}