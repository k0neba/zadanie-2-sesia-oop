namespace UtilityCompanyApp
{
    public partial class Form1 : Form
    {
        private UtilityCompany utilityCompany;
        public Form1()
        {
            InitializeComponent();
            utilityCompany = new UtilityCompany();
        }

        private void txtServiceName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRate_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblServiceName_Click(object sender, EventArgs e)
        {

        }

        private void lblRate_Click(object sender, EventArgs e)
        {

        }

        private void lstTariffs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblResidentName_Click(object sender, EventArgs e)
        {

        }

        private void txtResidentName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddResident_Click(object sender, EventArgs e)
        {
            string residentName = txtResidentName.Text;
            utilityCompany.AddResident(residentName);
            lstResidents.Items.Add(residentName);
            cmbResidents.Items.Add(residentName);
        }

        private void lstResidents_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddTariff_Click(object sender, EventArgs e)
        {
            string serviceName = txtServiceName.Text;
            double rate;
            if (double.TryParse(txtRate.Text, out rate))
            {
                utilityCompany.AddTariff(serviceName, rate);
                lstTariffs.Items.Add($"{serviceName}: {rate} ���");
                cmbServices.Items.Add(serviceName);
            }
            else
            {
                MessageBox.Show("������� ������ ������.");
            }
        }

        private void cmbResidents_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbServices_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblQuantity_Click(object sender, EventArgs e)
        {

        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddConsumedService_Click(object sender, EventArgs e)
        {
            string residentName = cmbResidents.SelectedItem.ToString();
            string serviceName = cmbServices.SelectedItem.ToString();
            double quantity;

            if (double.TryParse(txtQuantity.Text, out quantity))
            {
                utilityCompany.AddConsumedServiceForResident(residentName, serviceName, quantity);
                MessageBox.Show("������� ������� ������.");
            }
            else
            {
                MessageBox.Show("������� ������ �������.");
            }
        }

        private void btnCalculateTotalForResident_Click(object sender, EventArgs e)
        {
            string name = cmbResidents.SelectedItem.ToString();
            double totalAmount = utilityCompany.GetResidentTotalAmount(name);
            lblResidentTotal.Text = $"���� ��� {name}: {totalAmount} ���";
        }

        private void btnCalculateTotalCost_Click(object sender, EventArgs e)
        {
            double totalCost = utilityCompany.GetTotalCostOfAllServices();
            lblTotalCost.Text = $"�������� �������: {totalCost} ���";
        }


        private void lblResidentTotal_Click(object sender, EventArgs e)
        {

        }

        private void lblTotalCost_Click(object sender, EventArgs e)
        {

        }

        // ���������� � XML
        private void btnSaveToXml_Click(object sender, EventArgs e)
        {
            utilityCompany.SaveToXml("utilityCompanyData.xml");
            MessageBox.Show("��� ��������� � XML.");
        }


        // ������������ � XML
        private void btnLoadFromXml_Click(object sender, EventArgs e)
        {
            string fileName = "utilityCompanyData.xml";

            if (File.Exists(fileName)) // ����������, �� ���� ����
            {
                utilityCompany = UtilityCompany.LoadFromXml(fileName);
                MessageBox.Show("��� ����������� � XML.");

                
                lstTariffs.Items.Clear();
                lstResidents.Items.Clear();
                cmbResidents.Items.Clear();
                cmbServices.Items.Clear();

                
                foreach (var tariff in utilityCompany.Tariffs)
                {
                    
                    lstTariffs.Items.Add($"{tariff.Value.ServiceName}: {tariff.Value.Rate} ���");
                    cmbServices.Items.Add(tariff.Value.ServiceName);
                }


                
                foreach (var resident in utilityCompany.Residents)
                {
                    lstResidents.Items.Add(resident.Name);
                    cmbResidents.Items.Add(resident.Name);
                }
            }
            else
            {
                MessageBox.Show("���� �� ��������.");
            }
        }
    }
}
