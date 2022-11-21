﻿using lab8.Utils;
using laba8.Models.Entities;
using System.Collections;

namespace lab8.Collections
{
    public class CustomMedicineCollection : IEnumerable
    {
        private readonly List<Medicine> medicines;
        private readonly OintmentEnumerator ointmentEnumerator;

        public CustomMedicineCollection(List<Medicine> medicines)
        {
            this.medicines = medicines;
            ointmentEnumerator = new OintmentEnumerator(this);
        }

        public int Length => this.medicines.Count;

        public IEnumerator GetEnumerator()
        {
            foreach (var medicine in this.medicines)
            {
                yield return medicine.Title;
            }
        }

        //public IEnumerator GetEnumerator()
        //{
        //    return ointmentEnumerator;
        //}

        public Medicine this[int index]
        {
            get => this.medicines[index];
            set => this.medicines[index] = value;
        }
    }
}