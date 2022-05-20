using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParentPotion : MonoBehaviour
{
   

    public virtual void EffectPotion()
    {

    }
    public virtual void DestroyPotion()
    {
        Destroy(this.gameObject);
    }
    

}
