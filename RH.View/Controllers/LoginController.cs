using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RH.Control;
using RH.Model;
using RH.Model.Repositories;

namespace RH.View.Controllers
{
    public class LoginController : Controller
    {
        private CAluno DbAluno = new CAluno();
        private CProfessor DbProf = new CProfessor();

        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string email, string senha)
        {

            var Aluno = DbAluno.FazerLogin(email, senha);
            var Professor = DbProf.LoginProfessor(email, senha);

            try
            {
                if (string.IsNullOrEmpty(email) && string.IsNullOrEmpty(senha))
                {
                    ModelState.AddModelError("", "Preencha os campos");
                }

                else if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(senha))
                {
                    ModelState.AddModelError("", "Preencha Todos os campos ");
                }

                else
                {


                    if (!string.IsNullOrEmpty(Aluno.Alu_Email))
                    {
                        //Direcionamento para Pagina Aluno
                        Session["User"] = Aluno;
                        return RedirectToAction("MinhasEmpresas", "Empresa");
                    }
                    else
                    {
                        //Verificação se no professor tera um email. se tiver e pq ele existe se nao nao existe cadastro para este professor
                        if (!string.IsNullOrEmpty(Professor.Pro_Email)) // Se a string Pro_Email do Professor nao for Nula ou vazia
                        {
                            //Direcionamento para Pagina Professor
                            Session["User"] = Professor;
                            return RedirectToAction("MinhasEmpresas", "Empresa");
                        }
                        else //User Nao cadastrado ou dados de login errados
                        {
                            ModelState.AddModelError("", "Login ou Senha Invalida");
                        }


                    }

                }

                return View();
            }
            catch
            {
                if (!string.IsNullOrEmpty(Professor.Pro_Email)) // Se a string Pro_Email do Professor nao for Nula ou vazia
                {
                    //Direcionamento para Pagina Professor
                    Session["User"] = Professor;
                    return RedirectToAction("MinhasEmpresas", "Empresa");
                }
                else //User Nao cadastrado ou dados de login errados
                {
                    ModelState.AddModelError("", "Login ou Senha Invalida");
                }

                return View();
            }

        }
    }
}