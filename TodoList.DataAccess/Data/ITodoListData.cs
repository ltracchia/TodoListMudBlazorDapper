using TodoList.DataAccess.Models;

namespace TodoList.DataAccess.Data
{
    public interface ITodoListData
    {
        Task<IEnumerable<TodoListModel>> GetTodoLists();        
        Task<TodoListModel?> GetTodoList(int id);
        Task<int> Insert(TodoListModel x);
        Task Update(TodoListModel x);
        Task Delete(int id);
    }
}