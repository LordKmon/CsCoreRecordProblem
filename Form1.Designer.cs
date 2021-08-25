namespace WriteCSCoreProblem
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_StartRecord = new System.Windows.Forms.Button();
            this.btn_Stop = new System.Windows.Forms.Button();
            this.l_Status = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_StartRecord
            // 
            this.btn_StartRecord.Location = new System.Drawing.Point(123, 73);
            this.btn_StartRecord.Name = "btn_StartRecord";
            this.btn_StartRecord.Size = new System.Drawing.Size(137, 61);
            this.btn_StartRecord.TabIndex = 0;
            this.btn_StartRecord.Text = "Start record!";
            this.btn_StartRecord.UseVisualStyleBackColor = true;
            this.btn_StartRecord.Click += new System.EventHandler(this.btn_StartRecord_Click);
            // 
            // btn_Stop
            // 
            this.btn_Stop.Location = new System.Drawing.Point(123, 189);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(137, 66);
            this.btn_Stop.TabIndex = 1;
            this.btn_Stop.Text = "Stop record";
            this.btn_Stop.UseVisualStyleBackColor = true;
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // l_Status
            // 
            this.l_Status.AutoSize = true;
            this.l_Status.Location = new System.Drawing.Point(302, 107);
            this.l_Status.Name = "l_Status";
            this.l_Status.Size = new System.Drawing.Size(16, 13);
            this.l_Status.TabIndex = 2;
            this.l_Status.Text = "...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 369);
            this.Controls.Add(this.l_Status);
            this.Controls.Add(this.btn_Stop);
            this.Controls.Add(this.btn_StartRecord);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_StartRecord;
        private System.Windows.Forms.Button btn_Stop;
        private System.Windows.Forms.Label l_Status;
    }
}

