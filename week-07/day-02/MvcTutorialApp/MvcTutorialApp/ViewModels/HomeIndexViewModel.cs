using MvcTutorialApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcTutorialApp.ViewModels
{
    public class HomeIndexViewModel
    {
        public Contact Contact { get; set; }
        public Customer Customer { get; set; }
    }
}
