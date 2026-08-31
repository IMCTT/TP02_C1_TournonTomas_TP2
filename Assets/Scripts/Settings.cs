using TMPro;
using UnityEngine;
using UnityEngine.UIElements;
using Slider = UnityEngine.UI.Slider;

public class Settings : MonoBehaviour
{
    
    [Header("Paneles")]
    public GameObject pausePanel;
    public GameObject settingsPanel;
    
    [Header("Boton y Sliders")]
    
    public UnityEngine.UI.Button backButton;
    public Slider p1Slisder, p2Slider;
    public TMP_Text p1Text, p2Text; 
 
    
    public GameObject player1, player2;
    private void Start()
    {
        
        p1Slisder.minValue = 1f;
        p1Slisder.maxValue = 20f;
        p2Slider.minValue = 1f;
        p2Slider.maxValue = 20f;
 
        p1Slisder.onValueChanged.AddListener(OnP1sliderChanged);
        p2Slider.onValueChanged.AddListener(OnP2sliderChanged);
        
        backButton.onClick.AddListener(OnBackButtonClicked);
    }
 
   private void OnP1sliderChanged(float value)
    {
        
        p1Text.text = $"Jugador 1: {value:F1}";
    }
 
    private void OnP2sliderChanged(float value)
    {
        p2Text.text = $"Jugador 2: {value:F1}";
    }
    
    public void OnBackButtonClicked()
    {
        settingsPanel.SetActive(false);
        pausePanel.SetActive(true);
    }
}
