using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtackDirection : MonoBehaviour {

    public static Vector2 direction;

    public void Updirection ()
    {
        direction.Set(0, 1);
        Debug.Log(direction);
    }

    public void Downdirection()
    {
        direction.Set(0, -1);
        Debug.Log(direction);
    }
    public void Ldirection()
    {
        direction.Set(-1, 0);
        Debug.Log(direction);
    }
    public void Rpdirection()
    {
        direction.Set(1, 0);
        Debug.Log(direction);
    }

}
