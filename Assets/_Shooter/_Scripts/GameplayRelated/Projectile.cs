using UnityEngine;

namespace _Shooter._Scripts.GameplayRelated
{
    public class Projectile : MonoBehaviour
    {
        private void OnCollisionEnter(Collision collision)
        {
            //checking if the collided object has implemented ITarget interface
            ITarget target = collision.collider.GetComponent<ITarget>();
            if (target != null)
            {
                target.OnProjectileHit();
                ProjectilePool.instance.ReturnProjectile(gameObject);
            }

            if (collision.collider.name.Contains("Border"))
            {
                ProjectilePool.instance.ReturnProjectile(gameObject);
            }
        }
    }
}
