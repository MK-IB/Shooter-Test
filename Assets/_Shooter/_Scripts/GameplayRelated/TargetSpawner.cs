using _Shooter._Scripts.ControllerRelated;
using _Shooter._Scripts.GameplayRelated;
using UnityEngine;

public class TargetSpawner : MonoBehaviour
{
    public ITargetFactory targetController;
    public float spawnInterval = 2f; // Time between spawns
    public Vector3 spawnAreaMin;
    public Vector3 spawnAreaMax;

    private Transform _playerTransform;

    private void Start()
    {
        targetController = FindObjectOfType<TargetController>();
        InvokeRepeating(nameof(SpawnTarget), 0f, spawnInterval);
        _playerTransform = PlayerController.instance.transform;
    }

    private void SpawnTarget()
    {
        // Randomly instantiate a target type
        TargetType randomType = (TargetType)Random.Range(0, System.Enum.GetValues(typeof(TargetType)).Length);

        // generating a random spawn position
        Vector3 randomPosition = new Vector3(
            Random.Range(spawnAreaMin.x, spawnAreaMax.x),
            0,
            Random.Range(spawnAreaMin.z, spawnAreaMax.z)
        );

        //spawn the target
        GameObject target = targetController.CreateTarget(randomType, randomPosition, Quaternion.identity);
        Quaternion lookRotation = Quaternion.LookRotation(_playerTransform.position - randomPosition);
        target.transform.rotation = Quaternion.RotateTowards(target.transform.rotation, lookRotation, 360);
    }
}