namespace HospitalManagementSystem.Models
{
    public class SystemCode : UserCreateActivity
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public int Description { get; set; }
        public int OrderNo { get; set; }
    }
}
