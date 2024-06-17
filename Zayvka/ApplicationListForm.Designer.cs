namespace Zayvka
{
    partial class ApplicationListForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.createApplication = new System.Windows.Forms.Button();
            this.applicationsFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.searchTxt = new System.Windows.Forms.TextBox();
            this.statsBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Все заявки";
            // 
            // createApplication
            // 
            this.createApplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createApplication.Location = new System.Drawing.Point(831, 49);
            this.createApplication.Name = "createApplication";
            this.createApplication.Size = new System.Drawing.Size(209, 35);
            this.createApplication.TabIndex = 8;
            this.createApplication.Text = "Создать заявку";
            this.createApplication.UseVisualStyleBackColor = true;
            this.createApplication.Click += new System.EventHandler(this.createApplication_Click);
            // 
            // applicationsFlowPanel
            // 
            this.applicationsFlowPanel.Location = new System.Drawing.Point(17, 90);
            this.applicationsFlowPanel.Name = "applicationsFlowPanel";
            this.applicationsFlowPanel.Size = new System.Drawing.Size(1020, 627);
            this.applicationsFlowPanel.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Поиск: ";
            // 
            // searchTxt
            // 
            this.searchTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchTxt.Location = new System.Drawing.Point(97, 51);
            this.searchTxt.Name = "searchTxt";
            this.searchTxt.Size = new System.Drawing.Size(262, 30);
            this.searchTxt.TabIndex = 11;
            this.searchTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchTxt_KeyPress);
            // 
            // statsBtn
            // 
            this.statsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statsBtn.Location = new System.Drawing.Point(380, 49);
            this.statsBtn.Name = "statsBtn";
            this.statsBtn.Size = new System.Drawing.Size(237, 35);
            this.statsBtn.TabIndex = 12;
            this.statsBtn.Text = "Просмотр статистики";
            this.statsBtn.UseVisualStyleBackColor = true;
            this.statsBtn.Click += new System.EventHandler(this.statsBtn_Click);
            // 
            // ApplicationListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 729);
            this.Controls.Add(this.statsBtn);
            this.Controls.Add(this.searchTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.applicationsFlowPanel);
            this.Controls.Add(this.createApplication);
            this.Controls.Add(this.label1);
            this.Name = "ApplicationListForm";
            this.Text = "Все заявки";
            this.Load += new System.EventHandler(this.ApplicationListForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button createApplication;
        private System.Windows.Forms.FlowLayoutPanel applicationsFlowPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox searchTxt;
        private System.Windows.Forms.Button statsBtn;
    }
}