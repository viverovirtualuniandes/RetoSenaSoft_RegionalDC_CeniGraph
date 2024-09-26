using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerEventCali: MonoBehaviour
{
    public Animator mesacali;
    private bool estaCercaCali = false;

    private void OnTriggerEnter (Collider other)
    {
        if (other.gameObject.name == "Main Camera")
        {
            estaCercaCali = true;
            mesacali.SetBool("estaCercaCali", estaCercaCali);
        }
    }

    private void OnTriggerExit (Collider other)
    {
        if (other.gameObject.name == "Main Camera")
        {
            estaCercaCali = false;
            mesacali.SetBool("estaCercaCali", estaCercaCali);
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