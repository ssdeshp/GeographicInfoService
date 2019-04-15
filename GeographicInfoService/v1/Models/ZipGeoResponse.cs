using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeographicInfoEndpoint.v1.Models
{
    public class ZipGeoResponse
    {
        public string ZipCode { get; set; }

        public string City { get; set; }

        public string TimeZoneName { get; set; }

        public string Temperature { get; set; }

        public string Elevation { get; set; }

        public string Message { get; set; }
    }
}
