using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraversalCoreProje.Data.Abstract;
using TraversalCoreProje.Data.Repository;
using TraversalCoreProje.Entity.Concrete;

namespace TraversalCoreProje.Data.EntityFramework
{
    public class EfFeature2Dal: GenericRepository<Feature2>, IFeature2Dal
    {
    }
}
