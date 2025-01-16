using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//all the interafaces needed in the game
public interface ITarget
{
    public void OnProjectileHit();
}

public interface IScoreManager
{
    public void UpdateScore();
}

public interface IPlayerController
{
    public void ShootProjectile();
}

public interface ITargetFactory
{
    public GameObject CreateTarget(TargetType type, Vector3 position, Quaternion rotation);
}


//Target types
public enum TargetType
{
    Dumb,
    Smart,
}



