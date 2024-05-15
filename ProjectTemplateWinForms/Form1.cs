namespace ProjectTemplateWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Add code below to complete the implementation to populate the listBox
            // by reading the employee.csv file into a List of PaySlip objects, then binding this to the ListBox.
            // CSV file format: <employee ID>, <first name>, <last name>, <hourly rate>,<taxthreshold>
                        
            //CHANGE THIS TO YOUR FILE HELEN
            var fileName = @"C:\Users\User\source\repos\ProjectTemplateWinForms\ProjectTemplateWinForms\employee.csv";


            List<CsvMap> importedRecords = CsvImporter.ImportSomeRecords(fileName);

            dgEmpData.DataSource = importedRecords;

        }

        private void buttonCaclulate(object sender, EventArgs e)
        {
            // Add code below to complete the implementation to populate the
            // payment summary (textBox2) using the PaySlip and PayCalculatorNoThreshold
            // and PayCalculatorWithThresholds classes object and methods.
            MessageBox.Show("Calc Clicked");

        }

        private void buttonSave(object sender, EventArgs e)
        {
            // Add code below to complete the implementation for saving the
            // calculated payment data into a csv file.
            // File naming convention: Pay_<full name>_<datetimenow>.csv
            // Data fields expected - EmployeeId, Full Name, Hours Worked, Hourly Rate, Tax Threshold, Gross Pay, Tax, Net Pay, Superannuation
            MessageBox.Show("Save Clicked");
        }
    }
}
