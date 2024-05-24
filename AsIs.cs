using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsIs : MonoBehaviour
{
    //As-----------------------------------------------------------
    //as Ű���� ���
    public void AsMethod(ParentAs pa)
    {
        ChildrenAs asis = pa as ChildrenAs;
           
        //as Ű����� ����ȯ�� ���� �ʾ��� �� null�� �����Ѵ�. ���ܸ� ����� �ڵ带 ª�� �ۼ��Ҷ� ����.
        if (asis == null)
            return;

        asis.method();

    }

    //���� (�����) �� ��ȯ
    public void ForceMethod(ParentAs pa)
    {
        //�� ��ȯ ���� ó��
        try
        {
            ChildrenAs asis2 = (ChildrenAs)pa;
            if (asis2 == null)
                new Exception("dsadsa");

            asis2.method();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
       
    }
    //----------------------------------------------------------------


    //Is--------------------------------------------------------------
    public void IsMethod(ParentAs ob)
    {
        object a = ob.parent;
        int b;
        
        if(a is int)
        {
            b = (int)a; 
        }
    }
}

public class ParentAs
{
    public int parent { get; set; }   
}

public class ChildrenAs : ParentAs
{
    public void method()
    {
        parent = 10;
    }
}

