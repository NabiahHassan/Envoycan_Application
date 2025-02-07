using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace Envoycan_Application.Models
{
    public class Services
    {
        public class ACRepair
        {
            [Key]
            public int ACRepairID { get; set; }
            public string ACRepairName { get; set; }
        }
        public class Carpenter
        {
            [Key]
            public int CarpenterServiceID { get; set; }
            public string CarpenterServiceName { get; set; }
        }
        public class HouseCleaning
        {
            [Key]
            public int HouseCleaningID { get; set; }
            public string HouseCleaningName { get; set; }
        }
        public class Painter
        {
            [Key]
            public int PainterID { get; set; }
            public string PainterName { get; set; }
        }
        public class PestControl 
        {
            [Key]
            public int PestControlID { get; set; }
            public string PestControlName { get; set; }
        }
        public class Plumber
        {
            [Key]
            public int PlumberID { get; set; }
            public string PlumberName { get; set; }
        }
        public class Salon
        {
            [Key]
            public int SalonID { get; set; }
            public string SalonName { get; set; }
        }
        public class SmartHome
        {
            [Key]
            public int SmartHomeID { get; set; }
            public string SmartHomeName { get; set; }
        }
    }
}
