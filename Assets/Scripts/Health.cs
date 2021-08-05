using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int Max_Health = 3;
    public int Current_Health;
    //public Animator anim;

    void Start()
    {
        Current_Health = Max_Health;
    }

    // Update is called once per frame
    void Take_Damage(int amount)
    {
        Current_Health -= amount;
      //  if(Current_Health <= 0)
      //  {
      //      //We're dead
      //      //Play Death animation
      //      //Show GameOver Screen
      //      anim.Setbool("IsDead", true);
      //  }
    }
}
