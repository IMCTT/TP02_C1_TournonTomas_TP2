using System;
using UnityEngine;



public class MainMenu : MonoBehaviour
{
    [Header("Paneles")]
    public GameObject mainMenuPanel;
    public GameObject settingsPanel;
    public GameObject creditsPanel;
    
    [Header("Botones")]
    public UnityEngine.UI.Button playButton;
    public UnityEngine.UI.Button settingsButton;
    public UnityEngine.UI.Button creditsButton;
    public UnityEngine.UI.Button exitButton;

    private void Start()
    {
        playButton.onClick.AddListener(OnPlayButton);
        settingsButton.onClick.AddListener(OnSettingsButton);
        creditsButton.onClick.AddListener(OnCreditsButton);
        exitButton.onClick.AddListener(OnExitButton);
    }

    public void OnPlayButton()
    {
        
        mainMenuPanel.SetActive(false);
        Time.timeScale = 1f;
    }

    public void OnSettingsButton()
    {
        mainMenuPanel.SetActive(false);
        settingsPanel.SetActive(true);
    }

    public void OnCreditsButton()
    {
        mainMenuPanel.SetActive(false);
        creditsPanel.SetActive(true);
    }

    public void OnExitButton()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}

