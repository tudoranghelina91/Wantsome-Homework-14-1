﻿using System.Collections.Generic;
using PatientManagementSystem.Domain;
using System.Linq;

namespace PatientManagementSystem.Repositories
{
    class PatientRepository : Context, IPatientRepository
    {
        public void Add(Patient patient)
        {
            context.Patients.Add(patient);
            context.SaveChanges();
        }

        public IList<Patient> GetAll()
        {
            return context.Patients.ToList();
        }

        public Patient GetById(int id)
        {
            return context.Patients.FirstOrDefault(p => p.Id == id);
        }
    }
}
