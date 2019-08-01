using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
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

            Aluno oAluno = DbAluno.FazerLogin(email, senha);
            Professor oProfessor = DbProf.LoginProfessor(email, senha);

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(senha))
            {
                ModelState.AddModelError("", "Por favor preencha todos os campos");
            }

            else
            {
                if (oAluno != null)
                {
                    //Direcionamento para Pagina Aluno
                    Session["User"] = oAluno;
                    Session["TypeUser"] = "Aluno";
                    return RedirectToAction("MinhasEmpresas", "Empresa");
                }

                else
                {
                    if (email=="professor" && senha=="123")
                    {
                        Session["User"] = "Professor";
                        Session["TypeUser"] = "Professor";
                        return RedirectToAction("Professor", "Home");
                    }
                }

            }

            ModelState.AddModelError("", "Email ou senha incorretos");
            return View();
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            Session.RemoveAll();
            return RedirectToAction("Index", "Login");
        }

    }
}

