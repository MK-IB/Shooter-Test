using UnityEngine;

namespace _Shooter._Scripts.ControllerRelated
{
    public class TargetController : MonoBehaviour, ITargetFactory
    {
        public GameObject dumbTargetPrefab;
        public GameObject smartTargetPrefab;

        public GameObject CreateTarget(TargetType type, Vector3 position, Quaternion rotation)
        {
            GameObject targetPrefab = null;

            switch (type)
            {
                case TargetType.Dumb:
                    targetPrefab = dumbTargetPrefab;
                    break;
                case TargetType.Smart:
                    targetPrefab = smartTargetPrefab;
                    break;
                default:
                    Debug.LogError("Invalid TargetType specified!");
                    return null;
            }

            return Instantiate(targetPrefab, position, rotation);
        }
    }
}
