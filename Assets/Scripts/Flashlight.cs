using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Flashlight : MonoBehaviour
{
    //public MonsterMove monster;
    private Ray ray;
    private RaycastHit hit;
    private string enemy = "Monster";
    public bool trigger = false;

    // Start is called before the first frame update
    void Start()
    {
        MonsterMove MonsterMove = GetComponent<MonsterMove>();
    }

    /*
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == enemy)
        {
            //Debug.Log("tag is monster");
            trigger = true;
        }
        else
        {
            trigger = false;
            //Debug.Log("tag is not monster");
        }
    }
    */
    // Update is called once per frame
    void Update()
    {
        /*
        if (trigger)
        {
            Debug.Log("Trigger True");
            MonsterMove.In
            gameObject.GetComponent<MonsterMove>().MonsterStop();
        }
        else
        {
            Debug.Log("Trigger False");
            gameObject.GetComponent<MonsterMove>().MonsterGo();
        }

        // creates ray that extends outward
        //ray = new Ray(transform.position, transform.forward);
        //Debug.DrawRay(transform.position, transform.forward, Color.green, 10);
        // if ray hits tagged Monster

        */

        /*
        if (Physics.Raycast (ray, out hit))
        {

            if (hit.transform.tag == enemy)
            {
                GetComponent<MonsterMove>().MonsterStop();
                Debug.Log("Monster Stoped");
                //monster.MonsterStop();
            }
        }
        else
        {
            GetComponent<MonsterMove>().MonsterGo();
            Debug.Log("Monster Go");
            //monster.MonsterGo();
        }
        */    }

}
