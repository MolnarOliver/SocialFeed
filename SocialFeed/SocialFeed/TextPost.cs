using SocialFeed;

public class TextPost : Post
{
    private string _text;

    public string Text
    {
        get { return _text; }
        set { _text = value; }
    }

    public TextPost(string autor, string text) : base(autor)
    {
        Text = text;
    }

    public override int Score()
    {
        return Likes;
    }

    public override string GetDescription()
    {
        string desString = Text;
        if (Text.Length > 20)
        {
            desString = Text.Substring(0, 20) + "...";
        }
        return base.GetDescription() + $" : {desString}";
    }
}
