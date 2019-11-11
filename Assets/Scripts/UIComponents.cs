using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIComponents : MonoBehaviour
{
    public GameObject Panel_Menu;
    public GameObject Panel_Credits;
    public GameObject Panel_Howtoplay;

    public void Awake()
    {
        Panel_Menu.gameObject.SetActive(true);
        Panel_Credits.gameObject.SetActive(false);
        Panel_Howtoplay.gameObject.SetActive(false);
    }

    public void LoadGameScene()
    {
        SceneManager.LoadScene(1);
    }

    public void LoadMenuSecne()
    {
        SceneManager.LoadScene(0);
        Panel_Credits.gameObject.SetActive(false);
        Panel_Howtoplay.gameObject.SetActive(false);

    }

    public void LoadHowtoPlayPanel()
    {
        Panel_Howtoplay.gameObject.SetActive(true);
    }

    public void LoadCreditsPanel()
    {
        Panel_Credits.gameObject.SetActive(true);
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
