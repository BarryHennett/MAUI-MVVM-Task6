using MauiTask6.Models;
using MauiTask6.Models.ViewModels;
namespace MauiTask6.Pages;

public partial class EmployeeListPage : ContentPage
{
	public EmployeeListPage()
	{
		InitializeComponent();
		BindingContext = new EmployeeViewModel();
	}

    private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
    {
		var employee = (Employee)e.Item;
		var employeeDetailViewModel2 = new EmployeeDetailViewModel2 { Employee = employee};
		var employeeDetailPage = new EmployeeDetailPage();
		employeeDetailPage.BindingContext = employeeDetailViewModel2;

		Navigation.PushAsync(employeeDetailPage);
    }
}