namespace SenadorMidtermExam1
{
    partial class Form1
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
            this.btnVoteNo = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Label();
            this.btnVoteYes = new System.Windows.Forms.Button();
            this.btnFinalize = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVoteNo
            // 
            this.btnVoteNo.Location = new System.Drawing.Point(429, 120);
            this.btnVoteNo.Name = "btnVoteNo";
            this.btnVoteNo.Size = new System.Drawing.Size(64, 23);
            this.btnVoteNo.TabIndex = 1;
            this.btnVoteNo.Text = "NO";
            this.btnVoteNo.UseVisualStyleBackColor = true;
            this.btnVoteNo.Click += new System.EventHandler(this.btnVoteNo_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(326, 78);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(86, 13);
            this.lblResult.TabIndex = 2;
            this.lblResult.Text = "ARE YOU GAY?";
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(346, 178);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(0, 13);
            this.result.TabIndex = 3;
            // 
            // btnVoteYes
            // 
            this.btnVoteYes.Location = new System.Drawing.Point(216, 120);
            this.btnVoteYes.Name = "btnVoteYes";
            this.btnVoteYes.Size = new System.Drawing.Size(75, 23);
            this.btnVoteYes.TabIndex = 4;
            this.btnVoteYes.Text = "YES";
            this.btnVoteYes.UseVisualStyleBackColor = true;
            this.btnVoteYes.Click += new System.EventHandler(this.btnVoteYes_Click);
            // 
            // btnFinalize
            // 
            this.btnFinalize.Location = new System.Drawing.Point(329, 178);
            this.btnFinalize.Name = "btnFinalize";
            this.btnFinalize.Size = new System.Drawing.Size(75, 23);
            this.btnFinalize.TabIndex = 5;
            this.btnFinalize.Text = "ENTER";
            this.btnFinalize.UseVisualStyleBackColor = true;
            this.btnFinalize.Click += new System.EventHandler(this.btnFinalize_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 450);
            this.Controls.Add(this.btnFinalize);
            this.Controls.Add(this.btnVoteYes);
            this.Controls.Add(this.result);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnVoteNo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnVoteNo;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Button btnVoteYes;
        private System.Windows.Forms.Button btnFinalize;
    }
}

