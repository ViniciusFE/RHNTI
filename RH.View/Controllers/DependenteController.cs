using System.Web.Mvc;
using RH.Model;
using RH.Control;

namespace RH.View.Controllers
{
    public class DependenteController : Controller
    {
        CDependente _Control;

        public DependenteController()
        {
            _Control = new CDependente();
        }

        public ActionResult Index(int IDFuncionario)
        {
            return View(_Control.SelecionarDependetesFuncionario(IDFuncionario));
        }

        public ActionResult CadastrarDependente(int IDFuncionario)
        {
            ViewBag.IDFuncionario = IDFuncionario;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CadastrarFuncionario(DadoDependente oDependente)
        {
            if(ModelState.IsValid)
            {
                _Control.CadastrarDependente(oDependente);
                return RedirectToAction("MeusFuncionarios", "Pessoa");
            }

            return View();
        }

        public ActionResult AlterarDependete(int id)
        {
            DadoDependente Dependente = _Control.SelecionarDependente(id);
            return View(Dependente);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AlterarDependente(DadoDependente oDependente)
        {
            if(ModelState.IsValid)
            {
                _Control.AlterarDependente(oDependente);
                return RedirectToAction("MeusFuncionarios", "Pessoa");
            }

            return View();
        }
    }
}
