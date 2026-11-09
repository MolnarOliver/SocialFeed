using System;

namespace SocialFeed
{
    public abstract class Post
    {
        private string _autor;
        private int _likes;

        public string Autor
        {
            get { return _autor; }
            set { _autor = value; }
        }

        public int Likes
        {
            get { return _likes; }
        }

        public Post(string autor)
        {
            Autor = autor;
            _likes = 0;
        }

        public virtual bool Like()
        {
            _likes++;
            return true;
        }

        public virtual string GetDescription()
        {
            return $"{Autor}, {Likes} kedveles";
        }

        public abstract int Score();
    }
}

