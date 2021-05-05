using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using Newtonsoft.Json;

namespace Models {
public class Interest {
    
    public string Type { get; set; }
    public string Description { get; set; }
    public int Id { get; set; }
    [JsonIgnore]
    public IList<Child>? Children { get; set; }
    public override string ToString()
    {
        return Type + Description;
    }
}
}