using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NwndWebApi.Models.DTO
{
    [ModelMetadataType(typeof(CategoriesMD))]
    public partial class Categories : CategoriesMD
    {
    }
    public interface CategoriesMD
    {
        [JsonIgnore]
        ICollection<Products> Products { get; set; }
    }
}
