using UnityEngine;
using System.Collections;

public class BallSound : MonoBehaviour {

	void OnCollisionEnter(Collision collision)
    {
        AudioSource source = GetComponent<AudioSource>();
        source.Play();
    }
}
