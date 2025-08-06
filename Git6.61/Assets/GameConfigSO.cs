using UnityEngine;

[CreateAssetMenu(fileName = "GameConfig", menuName = "Configs/GameConfig")]
public class GameConfigSO : ScriptableObject
{
    public int maxLives;
    public float playerSpeed;
    public string playerName;
}