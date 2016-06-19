﻿using UnityEngine;
using System.Collections;

public class Stone : Defender {

   

    void OnTriggerStay2D(Collider2D coll)
    {
        attacker attacker = coll.gameObject.GetComponent<attacker>();
        
        if (attacker)
        {
            animator.SetTrigger("underAttackTrigger");
        }
    }
}
