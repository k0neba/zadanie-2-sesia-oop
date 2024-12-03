namespace UtilityCompanyApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblServiceName = new Label();
            lblRate = new Label();
            txtServiceName = new TextBox();
            txtRate = new TextBox();
            btnAddTariff = new Button();
            lstTariffs = new ListBox();
            lblResidentName = new Label();
            txtResidentName = new TextBox();
            btnAddResident = new Button();
            lstResidents = new ListBox();
            cmbResidents = new ComboBox();
            cmbServices = new ComboBox();
            lblQuantity = new Label();
            txtQuantity = new TextBox();
            btnAddConsumedService = new Button();
            btnCalculateTotalForResident = new Button();
            btnCalculateTotalCost = new Button();
            lblResidentTotal = new Label();
            lblTotalCost = new Label();
            btnLoadFromXml = new Button();
            btnSaveToXml = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // lblServiceName
            // 
            lblServiceName.AutoSize = true;
            lblServiceName.Location = new Point(12, 29);
            lblServiceName.Name = "lblServiceName";
            lblServiceName.Size = new Size(87, 15);
            lblServiceName.TabIndex = 0;
            lblServiceName.Text = "Назва послуги";
            lblServiceName.Click += lblServiceName_Click;
            // 
            // lblRate
            // 
            lblRate.AutoSize = true;
            lblRate.Location = new Point(218, 29);
            lblRate.Name = "lblRate";
            lblRate.Size = new Size(46, 15);
            lblRate.TabIndex = 1;
            lblRate.Text = "Тариф ";
            lblRate.Click += lblRate_Click;
            // 
            // txtServiceName
            // 
            txtServiceName.Location = new Point(105, 26);
            txtServiceName.Name = "txtServiceName";
            txtServiceName.Size = new Size(100, 23);
            txtServiceName.TabIndex = 3;
            txtServiceName.TextChanged += txtServiceName_TextChanged;
            // 
            // txtRate
            // 
            txtRate.Location = new Point(281, 26);
            txtRate.Name = "txtRate";
            txtRate.Size = new Size(100, 23);
            txtRate.TabIndex = 4;
            txtRate.TextChanged += txtRate_TextChanged;
            // 
            // btnAddTariff
            // 
            btnAddTariff.Location = new Point(42, 187);
            btnAddTariff.Name = "btnAddTariff";
            btnAddTariff.Size = new Size(75, 23);
            btnAddTariff.TabIndex = 5;
            btnAddTariff.Text = "Додати тариф";
            btnAddTariff.UseVisualStyleBackColor = true;
            btnAddTariff.Click += btnAddTariff_Click;
            // 
            // lstTariffs
            // 
            lstTariffs.FormattingEnabled = true;
            lstTariffs.ItemHeight = 15;
            lstTariffs.Location = new Point(42, 78);
            lstTariffs.Name = "lstTariffs";
            lstTariffs.Size = new Size(369, 94);
            lstTariffs.TabIndex = 6;
            lstTariffs.SelectedIndexChanged += lstTariffs_SelectedIndexChanged;
            // 
            // lblResidentName
            // 
            lblResidentName.AutoSize = true;
            lblResidentName.Location = new Point(534, 29);
            lblResidentName.Name = "lblResidentName";
            lblResidentName.Size = new Size(92, 15);
            lblResidentName.TabIndex = 7;
            lblResidentName.Text = " Ім'я мешканця";
            lblResidentName.Click += lblResidentName_Click;
            // 
            // txtResidentName
            // 
            txtResidentName.Location = new Point(632, 26);
            txtResidentName.Name = "txtResidentName";
            txtResidentName.Size = new Size(141, 23);
            txtResidentName.TabIndex = 8;
            txtResidentName.TextChanged += txtResidentName_TextChanged;
            // 
            // btnAddResident
            // 
            btnAddResident.Location = new Point(790, 26);
            btnAddResident.Name = "btnAddResident";
            btnAddResident.Size = new Size(128, 23);
            btnAddResident.TabIndex = 9;
            btnAddResident.Text = "Додати мешканця";
            btnAddResident.UseVisualStyleBackColor = true;
            btnAddResident.Click += btnAddResident_Click;
            // 
            // lstResidents
            // 
            lstResidents.FormattingEnabled = true;
            lstResidents.ItemHeight = 15;
            lstResidents.Location = new Point(534, 78);
            lstResidents.Name = "lstResidents";
            lstResidents.Size = new Size(384, 94);
            lstResidents.TabIndex = 10;
            lstResidents.SelectedIndexChanged += lstResidents_SelectedIndexChanged;
            // 
            // cmbResidents
            // 
            cmbResidents.FormattingEnabled = true;
            cmbResidents.Location = new Point(12, 291);
            cmbResidents.Name = "cmbResidents";
            cmbResidents.Size = new Size(121, 23);
            cmbResidents.TabIndex = 11;
            cmbResidents.SelectedIndexChanged += cmbResidents_SelectedIndexChanged;
            // 
            // cmbServices
            // 
            cmbServices.FormattingEnabled = true;
            cmbServices.Location = new Point(171, 291);
            cmbServices.Name = "cmbServices";
            cmbServices.Size = new Size(121, 23);
            cmbServices.TabIndex = 12;
            cmbServices.SelectedIndexChanged += cmbServices_SelectedIndexChanged;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(12, 337);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(157, 15);
            lblQuantity.TabIndex = 13;
            lblQuantity.Text = "Кількість наданих  послуги ";
            lblQuantity.Click += lblQuantity_Click;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(192, 334);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(100, 23);
            txtQuantity.TabIndex = 14;
            txtQuantity.TextChanged += txtQuantity_TextChanged;
            // 
            // btnAddConsumedService
            // 
            btnAddConsumedService.Location = new Point(130, 373);
            btnAddConsumedService.Name = "btnAddConsumedService";
            btnAddConsumedService.Size = new Size(162, 23);
            btnAddConsumedService.TabIndex = 15;
            btnAddConsumedService.Text = " Додати спожиту послугу";
            btnAddConsumedService.UseVisualStyleBackColor = true;
            btnAddConsumedService.Click += btnAddConsumedService_Click;
            // 
            // btnCalculateTotalForResident
            // 
            btnCalculateTotalForResident.Location = new Point(412, 290);
            btnCalculateTotalForResident.Name = "btnCalculateTotalForResident";
            btnCalculateTotalForResident.Size = new Size(114, 23);
            btnCalculateTotalForResident.TabIndex = 16;
            btnCalculateTotalForResident.Text = "Обчислити суму";
            btnCalculateTotalForResident.UseVisualStyleBackColor = true;
            btnCalculateTotalForResident.Click += btnCalculateTotalForResident_Click;
            // 
            // btnCalculateTotalCost
            // 
            btnCalculateTotalCost.Location = new Point(412, 329);
            btnCalculateTotalCost.Name = "btnCalculateTotalCost";
            btnCalculateTotalCost.Size = new Size(228, 23);
            btnCalculateTotalCost.TabIndex = 17;
            btnCalculateTotalCost.Text = "Обчислити загальну вартість послуг";
            btnCalculateTotalCost.UseVisualStyleBackColor = true;
            btnCalculateTotalCost.Click += btnCalculateTotalCost_Click;
            // 
            // lblResidentTotal
            // 
            lblResidentTotal.AutoSize = true;
            lblResidentTotal.Location = new Point(412, 381);
            lblResidentTotal.Name = "lblResidentTotal";
            lblResidentTotal.Size = new Size(179, 15);
            lblResidentTotal.TabIndex = 18;
            lblResidentTotal.Text = "Виведення суми для мешканця";
            lblResidentTotal.Click += lblResidentTotal_Click;
            // 
            // lblTotalCost
            // 
            lblTotalCost.AutoSize = true;
            lblTotalCost.FlatStyle = FlatStyle.Flat;
            lblTotalCost.Location = new Point(412, 410);
            lblTotalCost.Name = "lblTotalCost";
            lblTotalCost.Size = new Size(171, 15);
            lblTotalCost.TabIndex = 19;
            lblTotalCost.Text = " Виведення загальної вартості";
            lblTotalCost.Click += lblTotalCost_Click;
            // 
            // btnLoadFromXml
            // 
            btnLoadFromXml.Location = new Point(534, 500);
            btnLoadFromXml.Name = "btnLoadFromXml";
            btnLoadFromXml.Size = new Size(170, 23);
            btnLoadFromXml.TabIndex = 20;
            btnLoadFromXml.Text = " Завантажити дані з XML";
            btnLoadFromXml.UseVisualStyleBackColor = true;
            btnLoadFromXml.Click += btnLoadFromXml_Click;
            // 
            // btnSaveToXml
            // 
            btnSaveToXml.Location = new Point(263, 500);
            btnSaveToXml.Name = "btnSaveToXml";
            btnSaveToXml.Size = new Size(148, 23);
            btnSaveToXml.TabIndex = 21;
            btnSaveToXml.Text = "Зберегти дані в XML";
            btnSaveToXml.UseVisualStyleBackColor = true;
            btnSaveToXml.Click += btnSaveToXml_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 273);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 22;
            label1.Text = "Мешканець";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(211, 273);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 23;
            label2.Text = "Послуга";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(979, 535);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSaveToXml);
            Controls.Add(btnLoadFromXml);
            Controls.Add(lblTotalCost);
            Controls.Add(lblResidentTotal);
            Controls.Add(btnCalculateTotalCost);
            Controls.Add(btnCalculateTotalForResident);
            Controls.Add(btnAddConsumedService);
            Controls.Add(txtQuantity);
            Controls.Add(lblQuantity);
            Controls.Add(cmbServices);
            Controls.Add(cmbResidents);
            Controls.Add(lstResidents);
            Controls.Add(btnAddResident);
            Controls.Add(txtResidentName);
            Controls.Add(lblResidentName);
            Controls.Add(lstTariffs);
            Controls.Add(btnAddTariff);
            Controls.Add(txtRate);
            Controls.Add(txtServiceName);
            Controls.Add(lblRate);
            Controls.Add(lblServiceName);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblServiceName;
        private Label lblRate;
        private TextBox txtServiceName;
        private TextBox txtRate;
        private Button btnAddTariff;
        private ListBox lstTariffs;
        private Label lblResidentName;
        private TextBox txtResidentName;
        private Button btnAddResident;
        private ListBox lstResidents;
        private ComboBox cmbResidents;
        private ComboBox cmbServices;
        private Label lblQuantity;
        private TextBox txtQuantity;
        private Button btnAddConsumedService;
        private Button btnCalculateTotalForResident;
        private Button btnCalculateTotalCost;
        private Label lblResidentTotal;
        private Label lblTotalCost;
        private Button btnLoadFromXml;
        private Button btnSaveToXml;
        private Label label1;
        private Label label2;
    }
}
