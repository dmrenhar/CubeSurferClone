using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMove : MonoBehaviour
{
    [SerializeField]
    private float forwardSpeed;
    [SerializeField]
    private float leftAndRightSpeed;

    void Update()
    {
        float horizontalAxis = Input.GetAxis("Horizontal") * leftAndRightSpeed * Time.deltaTime;
        this.transform.Translate(horizontalAxis, 0, forwardSpeed * Time.deltaTime);
    }
}
