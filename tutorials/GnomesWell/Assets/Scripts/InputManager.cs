using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : Singleton<InputManager>
{
    //How much we're moving. -1.0 = full left, +1.0 = full right
    private float _sidewaysMotion = 0.0f;
    
    //this property if declared as read-only, so that toher classes can't change it.
    public float sidewaysMotion
    {
        get
        {
            return _sidewaysMotion;
        }
    }

    //every frame, store the tilt
    private void Update()
    {
        Vector3 accel = Input.acceleration;

        _sidewaysMotion = accel.x;
    }

}
