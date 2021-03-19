using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_splitview.Models
{
    public class NewsItem
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public string Headline { get; set; }
        public string Subhead { get; set; }
        public string Dateline { get; set; }
        public string Image { get; set; }

        public static List<NewsItem> GetNewsItems()
        {
            var items = new List<NewsItem>
            {
                new NewsItem() { Id = 1, Category = "Financial", Headline = "Lorem Ipsum", Subhead = "doro sit amet", Dateline = "Nunc tristique mec", Image = "Assets/Financial.png" },
                new NewsItem() { Id = 2, Category = "Financial", Headline = "Lorem Ipsum", Subhead = "doro sit amet", Dateline = "Nunc tristique mec", Image = "Assets/Financial.png" },
                new NewsItem() { Id = 3, Category = "Financial", Headline = "Lorem Ipsum", Subhead = "doro sit amet", Dateline = "Nunc tristique mec", Image = "Assets/Financial2.png" },
                new NewsItem() { Id = 4, Category = "Financial", Headline = "Lorem Ipsum", Subhead = "doro sit amet", Dateline = "Nunc tristique mec", Image = "Assets/Financial5.png" },
                new NewsItem() { Id = 5, Category = "Financial", Headline = "Lorem Ipsum", Subhead = "doro sit amet", Dateline = "Nunc tristique mec", Image = "Assets/Financial4.png" },
                new NewsItem() { Id = 6, Category = "Financial", Headline = "Lorem Ipsum", Subhead = "doro sit amet", Dateline = "Nunc tristique mec", Image = "Assets/Financial3.png" },
                new NewsItem() { Id = 7, Category = "Food", Headline = "Lorem Ipsum", Subhead = "doro sit amet", Dateline = "Nunc tristique mec", Image = "Assets/Food1.png" },
                new NewsItem() { Id = 8, Category = "Food", Headline = "Lorem asdfIpsum", Subhead = "doro siddddt amet", Dateline = "Nunc tdddristique mec", Image = "Assets/Food2.png" },
                new NewsItem() { Id = 9, Category = "Food", Headline = "Lorem Iddpsum", Subhead = "doro fffsit amet", Dateline = "Nunc trigggstique mec", Image = "Assets/Food3.png" },
                new NewsItem() { Id = 10, Category = "Financial", Headline = "Lorem Ipsum", Subhead = "doro sit amet", Dateline = "Nunc tristique mec", Image = "Assets/Financial.png" }
            };

            return items;
        }
    }

    public class NewsManager
    {
        public static void GetNews(string category, ObservableCollection<NewsItem> newsItems)
        {
            var allItems = NewsItem.GetNewsItems();
            var filteredNewsItems = allItems.Where(p => p.Category == category).ToList();
            newsItems.Clear();
            filteredNewsItems.ForEach(p => newsItems.Add(p));
        }
    }
}
