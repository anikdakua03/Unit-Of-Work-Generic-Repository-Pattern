using MovieManagement.DataAccess.Context;
using MovieManagement.Domain.Entities;
using MovieManagement.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManagement.DataAccess.Implementations
{
    public class BiographyRepository : GenericRepository<Biography> , IBiographyRepository
    {
        private readonly MovieManagementDbContext _movieManagementDbContext;
        public BiographyRepository(MovieManagementDbContext movieManagementDbContext) : base(movieManagementDbContext)
        {
            _movieManagementDbContext = movieManagementDbContext;
        }
    }
}
