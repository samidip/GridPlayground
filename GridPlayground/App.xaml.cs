﻿namespace GridPlayground;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new PostListView();
	}
}

