using UnityEngine;
using System.Collections;

public class SeaController : MonoBehaviour {
    
    private int _speed;
    private Transform _transform;
    
    
    //Public Properties, this is where we assign values to private properties

        public int Speed{
        get {
            return this._speed;
        }
        set {
            this._speed = value;
        }
    }
    
    // Use this for initialization

    void Start () {
        //telling compiler that _transform component that comes from my object in unity (Sea) is getting referenced and stored in this private class variable
        //my current position is being stored in this _transform component, keeps track of my psition every frame
        this._transform = this.GetComponent<Transform> ();

        //what speed goes my Sea for pixel per frame
        this._speed = 5;

        
	}
	
	// Update is called once per frame
	void Update () {
        this._move();
        this._checkBounds();
        
    }

    //moves game object (sea) up
    private void _move() {
        //just taking current position of _transform into new position, just making them equal
        Vector2 newPosition = this._transform.position;

        //taking new position y coordinate and add speed to it
        newPosition.y -= this._speed;

        //putting it back into the old position thus we are incurring change in position
        this._transform.position = newPosition;
    }

    //this method will make sure the game object doesnt keep moving beyond the scope of what we want.

    private void _checkBounds()
    {
        if (this._transform.position.y <= -6426f) {

            this._reset();
        }

    }
    //this method reset game object to orginal position we had, 591 f in y axis.

    private void _reset() {
        this._transform.position = new Vector2(0f, 591f);
    }
}

