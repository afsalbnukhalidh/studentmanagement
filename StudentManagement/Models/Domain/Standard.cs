namespace StudentManagement.Models.Domain
{
	public class Standard
	{
		public int Id { get; set; }
		public string Class { get; set; }
		public string Division { get; set; }
        public Teacher? Teacher { get; set; }
		public string Status { get; set; }
		public ICollection<Student> Students { get; set; }
	}
}
