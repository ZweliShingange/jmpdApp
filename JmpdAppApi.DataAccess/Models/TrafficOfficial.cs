namespace JmpdAppApi.DataAccess.Models
{
    public partial class TrafficOfficial
    {
        public TrafficOfficial()
        {
        }

        #region Generated Properties
        public string OfficerNumber { get; set; }

        public string Name { get; set; }

        public int RoleId { get; set; }

        public int ProvinceId { get; set; }

        public int GenderId { get; set; }

        public int TitleId { get; set; }

        public int EmailAddress { get; set; }

        public string Password { get; set; }

        #endregion

        #region Generated Relationships
        public virtual Gender Gender { get; set; }

        public virtual Role Role { get; set; }

        public virtual Title Title { get; set; }

        #endregion

    }
}
