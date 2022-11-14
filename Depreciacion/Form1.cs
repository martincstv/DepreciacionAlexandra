using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Depreciacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Activo> listaActivo = new List<Activo>();
        int _anioVidaUtil;
        float _porcentajeResidual;

        private void vehiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox_TipoActivo.Text = "Vehículo";

        }

        private void inmuebleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox_TipoActivo.Text = "Inmueble";
        }


        private void button_Depreciar_Click(object sender, EventArgs e)
        {
            CargarValoresDelActivo();
        }

        private void CargarValoresDelActivo()
        {
            CalcularDepreciacionActivo();
        }


        private void CalcularDepreciacionActivo()
        {

            if (textBox_TipoActivo.Text == "Vehículo")
            {
                _anioVidaUtil = 5;
                _porcentajeResidual = 0.10f;

            }
            else
            {
                _anioVidaUtil = 20;
                _porcentajeResidual = 0.20f;
            }
            //Algoritmo
            var fechaCompra = dateTimePicker_FechaCompra.Value;
            var mesFechaCompra = fechaCompra.Month;
            var añoFechaCompra = fechaCompra.Year;
            var fechaDepreciacion = dateTimePicker_FechaDepreciacion.Value;
            var mesFechaDepreciacion = fechaDepreciacion.Month;
            var añoFechaDepreciacion = fechaDepreciacion.Year;
            float valorCompra = Convert.ToSingle(textBox_ValorCompra.Text);
            const int CANTIDAD_MESES_AÑO = 12;

            //
            var mesesParaTerminarElAño_FechaCompra = CANTIDAD_MESES_AÑO - mesFechaCompra;
            var mesesParaTerminarElAño_FechaDepreciacion = mesFechaDepreciacion;


            float depreciar = (((valorCompra - (valorCompra * _porcentajeResidual)) / _anioVidaUtil))/12;

            var contador = 1;
            var valorDepreciadoAcumulado = 0;
            var contadorAnios = 0;
            for (int i = añoFechaCompra; i <= añoFechaDepreciacion; i++)
            {
                float valorDepreciado;
                //n°, año, meses, valorCompra, valorDepreciado, valorDepreciadoAcumulado, valorotal
                if (i == añoFechaCompra)
                {
                    contadorAnios++;
                    listaActivo.Add(new Activo(contador++,i,mesesParaTerminarElAño_FechaCompra,valorCompra,valorDepreciado = (depreciar * mesesParaTerminarElAño_FechaCompra),valorDepreciadoAcumulado = (int)valorDepreciado,valorCompra - valorDepreciadoAcumulado));
                }
                if (i > añoFechaCompra && i < añoFechaDepreciacion)
                {
                    contadorAnios++;
                    listaActivo.Add(new Activo(contador++, i, CANTIDAD_MESES_AÑO, valorCompra, (contadorAnios <= _anioVidaUtil)? (depreciar * CANTIDAD_MESES_AÑO) : 0, valorDepreciadoAcumulado += (int)(depreciar * CANTIDAD_MESES_AÑO), ((valorCompra - valorDepreciadoAcumulado) < (valorCompra * _porcentajeResidual)) ? (valorCompra * _porcentajeResidual) : (valorCompra - valorDepreciadoAcumulado))); ;
                }
                if (i==añoFechaDepreciacion)
                {
                    contadorAnios++;
                    listaActivo.Add(new Activo(contador++,i, mesesParaTerminarElAño_FechaDepreciacion, valorCompra, (contadorAnios <= _anioVidaUtil)? (depreciar * mesesParaTerminarElAño_FechaDepreciacion) : 0, valorDepreciadoAcumulado += (int)(depreciar * mesesParaTerminarElAño_FechaDepreciacion), ((valorCompra - valorDepreciadoAcumulado) < (valorCompra * _porcentajeResidual)) ? (valorCompra * _porcentajeResidual) : (valorCompra - valorDepreciadoAcumulado)));
                }

            }

            dataGridView_Depreciacion.DataSource = null;
            dataGridView_Depreciacion.DataSource = listaActivo;
        }


        private void button_limpiar_Click(object sender, EventArgs e)
        {
            limpiarFormulario();

        }

        private void limpiarFormulario()
        {
            textBox_TipoActivo.Text = "";
            textBox_ValorCompra.Text = "";
            dataGridView_Depreciacion.DataSource = "";
            dateTimePicker_FechaCompra.Text = "";
            dateTimePicker_FechaDepreciacion.Text = "";
        }
    }
}
