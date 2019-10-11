using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightFade : MonoBehaviour
{

    public float duration = 30.0f;
    public float originalRange;
    Light lt;
    // Start is called before the first frame update
    void Start()
    {
        lt = GetComponent<Light>();
        originalRange = lt.range;
    }

    // Update is called once per frame
    void Update()
    {
        if(duration > 0)
        {
            duration -= Time.deltaTime;
            lt.range = duration;
        }
    }
}
