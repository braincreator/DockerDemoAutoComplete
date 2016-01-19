using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNet.Mvc.Rendering;

namespace AutoComplete.Models
{
    public class AutoCompleteModel
    {
        public AutoCompleteModel()
        {
           
        }
    }

    public class Product
    {
        public Product()
        {
            
        }

        public int Id { get; set; }
        public string Name { get; set; }
    }
}