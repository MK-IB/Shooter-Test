using _Shooter._Scripts.ControllerRelated;
using UnityEngine;

namespace _Shooter._Scripts.GameplayRelated
{
    public class TargetDumb : MonoBehaviour, ITarget
    {

        [SerializeField] private GameObject explosionFx;
        
       //interface method definition
        public void OnProjectileHit()
        {
            //calling to invoke scoring event
            GameEvents.TargetHit();
            explosionFx.SetActive(true);
            explosionFx.transform.parent = null;
            Game.instance.StartCoroutine(Game.instance.DumpUnUsed(explosionFx, 2));
            Destroy(gameObject);
        }
        
    }
}