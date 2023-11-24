using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour
{
    public static PlayerManager Instance = null;

    [Serializable]
    public class SavedData {
        public string playerName = "";
        public int score = 0;  
    }
    SavedData _bestScore = new SavedData();
    public SavedData bestScore { get { return _bestScore; } } 
    
    string currentPlayer;

    void Awake() {
        if (Instance == null) {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        } else
            Destroy(gameObject);


    }

    public void SetPlayerName(string name) {
        currentPlayer = name; 

    }

    public void LoadScore() {
        if (File.Exists(Application.persistentDataPath + "/saveFile.json"))
            PlayerManager.Instance._bestScore = JsonUtility.FromJson<SavedData>(File.ReadAllText(Application.persistentDataPath + "/saveFile.json"));


    }

    public void SaveData(int newScore) {
        _bestScore.score = newScore;    
        _bestScore.playerName = currentPlayer;
        File.WriteAllText(Application.persistentDataPath + "/saveFile.json", JsonUtility.ToJson(PlayerManager.Instance._bestScore));

    }

}
