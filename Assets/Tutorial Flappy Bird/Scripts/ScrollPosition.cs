using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollPosition : MonoBehaviour
{
    static public List<ScrollPosition> Items = new List<ScrollPosition>();

    private void Awake()
    {
        //Debug.Log(name + "������");
        Items.Add(this);
    }

    private void Start()
    {
        speed *= GameManager.instance.scrollSpeedMultiply;
    }

    private void OnDestroy()
    {
        //Debug.Log(name + "������");
        Items.Remove(this);
    }


    public float speed = -1f; // 1�ʿ� ��ĭ �������� �̵�.

    void Update()
    {
        // ��ũ�� ���� �̵�.
        transform.Translate(speed * Time.deltaTime, 0, 0);
    }
}
