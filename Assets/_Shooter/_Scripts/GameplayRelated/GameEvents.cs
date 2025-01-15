using System;

namespace _Shooter._Scripts.GameplayRelated
{
    public static class GameEvents
    {
        public static event Action OnTargetHit;

        public static void TargetHit()
        {
            OnTargetHit?.Invoke();
        }
    }
}