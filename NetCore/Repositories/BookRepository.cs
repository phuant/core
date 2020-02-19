using NetCore.Commom;
using NetCore.Model;

namespace NetCore.Repositories
{
    public class BookRepository : RepositoryBase<Book>, IBookRepository
    {
        public BookRepository(ConnectDatabase context) : base(context)
        {

        }
    }
}
