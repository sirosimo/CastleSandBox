namespace CastleSandBox.Core;

public interface IPersonBase{
    string Name{ get; set; }
    int Age{ get; set; }
    void Sleep();
    void Eat();
}