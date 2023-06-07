using TodoList.DataAccess.Models;

namespace TodoList.DataAccess.Data
{
    public interface IPersonData
    {
        Task<int> Insert(PersonModel x);
        Task<PersonModel?> GetPersonByUserName(string username);
    }
}