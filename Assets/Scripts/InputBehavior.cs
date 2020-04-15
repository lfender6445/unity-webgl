using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    public float updatedX;

    void Start()
    {
        player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log("calling update");
        // gameObject.GetComponent<
        if (Input.GetKey(KeyCode.LeftArrow)) {
            updatedX = player.transform.position.x + .1f;
            player.transform.position = new Vector3(updatedX, player.transform.position.y, transform.position.z);
        }

        if (Input.GetKey(KeyCode.RightArrow)) {
            updatedX = player.transform.position.x - .1f;
            player.transform.position = new Vector3(updatedX, player.transform.position.y, transform.position.z);
        }
    }
}
