using UnityEngine;

public class GameConfigFromSO : IGameConfig
{
    private readonly GameConfigSO _configSO;

    public GameConfigFromSO(GameConfigSO configSO)
    {
        _configSO = configSO;
    }

    public int MaxLives => _configSO.maxLives;
    public float PlayerSpeed => _configSO.playerSpeed;
    public string PlayerName => _configSO.playerName;
}