using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class CambiarEscena : MonoBehaviour, IPointerClickHandler {

    public Escenas cargarEscena;

    public void OnPointerClick(PointerEventData eventData)
    {
        PantallaDeCarga.Instancia.CargarEscena(cargarEscena.ToString());
    }

}

public enum Escenas
{
    Escena1,
    Escena2
}
