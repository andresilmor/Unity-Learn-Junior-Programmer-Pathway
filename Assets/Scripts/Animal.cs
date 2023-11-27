using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Animal : LivingBeing
{
    public virtual string MakesSound() {
        return "does some kind of noise";

    }
}
