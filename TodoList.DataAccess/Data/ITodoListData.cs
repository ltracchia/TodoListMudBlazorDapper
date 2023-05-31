using TodoList.DataAccess.Models;

namespace TodoList.DataAccess.Data
{
    public interface ITodoListData
    {
        Task<IEnumerable<TodoListModel>> GetTodoList(int id);
        Task<int> Insert(TodoListModel x);
        Task Update(TodoListModel x);
    }
}