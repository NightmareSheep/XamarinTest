using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Vreugdenhil_prototype_7
{
    public partial class MainPage : ContentPage
    {
        public List<Article> Articles { get; set; } = new List<Article>()
        {
            new Article
            {
                Title = "Article 1",
                SubTitle = "Subtitle 1",
                Content = "Content",
                Tag = "Tag 1",
                PublishDate = DateTime.Now
            },
            new Article
            {
                Title = "Article 2",
                SubTitle = "Subtitle 2",
                Content = "Content",
                Tag = "Tag 2",
                PublishDate = DateTime.Now
            },
        };

        public MainPage()
        {
            InitializeComponent();
            ArticleListView.ItemsSource = Articles;
        }
    }
}
