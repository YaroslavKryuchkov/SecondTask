using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[RequireComponent(typeof(TextMeshProUGUI))]
public class ShowCent : MonoBehaviour
{
    private int _cents;
    private TextMeshProUGUI _text;

    private void Awake()
    {
        _text = gameObject.GetComponent<TextMeshProUGUI>();
    }

    private void OnEnable()
    {
        GrabCent.OnGrab += ChangeCents;
    }

    private void OnDisable()
    {
        GrabCent.OnGrab -= ChangeCents;
    }

    private void ChangeCents(int cents)
    {
        _cents += cents;

        _text.text = "You have " + _cents.ToString() + " cent" + (_cents > 1 ? "s" : "");
    }
}
