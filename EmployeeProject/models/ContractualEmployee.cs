namespace EmployeeProject
{
    public class ContractualEmployee : Employee, IEmployeeDetails
    {
        public string GetEmployeeDetails(int employeeId)
        {
            return GetProjectDetails(employeeId);
        }

        string GetProjectDetails(int employeeId)
        {
            return "Contractual EmployeeProject's Project";
        }
    }
}