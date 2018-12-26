using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour {

    [SerializeField] private MemoryCard originalCard;//ссылка для карты в сцене
    [SerializeField] private Sprite[] images;//массив ссылок на ресурсы-спрайты

    public const int gridRows = 2;//значения, количество ячеей в сетки и их расстояние друг от друга
    public const int gridCols = 4;
    public const float offsetX = 2f;
    public const float offsetY = 2.5f;

    void Start()
    {
        Vector3 startPos = originalCard.transform.position;//Положение первой карты, остальные от этой точки




        int id = Random.Range(0, images.Length);
        originalCard.SetCard(id, images[id]);//вызов открытого метода в MemoryCard
    }

    // Update is called once per frame
    void Update () {
		
	}
}
