using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static pryBlaiotta.clsLocal;

namespace pryBlaiotta
{
    public partial class Form1 : Form
    {
        private List<LocalDeTeatro> localesDeTeatro;


        public Form1()
        {
            InitializeComponent();
            InicializarLocalesDeTeatro();
            MostrarReservasEnGrillas();
        }

        private void InicializarLocalesDeTeatro()
        {
            localesDeTeatro = new List<LocalDeTeatro>
        {
            new LocalDeTeatro("Quenaken"),
            new LocalDeTeatro("Onas"),
            new LocalDeTeatro("Tobas")
        };

            // Ejemplo de cómo agregar una reserva al primer local de teatro
            localesDeTeatro[0].Reservas.Add(new Reserva { Cliente = "Juan", Fila = 1, Columna = 2 });
        }

        private void MostrarReservasEnGrillas()
        {
            // Limpiar las grillas antes de mostrar nuevas reservas
            dataGridViewQuenaken.Rows.Clear();
            dataGridViewOnas.Rows.Clear();
            dataGridViewTobas.Rows.Clear();

            // Iterar sobre cada local de teatro y mostrar sus reservas en la grilla correspondiente
            foreach (var local in localesDeTeatro)
            {
                DataGridView dataGridViewLocal = null;

                // Seleccionar la grilla correspondiente al local de teatro
                switch (local.Nombre)
                {
                    case "Quenaken":
                        dataGridViewLocal = dataGridViewQuenaken;
                        break;
                    case "Onas":
                        dataGridViewLocal = dataGridViewOnas;
                        break;
                    case "Tobas":
                        dataGridViewLocal = dataGridViewTobas;
                        break;
                        // Puedes agregar más casos según sea necesario
                }
                if (dataGridViewLocal.Columns.Count == 0)
                {
                    dataGridViewLocal.Columns.Add("Cliente", "Cliente");
                    dataGridViewLocal.Columns.Add("Fila", "Fila");
                    dataGridViewLocal.Columns.Add("Columna", "Columna");
                }

                // Mostrar las reservas del local en la grilla correspondiente
                foreach (var reserva in local.Reservas)
                {
                    dataGridViewLocal.Rows.Add(reserva.Cliente, reserva.Fila, reserva.Columna);
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarReserva_Click(object sender, EventArgs e)
        {

        }
    }
}