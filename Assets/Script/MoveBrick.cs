using UnityEngine;
using System.Collections;

public class MoveBrick : MonoBehaviour {

    public enum Direction {right, left, down};
    

    // 所有位置点的根节点 
    GameObject posRoot;
    float distance = 0;

	// Use this for initialization
	void Start () {
        // 所有位置根节点 
        posRoot = GameObject.Find("POSRoot") as GameObject;
        distance = posRoot.transform.localScale.x / 10;
	}
	
	// Update is called once per frame
	void Update () {

	}


    void MoveTo( GameObject obj, Direction direction )
    {
        float distX = 0;
        float distY = 0;

        switch(direction)
        {
            case Direction.left:  distX = -distance;
            break;

            case Direction.right: distX = distance;
            break;

            case Direction.down:  distY = -distance;
            break;

            default:
            break;
        }

        obj.transform.localPosition += new Vector3(obj.transform.localPosition.x + distX, 
                                                   obj.transform.localPosition.y + distY,
                                                   obj.transform.localPosition.z);

    }















}
