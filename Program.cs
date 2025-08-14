//using hospital.model;
//using Hospital.dbcontext;
//using hospital.services;
//using static System.Runtime.InteropServices.JavaScript.JSType;

//namespace hospital
//{
//    internal class Program
//    {
//        public static void ShowMenuDoctors()
//        {
//            Console.WriteLine("1. Add Doctor");
//            Console.WriteLine("2. View Doctors");
//            Console.WriteLine("3. Update Doctor");
//            Console.WriteLine("4. Delete Doctor");
//            Console.WriteLine("5. Exit");
//        }
//        public static void ShowMenuPatients()
//        {
//            Console.WriteLine("1. Add Patient");
//            Console.WriteLine("2. View Patients");
//            Console.WriteLine("3. Update Patient");
//            Console.WriteLine("4. Delete Patient");
//            Console.WriteLine("5. Exit");
//        }
//        public static void ShowMenuCitas()
//        {
//            Console.WriteLine("1. Add Cita");
//            Console.WriteLine("2. View Citas");
//            Console.WriteLine("3. Update Cita");
//            Console.WriteLine("4. Delete Cita");
//            Console.WriteLine("5. Exit");
//        }
//        public static void ShowMenuHistori()
//        {
//            Console.WriteLine("1. Add Histori");
//            Console.WriteLine("2. View Historis");
//            Console.WriteLine("3. Update Histori");
//            Console.WriteLine("4. Delete Histori");
//            Console.WriteLine("5. Exit");
//        }

//        static void Main(string[] args)
//        {
//            Console.WriteLine("Welcome to the Hospital Management System!");
//            Console.WriteLine("Please select an option:");

//            Console.WriteLine("1. Manage Doctors");
//            Console.WriteLine("2. Manage Patients");
//            Console.WriteLine("3. Manage Citas");
//            Console.WriteLine("4. Manage Histori");
//            Console.WriteLine("5. Exit");

//            string opcion = Console.ReadLine();

//            switch (opcion)
//            {
//                case "1":
//                    {
//                        string doctorOption;
//                        do
//                        {
//                            ShowMenuDoctors();
//                            doctorOption = Console.ReadLine();
//                            switch (doctorOption)
//                            {
//                                case "1":
//                                    {
//                                        Console.WriteLine("Enter Doctor Name:");
//                                        string name = Console.ReadLine();
//                                        Console.WriteLine("Enter Doctor Lastname:");
//                                        string lastname = Console.ReadLine();
//                                        Console.WriteLine("Enter Doctor Cellphone:");
//                                        string cellphone = Console.ReadLine();
//                                        Console.WriteLine("Enter Doctor especialidad:");
//                                        string especialidad = Console.ReadLine();

//                                        DocServices.AddDoctor(name, lastname, cellphone);

