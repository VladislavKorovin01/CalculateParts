using DXF;

namespace CalculateDXFs
{
    public partial class PartForm : Form
    {
        public Part _part;
        public PartForm()
        {
            InitializeComponent();
        }

        public PartForm(Part part) : this()
        {
            _part = part;
            if (_part != null)
            {
                textBoxNamePart.Text = _part.Name;
                textBoxMaterialName.Text = _part.Material;
                textBoxThikness.Text = _part.Thikness.ToString();
                textBoxArea.Text = _part.Area.ToString();
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            _part.Name = textBoxNamePart.Text;
            _part.Material = textBoxMaterialName.Text;
            _part.Thikness = Double.Parse(textBoxThikness.Text);
            _part.Area = Double.Parse(textBoxArea.Text);
        }
    }
}
