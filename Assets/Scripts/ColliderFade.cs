using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderFade : MonoBehaviour
{
    Collider m_Collider;
    public float duration = 30.0f;
    // Start is called before the first frame update
    void Start()
    {
        m_Collider = GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {
        if (m_Collider.enabled)
        {
            if (duration > 0)
            {
                duration -= Time.deltaTime;
            }
            else
            {
                m_Collider.enabled = !m_Collider.enabled;
            }
        }
    }
}