//                                        break;
//                                    }
//                                case "2":
//                                    {
//                                        var doctors = DocServices.GetDoctors();
//                                        foreach (var doc in doctors)
//                                        {
//                                            Console.WriteLine($"ID: {doc.ID}, Name: {doc.Name}, Lastname: {doc.Lastname}, Cellphone: {doc.Cellphone}");
//                                        }
//                                        break;
//                                    }
//                                case "3":
//                                    {
//                                        Console.WriteLine("Enter Doctor ID to update:");
//                                        int id = int.Parse(Console.ReadLine());
//                                        var doctor = DocServices.GetDoctorById(id);
//                                        if (doctor != null)
//                                        {
//                                            Console.WriteLine("Enter new Name:");
//                                            doctor.Name = Console.ReadLine();
//                                            Console.WriteLine("Enter new Lastname:");
//                                            doctor.Lastname = Console.ReadLine();
//                                            Console.WriteLine("Enter new Cellphone:");
//                                            doctor.Cellphone = Console.ReadLine();
//                                            DocServices.UpdateDoctor(doctor);
//                                        }
//                                        else
//                                        {
//                                            Console.WriteLine("Doctor not found.");
//                                        }
//                                        break;
//                                    }
//                                case "4":
//                                    {
//                                        Console.WriteLine("Enter Doctor ID to delete:");
//                                        int id = int.Parse(Console.ReadLine());
//                                        DocServices.DeleteDoctor(id);
//                                        break;
//                                    }
//                                case "5":
//                                    {
//                                        Console.WriteLine("Exiting Doctor Management.");
//                                        break;
//                                    }
//                                default:
//                                    {
//                                        Console.WriteLine("Invalid option. Please try again.");
//                                        break;
//                                    }
//                            }
//                        } while (doctorOption != "5");
//                        break;
//                    }
//                case "2":
//                    // Implement citas management here
//                    string patientOption;
//                    do
//                    {
//                        ShowMenuPatients();
//                        patientOption = Console.ReadLine();
//                        switch (patientOption)
//                        {
//                            case "1":
//                                {
//                                    Console.WriteLine("Enter Patient Name:");
//                                    string name = Console.ReadLine();
//                                    Console.WriteLine("Enter Patient Lastname:");
//                                    string lastname = Console.ReadLine();
//                                    Console.WriteLine("Enter Patient Cellphone:");
//                                    string cellphone = Console.ReadLine();
//                                    pacientesCervices.AddPaciente(name, lastname, cellphone);
//                                    break;
//                                }
//                            case "2":
//                                {
//                                    var patients = pacientesCervices.GetPacientes();
//                                    foreach (var patient in patients)
//                                    {
//                                        Console.WriteLine($"ID: {patient.ID}, Name: {patient.Name}, Lastname: {patient.Lastname}, Cellphone: {patient.Cellphone}");
//                                    }
//                                    break;
//                                }
//                            case "3":
//                                {
//                                    Console.WriteLine("Enter Patient ID to update:");
//                                    int id = int.Parse(Console.ReadLine());
//                                    var patient = pacientesCervices.GetPacienteById(id);
//                                    if (patient != null)
//                                    {
//                                        Console.WriteLine("Enter new Name:");
//                                        patient.Name = Console.ReadLine();
//                                        Console.WriteLine("Enter new Lastname:");
//                                        patient.Lastname = Console.ReadLine();
//                                        Console.WriteLine("Enter new Cellphone:");
//                                        patient.Cellphone = Console.ReadLine();
//                                        pacientesCervices.UpdatePaciente(patient);
//                                    }
//                                    else
//                                    {
//                                        Console.WriteLine("Patient not found.");
//                                    }
//                                    break;
//                                }
//                            case "4":
//                                {
//                                    Console.WriteLine("Enter Patient ID to delete:");
//                                    int id = int.Parse(Console.ReadLine());
//                                    pacientesCervices.DeletePaciente(id);
//                                    break;
//                                }
//                            case "5":
//                                {
//                                    Console.WriteLine("Exiting Patient Management.");
//                                    break;
//                                }
//                            default:
//                                {
//                                    Console.WriteLine("Invalid option. Please try again.");
//                                    break;
//                                }
//                        }
//                    } while (patientOption != "5");


//                    break;
//                case "3":
//                    // Implement citas management here

//                    break;
//                case "4":
//                    // Implement Medical Records management here
//                    string historiOption;

//                    break;


//                case "5":



//                default:
//                    Console.WriteLine("Invalid option. Please try again.");
//                    break;



//            }




//        }
//    }
//}


////        static void Main(string[] args)
////        {
////            string mainOption;

////            do
////            {
////                Console.WriteLine("Welcome to the Hospital Management System!");
////                Console.WriteLine("Please select an option:");
////                Console.WriteLine("1. Manage Doctors");
////                Console.WriteLine("2. Manage Patients");
////                Console.WriteLine("3. Manage Citas");
////                Console.WriteLine("4. Manage Histori");
////                Console.WriteLine("5. Exit");

////                mainOption = Console.ReadLine();

////                switch (mainOption)
////                {
////                    case "1":
////                        {
////                            string doctorOption;
////                            do
////                            {
////                                ShowMenuDoctors();
////                                doctorOption = Console.ReadLine();
////                                switch (doctorOption)
////                                {
////                                    case "1":
////                                        Console.WriteLine("Enter Doctor Name:");
////                                        string name = Console.ReadLine();
////                                        Console.WriteLine("Enter Doctor Lastname:");
////                                        string lastname = Console.ReadLine();
////                                        Console.WriteLine("Enter Doctor Cellphone:");
////                                        string cellphone = Console.ReadLine();
////                                        Console.WriteLine("Enter Doctor especialidad:");
////                                        string especialidad = Console.ReadLine();
////                                        DocServices.AddDoctor(name, lastname, cellphone);
////                                        break;
////                                    case "2":
////                                        var doctors = DocServices.GetDoctors();
////                                        foreach (var doc in doctors)
////                                        {
////                                            Console.WriteLine($"ID: {doc.ID}, Name: {doc.Name}, Lastname: {doc.Lastname}, Cellphone: {doc.Cellphone}");
////                                        }
////                                        break;
////                                    case "3":
////                                        Console.WriteLine("Enter Doctor ID to update:");
////                                        int idUpdate = int.Parse(Console.ReadLine());
////                                        var doctor = DocServices.GetDoctorById(idUpdate);
////                                        if (doctor != null)
////                                        {
////                                            Console.WriteLine("Enter new Name:");
////                                            doctor.Name = Console.ReadLine();
////                                            Console.WriteLine("Enter new Lastname:");
////                                            doctor.Lastname = Console.ReadLine();
////                                            Console.WriteLine("Enter new Cellphone:");
////                                            doctor.Cellphone = Console.ReadLine();
////                                            DocServices.UpdateDoctor(doctor);
////                                        }
////                                        else
////                                        {
////                                            Console.WriteLine("Doctor not found.");
////                                        }
////                                        break;
////                                    case "4":
////                                        Console.WriteLine("Enter Doctor ID to delete:");
////                                        int idDelete = int.Parse(Console.ReadLine());
////                                        DocServices.DeleteDoctor(idDelete);
////                                        break;
////                                    case "5":
////                                        Console.WriteLine("Exiting Doctor Management.");
////                                        break;
////                                    default:
////                                        Console.WriteLine("Invalid option. Please try again.");
////                                        break;
////                                }
////                            } while (doctorOption != "5");
////                            break;
////                        }

