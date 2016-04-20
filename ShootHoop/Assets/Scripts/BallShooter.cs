using UnityEngine;
using System.Collections;

public class BallShooter : MonoBehaviour {

    public GameObject ballSpawn;
    public float ballSpeed = 15.0f;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire1"))
        {
            ShootBall();
        }
    }

    private void ShootBall()
    {
        GameObject instance = Instantiate(ballSpawn);
        Transform transf = instance.GetComponent<Transform>();
        Rigidbody rb = instance.GetComponent<Rigidbody>();
        Transform camera = transform.Find("Camera");
        transf.position = camera.transform.position;
        Vector3 direction = camera.transform.forward;
        rb.velocity = direction * ballSpeed;
    }
}
