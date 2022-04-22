using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy :  Snake,IMoving
{
    public void Move()
    {
        transform.Translate(this._direction * this.moveSpeed * Time.deltaTime);
    }

    private void Update()
    {
       
    }
    
}
