
using System;
using System.Windows.Forms;

namespace Xopero
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.rdo2 = new System.Windows.Forms.RadioButton();
            this.rdo1 = new System.Windows.Forms.RadioButton();
            this.rdo3 = new System.Windows.Forms.RadioButton();
            this.getSelectedRB = new System.Windows.Forms.Button();
            this.rdo4 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.rdo2);
            this.groupBox1.Controls.Add(this.rdo1);
            this.groupBox1.Controls.Add(this.rdo3);
            this.groupBox1.Controls.Add(this.getSelectedRB);
            this.groupBox1.Location = new System.Drawing.Point(107, 60);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(640, 450);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(62, 223);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(514, 218);
            this.textBox1.TabIndex = 4;
            // 
            // rdo2
            // 
            this.rdo2.Location = new System.Drawing.Point(262, 50);
            this.rdo2.Margin = new System.Windows.Forms.Padding(6);
            this.rdo2.Name = "rdo2";
            this.rdo2.Size = new System.Drawing.Size(134, 34);
            this.rdo2.TabIndex = 0;
            this.rdo2.Text = "Upload issue";
            this.rdo2.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // rdo1
            // 
            this.rdo1.Checked = true;
            this.rdo1.Location = new System.Drawing.Point(62, 50);
            this.rdo1.Margin = new System.Windows.Forms.Padding(6);
            this.rdo1.Name = "rdo1";
            this.rdo1.Size = new System.Drawing.Size(134, 34);
            this.rdo1.TabIndex = 1;
            this.rdo1.TabStop = true;
            this.rdo1.Text = "Extract issues";
            this.rdo1.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // rdo3
            // 
            this.rdo3.Location = new System.Drawing.Point(462, 50);
            this.rdo3.Margin = new System.Windows.Forms.Padding(6);
            this.rdo3.Name = "rdo3";
            this.rdo3.Size = new System.Drawing.Size(134, 34);
            this.rdo3.TabIndex = 2;
            this.rdo3.Text = "Update issue";
            this.rdo3.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // getSelectedRB
            // 
            this.getSelectedRB.Location = new System.Drawing.Point(128, 146);
            this.getSelectedRB.Margin = new System.Windows.Forms.Padding(6);
            this.getSelectedRB.Name = "getSelectedRB";
            this.getSelectedRB.Size = new System.Drawing.Size(400, 50);
            this.getSelectedRB.TabIndex = 3;
            this.getSelectedRB.Text = "Execute";
            this.getSelectedRB.Click += new System.EventHandler(this.getSelectedRB_Click);
            // 
            // rdo4
            // 
            this.rdo4.Location = new System.Drawing.Point(362, 50);
            this.rdo4.Margin = new System.Windows.Forms.Padding(6);
            this.rdo4.Name = "rdo4";
            this.rdo4.Size = new System.Drawing.Size(134, 34);
            this.rdo4.TabIndex = 0;
            this.rdo4.Text = "Close issue";
            this.rdo4.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(169, 536);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(514, 65);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Use data from file";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(313, 36);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Save to file";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(93, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Upload from file";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 648);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Issues Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rdo1;
        private System.Windows.Forms.RadioButton rdo2;
        private System.Windows.Forms.RadioButton rdo3;
        private System.Windows.Forms.RadioButton rdo4;
        private TextBox textBox1;
        private GroupBox groupBox2;
        private Button button2;
        private Button button1;
    }
}

