using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Managers/Game Settings")]
public class GameSettings : ScriptableObject{
    [SerializeField]
    private string _gameVersion = "0.0.1";
    public string GameVersion { get { return _gameVersion; } }
    [SerializeField]
    private string _playerName = "Player";
    public string PlayerName { get {
        int number = Random.Range(0,20);
        return _playerName + number; }
         }
}
