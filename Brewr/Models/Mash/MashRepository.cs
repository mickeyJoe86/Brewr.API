using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Brewr.Models.Mash
{
    public class MashRepository
    {
        internal List<Mash> GetAll()
        {
            using (var context = new MashContext())
            {
                var mashes = context.Mashes.ToList();
                return mashes;
            }
        }
    }
}