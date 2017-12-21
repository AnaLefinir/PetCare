using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PetCareApp.Models;

namespace PetCareApp.ModelView.Home
{
    public class HomeModel
    {
        public List<IncomeChartItem> IncomeChartItems { get; set; }
        public List<SpeciesChartItem> SpeciesChartItems { get; set; }
    }
}