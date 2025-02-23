using AndreysGym.Entidades;
using AndreysGym.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AndreysGym.Forms
{
    public partial class FrmFrequencia : Form
    {
        private List<Frequencia> _frequencias;
        private static Usuario _usuario;
        private static FrmFrequencia _instance;
        private FrmFrequencia()
        {            
            InitializeComponent();
            _frequencias = FrequenciaRepository.FindByUsuario(_usuario);
            foreach (var frequencia in _frequencias)
            {
                mntFrequencia.AddBoldedDate(frequencia.Entrada);
            }
        }


        public static FrmFrequencia GetInstance(Usuario usuario)
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _usuario = usuario;
                _instance = new FrmFrequencia();
            }
            return _instance;
        }
        public static FrmFrequencia GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new FrmFrequencia();
            }
            return _instance;
        }

        private void mntFrequencia_DateSelected(object sender, DateRangeEventArgs e)
        {
            DateTime dataSelecionada = e.Start.Date;

            var frequenciasDoDia = _frequencias.Where(f => f.Entrada.Date == dataSelecionada).ToList();

            if (frequenciasDoDia.Any())
            {
                string detalhes = "Registros do dia " + dataSelecionada.ToShortDateString() + ":\n";
                foreach (var freq in frequenciasDoDia)
                {
                    string entrada = freq.Entrada.ToString("HH:mm:ss");
                    string saida = freq.Saida.HasValue ? freq.Saida.Value.ToString("HH:mm:ss") : "Ainda no local";
                    detalhes += $"Entrada: {entrada} - Saída: {saida}\n";
                }

                lblDetalhes.Text = detalhes;
            }
            else
            {
                lblDetalhes.Text = "Nenhum registro encontrado para esta data.";
            }
        }
    }
}
