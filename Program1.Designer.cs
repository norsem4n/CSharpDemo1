namespace CKarnasProgram1
{
    partial class Program1
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
            this.lblMovieTitle = new System.Windows.Forms.Label();
            this.btnLeadActress = new System.Windows.Forms.Button();
            this.btnLeadActor = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLeadDirector = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblAcclaim = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMovieTitle
            // 
            this.lblMovieTitle.AutoSize = true;
            this.lblMovieTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieTitle.Location = new System.Drawing.Point(395, 25);
            this.lblMovieTitle.Name = "lblMovieTitle";
            this.lblMovieTitle.Size = new System.Drawing.Size(95, 31);
            this.lblMovieTitle.TabIndex = 0;
            this.lblMovieTitle.Text = "Titanic";
            // 
            // btnLeadActress
            // 
            this.btnLeadActress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeadActress.Location = new System.Drawing.Point(201, 91);
            this.btnLeadActress.Name = "btnLeadActress";
            this.btnLeadActress.Size = new System.Drawing.Size(117, 44);
            this.btnLeadActress.TabIndex = 1;
            this.btnLeadActress.Text = "Lead Actress";
            this.btnLeadActress.UseVisualStyleBackColor = true;
            this.btnLeadActress.Click += new System.EventHandler(this.btnLeadActress_Click);
            // 
            // btnLeadActor
            // 
            this.btnLeadActor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeadActor.Location = new System.Drawing.Point(388, 91);
            this.btnLeadActor.Name = "btnLeadActor";
            this.btnLeadActor.Size = new System.Drawing.Size(117, 44);
            this.btnLeadActor.TabIndex = 5;
            this.btnLeadActor.Text = "Lead Actor";
            this.btnLeadActor.UseVisualStyleBackColor = true;
            this.btnLeadActor.Click += new System.EventHandler(this.btnLeadActor_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(492, 297);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(117, 44);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLeadDirector
            // 
            this.btnLeadDirector.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeadDirector.Location = new System.Drawing.Point(578, 91);
            this.btnLeadDirector.Name = "btnLeadDirector";
            this.btnLeadDirector.Size = new System.Drawing.Size(117, 44);
            this.btnLeadDirector.TabIndex = 7;
            this.btnLeadDirector.Text = "Lead Director";
            this.btnLeadDirector.UseVisualStyleBackColor = true;
            this.btnLeadDirector.Click += new System.EventHandler(this.btnLeadDirector_Click);
            // 
            // lblResult
            // 
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResult.Location = new System.Drawing.Point(283, 161);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(326, 64);
            this.lblResult.TabIndex = 8;
            // 
            // lblAcclaim
            // 
            this.lblAcclaim.AutoSize = true;
            this.lblAcclaim.Location = new System.Drawing.Point(679, 454);
            this.lblAcclaim.Name = "lblAcclaim";
            this.lblAcclaim.Size = new System.Drawing.Size(109, 15);
            this.lblAcclaim.TabIndex = 9;
            this.lblAcclaim.Text = "Developed by CGK";
            // 
            // Program1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 499);
            this.Controls.Add(this.lblAcclaim);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnLeadDirector);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLeadActor);
            this.Controls.Add(this.btnLeadActress);
            this.Controls.Add(this.lblMovieTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Program1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Assignment Set 1 - Program 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMovieTitle;
        private System.Windows.Forms.Button btnLeadActress;
        private System.Windows.Forms.Button btnLeadActor;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnLeadDirector;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblAcclaim;
    }
}