using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickerCode : MonoBehaviour
{
    GameObject mainCube;
    int high;
    void Start()
    {
        mainCube = GameObject.FindGameObjectWithTag("mainCube");   
    }

    void Update()
    {
        mainCube.transform.position = new Vector3(transform.position.x, high + 1, transform.position.z);
        this.transform.localPosition = new Vector3(0, -high, 0);
    }
    public void highReduce()
    {
        high-= 1;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("CollectibleCube") && !other.gameObject.GetComponent<CollectibleObjects>().GetHasİtGathered())
        {
            Debug.Log("toplandı");
            high++;
            other.gameObject.GetComponent<CollectibleObjects>().wasGathered();
            other.gameObject.GetComponent<CollectibleObjects>().Index(high);
            other.gameObject.transform.parent = mainCube.transform;

        }
    }
}
