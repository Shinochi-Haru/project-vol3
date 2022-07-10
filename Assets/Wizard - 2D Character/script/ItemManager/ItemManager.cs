using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ItemManager: MonoBehaviour
{
    /// <summary>
    /// �A�C�e���̌���
    /// </summary>
    public abstract void Activate();

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            Activate();
            Destroy(this.gameObject);
        }
    }
}
