using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingController : MonoBehaviour {

    public Rigidbody projectile;
    public float force;
    public float shootDelay;
    public float lifetime;
    public Camera cam;
    public float  rotateNum;

	// Update is called once per frame
	void Update () {
        RaycastHit hit;
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);

        Vector3 temp = Input.mousePosition;
        temp.z = 1.0f; // Set this to be the distance you want the object to be placed in front of the camera.
        this.transform.position = Camera.main.ScreenToWorldPoint(temp);

        if (Input.GetMouseButtonDown(0) && Physics.Raycast(ray, out hit)) {
            Transform objectHit = hit.transform;
            Rigidbody clone;
            clone = Instantiate(projectile, transform.position, transform.rotation);
            clone.transform.Rotate(new Vector3(90, 0, 0));
            clone.AddForce(0, 0, force * 2, ForceMode.Impulse);
            Destroy(clone.gameObject, lifetime);
            print("nothing");
        }
        if (Input.GetKey(KeyCode.A))
        {
            cam.transform.Rotate(0, -rotateNum, 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            cam.transform.Rotate(0, rotateNum, 0);
        }
    }

}
