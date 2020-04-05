/***
  Unit class

  Constructors for the class are designed to only permit either a Player Unit
  or Card Unit per unit.

  Each Unit may only belong to one specific tile.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
  private Card card {get; }; // Associated Card for Unit
  private Player player {get; }; // Associated Player for Unit
  private Tile tile {get; private set;}; // Associated Tile the Unit is placed on

  private int attack_stat {get; private set;}; // Attack Stat for Player/Card unit
  private int defense_stat {get; private set;}; // Defense Stat for Player/Card unit
  private int hp_stat {get; private set;}; // HP Stat for Player units

  // Constructor for the Card Unit
  public Unit(Card card, Tile tile) {
    this.card = card;
    this.tile = tile;
    this.attack_stat = card.attack_stat;
    this.defense_stat = card.defense_stat;
  }

  // Constructor for the Player Unit
  public Unit(Player player, Tile tile) {
    this.player = player;
    this.attack_stat = player.attack_stat;
    this.defense_stat = player.defense_stat;
    this.hp_stat = player.hp_stat;
    this.tile = tile;
  }

  public bool IsPlayerUnit() {
    return player != null;
  }

  public IsCardUnit() {
    return card != null;
  }
}
