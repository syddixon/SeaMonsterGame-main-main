using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Anchor : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] GameObject explodePrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed * Time.deltaTime * Vector3.right);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //destroy anchor
        Destroy(collision.gameObject);
        Destroy(gameObject);

        //play sound effect
		AudioSource audioSource;
		audioSource = GetComponent<AudioSource>();
		audioSource.Play();

        //instantiate explosion
		Instantiate(explodePrefab, transform.position, transform.rotation);
    }
    
}