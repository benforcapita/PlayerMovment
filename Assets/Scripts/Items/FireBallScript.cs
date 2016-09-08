using UnityEngine;
using System.Collections;

public class FireBallScript : MonoBehaviour {

    public Vector2 initiateVelocity = new Vector2(100, -100);
    private Rigidbody2D body2d;
    public int bounces = 3;
    
    void Awake()
    {
        body2d = GetComponent<Rigidbody2D>();
    }
	// Use this for initialization
	void Start () {
        var velocityX = initiateVelocity.x * transform.localScale.x;
        body2d.velocity = new Vector2(velocityX, body2d.velocity.y);
	}
	
    void OnCollisionEnter2D(Collision2D target)
    {
        if(target.gameObject.transform.position.y< this.transform.position.y)
        {
            bounces--;
        }
        if(bounces<=0)
        {
            Destroy(this.gameObject);
        }
    }
	
}
