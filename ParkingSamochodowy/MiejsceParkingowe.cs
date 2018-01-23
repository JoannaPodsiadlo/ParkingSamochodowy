﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ParkingSamochodowy
{
    public enum Status
    {
        wolne, zajete
    }
    public class MiejsceParkingowe
    {
        private int _nrMiejsca;
        private static int iDMiejsca = 0;
        private Status _status;
        public int NrMiejsca { get => _nrMiejsca; set => _nrMiejsca = value; }
        public static int IDMiejsca { get => iDMiejsca; set => iDMiejsca = value; }
        public Status Status { get => _status; set => _status = value; }

        public MiejsceParkingowe()
        {
            this._nrMiejsca = Interlocked.Increment(ref iDMiejsca);
            _status = Status.wolne;
        }

        public void Zajmij()
        {
            _status = Status.zajete;
        }

        public override string ToString()
        {
            return _nrMiejsca.ToString() + " " + _status.ToString();
        }

    }
}