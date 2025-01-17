using System;
using System.Collections;
using System.Collections.Generic;
using _Shooter._Scripts.ControllerRelated;
using _Shooter._Scripts.GameplayRelated;
using UnityEngine;
using UnityEngine.UI;

public class UIGame : MonoBehaviour
{
    [SerializeField] private Button shootButton;
    [SerializeField] private GameObject splashScreen;

    private void Start()
    {
        shootButton.onClick.AddListener(Game.On_ShootButtonPressed);
        StartCoroutine(DisableSplashScreen());
    }

    IEnumerator DisableSplashScreen()
    {
        yield return new WaitForSeconds(2);
        splashScreen.SetActive(false);
    }
}
