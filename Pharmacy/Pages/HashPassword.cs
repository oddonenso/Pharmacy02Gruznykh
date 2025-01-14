﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HashPasswords
{
    public static class HashPassword
    {
        /// <summary>
        /// хеширование паролей
        /// </summary>

        public static string Hash(string password)
        {
            // Создаем объект класса SHA256CryptoServiceProvider
            var sha256 = new SHA256CryptoServiceProvider();

            // Вычисляем хеш пароля
            var bytes = sha256.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));

            // Возвращаем хеш в виде строки
            return BitConverter.ToString(bytes).Replace("-", "");
        }
    }
}