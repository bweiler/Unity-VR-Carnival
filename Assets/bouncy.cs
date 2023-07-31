using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bouncy : MonoBehaviour
{
    Vector3 base_pos;
    float offset_x, offset_y, offset_z;

    // Start is called before the first frame update
    void Start()
    {
        base_pos = transform.position;
        offset_x = 0.0f;
        offset_y = 0.0f;
        offset_z = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {


            transform.position = new Vector3(base_pos.x + Mathf.Sin(offset_x), base_pos.y + Mathf.Sin(offset_y), base_pos.z + Mathf.Sin(offset_z));
            offset_x += 0.01f;
            offset_y += 0.02f;
            offset_z += 0.03f;
            if (offset_x >= Mathf.PI)
                offset_x = 0.0f;
            if (offset_y >= Mathf.PI)
                offset_y = 0.0f;
            if (offset_z >= Mathf.PI)
                offset_z = 0.0f;
    }
}

