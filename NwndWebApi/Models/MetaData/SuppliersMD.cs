using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NwndWebApi.Models.DTO
{
    [ModelMetadataType(typeof(SuppliersMD))]
    public partial class Suppliers : SuppliersMD
    {
    }
    public interface SuppliersMD
    {
        [JsonIgnore]
        ICollection<Products> Products { get; set; }
    }
}
