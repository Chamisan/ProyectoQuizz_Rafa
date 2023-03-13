using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RandomSelection : MonoBehaviour
{
    private int numberQuestions = 7;
    public int i = 0;
    public int countQuestions = 0;
    public List<int> numberRandom;
    public GameObject[] questions;
    public GameObject canvasInicio;
    public GameObject canvasFinal;
    public TextMeshProUGUI textoPuntos;
    private int points = 0;


    void Start()
    {
        while (i != numberQuestions -1)
        {
            int temp = Random.Range(0, numberQuestions - 1);
            if (!numberRandom.Contains(temp))
            {
                numberRandom.Add(temp);
                i++;
            }   
        }
        canvasInicio.SetActive(true);
    }
    
    public void ActiveQuestion()
    {
            questions[numberRandom[0]].SetActive(false);
            questions[numberRandom[1]].SetActive(false);
            questions[numberRandom[2]].SetActive(false);
            questions[numberRandom[3]].SetActive(false);
            questions[numberRandom[4]].SetActive(false);
            questions[numberRandom[4]].SetActive(false);

        if (countQuestions != i-1)
            {
                
                questions[numberRandom[countQuestions]].SetActive(true);
                countQuestions++;
            }
            else
            {
                questions[numberRandom[countQuestions]].SetActive(false);
                canvasFinal.SetActive(true);
                textoPuntos.text = points.ToString();
            }
            
    }

    public void CorrectOption(Button _boton)
    {
        StartCoroutine(CorrectOptionCoroutine(_boton));
    }

    public void IncorrectOption(Button _boton)
    {
        StartCoroutine(IncorrectOptionCoroutine(_boton));
    }

    public IEnumerator CorrectOptionCoroutine(Button _boton)
    {
        _boton.image.color = Color.green;
        yield return new WaitForSeconds(1);
        points += 20;
        ActiveQuestion();
    }
    public IEnumerator IncorrectOptionCoroutine(Button _boton)
    {
        _boton.image.color = Color.red;
        yield return new WaitForSeconds(1);
        ActiveQuestion();
    }

}
