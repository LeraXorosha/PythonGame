public MainWindow()
{
	InitializeComponent();
	FrameMain.Navigate(new Pages.Authorization());
}

private void ButtonBack_Click(object sender, RoutedEventArgs e)
{
	FrameMain.GoBack();
}

private void ButtonExit_Click(object sender, RoutedEventArgs e)
{
	this.Close();
}

private void FrameMain_ContentRendered(object sender, EventArgs e)
{
	if (FrameMain.CanGoBack)
	{
		ButtonBack.Visibility = Visibility.Visible;
	}
	else
	{
		ButtonBack.Visibility = Visibility.Hidden;
	}
}