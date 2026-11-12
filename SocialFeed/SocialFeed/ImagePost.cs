using System;

namespace SocialFeed
{
    public class ImagePost : Post
    {
        private int _imageCount;

        public int ImageCount
        {
            get { return _imageCount; }
            set
            {
                if (value >= 1 && value <= 10)
                {
                    _imageCount = value;
                }
                else
                {
                    _imageCount = 1;
                }
            }
        }

        public ImagePost(string author, int imageCount) : base(author)
        {
            ImageCount = imageCount;
        }

        public override int Score()
        {
            return Likes * 2;
        }

        public override string GetDescription()
        {
            return $"{base.GetDescription()}, {ImageCount} kép";
        }
    }
}