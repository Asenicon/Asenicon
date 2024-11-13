using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AnketaScript : MonoBehaviour
{
    public TMP_InputField nameInputField;
    public TMP_Text nameTmpText;

    public void OnButtonUserName()
    {
        nameTmpText.text = nameInputField.text;
    }
      public TMP_InputField ageInputField;
      public TMP_Text ageTmpText;
      
    // public void OnButtonUserAge()
    // {
    //     string ageString = ageInputField.text;
    //     int ageInt = int.Parse(ageString);
    // }                                                                                                                                                                               
}