using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CheeseMVC.Models;

namespace CheeseMVC.Views.Menu
{
    public class ViewMenuViewModel
    {
        public CheeseMVC.Models.Menu { get; set; }
        public IList<CheeseMenu> Items { get; set; }

    }
}
