namespace JmpdAppApi.DataAccess.Models
{
    public partial class Role
    {
        public Role()
        {
            #region Generated Constructor
            TrafficOfficials = new HashSet<TrafficOfficial>();
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

        public string RoleMember { get; set; }

        #endregion

        #region Generated Relationships
        public virtual ICollection<TrafficOfficial> TrafficOfficials { get; set; }

        #endregion

    }
}
