using UnityEngine;

public class AttachOneToOther : MonoBehaviour
{
    public GameObject mainObj, secondObj;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        secondObj.transform.position = mainObj.transform.position;
    }
}
