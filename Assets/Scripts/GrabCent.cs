using System;
using UnityEngine;

public class GrabCent : MonoBehaviour
{
    public static event Action<int> OnGrab;
    [SerializeField] private int _cents = 0;

    void OnMouseOver()
    {
        OnGrab?.Invoke(_cents);
        Destroy(gameObject);
    }
}
