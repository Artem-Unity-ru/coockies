using System.Collections;
using UnityEngine;

public class yes : MonoBehaviour
{
    [Header("������")]
    [SerializeField] ulong coockies = 0;
    [Space]

    [Header("�������� �����")]
    [SerializeField] uint babushka = 0;
    [SerializeField] ulong bakery = 0;
    [SerializeField] ulong customer = 0;
    [SerializeField] ulong shop = 0;
    [Space]

    [Header("���� (�������� �����)")]
    [SerializeField] ulong babushkaPrice = 100;
    [SerializeField] ulong bakeryPrice = 1500;
    [SerializeField] ulong customerPrice = 3000;
    [SerializeField] ulong shopPrice = 5000;
    [Space]

    [Header("��������� �����")]
    [SerializeField] uint chocolate = 0;
    [SerializeField] uint nuts = 0;
    [Space]

    [Header("���� (��������� �����)")]
    [SerializeField] ulong chocolatePrice = 2000;
    [SerializeField] ulong nutsPrice = 20000;




    void Start()
    {
        StartCoroutine(AutoClick());
    }


    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            ProcessClick();
            print($"��� ������ {coockies}$");
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            BuyBabyshka();
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            BuyBakery();
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            BuyCustomer();
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            BuyShop();
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            BuyChocolate();
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            BuyNuts();
        }
    }

    void ProcessClick()
    {
        coockies += babushka + bakery * 2 + customer * 3 + shop * 4;
    }

    void BuyBabyshka()
    {
        if (coockies >= babushkaPrice)
        {
            coockies -= babushkaPrice;
            babushkaPrice = (ulong)(babushkaPrice * 1.18f);
            babushka++;
            print($"����������� � �������� �������������. � ��� {babushka} �������");
        }
        else
        {
            print($"� ��������� � ��� �� ������� ������� ��� �������. �������� ��� {babushkaPrice - coockies}$");
        }
    }

    void BuyBakery()
    {
        if (coockies >= bakeryPrice)
        {
            coockies -= bakeryPrice;
            bakeryPrice = (ulong)(bakeryPrice * 1.18f);
            bakery++;
            print($"����������� � �������� �������������. � ��� {bakery} �������");
        }
        else
        {
            print($"� ��������� � ��� �� ������� ������� ��� �������. �������� ��� {bakeryPrice - coockies}$");
        }
    }

    void BuyCustomer()
    {
        if (coockies >= customerPrice)
        {
            coockies -= customerPrice;
            customerPrice = (ulong)(customerPrice * 1.18f);
            customer++;
            print($"����������� � �������� �������������. � ��� {customer} ���������� �����������");
        }
        else
        {
            print($"� ��������� � ��� �� ������� ������� ��� �������. �������� ��� {customerPrice - coockies}$");
        }
    }

    void BuyShop()
    {
        if (coockies >= bakeryPrice)
        {
            coockies -= shopPrice;
            shopPrice = (ulong)(shopPrice * 1.18f);
            shop++;
            print($"����������� � �������� �������������. � ��� {shop} ���������� �����������");
        }
        else
        {
            print($"� ��������� � ��� �� ������� ������� ��� �������. �������� ��� {shopPrice - coockies}$");
        }
    }

    IEnumerator AutoClick()
    {
        while (true)
        {
            coockies += chocolate + nuts * 2;
            print(coockies);
            yield return new WaitForSeconds(0.75f);
        }
    }

    void BuyChocolate()
    {
        if (coockies >= chocolatePrice)
        {
            coockies -= chocolatePrice;
            chocolatePrice = (ulong)(chocolatePrice * 1.18f);
            chocolate++;
            print($"�����������, �� ��������� ������� ��������. ��� ������� {chocolate}");
        }
        else
        {
            print($"� ��������� � ��� �� ������� ������� ��� ��������. �������� ��� {chocolatePrice - coockies} ");
        }
    }

    void BuyNuts()
    {
        if (coockies >= nutsPrice)
        {
            coockies -= nutsPrice;
            nutsPrice = (ulong)(nutsPrice * 1.18f);
            nuts++;
            print($"�����������, �� ��������� ������� ������. ��� ������� {nuts}");
        }
        else
        {
            print($"� ��������� � ��� �� ������� ������� ��� ��������. �������� ��� {nutsPrice - coockies} ");
        }
    }
}





