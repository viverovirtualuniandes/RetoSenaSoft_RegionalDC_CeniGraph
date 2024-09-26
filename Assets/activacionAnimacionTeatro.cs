using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activacionAnimacionTeatro : MonoBehaviour
{

    public Animator bogotaCrece;
    private bool estaCercaBog = false;

    private void OnTriggerEnter (Collider other)
    {
        if (other.gameObject.name == "Main Camera")
        {
            estaCercaBog = true;
            bogotaCrece.SetBool ("estaCercaBog", estaCercaBog);
        }
    }

    private void OnTriggerExit (Collider other)
    {
        if (other.gameObject.name == "Main Camera")
        {
            estaCercaBog = false;
            bogotaCrece.SetBool("estaCercaBog", estaCercaBog);
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
