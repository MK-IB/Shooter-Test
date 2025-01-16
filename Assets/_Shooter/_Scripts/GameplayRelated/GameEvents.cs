using System;

namespace _Shooter._Scripts.GameplayRelated
{
    public static class GameEvents
    {
        public static event Action OnTargetHit;

        //invoking the event when a target is hit
        public static void TargetHit()
        {
            OnTargetHit?.Invoke();
        }
    }
}