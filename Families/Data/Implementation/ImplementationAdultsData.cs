using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using Families;
using FileData;
using Models;

namespace WebFamilies_Assignment.Data.Implementation
{
    public class ImplementationAdultsData : InterfaceAdultsData
    {
        private IList<Adult> adults = new List<Adult>();
        private FileContext fileContext = new FileContext();

        public ImplementationAdultsData(){
            adults = fileContext.Adults;
        }
        
        public IList<Adult> GetAllAdults(){
            List<Adult> adultsCopy = new List<Adult>(adults);
            return adultsCopy;
        }

        public void AddAnAdult(Adult adult) {
            int max = adults.Max(adult => adult.Id);
            adult.Id = (++max);
            adults.Add(adult);
            fileContext.SaveChanges();
        }

        public void RemoveAnAdult(int id) {
            Adult adult = adults.First(adult => adult.Id == id);
            adults.Remove(adult);
            fileContext.SaveChanges();
        }
    }
}