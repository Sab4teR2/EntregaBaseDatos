using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Librerías añadidas
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    //declaramos nuestro codigo con la funcion ola para poder acceder a el
    //Declaramos tambien el texto de nuestros puntos en nuestro caso clicks y el nombre de la persona que juega
    public GuardadoJsonEncript ola;
    public Text puntosTXT;
    public Text nombreTXT;
    public GameObject rankingGO;
    int puntosDB;

    public void Update()
    {
        
    }

    //Guardamos los puntos de la data base en nuestro caso clicks, cambiamos el texto de puntos a nuestros clicks y lo enviamos al string
    //Entramos en el ranking de ranking manager e insertamos los punto mostrados antes
    public void GuardarPuntosDB()
    {
        puntosDB = (int)ola.clicks;
        puntosTXT.text = ola.clicks.ToString();

        rankingGO.GetComponent<RankingManager>().InsertarPuntos(nombreTXT.text, puntosDB);
    }
}
