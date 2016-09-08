using UnityEngine;
using System.Collections;

public abstract class Collecteble : MonoBehaviour {

    public string targeTag = "Player";
	// Use this for initialization
	void OnTriggerEnter2D(Collider2D target)
    {
       
        if(target.gameObject.tag==targeTag)
        {
            OnCollect(target.gameObject);
            OnDestroy();
        }
    }
    protected virtual void OnCollect(GameObject target)
    {

    }

    protected virtual void OnDestroy()
    {
        Destroy(gameObject);
    }
}
