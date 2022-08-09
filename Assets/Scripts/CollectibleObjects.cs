using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleObjects : MonoBehaviour
{
    bool hasİtGathered;
    int index;
    public pickerCode picker_code;
    void Start()
    {

        picker_code = GameObject.Find("picker").GetComponent<pickerCode>();
        hasİtGathered = false;
    }

    void Update()
    {
        if (hasİtGathered)
        {
            if(transform.parent != null)
           transform.localPosition = new Vector3(0, -index, 0);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("barrier"))
        {

            //picker_code = GameObject.Find("picker").GetComponent<pickerCode>();
            picker_code.GetComponent<pickerCode>().highReduce();
            transform.parent = null;
            GetComponent<BoxCollider>().enabled = false;
            other.gameObject.GetComponent<BoxCollider>().enabled = false;
        }
    }

    public bool GetHasİtGathered()
    {
        return hasİtGathered;
    }
    public void wasGathered()
    {
        hasİtGathered = true;
    }
    public void Index(int index)
    {
        this.index = index;
    }
}
