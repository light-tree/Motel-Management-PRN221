using BussinessObject.Models;
using DataAccess.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class ManagerRepo : IManagerRepo
    {
        ManagerDAO managerDAO;
        public void AddManager(Manager manager)
        {
            managerDAO.AddManager(manager);
        }
    }
}
