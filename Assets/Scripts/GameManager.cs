using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("Paneles")]
    public GameObject pauseMenuPanel;
    public GameObject mainMenuPanel;
    
  
    void Start()
    {
        mainMenuPanel.SetActive(true);
        Time.timeScale = 0f;
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Time.timeScale = 0f;
            pauseMenuPanel.SetActive(true);
        }
    }
}
