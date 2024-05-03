
using Landis.Core;
using Landis.Library.UniversalCohorts;
using Landis.SpatialModeling;

namespace Landis.Library.SiteHarvest
{
    /// <summary>
    /// The library's site variables.
    /// </summary>
    public static class SiteVars
    {
        /// <summary>
        /// The site variable with cohorts (accessed as age-only cohorts).
        /// </summary>
        public static ISiteVar<ISiteCohorts> Cohorts { get; private set; }

        //---------------------------------------------------------------------

        /// <summary>
        /// Initializes the library's site variables.
        /// </summary>
        public static void Initialize()
        {
            Cohorts = Model.Core.GetSiteVar<ISiteCohorts>("Succession.AgeCohorts");
        }
    }
}
