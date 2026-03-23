using System;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseUI;
    private bool isPaused = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) TogglePause();

    }

    public void TogglePause()
    {
      isPaused = !isPaused;
        pauseUI.SetActive(isPaused);
        Time.timeScale = isPaused ? 0f : 1f;
    }
}
