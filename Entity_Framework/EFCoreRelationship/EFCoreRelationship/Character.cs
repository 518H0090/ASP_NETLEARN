namespace EFCoreRelationship
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string RpgClass { get; set; } = "Knight";
        //Relationship with User
        public User user { get; set; }
        public int UserId { get; set; }
    }
}