////                    case "2":
////                        {
////                            string patientOption;
////                            do
////                            {
////                                ShowMenuPatients();
////                                patientOption = Console.ReadLine();
////                                switch (patientOption)
////                                {
////                                    case "1":
////                                        Console.WriteLine("Enter Patient Name:");
////                                        string name = Console.ReadLine();
////                                        Console.WriteLine("Enter Patient Lastname:");
////                                        string lastname = Console.ReadLine();
////                                        Console.WriteLine("Enter Patient Cellphone:");
////                                        string cellphone = Console.ReadLine();
////                                        pacientesCervices.AddPaciente(name, lastname, cellphone);
////                                        break;
////                                    case "2":
////                                        var patients = pacientesCervices.GetPacientes();
////                                        foreach (var patient in patients)
////                                        {
////                                            Console.WriteLine($"ID: {patient.ID}, Name: {patient.Name}, Lastname: {patient.Lastname}, Cellphone: {patient.Cellphone}");
////                                        }
////                                        break;
////                                    case "3":
////                                        Console.WriteLine("Enter Patient ID to update:");
////                                        int id = int.Parse(Console.ReadLine());
////                                        var patientUpdate = pacientesCervices.GetPacienteById(id);
////                                        if (patientUpdate != null)
////                                        {
////                                            Console.WriteLine("Enter new Name:");
////                                            patientUpdate.Name = Console.ReadLine();
////                                            Console.WriteLine("Enter new Lastname:");
////                                            patientUpdate.Lastname = Console.ReadLine();
////                                            Console.WriteLine("Enter new Cellphone:");
////                                            patientUpdate.Cellphone = Console.ReadLine();
////                                            pacientesCervices.UpdatePaciente(patientUpdate);
////                                        }
////                                        else
////                                        {
////                                            Console.WriteLine("Patient not found.");
////                                        }
////                                        break;
////                                    case "4":
////                                        Console.WriteLine("Enter Patient ID to delete:");
////                                        int idDel = int.Parse(Console.ReadLine());
////                                        pacientesCervices.DeletePaciente(idDel);
////                                        break;
////                                    case "5":
////                                        Console.WriteLine("Exiting Patient Management.");
////                                        break;
////                                    default:
////                                        Console.WriteLine("Invalid option. Please try again.");
////                                        break;
////                                }
////                            } while (patientOption != "5");
////                            break;
////                        }

////                    case "3":
////                        Console.WriteLine("Manage Citas (no implementado aún)");
////                        break;

////                    case "4":
////                        Console.WriteLine("Manage Histori (no implementado aún)");
////                        break;

////                    case "5":
////                        Console.WriteLine("Exiting system...");
////                        break;

////                    default:
////                        Console.WriteLine("Invalid option. Please try again.");
////                        break;
////                }

////            } while (mainOption != "5");
////        }
////    }
////};
using hospital.model;
using Hospital.dbcontext;
using hospital.services;
using System;

namespace hospital
{
    internal class Program
    {
        public static void ShowMenuDoctors()
        {
            Console.WriteLine("\n--- Doctors Menu ---");
            Console.WriteLine("1. Add Doctor");
            Console.WriteLine("2. View Doctors");
            Console.WriteLine("3. Update Doctor");
            Console.WriteLine("4. Delete Doctor");
            Console.WriteLine("5. Back to Main Menu");
        }

