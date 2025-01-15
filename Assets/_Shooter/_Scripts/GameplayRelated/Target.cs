using UnityEngine;

namespace _Shooter._Scripts.GameplayRelated
{
    public class Target : MonoBehaviour
    {
        //on colliding with the projectile,
        //raises an event to calculate score
        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.CompareTag("Projectile"))
            {
                GameEvents.TargetHit(); 
                Destroy(collision.gameObject);
                Destroy(gameObject);
            }
        }
    }
}