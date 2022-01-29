using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour
{
    [SerializeField] private Vector2 scale = new Vector2(10f, 10f);//�}�X���̂̑傫��
    [SerializeField] private Vector2Int division = new Vector2Int(10, 10);//�}�X�̌�
    [SerializeField] private Material material;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //�V�[���������_�����O������ɌĂяo��
    private void OnRenderObject()
    {
        Vector2 stepSize = scale / division;
        Vector2 halfScale = scale * 0.5f;
        material.SetPass(0);
        GL.PushMatrix();
        GL.MultMatrix(transform.localToWorldMatrix);
        for (int x = 0; x <= division.x; x++)
        {
            GL.Begin(GL.LINES);//�`��J�n
            for (int z = 0; z < division.y; z++)
            {
                GL.Vertex(new Vector3(x * stepSize.x - halfScale.x, 0f, z * stepSize.y - halfScale.y));//���_�𑗐M
                GL.Vertex(new Vector3(x * stepSize.x - halfScale.x, 0f, (z + 1) * stepSize.y - halfScale.y));//���_�𑗐M
            }
            GL.End();
        }
        for (int z = 0; z <= division.y; z++)
        {
            GL.Begin(GL.LINES);//�`��J�n
            for (int x = 0; x < division.x; x++)
            {
                GL.Vertex(new Vector3(x * stepSize.x - halfScale.x, 0f, z * stepSize.y - halfScale.y));//���_�𑗐M
                GL.Vertex(new Vector3((x + 1) * stepSize.x - halfScale.x, 0f, z * stepSize.y - halfScale.y));//���_�𑗐M
            }
            GL.End();
        }
        GL.PopMatrix();
    }
}
