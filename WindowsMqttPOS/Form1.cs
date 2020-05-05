using System;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;
using static WindowsMqttPOS.ApiPayment;

namespace WindowsMqttPOS
{

    
    public partial class formPayment : Form
    {
        MqttClient client;
        string clientId;
        delegate void SetTextCallback(string text);
        public formPayment()
        {
            InitializeComponent();
        }

        private void EventPublished(Object sender, MqttMsgPublishEventArgs e)
        {
            try
            {
                SetText("*** Received Message");
                SetText("*** Topic: " + e.Topic);
                SetText("*** Message: " + Encoding.UTF8.GetString(e.Message));
                SetText("");
                MessageBox.Show("*** Payment Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void SetText(string text)
        {
            if (listBox1.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                Invoke(d, new object[] { text });
            }
            else
            {
                listBox1.Items.Add(text);
            }
        }

        private void subcribe(string topic)
        {
            if (topic != "")
            {
                // subscribe to the topic with QoS 2
                client.Subscribe(new string[] { topic }, new byte[] { 2 });   // we need arrays as parameters because we can subscribe to different topics with one call
                //txtReceived.Text = "";
            }
            else
            {
                //System.Windows.MessageBox.Show("You have to enter a topic to subscribe!");
            }
        }

        private void publish(string topic, string message)
        {
            if (topic != "")
            {
                // publish a message with QoS 2
                client.Publish(topic, Encoding.UTF8.GetBytes(message), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, true);
            }
            else
            {
                //System.Windows.MessageBox.Show("You have to enter a topic to publish!");
            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            try {
                string BrokerAddress = "mqtt.eclipse.org";
                client = new MqttClient(BrokerAddress);
                // use a unique id as client id, each time we start the application
                clientId = Guid.NewGuid().ToString();
                client.Connect(clientId);
                listBox1.Items.Add("* Client connected");
                //subcribe("/ReqPOS/");
                client.MqttMsgPublishReceived += new MqttClient.MqttMsgPublishEventHandler(EventPublished);
            } catch(Exception ex) {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void RbCreditDebet_CheckedChanged(object sender, EventArgs e)
        {
            gbEwallet.Visible = false;
        }

        private async void BtnPayment_Click(object sender, EventArgs e)
        {
            String paymentMethod = null;
            if (rbCreditDebet.Checked == true)
            {
                paymentMethod = "CARD-DEBIT";
            }
            else if (rbCreditCard.Checked == true)
            {
                paymentMethod = "CARD";
            }
            else if (rbEwallet.Checked == true)
            {
                
                if (rbOvo.Checked == true)
                {
                    paymentMethod = "Ewallet-Ovo";
                }
                else if (rbGopay.Checked == true)
                {
                    paymentMethod = "Ewallet-Gopay";
                }
                else if (rbDana.Checked == true)
                {
                    paymentMethod = "Ewallet-Dana";
                }
                else if (rbLinkAja.Checked == true)
                {
                    paymentMethod = "Ewallet-LinkAja";
                }
            }
            subcribe("/ReqPOS/");
            publish("/PubPOS/", paymentMethod+" "+txtAmount.Text);
            //MessageBox.Show("Ammount: "+txtAmount.Text+" Method Payment: "+paymentMethod);
            try
            {
                btnPayment.Enabled = false;
                pbPayment.Visible = true;
                pbPayment.Style = ProgressBarStyle.Marquee;
                PaymentResponse resp = await PostPaymentAsync("1",paymentMethod,"112",Int32.Parse(txtAmount.Text));
                MessageBox.Show(resp.status);
                pbPayment.Visible = false;
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
            return;
        }

        private async Task<PaymentResponse> PostPaymentAsync(string posId, 
            string trMethod, 
            string trNo, 
            int trAmount)
        {
            PaymentRequest req = new PaymentRequest
            {
                posId = posId,
                trMethod = trMethod,
                trNo = trNo,
                trAmount = trAmount
            };
            PaymentResponse response = await CreatePayment(req);
            return response;
            
        }

        private void GbEwallet_Enter(object sender, EventArgs e)
        {
            
        }

        private void RbEwallet_CheckedChanged(object sender, EventArgs e)
        {
            gbEwallet.Visible = true;
        }

        private void RbCreditCard_CheckedChanged(object sender, EventArgs e)
        {
            gbEwallet.Visible = false;
        }
    }
}
