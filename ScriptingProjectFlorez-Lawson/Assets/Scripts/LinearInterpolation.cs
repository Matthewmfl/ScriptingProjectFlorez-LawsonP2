using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinearInterpolation : MonoBehaviour
{
    /* In this case, result = 4
    float result = Mathf.Lerp(3f, 5f, 0.5f);

    // Vector that leads to result below; different float variables are the different values
    Vector3 from = new Vector3 (1f, 2f, 3f);
    Vector3 to = new Vector3 (5f, 6f, 7f);

    // Here result = (4, 5, 6)
    // 4 is 75% of the way between 1 and 5; 5 is 75% of the way between 2 and 6; 6 is 75% of the way between 3 and 7
    Vector3 result = Vector3.Lerp (from, to, 0.75f);

    // Update is called once per frame
    void Update()
    {
        // light intensity will tend towards 8 but the rate of its change will slow as it approaches its target over several frames
        light.intensity = Mathf.Lerp(light.intensity, 8f, 0.5f);
        // change to intensity would happen per second instead of per frame
        light.intensity = Mathf.Lerp(light.intensity, 8f, 0.5f * Time.deltaTime);
    }*/
}
