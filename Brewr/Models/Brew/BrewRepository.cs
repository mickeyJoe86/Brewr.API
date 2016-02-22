using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Brewr.Models.Brew
{
    public class BrewRepository
    {
        internal List<Brew> GetAll()
        {
            using (var context = new BrewContext())
            {
                var brews = context.Brews.ToList();
                return brews;
            }
        }
    }
}