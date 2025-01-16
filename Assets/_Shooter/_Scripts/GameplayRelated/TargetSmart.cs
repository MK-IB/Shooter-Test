using _Shooter._Scripts.GameplayRelated;
using UnityEngine;

public class TargetSmart : MonoBehaviour, ITarget
{
    //interface method definition
    public void OnProjectileHit()
    {
        //calling to invoke scoring event
        GameEvents.TargetHit(); 
        Destroy(gameObject);
    }
}
