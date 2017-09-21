using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour {

    public int mapHalfWidth;
    public int mapHalfHeight;

    public Transform[] blockTypes;
    List<Vector2> critPath = new List<Vector2>();

    public Vector2[] playerStartPos;

	// Use this for initialization
	void Start () {
        playerStartPos = new Vector2[] {
            new Vector2(-mapHalfWidth, mapHalfHeight),
            new Vector2(mapHalfWidth, mapHalfHeight),
            new Vector2(-mapHalfWidth, -mapHalfHeight),
            new Vector2(mapHalfWidth, -mapHalfHeight),
        };
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    class Vertex
    {
        public Vector2 location;
        public Vertex parent;
    }

    void generateCritPath(Vector2 start)
    {
        Stack<Vertex> toBeSearched = new Stack<Vertex>();
        Vertex startVertex = new Vertex();
        startVertex.location = start;
        toBeSearched.Push(startVertex);
    }
}
