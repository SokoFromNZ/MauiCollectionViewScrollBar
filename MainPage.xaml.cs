using System.Collections.ObjectModel;

namespace CollectionViewScrollBar;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
        BindingContext = this;

        for (var i = 0; i < 50; i++)
        {
            Rows.Add(new Row($"Title-{i}", $"Detail-{i}"));
        }
	}

    public ObservableCollection<Row>  Rows { get; } = new ();
}

public record Row(string Title, string Detail);
