using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    public float rotationSpeed = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.eulerAngles = new Vector3(this.transform.eulerAngles.x, this.gameObject.transform.eulerAngles.y + rotationSpeed * Time.deltaTime, this.gameObject.transform.eulerAngles.z);
    }
}
