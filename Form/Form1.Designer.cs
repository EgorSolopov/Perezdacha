
namespace task8_26
{
    partial class MainForm
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
            this.Panel = new System.Windows.Forms.FlowLayoutPanel();
            this.AddHouse = new System.Windows.Forms.Button();
            this.SlowTechnics = new System.Windows.Forms.Button();
            this.FastTechnics = new System.Windows.Forms.Button();
            this.InstantTechnics = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Panel
            // 
            this.Panel.AutoScroll = true;
            this.Panel.Location = new System.Drawing.Point(12, 53);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(1384, 453);
            this.Panel.TabIndex = 0;
            // 
            // AddHouse
            // 
            this.AddHouse.Location = new System.Drawing.Point(12, 12);
            this.AddHouse.Name = "AddHouse";
            this.AddHouse.Size = new System.Drawing.Size(139, 35);
            this.AddHouse.TabIndex = 1;
            this.AddHouse.Text = "Добавить здание";
            this.AddHouse.UseVisualStyleBackColor = true;
            this.AddHouse.Click += new System.EventHandler(this.AddBolide_Click);
            // 
            // SlowTechnics
            // 
            this.SlowTechnics.Location = new System.Drawing.Point(967, 12);
            this.SlowTechnics.Name = "SlowTechnics";
            this.SlowTechnics.Size = new System.Drawing.Size(139, 35);
            this.SlowTechnics.TabIndex = 2;
            this.SlowTechnics.Text = "SlowTechnics";
            this.SlowTechnics.UseVisualStyleBackColor = true;
            this.SlowTechnics.Click += new System.EventHandler(this.SlowLoader_Click);
            // 
            // FastTechnics
            // 
            this.FastTechnics.Location = new System.Drawing.Point(1112, 12);
            this.FastTechnics.Name = "FastTechnics";
            this.FastTechnics.Size = new System.Drawing.Size(139, 35);
            this.FastTechnics.TabIndex = 3;
            this.FastTechnics.Text = "FastTechnics";
            this.FastTechnics.UseVisualStyleBackColor = true;
            this.FastTechnics.Click += new System.EventHandler(this.FastLoader_Click);
            // 
            // InstantTechnics
            // 
            this.InstantTechnics.Location = new System.Drawing.Point(1257, 12);
            this.InstantTechnics.Name = "InstantTechnics";
            this.InstantTechnics.Size = new System.Drawing.Size(139, 35);
            this.InstantTechnics.TabIndex = 4;
            this.InstantTechnics.Text = "InstantTechnics";
            this.InstantTechnics.UseVisualStyleBackColor = true;
            this.InstantTechnics.Click += new System.EventHandler(this.InstantLoader_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1408, 518);
            this.Controls.Add(this.InstantTechnics);
            this.Controls.Add(this.FastTechnics);
            this.Controls.Add(this.SlowTechnics);
            this.Controls.Add(this.AddHouse);
            this.Controls.Add(this.Panel);
            this.MaximumSize = new System.Drawing.Size(1426, 565);
            this.MinimumSize = new System.Drawing.Size(1426, 565);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel Panel;
        private System.Windows.Forms.Button AddHouse;
        private System.Windows.Forms.Button SlowTechnics;
        private System.Windows.Forms.Button FastTechnics;
        private System.Windows.Forms.Button InstantTechnics;
    }
}

