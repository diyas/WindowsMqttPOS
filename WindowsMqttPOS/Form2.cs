using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsMqttPOS
{
    public partial class FormConfig : Form
    {
        JsonFileCrud jsonFile;
        public FormConfig()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            jsonFile = new JsonFileCrud();
            string deviceId = jsonFile.ReadJson("client").GetValue("deviceId").ToString();
            string deviceDesc = jsonFile.ReadJson("client").GetValue("description").ToString();
            string username = jsonFile.ReadJson("login").GetValue("username").ToString();
            string password = jsonFile.ReadJson("login").GetValue("password").ToString();
            string baseUrl = jsonFile.ReadJson("resource").GetValue("baseUrl").ToString();
            string mqttHost = jsonFile.ReadJson("mqtt").GetValue("host").ToString();
            string mqttPort = jsonFile.ReadJson("mqtt").GetValue("port").ToString();
            txtUserName.Text = username;
            txtPassword.Text = password;
            txtPassword.PasswordChar = '*';
            txtDeviceId.Text = deviceId;
            txtDeviceDescription.Text = deviceDesc;
            txtBaseUrl.Text = baseUrl;
            txtMqttHost.Text = mqttHost +":"+ mqttPort;
        }


        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            jsonFile.UpdateConfig(
                txtDeviceId.Text, 
                txtDeviceDescription.Text,
                txtUserName.Text,
                txtPassword.Text
                );
            this.Close();
        }
    }
}
