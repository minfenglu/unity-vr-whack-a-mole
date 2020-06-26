using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (Input.GetKeyDown("space")){
            RaycastHit hit;
            if (Physics.Raycast(transform.position, transform.forward, out hit)) {
                Debug.Log(hit.transform.name);
            }
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
