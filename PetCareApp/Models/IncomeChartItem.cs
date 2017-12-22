using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PetCareApp.Models
{
    public class IncomeChartItem
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public double Income { get; set; }
    }
}