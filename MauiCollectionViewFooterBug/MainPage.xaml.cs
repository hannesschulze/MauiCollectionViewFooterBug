using System.Collections.ObjectModel;

namespace MauiCollectionViewFooterBug;

public sealed class ListItem
{
    public string Identifier { get; } = Guid.NewGuid().ToString("D");
}

public partial class MainPage : ContentPage
{
    public ObservableCollection<ListItem> Items { get; }

    public MainPage()
    {
        Items = new ObservableCollection<ListItem> { new ListItem(), new ListItem() };
        BindingContext = this;
        InitializeComponent();
    }

    private async void BreakFooter(object sender, EventArgs e)
    {
        Items.Clear();
        await Task.Delay(TimeSpan.FromMilliseconds(250));
        Items.Add(new ListItem());
        Items.Add(new ListItem());
    }
}
