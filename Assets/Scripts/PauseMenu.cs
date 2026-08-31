using System;
using UnityEngine;



public class PauseMenu : MonoBehaviour
{
    [Header("Paneles")]
    public GameObject pausePanel;
    public GameObject settingsPanel;
    public GameObject creditsPanel;
    
    [Header("Botones")]
    public UnityEngine.UI.Button continueButton;
    public UnityEngine.UI.Button settingsButton;
    public UnityEngine.UI.Button creditsButton;
    public UnityEngine.UI.Button exitButton;

    private void Start()
    {
        continueButton.onClick.AddListener(OnContinueButtonButton);
        settingsButton.onClick.AddListener(OnSettingsButton);
        creditsButton.onClick.AddListener(OnCreditsButton);
        exitButton.onClick.AddListener(OnExitButton);
    }

    public void OnContinueButtonButton()
    {
        
        pausePanel.SetActive(false);
        Time.timeScale = 1f;
    }

    public void OnSettingsButton()
    {
        pausePanel.SetActive(false);
        settingsPanel.SetActive(true);
    }

    public void OnCreditsButton()
    {
        pausePanel.SetActive(false);
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

