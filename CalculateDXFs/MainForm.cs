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
            dataGridViewMainForm.Rows.Clear();

            openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Multiselect= true;
            openFileDialog1.Filter = "DXF-files(*.dxf)|*.dxf";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var calc = new Calculate();
                parts = new List<Part>();

                foreach (string path in openFileDialog1.FileNames)
                {
                    parts.Add(new Part(path) {Area = calc.GetAreaPart(path) });
                }
            }
            dataGridViewMainForm.DataSource = parts;
        }

        private void dataGridViewMainForm_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

           var index = e.RowIndex;

            //MessageBox.Show(index.ToString());

            var part = parts[index];
            var formPart = new PartForm(part);
            Hide();
            formPart.ShowDialog();
            Show();

            parts[index] = formPart._part;

            //MessageBox.Show($"Name: {part.Name} \n Area: {part.Area}");
        }
    }
}