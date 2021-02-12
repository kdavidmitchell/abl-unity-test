using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bot : MonoBehaviour
{
    // Current bot counter.
    static int IdCount = 0;

    // A bot's unique ID.
    private int _id;
    // A bot's current position as vector(x, y, z).
    private Vector3 _position;

    public Bot() {
        this._id = IdCount++;
        this._position = Vector3.zero;
    } 

    public int Id {
        get { return this._id; }
        set { this._id = value; }
    }

    public Vector3 Position {
        get { return this._position; }
        set { this._position = value; }
    }

    public float X {
        get { return this._position.x; }
        set { this._position.x = value; }
    }

    public float Y {
        get { return this._position.y; }
        set { this._position.y = value; }
    }

    public float Z {
        get { return this._position.z; }
        set { this._position.z = value; }
    }

    // Start is called before the first frame update
    void Start()
    {
        // Set this bot's transform to be equal to starting position.
        transform.position = _position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
