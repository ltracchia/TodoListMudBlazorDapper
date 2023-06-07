using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoList.DataAccess.DbAccess;
using TodoList.DataAccess.Models;

namespace TodoList.DataAccess.Data
{
    public class PersonData : IPersonData
    {
        private readonly ISqlDataAccess _db;

        public PersonData(ISqlDataAccess db)
        {
            _db = db;
        }
        public Task<int> Insert(PersonModel x) =>        
            _db.SaveData(storedProcedure: "dbo.spPerson_Insert", new { x.FirstName, x.LastName, x.UserId });        
    }
}
