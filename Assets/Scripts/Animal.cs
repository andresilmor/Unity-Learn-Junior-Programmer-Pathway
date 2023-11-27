using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public abstract class Animal : LivingBeing
{
    // POLYMORPHISM
    public virtual string MakesSound() {
        return "does some kind of noise";

    }
}
