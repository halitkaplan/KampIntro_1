using System;
using System.Collections.Generic;
using System.Text;

namespace MyListWithDictionaryQuestion5
{
    class MyDictionary<T,E>
    {
        T[] TC;
        E[] eleman;

        public MyDictionary()
        {
            TC = new T[0];
            eleman = new E[0];

        }


        public void Add(T TCler, E elemanlar)
        {
            T[] tempArrayT = TC;
            E[] tempArrayE = eleman;

            TC = new T[TC.Length + 1];
            eleman = new E[eleman.Length +1 ];

            for (int i = 0; i < tempArrayT.Length; i++)
            {
                TC[i] = tempArrayT[i];
                
            }
            TC[TC.Length - 1] = TCler;

            for (int i = 0; i < tempArrayE.Length; i++)
            {
                eleman[i] = tempArrayE[i];
            }
            eleman[eleman.Length - 1] = elemanlar;
            
        }

        public void Listele()
        {
            for (int i = 0; i < TC.Length; i++)
            {
                Console.WriteLine("TC : " + TC[i] +" ______ "+ "İsim :" + eleman[i]);
            }
        }
        
    }
}
