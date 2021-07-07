using System;
using System.Reflection;
using System.Windows.Forms;
using SecureCommunicationComponent;

namespace PoliceDispatcherClient
{
    public partial class DispatcherForm : Form
    {
        public DispatcherForm()
        {
            InitializeComponent();
        }

        private void DispatcherForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCall_Click(object sender, EventArgs e)
        {
            Communicator comm = new Communicator();
            MessageBox.Show(comm.SendAlert(tbOfficer.Text, "Hello, Officer"));
        }

    }
}
