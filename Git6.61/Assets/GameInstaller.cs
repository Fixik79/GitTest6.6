using Zenject;
using UnityEngine;

public class GameInstaller : MonoInstaller
{
    [SerializeField] private GameConfigSO gameConfigSO;
    [SerializeField] private bool useDummyConfig = false;

    public override void InstallBindings()
    {
        if (useDummyConfig)
        {
            Container.Bind<IGameConfig>().To<DummyGameConfig>().AsSingle();
        }
        else
        {
            // Передаём ScriptableObject в конструктор GameConfigFromSO
            Container.Bind<IGameConfig>().To<GameConfigFromSO>().AsSingle()
                .WithArguments(gameConfigSO);
        }
    }
}