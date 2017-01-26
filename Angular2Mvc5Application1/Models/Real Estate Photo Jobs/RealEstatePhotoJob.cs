using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Angular2Mvc5Application1.Models.PhotoJobs
{
    public class RealEstatePhotoJob
    {
        public int Id { get; set; }
        public DateTime JobDate { get; set; }
        public Common.Address JobAddress { get; set; }
        public RealEstateJobType JobType { get; set; }
        public RealEstateJobAddon[] JobAddons { get; set; }
        public int JobMileage { get; set; }

    }
}
