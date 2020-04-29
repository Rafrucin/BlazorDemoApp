using DataAccessLib.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLib
{
    public interface IPeopleData
    {
        Task<List<PersonModel>> GetPeople();
        Task InserPerson(PersonModel person);
    }
}