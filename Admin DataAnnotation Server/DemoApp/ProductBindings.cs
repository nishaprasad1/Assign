using System.ComponentModel;

namespace DemoApp.Admin;


public class ProductBindings : INotifyPropertyChanged
{
    AdminDbContext _db = new AdminDbContext();
    private Department _currentDepartment;
    public event  PropertyChangedEventHandler PropertyChanged;
    public IEnumerable<Department> Departments => _db.Departments.ToList();

    public Department CurrentDepartment
    {
        get => _currentDepartment;
        set
        {
            _currentDepartment = value;
            _db.Entry(_currentDepartment).Collection(e => e.Employees).Load();
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentDepartment"));
        }

    }

}