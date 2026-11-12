using System;

namespace SocialFeed
{
    public class PollPost : Post
    {
        private int _votes;
        private bool _isClosed;

        public int Votes
        {
            get { return _votes; }
        }

        public bool IsClosed
        {
            get { return _isClosed; }
        }

        public PollPost(string author) : base(author)
        {
            _votes = 0;
            _isClosed = false;
        }

        public bool Vote()
        {
            if (!IsClosed)
            {
                _votes++;
                return true;
            }
            return false;
        }

        public void Close()
        {
            _isClosed = true;
        }

        public override int Score()
        {
            return Likes + Votes;
        }

        public override string GetDescription()
        {
            return base.GetDescription() + $"{_votes} szavzat {(IsClosed ? "lezarva" : "")}";
        }

        public override bool Like()
        {
            if (IsClosed) return false;
            return base.Like();
        }
    }
}