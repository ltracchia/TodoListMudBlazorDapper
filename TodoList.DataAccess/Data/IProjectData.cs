using TodoList.DataAccess.Models;

namespace TodoList.DataAccess.Data
{
    public interface IProjectData
    {
        Task Insert(ProjectModel x);
    }
}