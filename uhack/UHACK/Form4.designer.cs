namespace GGboi
{
    partial class Form4
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
            this.btnview = new System.Windows.Forms.Button();
            this.btnmessage = new System.Windows.Forms.Button();
            this.btnregister = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnview
            // 
            this.btnview.BackColor = System.Drawing.Color.Red;
            this.btnview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnview.FlatAppearance.BorderSize = 0;
            this.btnview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnview.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnview.Location = new System.Drawing.Point(74, 106);
            this.btnview.Name = "btnview";
            this.btnview.Size = new System.Drawing.Size(149, 93);
            this.btnview.TabIndex = 1;
            this.btnview.Text = "View";
            this.btnview.UseVisualStyleBackColor = false;
            this.btnview.Click += new System.EventHandler(this.btnview_Click);
            // 
            // btnmessage
            // 
            this.btnmessage.BackColor = System.Drawing.Color.Red;
            this.btnmessage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnmessage.FlatAppearance.BorderSize = 0;
            this.btnmessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmessage.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmessage.Location = new System.Drawing.Point(171, 217);
            this.btnmessage.Name = "btnmessage";
            this.btnmessage.Size = new System.Drawing.Size(149, 93);
            this.btnmessage.TabIndex = 2;
            this.btnmessage.Text = "Message";
            this.btnmessage.UseVisualStyleBackColor = false;
            this.btnmessage.Click += new System.EventHandler(this.btnmessage_Click);
            // 
            // btnregister
            // 
            this.btnregister.BackColor = System.Drawing.Color.Red;
            this.btnregister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnregister.FlatAppearance.BorderSize = 0;
            this.btnregister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnregister.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregister.Location = new System.Drawing.Point(267, 106);
            this.btnregister.Name = "btnregister";
            this.btnregister.Size = new System.Drawing.Size(149, 93);
            this.btnregister.TabIndex = 3;
            this.btnregister.Text = "Register";
            this.btnregister.UseVisualStyleBackColor = false;
            this.btnregister.Click += new System.EventHandler(this.btnregister_Click);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.Crimson;
            this.btnexit.FlatAppearance.BorderSize = 0;
            this.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexit.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(425, 12);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(65, 23);
            this.btnexit.TabIndex = 5;
            this.btnexit.Text = "Logout";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(183, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Select Operation";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(502, 369);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnregister);
            this.Controls.Add(this.btnmessage);
            this.Controls.Add(this.btnview);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnview;
        private System.Windows.Forms.Button btnmessage;
        private System.Windows.Forms.Button btnregister;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Label label1;
    }
}