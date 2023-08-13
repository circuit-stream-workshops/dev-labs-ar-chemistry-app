using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ARInteraction : MonoBehaviour
{

    public Dictionary<string, bool> moleculeActive = new Dictionary<string, bool>();

    public void ActivateMolecule(string name)
    {
        moleculeActive[name] = true;
    }

    public void DeactivateMolecule(string name)
    {
        moleculeActive[name] = false;
    }

    private void Start()
    {
        moleculeActive.Add("H", false);
        moleculeActive.Add("O", false);
    }

}
