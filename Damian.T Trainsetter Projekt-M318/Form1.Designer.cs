namespace Damian.T_Trainsetter_Projekt_M318
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnsuchen = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cbBox1 = new System.Windows.Forms.ComboBox();
            this.cbBox2 = new System.Windows.Forms.ComboBox();
            this.btnweiterleiten = new System.Windows.Forms.Button();
            this.lstview1 = new System.Windows.Forms.ListView();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.btnFeedback = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Von:                 ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nach:                       ";
            // 
            // btnsuchen
            // 
            this.btnsuchen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsuchen.Location = new System.Drawing.Point(12, 192);
            this.btnsuchen.Name = "btnsuchen";
            this.btnsuchen.Size = new System.Drawing.Size(261, 35);
            this.btnsuchen.TabIndex = 4;
            this.btnsuchen.Text = "Verbindung Jetzt Suchen";
            this.btnsuchen.UseVisualStyleBackColor = true;
            this.btnsuchen.Click += new System.EventHandler(this.button1_Click);
            this.btnsuchen.Enter += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            // 
            // cbBox1
            // 
            this.cbBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBox1.FormattingEnabled = true;
            this.cbBox1.Location = new System.Drawing.Point(123, 48);
            this.cbBox1.Name = "cbBox1";
            this.cbBox1.Size = new System.Drawing.Size(212, 28);
            this.cbBox1.TabIndex = 1;
            this.cbBox1.DropDown += new System.EventHandler(this.comboBox1_DropDown);
            this.cbBox1.TextUpdate += new System.EventHandler(this.cbBox1_TextUpdate);
            // 
            // cbBox2
            // 
            this.cbBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBox2.FormattingEnabled = true;
            this.cbBox2.Location = new System.Drawing.Point(123, 82);
            this.cbBox2.Name = "cbBox2";
            this.cbBox2.Size = new System.Drawing.Size(212, 28);
            this.cbBox2.TabIndex = 2;
            this.cbBox2.DropDown += new System.EventHandler(this.comboBox2_DropDown);
            this.cbBox2.TextUpdate += new System.EventHandler(this.cbBox2_TextUpdate);
            // 
            // btnweiterleiten
            // 
            this.btnweiterleiten.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnweiterleiten.Location = new System.Drawing.Point(388, 48);
            this.btnweiterleiten.Name = "btnweiterleiten";
            this.btnweiterleiten.Size = new System.Drawing.Size(114, 62);
            this.btnweiterleiten.TabIndex = 5;
            this.btnweiterleiten.Text = "Resultate weiterleiten";
            this.btnweiterleiten.UseVisualStyleBackColor = true;
            this.btnweiterleiten.Click += new System.EventHandler(this.btn2_Click);
            // 
            // lstview1
            // 
            this.lstview1.Location = new System.Drawing.Point(12, 233);
            this.lstview1.Name = "lstview1";
            this.lstview1.Size = new System.Drawing.Size(853, 231);
            this.lstview1.TabIndex = 14;
            this.lstview1.UseCompatibleStateImageBehavior = false;
            
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "dd.MM.yyyy               HH.mm";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(12, 155);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(215, 20);
            this.dateTimePicker2.TabIndex = 3;
            this.dateTimePicker2.Value = new System.DateTime(2017, 5, 4, 14, 16, 0, 0);
            // 
            // timer2
            // 
            this.timer2.Interval = 10;
            // 
            // btnFeedback
            // 
            this.btnFeedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFeedback.Location = new System.Drawing.Point(706, -1);
            this.btnFeedback.Name = "btnFeedback";
            this.btnFeedback.Size = new System.Drawing.Size(175, 35);
            this.btnFeedback.TabIndex = 15;
            this.btnFeedback.Text = "Feedback/Probleme";
            this.btnFeedback.UseVisualStyleBackColor = true;
            this.btnFeedback.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnweiterleiten;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Crimson;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(877, 490);
            this.Controls.Add(this.btnFeedback);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.lstview1);
            this.Controls.Add(this.btnweiterleiten);
            this.Controls.Add(this.cbBox2);
            this.Controls.Add(this.cbBox1);
            this.Controls.Add(this.btnsuchen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "TrainSetter";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnsuchen;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox cbBox1;
        private System.Windows.Forms.ComboBox cbBox2;
        private System.Windows.Forms.Button btnweiterleiten;
        private System.Windows.Forms.ListView lstview1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button btnFeedback;
    }
}

