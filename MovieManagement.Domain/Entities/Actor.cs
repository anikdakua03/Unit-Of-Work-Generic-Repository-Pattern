using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManagement.Domain.Entities
{
    public class Actor
    {
        public string FirstName { get; set; } = string.Empty;
        public int Id { get; set; }
        public string LastName { get; set; } = string.Empty;
        public List<Movie>? Movies { get; set; } // for one actor there can be many movies
        public Biography? Biography { get; set; } // for one actor only one biography
    }
}
