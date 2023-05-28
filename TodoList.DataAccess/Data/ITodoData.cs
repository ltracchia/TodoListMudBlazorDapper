using TodoList.DataAccess.Models;

namespace TodoList.DataAccess.Data
{
    public interface ITodoData
    {
        Task<IEnumerable<TodoModel>> GetTodos();
        Task Insert(TodoModel x);
        Task Update(TodoModel x);
    }
}