using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    public Rigidbody2D rb;

    [SerializeField]
    [Range(0, 10)]
    private float moveSpeed = 1;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Debug.Log("Hello World");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float inputX = Input.GetAxisRaw("Horizontal");
        float inputY = Input.GetAxisRaw("Vertical");

        Vector3 oldPosition = transform.position;

        rb.MovePosition(oldPosition + new Vector3(inputX, inputY, 0) * moveSpeed * Time.fixedDeltaTime);
    }
}
