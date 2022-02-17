using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{

    [SerializeField] Text txtTanks;
    [SerializeField] Text txtPlanes;
    [SerializeField] Text txtBases;
    [SerializeField] Text txtHospitals;
    [SerializeField] Text txtPersonnel;

    int tanks = 0;
    int planes = 0;
    int bases = 0;
    int hospitals = 0;
    int personnel = 0;

    // Start is called before the first frame update
    public void BuyTank()
    {
        PerformTransaction(5000000f, tanks);
        Debug.Log(tanks);
    }

    public void BuyPlane()
    {
        PerformTransaction(12000000f, planes);
        Debug.Log(planes);
    }

    public void BuyBase()
    {
        PerformTransaction(3500000f, bases);
        Debug.Log(bases);
    }

    public void BuyHospital()
    {
        PerformTransaction(5000000f, hospitals);
        Debug.Log(hospitals);
    }

    public void Recruit()
    {
        PerformTransaction(45000f, personnel);
        Debug.Log(personnel);
    }

    // Update is called once per frame
    void Update()
    {
        UpdateLabels();
    }

    void UpdateLabels()
    {
        txtTanks.text = tanks.ToString();
        txtPlanes.text = planes.ToString();
        txtBases.text = bases.ToString();
        txtHospitals.text = hospitals.ToString();
        txtPersonnel.text = personnel.ToString();
    }

    void PerformTransaction(float value, int item)
    {
        if(!(MinningButtons._balance < value))
        {
            MinningButtons._balance -= value;
            item += 1;
        }
    }
}

