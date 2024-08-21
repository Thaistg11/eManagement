using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace eManagement.Models
{
    public class Site
    {
        public int Id { get; set; }
        public string SiteName { get; set; }
        public string Adress1 { get; set; }
        public string Adress2 { get; set; }
        public string PostCode { get; set; }
        public string FoneNumeber { get; set; }

    }
}

