﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumeroMagico : MonoBehaviour
{
    int max, min, adivinado;
    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        max = 1000;
        min = 1;
        adivinado = 500;
        Debug.Log("Bienvenido al juego número máginco");
        Debug.Log("Por favor piense en un número, no me lo diga...");
        Debug.Log("El valor mínimo del número debe ser " + min);
        Debug.Log("El valor máximo del número debe ser " + max);
        Debug.Log($"Ahora dígame , ¿Es {adivinado} el número es correcto, o es mayor o menor?");
        Debug.Log("Arriba = Mayor, Abajo = Menor, ENTER = Correcto");
        max++;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown((KeyCode.UpArrow)))
        {
            min = adivinado;
            NextGuess();
        }
        else if (Input.GetKeyDown((KeyCode.DownArrow)))
        {
            max = adivinado;
            NextGuess();
        }
        else if (Input.GetKeyDown((KeyCode.Return)))
        {
            Debug.Log($"Genial ¡Usted pensó el número {adivinado}!");
      
        }
    }

    void NextGuess()
    {
        adivinado = (int)Mathf.Floor((max + min) / 2);
        Debug.Log($"Entonces, Es {adivinado}​​​​ el número es correcto, o es mayor o menor");
        Debug.Log("Arriba = Mayor, Abajo = Menor, ENTER = Correcto");
        //Esto es un comentario de prueba que pasa calabaza
        //esto para probar el desktop


    }
}
