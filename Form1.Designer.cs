namespace Cnpj
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Panel = new MetroFramework.Controls.MetroPanel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.caminholog = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroButton5 = new MetroFramework.Controls.MetroButton();
            this.caminho = new MetroFramework.Controls.MetroTextBox();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.Panel.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel
            // 
            this.Panel.BackColor = System.Drawing.Color.Black;
            this.Panel.BackgroundImage = global::Cnpj.Properties.Resources.earth_2254769_640;
            this.Panel.Controls.Add(this.metroPanel1);
            this.Panel.Controls.Add(this.metroButton2);
            this.Panel.Controls.Add(this.metroButton1);
            this.Panel.Controls.Add(this.metroLabel1);
            this.Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel.HorizontalScrollbarBarColor = true;
            this.Panel.HorizontalScrollbarHighlightOnWheel = false;
            this.Panel.HorizontalScrollbarSize = 10;
            this.Panel.Location = new System.Drawing.Point(20, 60);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(760, 370);
            this.Panel.TabIndex = 0;
            this.Panel.VerticalScrollbarBarColor = true;
            this.Panel.VerticalScrollbarHighlightOnWheel = false;
            this.Panel.VerticalScrollbarSize = 10;
          
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.Black;
            this.metroPanel1.BackgroundImage = global::Cnpj.Properties.Resources.earth_2254769_640;
            this.metroPanel1.Controls.Add(this.caminholog);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.metroButton5);
            this.metroPanel1.Controls.Add(this.caminho);
            this.metroPanel1.Controls.Add(this.metroButton4);
            this.metroPanel1.Controls.Add(this.metroButton3);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 0);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(760, 370);
            this.metroPanel1.TabIndex = 10;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // caminholog
            // 
            // 
            // 
            // 
            this.caminholog.CustomButton.Image = null;
            this.caminholog.CustomButton.Location = new System.Drawing.Point(670, 1);
            this.caminholog.CustomButton.Name = "";
            this.caminholog.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.caminholog.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.caminholog.CustomButton.TabIndex = 1;
            this.caminholog.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.caminholog.CustomButton.UseSelectable = true;
            this.caminholog.CustomButton.Visible = false;
            this.caminholog.Lines = new string[0];
            this.caminholog.Location = new System.Drawing.Point(15, 96);
            this.caminholog.MaxLength = 32767;
            this.caminholog.Name = "caminholog";
            this.caminholog.PasswordChar = '\0';
            this.caminholog.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.caminholog.SelectedText = "";
            this.caminholog.SelectionLength = 0;
            this.caminholog.SelectionStart = 0;
            this.caminholog.ShortcutsEnabled = true;
            this.caminholog.Size = new System.Drawing.Size(692, 23);
            this.caminholog.TabIndex = 13;
            this.caminholog.UseSelectable = true;
            this.caminholog.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.caminholog.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.Color.Black;
            this.metroLabel3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroLabel3.Location = new System.Drawing.Point(15, 74);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(108, 19);
            this.metroLabel3.TabIndex = 12;
            this.metroLabel3.Text = "Caminho do Log";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroButton5
            // 
            this.metroButton5.BackColor = System.Drawing.Color.Black;
            this.metroButton5.BackgroundImage = global::Cnpj.Properties.Resources.icons8_search_16px_1;
            this.metroButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroButton5.Location = new System.Drawing.Point(713, 96);
            this.metroButton5.Name = "metroButton5";
            this.metroButton5.Size = new System.Drawing.Size(34, 23);
            this.metroButton5.Style = MetroFramework.MetroColorStyle.Black;
            this.metroButton5.TabIndex = 10;
            this.metroButton5.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton5.UseSelectable = true;
            this.metroButton5.Click += new System.EventHandler(this.metroButton5_Click);
            // 
            // caminho
            // 
            // 
            // 
            // 
            this.caminho.CustomButton.Image = null;
            this.caminho.CustomButton.Location = new System.Drawing.Point(670, 1);
            this.caminho.CustomButton.Name = "";
            this.caminho.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.caminho.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.caminho.CustomButton.TabIndex = 1;
            this.caminho.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.caminho.CustomButton.UseSelectable = true;
            this.caminho.CustomButton.Visible = false;
            this.caminho.Lines = new string[0];
            this.caminho.Location = new System.Drawing.Point(15, 32);
            this.caminho.MaxLength = 32767;
            this.caminho.Name = "caminho";
            this.caminho.PasswordChar = '\0';
            this.caminho.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.caminho.SelectedText = "";
            this.caminho.SelectionLength = 0;
            this.caminho.SelectionStart = 0;
            this.caminho.ShortcutsEnabled = true;
            this.caminho.Size = new System.Drawing.Size(692, 23);
            this.caminho.TabIndex = 9;
            this.caminho.UseSelectable = true;
            this.caminho.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.caminho.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButton4
            // 
            this.metroButton4.Location = new System.Drawing.Point(15, 178);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(732, 39);
            this.metroButton4.TabIndex = 5;
            this.metroButton4.Text = "Iniciar";
            this.metroButton4.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton4.UseSelectable = true;
            this.metroButton4.Click += new System.EventHandler(this.metroButton4_Click);
            // 
            // metroButton3
            // 
            this.metroButton3.BackColor = System.Drawing.Color.Black;
            this.metroButton3.BackgroundImage = global::Cnpj.Properties.Resources.icons8_search_16px_1;
            this.metroButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroButton3.Location = new System.Drawing.Point(713, 33);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(34, 23);
            this.metroButton3.Style = MetroFramework.MetroColorStyle.Black;
            this.metroButton3.TabIndex = 4;
            this.metroButton3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton3.UseSelectable = true;
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.Black;
            this.metroLabel2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroLabel2.Location = new System.Drawing.Point(15, 11);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(233, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Caminho do Arquivo para Tratamento";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(672, 136);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(75, 39);
            this.metroButton2.TabIndex = 5;
            this.metroButton2.Text = "Iniciar";
            this.metroButton2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton2.UseSelectable = true;
            
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.Black;
            this.metroButton1.BackgroundImage = global::Cnpj.Properties.Resources.icons8_search_16px_1;
            this.metroButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroButton1.Location = new System.Drawing.Point(713, 33);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(34, 23);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Black;
            this.metroButton1.TabIndex = 4;
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton1.UseSelectable = true;
            
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Black;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroLabel1.Location = new System.Drawing.Point(15, 11);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(233, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Caminho do Arquivo para Tratamento";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Panel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Tratamento de CNPJ";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
           
            this.Panel.ResumeLayout(false);
            this.Panel.PerformLayout();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel Panel;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
       
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        
        private MetroFramework.Controls.MetroTextBox caminholog;
        private MetroFramework.Controls.MetroButton metroButton5;
        private MetroFramework.Controls.MetroTextBox caminho;
        private MetroFramework.Controls.MetroButton metroButton4;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        
    }
}

