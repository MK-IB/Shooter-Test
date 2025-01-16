using System.Collections.Generic;
using UnityEngine;

namespace _Shooter._Scripts.GameplayRelated
{
    public class ProjectilePool : MonoBehaviour
    {
        public static ProjectilePool instance;
        
        public GameObject projectilePrefab;
        public int poolSize = 500;

        private Queue<GameObject> pool = new Queue<GameObject>();

        private void Awake()
        {
            instance = this;
            // Initialize the pool
            for (int i = 0; i < poolSize; i++)
            {
                GameObject projectile = Instantiate(projectilePrefab);
                projectile.SetActive(false); // Disable the projectile initially
                pool.Enqueue(projectile);
            }
        }

        public GameObject GetProjectile()
        {
            // Check if a projectile is available in the pool
            if (pool.Count > 0)
            {
                GameObject projectile = pool.Dequeue();
                projectile.SetActive(true); // Enable the projectile
                return projectile;
            }

            // If no projectiles are available, optionally expand the pool (optional)
            GameObject newProjectile = Instantiate(projectilePrefab);
            return newProjectile;
        }

        public void ReturnProjectile(GameObject projectile)
        {
            projectile.SetActive(false); // Disable the projectile
            pool.Enqueue(projectile); // Add it back to the pool
        }
    }
}