using DemoProject.IRepository;
using Rotativa;
using System;
using System.Linq;
using System.Web.Mvc;

namespace DemoProject.Controllers
{
    [HandleError(View = "Error")]
    public class AgentController : Controller
    {
        private IAgentRepository agentRepository;

        public AgentController(IAgentRepository _agentRepository)
        {
            this.agentRepository = _agentRepository;
        }
        // GET: Agent DashBoard   
        public ActionResult Dashboard()
        {
            var agentlist = agentRepository.GetAllAgents();

            ViewBag.SALES = agentlist.Select(x => x.Sales);
            ViewBag.AGENTS = agentlist.Select(x => x.AgentID);
            return View();
        }
        
        public ActionResult PrintPDF()
        {
            var pdf = new ActionAsImage("Dashboard");       
            //{
            //    FileName = Guid.NewGuid().ToString() + ".pdf"                
            //};
            return pdf;
        }

    }
}