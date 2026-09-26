using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class UpgradeHolder : MonoBehaviour
{
    List<Upgrade> upgrades = new List<Upgrade>();

    public void AddUpgrade(Upgrade upgrade)
    {
        upgrades.Add(upgrade);
    }


}
