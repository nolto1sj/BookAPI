using BookApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        [HttpPost("add")]
        public Book AddBook(string title, string category)
        {
            return Book.AddBook(title, category);
        }

        [HttpGet]
        public List<Book> GetAll()
        {
            return Book.GetAll();
        }

        [HttpGet("{id}")]
        public Book FindById(int id)
        {
            return Book.FindById(id);
        }

        [HttpGet("category/categoryname")]
        public List<Book> FindByCategory(string categoryname)
        {
            return Book.FindByCategory(categoryname);
        }

        [HttpGet("search/{keyword}")]
        public List<Book> FindByKeyword(string keyword)
        {
            return Book.FindByKeyword(keyword);
        }

        [HttpPut("updatebook/{id}")]
        public void UpdateBook(int id, string title, string category)
        {
            Book.UpdateBook(id, title, category);
        }

        [HttpDelete("deletebook/{id}")]
        public void DeleteBook(int id)
        {
            Book.DeleteBook(id);
        }

    }
}
