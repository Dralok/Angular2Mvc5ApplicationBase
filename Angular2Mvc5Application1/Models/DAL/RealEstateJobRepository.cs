using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Angular2Mvc5Application1.Models.DAL
{
    public class RealEstateJobRepository
    {
        private static PhotoJobs.RealEstateJobType[] _mockTypes =
        {
            new PhotoJobs.RealEstateJobType { Id = 1, Description = "up to 1999 sf", Charge = 80, Active = true },
            new PhotoJobs.RealEstateJobType { Id = 2, Description = "2000-3499 sf", Charge = 95, Active = true },
            new PhotoJobs.RealEstateJobType { Id = 3, Description = "3500-4999 sf", Charge = 115, Active = true }
        };
        private static PhotoJobs.RealEstateJobAddon[] _mockAddons =
        {
            new PhotoJobs.RealEstateJobAddon { Id=1, Description = "House Front only (already nearby)", Charge = 35, Active=true },
            new PhotoJobs.RealEstateJobAddon { Id=2, Description = "Exteriors Only Shoot", Charge = 45, Active=true },
            new PhotoJobs.RealEstateJobAddon { Id=3, Description = "Partial Re-shoot", Charge = 60, Active=true },
            new PhotoJobs.RealEstateJobAddon { Id=4, Description = "Full Interior Re-shoot", Charge = -15, Active=true }
        };
        private static Models.PhotoJobs.RealEstatePhotoJob[] _mockJobs = 
        {
            new PhotoJobs.RealEstatePhotoJob { Id = 1,
                JobDate = new DateTime(2017,1,10),
                JobMileage = 10,
                JobType = _mockTypes[0],
                JobAddons = new PhotoJobs.RealEstateJobAddon[0],
                JobAddress = new Common.Address { Line1 = "1910 Opal Dr" }
            },
            new PhotoJobs.RealEstatePhotoJob { Id = 2,
                JobDate = new DateTime(2017,1,12),
                JobMileage = 15,
                JobType = _mockTypes[1],
                JobAddons = new PhotoJobs.RealEstateJobAddon[0],
                JobAddress = new Common.Address { Line1 = "1443 Cantwell Ct" }
            },
            new PhotoJobs.RealEstatePhotoJob { Id = 3,
                JobDate = new DateTime(2017,1,18),
                JobMileage = 15,
                JobType = _mockTypes[1],
                JobAddons = new PhotoJobs.RealEstateJobAddon[0],
                JobAddress = new Common.Address { Line1 = "2420 Regents Park Ln" }
            },
            new PhotoJobs.RealEstatePhotoJob { Id = 4,
                JobDate = new DateTime(2017,1,12),
                JobMileage = 15,
                JobType = _mockTypes[1],
                JobAddons = new PhotoJobs.RealEstateJobAddon[] {_mockAddons[4] },
                JobAddress = new Common.Address { Line1 = "1700 #H5 N Elm St" }
            }
        };
        
        public IEnumerable<PhotoJobs.RealEstatePhotoJob> GetJobs()
        {
            return _mockJobs;
        }
    }
}
