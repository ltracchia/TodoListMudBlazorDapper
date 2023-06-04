using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoList.DataAccess.DbAccess;
using TodoList.DataAccess.Models;

namespace TodoList.DataAccess.Data
{
    public class TodoData : ITodoData
    {
        private readonly ISqlDataAccess _db;

        public TodoData(ISqlDataAccess db)
        {
            _db = db;
        }

        //public Task<List<TodoModel>> GetTodos()
        //{
        //    string sql = "select * from dbo.Todo";

        //    return _db.LoadData<TodoModel, dynamic>(sql, new { });
        //}

        public Task<IEnumerable<TodoModel>> GetTodos(int todoListId)
            => _db.LoadData<TodoModel, dynamic>(storedProcedure: "dbo.spTodo_GetAll", new { todoListId });

        //public Task Insert(TodoModel x)
        //    => _db.SaveData(storedProcedure: "dbo.spTodo_Insert",
        //    new { x.Description, x.IsComplete, x.IsFavorite });

        public Task<int> Insert(TodoModel x)
        {
            try
            {
                return _db.SaveData(storedProcedure: "dbo.spTodo_Insert", new { x.Name, x.Description });                
            }
            catch(Exception ex)
            {
                throw;
            }
        }    

        public Task Update(TodoModel x)                 
            => _db.SaveData(storedProcedure: "dbo.spTodo_Update", 
            new { x.Id, x.Name, x.Description, x.IsComplete, x.IsFavorite, x.IsDeleted });
        

        public Task Delete(int id)
            => _db.SaveData(storedProcedure: "dbo.spTodo_Delete", 
                new { id });        


    }
}
