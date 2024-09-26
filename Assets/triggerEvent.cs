using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerEvent : MonoBehaviour
{
    public Animator mesabogota;
    private bool estaCercaBog = false;

    private void OnTriggerEnter (Collider other)
    {
        if (other.gameObject.name == "Main Camera")
        {
            estaCercaBog = true;
            mesabogota.SetBool("estaCercaBog", estaCercaBog);
        }
    }

    private void OnTriggerExit (Collider other)
    {
        print (other.name);
        if (other.gameObject.name == "Main Camera")
        {
            estaCercaBog = false;
            mesabogota.SetBool("estaCercaBog", estaCercaBog);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}