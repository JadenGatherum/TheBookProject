namespace TheBookProject.Models
{
    public interface IBookRepository
    {
        public IQueryable<Book> Books { get; }
    }
}
