﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuTiendaControl : MonoBehaviour
{
    public int cost;
    public TextMesh costTxt; 
    TextMesh info;
    GameObject PanelCompra;
    // Start is called before the first frame update

    private void Awake()
    {
        PanelCompra = GameObject.FindGameObjectWithTag("PanelCompra");
        info = GameObject.Find("Info").GetComponent<TextMesh>();
    }
    void Start()
    {
        PanelCompra.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnMouseDown()
    {
        if (gameObject.name == "Armadura")
        {
            PanelCompra.SetActive(true);
            PanelCompra.transform.GetChild(6).GetComponent<SpriteRenderer>().sprite = gameObject.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite;
            info.text = "Incrementa la armadura base en +5.\n Se compra una vez";

        }
        else if (gameObject.name == "Pocion")
        {
            PanelCompra.SetActive(true);
            PanelCompra.transform.GetChild(6).GetComponent<SpriteRenderer>().sprite = gameObject.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite;
            info.text = "Restaura un 10% de la vida actual.\n Solo se puede llevar un maximo de 3";

        }
        else if (gameObject.name == "Lagrima")
        {
            PanelCompra.SetActive(true);
            PanelCompra.transform.GetChild(6).GetComponent<SpriteRenderer>().sprite = gameObject.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite;
            info.text = "Lagrima misteriosa. Sus beneficios son desconocidos.\n Dicen que proviene de una Diosa.\n Se compra una vez";
        }
        else if (gameObject.name == "Amuleto")
        {
            PanelCompra.SetActive(true);
            PanelCompra.transform.GetChild(6).GetComponent<SpriteRenderer>().sprite = gameObject.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite;
            info.text = "Increible amuleto, permite manejar el elemento fuego.\n Se compra una vez";

        }
        else
        {
            SceneManager.LoadScene("MapaPrincipal");
        }
        costTxt.text = cost.ToString();
    }
    private void OnMouseOver()
    {
        

    }
    private void OnMouseExit()
    {
        
    }
}
