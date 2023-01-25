﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploOO07_ExcecoesPersoReservation.Entities
{
    internal class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation() { }

        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }
        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }
        public string UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            DateTime now = DateTime.Now;
            if (checkIn < now || checkOut < now)
            {
                return "Reservation dates for update must be future dates!";
            }
            if (checkOut <= checkIn)
            {
                return "Check-Out date must be after Check-In!";
            }
            CheckIn = checkIn;
            CheckOut = checkOut;
            return null;
        }
        public override string ToString()
        {
            return ($"Room: {RoomNumber}, Check-In: {CheckIn.ToString("dd/MM/yyyy")}," +
                $" Check-Out: {CheckOut.ToString("dd/MM/yyyy")}, {Duration()} nights.");
        }
    }
}
