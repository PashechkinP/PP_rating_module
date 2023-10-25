namespace PP_rating_module
{
	public class UserStat
	{
		public int Id { get; set; }
		public string? Name { get; set; }
		public int? Sector { get; set; }
		public bool? highDegree { get; set; }
		public int? children { get; set; }
		public bool? dangerouseDisease { get; set; }


		//public UserStat(string name)
		//{
		//	Name = name;
		//}
	}

    public class Userochek
    {
        public int Id { get; set; }
        public string? Name { get; set; }
		public string? Gender { get; set; }
       
    }
}
