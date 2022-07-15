using System.Collections.ObjectModel;

namespace MauiCollectionViewFooterBug;

public sealed class ListItem
{
    public string Identifier { get; } = Guid.NewGuid().ToString("D");
}

public partial class MainPage : ContentPage
{
    public ObservableCollection<ListItem> Items { get; } = new();

    public MainPage()
    {
        BindingContext = this;
        InitializeComponent();
    }

    private void AddItem(object sender, EventArgs e)
    {
        Items.Add(new ListItem());
    }
}
