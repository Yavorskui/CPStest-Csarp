namespace CPStest
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
            this.cliackarea = new System.Windows.Forms.Button();
            this.s3btn = new System.Windows.Forms.Button();
            this.s5btn = new System.Windows.Forms.Button();
            this.s10btn = new System.Windows.Forms.Button();
            this.s30btn = new System.Windows.Forms.Button();
            this.maintimer = new System.Windows.Forms.Timer(this.components);
            this.customsecondbtn = new System.Windows.Forms.Button();
            this.clickcounter = new System.Windows.Forms.Label();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // cliackarea
            // 
            this.cliackarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cliackarea.Location = new System.Drawing.Point(12, 12);
            this.cliackarea.Name = "cliackarea";
            this.cliackarea.Size = new System.Drawing.Size(560, 205);
            this.cliackarea.TabIndex = 0;
            this.cliackarea.Text = "Click here\r\n3 seconds";
            this.cliackarea.UseVisualStyleBackColor = true;
            this.cliackarea.Click += new System.EventHandler(this.cliackarea_Click);
            // 
            // s3btn
            // 
            this.s3btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.s3btn.Location = new System.Drawing.Point(14, 251);
            this.s3btn.Name = "s3btn";
            this.s3btn.Size = new System.Drawing.Size(94, 73);
            this.s3btn.TabIndex = 1;
            this.s3btn.Text = "3 seconds";
            this.s3btn.UseVisualStyleBackColor = true;
            this.s3btn.Click += new System.EventHandler(this.s3btn_Click);
            // 
            // s5btn
            // 
            this.s5btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.s5btn.Location = new System.Drawing.Point(120, 251);
            this.s5btn.Name = "s5btn";
            this.s5btn.Size = new System.Drawing.Size(94, 73);
            this.s5btn.TabIndex = 2;
            this.s5btn.Text = "5 seconds";
            this.s5btn.UseVisualStyleBackColor = true;
            this.s5btn.Click += new System.EventHandler(this.s5btn_Click);
            // 
            // s10btn
            // 
            this.s10btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.s10btn.Location = new System.Drawing.Point(226, 251);
            this.s10btn.Name = "s10btn";
            this.s10btn.Size = new System.Drawing.Size(94, 73);
            this.s10btn.TabIndex = 3;
            this.s10btn.Text = "10 seconds";
            this.s10btn.UseVisualStyleBackColor = true;
            this.s10btn.Click += new System.EventHandler(this.s10btn_Click);
            // 
            // s30btn
            // 
            this.s30btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.s30btn.Location = new System.Drawing.Point(332, 251);
            this.s30btn.Name = "s30btn";
            this.s30btn.Size = new System.Drawing.Size(94, 73);
            this.s30btn.TabIndex = 4;
            this.s30btn.Text = "30 seconds";
            this.s30btn.UseVisualStyleBackColor = true;
            this.s30btn.Click += new System.EventHandler(this.s30btn_Click);
            // 
            // maintimer
            // 
            this.maintimer.Tick += new System.EventHandler(this.maintimer_Tick);
            // 
            // customsecondbtn
            // 
            this.customsecondbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.customsecondbtn.Location = new System.Drawing.Point(439, 280);
            this.customsecondbtn.Name = "customsecondbtn";
            this.customsecondbtn.Size = new System.Drawing.Size(133, 44);
            this.customsecondbtn.TabIndex = 6;
            this.customsecondbtn.Text = "Set custom duration";
            this.customsecondbtn.UseVisualStyleBackColor = true;
            this.customsecondbtn.Click += new System.EventHandler(this.customsecondbtn_Click);
            // 
            // clickcounter
            // 
            this.clickcounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clickcounter.Location = new System.Drawing.Point(249, 224);
            this.clickcounter.Name = "clickcounter";
            this.clickcounter.Size = new System.Drawing.Size(100, 23);
            this.clickcounter.TabIndex = 7;
            this.clickcounter.Text = "Clicks:";
            this.clickcounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDown
            // 
            this.numericUpDown.DecimalPlaces = 1;
            this.numericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.numericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown.Location = new System.Drawing.Point(439, 251);
            this.numericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.Size = new System.Drawing.Size(133, 23);
            this.numericUpDown.TabIndex = 8;
            this.numericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 333);
            this.Controls.Add(this.numericUpDown);
            this.Controls.Add(this.clickcounter);
            this.Controls.Add(this.customsecondbtn);
            this.Controls.Add(this.s30btn);
            this.Controls.Add(this.s10btn);
            this.Controls.Add(this.s5btn);
            this.Controls.Add(this.s3btn);
            this.Controls.Add(this.cliackarea);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "CPS test";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cliackarea;
        private System.Windows.Forms.Button s3btn;
        private System.Windows.Forms.Button s5btn;
        private System.Windows.Forms.Button s10btn;
        private System.Windows.Forms.Button s30btn;
        private System.Windows.Forms.Timer maintimer;
        private System.Windows.Forms.Button customsecondbtn;
        private System.Windows.Forms.Label clickcounter;
        private System.Windows.Forms.NumericUpDown numericUpDown;
    }
}

