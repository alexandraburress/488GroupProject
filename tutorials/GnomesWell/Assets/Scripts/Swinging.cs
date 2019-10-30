using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swinging : MonoBehaviour
{
    public float swingSensitivity = 100.0f;

    //use fixed update isntead of update, in order to play
    //better with the physics engine
    private void FixedUpdate()
    {
        //If we have no ridigbody (anymore), remoce this component
        if (GetComponent<Rigidbody2D>() == null)
        {
            Destroy(this);
            return;
        }

        //Get the tilt amount form the InputManager
        float swing = InputManager.instance.sidewaysMotion;

        //calculate a force to apply 
        Vector2 force =
            new Vector2(swing * swingSensitivity, 0);

        //apply the force
        GetComponent<Rigidbody2D>().AddForce(force);
    }
}
