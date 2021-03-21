using System.Collections.Generic;
using Families;
using FileData;
using Models;

namespace WebFamilies_Assignment.Data.Implementation
{
    public class ImplementationChildrenData : InterfaceChildrenData
    {
        private IList<Family> families = new List<Family>();
        private IList<Child> children = new List<Child>();
        private FileContext fileContext = new FileContext();

        public ImplementationChildrenData(){
            families = fileContext.Families;
        }

        public IList<Child> GetAllChildren()
        {
            foreach (var item in families)
            {
                for (int i = 0; i < item.Children.Count; i++)
                {
                     children.Add(item.Children[i]);
                }
               
            }

            return children;
        }

        public void AddAChild(Child child)
        {
            throw new System.NotImplementedException();
        }
    }
}