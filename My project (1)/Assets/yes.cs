using System.Collections;
using UnityEngine;

public class yes : MonoBehaviour
{
    [Header("������")]
    [SerializeField] ulong coockies = 0;
    [Space]

    [Header("�������� �����")]
    [SerializeField] ulong nuts = 1;
    [SerializeField] ulong chocolate = 0;
    [SerializeField] ulong orange = 0;
    [SerializeField] ulong caramel = 0;
    [Space]

    [Header("���� (�������� �����)")]
    [SerializeField] ulong chocolatePrice = 150;
    [SerializeField] ulong nutsPrice = 1500;
    [SerializeField] ulong orangePrise = 3000;
    [SerializeField] ulong caramelPrise = 5000;
    [Space]

    [Header("��������� �����")]
    [SerializeField] uint babushka = 0;
    [SerializeField] ulong bakery = 0;
    [SerializeField] ulong customer = 0;
    [SerializeField] ulong shop = 0;

    [Space]

    [Header("���� (��������� �����)")]
    [SerializeField] ulong babushkaPrice = 1000;
    [SerializeField] ulong bakeryPrice = 15000;
    [SerializeField] ulong customerPrice = 30000;
    [SerializeField] ulong shopPrice = 50000;




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
        if (Input.GetKeyDown(KeyCode.D))
        {
           BuyOrange();
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            BuyCaramel();
        }
    }

    void ProcessClick()
    {
        coockies += babushka + bakery * 2 + customer * 3 + shop * 4;
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


    void BuyOrange()
    {
        if (coockies >= orangePrise)
        {
            coockies -= orangePrise;
            orangePrise = (ulong)(chocolatePrice * 1.18f);
            chocolate++;
            print($"�����������, �� ��������� ������� ��������. ��� ������� {orange}");
        }
        else
        {
            print($"� ��������� � ��� �� ������� ������� ��� ��������. �������� ��� {orangePrise - coockies} ");
        }
    }  

    void BuyCaramel()
    {
        if (coockies >= caramelPrise)
        {
            coockies -= caramelPrise;
            caramelPrise = (ulong)(chocolatePrice * 1.18f);
            chocolate++;
            print($"�����������, �� ��������� ������� ��������. ��� ������� {caramel}");
        }
        else
        {
            print($"� ��������� � ��� �� ������� ������� ��� ��������. �������� ��� {caramelPrise - coockies} ");
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
}





