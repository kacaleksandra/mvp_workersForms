using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;


namespace form_app
{
    public partial class WorkerView : Form
    {
        public WorkerView()
        {
            InitializeComponent();
            postion_selectBox.SelectedIndex = 0;
            radio1.Checked = true;
        }

        //event handlers
        public event EventHandler<EventArgs> AddWorker;
        public event EventHandler<int> PreviewWorker;
        public event EventHandler<int> DeleteWorker;
        public event EventHandler<int> EditWorker;
        public event EventHandler<string> Export;
        public event EventHandler<string> Import;

        //buttony
        private void AddButton_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            EditButton.Text = "Edytuj";
            AddWorker?.Invoke(this, EventArgs.Empty);
        }

        private void WorkersList_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            dynamic item = workersList.SelectedItem;
            if (item == null) return;
            PreviewWorker.Invoke(sender, item.Id);
        }

        private void DeleteWorker_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            EditButton.Text = "Edytuj";
            dynamic item = workersList.SelectedItem;
            if(item != null) DeleteWorker?.Invoke(this, item.Id);
            else return;
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            dynamic item = workersList.SelectedItem;
            if (item != null)
            {
                if (EditButton.Text == "Edytuj") EditButton.Text = "Zapisz";
                else
                {
                    EditWorker?.Invoke(this, item.Id);
                    EditButton.Text = "Edytuj";
                }
            }
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            EditButton.Text = "Edytuj";
            saveFileDialog1.Filter = "Plik XML (.xml)|.xml";
            saveFileDialog1.Title = "Wybierz miejsce zapisu pliku XML";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Użytkownik wybrał miejsce zapisu, więc możesz wyeksportować dane do pliku XML
                string path = saveFileDialog1.FileName;
                Export?.Invoke(this, path);
            }
        }

        private void ImportButton_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            EditButton.Text = "Edytuj";
            openFileDialog1.Filter = "Plik XML (*.xml)| *.xml";
            openFileDialog1.Title = "Wybierz plik XML do otwarcia";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Użytkownik wybrał plik do otwarcia, więc możesz wczytać dane z pliku XML
                string path = openFileDialog1.FileName;
                Import?.Invoke(this, path);
            }
        }


        //wlasciwosci do przekazania
        public Worker GetWorker()
        {
            //ktory radio zostal wybrany
            string contractChoice;
            if (radio1.Checked) contractChoice = radio1.Text;
            else if (radio2.Checked) contractChoice = radio2.Text;
            else contractChoice = radio3.Text;
            //zwrocenie obiektu
            return new Worker
            {
                Name = name_textBox.Text,
                Surname = surname_textBox.Text,
                BirthDate = birthDate_picker.Value,
                Salary = Decimal.ToInt32(salary_box.Value),
                Position = postion_selectBox.Text,
                ContractType = contractChoice
            };
        }

        //metody wyswietlajace
        public void ShowWorkersList(List <Worker> workers)
        {
            workersList.Items.Clear();
            workersList.Items.AddRange(workers.Select(w => new { Id = w.Id, Text = w.Name+" "+w.Surname+", " + w.BirthDate.ToShortDateString() +", "+ w.Position + ", " + w.Salary + "PLN, " + w.ContractType }).ToArray());
        }
        public void IsError()
        {
            errorProvider1.SetError(groupBox1, "Niepoprawne dane!");
        }

        public void PromptCorrect()
        {
            MessageBox.Show("Pomyślnie wyeksportowano do pliku");
        }

        public void UseSelectedWorker(Worker worker)
        {
            try
            {
                name_textBox.Text = worker.Name;
                surname_textBox.Text = worker.Surname;
                birthDate_picker.Value = worker.BirthDate;
                salary_box.Value = worker.Salary;
                postion_selectBox.Text = worker.Position;
                if (worker.ContractType == "umowa na czas nieokreślony") radio1.Checked = true;
                else if (worker.ContractType == "umowa na czas określony") radio2.Checked = true;
                else radio3.Checked = true;
            }
            catch(Exception ex)
            {
                DeleteWorker?.Invoke(this, worker.Id);
                errorProvider1.SetError(groupBox1, "Uszkodzony rekord!");
            }
        }

  
    }
}
