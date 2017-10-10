using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Move : MonoBehaviour
{

    // Use this for initialization

    public GameObject Hero;
    public Vector3 movementAmount;
    public Vector3 movementAmountYZ;
    public GameObject currentCheckpoint;
    public GameObject Starting;
    public Text youwonText;


    // Use this for initialization
    void Start()
    {
        youwonText.text = "";
        movementAmount = new Vector3(1, 0, 0);
        movementAmountYZ = new Vector3(0, 0, 1);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Debug.Log("true");
            Hero.transform.position += movementAmount;
        }
        else
        {
            Debug.Log("false");
        }
        
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Debug.Log("true");
            Hero.transform.position -= movementAmount;
        }
        else
        {
            Debug.Log("false");
        }
      
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("true");
            Hero.transform.position += movementAmountYZ;
        }
        else
        {
            Debug.Log("false");
        }
        
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("true");
            Hero.transform.position -= movementAmountYZ;
        }
        else
        {
            Debug.Log("false");
        }




    }
//    void OnTriggerEnter(Collider other)
//    {
//        if (other.gameObject.CompareTag("Death"))
//        {
//            Debug.Log("One more Chance");
//            Hero.transform.position = currentCheckpoint.transform.position;
//        }
//        if (other.gameObject.CompareTag("Death1"))
//        {
//            Debug.Log("Begin!");
//            Hero.transform.position = Starting.transform.position;
//        }
//        if (other.gameObject.CompareTag("Blah"))
//        {
//            Debug.Log("You won!!");
//            other.gameObject.SetActive(false);
//            youwonText.text = "Congrats!!";
//        }
    }




    

