using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Registration.Models
{
    public class Register
    {
        [Display(Name = "Date", ResourceType = typeof(Resource))]
        [Required(ErrorMessageResourceType = typeof(Resource), ErrorMessageResourceName = "DateRequired")]
        public string Date
        {
            get;
            set;
        }
        [Display(Name = "Time", ResourceType = typeof(Resource))]
        [Required(ErrorMessageResourceType = typeof(Resource), ErrorMessageResourceName = "TimeRequired")]
        public string Time
        {
            get;
            set;
        }
        [Display(Name = "Name", ResourceType = typeof(Resource))]
        [Required(ErrorMessageResourceType = typeof(Resource), ErrorMessageResourceName = "NameRequired")]
        public string Name
        {
            get;
            set;
        }
        [Display(Name = "District", ResourceType = typeof(Resource))]
        [Required(ErrorMessageResourceType = typeof(Resource), ErrorMessageResourceName = "DistrictRequired")]
        public string District
        {
            get;
            set;
        }
        [Display(Name = "Taluka", ResourceType = typeof(Resource))]
        [Required(ErrorMessageResourceType = typeof(Resource), ErrorMessageResourceName = "TalukaRequired")]
        public string Taluka
        {
            get;
            set;
        }
        [Display(Name = "Village", ResourceType = typeof(Resource))]
        [Required(ErrorMessageResourceType = typeof(Resource), ErrorMessageResourceName = "VillageRequired")]
        public string Village
        {
            get;
            set;
        }
        [Display(Name = "Mobile_No", ResourceType = typeof(Resource))]
        [Required(ErrorMessageResourceType = typeof(Resource), ErrorMessageResourceName = "MobileNoRequired")]
        public string Mobile_No
        {
            get;
            set;
        }
        [Display(Name = "No_Of_Live_Stock", ResourceType = typeof(Resource))]
        [Required(ErrorMessageResourceType = typeof(Resource), ErrorMessageResourceName = "StockRequired")]
        public string No_Of_Live_Stock
        {
            get;
            set;
        }

    }
}