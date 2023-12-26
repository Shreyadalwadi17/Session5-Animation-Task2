using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public Animator pa;

    private void FixedUpdate()
    {

        if (Input.GetKey(KeyCode.S))
        {
            pa.SetTrigger("standup");
        }
        if (Input.GetKey(KeyCode.O))
        {
            pa.SetTrigger("epunch");
        }
    }


}
