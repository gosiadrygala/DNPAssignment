using System.Collections.Generic;
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
    }
}