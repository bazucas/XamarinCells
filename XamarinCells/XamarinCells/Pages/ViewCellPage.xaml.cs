using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinCells.Model;

namespace XamarinCells.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ViewCellPage : ContentPage
    {
        public ViewCellPage()
        {
            InitializeComponent();

            var list = new List<Employee>
            {
                new Employee {Name = "Luis Inacio", Function = "Developer C#"},
                new Employee {Name = "Renato Santos", Function = "Developer Java"},
                new Employee {Name = "Marilia Ferreira", Function = "Developer iOS"},
                new Employee {Name = "Joao Matos", Function = "Developer Android"},
                new Employee {Name = "Tiago Lopes", Function = "Developer Python"},
                new Employee {Name = "Bruno Novo", Function = "Developer Go"}
            };

            EmployeeList.ItemsSource = list;
        }
    }
}