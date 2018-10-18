using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {
    public float JumpSpeed = 1.0f;
    public float MoveSpeed = 1.0f;
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.up *Time.deltaTime*JumpSpeed;
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.down * Time.deltaTime * JumpSpeed;
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * Time.deltaTime * MoveSpeed;
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * Time.deltaTime * MoveSpeed;
        }
    }
}
