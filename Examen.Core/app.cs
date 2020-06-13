
using Examen.Core.ViewModels;
using MvvmCross.IoC;
using MvvmCross.ViewModels;

namespace Examen.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterAppStart<MenuViewModel>();
        }
    }
}