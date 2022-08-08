using UnityEngine;
using UnityEngine.UI;

public class UIGame : MonoBehaviour
{
    public Image healthBar;
    public float actualHealth;
    public float maxVida = 100f;

    private bool pauseActive;
    public GameObject pauseMenu;


    void Start()
    {
        
    }

    
    void Update()
    {
        actualHealth = Player.Health;
        healthBar.fillAmount = actualHealth / maxVida;
        TogglePause();

    }

    public void TogglePause()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (pauseActive)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }

    void ResumeGame()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
        pauseActive = false;
    }

    void PauseGame()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0;
        pauseActive = true;
    }
}
