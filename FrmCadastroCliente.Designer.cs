namespace Projeto3Camadas
{
    partial class FrmCadastroCliente
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
            txtID = new TextBox();
            txtNome = new TextBox();
            txtEmail = new TextBox();
            labelID = new Label();
            labelNome = new Label();
            labelEmail = new Label();
            btnInserir = new Button();
            btnAlterar = new Button();
            btnExcluir = new Button();
            gridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)gridView).BeginInit();
            SuspendLayout();
            // 
            // txtID
            // 
            txtID.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtID.Location = new Point(42, 82);
            txtID.Name = "txtID";
            txtID.Size = new Size(645, 47);
            txtID.TabIndex = 0;
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtNome.Location = new Point(42, 182);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(645, 47);
            txtNome.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(42, 283);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(645, 47);
            txtEmail.TabIndex = 2;
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelID.Location = new Point(42, 48);
            labelID.Name = "labelID";
            labelID.Size = new Size(93, 31);
            labelID.TabIndex = 3;
            labelID.Text = "Código:";
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelNome.Location = new Point(42, 148);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(81, 31);
            labelNome.TabIndex = 4;
            labelNome.Text = "Nome:";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelEmail.Location = new Point(42, 249);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(84, 31);
            labelEmail.TabIndex = 5;
            labelEmail.Text = "E-mail:";
            // 
            // btnInserir
            // 
            btnInserir.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnInserir.Location = new Point(41, 361);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(150, 50);
            btnInserir.TabIndex = 6;
            btnInserir.Text = "Inserir";
            btnInserir.UseVisualStyleBackColor = true;
            btnInserir.Click += btnInserir_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnAlterar.Location = new Point(299, 361);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(150, 50);
            btnAlterar.TabIndex = 7;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = true;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnExcluir.Location = new Point(537, 361);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(150, 50);
            btnExcluir.TabIndex = 8;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // gridView
            // 
            gridView.AllowUserToAddRows = false;
            gridView.AllowUserToDeleteRows = false;
            gridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridView.Location = new Point(42, 436);
            gridView.Name = "gridView";
            gridView.ReadOnly = true;
            gridView.RowHeadersWidth = 51;
            gridView.RowTemplate.Height = 29;
            gridView.Size = new Size(645, 244);
            gridView.TabIndex = 10;
            // 
            // FrmCadastroCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(736, 714);
            Controls.Add(gridView);
            Controls.Add(btnExcluir);
            Controls.Add(btnAlterar);
            Controls.Add(btnInserir);
            Controls.Add(labelEmail);
            Controls.Add(labelNome);
            Controls.Add(labelID);
            Controls.Add(txtEmail);
            Controls.Add(txtNome);
            Controls.Add(txtID);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "FrmCadastroCliente";
            Text = "Projeto 3 Camadas";
            Load += FrmCadastroCliente_Load;
            ((System.ComponentModel.ISupportInitialize)gridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtID;
        private TextBox txtNome;
        private TextBox txtEmail;
        private Label labelID;
        private Label labelNome;
        private Label labelEmail;
        private Button btnInserir;
        private Button btnAlterar;
        private Button btnExcluir;
        private DataGridView gridView;
    }
}
