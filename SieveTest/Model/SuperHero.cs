using Microsoft.AspNetCore.Mvc.RazorPages;
using Sieve.Attributes;
using Sieve.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SieveTest.Model
{
    public class SuperHero
    {
        public int Id { get; set; }

        [Sieve(CanFilter = true, CanSort =true)]
        public string Name { get; set; }

        [Sieve(CanFilter = true, CanSort = true)]
        public string EyeColor { get; set; }

        [Sieve(CanFilter = true, CanSort = true)]
        public Gender Gender { get; set; }

        [Sieve(CanFilter = true, CanSort = true)]
        public string Race { get; set; }

        [Sieve(CanFilter = true, CanSort = true)]
        public string HairColor { get; set; }

        [Sieve(CanFilter = true, CanSort = true)]
        public double Height { get; set; }

        [Sieve(CanFilter = true, CanSort = true)]
        public double Weight { get; set; }

        [Sieve(CanFilter = true, CanSort = true)]
        public string Publisher { get; set; }

        [Sieve(CanFilter = true, CanSort = true)]
        public string SkinColor { get; set; }

        [Sieve(CanFilter = true, CanSort = true)]
        public string Alignment { get; set; }

        
        
        
    }

    public enum Gender
    {
        Male = 1,
        Female = 2
    }

    public class FilterOptions
    {
        public string Sort { get; set; }

        public string Order { get; set; }

        public string Search { get; set; }

        public int Limit { get; set; }

        public int Offset { get; set; }

        public string filter { get; set; }

        private SieveModel _sieveModel;

        public FilterOptions()
        {
            _sieveModel = new SieveModel();
        }

        //public SieveModel ApplyFilter()
        //{
        //    if (!String.IsNullOrEmpty(model.filter))
        //    {
        //        var str1 = filter.Replace(":\"", "==");
        //        var str2 = str1.Replace(@"""", ""); // remove "
        //        var str3 = str2.Replace("\\", ""); // remove \
        //        var str4 = str3.Replace("}", "");
        //        _sieveModel.Filters = str4.Replace("{", "");

        //        _sieveModel.Sorts = "";

        //    }

        //    return _sieveModel;
        //}

       //public SieveModel ApplyPaging()
       //{
            


            
       //     var filteredResult = _sieveProcessor.Apply(sieveModel, SuperHeroList.AsQueryable());
       //     totalRows = filteredResult.Count();

       //     sieveModel.PageSize = model.Limit;
       //     if (model.Offset == 0)
       //         sieveModel.Page = 1;
       //     else
       //         sieveModel.Page = (int)(model.Offset / model.Limit) + 1;
       // }
    }

}
