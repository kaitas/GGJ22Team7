using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameFlowOperation
{
    //�ɉh�]���l�@0.0f����100.0f�܂�
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

    //�������J�E���g���ĉ��Z������
    public void CreaturePoint(List<Creature> creatureList)
    {

    }
}
