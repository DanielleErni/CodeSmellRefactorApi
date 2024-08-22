namespace CodeSmellRefactorApi.Dto;

public class UserDto
{
    public int id { get; set; }
    public required string name { get; set; }
    public required string company { get; set; }
    public required string username { get; set; }
    public required string email { get; set; }
    public required string address { get; set; }
    public required string zip { get; set; }
    public required string state { get; set; }
    public required string country { get; set; }
    public required string phone { get; set; }
    public required string photo { get; set; }
}
