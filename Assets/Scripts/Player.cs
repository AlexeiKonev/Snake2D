 
using UnityEngine;

public class Player : Snake,IDirection,IMoving
{
     
    private Rigidbody2D _rbSnake;

    private void Awake()
    {
         
        _rbSnake = GetComponent<Rigidbody2D>();
        
    }

    private void Update()
    {
        ChangeDir();
        Move();
    }

    public void Move()
    {

        transform.Translate(this._direction * this.moveSpeed * Time.deltaTime);

    }

    public void ChangeDir()
    {
        if (Input.GetAxis("Horizontal") > 0)
        {  _direction = Vector2.right; }
        else if (Input.GetAxis("Horizontal") < 0)
        {  _direction = Vector2.left; }

        if (Input.GetAxis("Vertical") > 0)
        {  _direction = Vector2.up; }
        else if (Input.GetAxis("Vertical") < 0)
        {  _direction = Vector2.down; }
    }
}
