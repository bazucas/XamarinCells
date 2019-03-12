using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinCells.Pages;

namespace XamarinCells.Menu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Master : MasterDetailPage
    {
        public Master()
        {
            InitializeComponent();
        }

        private void GoPageTextCell(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new TextCellPage());
            IsPresented = false;
        }


        private void GoPageImageCell(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new ImageCellPage());
            IsPresented = false;
        }

        private void GoPageEntryCell(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new EntryCellPage());
            IsPresented = false;
        }

        private void GoPageSwitchCell(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new SwitchCellPage());
            IsPresented = false;
        }

        private void GoPageViewCell(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new ViewCellPage());
            IsPresented = false;
        }

        private void GoPageListView(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new ListViewPage());
            IsPresented = false;
        }

        private void GoPageListViewButtonPage(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new ListViewButtonPage());
            IsPresented = false;
        }
    }
}