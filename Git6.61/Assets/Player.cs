using UnityEngine;
using Zenject;

public class Player : MonoBehaviour
{
    private IGameConfig _gameConfig;

    [Inject]
    public void Construct(IGameConfig gameConfig)
    {
        _gameConfig = gameConfig;
    }

    private void Start()
    {
        Debug.Log($"Player Name: {_gameConfig.PlayerName}");
        Debug.Log($"Max Lives: {_gameConfig.MaxLives}");
        Debug.Log($"Player Speed: {_gameConfig.PlayerSpeed}");
    }
}