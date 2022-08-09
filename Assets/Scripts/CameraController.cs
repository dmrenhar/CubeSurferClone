using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]
    private GameObject Target;
    public Vector3 distance;

    private void LateUpdate()
    {
        this.transform.position = Vector3.Lerp(this.transform.position, Target.transform.position + distance, Time.deltaTime);
    }
}
