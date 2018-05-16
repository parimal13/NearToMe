﻿using MvvmCross.Core.ViewModels;
using MvvmCross.Platform.IoC;
using NearToMe.Core.ViewModels;

namespace NearToMe.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterNavigationServiceAppStart<SplashViewModel>();
        }
    }
}
