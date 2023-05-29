using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoList.DataAccess.DbAccess;
using TodoList.DataAccess.Models;

namespace TodoList.DataAccess.Data
{
    public class ProjectData : IProjectData
    {
        private readonly ISqlDataAccess _db;

        public ProjectData(ISqlDataAccess db)
        {
            _db = db;
        }

        //public Task Insert(TodoModel x)
        //    => _db.SaveData(storedProcedure: "dbo.spTodo_Insert",
        //    new { x.Description, x.IsComplete, x.IsFavorite });

        public Task Insert(ProjectModel x)
        {
            try
            {
                return _db.SaveData(storedProcedure: "dbo.spProject_Insert", new { x.Name, x.Description });
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
