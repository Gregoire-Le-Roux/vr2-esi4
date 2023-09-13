using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    public Button StartButton, AboutButton, QuitButton, BackButton;
    public GameObject MainSection, AboutSection;


    private void Awake()
    {
        SetupButtons();
    }

    private void SetupButtons()
    {
        StartButton.onClick.AddListener(() =>
        {
            PlayGame();
        });
        AboutButton.onClick.AddListener(() =>
        {
            ShowAboutScene(true);
        });
        BackButton.onClick.AddListener(() =>
        {
            ShowAboutScene(false);
        });
        QuitButton.onClick.AddListener(() =>
        {
            QuitGame();
        });
    }

    public void PlayGame ()
    {
        SceneManager.LoadScene("roomOneScene");
    }

    public void ShowAboutScene (bool show)
    {
        MainSection.SetActive(!show);
        AboutSection.SetActive(show);
    }

    public void QuitGame ()
    {
        bool quit = false;
        #if UNITY_EDITOR
            quit = true;
            EditorApplication.ExitPlaymode();
        #endif
        if (!quit) Application.Quit();
    }
}
