namespace StatusBarXamarinForms.UWP
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            this.InitializeComponent();

            LoadApplication(new StatusBarXamarinForms.App());
        }
    }
}