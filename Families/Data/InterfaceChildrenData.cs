using System.Collections.Generic;
using System.Threading.Tasks;
using Models;

namespace Families
{
    public interface InterfaceChildrenData
    {
        Task<IList<Child>> GetAllChildren();
    }
}