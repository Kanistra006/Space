using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Is_On_Pos : MonoBehaviour
{
    [SerializeField] double speed_eblan1;
    [SerializeField] double eblan1_coord;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y != eblan1_coord)
        {

        }
    }
}
