using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameFlowOperation
{
    //繁栄評価値　0.0fから100.0fまで
    public float _gamePoint = 0.0f;
    public float _gameClearPoint = 10000.0f;

    public enum _creaturePointType
    {
        Plancton,
        Wood,
        Bug,
        Fish,
        Crocodile,
        Bird,
        Caw,
        Wolf,
        Human,
        Gorilla
    }

    //生物をカウントして加算させる
    public void CreaturePoint(List<Creature> creatureList)
    {

    }
}
