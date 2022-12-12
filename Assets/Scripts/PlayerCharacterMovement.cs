using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacterMovement : MonoBehaviour
{
    [SerializeField]
    [Range(0, 1000)]
    private float MoveSpeed = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World");
    }

    // Update is called once per frame
    void Update()
    {
        float xInput = Input.GetAxis("Horizontal");
        float yInput = Input.GetAxis("Vertical");

        Vector3 oldPosition = transform.position;
        Flip(xInput);

        transform.position = oldPosition + new Vector3(xInput, yInput, 0) * MoveSpeed * Time.deltaTime;
    }

    public void Flip(float x)
    {
        if(x != 0.0f)
        {
            transform.localScale = new Vector3((x > 0.0f) ? 1.0f : -1.0f, 1.0f, 1.0f);
        }
    }
}
