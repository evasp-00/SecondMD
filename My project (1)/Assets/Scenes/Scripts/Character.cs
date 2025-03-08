using UnityEngine;

public class Character : MonoBehaviour
{
    public int health = 5;

    public void Reporthealth()
    { 
        Debug.Log(name+ " health " + health);
    }
}
