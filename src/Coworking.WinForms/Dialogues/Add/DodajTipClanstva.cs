using Coworking.Data.Providers;
using Coworking.Domain.Entities;
using System;
using System.Globalization;

namespace Coworking.WinForms.Dialogues
{

    public partial class DodajTipClanstva : Form
    {
        IDataBase singleton;
        public DodajTipClanstva()
        {
            InitializeComponent();
            singleton = DataBaseSingleton.vratiInstancu();
        }

        private void conferenceCheckBox_CheckedChanged()
        {
            if (conferenceCheckBox.Checked)
                conferenceTimeNumeric.Visible = conferenceTimeLabel.Visible = true;
            else
                conferenceTimeNumeric.Visible = conferenceTimeLabel.Visible = false;
        }

        private void addMembershipButton_Click(object sender, EventArgs e)
        {
            var name = nameTextBox.textBox.Text;
            var price = float.Parse(priceTextBox.textBox.Text, CultureInfo.InvariantCulture);
            var monthlyNumeric = (int)monthlyNumeric1.Value;
            var duration = (int)durationNumeric.Value;
            var conferenceTime = conferenceCheckBox.Checked == true ? true : false;
            var maxHours = 0;
            if (conferenceTime)
            {
                maxHours = (int)conferenceTimeNumeric.Value;
            }

            singleton.dodajTipClanstva(new TipClanstva(name, price, monthlyNumeric, duration, maxHours, conferenceTime));
        }

    }
}
