using System;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class MenuInputReader : MonoBehaviour
{
    [SerializeField] private Button playButton;
    [SerializeField] private Button creditsButton;
    [SerializeField] private Button menuButton;
    [SerializeField] private Button exitButton;
    [SerializeField] private Button goToMenuButton;

    [SerializeField] private GameObject menu;
    [SerializeField] private GameObject game;
    [SerializeField] private GameObject credits;


    private void OnEnable()
    {
        playButton.onClick.AddListener(HandleStartPlay);
        creditsButton.onClick.AddListener(HandleCreditsPlay);
        menuButton.onClick.AddListener(HandleMenuPlay);
        exitButton.onClick.AddListener(HandleExitPlay);
        goToMenuButton.onClick.AddListener(HandleMenuInGame);

    }

    private void HandleMenuInGame()
    {
       game.SetActive(false);
        menu.SetActive(true);
    }

    private void OnDisable()
    {
        playButton.onClick.RemoveListener(HandleStartPlay);
        creditsButton.onClick.RemoveListener(HandleCreditsPlay);
        menuButton.onClick.RemoveListener(HandleMenuPlay);
        goToMenuButton.onClick.RemoveListener(HandleMenuInGame);
    }

    private void HandleStartPlay()
    {
        menu.SetActive(false);
        game.SetActive(true);
    }

    private void HandleCreditsPlay()
    {
        menu.SetActive(false);
        credits.SetActive(true);
    }

    private void HandleMenuPlay()
    {
        menu.SetActive(true);
        credits.SetActive(false);
    }

    private void HandleExitPlay()
    {
        Application.Quit();
    }
}
