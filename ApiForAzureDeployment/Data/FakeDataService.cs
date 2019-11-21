using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiForAzureDeployment.Models;

namespace ApiForAzureDeployment.Data
{
    public class FakeDataService
    {
        public List<Person> People { get; set; }
        public FakeDataService()
        {

            People = new List<Person>()
            {
                new Person
                {
                    Id = 1,
                    Firstname = "A",
                    Lastname = "B"
                },
                new Person
                {
                    Id = 2,
                    Firstname = "C",
                    Lastname = "D"
                }
            };
        }
        
        public List<Person> GetPeople()
        {
            return People;
        }
    }
}
