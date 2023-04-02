using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    public GameObject northExit, southExit, eastExit, westExit;
    public float movementSpeed = 40.0f;


    // Start is called before the first frame update
    void Start()
    {
        this.rb = this.GetComponent<Rigidbody>();
        print(MasterData.count);
        MasterData md = new MasterData();
     
    }

    // Update is called once per frame
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
           StartCoroutine(MoveitN());
        }
        if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            StartCoroutine (MoveitS());
        }
        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            StartCoroutine (MoveitE());
        }
        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
           StartCoroutine (MoveitW());
        }
            
    }

    private IEnumerator MoveitN()
    {
        this.rb.AddForce(this.northExit.transform.position * movementSpeed);
        yield return new WaitForSeconds((float)1.25);
        MasterData.count++;
        SceneManager.LoadScene("DungeonRoom");
    }
    private IEnumerator MoveitE()
    {
        this.rb.AddForce(this.eastExit.transform.position * movementSpeed);
        yield return new WaitForSeconds((float)1.25);
        MasterData.count++;
        SceneManager.LoadScene("DungeonRoom");
    }

    private IEnumerator MoveitS() 
    {
        this.rb.AddForce(this.southExit.transform.position * movementSpeed);
        yield return new WaitForSeconds((float)1.25);
        MasterData.count++;
        SceneManager.LoadScene("DungeonRoom");
    }

    private IEnumerator MoveitW() 
    {
        this.rb.AddForce(this.westExit.transform.position * movementSpeed);
        yield return new WaitForSeconds((float)1.25);
        MasterData.count++;
        SceneManager.LoadScene("DungeonRoom");
    }
}
