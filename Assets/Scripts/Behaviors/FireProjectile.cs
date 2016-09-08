using UnityEngine;
using System.Collections;

public class FireProjectile : AbstractBehavior {


    float shootDelay = .5f;
    public GameObject ProjectilePrefab;
    private float timelapps = 0;
    public Vector2 firePos = Vector2.zero;
    public Color debugColor = Color.yellow;
    public float debugradios = 3;

    void creatProjectile(Vector2 pos)
    {
        var clone =Instantiate(ProjectilePrefab, pos, Quaternion.identity) as GameObject;
        clone.transform.localScale = transform.localScale;
    }
	
	
	// Update is called once per frame
	void Update () {
	if(ProjectilePrefab!= null)
        {
            var canfire = inputState.GetButtonValue(inputButtons[0]);
            if(canfire&& timelapps>shootDelay)
            {
                creatProjectile(calculateFirePos());
                timelapps = 0;
            }
        }
        timelapps += Time.deltaTime;
 
	}

    Vector2 calculateFirePos()
    {
        Vector2 pos = firePos;
        pos.x *= (float)inputState.direction;
        pos.x += transform.position.x;
        pos.y += transform.position.y;
        return pos;
    }

    void OnDrawGizmos()
    {
        Gizmos.color = debugColor;
        Vector2 pos = firePos;
        if(inputState!= null)
        {
            pos.x *= (float)inputState.direction;
        }
      
        pos.x += transform.position.x;
        pos.y += transform.position.y;
        Gizmos.DrawWireSphere(pos, debugradios);
    }
}
