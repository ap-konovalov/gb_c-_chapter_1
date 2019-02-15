namespace Lesson7
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
            this.components = new System.ComponentModel.Container();
            this.lblNumberResult = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblOperationsCount = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.игратьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.игратьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.отменитьХодToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.lblExpectedResult = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNumberResult
            // 
            this.lblNumberResult.AutoSize = true;
            this.lblNumberResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNumberResult.Location = new System.Drawing.Point(164, 87);
            this.lblNumberResult.Name = "lblNumberResult";
            this.lblNumberResult.Size = new System.Drawing.Size(18, 20);
            this.lblNumberResult.TabIndex = 0;
            this.lblNumberResult.Text = "0";
            this.lblNumberResult.Click += new System.EventHandler(this.lblNumberResult_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(327, 128);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Сброс";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(327, 32);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(75, 23);
            this.btnPlus.TabIndex = 2;
            this.btnPlus.Text = "+1";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Location = new System.Drawing.Point(327, 87);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(75, 23);
            this.btnMultiply.TabIndex = 3;
            this.btnMultiply.Text = "x2";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(68, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Результат вычисления";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Количество ходов:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblOperationsCount
            // 
            this.lblOperationsCount.AutoSize = true;
            this.lblOperationsCount.Location = new System.Drawing.Point(120, 179);
            this.lblOperationsCount.Name = "lblOperationsCount";
            this.lblOperationsCount.Size = new System.Drawing.Size(13, 13);
            this.lblOperationsCount.TabIndex = 6;
            this.lblOperationsCount.Text = "0";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.игратьToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(113, 26);
            // 
            // игратьToolStripMenuItem
            // 
            this.игратьToolStripMenuItem.Name = "игратьToolStripMenuItem";
            this.игратьToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.игратьToolStripMenuItem.Text = "Играть";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.игратьToolStripMenuItem1,
            this.отменитьХодToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(436, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // игратьToolStripMenuItem1
            // 
            this.игратьToolStripMenuItem1.Name = "игратьToolStripMenuItem1";
            this.игратьToolStripMenuItem1.Size = new System.Drawing.Size(57, 20);
            this.игратьToolStripMenuItem1.Text = "Играть";
            this.игратьToolStripMenuItem1.Click += new System.EventHandler(this.игратьToolStripMenuItem1_Click);
            // 
            // отменитьХодToolStripMenuItem
            // 
            this.отменитьХодToolStripMenuItem.Name = "отменитьХодToolStripMenuItem";
            this.отменитьХодToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.отменитьХодToolStripMenuItem.Text = "Отменить ход";
            this.отменитьХодToolStripMenuItem.Click += new System.EventHandler(this.отменитьХодToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(261, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Получаем число:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblExpectedResult
            // 
            this.lblExpectedResult.AutoSize = true;
            this.lblExpectedResult.Location = new System.Drawing.Point(359, 179);
            this.lblExpectedResult.Name = "lblExpectedResult";
            this.lblExpectedResult.Size = new System.Drawing.Size(10, 13);
            this.lblExpectedResult.TabIndex = 10;
            this.lblExpectedResult.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 204);
            this.Controls.Add(this.lblExpectedResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lblOperationsCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblNumberResult);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumberResult;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblOperationsCount;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem игратьToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem игратьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem отменитьХодToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblExpectedResult;
    }
}

