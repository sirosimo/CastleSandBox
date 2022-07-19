using Castle.MicroKernel.Registration;
using Castle.Windsor;
using CastleSandBox.Core;
using PeopleExplorer;

var container = new WindsorContainer();

container.Register(
    Component.For<ILogging>().ImplementedBy<Logging>(),
    Classes.FromAssemblyInDirectory(new AssemblyFilter("Peoples"))
        .BasedOn<IPersonBase>()
        .WithServiceFromInterface());

var logger = container.Resolve<ILogging>();
logger.LogMessage("Hello World.");

var peoples = container.Kernel.GetAssignableHandlers(typeof(IPersonBase));
foreach (var people in peoples){
    Console.WriteLine(people.ComponentModel.Name);
}


Console.ReadLine();


