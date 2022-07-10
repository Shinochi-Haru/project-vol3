using ClearSky;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUpItem : ItemManager
{
    /// <summary>/// ���鑬�x���オ��/// </summary>
    [SerializeField] int _speedup = 10;

    public override void Activate()
    {
        FindObjectOfType<SimplePlayerController>().AddSpeed(_speedup);
    }
}
