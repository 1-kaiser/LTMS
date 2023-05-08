namespace LTMS
{
    partial class services
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(services));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.wash_dry = new System.Windows.Forms.RadioButton();
            this.dry = new System.Windows.Forms.RadioButton();
            this.wash = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.drop_off = new System.Windows.Forms.RadioButton();
            this.self_service = new System.Windows.Forms.RadioButton();
            this.weight_textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_services = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(263, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(287, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.weight_textbox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btn_services);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(190, 198);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(427, 307);
            this.panel1.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox2.Controls.Add(this.wash_dry);
            this.groupBox2.Controls.Add(this.dry);
            this.groupBox2.Controls.Add(this.wash);
            this.groupBox2.Location = new System.Drawing.Point(97, 137);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(129, 79);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // wash_dry
            // 
            this.wash_dry.AutoSize = true;
            this.wash_dry.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wash_dry.Location = new System.Drawing.Point(16, 47);
            this.wash_dry.Name = "wash_dry";
            this.wash_dry.Size = new System.Drawing.Size(107, 20);
            this.wash_dry.TabIndex = 6;
            this.wash_dry.TabStop = true;
            this.wash_dry.Text = "Wash and Dry";
            this.wash_dry.UseVisualStyleBackColor = true;
            this.wash_dry.CheckedChanged += new System.EventHandler(this.wash_dry_CheckedChanged);
            // 
            // dry
            // 
            this.dry.AutoSize = true;
            this.dry.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dry.Location = new System.Drawing.Point(79, 16);
            this.dry.Name = "dry";
            this.dry.Size = new System.Drawing.Size(45, 20);
            this.dry.TabIndex = 5;
            this.dry.TabStop = true;
            this.dry.Text = "Dry";
            this.dry.UseVisualStyleBackColor = true;
            this.dry.CheckedChanged += new System.EventHandler(this.dry_CheckedChanged);
            // 
            // wash
            // 
            this.wash.AutoSize = true;
            this.wash.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wash.Location = new System.Drawing.Point(16, 15);
            this.wash.Name = "wash";
            this.wash.Size = new System.Drawing.Size(57, 20);
            this.wash.TabIndex = 4;
            this.wash.TabStop = true;
            this.wash.Text = "Wash";
            this.wash.UseVisualStyleBackColor = true;
            this.wash.CheckedChanged += new System.EventHandler(this.wash_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.drop_off);
            this.groupBox1.Controls.Add(this.self_service);
            this.groupBox1.Location = new System.Drawing.Point(100, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(234, 53);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // drop_off
            // 
            this.drop_off.AutoSize = true;
            this.drop_off.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drop_off.Location = new System.Drawing.Point(148, 23);
            this.drop_off.Name = "drop_off";
            this.drop_off.Size = new System.Drawing.Size(78, 20);
            this.drop_off.TabIndex = 3;
            this.drop_off.TabStop = true;
            this.drop_off.Text = "Drop-Off";
            this.drop_off.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.drop_off.UseVisualStyleBackColor = true;
            this.drop_off.CheckedChanged += new System.EventHandler(this.drop_off_CheckedChanged);
            // 
            // self_service
            // 
            this.self_service.AutoSize = true;
            this.self_service.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.self_service.Location = new System.Drawing.Point(21, 23);
            this.self_service.Name = "self_service";
            this.self_service.Size = new System.Drawing.Size(92, 20);
            this.self_service.TabIndex = 2;
            this.self_service.TabStop = true;
            this.self_service.Text = "Self-Service";
            this.self_service.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.self_service.UseVisualStyleBackColor = true;
            this.self_service.CheckedChanged += new System.EventHandler(this.self_service_CheckedChanged);
            // 
            // weight_textbox
            // 
            this.weight_textbox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.weight_textbox.Location = new System.Drawing.Point(281, 180);
            this.weight_textbox.Name = "weight_textbox";
            this.weight_textbox.Size = new System.Drawing.Size(45, 20);
            this.weight_textbox.TabIndex = 8;
            this.weight_textbox.TextChanged += new System.EventHandler(this.weight_textbox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(278, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Weight";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_services
            // 
            this.btn_services.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btn_services.Location = new System.Drawing.Point(347, 260);
            this.btn_services.Name = "btn_services";
            this.btn_services.Size = new System.Drawing.Size(63, 28);
            this.btn_services.TabIndex = 1;
            this.btn_services.Text = "Next";
            this.btn_services.UseVisualStyleBackColor = false;
            this.btn_services.Click += new System.EventHandler(this.btn_services_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(109, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select your Preferred Service\r\nand Laundry Type";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // services
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 529);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "services";
            this.Text = "Save5Pro - Services";
            this.Load += new System.EventHandler(this.services_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_services;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton drop_off;
        private System.Windows.Forms.RadioButton self_service;
        private System.Windows.Forms.RadioButton wash_dry;
        private System.Windows.Forms.RadioButton dry;
        private System.Windows.Forms.RadioButton wash;
        private System.Windows.Forms.TextBox weight_textbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}