using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartMenuHandler : MonoBehaviour
{

    [SerializeField] InputField nameInput;

    public void Play() {
        PlayerManager.Instance.SetPlayerName(nameInput.text);
        SceneManager.LoadScene(1);

    }

    public void Quit() {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
    Application.Quit();
#endif

    }

}
