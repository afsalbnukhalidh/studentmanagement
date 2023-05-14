namespace StudentManagement.Models.Domain
{
	public class Student
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string FatherName { get; set; }
        public byte[] Image { get; set; }
        public string Address { get; set; }	
		public string Place { get; set; }
        public Standard? Standard { get; set; }
        public string Status { get; set; }
    }
}
