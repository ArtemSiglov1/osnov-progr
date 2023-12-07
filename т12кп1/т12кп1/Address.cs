﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace т12кп1
{
    internal class Address
    {
        /// <summary>
        /// поле индекса
        /// </summary>
        public ushort index;
        /// <summary>
        /// поле страны
        /// </summary>
        public string country;
        /// <summary>
        /// поле города
        /// </summary>
        public string city;
        /// <summary>
        /// поле улицы
        /// </summary>
        public string street;
        /// <summary>
        /// поле дома
        /// </summary>
        public ushort house;
        /// <summary>
        /// поле номера кв
        /// </summary>
        public ushort apart;


        /// <summary>
        /// конструктор по умолчанию
        /// </summary>
        public Address() { }
        /// <summary>
        /// конструктор с парметром
        /// </summary>
        /// <param name="index"></param>
        /// <param name="country"></param>
        /// <param name="city"></param>
        /// <param name="street"></param>
        /// <param name="house"></param>
        /// <param name="apart"></param>
        public Address(ushort index, string country, string city, string street, ushort house, ushort apart)
        {
            this.index = index;
            this.country = country;
            this.city = city;
            this.street = street;
            this.house = house;
            this.apart = apart;
        }
        /// <summary>
        /// метод вывода
        /// </summary>
        /// <returns>индекс страна город дом апартаменты</returns
        public override string ToString()
        {
            return $"{index}\t {country} \t {city}\t {street}\t {house}\t {apart}";
        }

    }
}
