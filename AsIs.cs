using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsIs : MonoBehaviour
{
    //As-----------------------------------------------------------
    //as 키워드 사용
    public void AsMethod(ParentAs pa)
    {
        ChildrenAs asis = pa as ChildrenAs;
           
        //as 키워드는 형변환이 되지 않았을 시 null을 리턴한다. 예외를 고려한 코드를 짧게 작성할때 좋다.
        if (asis == null)
            return;

        asis.method();

    }

    //강제 (명시적) 형 변환
    public void ForceMethod(ParentAs pa)
    {
        //형 변환 예외 처리
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

