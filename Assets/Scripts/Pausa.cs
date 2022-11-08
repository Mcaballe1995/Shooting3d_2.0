using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pausa : MonoBehaviour
{
    private GameObject panelPausa;


    private int estadoPausa;
    private int estadoPanelPausa;

    private void Awake()
    {
        estadoPausa = 0;
        panelPausa = (GameObject)GameObject.FindGameObjectWithTag("PanelPausa");


        estadoPanelPausa = 0;

        if (panelPausa != null)
        {
            panelPausa.SetActive(false);
        }

    }

    public void MostrarPanelPausa(int estado)
    {
        if (!panelPausa.activeSelf)
        {
            Time.timeScale = 0;
            panelPausa.SetActive(true);
        }

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            MostrarPanelPausa(estadoPanelPausa);
        }
    }

    public void CerrarPanelPausa()
    {
        panelPausa.SetActive(false);
        Time.timeScale = 1;
    }

    public void SalirJuego()
    {
            SceneManager.LoadScene("Menu");
    }
}
