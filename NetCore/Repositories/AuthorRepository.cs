using NetCore.Commom;
using NetCore.Model;

namespace NetCore.Repositories
{
    public class AuthorRepository : RepositoryBase<Author>,IAuthorRepository
    {
        public AuthorRepository(ConnectDatabase context) : base(context)
        {

        }
    }
}
