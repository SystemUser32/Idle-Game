using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MinningButtons : MonoBehaviour
{

    [SerializeField] Text balance;
    [SerializeField] Text production;
    [SerializeField] Text upgradeCost;

    public static float _balance = 0;
    float _production = 1000f;
    float _upgradeCost = 1000f;

    // Start is called before the first frame update
    public void Produce()
    {
        _balance += _production;
    }

    public void UpgradeCost()
    {
        if(!(_balance < _upgradeCost))
        {
            _balance -= _upgradeCost;
            _production *= 1.5f;
            _upgradeCost *= 1.8f;
        }
    }

    // Update is called once per frame
    void Update()
    {
        UpdateLabels();
    }

    void UpdateLabels()
    {
        balance.text = _balance.ToString();
        production.text = _production.ToString();
        upgradeCost.text = _upgradeCost.ToString();
    }
}
