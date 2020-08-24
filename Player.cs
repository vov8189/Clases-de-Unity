using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float speed = 5;
    public Vector3 pToGo = new Vector3(0, 0, 0);
    Rigidbody rb;
    public int hp = 50;
    private void Awake()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }
    void Update()
    {
        move(pToGo);
    }
    
    private void move(Vector3 pointToGo)
    {
        Vector3 pos = gameObject.transform.position;

        Vector3 direction = pointToGo - pos;
        direction.y = 0f;
        Vector3 norm = direction.normalized;

        rb.AddForce(norm * speed);
    }
}
