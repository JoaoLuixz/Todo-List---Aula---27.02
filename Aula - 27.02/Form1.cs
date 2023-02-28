namespace Aula___27._02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if(tbTarefa.Text != "")
            {
                listboxTarefas.Items.Add($"{dtpDATA.Value:d} - {tbTarefa.Text}");
            }
            else
            {
                MessageBox.Show("Digite a tarefa!!!");
            }
        }

        private void bntRemover_Click(object sender, EventArgs e)
        {
            if(this.listboxTarefas.SelectedItem == null )
            {
                MessageBox.Show("Selecione um item!!!");
            }
            else
            {
                this.listboxTarefas.Items.Remove(listboxTarefas.SelectedItem);
            }
        }
    }
}