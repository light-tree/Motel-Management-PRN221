using BussinessObject.Data;
using BussinessObject.Models;
using BussinessObject.Status;
using DataAccess.Repository;
using System;
using System.Linq;

namespace Test
{
    public class Program
    {
        static void Main(string[] args)
        {
            IManagerRepo managerRepo;
            try
            {
                Manager manager = new Manager();
                manager.FullName = "1";
                manager.Status = AccountStatus.ACTIVE;
                manager.IdentityCardNumber = "123456789012";
                manager.UserName = "1";
                manager.Password = "1";

                //managerRepo.AddManager(manager);

                //Context context = new Context();
                //context.Managers.Add(manager);
                //context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            //Manager manager = new Manager();
            ////manager.Id = 1;
            //manager.FullName = "1";
            //manager.Status = 1;
            //manager.IdentityCardNumber = "123456789012";
            //manager.UserName = null;
            //manager.Password = "1";

            //Context context = new Context();
            ////context.Managers.Add(manager);
            ////context.SaveChanges();

            //Resident resident = context.Residents.FirstOrDefault(m => m.Id == 1);
            //Console.WriteLine(resident.IdentityCardNumber);
        }
    }
}
