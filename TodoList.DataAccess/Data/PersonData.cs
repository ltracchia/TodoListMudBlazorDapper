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

        public async Task<PersonModel?> GetPersonByUserName(string username)
        {
            var results = await _db.LoadData<PersonModel, dynamic>(storedProcedure: "dbo.spPerson_GetByUserName", new { username });
            return results.FirstOrDefault();
        }
            //=> _db.LoadData<PersonModel, dynamic>(storedProcedure: "dbo.spPerson_GetByUserId", new { id });

        public Task<int> Insert(PersonModel x) =>        
            _db.SaveData(storedProcedure: "dbo.spPerson_Insert", new { x.FirstName, x.LastName, x.UserName });        
    }
}
