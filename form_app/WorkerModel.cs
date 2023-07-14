using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Xml.Serialization;

namespace form_app
{
    public class Worker
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public int Salary { get; set; }
        public string Position { get; set; }
        public string ContractType { get; set; }
    }

    internal sealed class WorkerModel
    {
        private List<Worker> _workers;
        //konstruktor
        public WorkerModel()
        {
            _workers = new List<Worker>();
        }
        //walidacja pracownika
        public bool WorkerValidation(Worker worker)
        {
            if (string.IsNullOrWhiteSpace(worker.Name) || string.IsNullOrWhiteSpace(worker.Surname))
            {
                return false; // Imię lub nazwisko jest puste lub składa się z białych znaków
            }

            if (worker.Name.Any(char.IsDigit) || worker.Surname.Any(char.IsDigit))
            {
                return false; // Imię lub nazwisko zawiera cyfry
            }

            if (worker.Name.Contains(" ") || worker.Surname.Split('-').Any(part => part.Contains(" ")) || worker.Surname.Count(c => c == '-') > 1)
            {
                return false; // Imię lub nazwisko zawiera spacje w środku, spacje w drugiej części nazwiska dwuczłonowego lub nazwisko dwuczłonowe zawiera więcej niż jedno łącznik
            }

            if (!Regex.IsMatch(worker.Name, @"^[a-zA-ZżźćńółęąśŻŹĆĄŚĘŁÓŃ]+$") || !Regex.IsMatch(worker.Surname.Replace("-", ""), @"^[a-zA-ZżźćńółęąśŻŹĆĄŚĘŁÓŃ]+$") || worker.Surname.StartsWith("-") || worker.Surname.EndsWith("-"))
            {
                return false; // Imię lub nazwisko zawiera znaki specjalne lub nazwisko dwuczłonowe zawiera znak '-' w niepoprawnym miejscu, zaczyna się od łącznika lub kończy się łącznikiem
            }

            return true; // Imię i nazwisko są poprawne
        }



        //konwersja stringu
        public string NameString(string s)
        {
            string sCorrected = "";

            s = s.ToUpper();
            for (int i = 0; i < s.Length; i++)
            {
                if (i == 0)
                {
                    sCorrected += s[i];
                    s = s.ToLower();
                }
                else if(s[i] == '-')
                {
                    sCorrected += s.Substring(i, 2).ToUpper();
                    i += 1;
                }
                else
                {
                    sCorrected += s[i];
                }
            }
            return sCorrected;
        }

        //dodawanie pracownika
        public void AddWorker(Worker worker)
        {
            worker.Id = _workers.Count > 0 ? _workers.Max(p => p.Id) + 1 : 1;
            worker.Name = NameString(worker.Name);
            worker.Surname = NameString(worker.Surname);
            
            var r = _workers.FirstOrDefault(w => ((w.Name == worker.Name) && (w.Surname == worker.Surname) && (w.Salary == worker.Salary) && (w.Position == worker.Position) && (w.ContractType == worker.ContractType) && (w.BirthDate == worker.BirthDate)));
            if (r != null) return;
            _workers.Add(worker);
        }
        //pobieranie pracownikow
        public List<Worker> GetWorkers() => _workers;
        
        //usuwanie pracowników
        public void DeleteWorker(Worker worker)
        {
            _workers.Remove(worker);
        }
        //edytowanie pracownika
        public void EditWorker(int id, Worker newWorker)
        {
            var worker = _workers.FirstOrDefault(w => w.Id == id);
            if (worker == null) return;
            worker.BirthDate = newWorker.BirthDate;
            worker.Position = newWorker.Position;
            worker.ContractType = newWorker.ContractType;
            worker.Name = newWorker.Name;
            worker.Surname = newWorker.Surname;
            worker.Salary = newWorker.Salary;
        }
        //eksport do pliku
        public void Export(string path)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Worker>));
            using (StreamWriter sw = new StreamWriter(path))
            {
                serializer.Serialize(sw, _workers);
            }
        }
        //import pliku
        public void Import(string path)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Worker>));
            using (StreamReader sr = new StreamReader(path))
            {
                try
                {
                    _workers = (List<Worker>)serializer.Deserialize(sr);
                }
                catch (Exception ex)
                {
                    return;
                }
            }
        }
    }
}



