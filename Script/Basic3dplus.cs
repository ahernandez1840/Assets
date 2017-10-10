using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basic3dplus : MonoBehaviour {




    // Use this for initialization




    // Use this for initialization
    public int movementAmt = 1;
    public GameObject Hero;
    public Vector3 startingPosition;
    public GameObject winSpot;
    public Vector3 youWin;
    public GameObject[] Floor;
    
    public GameObject [] Enemies;
    public GameObject bg;
    public float enemySpeed = 0.1f;

	public AudioSource HeroAudSrc;

	public AudioClip mooSound;

	public AudioClip coinSound;

    // Use this for initialization
    void Start()
    {
        startingPosition = Hero.transform.position;
        youWin = Hero.transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {


        if (Hero.transform.position.z < -8.75 || Hero.transform.position.z > 8.5 ||
            Hero.transform.position.x > 12 || Hero.transform.position.x < -11 



        ) {

            Hero.transform.position = startingPosition;
            Hero.GetComponent<MeshRenderer>().material.color = Color.red; //access the color through 
			HeroAudSrc.PlayOneShot (mooSound,0.7f);
        }

        if (Hero.transform.position.z <= -7.55) { //z as winSpot
                                                 //if so...
            Debug.Log("win?"); //give us a console message

            Hero.GetComponent<MeshRenderer>().material.color = Color.yellow; //access the color through 
            Hero.transform.localScale *= 1.01f;
			HeroAudSrc.PlayOneShot (coinSound, 0.7f);

            newLevel();
        }



        for (int i = 0; i < Enemies.Length; i++)
        {
            if (Hero.transform.position == Enemies[i].transform.position)
            { //is mover in same position as enemy?
                Hero.transform.position = startingPosition;
            }

            if (Enemies[i].transform.position.x > -8)
            {
                Enemies[i].transform.position += new Vector3(-enemySpeed, 0, 0);
            }
            else
            {
                Enemies[i].transform.position = new Vector3(3, Enemies[i].transform.position.y, Enemies[i].transform.position.z);
            }
        }


       



            if (Input.GetKeyDown(KeyCode.LeftArrow)) {
            Debug.Log("true");
            Hero.transform.position -= new Vector3 (movementAmt, 0, 0);
        } else {
            Debug.Log("false");
        }

        if (Input.GetKeyDown (KeyCode.RightArrow)) {
			Debug.Log ("true");
			Hero.transform.position += new Vector3 (movementAmt, 0, 0);
		} else {
			Debug.Log ("false");
		}

		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			Debug.Log ("true");
			Hero.transform.position += new Vector3 (0, 0, movementAmt);
		} else {
			Debug.Log ("false");
		}

		if (Input.GetKeyDown (KeyCode.DownArrow)) {
			Debug.Log ("true");
			Hero.transform.position += new Vector3 (0, 0, -movementAmt);
		} else {
			Debug.Log ("false");
		}



	}

    void newLevel()
    {
        Hero.transform.position = startingPosition;
        Hero.GetComponent<MeshRenderer>().material.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f), 1F);
        bg.GetComponent<MeshRenderer>().material.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f), 1F);
        enemySpeed += 0.05f;

        for (int i = 0; i < Enemies.Length; i++)
        {
            Enemies[i].transform.position = new Vector3(Random.Range(-10, 11), Enemies[i].transform.position.y, Random.Range(-6, 7));
        }
    }



}