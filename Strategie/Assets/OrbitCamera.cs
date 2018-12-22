using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitCamera : MonoBehaviour {

    public Transform target; //Переменная хранит ссылку на объект, вокруг производиться облет
    public float rotSpeed = 1.5f;
    private float _rotY;
    private Vector3 _offset;
    // Use this for initialization
    void Start()
    {
        _rotY = transform.eulerAngles.y;
        _offset = target.position - transform.position; //сохранние начального смещения между камерой и целью
    }
    private void LateUpdate()
    {
        float horInput = Input.GetAxis("Horizontal");
        if (horInput != 0)//медленный поворот камеры при помощи клавиш со стрелками
        {
            _rotY += horInput * rotSpeed;
        }
        else
        {
            _rotY += Input.GetAxis("Mouse X") * rotSpeed * 3;//или быстрый поворот с помощью мыши
        }
        Quaternion rotation = Quaternion.Euler(0, _rotY, 0);
        transform.position = target.position - (rotation * _offset);//поддерживаем начальное, сдвигаемое в соответствии с поворотом камеры.
        transform.LookAt(target); //камера всегда направлена на цель, где бы относительно этой цели она ни располагалась
    }
}
