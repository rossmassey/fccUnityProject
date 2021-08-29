using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpButton : MonoBehaviour
{
  GameObject player;

  void Start()
  {
    player = GameObject.FindWithTag("Player");
  }

  public void Jump()
  {
    Debug.Log("Jump Button Pressed");
    player.GetComponent<Player>().Jump();
  }


}
