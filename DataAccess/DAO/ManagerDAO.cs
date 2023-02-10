using BussinessObject.Data;
using BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAO
{
    public class ManagerDAO
    {
        Context context;
        public void AddManager(Manager manager)
        {
            context.Add(manager);
            context.SaveChanges();
        }
    }
}
