namespace JmpdAppApi.DataAccess.Models
{
    public partial class Gender
    {
        public Gender()
        {
            TrafficOfficials = new HashSet<TrafficOfficial>();
        }
        public int Id { get; set; }

        public string GenderMember { get; set; }


        public virtual ICollection<TrafficOfficial> TrafficOfficials { get; set; }
    }
}