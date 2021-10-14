
namespace HelloWinFormsApp
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelImie = new System.Windows.Forms.Label();
            this.labelNazwisko = new System.Windows.Forms.Label();
            this.labelWiek = new System.Windows.Forms.Label();
            this.textBoxWiek = new System.Windows.Forms.TextBox();
            this.textBoxNazwisko = new System.Windows.Forms.TextBox();
            this.textBoxImie = new System.Windows.Forms.TextBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.labelKomunikat1 = new System.Windows.Forms.Label();
            this.labelKomunikat2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelImie
            // 
            this.labelImie.AutoSize = true;
            this.labelImie.Location = new System.Drawing.Point(12, 25);
            this.labelImie.Name = "labelImie";
            this.labelImie.Size = new System.Drawing.Size(29, 13);
            this.labelImie.TabIndex = 0;
            this.labelImie.Text = "Imię:";
            // 
            // labelNazwisko
            // 
            this.labelNazwisko.AutoSize = true;
            this.labelNazwisko.Location = new System.Drawing.Point(12, 70);
            this.labelNazwisko.Name = "labelNazwisko";
            this.labelNazwisko.Size = new System.Drawing.Size(56, 13);
            this.labelNazwisko.TabIndex = 1;
            this.labelNazwisko.Text = "Nazwisko:";
            // 
            // labelWiek
            // 
            this.labelWiek.AutoSize = true;
            this.labelWiek.Location = new System.Drawing.Point(12, 111);
            this.labelWiek.Name = "labelWiek";
            this.labelWiek.Size = new System.Drawing.Size(35, 13);
            this.labelWiek.TabIndex = 2;
            this.labelWiek.Text = "Wiek:";
            // 
            // textBoxWiek
            // 
            this.textBoxWiek.Location = new System.Drawing.Point(106, 111);
            this.textBoxWiek.Name = "textBoxWiek";
            this.textBoxWiek.Size = new System.Drawing.Size(100, 20);
            this.textBoxWiek.TabIndex = 3;
            // 
            // textBoxNazwisko
            // 
            this.textBoxNazwisko.Location = new System.Drawing.Point(106, 70);
            this.textBoxNazwisko.Name = "textBoxNazwisko";
            this.textBoxNazwisko.Size = new System.Drawing.Size(100, 20);
            this.textBoxNazwisko.TabIndex = 4;
            // 
            // textBoxImie
            // 
            this.textBoxImie.Location = new System.Drawing.Point(106, 25);
            this.textBoxImie.Name = "textBoxImie";
            this.textBoxImie.Size = new System.Drawing.Size(100, 20);
            this.textBoxImie.TabIndex = 5;
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(131, 159);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 6;
            this.buttonOk.Text = "Kliknij";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // labelKomunikat1
            // 
            this.labelKomunikat1.AutoSize = true;
            this.labelKomunikat1.Location = new System.Drawing.Point(12, 213);
            this.labelKomunikat1.Name = "labelKomunikat1";
            this.labelKomunikat1.Size = new System.Drawing.Size(63, 13);
            this.labelKomunikat1.TabIndex = 7;
            this.labelKomunikat1.Text = "Komunikat1";
            // 
            // labelKomunikat2
            // 
            this.labelKomunikat2.AutoSize = true;
            this.labelKomunikat2.Location = new System.Drawing.Point(12, 256);
            this.labelKomunikat2.Name = "labelKomunikat2";
            this.labelKomunikat2.Size = new System.Drawing.Size(63, 13);
            this.labelKomunikat2.TabIndex = 8;
            this.labelKomunikat2.Text = "Komunikat2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelKomunikat2);
            this.Controls.Add(this.labelKomunikat1);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.textBoxImie);
            this.Controls.Add(this.textBoxNazwisko);
            this.Controls.Add(this.textBoxWiek);
            this.Controls.Add(this.labelWiek);
            this.Controls.Add(this.labelNazwisko);
            this.Controls.Add(this.labelImie);
            this.Name = "Form1";
            this.Text = "Aplikacja Witaj";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelImie;
        private System.Windows.Forms.Label labelNazwisko;
        private System.Windows.Forms.Label labelWiek;
        private System.Windows.Forms.TextBox textBoxWiek;
        private System.Windows.Forms.TextBox textBoxNazwisko;
        private System.Windows.Forms.TextBox textBoxImie;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Label labelKomunikat1;
        private System.Windows.Forms.Label labelKomunikat2;
    }
}

