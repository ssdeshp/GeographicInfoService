using GeographicInfoEndpoint.Wrappers.GoogleMaps.Entities;
using System.Collections.Generic;

namespace GeographicInfoEndpoint.Wrappers.GoogleMaps.Response
{
    public class ElevationResponse
    {
        public IList<ElevationResultItem> Results { get; set; }
    }
}
