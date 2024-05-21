using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour {

    public GameObject creditsPanel;
    public GameObject MainMenuPanel;

    /* Anatom�a de una funci�n en C#
     acceso retorno nombre (par�metros) {
        cuerpo;
        (si regresa algo) return dato;
     }

     acceso: public | private | protected
        public: que puede ser usado y accesado por quine sea, donde sea
        private: s�lo puede ser usado dentro de la clase
        protected: s�lo puede ser usado dentro de la clase, y las clases heredadas (herencia)

     retorno: void | tipo primitivo | tipo abstracto
        void: la funci�n no regresa datos
        tipo rpimitivo: son tipos de datos que ya est�n en el lenguaje (int, float, char, string)
        tipo abstracto: son tipos que definimos cada que se crea una clase

     nombre: nombre que recibe la funci�n en camel case (cambioDeEscena, miMamaMeMima, esOsoSeAseaAs�)
        Se recomienda que sea muy autodescriptivo (autodocumentado)
     
     par�metros: datos que recibe la funci�n, y que van a ser usados dentro de ella (nada | tipo primitivo | tipo abstracto)

     cuerpo: es todo lo que hace la funci�n (procurar que sean menos de 20 l�neas ded cuerpo)
     
     return: si la funci�n regresa void, no es necesario dar un dato como retorno, en caso contrario
        se debe regresar un dato del tipo que hayamos indicado en el retorno
     */

    public void sceneChange (string nextScene) {
        SceneManager.LoadScene(nextScene);
    }

    public void showCredits () {
        creditsPanel.SetActive(true);
        MainMenuPanel.SetActive(false);

    }

    public void returnToMenu() {
        MainMenuPanel.SetActive(true);
        creditsPanel.SetActive(false);

    }
}
