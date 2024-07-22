namespace ConverPdf.Models
{
	public class Employee
	{
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
    }
    public class EmployeeList
    {
        public List<Employee> EmpList { get; set; }
        public EmployeeList()
        {
            EmpList = new List<Employee>()
            {
                new Employee { Id = 1,Name="Ali",City="Ankara",Country="TR"},
                new Employee { Id = 2,Name="Veli",City="Capital",Country="TR"},
                new Employee { Id = 3,Name="Selim",City="Istanbul",Country="TR"},
                new Employee { Id = 4,Name="Suleyman",City="Izmir",Country="TR"},
                new Employee { Id = 5,Name="Ben",City="Antalya",Country="TR"},
            };
        }
    }
}
