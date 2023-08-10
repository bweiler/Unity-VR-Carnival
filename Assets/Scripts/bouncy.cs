using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Have Asset move constantly in x,y and z, based on sin waveforms
//
//At 90fps offset = (2 * PI * freq) / 90
//
public class bouncy : MonoBehaviour
{
    private Vector3 base_pos;
    private float add_to_x, add_to_y, add_to_z;
    private float offset_x, offset_y, offset_z;
    private const float x_freq = 0.2f;
    private const float y_freq = 0.3f;
    private const float z_freq = 0.4f;
    private const float VR_fps = 90f;

    // Start is called before the first frame update
    void Start()
    {
        base_pos = transform.position;
        offset_x = 0.0f;
        offset_y = 0.0f;
        offset_z = 0.0f;

        add_to_x = ((2f * Mathf.PI * x_freq) / VR_fps);
        add_to_y = ((2f * Mathf.PI * y_freq) / VR_fps); 
        add_to_z = ((2f * Mathf.PI * z_freq) / VR_fps);

    }

    // Update is called once per frame
    void Update()
    {
            transform.position = new Vector3(base_pos.x + Mathf.Sin(offset_x), base_pos.y + Mathf.Sin(offset_y), base_pos.z + Mathf.Sin(offset_z));
            offset_x += add_to_x;
            offset_y += add_to_y;
            offset_z += add_to_z;
            if (offset_x >= Mathf.PI)
                offset_x = 0.0f;
            if (offset_y >= Mathf.PI)
                offset_y = 0.0f;
            if (offset_z >= Mathf.PI)
                offset_z = 0.0f;
    }
}

