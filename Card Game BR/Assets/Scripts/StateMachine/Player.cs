/***
  Dummy Player class for the purpose of the Unit class
*/

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
  public int attack_stat {get; }
  public int defense_stat {get; }
  public int hp_stat {get; }
  private int mana_stat {get; }
}
