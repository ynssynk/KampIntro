﻿using System;

namespace OOP3
{
    public class EsnafKrediManager:IKrediManager
    {
        public void Hesapla()
        {
            Console.WriteLine("Esnaf kredisi hesaplandı");
        }

        public void BiseyYap()
        {
            throw new System.NotImplementedException();
        }
    }
}