
namespace PPL_Main.Telas
{
    partial class TelaMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.sairButton = new System.Windows.Forms.Button();
            this.pBLDBDataSet = new PPL_Main.PBLDBDataSet();
            this.pBLDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelQuantidadeUsuarios = new System.Windows.Forms.Label();
            this.labelQuantidadeSimulacoesFeitas = new System.Windows.Forms.Label();
            this.listViewTabelaResultados = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.pBLDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBLDBDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // sairButton
            // 
            this.sairButton.BackColor = System.Drawing.Color.DarkRed;
            this.sairButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sairButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.sairButton.Location = new System.Drawing.Point(269, 444);
            this.sairButton.Name = "sairButton";
            this.sairButton.Size = new System.Drawing.Size(91, 38);
            this.sairButton.TabIndex = 2;
            this.sairButton.Text = "Sair";
            this.sairButton.UseVisualStyleBackColor = false;
            // 
            // pBLDBDataSet
            // 
            this.pBLDBDataSet.DataSetName = "PBLDBDataSet";
            this.pBLDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pBLDBDataSetBindingSource
            // 
            this.pBLDBDataSetBindingSource.DataSource = this.pBLDBDataSet;
            this.pBLDBDataSetBindingSource.Position = 0;
            // 
            // labelQuantidadeUsuarios
            // 
            this.labelQuantidadeUsuarios.AutoSize = true;
            this.labelQuantidadeUsuarios.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuantidadeUsuarios.Location = new System.Drawing.Point(589, 160);
            this.labelQuantidadeUsuarios.Name = "labelQuantidadeUsuarios";
            this.labelQuantidadeUsuarios.Size = new System.Drawing.Size(125, 30);
            this.labelQuantidadeUsuarios.TabIndex = 10;
            this.labelQuantidadeUsuarios.Text = "Cadastre-se";
            this.labelQuantidadeUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelQuantidadeSimulacoesFeitas
            // 
            this.labelQuantidadeSimulacoesFeitas.AutoSize = true;
            this.labelQuantidadeSimulacoesFeitas.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuantidadeSimulacoesFeitas.Location = new System.Drawing.Point(220, 160);
            this.labelQuantidadeSimulacoesFeitas.Name = "labelQuantidadeSimulacoesFeitas";
            this.labelQuantidadeSimulacoesFeitas.Size = new System.Drawing.Size(125, 30);
            this.labelQuantidadeSimulacoesFeitas.TabIndex = 11;
            this.labelQuantidadeSimulacoesFeitas.Text = "Cadastre-se";
            this.labelQuantidadeSimulacoesFeitas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listViewTabelaResultados
            // 
            this.listViewTabelaResultados.HideSelection = false;
            this.listViewTabelaResultados.Location = new System.Drawing.Point(12, 51);
            this.listViewTabelaResultados.Name = "listViewTabelaResultados";
            this.listViewTabelaResultados.Size = new System.Drawing.Size(121, 97);
            this.listViewTabelaResultados.TabIndex = 12;
            this.listViewTabelaResultados.UseCompatibleStateImageBehavior = false;
            this.listViewTabelaResultados.View = System.Windows.Forms.View.Details;
            // 
            // TelaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 516);
            this.Controls.Add(this.listViewTabelaResultados);
            this.Controls.Add(this.labelQuantidadeSimulacoesFeitas);
            this.Controls.Add(this.labelQuantidadeUsuarios);
            this.Controls.Add(this.sairButton);
            this.Name = "TelaMenu";
            this.Text = "Menu Principal - Sistema de calculo e simulação de um lançamento balistico com al" +
    "vo movel";
            this.Load += new System.EventHandler(this.TelaPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBLDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBLDBDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sairButton;
        private System.Windows.Forms.BindingSource pBLDBDataSetBindingSource;
        private PBLDBDataSet pBLDBDataSet;
        private System.Windows.Forms.Label labelQuantidadeUsuarios;
        private System.Windows.Forms.Label labelQuantidadeSimulacoesFeitas;
        private System.Windows.Forms.ListView listViewTabelaResultados;
    }
}