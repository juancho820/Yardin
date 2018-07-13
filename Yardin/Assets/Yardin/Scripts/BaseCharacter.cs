using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseCharacter : MonoBehaviour {

    private string characterName;
    private string characterDescription;
    //stats
    private int health;
    private int explorationSkill;
    private int forageScavange;
    private int build;
    private int attack;
    private int defense;

    public string CharacterName
    {
        get
        {return characterName;}
        set
        {characterName = value;}
    }
    public string CharacterDescription
    {
        get
        {return characterDescription;}
        set
        {characterDescription = value;}
    }
    public int Health
    {
        get
        {return health;}
        set
        {health = value;}
    }
    public int ExplorationSkill
    {
        get
        { return explorationSkill; }
        set
        { explorationSkill = value; }
    }
    public int ForageScavange
    {
        get
        { return forageScavange; }
        set
        { forageScavange = value; }
    }
    public int Build
    {
        get
        { return build; }
        set
        { build = value; }
    }
    public int Attack
    {
        get
        { return attack; }
        set
        { attack = value; }
    }
    public int Defense
    {
        get
        { return defense; }
        set
        { defense = value; }
    }
}
