public class UserEntity
{
    public int Id { get; set; }
    public string Login { get; set; }
    public string Pass { get; set; }
    public DateTime? Created { get; set; }
    public DateTime? Updated { get; set; }
}