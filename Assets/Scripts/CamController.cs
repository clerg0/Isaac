using UnityEngine;
using System.Collections;

public class CamController : MonoBehaviour {

    public GameObject Isaac;

    void Start () {
	
	}
	
	
	void Update ()
    {
        FollowIsaac();    
	}

    void FollowIsaac()
    {
        Vector3 newPos = new Vector3(Isaac.transform.position.x, Isaac.transform.position.y, this.transform.position.z);
        this.transform.position = newPos;
    }
}
