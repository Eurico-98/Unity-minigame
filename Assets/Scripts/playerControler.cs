using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scene1 : MonoBehaviour
{
    [SerializeField] private float movementSpeed = 2f; //SerializeField allows for variable to be viewd in the unity editor but remain private to the current script

    // Update is called once per frame
    private void Update(){

        Vector2 inputVector = new Vector2(0, 0);

        if (Input.GetKey(KeyCode.W)) {
            inputVector.y = +1;
        }
        if (Input.GetKey(KeyCode.S)){
            inputVector.y = -1;
        }
        if (Input.GetKey(KeyCode.A)){
            inputVector.x = -1;
        }
        if (Input.GetKey(KeyCode.D)){
            inputVector.x = +1;
        }

        inputVector = inputVector.normalized; // keep movement speed normalized when pressing two keys combined

        Vector3 moveDir = new Vector3(inputVector.x, 0f, inputVector.y); // translate 2D movment keys into X and Z axis in the game
        transform.position += moveDir * movementSpeed * Time.deltaTime; // delta time allows to make movement independent of framerate

    }
}
