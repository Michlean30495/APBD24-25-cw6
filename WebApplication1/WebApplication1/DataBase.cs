using WebApplication1.Models;

namespace WebApplication1;

public class DataBase
{
    public static List<Test> tests = new List<Test>()
    {
        new Test() { Id = 1, Name = "Test1" },
        new Test() { Id = 2, Name = "Test2" },
        new Test() { Id = 3, Name = "Test3" }
    };
}