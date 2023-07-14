namespace form_app
{
    partial class WorkerView
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.EditButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.radio3 = new System.Windows.Forms.RadioButton();
            this.radio2 = new System.Windows.Forms.RadioButton();
            this.radio1 = new System.Windows.Forms.RadioButton();
            this.postion_selectBox = new System.Windows.Forms.ComboBox();
            this.salary_box = new System.Windows.Forms.NumericUpDown();
            this.birthDate_picker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.surname_textBox = new System.Windows.Forms.TextBox();
            this.name_textBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.workersList = new System.Windows.Forms.ListBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salary_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.EditButton);
            this.groupBox1.Controls.Add(this.deleteButton);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.radio3);
            this.groupBox1.Controls.Add(this.radio2);
            this.groupBox1.Controls.Add(this.radio1);
            this.groupBox1.Controls.Add(this.postion_selectBox);
            this.groupBox1.Controls.Add(this.salary_box);
            this.groupBox1.Controls.Add(this.birthDate_picker);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.surname_textBox);
            this.groupBox1.Controls.Add(this.name_textBox);
            this.groupBox1.Location = new System.Drawing.Point(33, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(574, 598);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dane pracownika";
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(298, 543);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(245, 35);
            this.EditButton.TabIndex = 16;
            this.EditButton.Text = "Edytuj";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(28, 543);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(245, 35);
            this.deleteButton.TabIndex = 15;
            this.deleteButton.Text = "Usuń";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteWorker_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 502);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(515, 35);
            this.button1.TabIndex = 14;
            this.button1.Text = "Dodaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // radio3
            // 
            this.radio3.AutoSize = true;
            this.radio3.Location = new System.Drawing.Point(167, 435);
            this.radio3.Name = "radio3";
            this.radio3.Size = new System.Drawing.Size(147, 24);
            this.radio3.TabIndex = 13;
            this.radio3.TabStop = true;
            this.radio3.Text = "umowa zlecenie";
            this.radio3.UseVisualStyleBackColor = true;
            // 
            // radio2
            // 
            this.radio2.AutoSize = true;
            this.radio2.Location = new System.Drawing.Point(167, 387);
            this.radio2.Name = "radio2";
            this.radio2.Size = new System.Drawing.Size(215, 24);
            this.radio2.TabIndex = 12;
            this.radio2.TabStop = true;
            this.radio2.Text = "umowa na czas określony";
            this.radio2.UseVisualStyleBackColor = true;
            // 
            // radio1
            // 
            this.radio1.AutoSize = true;
            this.radio1.Location = new System.Drawing.Point(167, 341);
            this.radio1.Name = "radio1";
            this.radio1.Size = new System.Drawing.Size(236, 24);
            this.radio1.TabIndex = 11;
            this.radio1.TabStop = true;
            this.radio1.Text = "umowa na czas nieokreślony";
            this.radio1.UseVisualStyleBackColor = true;
            // 
            // postion_selectBox
            // 
            this.postion_selectBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.postion_selectBox.FormattingEnabled = true;
            this.postion_selectBox.Items.AddRange(new object[] {
            "Tester",
            "Projektant",
            "Inżynier",
            "Młodszy programista",
            "Starszy programista"});
            this.postion_selectBox.Location = new System.Drawing.Point(167, 281);
            this.postion_selectBox.Name = "postion_selectBox";
            this.postion_selectBox.Size = new System.Drawing.Size(363, 28);
            this.postion_selectBox.TabIndex = 10;
            // 
            // salary_box
            // 
            this.salary_box.Location = new System.Drawing.Point(167, 223);
            this.salary_box.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.salary_box.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.salary_box.Name = "salary_box";
            this.salary_box.Size = new System.Drawing.Size(363, 26);
            this.salary_box.TabIndex = 9;
            this.salary_box.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // birthDate_picker
            // 
            this.birthDate_picker.Location = new System.Drawing.Point(167, 166);
            this.birthDate_picker.MaxDate = new System.DateTime(2009, 1, 1, 0, 0, 0, 0);
            this.birthDate_picker.MinDate = new System.DateTime(1940, 1, 1, 0, 0, 0, 0);
            this.birthDate_picker.Name = "birthDate_picker";
            this.birthDate_picker.Size = new System.Drawing.Size(363, 26);
            this.birthDate_picker.TabIndex = 8;
            this.birthDate_picker.Value = new System.DateTime(2009, 1, 1, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 343);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Rodzaj umowy:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Stanowisko:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Pensja:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Data urodzenia:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nazwisko:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Imię:";
            // 
            // surname_textBox
            // 
            this.surname_textBox.Location = new System.Drawing.Point(167, 106);
            this.surname_textBox.MaxLength = 35;
            this.surname_textBox.Name = "surname_textBox";
            this.surname_textBox.Size = new System.Drawing.Size(363, 26);
            this.surname_textBox.TabIndex = 1;
            // 
            // name_textBox
            // 
            this.name_textBox.Location = new System.Drawing.Point(167, 51);
            this.name_textBox.MaxLength = 35;
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.Size = new System.Drawing.Size(363, 26);
            this.name_textBox.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(61, 638);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(245, 44);
            this.button2.TabIndex = 1;
            this.button2.Text = "Zapisz";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(331, 638);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(245, 44);
            this.button3.TabIndex = 2;
            this.button3.Text = "Wczytaj";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.ImportButton_Click);
            // 
            // workersList
            // 
            this.workersList.DisplayMember = "Text";
            this.workersList.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.workersList.FormattingEnabled = true;
            this.workersList.HorizontalScrollbar = true;
            this.workersList.ItemHeight = 30;
            this.workersList.Location = new System.Drawing.Point(692, 54);
            this.workersList.Name = "workersList";
            this.workersList.Size = new System.Drawing.Size(883, 604);
            this.workersList.TabIndex = 3;
            this.workersList.Click += new System.EventHandler(this.WorkersList_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // WorkerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1621, 764);
            this.Controls.Add(this.workersList);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(1643, 820);
            this.MinimumSize = new System.Drawing.Size(1643, 820);
            this.Name = "WorkerView";
            this.Text = "Formularz";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salary_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox surname_textBox;
        private System.Windows.Forms.TextBox name_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radio3;
        private System.Windows.Forms.RadioButton radio2;
        private System.Windows.Forms.RadioButton radio1;
        private System.Windows.Forms.ComboBox postion_selectBox;
        private System.Windows.Forms.NumericUpDown salary_box;
        private System.Windows.Forms.DateTimePicker birthDate_picker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox workersList;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

