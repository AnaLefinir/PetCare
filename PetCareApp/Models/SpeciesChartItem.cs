using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PetCareApp.Models
{
    public class SpeciesChartItem
    {
        public string Name { get; set; }
        public int Count { get; set; }
    }
}