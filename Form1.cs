using System.Diagnostics;

namespace Launch_Tote_Verification
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string computerName = Environment.MachineName;
            string portValue = textBox1.Text.Trim();
            string defaultUrl = "http://localhost:8080";

            if (string.Equals(portValue, defaultUrl, StringComparison.OrdinalIgnoreCase))
            {
                defaultUrl += "?comp_name=" + computerName;
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = defaultUrl,
                    UseShellExecute = true
                };
                Process.Start(psi);
            }
            else
            {
                string url = portValue + "?comp_name=" + computerName;
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                };
                Process.Start(psi);
            }
        }
    }
}