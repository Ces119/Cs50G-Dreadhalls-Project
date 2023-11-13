using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


// Assignment 9 Add a Text //
public class MazeNumber : MonoBehaviour{

    public Text Maze;
    public static int number = 1;
    
    void Start()
    {

    }

    void Update()
    {
        Maze.text = "Maze No: " + number.ToString();
    }
}