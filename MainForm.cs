using System.ComponentModel.Design.Serialization;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace SplitTheDiff
{
    public partial class MainForm : Form
    {
        private static readonly Keys[] disabledKeys = [Keys.Decimal, Keys.Enter, Keys.Oemcomma, Keys.OemMinus, Keys.OemPeriod, Keys.Subtract];

        #region Public

        public MainForm()
        {
            InitializeComponent();
        }

        #endregion Public

        #region Private

        #region Event Handlers

        private void MainForm_Load(object sender, EventArgs e)
        {
            numericUpDown1.SelectAll();

            alwaysOnTopCheckBox.Checked = Properties.Settings.Default.AlwaysOnTop;
            setTopMost();
        }
        private void NumericUpDown_KeyDown(object sender, KeyEventArgs e)
        {
            if (disabledKeys.Contains(e.KeyCode))
                e.SuppressKeyPress = true;
        }

        private void NumericUpDown_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
                return;

            var numericUpDown = (sender == numericUpDown1) ? numericUpDown2 : numericUpDown1;

            numericUpDown.SelectAll();
        }

        private void NumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            var diff = Math.Abs(numericUpDown1.Value - numericUpDown2.Value) / (decimal)2;
            diff += Math.Min(numericUpDown1.Value, numericUpDown2.Value);
            resultLabel.Text = diff.ToString();
        }

        private void alwaysOnTopCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            setTopMost();

            Properties.Settings.Default.AlwaysOnTop = alwaysOnTopCheckBox.Checked;
            Properties.Settings.Default.Save();
        }

        #endregion Event Handlers

        private void setTopMost()
        {
            TopMost = alwaysOnTopCheckBox.Checked;
        }

        #endregion Private
    }

    public static class NumericUpDownExtensions
	{
		public static void SelectAll(this NumericUpDown numericUpDown)
		{
			numericUpDown.Focus();
			numericUpDown.Select(0, numericUpDown.Value.ToString().Length);
		}
	}
}
