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
    [Autorizacao]
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
        [AutorizacaoEmpresa]
        public ActionResult CadastrarFuncionario(Pessoa oFuncionario, HttpPostedFileBase Imagem)
        {
            var cargo = oFuncionario.Pes_Cargo_Car_ID;

            if (DbPessoa.AutenticaCargo(cargo) == true)
            {
                ModelState.AddModelError("", "Este Cargo ja Pertence a Outro Funcionário");
                return View();
            }
            else
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
                        ModelState.AddModelError("Imagem", "Por favor selecione uma foto para o Funcionário");
                        return View();
                    }
                    if (oFuncionario.Pes_Nome == null)
                    {
                        ModelState.AddModelError("Nome", "Por favor digite o nome o Funcionário");
                        return View();
                    }
                    if (oFuncionario.Pes_CPF == null)
                    {
                        ModelState.AddModelError("CPF", "Por favor digite o CPF do Funciónario");
                        return View();
                    }
                    else
                    {
                        oFuncionario.Pes_Situation = true;
                        DbPessoa.CadastrarFuncionario(oFuncionario);
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

        }

        //edição dados do Funcionario

        [AutorizacaoEmpresa]
        public ActionResult AlterarFuncionario(int id)
        {
            var aPessoa = DbPessoa.SelecionarFuncionario(id);

            return View(aPessoa);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [AutorizacaoEmpresa]
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
                    ModelState.AddModelError("Imagem", "Por favor selecione uma foto para o Funcionário");
                    return View();
                }
                if (oFuncionario.Pes_Nome == null)
                {
                    ModelState.AddModelError("Nome", "Por favor selecionenome o Funcionário");
                    return View();
                }
                if (oFuncionario.Pes_CPF == null)
                {
                    ModelState.AddModelError("CPF", "Por favor selecione cpf o Funcionário");
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

        [AutorizacaoEmpresa]
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

        public ActionResult Demitir(int id,string Motivo)
        {
            Pessoa aPessoa = DbPessoa.SelecionarFuncionario(id);
            aPessoa.Pes_Situation = false;
            DbPessoa.AlterarFuncionario(aPessoa);

            Demissao aDemissao = new Demissao()
            {
                Dem_Data = DateTime.Now,
                Dem_Motivo = Motivo,
                Dem_Pessoa_Pes_ID = id,
                Dem_Situation = true
            };

            if(Motivo=="Pediu demissão")
            {
                aDemissao.Dem_Salario = aPessoa.Pes_Salario * 2;
            }

            else
            {
                aDemissao.Dem_Salario = aPessoa.Pes_Salario - (aPessoa.Pes_Salario / 2);
            }

            DbPessoa.CadastrarDemissao(aDemissao);

            return Json("O funcionário foi demitido com sucesso!");
        }

    }

}
