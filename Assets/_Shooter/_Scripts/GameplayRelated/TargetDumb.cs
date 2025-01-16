using UnityEngine;

namespace _Shooter._Scripts.GameplayRelated
{
    public class TargetDumb : MonoBehaviour, ITarget
    {
       //interface method definition
        public void OnProjectileHit()
        {
            //calling to invoke scoring event
            GameEvents.TargetHit(); 
            Destroy(gameObject);
        }
    }
}