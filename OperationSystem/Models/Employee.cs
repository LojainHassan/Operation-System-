namespace OperationSystem.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string? EmployeeName { get; set; }
        public string? City { get; set; }
        public string? Email { get; set; }
        public decimal Salary { get; set; }
        public DateTime HireDate { get; set; }
        public string? Mobile { get; set; }
        public Gender Gender { get; set; }
        public string? Position { get; set; }
        public bool isActive { get; set; }
        public bool isDeleted { get; set; }
    }
}

/// <summary>
/// Static List of Gender
/// we dont need table for it
/// </summary>
/// 1 reference means where and how much is thing used , click on it you can see where it used 
public enum Gender
{
    Male,Female
}