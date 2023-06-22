namespace GridPlayground;

public partial class PostListView : ContentPage
{
	PostListViewModel MyViewModel;

	public PostListView()
	{
		InitializeComponent();
		MyViewModel = new PostListViewModel();
	}

    protected async override void OnAppearing()
    {
        base.OnAppearing();

        NetworkAccess accessType = Connectivity.Current.NetworkAccess;

        if (accessType == NetworkAccess.Internet)
        {
            this.MyDataGrid.ItemsSource = await MyViewModel.GetPostData();
            this.MyBusyIndicator.IsBusy = false;
        }
        else
        {
            this.MyBusyIndicator.IsBusy = false;
            await DisplayAlert("Alert", "You do not have internet connection!", "OK");
        }
    }
}
