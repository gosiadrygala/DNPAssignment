using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace WebAPI.Repositories.Adult
{
    public interface IAdultRepo
    {
        Task<IList<Models.Adult>> GetAllAdults();
        Task<ActionResult<Models.Adult>> AddAnAdult(Models.Adult adult);
        Task<bool> RemoveAnAdult(int id);
    }
}