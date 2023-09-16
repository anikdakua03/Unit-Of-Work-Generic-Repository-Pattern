using Microsoft.EntityFrameworkCore;
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
    public class ActorRepository : GenericRepository<Actor> , IActorRepository
    {
        private readonly MovieManagementDbContext _movieManagementDbContext;
        public ActorRepository(MovieManagementDbContext movieManagementDbContext) : base(movieManagementDbContext)
        {
            _movieManagementDbContext = movieManagementDbContext;
        }

        public IEnumerable<Actor> GetActorsWithMovies()
        {
            var actorWithMovies = _movieManagementDbContext.Actors.Include(a=> a.Movies).ToList();

            return actorWithMovies;
        }
    }
}
