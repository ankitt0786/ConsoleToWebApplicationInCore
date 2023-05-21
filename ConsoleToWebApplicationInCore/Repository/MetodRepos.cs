using ConsoleToWebApplicationInCore.Models;

namespace ConsoleToWebApplicationInCore.Repository
{
    public class MetodRepos
    {
        public List<BookModel> GetBookList()
        { 
            return books(); 
        }
        public BookModel GetBook(int id) 
        {  
            return books().Where(x=>x.Id == id).FirstOrDefault(); 
        }

        public List<BookModel> GetBooksSearch(string title, string name)
        {
            return books().Where(x=>x.Title.Contains(title) || x.Author==name).ToList();
        }


        private List<BookModel> books()
        {
            List<BookModel> bookModels = new List<BookModel>()
            {
                new BookModel()
                {
                Id=1,
                Title="firstbook",
                Description="This is a dummy book",
                Author="Ankit",
                AuthorUrl="Ankit.com"
                },
                new BookModel()
                {
                    Id = 2,
                    Title = "second book",
                    Description = "This is a dummy book",
                    Author = "Vinay",
                    AuthorUrl = "vinay.com"
                }
            };

            return bookModels;
        }
    }
}
