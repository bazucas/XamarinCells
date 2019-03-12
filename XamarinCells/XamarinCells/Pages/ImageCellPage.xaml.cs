using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinCells.Model;

namespace XamarinCells.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ImageCellPage : ContentPage
    {
        public ImageCellPage()
        {
            InitializeComponent();

            var list = new List<Employee>
            {
                new Employee {Name = "Luis Inacio", Function = "Developer C#", Photo = Device.RuntimePlatform == Device.UWP ? "Resources/face1.jpg" : "face1.jpg"},
                new Employee {Name = "Ruben Santos", Function = "Developer Java", Photo = Device.RuntimePlatform == Device.UWP ? "Resources/face2.jpg" : "face2.jpg"},
                new Employee {Name = "Silvia Fidalgo", Function = "Developer iOS", Photo = Device.RuntimePlatform == Device.UWP ? "Resources/face4.jpg" : "face4.jpg"},
                new Employee {Name = "Miguel Micla", Function = "Developer Android", Photo = Device.RuntimePlatform == Device.UWP ? "Resources/face3.jpg" : "face3.jpg"},
                new Employee {Name = "Alexandre Torres", Function = "Developer Python", Photo = Device.RuntimePlatform == Device.UWP ? "Resources/face5.jpg" : "face5.jpg"},
                new Employee {Name = "Zé Carvalho", Function = "Developer Go", Photo = Device.RuntimePlatform == Device.UWP ? "Resources/face6.jpg" : "face6.jpg"},
                new Employee {Name = "Luis Matos", Function = "Developer Php", Photo = Device.RuntimePlatform == Device.UWP ? "Resources/face7.jpg" : "face7.jpg"}
            };

            EmployeeList.ItemsSource = list;
        }
    }
}