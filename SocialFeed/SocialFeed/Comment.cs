using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SocialFeed
{
    public class Comment : IReportable
    {
        private string _author;
        private string _text;
        private Post _parentPost;
        private int _reports;

        public string Author
        {
            get { return _author; }
            set { _author = value; }
        }

        public string Text
        {
            get { return _text; }
            set { _text = value; }
        }

        public Post ParentPost
        {
            get { return _parentPost; }
        }

        public Comment(string author, string text, Post parentPost)
        {
            Author = author;
            Text = text;
            _parentPost = parentPost;
            _reports = 0;
        }

        public void Report()
        {
            _reports++;
        }

        public int ReportCount()
        {
            return _reports;
        }

        public string GetDescription()
        {
            return $"{Author} hozzászólása {ParentPost.Autor} bejegyzéséhez: {Text}";
        }
    }
}