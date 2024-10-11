using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class P2_ManagerConversation : MonoBehaviour
{
    [System.Serializable]
    public struct Dialogo{
        public string name;
        public string texto;
        public Sprite imagen;


    }

    public List<Dialogo> charla;

    [SerializeField] TextMeshProUGUI txt_mensaje;
    [SerializeField] TextMeshProUGUI txt_nombre;
    [SerializeField] Image imagen;

    int contador;
    void mostrarDialogo(){
        txt_mensaje.text = charla[contador].texto;
        txt_nombre.text = charla[contador].name;
        imagen.sprite = charla[contador].imagen;
    }

    void Start()
    {
        contador = 0;
        mostrarDialogo();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.C)){
            contador++;
            contador %=charla.Count;
            mostrarDialogo();

        }
        
    }
}
