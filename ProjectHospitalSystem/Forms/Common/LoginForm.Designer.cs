namespace ProjectHospitalSystem
{
    partial class LoginForm
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
            txt_userName = new TextBox();
            txt_Password = new TextBox();
            button1 = new Button();
            btn_clear = new Button();
            SuspendLayout();
            // 
            // txt_userName
            // 
            txt_userName.Location = new Point(358, 76);
            txt_userName.Name = "txt_userName";
            txt_userName.Size = new Size(194, 23);
            txt_userName.TabIndex = 0;
            // 
            // txt_Password
            // 
            txt_Password.Location = new Point(358, 165);
            txt_Password.Name = "txt_Password";
            txt_Password.Size = new Size(194, 23);
            txt_Password.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(417, 231);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btn_clear
            // 
            btn_clear.Location = new Point(514, 231);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(75, 23);
            btn_clear.TabIndex = 3;
            btn_clear.Text = "clear";
            btn_clear.UseVisualStyleBackColor = true;
            btn_clear.Click += btn_clear_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_clear);
            Controls.Add(button1);
            Controls.Add(txt_Password);
            Controls.Add(txt_userName);
            Name = "LoginForm";
            Text = "Login";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_userName;
        private TextBox txt_Password;
        private Button button1;
        private Button btn_clear;
    }
}
