using KarenKrill.UniCore.Logging;
using UnityEngine;
using Zenject;

public class BasicSampleInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.Bind<ILogger>().To<Logger>().FromNew().AsSingle().WithArguments(new DebugLogHandler());
    }
}