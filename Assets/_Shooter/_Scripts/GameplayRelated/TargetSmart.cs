using _Shooter._Scripts.ControllerRelated;
using _Shooter._Scripts.GameplayRelated;
using UnityEngine;

public class TargetSmart : MonoBehaviour, ITarget
{
    [SerializeField] private GameObject explosionFx;
    public float speed = 3f;

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
    
    private void Update()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }
}
