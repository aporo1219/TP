using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearkMove1 : MonoBehaviour
{
    private Vector3 pos;
    // Start is called before the first frame update
    void Start()
    {
        //‰Šú‰»iˆÚ“®j
        pos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //ˆÚ“®
        transform.position = new Vector3(pos.x + Mathf.PingPong(Time.time, 5), pos.y);
    }
}
