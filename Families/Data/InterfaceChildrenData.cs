using System.Collections.Generic;
using Models;

namespace Families
{
    public interface InterfaceChildrenData
    {
        IList<Child> GetAllChildren();
        void AddAChild(Child child);
    }
}