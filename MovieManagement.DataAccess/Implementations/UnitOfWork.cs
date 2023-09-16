using MovieManagement.DataAccess.Context;
using MovieManagement.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManagement.DataAccess.Implementations
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MovieManagementDbContext _movieManagementDbContext;
        public UnitOfWork(MovieManagementDbContext movieManagementDbContext)
        {
            _movieManagementDbContext = movieManagementDbContext;
            Actor = new ActorRepository(movieManagementDbContext);
            Movie = new MovieRepository(movieManagementDbContext);
            Biography = new BiographyRepository(movieManagementDbContext);
            Genre = new GenreRepository(movieManagementDbContext);
        }

        public IActorRepository Actor { get; private set; }
        public IMovieRepository Movie { get; private set; }
        public IBiographyRepository Biography { get; private set;}
        public IGenreRepository Genre { get; private set; }
        public int Save()
        {
            return _movieManagementDbContext.SaveChanges();
        }

        public void Dispose()
        {
            _movieManagementDbContext?.Dispose();
        }
    }
}
