namespace MVC_Learn2
{
    public partial class Form1 : Form
    {
        private Controller controller;

        private double _speed, _time, _distance;
        private bool _safe;

        public Form1()
        {
            InitializeComponent();
            Model _model = new();
            _model.modelHndl += SetResult;

            controller = new(_model);
        }

        public void SetResult(double result)
        {
            if (_safe)
            {
                _distance = result;
                resultTextBox.Text = _distance.ToString();
            }
            else
                resultTextBox.Text = "Ошибка";

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void speedTextBox_TextChanged(object sender, EventArgs e)
        {
            InitAndCheckValue(ref _speed, speedTextBox);
        }

        private void timeTextBox_TextChanged(object sender, EventArgs e)
        {
            InitAndCheckValue(ref _time, timeTextBox);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            controller.Calculate(_speed, _time);
        }

        void InitAndCheckValue(ref double value, TextBox textBox)
        {
            try
            {
                value = double.Parse(textBox.Text);
                _safe = true;
            }
            catch (FormatException)
            {
                _safe = false;
            }
        }
    }
}