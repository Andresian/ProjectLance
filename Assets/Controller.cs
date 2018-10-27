using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {
	public Rigidbody2D rb;

    public Vector3 mousepos;

    // Use this for initialization
    void Start () {
		rb = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		/*if(Input.GetKey(KeyCode.DownArrow))
		{
			rb.MovePosition(new Vector2(rb.position.x, rb.position.y - 0.1f));
		}
		if(Input.GetKey(KeyCode.UpArrow))
		{
			rb.MovePosition(new Vector2(rb.position.x, rb.position.y + 0.1f));
		}
		if(Input.GetKey(KeyCode.LeftArrow))
		{
			rb.MovePosition(new Vector2(rb.position.x - 0.1f, rb.position.y));
		}
		if(Input.GetKey(KeyCode.RightArrow))
		{
			rb.MovePosition(new Vector2(rb.position.x + 0.1f, rb.position.y));
		}*/
		mousepos = Input.mousePosition;
		mousepos = Camera.main.ScreenToWorldPoint(mousepos);
	    Move();
	}

    void Move()
    {
        float distanceX = mousepos.x - rb.position.x;
        float distanceY = mousepos.y - rb.position.y;
        float absX = Mathf.Abs(distanceX);
        float absY = Mathf.Abs(distanceY);
        if (distanceX > 2f || distanceX < -2f)
        {
            distanceX = (distanceX > 0) ? 2f : -2f;
        }
        if (distanceY > 2f || distanceY < -2f)
        {
            distanceY = (distanceY > 0) ? 2f : -2f;
        }
        //if (absX > 2f && absY > 2f)
        //{
           rb.MovePosition(new Vector2(rb.position.x + distanceX / 30, rb.position.y + distanceY / 30));
        /*}
        else if (absX <= 2f && absY <= 2f)
        {
            rb.MovePosition(new Vector2(rb.position.x + distanceX / 20, rb.position.y + distanceY / 20));
        }
        else
        {
            Vector2 move = (absX <= 2f)
                ? new Vector2(rb.position.x + distanceX / 20, rb.position.y + distanceY / 30)
                : new Vector2(rb.position.x + distanceX / 30, rb.position.y + distanceY / 20);
            rb.MovePosition(move);
        }*/
    }
}
