using UnityEngine;
using System.Collections;

public class RaftController : MonoBehaviour {

    private Transform _transform;

	// Use this for initialization
	void Start () {

            
        //just taking current position of _transform into new position, just making them equal
        this._transform = this.GetComponent<Transform>();

	}
	
	// Update is called once per frame
	void Update () {

        

    }

    private void _move() {
        //locking my y at -200f and the x is gonna change, side scrolling game. 
        this._transform.position = new Vector2(Mathf.Clamp(Input.mousePosition.x - 1300f,-2345f,2371f ), -5000f);

    }
}
