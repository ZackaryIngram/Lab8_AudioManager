using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    [Range(0, 5)]
    private float m_moveSpeed = 10.0f;

    [SerializeField]
    Rigidbody2D rigidbody;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float xInput = Input.GetAxis("Horizontal");
        float yInput = Input.GetAxis("Vertical");

        Vector3 oldPosition = transform.position;

        rigidbody.MovePosition(oldPosition + new Vector3(xInput, yInput, 0) * m_moveSpeed * Time.deltaTime);
        //transform.position = oldPosition + new Vector3(xInput, yInput, 0) * m_moveSpeed * Time.deltaTime;
    }
}
