using System;
using _Shooter._Scripts.GameplayRelated;
using UnityEngine;

namespace _Shooter._Scripts.ControllerRelated
{
    public class Game : MonoBehaviour
    {
        [HideInInspector] public static IPlayerController _playerController;
        private IScoreManager _scoreManager;

        private void Awake()
        {
            _playerController = FindObjectOfType<PlayerController>();
            _scoreManager = FindObjectOfType<ScoreManager>();
        }

        private void OnEnable()
        {
            GameEvents.OnTargetHit += _scoreManager.UpdateScore;
        }

        private void OnDisable()
        {
            GameEvents.OnTargetHit -= _scoreManager.UpdateScore;
        }

        public static void On_ShootButtonPressed() => _playerController.ShootProjectile();
    }
}