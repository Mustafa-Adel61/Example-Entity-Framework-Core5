using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography;

namespace ExampleEfCore5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AppDBContext context = new AppDBContext();
            #region insert  related data
            //Patient patient = new Patient
            //{
            //    First_Name = "Mustafa",
            //    Middle_Name = "Adel",
            //    Last_Name = "Frahat",
            //    perscrtion = "sasasasa",
            //    Email = "mustafa.adel6101@gmail.com",
            //    Age = 24,
            //    registration = 4,
            //    patient_Phone = new List<Patient_Phone>
            //    {
            //        new Patient_Phone { Phone_Number = "01143514960" },
            //        new Patient_Phone { Phone_Number = "01265437343" },
            //        new Patient_Phone { Phone_Number = "01224322232" },

            //    },
            //    doctor = new Doctor
            //    {
            //        First_Name = "Ahmed",
            //        Middle_Name = "Adel",
            //        Last_Name = "Frahat",
            //        specialization = "ssasasasas",
            //        Age = 30,
            //        years_to_retirement = 10,
            //        doctor_Locations = new List<Doctor_Location> {
            //            new Doctor_Location { Location = "Assiut-Egypt" },
            //            new Doctor_Location { Location = "Cairo-Egypt" }

            //        },
            //        medicines = new List<Medicine> {
            //            new Medicine {
            //                Manufacturer = "GlaxoSmithKline",
            //                remaining_shelf_life = 10,
            //                amount = 150,
            //                frequency = "test",
            //                supplier = new Supplier {
            //                    phone_Number = "01165844333",
            //                    First_Name = "test1",
            //                    Middle_Name = "test2",
            //                    Last_Name = "test3",
            //                    Address = "Minya",
            //                    delivery_efficiency = 80,
            //                }
            //            }
            //        },
            //    },
            //    bill = new Bill
            //    {
            //        date = DateTime.Now,
            //        discount = 0.5f,
            //        Payment_method = "Cash",

            //    },



            //};

            //context.patients.Add(patient);
            //context.SaveChanges();
            #endregion
            #region get related data using Eager loading
            //var patient = context.patients.Include(c => c.doctor).FirstOrDefault();
            //Console.WriteLine(patient.doctor.First_Name); 
            #endregion
            #region get related data using Explicit loading with Referance Navigation property
            //var DoctorName = context.patients.FirstOrDefault();
            //context.Entry(DoctorName).Reference(c => c.doctor).Load();
            //Console.WriteLine(DoctorName.doctor.First_Name);
            #endregion
            #region get related data using Explicit loading with Collection Navigation property in one to many relation
            //var medicineAmountFromSupplier = context.suppliers.FirstOrDefault(c => c.Id == 5);
            //context.Entry(medicineAmountFromSupplier).Collection(c => c.medicines).Load();
            //foreach (var item in medicineAmountFromSupplier.medicines)
            //{
            //    Console.WriteLine(item.amount);

            //} 
            #endregion
            #region get related data using Explicit loading with Collection Navigation property in many to many relation
            //var medicineAmount = context.doctors.FirstOrDefault();
            //context.Entry(medicineAmount).Collection(c => c.medicines).Load();
            //foreach (var item in medicineAmount.medicines)
            //{
            //    Console.WriteLine(item.amount);

            //}
            #endregion
            #region Groupby
            //var Address = context.suppliers.GroupBy(c => c.Address).Select(c => new { s1 = c.Key, s2 = c.Count() });

            //foreach (var item in Address)
            //{
            //    Console.WriteLine($"the Adress {item.s1} apper {item.s2} time");

            //}
            #endregion
            #region No Tracking
            //var changeFirstName = context.patients.AsNoTracking().FirstOrDefault();
            //changeFirstName.First_Name = "SASA";
            //context.SaveChanges(); 
            #endregion
            


        }
    }
}
