using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;

public class Cell : MonoBehaviour {
    public GameObject Label;
    public GameObject Input;

    private GameController _gameController;    

    void Start () {
        _gameController = GameObject.FindGameObjectWithTag(Tags.GameController)
            .GetComponent<GameController>();
    }

    void Update () {
        Label.SetActive(!_gameController.IsEvaluating());
        Input.SetActive(_gameController.IsEvaluating());
    }

    public void SetText (string text) {
        Label.GetComponent<Text>().text = text;
        // Input.GetComponent<InputField>().text = text;
    }

    public bool Calificar () {
        return Math.Round(float.Parse(Input.GetComponent<InputField>().text),1) ==
            Math.Round(float.Parse(Label.GetComponent<Text>().text),1); // TODO
    }
}
