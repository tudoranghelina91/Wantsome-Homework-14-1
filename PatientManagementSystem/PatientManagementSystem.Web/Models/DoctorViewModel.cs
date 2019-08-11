﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PatientManagementSystem.Web.Models
{
    public class DoctorViewModel : UserViewModel
    {
        public enum Specialty
        {
            AccidentAndEmergencyMedicine,
            Allergology,
            Anaesthetics,
            Cardiology,
            ChildPsychiatry,
            ClinicalBiology,
            ClinicalChemistry,
            ClinicalNeurophysiology,
            CraniofacialSurgery,
            Dermatology,
            Endocrinology,
            FamilyAndGeneralMedicine,
            GastroenterologicSurgery,
            Gastroenterology,
            GeneralPractice,
            GeneralSurgery,
            Geriatrics,
            Hematology,
            Immunology,
            InfectiousDiseases,
            InternalMedicine,
            LaboratoryMedicine,
            Microbiology,
            Nephrology,
            Neuropsychiatry,
            Neurology,
            Neurosurgery,
            NuclearMedicine,
            ObstetricsAndGynaecology,
            OccupationalMedicine,
            Ophthalmology,
            OralAndMaxillofacialSurgery,
            Orthopaedics,
            Otorhinolaryngology,
            PaediatricSurgery,
            Paediatrics,
            Pathology,
            Pharmacology,
            PhysicalMedicineAndRehabilitation,
            PlasticSurgery,
            PodiatricSurgery,
            PreventiveMedicine,
            Psychiatry,
            PublicHealth,
            RadiationOncology,
            Radiology,
            RespiratoryMedicine,
            Rheumatology,
            Stomatology,
            ThoracicSurgery,
            TropicalMedicine,
            Urology,
            VascularSurgery,
            Venereology,
        }
        public string University { get; set; }
        public Specialty Specialization { get; set; }
        public string LicenseNo { get; set; }
    }
}