﻿namespace Weather.UWP
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            this.InitializeComponent();

            LoadApplication(new Weather.App());
        }
    }
}
