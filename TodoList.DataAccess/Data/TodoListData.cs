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

        public Task<IEnumerable<TodoListModel>> GetTodoLists()
            => _db.LoadData<TodoListModel, dynamic>(storedProcedure: "dbo.spTodoList_GetAll", new {  });

        public async Task<TodoListModel?> GetTodoList(int id)
        {
            var results =  await _db.LoadData<TodoListModel, dynamic>(storedProcedure: "dbo.spTodoList_GetById", new { id });
            return results.FirstOrDefault(); 
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
                return _db.SaveData(storedProcedure: "dbo.spTodoList_Update", new { x.Id, x.ProjectId, x.Name, x.Description, x.IsDeleted });
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public Task Delete(int id)
        {
            try
            {
                return _db.SaveData(storedProcedure: "dbo.spTodoList_Delete", new { id });
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
