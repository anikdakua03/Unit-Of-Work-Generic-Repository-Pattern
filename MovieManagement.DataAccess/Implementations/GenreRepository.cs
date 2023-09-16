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
    public class GenreRepository : GenericRepository<Genre> , IGenreRepository
    {
        private readonly MovieManagementDbContext _movieManagementDbContext;
        public GenreRepository(MovieManagementDbContext movieManagementDbContext) : base(movieManagementDbContext)
        {
            _movieManagementDbContext = movieManagementDbContext;
        }
    }
}
