using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.NewsService
{
    public interface INewsService
    {
        IEnumerable<News> GetAllNews();
        News GetNews(int id);
        void InsertNews(News news);
        void UpdateNews(News news);
        void DeleteNews(int id);
    }
}
