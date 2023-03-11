using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bar : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = Input.mousePosition;
        Vector3 targetPos = Camera.main.ScreenToWorldPoint(new Vector3(pos.x, pos.y, 10));
        transform.position = targetPos;
    }
}
