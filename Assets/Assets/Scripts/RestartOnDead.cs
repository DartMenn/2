using UnityEngine;

public class RestartOnDead : MonoBehaviour
{
    [SerializeField] private GameObject _hud;
    [SerializeField] private GameObject _gameOverScreen;

    private Health _health;

    private void Start()
    {
        _health = GetComponent<Health>();
        ShowHUD();
    }

    private void Update()
    {
        if (_health.Value <= 0)
        {
            ShowGameOverScreen();
            DisableControl();
            
        }
    }

    private void ShowGameOverScreen()
    {
        _hud.SetActive(false);
        _gameOverScreen.SetActive(true);
    }

    private void DisableControl()
    {
        GetComponent<PlayerController>().enabled = false;
        GetComponent<FireballCaster>().enabled = false;
        GetComponent<CameraRotation>().enabled = false;
    }

    private void ShowHUD()
    {
        _hud.SetActive(true);
        _gameOverScreen.SetActive(false);
    }
}