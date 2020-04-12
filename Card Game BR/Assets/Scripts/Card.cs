/***
  Dummy Card Class for the purpose of the Unit class
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
  public int attack_stat { get; }
  public int defense_stat {get; }
  private int mana_required {get; }
  private string type {get; }
  private string unit_type {get; }

}
