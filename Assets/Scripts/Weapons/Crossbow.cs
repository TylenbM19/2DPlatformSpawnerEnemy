using UnityEngine;

public class Crossbow : Weapons
{
    public override void Shoot(Transform shooPoint)
    {
        Instantiate(Arrow, shooPoint.position, Quaternion.identity);
    }
}
