using RH.Control;
using RH.Model;
using RH.View.Filtro;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Web;
using System.Web.Mvc;

namespace RH.View.Controllers
{
    [AutorizacaoEmpresa]
    public class PessoaController : Controller
    {
        private CPessoa DbPessoa = new CPessoa();

        // GET: Funcionario
        public ActionResult Index()
        {
            return View();
        }
        //cadastro de Funcionario
        public ActionResult CadastrarFuncionario()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CadastrarFuncionario(Pessoa oFuncionario, HttpPostedFileBase Imagem)
        {
            try
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
                if (oFuncionario.Pes_Nome == null)
                {
                    ModelState.AddModelError("Nome", "Por favor selecionenome o Funcionari");
                    return View();
                }
                if (oFuncionario.Pes_CPF == null)
                {
                    ModelState.AddModelError("CPF", "Por favor selecione cpf o Funcionari");
                    return View();
                }
                else
                {
                    DbPessoa.AlterarFuncionario(oFuncionario);
                    return RedirectToAction("MeusFuncionarios");
                }

            }
            catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {
                    Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                        ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw;
            }

        }

        //edição dados do Funcionario

        public ActionResult AlterarFuncionario(int id)
        {
            var aPessoa = DbPessoa.SelecionarFuncionario(id);

            return View(aPessoa);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AlterarFuncionario(Pessoa oFuncionario, HttpPostedFileBase Imagem)
        {
            try
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
                if (oFuncionario.Pes_Nome == null)
                {
                    ModelState.AddModelError("Nome", "Por favor selecionenome o Funcionari");
                    return View();
                }
                if (oFuncionario.Pes_CPF == null)
                {
                    ModelState.AddModelError("CPF", "Por favor selecione cpf o Funcionari");
                    return View();
                }
                else
                {

                    DbPessoa.AlterarFuncionario(oFuncionario);

                    return RedirectToAction("MeusFuncionarios");
                }

            }
            catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {
                    Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw;
            }
        }


        public FileContentResult GetImagemFuncionario(int id)
        {
            var aPessoa = DbPessoa.SelecionarFuncionario(id);
            return File(aPessoa.Pes_Imagem, aPessoa.Pes_Imagem.GetType().ToString());
        }

        public ActionResult MeusFuncionarios()
        {
            int IDEmpresa = Convert.ToInt32(Session["IDEmpresa"]);
            List<Pessoa> Funcionarios = DbPessoa.SelecionarTodosFuncionariosEmpresa(IDEmpresa);
            List<Setor> Setores = DbPessoa.SelecionarTodosSetores(IDEmpresa);
            List<Cargo> Cargos = DbPessoa.SelecionarCargosEmpresa(IDEmpresa);
            ViewBag.Setores = Setores;
            ViewBag.Cargos = Cargos;
            return View(Funcionarios);
        }

    }

}
