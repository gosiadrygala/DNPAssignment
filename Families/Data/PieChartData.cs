using System.Collections.Generic;
using System.Threading.Tasks;
using Models;
using WebFamilies_Assignment.Data.Implementation;

namespace Families
{
    public class PieChartData
    {
        public int Amount { get; set; }
        public int TotalAmount { get; set; }
        public string HairColor { get; set; }

        public string TotalPercentage => (this.Amount * 100) / this.TotalAmount + "%";

        private List<Adult> adults = new List<Adult>();
        private IList<Child> children = new List<Child>();

        public async Task<List<PieChartData>> GetPieChartDatas()
        {
            adults =  await new ImplementationAdultsData().GetAllAdults();
            children = await new ImplementationChildrenData().GetAllChildren();
            List<PieChartData> pieChartData = new List<PieChartData>();
            int totalAmount = adults.Count + children.Count;
            pieChartData.Add(new PieChartData(){HairColor = "Black", TotalAmount = totalAmount, Amount = GetHairColorAmount("Black")});
            pieChartData.Add(new PieChartData(){HairColor = "Grey", TotalAmount = totalAmount, Amount = GetHairColorAmount("Grey")});
            pieChartData.Add(new PieChartData(){HairColor = "Blond", TotalAmount = totalAmount, Amount = GetHairColorAmount("Blond")});
            pieChartData.Add(new PieChartData(){HairColor = "Brown", TotalAmount = totalAmount, Amount = GetHairColorAmount("Brown")});
            pieChartData.Add(new PieChartData(){HairColor = "White", TotalAmount = totalAmount, Amount = GetHairColorAmount("White")});
            return pieChartData;
        }

        private int GetHairColorAmount(string haircolor) {
            int amount = 0;
            foreach (var item in adults)
            {
                if (item.HairColor.Equals(haircolor))
                {
                    amount++;
                }
            }

            foreach (var item in children)
            {
                if (item.HairColor.Equals(haircolor))
                {
                    amount++;
                }
            }
            return amount;
        }
    }
}