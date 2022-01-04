
namespace Cliente
{
    partial class PersonasFrm
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
            System.Windows.Forms.Label iDENTIFICACIONLabel;
            System.Windows.Forms.Label pRIMERAPELLIDOLabel;
            System.Windows.Forms.Label pRIMERNOMBRELabel;
            System.Windows.Forms.Label sEGUNDOAPELLIDOLabel;
            System.Windows.Forms.Label sEGUNDONOMBRELabel;
            this.personasDataGridView = new System.Windows.Forms.DataGridView();
            this.personaMSJBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listarButton = new System.Windows.Forms.Button();
            this.guardarButton = new System.Windows.Forms.Button();
            this.iDENTIFICACIONTextBox = new System.Windows.Forms.TextBox();
            this.pRIMERAPELLIDOTextBox = new System.Windows.Forms.TextBox();
            this.pRIMERNOMBRETextBox = new System.Windows.Forms.TextBox();
            this.sEGUNDOAPELLIDOTextBox = new System.Windows.Forms.TextBox();
            this.sEGUNDONOMBRETextBox = new System.Windows.Forms.TextBox();
            this.personaMSJBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.personaWS1 = new Proxies.Persona.PersonaWS();
            this.buscarButton = new System.Windows.Forms.Button();
            iDENTIFICACIONLabel = new System.Windows.Forms.Label();
            pRIMERAPELLIDOLabel = new System.Windows.Forms.Label();
            pRIMERNOMBRELabel = new System.Windows.Forms.Label();
            sEGUNDOAPELLIDOLabel = new System.Windows.Forms.Label();
            sEGUNDONOMBRELabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.personasDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personaMSJBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personaMSJBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // personasDataGridView
            // 
            this.personasDataGridView.AutoGenerateColumns = false;
            this.personasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.personasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewCheckBoxColumn1});
            this.personasDataGridView.DataSource = this.personaMSJBindingSource1;
            this.personasDataGridView.Enabled = false;
            this.personasDataGridView.Location = new System.Drawing.Point(39, 208);
            this.personasDataGridView.Name = "personasDataGridView";
            this.personasDataGridView.RowHeadersWidth = 51;
            this.personasDataGridView.RowTemplate.Height = 24;
            this.personasDataGridView.Size = new System.Drawing.Size(1289, 209);
            this.personasDataGridView.TabIndex = 0;
            // 
            // listarButton
            // 
            this.listarButton.Location = new System.Drawing.Point(145, 179);
            this.listarButton.Name = "listarButton";
            this.listarButton.Size = new System.Drawing.Size(87, 23);
            this.listarButton.TabIndex = 1;
            this.listarButton.Text = "Listar";
            this.listarButton.UseVisualStyleBackColor = true;
            this.listarButton.Click += new System.EventHandler(this.listarButton_Click);
            // 
            // guardarButton
            // 
            this.guardarButton.Location = new System.Drawing.Point(39, 179);
            this.guardarButton.Name = "guardarButton";
            this.guardarButton.Size = new System.Drawing.Size(88, 23);
            this.guardarButton.TabIndex = 2;
            this.guardarButton.Text = "Adicionar";
            this.guardarButton.UseVisualStyleBackColor = true;
            this.guardarButton.Click += new System.EventHandler(this.guardarButton_Click);
            // 
            // iDENTIFICACIONLabel
            // 
            iDENTIFICACIONLabel.AutoSize = true;
            iDENTIFICACIONLabel.Location = new System.Drawing.Point(49, 43);
            iDENTIFICACIONLabel.Name = "iDENTIFICACIONLabel";
            iDENTIFICACIONLabel.Size = new System.Drawing.Size(118, 17);
            iDENTIFICACIONLabel.TabIndex = 3;
            iDENTIFICACIONLabel.Text = "IDENTIFICACION:";
            // 
            // iDENTIFICACIONTextBox
            // 
            this.iDENTIFICACIONTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personaMSJBindingSource1, "IDENTIFICACION", true));
            this.iDENTIFICACIONTextBox.Location = new System.Drawing.Point(186, 40);
            this.iDENTIFICACIONTextBox.Name = "iDENTIFICACIONTextBox";
            this.iDENTIFICACIONTextBox.Size = new System.Drawing.Size(190, 22);
            this.iDENTIFICACIONTextBox.TabIndex = 4;
            // 
            // pRIMERAPELLIDOLabel
            // 
            pRIMERAPELLIDOLabel.AutoSize = true;
            pRIMERAPELLIDOLabel.Location = new System.Drawing.Point(36, 76);
            pRIMERAPELLIDOLabel.Name = "pRIMERAPELLIDOLabel";
            pRIMERAPELLIDOLabel.Size = new System.Drawing.Size(131, 17);
            pRIMERAPELLIDOLabel.TabIndex = 5;
            pRIMERAPELLIDOLabel.Text = "PRIMERAPELLIDO:";
            // 
            // pRIMERAPELLIDOTextBox
            // 
            this.pRIMERAPELLIDOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personaMSJBindingSource1, "PRIMERAPELLIDO", true));
            this.pRIMERAPELLIDOTextBox.Location = new System.Drawing.Point(186, 73);
            this.pRIMERAPELLIDOTextBox.Name = "pRIMERAPELLIDOTextBox";
            this.pRIMERAPELLIDOTextBox.Size = new System.Drawing.Size(190, 22);
            this.pRIMERAPELLIDOTextBox.TabIndex = 6;
            // 
            // pRIMERNOMBRELabel
            // 
            pRIMERNOMBRELabel.AutoSize = true;
            pRIMERNOMBRELabel.Location = new System.Drawing.Point(43, 115);
            pRIMERNOMBRELabel.Name = "pRIMERNOMBRELabel";
            pRIMERNOMBRELabel.Size = new System.Drawing.Size(124, 17);
            pRIMERNOMBRELabel.TabIndex = 7;
            pRIMERNOMBRELabel.Text = "PRIMERNOMBRE:";
            // 
            // pRIMERNOMBRETextBox
            // 
            this.pRIMERNOMBRETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personaMSJBindingSource1, "PRIMERNOMBRE", true));
            this.pRIMERNOMBRETextBox.Location = new System.Drawing.Point(186, 110);
            this.pRIMERNOMBRETextBox.Name = "pRIMERNOMBRETextBox";
            this.pRIMERNOMBRETextBox.Size = new System.Drawing.Size(190, 22);
            this.pRIMERNOMBRETextBox.TabIndex = 8;
            // 
            // sEGUNDOAPELLIDOLabel
            // 
            sEGUNDOAPELLIDOLabel.AutoSize = true;
            sEGUNDOAPELLIDOLabel.Location = new System.Drawing.Point(404, 76);
            sEGUNDOAPELLIDOLabel.Name = "sEGUNDOAPELLIDOLabel";
            sEGUNDOAPELLIDOLabel.Size = new System.Drawing.Size(149, 17);
            sEGUNDOAPELLIDOLabel.TabIndex = 9;
            sEGUNDOAPELLIDOLabel.Text = "SEGUNDOAPELLIDO:";
            // 
            // sEGUNDOAPELLIDOTextBox
            // 
            this.sEGUNDOAPELLIDOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personaMSJBindingSource1, "SEGUNDOAPELLIDO", true));
            this.sEGUNDOAPELLIDOTextBox.Location = new System.Drawing.Point(566, 73);
            this.sEGUNDOAPELLIDOTextBox.Name = "sEGUNDOAPELLIDOTextBox";
            this.sEGUNDOAPELLIDOTextBox.Size = new System.Drawing.Size(207, 22);
            this.sEGUNDOAPELLIDOTextBox.TabIndex = 10;
            // 
            // sEGUNDONOMBRELabel
            // 
            sEGUNDONOMBRELabel.AutoSize = true;
            sEGUNDONOMBRELabel.Location = new System.Drawing.Point(411, 118);
            sEGUNDONOMBRELabel.Name = "sEGUNDONOMBRELabel";
            sEGUNDONOMBRELabel.Size = new System.Drawing.Size(142, 17);
            sEGUNDONOMBRELabel.TabIndex = 11;
            sEGUNDONOMBRELabel.Text = "SEGUNDONOMBRE:";
            // 
            // sEGUNDONOMBRETextBox
            // 
            this.sEGUNDONOMBRETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personaMSJBindingSource1, "SEGUNDONOMBRE", true));
            this.sEGUNDONOMBRETextBox.Location = new System.Drawing.Point(566, 115);
            this.sEGUNDONOMBRETextBox.Name = "sEGUNDONOMBRETextBox";
            this.sEGUNDONOMBRETextBox.Size = new System.Drawing.Size(207, 22);
            this.sEGUNDONOMBRETextBox.TabIndex = 12;
            // 
            // personaMSJBindingSource1
            // 
            this.personaMSJBindingSource1.DataSource = typeof(Proxies.Persona.PersonaMSJ);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "SECUENCIAL";
            this.dataGridViewTextBoxColumn1.HeaderText = "SECUENCIAL";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 122;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CODIGOTIPOIDENTIFICACION";
            this.dataGridViewTextBoxColumn2.HeaderText = "CODIGO TIPO IDENTIFICACION";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 217;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "IDENTIFICACION";
            this.dataGridViewTextBoxColumn3.HeaderText = "IDENTIFICACION";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "PRIMERNOMBRE";
            this.dataGridViewTextBoxColumn4.HeaderText = "PRIMERNOMBRE";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "SEGUNDONOMBRE";
            this.dataGridViewTextBoxColumn5.HeaderText = "SEGUNDONOMBRE";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "PRIMERAPELLIDO";
            this.dataGridViewTextBoxColumn6.HeaderText = "PRIMERAPELLIDO";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "ESTAACTIVO";
            this.dataGridViewCheckBoxColumn1.HeaderText = "ESTAACTIVO";
            this.dataGridViewCheckBoxColumn1.MinimumWidth = 6;
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Width = 125;
            // 
            // personaWS1
            // 
            this.personaWS1.Credentials = null;
            this.personaWS1.Url = "http://localhost/Servidor/Servicios/PersonaWS.asmx";
            this.personaWS1.UseDefaultCredentials = false;
            // 
            // buscarButton
            // 
            this.buscarButton.Location = new System.Drawing.Point(407, 38);
            this.buscarButton.Name = "buscarButton";
            this.buscarButton.Size = new System.Drawing.Size(75, 26);
            this.buscarButton.TabIndex = 13;
            this.buscarButton.Text = "Buscar";
            this.buscarButton.UseVisualStyleBackColor = true;
            this.buscarButton.Click += new System.EventHandler(this.buscarButton_Click);
            // 
            // PersonasFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1349, 450);
            this.Controls.Add(this.buscarButton);
            this.Controls.Add(sEGUNDONOMBRELabel);
            this.Controls.Add(this.sEGUNDONOMBRETextBox);
            this.Controls.Add(sEGUNDOAPELLIDOLabel);
            this.Controls.Add(this.sEGUNDOAPELLIDOTextBox);
            this.Controls.Add(pRIMERNOMBRELabel);
            this.Controls.Add(this.pRIMERNOMBRETextBox);
            this.Controls.Add(pRIMERAPELLIDOLabel);
            this.Controls.Add(this.pRIMERAPELLIDOTextBox);
            this.Controls.Add(iDENTIFICACIONLabel);
            this.Controls.Add(this.iDENTIFICACIONTextBox);
            this.Controls.Add(this.guardarButton);
            this.Controls.Add(this.listarButton);
            this.Controls.Add(this.personasDataGridView);
            this.Name = "PersonasFrm";
            this.Text = "PersonasFrm";
            ((System.ComponentModel.ISupportInitialize)(this.personasDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personaMSJBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personaMSJBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView personasDataGridView;
        private System.Windows.Forms.Button listarButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn sECUENCIALDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODIGOTIPOIDENTIFICACIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDENTIFICACIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRIMERNOMBREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sEGUNDONOMBREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRIMERAPELLIDODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sEGUNDOAPELLIDODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn eSTAACTIVODataGridViewCheckBoxColumn;
        private System.Windows.Forms.BindingSource personaMSJBindingSource;
        private System.Windows.Forms.BindingSource personaMSJBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.Button guardarButton;
        private Proxies.Persona.PersonaWS personaWS1;
        private System.Windows.Forms.TextBox iDENTIFICACIONTextBox;
        private System.Windows.Forms.TextBox pRIMERAPELLIDOTextBox;
        private System.Windows.Forms.TextBox pRIMERNOMBRETextBox;
        private System.Windows.Forms.TextBox sEGUNDOAPELLIDOTextBox;
        private System.Windows.Forms.TextBox sEGUNDONOMBRETextBox;
        private System.Windows.Forms.Button buscarButton;
    }
}