namespace eManagement.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual List<eManagementLeadEntity> DepartmentID { get; set; }
    
    }
}
