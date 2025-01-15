using System;
using UnityEngine;

namespace _Shooter._Scripts.GameplayRelated
{
    public class MiniMapCameraFollower : MonoBehaviour
    {
        [SerializeField] private float followSpeed;
        private Transform _player;

        private void Start()
        {
            _player = PlayerController.instance.transform;
        }

        private void Update()
        {
            Vector3 smoothPos = Vector3.Lerp(transform.position, _player.position, Time.deltaTime * followSpeed);
            transform.position = new Vector3(smoothPos.x, transform.position.y, smoothPos.z);
        }
    }
}
