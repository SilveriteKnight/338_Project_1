using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterMove : MonoBehaviour
{

    public Transform myTrans;
    public Transform target;
    public float duration = 30.0f;

    Vector3 targetLoc;
    float oriX;
    float oriZ;

    //Monster Movement Speed
    private float speed = 0.5f;
    public bool canMove = true;
    // Start is called before the first frame update
    void Start()
    {
        myTrans = this.transform;
        oriX = myTrans.position.x;
        oriZ = myTrans.position.z;
    }


    public void MonsterStop()
    {
        //speed = 0.0f;
        
        canMove = false;
    }

    public void MonsterGo()
    {
        //speed = 0.0f;
        //speed = 0.2f;
        
        canMove = true;
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "FlashLight")
        {
            //Debug.Log("Monster Freeze");
            canMove = false;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "FlashLight")
        {
            //Debug.Log("Monster Move");
            canMove = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(duration);
        duration -= Time.deltaTime;
        targetLoc = target.position;
        if(targetLoc.y != -0.2)
        {
            targetLoc.y = -0.2f;
        }
        Vector3 relativePos = target.position - transform.position;
        Quaternion rotation = Quaternion.LookRotation(relativePos, -Vector3.forward);


        /*
        Vector3 targetDir = target.position - transform.position;
        float turnstep = speed * Time.deltaTime;
        Vector3 newDir = Vector3.RotateTowards(transform.forward, targetDir, turnstep, 0.0f);
        transform.rotation = Quaternion.LookRotation(newDir);
        */



        //Vector3 targetdir = new Vector3(oriX, target.position.y, oriZ);
        Debug.Log("Target Y is " + target.position.y);
        myTrans.rotation = Quaternion.Euler(-90, target.position.x, -102);
        //Debug.Log("OriX is " + oriX);
        //Debug.Log("Mon Y is " + this.transform.position.y);
        //Debug.Log("Tar Y is " + target.position.y);



        if (canMove)
        {
            //myTrans.position = Vector3.Lerp(myTrans.position, target.position, speed * Time.deltaTime);
            float step =  speed * Time.deltaTime; // calculate distance to move
            transform.position = Vector3.MoveTowards(myTrans.position, targetLoc, step);
        }

        if (duration < 0)
        {
            canMove = true;
        }

    }

}
