using BSD_Test4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSD_Test4
{
    class Program
    {
        static void Main(string[] args)
        {
            MyEntityContext context = new MyEntityContext();

          

            var dancer = new Role();// context.Roles.Create();
            dancer.Id = "Role_Dancer";
            dancer.Name = "Dancer";
            context.Roles.Add(dancer);



            var production = new Production();// context.Productions.Create();
            production.Id = "Blaze";
            production.Title = "Blaze";
            context.Productions.Add(production);

            var performance1 = context.Performances.Create();
            performance1.DateTime = DateTime.Parse("1 Jan 2020 20:00:00");
           // performance1.Production = production; 
            
            var performance2 = context.Performances.Create();
            performance2.DateTime = DateTime.Parse("2 Jan 2020 20:00:00");
            //performance2.Production = production;

            production.Performances.Add(performance1);
            production.Performances.Add(performance2);

            var d1 = new Person();
            d1.FirstName = "Tommy";
            d1.LastName = "Franzen";
            d1.Id = "Tommy_Franzen";

            var pm1 = context.ProductionMembers.Create();
            pm1.Person = d1;
            pm1.Role = dancer;

            var d2 = new Person();
            d2.FirstName = "Lizzie";
            d2.LastName = "Gough";
            d2.Id = "Lizzie_Gough";

            var pm2 = context.ProductionMembers.Create();
            pm2.Person = d2;
            pm2.Role = dancer;

            //var d3 = context.Persons.Create();
            //d3.FirstName = "Angelo";
            //d3.LastName = "Pardo";

            //var pm3 = context.ProductionMembers.Create();
            //pm3.Person = d3;
            //pm3.Role = dancer;

            production.ProductionTeam.Add(pm1);
            production.ProductionTeam.Add(pm2);
            //production.ProductionTeam.Add(pm3);

            context.SaveChanges();
            
            MyEntityContext context1 = new MyEntityContext();
    


        }
    }
}
