namespace HospitalProject
{
    partial class Registration
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnalreday = new System.Windows.Forms.Button();
            this.textBoxregcp = new System.Windows.Forms.TextBox();
            this.Btnregister = new System.Windows.Forms.Button();
            this.textBoxReguser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxregemail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxregpass = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnalreday);
            this.panel1.Controls.Add(this.textBoxregcp);
            this.panel1.Controls.Add(this.Btnregister);
            this.panel1.Controls.Add(this.textBoxReguser);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBoxregemail);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBoxregpass);
            this.panel1.Location = new System.Drawing.Point(266, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(529, 546);
            this.panel1.TabIndex = 23;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(468, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 37);
            this.button1.TabIndex = 22;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(43, 143);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 28);
            this.label1.TabIndex = 15;
            this.label1.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(85, 53);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(333, 42);
            this.label5.TabIndex = 19;
            this.label5.Text = "Registration Page";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnalreday
            // 
            this.btnalreday.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnalreday.Location = new System.Drawing.Point(48, 482);
            this.btnalreday.Name = "btnalreday";
            this.btnalreday.Size = new System.Drawing.Size(423, 41);
            this.btnalreday.TabIndex = 4;
            this.btnalreday.Text = "Already have an account? Login";
            this.btnalreday.UseVisualStyleBackColor = false;
            this.btnalreday.Click += new System.EventHandler(this.btnalreday_Click);
            // 
            // textBoxregcp
            // 
            this.textBoxregcp.Location = new System.Drawing.Point(239, 353);
            this.textBoxregcp.Name = "textBoxregcp";
            this.textBoxregcp.PasswordChar = '*';
            this.textBoxregcp.Size = new System.Drawing.Size(232, 26);
            this.textBoxregcp.TabIndex = 21;
            this.textBoxregcp.TextChanged += new System.EventHandler(this.textBoxregcp_TextChanged);
            this.textBoxregcp.Leave += new System.EventHandler(this.textBoxregcp_Leave);
            // 
            // Btnregister
            // 
            this.Btnregister.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btnregister.Location = new System.Drawing.Point(48, 414);
            this.Btnregister.Name = "Btnregister";
            this.Btnregister.Size = new System.Drawing.Size(423, 44);
            this.Btnregister.TabIndex = 3;
            this.Btnregister.Text = "Register";
            this.Btnregister.UseVisualStyleBackColor = false;
            this.Btnregister.Click += new System.EventHandler(this.Btnregister_Click);
            // 
            // textBoxReguser
            // 
            this.textBoxReguser.Location = new System.Drawing.Point(239, 147);
            this.textBoxReguser.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBoxReguser.Name = "textBoxReguser";
            this.textBoxReguser.Size = new System.Drawing.Size(232, 26);
            this.textBoxReguser.TabIndex = 0;
            this.textBoxReguser.TextChanged += new System.EventHandler(this.textBoxReguser_TextChanged);
            this.textBoxReguser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxReguser_KeyPress);
            this.textBoxReguser.Leave += new System.EventHandler(this.textBoxReguser_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(43, 349);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 28);
            this.label3.TabIndex = 20;
            this.label3.Text = "Confirm-Pass";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(43, 208);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 28);
            this.label2.TabIndex = 16;
            this.label2.Text = "Email-Id";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxregemail
            // 
            this.textBoxregemail.Location = new System.Drawing.Point(239, 212);
            this.textBoxregemail.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBoxregemail.Name = "textBoxregemail";
            this.textBoxregemail.Size = new System.Drawing.Size(232, 26);
            this.textBoxregemail.TabIndex = 1;
            this.textBoxregemail.TextChanged += new System.EventHandler(this.textBoxregemail_TextChanged);
            this.textBoxregemail.Leave += new System.EventHandler(this.textBoxregemail_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(43, 277);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 28);
            this.label4.TabIndex = 18;
            this.label4.Text = "Password";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBoxregpass
            // 
            this.textBoxregpass.Location = new System.Drawing.Point(239, 281);
            this.textBoxregpass.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBoxregpass.Name = "textBoxregpass";
            this.textBoxregpass.PasswordChar = '*';
            this.textBoxregpass.Size = new System.Drawing.Size(232, 26);
            this.textBoxregpass.TabIndex = 2;
            this.textBoxregpass.TextChanged += new System.EventHandler(this.textBoxregpass_TextChanged);
            this.textBoxregpass.Leave += new System.EventHandler(this.textBoxregpass_Leave);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HospitalProject.MyResource.bg32;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1060, 722);
            this.Controls.Add(this.panel1);
            this.Name = "Registration";
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.Registration_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnalreday;
        private System.Windows.Forms.TextBox textBoxregcp;
        private System.Windows.Forms.Button Btnregister;
        private System.Windows.Forms.TextBox textBoxReguser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxregemail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxregpass;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
    }
}