using ImageIssue14471.Models;

namespace ImageIssue14471.Data
{
    public static class Items
    {
        public static IList<ListItem> DummyData => Enumerable.Repeat(1, 25).Select((x, index) => new ListItem
        {
            Title = $"Item #{index}"
        }).ToList();
    }
}