        public static void ShowMenuPatients()
        {
            Console.WriteLine("\n--- Patients Menu ---");
            Console.WriteLine("1. Add Patient");
            Console.WriteLine("2. View Patients");
            Console.WriteLine("3. Update Patient");
            Console.WriteLine("4. Delete Patient");
            Console.WriteLine("5. Back to Main Menu");
        }

        public static void ShowMenuCitas()
        {
            Console.WriteLine("\n--- Citas Menu ---");
            Console.WriteLine("1. Add Cita");
            Console.WriteLine("2. View Citas");
            Console.WriteLine("3. Update Cita");
            Console.WriteLine("4. Delete Cita");
            Console.WriteLine("5. Back to Main Menu");
        }

        public static void ShowMenuHistori()
        {
            Console.WriteLine("\n--- Historial Menu ---");
            Console.WriteLine("1. View Historial");
            Console.WriteLine("2. View Historial by Date Range");
            Console.WriteLine("3. Back to Main Menu");
        }

        static void Main(string[] args)
        {
            string mainOption;
            do
            {
                Console.WriteLine("\nWelcome to the Hospital Management System!");
                Console.WriteLine("1. Manage Doctors");
                Console.WriteLine("2. Manage Patients");
                Console.WriteLine("3. Manage Citas");
                Console.WriteLine("4. Manage Historial");
                Console.WriteLine("5. Exit");
                Console.Write("Select an option: ");
                mainOption = Console.ReadLine();

                switch (mainOption)
                {
                    case "1": // Doctors
                        string doctorOption;
                        do
                        {
                            ShowMenuDoctors();
                            doctorOption = Console.ReadLine();
                            switch (doctorOption)
                            {
                                case "1":
                                    Console.Write("Enter Doctor Name: ");
                                    string name = Console.ReadLine();
                                    Console.Write("Enter Doctor Lastname: ");
                                    string lastname = Console.ReadLine();
                                    Console.Write("Enter Doctor Cellphone: ");
                                    string cellphone = Console.ReadLine();
                                    Console.Write("Enter Doctor Especialidad: ");
                                    string especialidad = Console.ReadLine();
                                    DocServices.AddDoctor(name, lastname, cellphone, especialidad);
                                    break;

                                case "2":
                                    var doctors = DocServices.GetDoctors();
                                    foreach (var doc in doctors)
                                    {
                                        Console.WriteLine($"ID: {doc.ID}, Name: {doc.Name}, Lastname: {doc.Lastname}, Cellphone: {doc.Cellphone}, Especialidad: {doc.Especialidad}");
                                    }
                                    break;

                                case "3":
                                    Console.Write("Enter Doctor ID to update: ");
                                    int idUpdate = int.Parse(Console.ReadLine());
                                    var doctor = DocServices.GetDoctorById(idUpdate);
                                    if (doctor != null)
                                    {
                                        Console.Write("New Name: ");
                                        doctor.Name = Console.ReadLine();
                                        Console.Write("New Lastname: ");
                                        doctor.Lastname = Console.ReadLine();
                                        Console.Write("New Cellphone: ");
                                        doctor.Cellphone = Console.ReadLine();
                                        Console.Write("New Especialidad: ");
                                        doctor.Especialidad = Console.ReadLine();
                                        DocServices.UpdateDoctor(doctor);
                                    }
                                    else Console.WriteLine("Doctor not found.");
                                    break;

                                case "4":
                                    Console.Write("Enter Doctor ID to delete: ");
                                    int idDelete = int.Parse(Console.ReadLine());
                                    DocServices.DeleteDoctor(idDelete);
                                    break;
                            }
                        } while (doctorOption != "5");
                        break;

                    case "2": // Patients
                        string patientOption;
                        do
                        {
                            ShowMenuPatients();
                            patientOption = Console.ReadLine();
                            switch (patientOption)
                            {
                                case "1":
                                    Console.Write("Enter Patient Name: ");
                                    string pname = Console.ReadLine();
                                    Console.Write("Enter Patient Lastname: ");
                                    string plastname = Console.ReadLine();
                                    Console.Write("Enter Patient Cellphone: ");
                                    string pcell = Console.ReadLine();
                                    pacientesCervices.AddPaciente(pname, plastname, pcell);
                                    break;

                                case "2":
                                    var patients = pacientesCervices.GetPacientes();
                                    foreach (var p in patients)
                                    {
                                        Console.WriteLine($"ID: {p.ID}, Name: {p.Name}, Lastname: {p.Lastname}, Cellphone: {p.Cellphone}");
                                    }
                                    break;

                                case "3":
                                    Console.Write("Enter Patient ID to update: ");
                                    int pid = int.Parse(Console.ReadLine());
                                    var patient = pacientesCervices.GetPacienteById(pid);
                                    if (patient != null)
                                    {
                                        Console.Write("New Name: ");
                                        patient.Name = Console.ReadLine();
                                        Console.Write("New Lastname: ");
                                        patient.Lastname = Console.ReadLine();
                                        Console.Write("New Cellphone: ");
                                        patient.Cellphone = Console.ReadLine();
                                        pacientesCervices.UpdatePaciente(patient);
                                    }
                                    else Console.WriteLine("Patient not found.");
                                    break;

                                case "4":
                                    Console.Write("Enter Patient ID to delete: ");
                                    int pidDel = int.Parse(Console.ReadLine());
                                    pacientesCervices.DeletePaciente(pidDel);
                                    break;
                            }
                        } while (patientOption != "5");
                        break;

                    case "3": // Citas
                        string citaOption;
                        do
                        {
                            ShowMenuCitas();
                            citaOption = Console.ReadLine();
                            switch (citaOption)
                            {
                                case "1":
                                    Console.Write("Enter Paciente ID: ");
                                    int pacienteId = int.Parse(Console.ReadLine());
                                    Console.Write("Enter Doctor ID: ");
                                    int doctorId = int.Parse(Console.ReadLine());
                                    Console.Write("Enter Date (yyyy-MM-dd HH:mm): ");
                                    DateTime date = DateTime.Parse(Console.ReadLine());
                                    CitasServices.AddCita(pacienteId, doctorId, date);
                                    break;

                                case "2":
                                    var citas = CitasServices.GetCitas();
                                    foreach (var c in citas)
                                    {
                                        Console.WriteLine($"ID: {c.ID}, PacienteID: {c.PacienteID}, DoctorID: {c.DoctorID}, Date: {c.Date}");
                                    }
                                    break;

                                case "3":
                                    Console.Write("Enter Cita ID to update: ");
                                    int citaId = int.Parse(Console.ReadLine());
                                    var cita = CitasServices.GetCitaById(citaId);
                                    if (cita != null)
                                    {
                                        Console.Write("New Paciente ID: ");
                                        cita.PacienteID = int.Parse(Console.ReadLine());
                                        Console.Write("New Doctor ID: ");
                                        cita.DoctorID = int.Parse(Console.ReadLine());
                                        Console.Write("New Date (yyyy-MM-dd HH:mm): ");
                                        cita.Date = DateTime.Parse(Console.ReadLine());
                                        CitasServices.UpdateCita(cita);
                                    }
                                    else Console.WriteLine("Cita not found.");
                                    break;

                                case "4":
                                    Console.Write("Enter Cita ID to delete: ");
                                    int cidDel = int.Parse(Console.ReadLine());
                                    CitasServices.DeleteCita(cidDel);
                                    break;
                            }
                        } while (citaOption != "5");
                        break;

                    case "4": // Historial
                        string histOption;
                        do
                        {
                            ShowMenuHistori();
                            histOption = Console.ReadLine();
                            var context = new ClinicaContext();
                            var historialService = new HistorialService(context);

                            switch (histOption)
                            {
                                case "1":
                                    var historial = historialService.ObtenerHistorial();
                                    foreach (var h in historial)
                                    {
                                        Console.WriteLine($"ID: {h.ID}, Date: {h.Date}, Doctor: {h.Doctor?.Name}, Paciente: {h.Paciente?.Name}");
                                    }
                                    break;

                                case "2":
                                    Console.Write("Enter start date (yyyy-MM-dd): ");
                                    DateTime start = DateTime.Parse(Console.ReadLine());
                                    Console.Write("Enter end date (yyyy-MM-dd): ");
                                    DateTime end = DateTime.Parse(Console.ReadLine());
                                    var historialFiltrado = historialService.ObtenerHistorial(start, end);
                                    foreach (var h in historialFiltrado)
                                    {
                                        Console.WriteLine($"ID: {h.ID}, Date: {h.Date}, Doctor: {h.Doctor?.Name}, Paciente: {h.Paciente?.Name}");
                                    }
                                    break;
                            }
                        } while (histOption != "3");
                        break;

                    case "5":
                        Console.WriteLine("Exiting system...");
                        break;

                    default:
                        Console.WriteLine("Invalid option. Try again.");
                        break;
                }

            } while (mainOption != "5");
        }
    }
}

