using BL.Interfaces;
using DAL.Models;
using SL.NewsService;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace BL.Services
{
        public class NewsService : INewsService
        {
            #region Property  
            private readonly IRepository<News> _repository;
            #endregion

            #region Constructor  
            public NewsService(IRepository<News> repository)
            {
                _repository = repository;
            }
            #endregion

            public IEnumerable<News> GetAllNews()
            {
                return _repository.GetAll();
            }

            public News GetNews(int id)
            {
                return _repository.Get(id);
            }

            public void InsertNews(News news)
            {

                _repository.Insert(news);
            }
            public void UpdateNews(News news)
            {
                _repository.Update(news);
            }

            public void DeleteNews(int id)
            {
                News news = GetNews(id);
                _repository.Remove(news);
                _repository.SaveChanges();
            }
        }
    }
