using System.Collections.Generic;
using System.Threading.Tasks;
using Models;

namespace WebAPI.Repositories.Children
{
    public interface IChildrenRepo
    {
        Task<IList<Child>> GetAllChildren();
    }
}