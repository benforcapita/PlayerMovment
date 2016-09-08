using UnityEngine;
using System.Collections;

public class PowerUpFlower : Collecteble
{
    public int itemID = 1;
    public GameObject projectilePrefab;


    protected override void OnCollect(GameObject target)
    {
        var epuiptBehavior = target.GetComponent<EquipBehavior>();
        if(epuiptBehavior != null)
        {
            epuiptBehavior.CurrentItemID = this.itemID;
        }
        var firrprojectile = target.GetComponent<FireProjectile>();
        if (firrprojectile != null)
        {
            firrprojectile.ProjectilePrefab = this.projectilePrefab;
        }


    }
    


}
