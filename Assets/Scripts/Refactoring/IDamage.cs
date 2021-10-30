using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDamage
{
    public Transform GetTransform();
    public void Damage(int daño);
}
