public class Reference
{
    public string Text { get; }

    public Reference(string text)
    {
        Text = text;
    }

    public string Display()
    {
        return Text;
    }
}