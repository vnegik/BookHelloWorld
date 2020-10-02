﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner3 : MonoBehaviour
{
    public GameObject  cubePrefabVar;
    public List<GameObject> gameObjectList; // Будет хранить все кубики
    public float    scalingFactor = 0.95f;
    // ^ Коэффициент изменения масштаба каждого кубика в каждом кадре
    public int      numCubes = 0; // Общее количество кубиков

   // Используйте этот метод для инициализации
    void Start()
    {
        // Инициализация списка List<GameObject>
        gameObjectList = new List<GameObject>();
    }
    // Update вызывается в каждом кадре
    void Update()
    {
        numCubes++; // Увеличить количество кубиков // a
    }

    GameObject gObj = Instantiate<GameObject>(cubePrefabVar); // b

    // Следующие строки устанавливают некоторые значения в новом кубике
    gObj.name = "Cube "+numCubes; // c
    Color c = new Color(Random.value, Random.value, Random.value); // d
    gObj.GetComponent<Renderer>().material.color = c;
    // ^ Получить компонент Renderer из gObj и назначить случайный цвет
    gObj.transform.position = Random.insideUnitSphere; // e

    gameObjectList.Add(gObj); // Добавить gObj в список кубиков

    List<GameObject> removeList = new List<GameObject>(); // f
    // ^ Список removeList будет хранить кубики, подлежащие
    // удалению из списка gameObjectList

    // Обход кубиков в gameObjectList
    foreach (GameObject goTemp in gameObjectList) {   // g
    
  
    // Получить масштаб кубика
        float scale = goTemp.transform.localScale.x;  // h

        scale *= scalingFactor; // Умножить на коэффициент scalingFactor
        goTemp.transform.localScale = Vector3.one* scale;
        if (scale <= 0.1f) { // Если масштаб меньше 0.1f...     // i
      
        removeList.Add(goTemp); // ...добавить кубик в removeList
        }
    }
    foreach (GameObject goTemp in removeList) {     // g

    gameObjectList.Remove(goTemp);   // j
    // ^ Удалить кубик из gameObjectList
    Destroy(goTemp); // Удалить игровой объект кубика
    }


    }
    }
