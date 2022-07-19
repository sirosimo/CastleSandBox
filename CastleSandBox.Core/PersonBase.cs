namespace CastleSandBox.Core;

public abstract class PersonBase : IPersonBase{
    public string Name{ get; set; }
    public int Age{ get; set; }

    public abstract void Sleep();
    public abstract void Eat();
}