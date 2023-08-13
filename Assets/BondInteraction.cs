using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BondInteraction : MonoBehaviour
{
    public GameObject element1, element2;
    public ARInteraction elementData;
    public float distance;
    public GameObject bond;

    void Update()
    {
        if(CheckDistance())
        {
            bond.SetActive(true);
            bond.transform.position = Vector3.Lerp(bond.transform.position, (element1.transform.position + element2.transform.position) / 2, 0.2f);
            element1.SetActive(false);
            element2.SetActive(false);
        }
        else
        {
            bond.SetActive(false);
            element1.SetActive(true);
            element2.SetActive(true);
        }
    }

    bool CheckDistance()
    {
        if (elementData.moleculeActive[element1.name] && elementData.moleculeActive[element2.name])
        {
            if(Vector3.Distance(element1.transform.position, element2.transform.position) < distance)
            {
                return true;
            }
        }
        return false;
    }
}
