using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RH.Model;
using RH.Control;
using SelectPdf;

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
                return Json("A data selecionada para alteração da data de sua empresa foi um dia que já passou!\nLembre-se que você só pode selecionar uma data futura.");
            }

            else if(DateTime.Compare(Convert.ToDateTime(Data), Convert.ToDateTime(ComparaData)) == 0)
            {
                return Json("Sua empresa já se encontra na data selecionada");
            }

            string Dia="";
            string Mes="";

            if(Convert.ToDateTime(Data).Day.ToString().Count()==1)
            {
                Dia = 0 + Convert.ToDateTime(Data).Day.ToString();
            }

            else
            {
                Dia= Convert.ToDateTime(Data).Day.ToString();
            }

            if (Convert.ToDateTime(Data).Month.ToString().Count()==1)
            {
                Mes = 0 + Convert.ToDateTime(Data).Month.ToString();
            }

            else
            {
                Mes = Convert.ToDateTime(Data).Month.ToString();
            }

            aEmpresa.Emp_DataAtual =  Dia+ "/" +Mes;
            _Control.AlterarEmpresa(aEmpresa);
            Session["DataAtual"] = aEmpresa.Emp_DataAtual;
            return Json("1");
        }

        public ActionResult GerarProva(int id)
        {
            Aluno oAluno = _Control.SelecionarAluno(id);
            Prova aProva = _Control.SelecionarProvaAluno(oAluno.Alu_ID);
            Curso oCurso = _Control.SelecionarCurso(oAluno.Alu_Curso_Cur_ID);

            //Identificação do Aluno
            ViewBag.CodigoProva = aProva.Pro_ID;
            ViewBag.DataTermino = aProva.Pro_DataTermino;
            ViewBag.NomeAluno = oAluno.Alu_Nome;
            ViewBag.Curso = oCurso.Cur_Nome + " - " + oAluno.Alu_Serie+"º ano";

            //Setores

            return View();
        }

        public ActionResult VisualizarProva()
        {
            Aluno oAluno = (Aluno)Session["User"];

            // instantiate a html to pdf converter object 
            HtmlToPdf converter = new HtmlToPdf();
            // create a new pdf document converting an url 
            PdfDocument doc = converter.ConvertUrl("http://localhost:52257/Home/GerarProva/"+oAluno.Alu_ID);

            // save pdf document 
            byte[] pdf = doc.Save();

            // close pdf document 
            doc.Close();

            // return resulted pdf document 
            FileResult fileResult = new FileContentResult(pdf, "application/pdf");
            fileResult.FileDownloadName = "PROVA - "+oAluno.Alu_Nome+".pdf";
            return fileResult;
        }

    }
}
