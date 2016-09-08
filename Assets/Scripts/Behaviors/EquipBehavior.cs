
using UnityEngine;
using System.Collections;

public class EquipBehavior : AbstractBehavior {
    private int _currentItemId = 0;
    private Animator anim;

    public int CurrentItemID { get { return _currentItemId; } set { _currentItemId = value; anim.SetInteger("EquippedItem", _currentItemId); } }

    protected override void Awake()
    {
        base.Awake();
        anim = GetComponent<Animator>();
    }
   
}
