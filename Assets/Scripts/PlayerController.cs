using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    [Range(0, 10)]
    float MoveSpeed = 1;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World");
    }

    // Update is called once per frame
    void Update()
    {
        float inputX = Input.GetAxisRaw("Horizontal") * MoveSpeed;
        float inputY = Input.GetAxisRaw("Vertical") * MoveSpeed;

        transform.position += new Vector3(inputX, inputY, 0) * Time.deltaTime;
    }
}
