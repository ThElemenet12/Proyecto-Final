﻿using Assets.Scripts.Class;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlJuego : MonoBehaviour
{
    public GameObject player;
    public enum NivelActual
    {
        Nivel0,
        Nivel1,
        Nivel2,
        Nivel3,
        BossFinal
    }
   
    public enum GameState
    {
        LevelSelect,
        Playing,
        LevelPass
    }

    public static List<Items> Inventario = new List<Items> { new Items("Armadura", 1), new Items("Pocion", 2), new Items("Lagrima", 1), new Items("Amuleto", 1) };


    public static int money;
    public static GameState state;
    public static NivelActual Nivel;
    public static int NivelesLogrados = 4, level = 1;
    bool Pass = true;
    
    float playerLife;

    // Start is called before the first frame update
    void Start()
    {
        //player = GameObject.FindGameObjectWithTag("Player");
        //Nivel = NivelActual.Nivel1;
        if(SceneManager.GetActiveScene().name == "MapaPrincipal")
        {
            state = GameState.LevelSelect;
        }       
    }

    // Update is called once per frame
    void Update()
    {
        switch (state)
        {
           
            case GameState.LevelSelect:
                switch (Nivel)
                {
                    case NivelActual.Nivel1:
                        state = GameState.Playing;
                        level = 1;
                        if (!Pass)
                        {
                            Pass = true;   
                            SceneManager.LoadScene("Intro");
                        }
                        else
                        {
                            SceneManager.LoadScene("Principal");
                        }
                        ///Dificultad
                        break;
                    case NivelActual.Nivel2:
                        level = 2;
                        state = GameState.Playing;
                        SceneManager.LoadScene("Principal");
                        ///Dificultad
                        break;
                    case NivelActual.Nivel3:
                        level = 3;
                        state = GameState.Playing;
                        SceneManager.LoadScene("Principal");
                        ///Dificultad
                        break;
                    case NivelActual.BossFinal:
                        level = 4;
                        state = GameState.Playing;
                        SceneManager.LoadScene("Principal");
                        ///Dificultad
                        break;
                    default:
                        break;
                }
                break;
            case GameState.Playing:
                if (player.GetComponent<CharacterMovement>().Vida <= 0)
                {
                    state = GameState.LevelSelect;
                    Nivel = NivelActual.Nivel0;
                    SceneManager.LoadScene("MapaPrincipal");
                }
                break;
            case GameState.LevelPass:
                NivelesLogrados++;
                state = GameState.LevelSelect;
                SceneManager.LoadScene("MapaPrincipal");
                break;
        }
                    
           

    }
    
}
