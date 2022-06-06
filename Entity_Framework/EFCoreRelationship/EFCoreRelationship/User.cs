namespace EFCoreRelationship
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; } = string.Empty;
        //Relationship with Character
        public List<Character> Characters { get; set; }
    }
}
