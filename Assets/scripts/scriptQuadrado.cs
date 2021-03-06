﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptQuadrado : MonoBehaviour {

	public string[] quadradoVetor = new string[6];
    //public string[] quadradoVetorCompara = new string[6];

    public bool preenchido = false;
    public int contador = 0;
    public float opacidade = 1.0f;

    public KeyCode btnZ;
    public KeyCode btnX;
    public KeyCode btnC;
    public KeyCode btnA;
    public KeyCode btnS;
    public KeyCode btnD;

    /*public bool AlphaQuadadroZ = true;
    public bool AlphaQuadadroX = true;
    public bool AlphaQuadadroC = true;
    public bool AlphaQuadadroA = true;
    public bool AlphaQuadadroS = true;
    public bool AlphaQuadadroD = true;*/

    public float AlphaQuadadroZ = 1;
    public float AlphaQuadadroX = 1;
    public float AlphaQuadadroC = 1;
    public float AlphaQuadadroA = 1;
    public float AlphaQuadadroS = 1;
    public float AlphaQuadadroD = 1;


    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {

        //GetComponent<SpriteRenderer>().color = new Color(opacidade, opacidade, opacidade);


        if(contador > 5)
        {
            preenchido = true;
            // seta o contador para a posição máxima do vetor para conseguir voltar
            contador = 5;
        }
        if (contador == -1)
        {
            preenchido = false;
            // seta o contador para a posição mínima do vetor para conseguir incrementar
            contador = 0;
        }


        // INÍCIO - inclui os dados no vetor
        if (preenchido == false)
        {

            if (Input.GetKeyDown(btnZ))
            {
                quadradoVetor[contador] = "Marrom";
                if (contador < 6)
                {
                    contador = contador + 1;
                    AlphaQuadadroZ = 0;
                }

            }

            if (Input.GetKeyDown(btnX))
            {
                quadradoVetor[contador] = "Rosa";
                if (contador < 6)
                {
                    contador = contador + 1;
                    AlphaQuadadroX = 0;
                }
            }

            if (Input.GetKeyDown(btnC))
            {
                quadradoVetor[contador] = "Amarelo";
                if (contador < 6)
                {
                    contador = contador + 1;
                    AlphaQuadadroC = 0;
                }
            }

            if (Input.GetKeyDown(btnA))
            {
                quadradoVetor[contador] = "Laranja";
                if (contador < 6)
                {
                    contador = contador + 1;
                    AlphaQuadadroA = 0;
                }
            }

            if (Input.GetKeyDown(btnS))
            {
                quadradoVetor[contador] = "Verde";
                if (contador < 6)
                {
                    contador = contador + 1;
                    AlphaQuadadroS = 0;
                }
            }

            if (Input.GetKeyDown(btnD))
            {
                quadradoVetor[contador] = "Roxo";
                if (contador < 6)
                {
                    contador = contador + 1;
                    AlphaQuadadroD = 0;
                }
            }
        }
        // FIM - inclui os dados no vetor



        // INÍCIO - deleta os dados no vetor
        if (preenchido == true)
        {

            if (Input.GetKeyDown(btnZ))
            {
                if(quadradoVetor[contador] == "Marrom")
                {
                quadradoVetor[contador] = "";
                if (contador > -1)
                    {
                        contador = contador - 1;
                        AlphaQuadadroZ = 1;
                    }

                }

            }

            if (Input.GetKeyDown(btnX))
            {
                if (quadradoVetor[contador] == "Rosa")
                {
                    quadradoVetor[contador] = "";
                if (contador > -1)
                    {
                        contador = contador - 1;
                        AlphaQuadadroX = 1;
                    }
                }

            }

            if (Input.GetKeyDown(btnC))
            {
                if (quadradoVetor[contador] == "Amarelo")
                {
                    quadradoVetor[contador] = "";
                if (contador > -1)
                    {
                        contador = contador - 1;
                        AlphaQuadadroC = 1;
                    }
                }

            }

            if (Input.GetKeyDown(btnA))
            {
                if (quadradoVetor[contador] == "Laranja")
                {
                    quadradoVetor[contador] = "";
                if (contador > -1)
                    {
                        contador = contador - 1;
                        AlphaQuadadroA = 1;
                    }
                }

            }

            if (Input.GetKeyDown(btnS))
            {
                if (quadradoVetor[contador] == "Verde")
                {
                    quadradoVetor[contador] = "";
                if (contador > -1)
                    {
                        contador = contador - 1;
                        AlphaQuadadroS = 1;
                    }
                }

            }

            if (Input.GetKeyDown(btnD))
            {
                if (quadradoVetor[contador] == "Roxo")
                {
                    quadradoVetor[contador] = "";
                if (contador > -1)
                    {
                        contador = contador - 1;
                        AlphaQuadadroD = 1;
                    }
                }

            }
        }
        // FIM - deleta os dados no vetor


    }
}
