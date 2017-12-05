using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class criaçãoPersonagem : MonoBehaviour
{
    public Button confirmarEscolha;
    public InputField nomeDigitado; 
    string nomePersonagem;   
    public GameObject panelCriacao;
    public string[] sobrenomes;
    public Text phrasesText;
    public GameObject cursorLoja;
    public float cursorPosition;

    public bool isShopping;
    public int indexItem;


    void Start ()
    {
        //DontDestroyOnLoad(this);
        confirmarEscolha.onClick.AddListener(ProcessText);
        panelCriacao.GetComponent<Image>().enabled = true;
        cursorPosition = 0.389f;
        indexItem = 0;

    }
    void FixedUpdate()
    {
        foreach (string index in sobrenomes)
        {
            phrasesText.text += index + "\n";
        }


        if (Input.GetKeyDown(KeyCode.UpArrow) && isShopping == true)
        {

            if (indexItem <= 0)
            {
                indexItem = sobrenomes.Length - 1;
                
                cursorLoja.GetComponent<RectTransform>().localPosition = new Vector3(-3.5f, cursorPosition - 20, 0); ;
            }
            else
            {
                indexItem--;
                
                cursorLoja.GetComponent<RectTransform>().localPosition = new Vector3(-3.5f, cursorPosition, 0);
            }
        }

        //index == 0 = 0.432f
        //index == 1 = -0.087f
        //index == 2 = -0.53f
        if (Input.GetKeyDown(KeyCode.DownArrow) && isShopping == true)
        {

            if (indexItem == sobrenomes.Length)
            {
                
                cursorPosition = -0.087f;
                cursorLoja.GetComponent<RectTransform>().localPosition = new Vector3(-3.5f, cursorPosition, 0);
                indexItem++;

            }
            //---------
            if (indexItem == 1)
            {
                
                cursorPosition = -0.53f;
                cursorLoja.GetComponent<RectTransform>().localPosition = new Vector3(-3.5f, cursorPosition, 0);
                indexItem++;

            }
            if (indexItem == 2)
            {
                
                cursorPosition = 0.432f;
                cursorLoja.GetComponent<RectTransform>().localPosition = new Vector3(-3.5f, cursorPosition, 0);
                indexItem = 0;
            }
            //-----------------
            else
            {
                indexItem++;
                cursorPosition = -0.087f;
                cursorLoja.GetComponent<RectTransform>().localPosition = new Vector3(-3.5f, cursorPosition, 0);

            }
        }

        

    }

    public void ProcessText()
    {
        
        nomePersonagem = nomeDigitado.text;
        Debug.Log("Meu Nome é : " + nomePersonagem);
        confirmarEscolha.enabled = false;
        nomeDigitado.enabled = false;
        panelCriacao.GetComponent<Image>().enabled = false;

		if (indexItem == 0) 
		{
			Debug.Log("sobrenome : souza : ");
		}
		if (indexItem == 1) 
		{
			Debug.Log("sobrenome : paiva : ");
		}
		if (indexItem == 2) 
		{
			Debug.Log("sobrenome : machado : ");
		}


        
    }
    public void MENU_ACTION_GotoPage(string scenename)
    {
        Application.LoadLevel(scenename);
    }

    void Update ()
    {	
	}
}
