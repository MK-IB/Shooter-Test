using System;
using System.Collections;
using _Shooter._Scripts.GameplayRelated;
using UnityEngine;

namespace _Shooter._Scripts.ControllerRelated
{
    public class Game : MonoBehaviour
    {
        public static Game instance;
        
        [HideInInspector] public static IPlayerController _playerController;
        private IScoreManager _scoreManager;

        private void Awake()
        {
            instance = this;
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

        public IEnumerator DumpUnUsed(GameObject obj, float delay)
        {
            yield return new WaitForSeconds(delay);
            obj.SetActive(false);
        }
    }
}