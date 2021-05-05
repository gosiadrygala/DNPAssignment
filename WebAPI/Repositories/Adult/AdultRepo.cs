using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Models;
using WebAPI.DataAccess;


namespace WebAPI.Repositories.Adult
{
    public class AdultRepo : IAdultRepo
    {
        public async Task<IList<Models.Adult>> GetAllAdults()
        {
            using (FamilyDBContext familyDbContext = new FamilyDBContext())
            {
                IList<Models.Adult> adults = familyDbContext.Adults.Include(u => u.JobTitle).ToList();
                return adults;
            }
            
        }

        public async Task<ActionResult<Models.Adult>> AddAnAdult(Models.Adult adult)
        {
            using (FamilyDBContext familyDbContext = new FamilyDBContext())
            {
                int id = familyDbContext.Adults.OrderBy(adult1 => adult1.Id).Last().Id;
                adult.Id = id + 1;
                familyDbContext.Adults.Add(adult); 
                await familyDbContext.SaveChangesAsync();
            }

            return adult;
        }

        public async Task<bool> RemoveAnAdult(int id)
        {
            
            using (FamilyDBContext familyDbContext = new FamilyDBContext())
            {
                try
                {

                    Models.Adult adult = await familyDbContext.Adults.FirstAsync(a => a.Id == id);
                    Job job =  await familyDbContext.Jobs.FirstAsync(j => j.Id == adult.JobTitle.Id);
                
                
                    familyDbContext.Adults.Remove(adult);
                    familyDbContext.Remove(job);
                    await familyDbContext.SaveChangesAsync();
                    return true;
                }
                catch (Exception e)
                {
                    return false;
                }
            }

            

        }
    }
}