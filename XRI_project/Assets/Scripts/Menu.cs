using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    //Get Accessor (Reading)
    //Set Accessor (Writing)
    //

    [SerializeField]
    public Button ResumeButton { get; set; }

    [SerializeField]
    public Button RestartButton { get; set; }

    [SerializeField]
    public TextMeshProUGUI SolvedText {  get; set; }



}
