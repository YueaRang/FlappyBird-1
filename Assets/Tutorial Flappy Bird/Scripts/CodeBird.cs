using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodeBird : Bird
{
    // Start is called before the first frame update
    new private void Start()
    {
        base.Start();

        rigidbody2D.bodyType = RigidbodyType2D.Kinematic;
        rigidbody2D.useFullKinematicContacts = true;
    }

    public float gravity = -9.8f;
    public float acceleration;
    // Update is called once per frame
    void Update()
    {
        acceleration += gravity * Time.deltaTime;
        //중력에 의한 낙하 구현
        // 중력
        // 중력 가속도


        // y값 변경
        transform.Translate(0, acceleration, 0);

        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            if (Time.time > 0.7f)
            {
                acceleration = forceY;


                //날개 펄럭이는 애니메이션 하자.
                animator.Play("Flap", 0, 0);
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        OnDie(collision);

        rigidbody2D.bodyType = RigidbodyType2D.Dynamic;
        enabled = false;
        GameManager.instace.scrollSpeedXMultiply = 0;


    }


}
