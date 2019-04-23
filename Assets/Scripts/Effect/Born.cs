﻿using UnityEngine;

public class Born : MonoBehaviour
{
    public bool isPlayer1 = true;


    /// <summary>
    /// 延时加载
    /// 延时销毁
    /// </summary>
    private void Start()
    {
        Invoke("BornTank", 1f);
        Destroy(gameObject, 1f);
    }

    /// <summary>
    /// 玩家坦克出生
    /// </summary>
    private void BornTank()
    {
        var player = Resources.Load<GameObject>(isPlayer1 ? GameConst.Player1Prefab : GameConst.Player2Prefab);
        Instantiate(player, transform.position, Quaternion.identity);
        // 魔法盾标识
        player.transform.Find("Shield").GetComponent<Renderer>().enabled = true;
    }
}