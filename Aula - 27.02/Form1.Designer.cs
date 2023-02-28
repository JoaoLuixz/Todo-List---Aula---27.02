namespace Aula___27._02
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbTodoList = new System.Windows.Forms.Label();
            this.lbData = new System.Windows.Forms.Label();
            this.dtpDATA = new System.Windows.Forms.DateTimePicker();
            this.lbTarefa = new System.Windows.Forms.Label();
            this.tbTarefa = new System.Windows.Forms.TextBox();
            this.toolTipData = new System.Windows.Forms.ToolTip(this.components);
            this.btn = new System.Windows.Forms.Button();
            this.listboxTarefas = new System.Windows.Forms.ListBox();
            this.bntRemover = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbTodoList
            // 
            this.lbTodoList.AutoSize = true;
            this.lbTodoList.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTodoList.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbTodoList.Location = new System.Drawing.Point(236, 9);
            this.lbTodoList.Name = "lbTodoList";
            this.lbTodoList.Size = new System.Drawing.Size(104, 31);
            this.lbTodoList.TabIndex = 0;
            this.lbTodoList.Text = "Todo List";
            this.lbTodoList.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbData
            // 
            this.lbData.AutoSize = true;
            this.lbData.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbData.Location = new System.Drawing.Point(39, 98);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(39, 17);
            this.lbData.TabIndex = 1;
            this.lbData.Text = "Data";
            // 
            // dtpDATA
            // 
            this.dtpDATA.Location = new System.Drawing.Point(84, 94);
            this.dtpDATA.Name = "dtpDATA";
            this.dtpDATA.Size = new System.Drawing.Size(240, 23);
            this.dtpDATA.TabIndex = 2;
            this.toolTipData.SetToolTip(this.dtpDATA, "Digite a data da tarefa");
            // 
            // lbTarefa
            // 
            this.lbTarefa.AutoSize = true;
            this.lbTarefa.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTarefa.Location = new System.Drawing.Point(30, 135);
            this.lbTarefa.Name = "lbTarefa";
            this.lbTarefa.Size = new System.Drawing.Size(48, 17);
            this.lbTarefa.TabIndex = 3;
            this.lbTarefa.Text = "Tarefa";
            // 
            // tbTarefa
            // 
            this.tbTarefa.Location = new System.Drawing.Point(84, 135);
            this.tbTarefa.Name = "tbTarefa";
            this.tbTarefa.Size = new System.Drawing.Size(240, 23);
            this.tbTarefa.TabIndex = 4;
            // 
            // toolTipData
            // 
            this.toolTipData.IsBalloon = true;
            this.toolTipData.Tag = "";
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(350, 92);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(125, 66);
            this.btn.TabIndex = 5;
            this.btn.Text = "Incluir";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // listboxTarefas
            // 
            this.listboxTarefas.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listboxTarefas.FormattingEnabled = true;
            this.listboxTarefas.ItemHeight = 20;
            this.listboxTarefas.Location = new System.Drawing.Point(84, 184);
            this.listboxTarefas.Name = "listboxTarefas";
            this.listboxTarefas.Size = new System.Drawing.Size(391, 164);
            this.listboxTarefas.TabIndex = 6;
            // 
            // bntRemover
            // 
            this.bntRemover.BackColor = System.Drawing.Color.Firebrick;
            this.bntRemover.Location = new System.Drawing.Point(236, 365);
            this.bntRemover.Name = "bntRemover";
            this.bntRemover.Size = new System.Drawing.Size(91, 44);
            this.bntRemover.TabIndex = 7;
            this.bntRemover.Text = "Remover";
            this.bntRemover.UseVisualStyleBackColor = false;
            this.bntRemover.Click += new System.EventHandler(this.bntRemover_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 421);
            this.Controls.Add(this.bntRemover);
            this.Controls.Add(this.listboxTarefas);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.tbTarefa);
            this.Controls.Add(this.lbTarefa);
            this.Controls.Add(this.dtpDATA);
            this.Controls.Add(this.lbData);
            this.Controls.Add(this.lbTodoList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbTodoList;
        private Label lbData;
        private DateTimePicker dtpDATA;
        private ToolTip toolTipData;
        private Label lbTarefa;
        private TextBox tbTarefa;
        private Button btn;
        private ListBox listboxTarefas;
        private Button bntRemover;
    }
}