using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Netshoes.Api.V1.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class ImageResource {
    
    
    [DataMember(Name="url", EmitDefaultValue=false)]
    public string Url { get; set; }

    
    
    [DataMember(Name="links", EmitDefaultValue=false)]
    public List<Link> Links { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ImageResource {\n");
      
      sb.Append("  Url: ").Append(Url).Append("\n");
      
      sb.Append("  Links: ").Append(Links).Append("\n");
      
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
  
  
}
