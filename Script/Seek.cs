using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seek : MonoBehaviour
{

    public Transform target;
    Rigidbody seeker;
    public float thrust;
     public AudioSource PuppyAudSrc;

    public AudioClip happydogSound;
    public GameObject Puppy;
    public GameObject Alien;

    // Use this for initialization
    void Start()
    {
        seeker = GetComponent<Rigidbody>();
        PuppyAudSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetDir = Vector3.Normalize(target.position - transform.position);
        seeker.AddForce(targetDir * thrust);

        if (Puppy.transform.position == Alien.transform.position)
        { //is mover in same position as enemy?
            PuppyAudSrc.PlayOneShot(happydogSound, 0.7f);
        }

        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                seeker.AddForce(Vector3.forward * thrust);
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                seeker.AddForce(Vector3.back * thrust);
            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                seeker.AddForce(Vector3.left * thrust);
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                seeker.AddForce(Vector3.right * thrust);
            }
        }

    }

    void OnCollisionEnter(Collision col)
    {
       
         if(col.gameObject.name == "Alien")
        {
            PuppyAudSrc.Play();
        }
    }
}









