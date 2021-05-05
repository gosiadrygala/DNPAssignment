using System.Collections.Generic;

namespace Models {
public class Child : Person {
    
    public IList<Interest> Interests { get; set; }
    public List<Pet> Pets { get; set; }

   
}
}