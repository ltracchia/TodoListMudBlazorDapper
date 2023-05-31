using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoList.DataAccess.DbAccess;
using TodoList.DataAccess.Models;

namespace TodoList.DataAccess.Data
{
    public class TodoListData : ITodoListData
    {
        private readonly ISqlDataAccess _db;

        public TodoListData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<int> Insert(TodoListModel x)
        {
            try
            {
                return _db.SaveData(storedProcedure: "dbo.spTodoList_Insert", new { x.Name, x.Description });
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public Task Update(TodoListModel x)
        {
            try
            {
                return _db.SaveData(storedProcedure: "dbo.spTodoList_Update", new { x.Id, x.ProjectId, x.Name, x.Description });
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
