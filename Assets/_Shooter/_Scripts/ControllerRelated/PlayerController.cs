using System;
using UnityEngine;

namespace _Shooter._Scripts.GameplayRelated
{
    public class PlayerController : MonoBehaviour
    {
        public static PlayerController instance;
        
        public float moveSpeed = 5f;
        public GameObject projectilePrefab;
        public Transform projectileSpawnPoint;
        public float projectileSpeed = 10f;

        private void Awake()
        {
            if (instance) DestroyImmediate(gameObject);
            else instance = this;
        }

        private void Update()
        {
            // taking input
            float moveX = Input.GetAxis("Horizontal");
            float moveZ = Input.GetAxis("Vertical");

            Vector3 moveDirection = new Vector3(moveX, 0f, moveZ).normalized;
            transform.Translate(moveDirection * moveSpeed * Time.deltaTime, Space.World);

            // Rotate to face to the Movement direction
            if (moveDirection != Vector3.zero)
            {
                Quaternion toRotation = Quaternion.LookRotation(moveDirection, Vector3.up);
                transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, 720 * Time.deltaTime);
            }

            // Shoot on space button press
            /*if (Input.GetKeyDown(KeyCode.Space))
            {
                ShootProjectile();
            }*/
        }

        public void ShootProjectile()
        {
            if (projectilePrefab && projectileSpawnPoint)
            {
                GameObject projectile = Instantiate(projectilePrefab, projectileSpawnPoint.position, Quaternion.identity);
                Rigidbody rb = projectile.GetComponent<Rigidbody>();
                if (rb)
                {
                    rb.velocity = transform.forward * projectileSpeed;
                }
            }
        }
    }
}
