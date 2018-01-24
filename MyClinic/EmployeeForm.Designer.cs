namespace MyClinic
{
    partial class EmployeeForm
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
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label cityIDLabel1;
            System.Windows.Forms.Label phoneNumberLabel1;
            System.Windows.Forms.Label label13;
            System.Windows.Forms.Label userGroupIDLabel;
            System.Windows.Forms.Label firstNameLabel1;
            System.Windows.Forms.Label postalCodeLabel1;
            System.Windows.Forms.Label employeeDescriptionLabel;
            System.Windows.Forms.Label lastNameLabel1;
            System.Windows.Forms.Label streetNumerLabel1;
            System.Windows.Forms.Label userPasswordLabel;
            System.Windows.Forms.Label userLoginLabel;
            System.Windows.Forms.Label streetLabel1;
            this.buttonAddEmployee = new System.Windows.Forms.Button();
            this.textBoxEmployeePicture = new System.Windows.Forms.TextBox();
            this.comboBoxEmployeeGroup = new System.Windows.Forms.ComboBox();
            this.comboBoxEmployeeCity = new System.Windows.Forms.ComboBox();
            this.comboBoxEmployeeVoivodeship = new System.Windows.Forms.ComboBox();
            this.textBoxEmployeePasswordConfirm = new System.Windows.Forms.TextBox();
            this.textBoxEmployeeLogin = new System.Windows.Forms.TextBox();
            this.textBoxEmployeePassword = new System.Windows.Forms.TextBox();
            this.textBoxEmployeePhoneNo = new System.Windows.Forms.TextBox();
            this.textBoxEmployeeDescription = new System.Windows.Forms.TextBox();
            this.textBoxEmployeePostalCode = new System.Windows.Forms.TextBox();
            this.textBoxEmployeeStreet = new System.Windows.Forms.TextBox();
            this.textBoxEmployeeStreetNo = new System.Windows.Forms.TextBox();
            this.textBoxEmployeeFirstName = new System.Windows.Forms.TextBox();
            this.textBoxEmployeeLastName = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            cityIDLabel1 = new System.Windows.Forms.Label();
            phoneNumberLabel1 = new System.Windows.Forms.Label();
            label13 = new System.Windows.Forms.Label();
            userGroupIDLabel = new System.Windows.Forms.Label();
            firstNameLabel1 = new System.Windows.Forms.Label();
            postalCodeLabel1 = new System.Windows.Forms.Label();
            employeeDescriptionLabel = new System.Windows.Forms.Label();
            lastNameLabel1 = new System.Windows.Forms.Label();
            streetNumerLabel1 = new System.Windows.Forms.Label();
            userPasswordLabel = new System.Windows.Forms.Label();
            userLoginLabel = new System.Windows.Forms.Label();
            streetLabel1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(12, 395);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(45, 13);
            label2.TabIndex = 117;
            label2.Text = "Zdjęcie:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 148);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(77, 13);
            label1.TabIndex = 116;
            label1.Text = "Województwo:";
            // 
            // cityIDLabel1
            // 
            cityIDLabel1.AutoSize = true;
            cityIDLabel1.Location = new System.Drawing.Point(12, 175);
            cityIDLabel1.Name = "cityIDLabel1";
            cityIDLabel1.Size = new System.Drawing.Size(41, 13);
            cityIDLabel1.TabIndex = 109;
            cityIDLabel1.Text = "Miasto:";
            // 
            // phoneNumberLabel1
            // 
            phoneNumberLabel1.AutoSize = true;
            phoneNumberLabel1.Location = new System.Drawing.Point(12, 201);
            phoneNumberLabel1.Name = "phoneNumberLabel1";
            phoneNumberLabel1.Size = new System.Drawing.Size(82, 13);
            phoneNumberLabel1.TabIndex = 110;
            phoneNumberLabel1.Text = "Numer telefonu:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new System.Drawing.Point(12, 345);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(39, 13);
            label13.TabIndex = 115;
            label13.Text = "Hasło:";
            // 
            // userGroupIDLabel
            // 
            userGroupIDLabel.AutoSize = true;
            userGroupIDLabel.Location = new System.Drawing.Point(12, 371);
            userGroupIDLabel.Name = "userGroupIDLabel";
            userGroupIDLabel.Size = new System.Drawing.Size(39, 13);
            userGroupIDLabel.TabIndex = 114;
            userGroupIDLabel.Text = "Grupa:";
            // 
            // firstNameLabel1
            // 
            firstNameLabel1.AutoSize = true;
            firstNameLabel1.Location = new System.Drawing.Point(12, 18);
            firstNameLabel1.Name = "firstNameLabel1";
            firstNameLabel1.Size = new System.Drawing.Size(29, 13);
            firstNameLabel1.TabIndex = 104;
            firstNameLabel1.Text = "Imię:";
            // 
            // postalCodeLabel1
            // 
            postalCodeLabel1.AutoSize = true;
            postalCodeLabel1.Location = new System.Drawing.Point(12, 122);
            postalCodeLabel1.Name = "postalCodeLabel1";
            postalCodeLabel1.Size = new System.Drawing.Size(77, 13);
            postalCodeLabel1.TabIndex = 108;
            postalCodeLabel1.Text = "Kod pocztowy:";
            // 
            // employeeDescriptionLabel
            // 
            employeeDescriptionLabel.AutoSize = true;
            employeeDescriptionLabel.Location = new System.Drawing.Point(12, 227);
            employeeDescriptionLabel.Name = "employeeDescriptionLabel";
            employeeDescriptionLabel.Size = new System.Drawing.Size(31, 13);
            employeeDescriptionLabel.TabIndex = 111;
            employeeDescriptionLabel.Text = "Opis:";
            // 
            // lastNameLabel1
            // 
            lastNameLabel1.AutoSize = true;
            lastNameLabel1.Location = new System.Drawing.Point(12, 44);
            lastNameLabel1.Name = "lastNameLabel1";
            lastNameLabel1.Size = new System.Drawing.Size(56, 13);
            lastNameLabel1.TabIndex = 105;
            lastNameLabel1.Text = "Nazwisko:";
            // 
            // streetNumerLabel1
            // 
            streetNumerLabel1.AutoSize = true;
            streetNumerLabel1.Location = new System.Drawing.Point(12, 96);
            streetNumerLabel1.Name = "streetNumerLabel1";
            streetNumerLabel1.Size = new System.Drawing.Size(41, 13);
            streetNumerLabel1.TabIndex = 107;
            streetNumerLabel1.Text = "Numer:";
            // 
            // userPasswordLabel
            // 
            userPasswordLabel.AutoSize = true;
            userPasswordLabel.Location = new System.Drawing.Point(12, 319);
            userPasswordLabel.Name = "userPasswordLabel";
            userPasswordLabel.Size = new System.Drawing.Size(39, 13);
            userPasswordLabel.TabIndex = 113;
            userPasswordLabel.Text = "Hasło:";
            // 
            // userLoginLabel
            // 
            userLoginLabel.AutoSize = true;
            userLoginLabel.Location = new System.Drawing.Point(12, 293);
            userLoginLabel.Name = "userLoginLabel";
            userLoginLabel.Size = new System.Drawing.Size(36, 13);
            userLoginLabel.TabIndex = 112;
            userLoginLabel.Text = "Login:";
            // 
            // streetLabel1
            // 
            streetLabel1.AutoSize = true;
            streetLabel1.Location = new System.Drawing.Point(12, 70);
            streetLabel1.Name = "streetLabel1";
            streetLabel1.Size = new System.Drawing.Size(34, 13);
            streetLabel1.TabIndex = 106;
            streetLabel1.Text = "Ulica:";
            // 
            // buttonAddEmployee
            // 
            this.buttonAddEmployee.Location = new System.Drawing.Point(221, 421);
            this.buttonAddEmployee.Name = "buttonAddEmployee";
            this.buttonAddEmployee.Size = new System.Drawing.Size(136, 23);
            this.buttonAddEmployee.TabIndex = 135;
            this.buttonAddEmployee.Text = "Zapisz";
            this.buttonAddEmployee.UseVisualStyleBackColor = true;
            this.buttonAddEmployee.Click += new System.EventHandler(this.buttonAddEmployee_Click);
            // 
            // textBoxEmployeePicture
            // 
            this.textBoxEmployeePicture.Location = new System.Drawing.Point(115, 395);
            this.textBoxEmployeePicture.Name = "textBoxEmployeePicture";
            this.textBoxEmployeePicture.Size = new System.Drawing.Size(242, 20);
            this.textBoxEmployeePicture.TabIndex = 132;
            // 
            // comboBoxEmployeeGroup
            // 
            this.comboBoxEmployeeGroup.FormattingEnabled = true;
            this.comboBoxEmployeeGroup.Location = new System.Drawing.Point(115, 368);
            this.comboBoxEmployeeGroup.Name = "comboBoxEmployeeGroup";
            this.comboBoxEmployeeGroup.Size = new System.Drawing.Size(242, 21);
            this.comboBoxEmployeeGroup.TabIndex = 131;
            // 
            // comboBoxEmployeeCity
            // 
            this.comboBoxEmployeeCity.FormattingEnabled = true;
            this.comboBoxEmployeeCity.Location = new System.Drawing.Point(115, 172);
            this.comboBoxEmployeeCity.Name = "comboBoxEmployeeCity";
            this.comboBoxEmployeeCity.Size = new System.Drawing.Size(242, 21);
            this.comboBoxEmployeeCity.TabIndex = 130;
            // 
            // comboBoxEmployeeVoivodeship
            // 
            this.comboBoxEmployeeVoivodeship.FormattingEnabled = true;
            this.comboBoxEmployeeVoivodeship.Location = new System.Drawing.Point(115, 145);
            this.comboBoxEmployeeVoivodeship.Name = "comboBoxEmployeeVoivodeship";
            this.comboBoxEmployeeVoivodeship.Size = new System.Drawing.Size(242, 21);
            this.comboBoxEmployeeVoivodeship.TabIndex = 129;
            // 
            // textBoxEmployeePasswordConfirm
            // 
            this.textBoxEmployeePasswordConfirm.Location = new System.Drawing.Point(115, 342);
            this.textBoxEmployeePasswordConfirm.Name = "textBoxEmployeePasswordConfirm";
            this.textBoxEmployeePasswordConfirm.PasswordChar = '*';
            this.textBoxEmployeePasswordConfirm.Size = new System.Drawing.Size(242, 20);
            this.textBoxEmployeePasswordConfirm.TabIndex = 128;
            // 
            // textBoxEmployeeLogin
            // 
            this.textBoxEmployeeLogin.Location = new System.Drawing.Point(115, 290);
            this.textBoxEmployeeLogin.Name = "textBoxEmployeeLogin";
            this.textBoxEmployeeLogin.Size = new System.Drawing.Size(242, 20);
            this.textBoxEmployeeLogin.TabIndex = 127;
            // 
            // textBoxEmployeePassword
            // 
            this.textBoxEmployeePassword.Location = new System.Drawing.Point(115, 316);
            this.textBoxEmployeePassword.Name = "textBoxEmployeePassword";
            this.textBoxEmployeePassword.PasswordChar = '*';
            this.textBoxEmployeePassword.Size = new System.Drawing.Size(242, 20);
            this.textBoxEmployeePassword.TabIndex = 126;
            // 
            // textBoxEmployeePhoneNo
            // 
            this.textBoxEmployeePhoneNo.Location = new System.Drawing.Point(115, 198);
            this.textBoxEmployeePhoneNo.Name = "textBoxEmployeePhoneNo";
            this.textBoxEmployeePhoneNo.Size = new System.Drawing.Size(242, 20);
            this.textBoxEmployeePhoneNo.TabIndex = 125;
            // 
            // textBoxEmployeeDescription
            // 
            this.textBoxEmployeeDescription.Location = new System.Drawing.Point(115, 224);
            this.textBoxEmployeeDescription.Multiline = true;
            this.textBoxEmployeeDescription.Name = "textBoxEmployeeDescription";
            this.textBoxEmployeeDescription.Size = new System.Drawing.Size(242, 60);
            this.textBoxEmployeeDescription.TabIndex = 124;
            // 
            // textBoxEmployeePostalCode
            // 
            this.textBoxEmployeePostalCode.Location = new System.Drawing.Point(115, 119);
            this.textBoxEmployeePostalCode.Name = "textBoxEmployeePostalCode";
            this.textBoxEmployeePostalCode.Size = new System.Drawing.Size(242, 20);
            this.textBoxEmployeePostalCode.TabIndex = 123;
            // 
            // textBoxEmployeeStreet
            // 
            this.textBoxEmployeeStreet.Location = new System.Drawing.Point(115, 67);
            this.textBoxEmployeeStreet.Name = "textBoxEmployeeStreet";
            this.textBoxEmployeeStreet.Size = new System.Drawing.Size(242, 20);
            this.textBoxEmployeeStreet.TabIndex = 122;
            // 
            // textBoxEmployeeStreetNo
            // 
            this.textBoxEmployeeStreetNo.Location = new System.Drawing.Point(115, 93);
            this.textBoxEmployeeStreetNo.Name = "textBoxEmployeeStreetNo";
            this.textBoxEmployeeStreetNo.Size = new System.Drawing.Size(242, 20);
            this.textBoxEmployeeStreetNo.TabIndex = 121;
            // 
            // textBoxEmployeeFirstName
            // 
            this.textBoxEmployeeFirstName.Location = new System.Drawing.Point(115, 15);
            this.textBoxEmployeeFirstName.Name = "textBoxEmployeeFirstName";
            this.textBoxEmployeeFirstName.Size = new System.Drawing.Size(242, 20);
            this.textBoxEmployeeFirstName.TabIndex = 120;
            // 
            // textBoxEmployeeLastName
            // 
            this.textBoxEmployeeLastName.Location = new System.Drawing.Point(115, 41);
            this.textBoxEmployeeLastName.Name = "textBoxEmployeeLastName";
            this.textBoxEmployeeLastName.Size = new System.Drawing.Size(242, 20);
            this.textBoxEmployeeLastName.TabIndex = 119;
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 452);
            this.Controls.Add(this.buttonAddEmployee);
            this.Controls.Add(this.textBoxEmployeePicture);
            this.Controls.Add(this.comboBoxEmployeeGroup);
            this.Controls.Add(this.comboBoxEmployeeCity);
            this.Controls.Add(this.comboBoxEmployeeVoivodeship);
            this.Controls.Add(this.textBoxEmployeePasswordConfirm);
            this.Controls.Add(this.textBoxEmployeeLogin);
            this.Controls.Add(this.textBoxEmployeePassword);
            this.Controls.Add(this.textBoxEmployeePhoneNo);
            this.Controls.Add(this.textBoxEmployeeDescription);
            this.Controls.Add(this.textBoxEmployeePostalCode);
            this.Controls.Add(this.textBoxEmployeeStreet);
            this.Controls.Add(this.textBoxEmployeeStreetNo);
            this.Controls.Add(this.textBoxEmployeeFirstName);
            this.Controls.Add(this.textBoxEmployeeLastName);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(cityIDLabel1);
            this.Controls.Add(phoneNumberLabel1);
            this.Controls.Add(label13);
            this.Controls.Add(userGroupIDLabel);
            this.Controls.Add(firstNameLabel1);
            this.Controls.Add(postalCodeLabel1);
            this.Controls.Add(employeeDescriptionLabel);
            this.Controls.Add(lastNameLabel1);
            this.Controls.Add(streetNumerLabel1);
            this.Controls.Add(userPasswordLabel);
            this.Controls.Add(userLoginLabel);
            this.Controls.Add(streetLabel1);
            this.MaximumSize = new System.Drawing.Size(382, 491);
            this.MinimumSize = new System.Drawing.Size(382, 491);
            this.Name = "EmployeeForm";
            this.Text = "Pracownik";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonAddEmployee;
        private System.Windows.Forms.TextBox textBoxEmployeePicture;
        private System.Windows.Forms.ComboBox comboBoxEmployeeGroup;
        private System.Windows.Forms.ComboBox comboBoxEmployeeCity;
        private System.Windows.Forms.ComboBox comboBoxEmployeeVoivodeship;
        private System.Windows.Forms.TextBox textBoxEmployeePasswordConfirm;
        private System.Windows.Forms.TextBox textBoxEmployeeLogin;
        private System.Windows.Forms.TextBox textBoxEmployeePassword;
        private System.Windows.Forms.TextBox textBoxEmployeePhoneNo;
        private System.Windows.Forms.TextBox textBoxEmployeeDescription;
        private System.Windows.Forms.TextBox textBoxEmployeePostalCode;
        private System.Windows.Forms.TextBox textBoxEmployeeStreet;
        private System.Windows.Forms.TextBox textBoxEmployeeStreetNo;
        private System.Windows.Forms.TextBox textBoxEmployeeFirstName;
        private System.Windows.Forms.TextBox textBoxEmployeeLastName;
    }
}