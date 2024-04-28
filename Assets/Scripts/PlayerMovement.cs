using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] int _speed = 25;
    public float boundaryLeft = -8.2f;
    public float boundaryRight = 8.2f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Mathf.Clamp(transform.position.x, boundaryLeft, boundaryRight);
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += new Vector3(1f, 0) * _speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += new Vector3(-1f, 0) * _speed * Time.deltaTime;
        }
        
    transform.position = new Vector3(
            Mathf.Clamp(transform.position.x, boundaryLeft, boundaryRight),
            transform.position.y,
            transform.position.z);

    }
}
