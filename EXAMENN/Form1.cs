using System.Windows.Forms;

namespace EXAMENN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnabrir_Click(object sender, EventArgs e)
        {
            DialogResult resultadoDialogo;
            resultadoDialogo = openFileDialog1.ShowDialog();

            if (resultadoDialogo==DialogResult.OK)
            {
                string rutaarchivo = openFileDialog1.FileName;
                string delimitador = ",";
                string[] lineasarchivo = File.ReadAllLines(rutaarchivo);

                List<string[]> registros = new List<string[]>();

                foreach (string linea in lineasarchivo)
                {
                    registros.Add(linea.Split(delimitador));
                }
                List<string> listaedades = new List<string>();
                List<string> listasexo = new List<string>();

                foreach (string[]registro in registros)
                {
                    string fechanac = registro[0].Substring(4, 6);
                    string sexo = registro[0].Substring(10, 1);

                    DateTime fechanacimiento = DateTime.ParseExact(fechanac, "yyMMdd", null);
                    DateTime fechaactual = DateTime.Now;

                    int anios = fechaactual.Year - fechanacimiento.Year;
                    int meses = fechaactual.Month - fechanacimiento.Month;
                    int dias = fechaactual.Day - fechanacimiento.Day;

                    if (fechaactual.Year < fechanacimiento.Year)
                    {
                        anios--;
                        meses += 12;
                    }
                    if (fechaactual.Month < fechanacimiento.Month)
                    {
                        meses--;
                        dias += DateTime.DaysInMonth(fechaactual.Year, fechaactual.Month - 1);

                    }
                    string sexocompleto = sexo == "H" ? "HOMBRE" : "MUJER";

                    listaedades.Add(anios.ToString());
                    listasexo.Add(sexocompleto);

                }
                for (int i=0;i<registros.Count; i++)
                {
                    dtgview.Rows.Add(registros[i]);
                    dtgview.Rows[i].Cells[2].Value = listaedades[i];
                    dtgview.Rows[i].Cells[3].Value = listasexo[i];
                }
            }

 

                }
            }
        }
    
            
        
