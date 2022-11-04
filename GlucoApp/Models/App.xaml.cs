using Xamarin.Forms;

namespace GlucoApp
{
    public partial class App : Application
    {

        public App ()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new CarouselPagqUno());
        }

        protected override void OnStart ()
        {
        }

        protected override void OnSleep ()
        {
        }

        protected override void OnResume ()
        {
        }
    }
}
