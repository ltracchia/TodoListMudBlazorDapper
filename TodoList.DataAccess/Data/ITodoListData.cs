using TodoList.DataAccess.Models;

namespace TodoList.DataAccess.Data
{
    public interface ITodoListData
    {
        Task Insert(TodoListModel x);
        Task Update(TodoListModel x);
    }
}