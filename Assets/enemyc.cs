﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyc : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        gameObject.transform.position += new Vector3(0, -0.01f, 0);
    }
    void OnTriggerEnter2D(Collider2D col) //名為col的觸發事件
    {
        if (col.tag == " ship" || col.tag == "Bullet") //如果碰撞的標籤是Ship或Bullet
        {
            Destroy(col.gameObject); //消滅碰撞的物件
            Destroy(gameObject); //消滅物件本身
        }
    }
}
