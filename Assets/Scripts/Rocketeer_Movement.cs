using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
   
    [SerializeField] float verticalSpeed = 3.0f;
    [SerializeField] public float stopYPosition = 0.0f;
    [SerializeField] public Transform playerTransform; // ��������� ������, �� ������� ������� ����

    private bool reachedPosition = false;

    void Update()
    {
        // ������������ �������� � �������� �����
        if (!reachedPosition)
        {
            float step = verticalSpeed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, stopYPosition, transform.position.z), step);

            // �������� ���������� �������
            if (Mathf.Abs(transform.position.y - stopYPosition) < 0.01f)
            {
                reachedPosition = true;
            }
        }
        else // ������� � ������
        {
            Vector3 direction = playerTransform.position - transform.position;
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg - 90f; // ������� �� 90 �������� ��� ���������� ����������
            transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        }
    }
}