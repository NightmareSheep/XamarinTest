using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Vreugdenhil_prototype_7
{
    public class Article
    {
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Content { get; set; }
        public string Tag { get; set; }
        public bool HaveRead { get; set; }
        public string Image { get; set; }
        public DateTime PublishDate { get; set; }
    }
}
