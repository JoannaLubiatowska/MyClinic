namespace MyClinic
{
    partial class MedicinesForm
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
            System.Windows.Forms.Label drugDosageLabel;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label14;
            System.Windows.Forms.Label label23;
            System.Windows.Forms.Label label28;
            this.buttonSaveMedicines = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxMedicinesAmount = new System.Windows.Forms.TextBox();
            this.textBoxMedicinesDrugDosage = new System.Windows.Forms.TextBox();
            this.textBoxMedicinesName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.textBoxMedicinesPesel = new System.Windows.Forms.TextBox();
            this.textBoxMedicinesFirstName = new System.Windows.Forms.TextBox();
            this.textBoxMedicinesLastName = new System.Windows.Forms.TextBox();
            drugDosageLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label14 = new System.Windows.Forms.Label();
            label23 = new System.Windows.Forms.Label();
            label28 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // drugDosageLabel
            // 
            drugDosageLabel.AutoSize = true;
            drugDosageLabel.Location = new System.Drawing.Point(7, 73);
            drugDosageLabel.Name = "drugDosageLabel";
            drugDosageLabel.Size = new System.Drawing.Size(72, 13);
            drugDosageLabel.TabIndex = 8;
            drugDosageLabel.Text = "Dawkowanie:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(7, 21);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(43, 13);
            label2.TabIndex = 6;
            label2.Text = "Nazwa:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(7, 47);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(59, 13);
            label3.TabIndex = 7;
            label3.Text = "Gramatura:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new System.Drawing.Point(7, 22);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(29, 13);
            label14.TabIndex = 15;
            label14.Text = "Imię:";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new System.Drawing.Point(7, 48);
            label23.Name = "label23";
            label23.Size = new System.Drawing.Size(56, 13);
            label23.TabIndex = 16;
            label23.Text = "Nazwisko:";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Location = new System.Drawing.Point(7, 74);
            label28.Name = "label28";
            label28.Size = new System.Drawing.Size(44, 13);
            label28.TabIndex = 21;
            label28.Text = "PESEL:";
            // 
            // buttonSaveMedicines
            // 
            this.buttonSaveMedicines.Location = new System.Drawing.Point(308, 502);
            this.buttonSaveMedicines.Name = "buttonSaveMedicines";
            this.buttonSaveMedicines.Size = new System.Drawing.Size(134, 23);
            this.buttonSaveMedicines.TabIndex = 58;
            this.buttonSaveMedicines.Text = "Zapisz";
            this.buttonSaveMedicines.UseVisualStyleBackColor = true;
            this.buttonSaveMedicines.Click += new System.EventHandler(this.buttonSaveMedicines_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxMedicinesAmount);
            this.groupBox2.Controls.Add(this.textBoxMedicinesDrugDosage);
            this.groupBox2.Controls.Add(this.textBoxMedicinesName);
            this.groupBox2.Controls.Add(drugDosageLabel);
            this.groupBox2.Controls.Add(label2);
            this.groupBox2.Controls.Add(label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 397);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(430, 99);
            this.groupBox2.TabIndex = 56;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dodaj nowy lek";
            // 
            // textBoxMedicinesAmount
            // 
            this.textBoxMedicinesAmount.Location = new System.Drawing.Point(174, 40);
            this.textBoxMedicinesAmount.Name = "textBoxMedicinesAmount";
            this.textBoxMedicinesAmount.Size = new System.Drawing.Size(242, 20);
            this.textBoxMedicinesAmount.TabIndex = 32;
            // 
            // textBoxMedicinesDrugDosage
            // 
            this.textBoxMedicinesDrugDosage.Location = new System.Drawing.Point(174, 66);
            this.textBoxMedicinesDrugDosage.Name = "textBoxMedicinesDrugDosage";
            this.textBoxMedicinesDrugDosage.Size = new System.Drawing.Size(242, 20);
            this.textBoxMedicinesDrugDosage.TabIndex = 31;
            // 
            // textBoxMedicinesName
            // 
            this.textBoxMedicinesName.Location = new System.Drawing.Point(174, 14);
            this.textBoxMedicinesName.Name = "textBoxMedicinesName";
            this.textBoxMedicinesName.Size = new System.Drawing.Size(242, 20);
            this.textBoxMedicinesName.TabIndex = 30;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 128);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(430, 263);
            this.groupBox1.TabIndex = 55;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Leki przyjmowane przez pacjenta";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.textBoxMedicinesPesel);
            this.groupBox6.Controls.Add(this.textBoxMedicinesFirstName);
            this.groupBox6.Controls.Add(this.textBoxMedicinesLastName);
            this.groupBox6.Controls.Add(label14);
            this.groupBox6.Controls.Add(label23);
            this.groupBox6.Controls.Add(label28);
            this.groupBox6.Location = new System.Drawing.Point(12, 12);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(430, 110);
            this.groupBox6.TabIndex = 54;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Dane pacjenta";
            // 
            // textBoxMedicinesPesel
            // 
            this.textBoxMedicinesPesel.AllowDrop = true;
            this.textBoxMedicinesPesel.Enabled = false;
            this.textBoxMedicinesPesel.Location = new System.Drawing.Point(174, 71);
            this.textBoxMedicinesPesel.Name = "textBoxMedicinesPesel";
            this.textBoxMedicinesPesel.Size = new System.Drawing.Size(242, 20);
            this.textBoxMedicinesPesel.TabIndex = 28;
            // 
            // textBoxMedicinesFirstName
            // 
            this.textBoxMedicinesFirstName.Enabled = false;
            this.textBoxMedicinesFirstName.Location = new System.Drawing.Point(174, 19);
            this.textBoxMedicinesFirstName.Name = "textBoxMedicinesFirstName";
            this.textBoxMedicinesFirstName.Size = new System.Drawing.Size(242, 20);
            this.textBoxMedicinesFirstName.TabIndex = 24;
            // 
            // textBoxMedicinesLastName
            // 
            this.textBoxMedicinesLastName.Enabled = false;
            this.textBoxMedicinesLastName.Location = new System.Drawing.Point(174, 45);
            this.textBoxMedicinesLastName.Name = "textBoxMedicinesLastName";
            this.textBoxMedicinesLastName.Size = new System.Drawing.Size(242, 20);
            this.textBoxMedicinesLastName.TabIndex = 23;
            // 
            // MedicinesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 534);
            this.Controls.Add(this.buttonSaveMedicines);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox6);
            this.Name = "MedicinesForm";
            this.Text = "Leki";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSaveMedicines;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxMedicinesAmount;
        private System.Windows.Forms.TextBox textBoxMedicinesDrugDosage;
        private System.Windows.Forms.TextBox textBoxMedicinesName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox textBoxMedicinesPesel;
        private System.Windows.Forms.TextBox textBoxMedicinesFirstName;
        private System.Windows.Forms.TextBox textBoxMedicinesLastName;
    }
}