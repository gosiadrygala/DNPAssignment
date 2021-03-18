using System.Collections.Generic;
using Models;

namespace Families
{
    public interface InterfaceAdultsData
    {
        IList<Adult> GetAllAdults();
        void AddAnAdult(Adult adult);
    }
}