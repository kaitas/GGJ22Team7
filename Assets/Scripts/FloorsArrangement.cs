using UnityEngine;

public class FloorsArrangement
{
    public GameObject[] _floors;//�Q�[���I�u�W�F�N�g�̍쐬
    private float x, z;//�ϐ�

    void Start()
    {
        _floors = GameObject.FindGameObjectsWithTag("floor");//�^�O�Ŏ擾

        for (var i = 0; i < _floors.Length; i++)
        {
            _floors[i].gameObject.name = "floor_" + "(" + i + ")";
            Placement(i);
        }
    }
    void Placement(int i)
    {
        x = (i + 1) % 100;
        z = (i + 1) / 100;
        if (x == 0) x = 100;
        _floors[i].gameObject.transform.position = new Vector3(x - 50, 6, z - 50);
    }
}