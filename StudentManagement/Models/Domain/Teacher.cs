namespace StudentManagement.Models.Domain
{
	public class Teacher
	{
        public int Id { get; set; }
		public string Name { get; set; }
		public string Subject { get; set; }
		public string Status { get; set; }
		public ICollection<Standard> Standards { get; set; }
	}
}
