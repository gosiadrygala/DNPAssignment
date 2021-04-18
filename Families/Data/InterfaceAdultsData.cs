using System.Collections.Generic;
using System.Threading.Tasks;
using Models;

namespace Families
{
    public interface InterfaceAdultsData
    {
        Task<List<Adult>> GetAllAdults();
        Task AddAnAdult(Adult adult);
        void RemoveAnAdult(int id);
    }
}