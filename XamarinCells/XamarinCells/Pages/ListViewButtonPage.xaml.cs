using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinCells.Model;

namespace XamarinCells.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewButtonPage : ContentPage
    {
        public ListViewButtonPage()
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

        private void Button_OnClicked(object sender, EventArgs e)
        {
            var btn = (Button) sender;
            var emp = (Employee) btn.CommandParameter;

            DisplayAlert("Vacation", "Employee: " + emp.Name, "Ok");
        }
    }
}