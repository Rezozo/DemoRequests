namespace Zayvka
{
    partial class ApplicationControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.numberLbl = new System.Windows.Forms.Label();
            this.clientNameLbl = new System.Windows.Forms.Label();
            this.statusBox = new System.Windows.Forms.ComboBox();
            this.status = new System.Windows.Forms.Label();
            this.staffBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.phoneNumberLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.priorityBox = new System.Windows.Forms.ComboBox();
            this.finishDatePick = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.equipmentLbl = new System.Windows.Forms.Label();
            this.faultLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.problemTxt = new System.Windows.Forms.TextBox();
            this.commentTxt = new System.Windows.Forms.TextBox();
            this.commentLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // numberLbl
            // 
            this.numberLbl.AutoSize = true;
            this.numberLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberLbl.Location = new System.Drawing.Point(3, 11);
            this.numberLbl.Name = "numberLbl";
            this.numberLbl.Size = new System.Drawing.Size(119, 16);
            this.numberLbl.TabIndex = 0;
            this.numberLbl.Text = "Номер заявки: ";
            // 
            // clientNameLbl
            // 
            this.clientNameLbl.AutoSize = true;
            this.clientNameLbl.Location = new System.Drawing.Point(3, 31);
            this.clientNameLbl.Name = "clientNameLbl";
            this.clientNameLbl.Size = new System.Drawing.Size(60, 16);
            this.clientNameLbl.TabIndex = 1;
            this.clientNameLbl.Text = "Клиент: ";
            // 
            // statusBox
            // 
            this.statusBox.FormattingEnabled = true;
            this.statusBox.Items.AddRange(new object[] {
            "В ожидании",
            "В работе",
            "Выполнено"});
            this.statusBox.Location = new System.Drawing.Point(796, 11);
            this.statusBox.Name = "statusBox";
            this.statusBox.Size = new System.Drawing.Size(190, 24);
            this.statusBox.TabIndex = 2;
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(731, 14);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(59, 16);
            this.status.TabIndex = 3;
            this.status.Text = "Статус: ";
            // 
            // staffBox
            // 
            this.staffBox.FormattingEnabled = true;
            this.staffBox.Items.AddRange(new object[] {
            "В ожидании",
            "В работе",
            "Выполнено"});
            this.staffBox.Location = new System.Drawing.Point(734, 41);
            this.staffBox.Name = "staffBox";
            this.staffBox.Size = new System.Drawing.Size(252, 24);
            this.staffBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(650, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Сотрудник";
            // 
            // phoneNumberLbl
            // 
            this.phoneNumberLbl.AutoSize = true;
            this.phoneNumberLbl.Location = new System.Drawing.Point(650, 68);
            this.phoneNumberLbl.Name = "phoneNumberLbl";
            this.phoneNumberLbl.Size = new System.Drawing.Size(128, 16);
            this.phoneNumberLbl.TabIndex = 6;
            this.phoneNumberLbl.Text = "Номер телефона:  ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(705, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Приоритет: ";
            // 
            // priorityBox
            // 
            this.priorityBox.FormattingEnabled = true;
            this.priorityBox.Items.AddRange(new object[] {
            "Низкий",
            "Средний",
            "Высокий"});
            this.priorityBox.Location = new System.Drawing.Point(796, 116);
            this.priorityBox.Name = "priorityBox";
            this.priorityBox.Size = new System.Drawing.Size(190, 24);
            this.priorityBox.TabIndex = 7;
            // 
            // finishDatePick
            // 
            this.finishDatePick.Location = new System.Drawing.Point(796, 88);
            this.finishDatePick.Name = "finishDatePick";
            this.finishDatePick.Size = new System.Drawing.Size(190, 22);
            this.finishDatePick.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(662, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Дата завершения: ";
            // 
            // equipmentLbl
            // 
            this.equipmentLbl.AutoSize = true;
            this.equipmentLbl.Location = new System.Drawing.Point(3, 49);
            this.equipmentLbl.Name = "equipmentLbl";
            this.equipmentLbl.Size = new System.Drawing.Size(139, 20);
            this.equipmentLbl.TabIndex = 11;
            this.equipmentLbl.Text = "Оборудование: ";
            // 
            // faultLbl
            // 
            this.faultLbl.AutoSize = true;
            this.faultLbl.Location = new System.Drawing.Point(3, 69);
            this.faultLbl.Name = "faultLbl";
            this.faultLbl.Size = new System.Drawing.Size(174, 20);
            this.faultLbl.TabIndex = 12;
            this.faultLbl.Text = "Тип неисправности:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Описание проблемы: ";
            // 
            // problemTxt
            // 
            this.problemTxt.Location = new System.Drawing.Point(6, 112);
            this.problemTxt.Multiline = true;
            this.problemTxt.Name = "problemTxt";
            this.problemTxt.Size = new System.Drawing.Size(693, 58);
            this.problemTxt.TabIndex = 14;
            // 
            // commentTxt
            // 
            this.commentTxt.Location = new System.Drawing.Point(6, 197);
            this.commentTxt.Multiline = true;
            this.commentTxt.Name = "commentTxt";
            this.commentTxt.Size = new System.Drawing.Size(980, 58);
            this.commentTxt.TabIndex = 16;
            this.commentTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.commentTxt_KeyPress);
            // 
            // commentLbl
            // 
            this.commentLbl.AutoSize = true;
            this.commentLbl.Location = new System.Drawing.Point(3, 174);
            this.commentLbl.Name = "commentLbl";
            this.commentLbl.Size = new System.Drawing.Size(124, 20);
            this.commentLbl.TabIndex = 15;
            this.commentLbl.Text = "Комментарий:";
            // 
            // ApplicationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.commentTxt);
            this.Controls.Add(this.commentLbl);
            this.Controls.Add(this.problemTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.faultLbl);
            this.Controls.Add(this.equipmentLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.finishDatePick);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.priorityBox);
            this.Controls.Add(this.phoneNumberLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.staffBox);
            this.Controls.Add(this.status);
            this.Controls.Add(this.statusBox);
            this.Controls.Add(this.clientNameLbl);
            this.Controls.Add(this.numberLbl);
            this.Name = "ApplicationControl";
            this.Size = new System.Drawing.Size(1000, 266);
            this.Load += new System.EventHandler(this.ApplicationControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label numberLbl;
        private System.Windows.Forms.Label clientNameLbl;
        private System.Windows.Forms.ComboBox statusBox;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.ComboBox staffBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label phoneNumberLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox priorityBox;
        private System.Windows.Forms.DateTimePicker finishDatePick;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label equipmentLbl;
        private System.Windows.Forms.Label faultLbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox problemTxt;
        private System.Windows.Forms.TextBox commentTxt;
        private System.Windows.Forms.Label commentLbl;
    }
}
