using DemoProject.IRepository;
using DemoProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoProject.Repository
{
    public class AgentRepository : IAgentRepository
    {
       private DemoProjectEntities DemoProjectEntities;

        public AgentRepository()
        {
            DemoProjectEntities = new DemoProjectEntities();
        }

        public IEnumerable<Agent> GetAllAgents()
        {
            return DemoProjectEntities.Agents.ToList();
        }
    }
}