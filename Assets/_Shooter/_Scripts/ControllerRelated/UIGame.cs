using System;
using System.Collections;
using System.Collections.Generic;
using _Shooter._Scripts.GameplayRelated;
using UnityEngine;
using UnityEngine.UI;

public class UIGame : MonoBehaviour
{
    [SerializeField] private Button shootButton;

    private void Start()
    {
        shootButton.onClick.AddListener(PlayerController.instance.ShootProjectile);
    }
}
