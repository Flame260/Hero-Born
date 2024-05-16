using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itembehavior : MonoBehaviour
{
    // Start is called before the first frame update
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "player")
        {
            Destroy(this.transform.gameObject);
//after picking up items
            Debug.Log(" item collected! ");
        }
    }

}
