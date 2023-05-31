using TodoList.DataAccess.Models;

namespace TodoList.DataAccess.Data
{
    public interface ITodoListData
    {
        Task<int> Insert(TodoListModel x);
        Task Update(TodoListModel x);
    }
}