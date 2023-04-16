
namespace ООП_4
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
            this.paintField = new System.Windows.Forms.PictureBox();
            this.CtrlCheck = new System.Windows.Forms.CheckBox();
            this.deleteAll = new System.Windows.Forms.Button();
            this.selectAll = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.paintField)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // paintField
            // 
            this.paintField.BackColor = System.Drawing.Color.LightGray;
            this.paintField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paintField.Location = new System.Drawing.Point(0, 0);
            this.paintField.Name = "paintField";
            this.paintField.Size = new System.Drawing.Size(754, 379);
            this.paintField.TabIndex = 0;
            this.paintField.TabStop = false;
            this.paintField.Click += new System.EventHandler(this.paintField_Click);
            this.paintField.Paint += new System.Windows.Forms.PaintEventHandler(this.paintField_Paint);
            this.paintField.MouseClick += new System.Windows.Forms.MouseEventHandler(this.paintField_MouseClick);
            // 
            // CtrlCheck
            // 
            this.CtrlCheck.AutoSize = true;
            this.CtrlCheck.Location = new System.Drawing.Point(601, 399);
            this.CtrlCheck.Name = "CtrlCheck";
            this.CtrlCheck.Size = new System.Drawing.Size(75, 17);
            this.CtrlCheck.TabIndex = 0;
            this.CtrlCheck.TabStop = false;
            this.CtrlCheck.Text = "Ctrl зажат";
            this.CtrlCheck.UseVisualStyleBackColor = true;
            this.CtrlCheck.CheckedChanged += new System.EventHandler(this.CtrlCheck_CheckedChanged);
            // 
            // deleteAll
            // 
            this.deleteAll.Location = new System.Drawing.Point(308, 392);
            this.deleteAll.Name = "deleteAll";
            this.deleteAll.Size = new System.Drawing.Size(186, 29);
            this.deleteAll.TabIndex = 1;
            this.deleteAll.Text = "Удалить все";
            this.deleteAll.UseCompatibleTextRendering = true;
            this.deleteAll.UseVisualStyleBackColor = true;
            this.deleteAll.Click += new System.EventHandler(this.deleteAll_Click);
            // 
            // selectAll
            // 
            this.selectAll.AutoSize = true;
            this.selectAll.Location = new System.Drawing.Point(601, 422);
            this.selectAll.Name = "selectAll";
            this.selectAll.Size = new System.Drawing.Size(178, 17);
            this.selectAll.TabIndex = 2;
            this.selectAll.Text = "Выдеять несколько объектов";
            this.selectAll.UseVisualStyleBackColor = true;
            this.selectAll.CheckedChanged += new System.EventHandler(this.selectAll_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.paintField);
            this.panel1.Location = new System.Drawing.Point(21, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(756, 381);
            this.panel1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.selectAll);
            this.Controls.Add(this.deleteAll);
            this.Controls.Add(this.CtrlCheck);
            this.Controls.Add(this.panel1);
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.paintField)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox paintField;
        private System.Windows.Forms.CheckBox CtrlCheck;
        private System.Windows.Forms.Button deleteAll;
        private System.Windows.Forms.CheckBox selectAll;
        private System.Windows.Forms.Panel panel1;
    }
}

