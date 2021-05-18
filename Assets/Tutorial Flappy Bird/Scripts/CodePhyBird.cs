using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodePhyBird : Bird
{
    new void Start()
    {
        // �θ��Լ��� Startȣ��
        base.Start();

        // �ڵ�� ���ְų� �ν����͸� �����ϰų�
        rigidbody2D.bodyType = RigidbodyType2D.Kinematic;
        rigidbody2D.useFullKinematicContacts = true;
    }

    public float acceleration;
    public float addForce = 1f;
    
    void Update()
    {
        if (Time.timeScale == 0)
            return;

        //���ӵ� acceleration
        acceleration += gravity * Time.deltaTime;
        transform.Translate(0, acceleration, 0);
        

        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
        {
            if (Time.time > 0.7f) // ���� �����ϰ� 0.7�� ���� Ŭ���� ����, ���� ������ ������ Ŭ���̺�Ʈ�� ����Ǵ°��� ����
            {
                acceleration = addForce;
                animator.Play("Flap", 0, 0);
            }
        }
    }
}
