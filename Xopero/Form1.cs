using System;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.Configuration;
using Xopero.Models;
using GithubClient;
using GithubClient.Models;
using System.IO;
using Newtonsoft.Json;

namespace Xopero
{
    public partial class Form1 : Form
    {
        private readonly IGithubClient _githubClient;
        private readonly RepositorySettings _settings;
        private GroupBox groupBox1;
        private RadioButton selectedrb;
        private Button getSelectedRB;
        private string cachedJsonData;
        public Form1(IGithubClient githubClient)
        {
            InitializeComponent();
            _githubClient = githubClient;
            _settings = Program.Configuration.GetSection("Github").Get<RepositorySettings>();
        }

        void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;

            if (rb == null)
            {
                MessageBox.Show("Sender is not a RadioButton");
                return;
            }
            if (rb.Name == "rdo2" || rb.Name == "rdo3")
                textBox1.ReadOnly = false;

            if (rb.Checked)
            {
                selectedrb = rb;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            selectedrb = rdo1;
        }

        private async void getSelectedRB_Click(object sender, EventArgs e)
        {
            string text = string.Empty;
            switch (selectedrb.Name)
            {
                case "rdo1":
                    text = await ExtractIssueData();
                    break;

                case "rdo2":
                    text = await CreateIssue();
                    break;

                case "rdo3":
                    text = await UpdateIssue();
                    break;

            }
            textBox1.Text = text;
        }

        private string ReadFromFile(string path)
        {
            try
            {
                string content;
                using (StreamReader r = new StreamReader(path))
                {
                    content = r.ReadToEnd();
                }
                return content;
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read: " +  e.Message);
                throw;
            }
        }

        private bool WriteToFile(string path)
        {
            try
            {
                using (StreamWriter outputFile = new StreamWriter(path))
                {
                    outputFile.Write(cachedJsonData);
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
                return false;
            }

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            cachedJsonData = ReadFromFile(_settings.DataToUploadPath);
            if (string.IsNullOrEmpty(cachedJsonData))
                textBox1.Text = "No data to send. Please make sure you have saved issue data.";
            else
            {
                textBox1.Text = await CreateIssue(true);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var operationResult = WriteToFile(_settings.DataToUploadPath);
            if (operationResult)
                textBox1.Text = "Successfully saved.";
            else
                textBox1.Text = "Saving operation failed. Please make sure you have executed extract operation before.";
        }

        private async Task<string> ExtractIssueData()
        {
            var response = await _githubClient.SendRequest<Issue>(HttpMethod.Get, _settings.GetIssuesEndpoint);
            if (response.TechnicalMessages.Any())
                return "Extract operation failed. " + string.Join(",", response.TechnicalMessages);
            else
            {
                cachedJsonData = JsonConvert.SerializeObject(response.Result.FirstOrDefault()) ?? "";
                return string.Join("\r\n", response.Result.Select(x => x.Title));
            }
        }

        private async Task<string> CreateIssue(bool useCachedData = false)
        {
            var text = textBox1.Text;
            var response = useCachedData ? await _githubClient.SendRequest<Issue>(HttpMethod.Post, _settings.CreateIssueEndpoint, cachedJsonData)
                : await _githubClient.SendRequest<Issue>(HttpMethod.Post, _settings.CreateIssueEndpoint, text);
            if (!response.TechnicalMessages.Any())
                return response.Messages.FirstOrDefault();
            else
                return "Create operation failed. " + string.Join(",", response.TechnicalMessages);
        }

        private async Task<string> UpdateIssue()
        {
            var text = textBox1.Text;
            var response = await _githubClient.SendRequest<Issue>(new HttpMethod("PATCH"), _settings.UpdateIssueEndpoint, text);
            if (!response.TechnicalMessages.Any())
                return response.Messages.FirstOrDefault();
            else
                return "Update operation failed. " + string.Join(",", response.TechnicalMessages);
        }

        private async Task<string> CloseIssue()
        {
            var text = textBox1.Text;
            var response = await _githubClient.SendRequest<Issue>(HttpMethod.Put, _settings.CloseIssueEndpoint, text);
            if (!response.TechnicalMessages.Any())
                return response.Messages.FirstOrDefault();
            else
                return "Close operation failed. " + string.Join(",", response.TechnicalMessages);
        }
    } 
}