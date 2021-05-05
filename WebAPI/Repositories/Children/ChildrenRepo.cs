using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Models;
using WebAPI.DataAccess;

namespace WebAPI.Repositories.Children
{
    public class ChildrenRepo : IChildrenRepo
    {
        public async Task<IList<Child>> GetAllChildren()
        {
            
            using (FamilyDBContext familyDbContext = new FamilyDBContext())
            {
                IList<Child> children = familyDbContext.Children.Include(u => u.Interests)
                    .Include(u => u.Pets).ToList();
                
                for (int i = 0; i < children.Count; i++)
                {
                    for (int j = 0; j < children[i].Interests.Count; j++)
                    {
                        children[i].Interests[j].Children = null;
                    }
                }
                return children;
            }
        }
    }
}