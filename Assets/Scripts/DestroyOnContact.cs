using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnContact : MonoBehaviour {

    void OnCollisionEnter (Collision c)
    {
		if (c.gameObject.tag == "Target")
        {
            Destroy(c.gameObject);
            Destroy(gameObject);
        }
	}
}
