using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIComponents : MonoBehaviour
{
    public GameObject Panel_Menu;

    public void Awake()
    {
        Panel_Menu.gameObject.SetActive(true);
    }

    public void LoadGameScene()
    {
        SceneManager.LoadScene(1);
    }

    public void LoadMenuSecne()
    {
        SceneManager.LoadScene(0);
    }

    public void QuitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = (false);
#else
            Application.Quit();
#endif
    }
}
