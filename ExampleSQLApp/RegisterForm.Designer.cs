namespace ExampleSQLApp
{
    partial class RegisterForm
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
            this.Registration = new System.Windows.Forms.Label();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.LoginBox = new System.Windows.Forms.TextBox();
            this.Close = new System.Windows.Forms.Label();
            this.HideShow = new System.Windows.Forms.Button();
            this.ButtonRegister = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ToLognForm = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Registration
            // 
            this.Registration.BackColor = System.Drawing.Color.BlueViolet;
            this.Registration.Font = new System.Drawing.Font("Corbel", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Registration.Location = new System.Drawing.Point(65, 76);
            this.Registration.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Registration.Name = "Registration";
            this.Registration.Size = new System.Drawing.Size(513, 65);
            this.Registration.TabIndex = 2;
            this.Registration.Text = "Регистрация";
            this.Registration.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // PasswordBox
            // 
            this.PasswordBox.Font = new System.Drawing.Font("Corbel", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordBox.Location = new System.Drawing.Point(147, 321);
            this.PasswordBox.Margin = new System.Windows.Forms.Padding(4);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(431, 52);
            this.PasswordBox.TabIndex = 10;
            this.PasswordBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PasswordBox.UseSystemPasswordChar = true;
            this.PasswordBox.WordWrap = false;
            // 
            // LoginBox
            // 
            this.LoginBox.Font = new System.Drawing.Font("Corbel", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginBox.Location = new System.Drawing.Point(147, 209);
            this.LoginBox.Margin = new System.Windows.Forms.Padding(4);
            this.LoginBox.Multiline = true;
            this.LoginBox.Name = "LoginBox";
            this.LoginBox.Size = new System.Drawing.Size(431, 67);
            this.LoginBox.TabIndex = 9;
            // 
            // Close
            // 
            this.Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close.Font = new System.Drawing.Font("RomanT", 26F, System.Drawing.FontStyle.Bold);
            this.Close.Location = new System.Drawing.Point(868, 0);
            this.Close.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(79, 60);
            this.Close.TabIndex = 11;
            this.Close.Text = "x";
            this.Close.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            this.Close.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Close_MouseDown);
            this.Close.MouseEnter += new System.EventHandler(this.Close_MouseEnter);
            this.Close.MouseLeave += new System.EventHandler(this.Close_MouseLeave);
            // 
            // HideShow
            // 
            this.HideShow.BackgroundImage = global::ExampleSQLApp.Properties.Resources.eye_off_icon;
            this.HideShow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HideShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HideShow.FlatAppearance.BorderSize = 0;
            this.HideShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HideShow.Location = new System.Drawing.Point(587, 321);
            this.HideShow.Margin = new System.Windows.Forms.Padding(4);
            this.HideShow.Name = "HideShow";
            this.HideShow.Size = new System.Drawing.Size(77, 68);
            this.HideShow.TabIndex = 13;
            this.HideShow.UseVisualStyleBackColor = true;
            this.HideShow.Click += new System.EventHandler(this.HideShow_Click);
            // 
            // ButtonRegister
            // 
            this.ButtonRegister.BackgroundImage = global::ExampleSQLApp.Properties.Resources.arrow_right_icon;
            this.ButtonRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonRegister.FlatAppearance.BorderSize = 0;
            this.ButtonRegister.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Indigo;
            this.ButtonRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonRegister.Location = new System.Drawing.Point(744, 394);
            this.ButtonRegister.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonRegister.Name = "ButtonRegister";
            this.ButtonRegister.Size = new System.Drawing.Size(96, 89);
            this.ButtonRegister.TabIndex = 12;
            this.ButtonRegister.UseVisualStyleBackColor = true;
            this.ButtonRegister.Click += new System.EventHandler(this.ButtonRegister_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ExampleSQLApp.Properties.Resources.lock_security_icon;
            this.pictureBox2.Location = new System.Drawing.Point(65, 321);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(73, 68);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ExampleSQLApp.Properties.Resources.user_icon;
            this.pictureBox1.Location = new System.Drawing.Point(65, 209);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // ToLognForm
            // 
            this.ToLognForm.AutoSize = true;
            this.ToLognForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ToLognForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ToLognForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToLognForm.Location = new System.Drawing.Point(61, 463);
            this.ToLognForm.Name = "ToLognForm";
            this.ToLognForm.Size = new System.Drawing.Size(214, 20);
            this.ToLognForm.TabIndex = 14;
            this.ToLognForm.Text = "Уже зарегистрированы?";
            this.ToLognForm.Click += new System.EventHandler(this.ToLognForm_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlueViolet;
            this.ClientSize = new System.Drawing.Size(947, 521);
            this.Controls.Add(this.ToLognForm);
            this.Controls.Add(this.HideShow);
            this.Controls.Add(this.ButtonRegister);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.LoginBox);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Registration);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RegisterForm";
            this.Text = "SinginForm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RegisterForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RegisterForm_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Registration;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.TextBox LoginBox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Close;
        private System.Windows.Forms.Button ButtonRegister;
        private System.Windows.Forms.Button HideShow;
        private System.Windows.Forms.Label ToLognForm;
    }
}