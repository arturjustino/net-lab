﻿namespace TesteImposto
{
    partial class FormImposto
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblEstadoOrigem = new System.Windows.Forms.Label();
            this.lblEstadoDestino = new System.Windows.Forms.Label();
            this.textBoxNomeCliente = new System.Windows.Forms.TextBox();
            this.txtEstadoOrigem = new System.Windows.Forms.TextBox();
            this.txtEstadoDestino = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewPedidos = new System.Windows.Forms.DataGridView();
            this.buttonGerarNotaFiscal = new System.Windows.Forms.Button();
            this.toolTipEstadoOrigem = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipEstadoDestino = new System.Windows.Forms.ToolTip(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do Cliente";
            // 
            // lblEstadoOrigem
            // 
            this.lblEstadoOrigem.AutoSize = true;
            this.lblEstadoOrigem.Location = new System.Drawing.Point(3, 34);
            this.lblEstadoOrigem.Name = "lblEstadoOrigem";
            this.lblEstadoOrigem.Size = new System.Drawing.Size(76, 13);
            this.lblEstadoOrigem.TabIndex = 1;
            this.lblEstadoOrigem.Text = "Estado Origem";
            // 
            // lblEstadoDestino
            // 
            this.lblEstadoDestino.AutoSize = true;
            this.lblEstadoDestino.Location = new System.Drawing.Point(3, 61);
            this.lblEstadoDestino.Name = "lblEstadoDestino";
            this.lblEstadoDestino.Size = new System.Drawing.Size(79, 13);
            this.lblEstadoDestino.TabIndex = 2;
            this.lblEstadoDestino.Text = "Estado Destino";
            // 
            // textBoxNomeCliente
            // 
            this.textBoxNomeCliente.Location = new System.Drawing.Point(95, 9);
            this.textBoxNomeCliente.Name = "textBoxNomeCliente";
            this.textBoxNomeCliente.Size = new System.Drawing.Size(939, 20);
            this.textBoxNomeCliente.TabIndex = 3;
            // 
            // txtEstadoOrigem
            // 
            this.txtEstadoOrigem.Location = new System.Drawing.Point(95, 31);
            this.txtEstadoOrigem.Name = "txtEstadoOrigem";
            this.txtEstadoOrigem.Size = new System.Drawing.Size(939, 20);
            this.txtEstadoOrigem.TabIndex = 4;
            this.txtEstadoOrigem.Leave += new System.EventHandler(this.txtEstadoOrigem_Leave);
            // 
            // txtEstadoDestino
            // 
            this.txtEstadoDestino.Location = new System.Drawing.Point(95, 53);
            this.txtEstadoDestino.Name = "txtEstadoDestino";
            this.txtEstadoDestino.Size = new System.Drawing.Size(939, 20);
            this.txtEstadoDestino.TabIndex = 5;
            this.txtEstadoDestino.Leave += new System.EventHandler(this.txtEstadoDestino_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Itens do pedido";
            // 
            // dataGridViewPedidos
            // 
            this.dataGridViewPedidos.AllowUserToOrderColumns = true;
            this.dataGridViewPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPedidos.Location = new System.Drawing.Point(6, 109);
            this.dataGridViewPedidos.Name = "dataGridViewPedidos";
            this.dataGridViewPedidos.Size = new System.Drawing.Size(1028, 325);
            this.dataGridViewPedidos.TabIndex = 7;
            // 
            // buttonGerarNotaFiscal
            // 
            this.buttonGerarNotaFiscal.Location = new System.Drawing.Point(907, 440);
            this.buttonGerarNotaFiscal.Name = "buttonGerarNotaFiscal";
            this.buttonGerarNotaFiscal.Size = new System.Drawing.Size(127, 23);
            this.buttonGerarNotaFiscal.TabIndex = 8;
            this.buttonGerarNotaFiscal.Text = "Gerar Nota Fiscal";
            this.buttonGerarNotaFiscal.UseVisualStyleBackColor = true;
            this.buttonGerarNotaFiscal.Click += new System.EventHandler(this.buttonGerarNotaFiscal_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormImposto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 477);
            this.Controls.Add(this.buttonGerarNotaFiscal);
            this.Controls.Add(this.dataGridViewPedidos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEstadoDestino);
            this.Controls.Add(this.txtEstadoOrigem);
            this.Controls.Add(this.textBoxNomeCliente);
            this.Controls.Add(this.lblEstadoDestino);
            this.Controls.Add(this.lblEstadoOrigem);
            this.Controls.Add(this.label1);
            this.Name = "FormImposto";
            this.Text = "Calculo de imposto";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEstadoOrigem;
        private System.Windows.Forms.Label lblEstadoDestino;
        private System.Windows.Forms.TextBox textBoxNomeCliente;
        private System.Windows.Forms.TextBox txtEstadoOrigem;
        private System.Windows.Forms.TextBox txtEstadoDestino;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridViewPedidos;
        private System.Windows.Forms.Button buttonGerarNotaFiscal;
        private System.Windows.Forms.ToolTip toolTipEstadoOrigem;
        private System.Windows.Forms.ToolTip toolTipEstadoDestino;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

