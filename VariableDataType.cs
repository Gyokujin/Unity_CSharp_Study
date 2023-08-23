using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariableDataType : MonoBehaviour
{
    void Start()
    {
        // int (����, 10�ڸ� ����, -21�� ~ 21��)
        int x; // �⺻���� 0
        int y;

        x = 1;
        y = 2;

        Debug.Log(x + y);

        // long (ū ����, 18�ڸ� ����)
        long a = 123456789012345;
        long b = 2345678901;

        Debug.Log(a + b);
        Debug.Log(a * b); // long ���� ������ �ʰ��ϱ� ������ ������ ��Ÿ����.

        // float (�Ҽ�, 7�ڸ� �Ҽ�)
        float c = 12345678901234567;
        float d = 12345.56677889f;
        float e = 12345678900000000;

        Debug.Log(c + d); // float ���� ������ �ʰ��ϱ� ������ ������ ��Ÿ����.
        Debug.Log((c == e).ToString()); // 7�ڸ������� ��Ȯ�� ����ϱ� ������ ������ ���� �޶� ���ٰ� ǥ���Ѵ�.

        // bool (���� ����)
        bool f = (c == d); // �⺻���� false

        Debug.Log(f);

        // string (���ڿ�)
        string s = "abcdefg"; // �⺻���� "". �� ���ڿ��̴�.
        string t = "hijkl";

        Debug.Log(s + t);
    }
}