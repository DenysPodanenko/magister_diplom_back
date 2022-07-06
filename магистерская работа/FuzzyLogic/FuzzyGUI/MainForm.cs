using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FastColoredTextBoxNS;
using Fuzzy;

namespace FuzzyGUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        TextStyle magenta = new TextStyle(Brushes.Magenta, null, FontStyle.Regular);
        TextStyle navyBold = new TextStyle(Brushes.Navy, null, FontStyle.Bold);
        TextStyle navy = new TextStyle(Brushes.Green, null, FontStyle.Regular);

        private void tb_TextChanged(object sender, TextChangedEventArgs e)
        {
            var r = e.ChangedRange;
            r.ClearStyle(StyleIndex.All);

            r.SetStyle(navy, @"\S+:");
            r.SetStyle(navyBold, @"\[.+\]+");
            r.SetStyle(magenta, @"[\d\.\-]+");
            
        }

        private void btCalc_Click(object sender, EventArgs e)
        {
            var calculator = new Mamdani();
            //parse vars and rules
            Parser.Parse(calculator, tbVarsAndRules.Text);
            //parse var values
            var values = Parser.ParseVarValues(calculator, tbValues.Text);
            //calc
            var results = calculator.Calculate(values).ToArray();
            //output
            tbResult.Clear();
            for (int i = 0; i < calculator.OutputVariables.Count; i++)
            {
                tbResult.AppendText(calculator.OutputVariables[i].Name + ": " + results[i].ToString("0.00", CultureInfo.InvariantCulture) + "\r\n");
            }
        }
    }
}
