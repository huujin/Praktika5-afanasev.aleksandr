
namespace HOmework._18
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
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Clear = new System.Windows.Forms.Button();
            this.Draw = new System.Windows.Forms.Button();
            this.Alive = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer1.Panel2.Controls.Add(this.Alive);
            this.splitContainer1.Panel2.Controls.Add(this.Draw);
            this.splitContainer1.Panel2.Controls.Add(this.Clear);
            this.splitContainer1.Size = new System.Drawing.Size(562, 450);
            this.splitContainer1.SplitterDistance = 329;
            this.splitContainer1.TabIndex = 0;
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(12, 65);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(240, 40);
            this.Clear.TabIndex = 1;
            this.Clear.Text = "Стереть";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Draw
            // 
            this.Draw.Location = new System.Drawing.Point(12, 16);
            this.Draw.Name = "Draw";
            this.Draw.Size = new System.Drawing.Size(240, 40);
            this.Draw.TabIndex = 2;
            this.Draw.Text = "Нарисовать";
            this.Draw.UseVisualStyleBackColor = true;
            this.Draw.Click += new System.EventHandler(this.Draw_Click);
            // 
            // Alive
            // 
            this.Alive.Location = new System.Drawing.Point(310, 16);
            this.Alive.Name = "Alive";
            this.Alive.Size = new System.Drawing.Size(240, 40);
            this.Alive.TabIndex = 3;
            this.Alive.Text = "Оживить";
            this.Alive.UseVisualStyleBackColor = true;
            this.Alive.Click += new System.EventHandler(this.Alive_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button Alive;
        private System.Windows.Forms.Button Draw;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Timer timer1;
    }
}

