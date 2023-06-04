using TodoList.DataAccess.Models;

namespace TodoList.DataAccess.Data
{
    public interface ITodoData
    {
        Task<IEnumerable<TodoModel>> GetTodos(int todoListId);
        Task<int> Insert(TodoModel x);
        Task Update(TodoModel x);
        Task Delete(int x);
    }
}