using DXF;

namespace CalculateDXFs
{
    public partial class MainForm : Form
    {
        List<Part> parts;
        public MainForm()
        {
            InitializeComponent();
        }

        private void calculatePartsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Multiselect= true;
            openFileDialog1.Filter = "DXF-files(*.dxf)|*.dxf";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var calc = new CalculatePart();
                parts = new List<Part>();

                foreach (string path in openFileDialog1.FileNames)
                {
                    parts.Add(new Part(path) {Area = calc.GetAreaPart(path) });
                }
            }
            dataGridViewMainForm.DataSource = parts;
        }
    }
}