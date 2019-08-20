using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RH.Model;
using RH.Control;

namespace RH.View.Controllers
{
    public class HomeController : Controller
    {
        private CEmpresa _Control;

        public HomeController()
        {
            _Control = new CEmpresa();
        }


        public ActionResult Index(int id,string nomeEmpresa)
        {
            Session["IDEmpresa"] = id;
            Session["NomeEmpresa"] = nomeEmpresa;

            Empresa aEmpresa = _Control.SelecionarEmpresa(id);
            if(aEmpresa.Emp_Avaliativa)
            {
                Session["Avaliativa"] = true;
            }

            else
            {
                Session["Avaliativa"] = false;
            }

            Session["DataAtual"] = aEmpresa.Emp_DataAtual;
            
            return View();
        }

        public ActionResult Professor()
        {
            return View();
        }

        public ActionResult MudarDataEmpresa(string Data)
        {
            Empresa aEmpresa = _Control.SelecionarEmpresa(Convert.ToInt32(Session["IDEmpresa"]));

            string ComparaData = aEmpresa.Emp_DataAtual + "/2019";

            if(DateTime.Compare(Convert.ToDateTime(Data),Convert.ToDateTime(ComparaData))<0)
            {
                return Json("A data atual selecionada para alteração da data de sua empresa foi um dia que já passou!\nLembre-se que você só pode selecionar uma data futura.");
            }

            else if(DateTime.Compare(Convert.ToDateTime(Data), Convert.ToDateTime(ComparaData)) == 0)
            {
                return Json("Sua empresa já se encontra na data selecionada");
            }

            aEmpresa.Emp_DataAtual = Convert.ToDateTime(Data).Day.ToString() + "/" + Convert.ToDateTime(Data).Month;
            _Control.AlterarEmpresa(aEmpresa);
            Session["DataAtual"] = aEmpresa.Emp_DataAtual;
            return Json("A data atual de sua empresa foi alterada com sucesso, lembre-se que não é possível ir para uma data anterior a está.");
        }

    }
}
