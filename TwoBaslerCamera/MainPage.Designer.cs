namespace TwoBaslerCamera
{
    partial class MainPage
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
            this.lbl_camera_status = new System.Windows.Forms.Label();
            this.picBox2 = new System.Windows.Forms.PictureBox();
            this.picboxOne = new System.Windows.Forms.PictureBox();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_setOk = new System.Windows.Forms.Button();
            this.lbl_result = new System.Windows.Forms.Label();
            this.gb_trigger_mode = new System.Windows.Forms.GroupBox();
            this.cbhardware = new System.Windows.Forms.CheckBox();
            this.cbsoftware = new System.Windows.Forms.CheckBox();
            this.cb_ok_ng_plc = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_first_camera = new System.Windows.Forms.Label();
            this.lbl_second_camera = new System.Windows.Forms.Label();
            this.numeric_timer_speed = new System.Windows.Forms.NumericUpDown();
            this.lbl_timer_speed = new System.Windows.Forms.Label();
            this.numeric_exposure_time = new System.Windows.Forms.NumericUpDown();
            this.lbl_exposure_time = new System.Windows.Forms.Label();
            this.btn_set = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_total_inspected = new System.Windows.Forms.Label();
            this.btn_reset = new System.Windows.Forms.Button();
            this.lbl_total_ok_piece = new System.Windows.Forms.Label();
            this.lbl_total_ng_piece = new System.Windows.Forms.Label();
            this.btn_ok_ng = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timer_camera_status = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxOne)).BeginInit();
            this.gb_trigger_mode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_timer_speed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_exposure_time)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_camera_status
            // 
            this.lbl_camera_status.AutoSize = true;
            this.lbl_camera_status.Location = new System.Drawing.Point(16, 17);
            this.lbl_camera_status.Name = "lbl_camera_status";
            this.lbl_camera_status.Size = new System.Drawing.Size(83, 13);
            this.lbl_camera_status.TabIndex = 0;
            this.lbl_camera_status.Text = "camera running ";
            this.lbl_camera_status.Click += new System.EventHandler(this.label1_Click);
            // 
            // picBox2
            // 
            this.picBox2.Location = new System.Drawing.Point(586, 136);
            this.picBox2.Name = "picBox2";
            this.picBox2.Size = new System.Drawing.Size(525, 493);
            this.picBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox2.TabIndex = 15;
            this.picBox2.TabStop = false;
            // 
            // picboxOne
            // 
            this.picboxOne.Location = new System.Drawing.Point(12, 136);
            this.picboxOne.Name = "picboxOne";
            this.picboxOne.Size = new System.Drawing.Size(542, 493);
            this.picboxOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxOne.TabIndex = 14;
            this.picboxOne.TabStop = false;
            // 
            // btn_exit
            // 
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Location = new System.Drawing.Point(1340, 737);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(140, 34);
            this.btn_exit.TabIndex = 16;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_setOk
            // 
            this.btn_setOk.BackColor = System.Drawing.Color.Blue;
            this.btn_setOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_setOk.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_setOk.Location = new System.Drawing.Point(12, 692);
            this.btn_setOk.Name = "btn_setOk";
            this.btn_setOk.Size = new System.Drawing.Size(202, 45);
            this.btn_setOk.TabIndex = 39;
            this.btn_setOk.Text = " set pulse type";
            this.btn_setOk.UseVisualStyleBackColor = false;
            this.btn_setOk.Click += new System.EventHandler(this.btn_setOk_Click);
            // 
            // lbl_result
            // 
            this.lbl_result.AutoSize = true;
            this.lbl_result.Location = new System.Drawing.Point(1126, 40);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(57, 13);
            this.lbl_result.TabIndex = 41;
            this.lbl_result.Text = "Result Is : ";
            // 
            // gb_trigger_mode
            // 
            this.gb_trigger_mode.Controls.Add(this.cbhardware);
            this.gb_trigger_mode.Controls.Add(this.cbsoftware);
            this.gb_trigger_mode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_trigger_mode.Location = new System.Drawing.Point(898, 12);
            this.gb_trigger_mode.Name = "gb_trigger_mode";
            this.gb_trigger_mode.Size = new System.Drawing.Size(202, 118);
            this.gb_trigger_mode.TabIndex = 40;
            this.gb_trigger_mode.TabStop = false;
            this.gb_trigger_mode.Text = "Trigger Mode ";
            // 
            // cbhardware
            // 
            this.cbhardware.AutoSize = true;
            this.cbhardware.Location = new System.Drawing.Point(26, 71);
            this.cbhardware.Name = "cbhardware";
            this.cbhardware.Size = new System.Drawing.Size(119, 28);
            this.cbhardware.TabIndex = 1;
            this.cbhardware.Text = "Hardware";
            this.cbhardware.UseVisualStyleBackColor = true;
            this.cbhardware.CheckedChanged += new System.EventHandler(this.cbhardware_CheckedChanged);
            // 
            // cbsoftware
            // 
            this.cbsoftware.AutoSize = true;
            this.cbsoftware.Checked = true;
            this.cbsoftware.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbsoftware.Location = new System.Drawing.Point(26, 28);
            this.cbsoftware.Name = "cbsoftware";
            this.cbsoftware.Size = new System.Drawing.Size(67, 28);
            this.cbsoftware.TabIndex = 0;
            this.cbsoftware.Text = "Live";
            this.cbsoftware.UseVisualStyleBackColor = true;
            this.cbsoftware.CheckedChanged += new System.EventHandler(this.cbsoftware_CheckedChanged);
            // 
            // cb_ok_ng_plc
            // 
            this.cb_ok_ng_plc.AutoSize = true;
            this.cb_ok_ng_plc.Location = new System.Drawing.Point(19, 754);
            this.cb_ok_ng_plc.Name = "cb_ok_ng_plc";
            this.cb_ok_ng_plc.Size = new System.Drawing.Size(94, 17);
            this.cb_ok_ng_plc.TabIndex = 2;
            this.cb_ok_ng_plc.Text = " set pulse type";
            this.cb_ok_ng_plc.UseVisualStyleBackColor = true;
            this.cb_ok_ng_plc.CheckedChanged += new System.EventHandler(this.cb_ok_ng_plc_CheckedChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Blue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(479, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(248, 45);
            this.button1.TabIndex = 43;
            this.button1.Text = "STATION ONE";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // lbl_first_camera
            // 
            this.lbl_first_camera.AutoSize = true;
            this.lbl_first_camera.ForeColor = System.Drawing.Color.Blue;
            this.lbl_first_camera.Location = new System.Drawing.Point(16, 110);
            this.lbl_first_camera.Name = "lbl_first_camera";
            this.lbl_first_camera.Size = new System.Drawing.Size(68, 13);
            this.lbl_first_camera.TabIndex = 44;
            this.lbl_first_camera.Text = "First Camera ";
            // 
            // lbl_second_camera
            // 
            this.lbl_second_camera.AutoSize = true;
            this.lbl_second_camera.ForeColor = System.Drawing.Color.Blue;
            this.lbl_second_camera.Location = new System.Drawing.Point(595, 110);
            this.lbl_second_camera.Name = "lbl_second_camera";
            this.lbl_second_camera.Size = new System.Drawing.Size(86, 13);
            this.lbl_second_camera.TabIndex = 45;
            this.lbl_second_camera.Text = "Second Camera ";
            // 
            // numeric_timer_speed
            // 
            this.numeric_timer_speed.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numeric_timer_speed.Location = new System.Drawing.Point(264, 10);
            this.numeric_timer_speed.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numeric_timer_speed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeric_timer_speed.Name = "numeric_timer_speed";
            this.numeric_timer_speed.Size = new System.Drawing.Size(120, 20);
            this.numeric_timer_speed.TabIndex = 46;
            this.numeric_timer_speed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numeric_timer_speed.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeric_timer_speed.ValueChanged += new System.EventHandler(this.numeric_timer_speed_ValueChanged);
            // 
            // lbl_timer_speed
            // 
            this.lbl_timer_speed.AutoSize = true;
            this.lbl_timer_speed.Location = new System.Drawing.Point(166, 13);
            this.lbl_timer_speed.Name = "lbl_timer_speed";
            this.lbl_timer_speed.Size = new System.Drawing.Size(89, 13);
            this.lbl_timer_speed.TabIndex = 47;
            this.lbl_timer_speed.Text = "timer speed ( ms )";
            // 
            // numeric_exposure_time
            // 
            this.numeric_exposure_time.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numeric_exposure_time.Location = new System.Drawing.Point(263, 36);
            this.numeric_exposure_time.Maximum = new decimal(new int[] {
            3000000,
            0,
            0,
            0});
            this.numeric_exposure_time.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numeric_exposure_time.Name = "numeric_exposure_time";
            this.numeric_exposure_time.Size = new System.Drawing.Size(120, 20);
            this.numeric_exposure_time.TabIndex = 48;
            this.numeric_exposure_time.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numeric_exposure_time.Value = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.numeric_exposure_time.ValueChanged += new System.EventHandler(this.numeric_exposure_time_ValueChanged);
            // 
            // lbl_exposure_time
            // 
            this.lbl_exposure_time.AutoSize = true;
            this.lbl_exposure_time.Location = new System.Drawing.Point(165, 39);
            this.lbl_exposure_time.Name = "lbl_exposure_time";
            this.lbl_exposure_time.Size = new System.Drawing.Size(94, 13);
            this.lbl_exposure_time.TabIndex = 49;
            this.lbl_exposure_time.Text = "Exposure Time(us)";
            // 
            // btn_set
            // 
            this.btn_set.Location = new System.Drawing.Point(390, 36);
            this.btn_set.Name = "btn_set";
            this.btn_set.Size = new System.Drawing.Size(65, 20);
            this.btn_set.TabIndex = 50;
            this.btn_set.Text = "Set";
            this.btn_set.UseVisualStyleBackColor = true;
            this.btn_set.Click += new System.EventHandler(this.btn_set_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::TwoBaslerCamera.Properties.Resources.black_rect;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lbl_total_inspected);
            this.panel1.Controls.Add(this.btn_reset);
            this.panel1.Controls.Add(this.lbl_total_ok_piece);
            this.panel1.Controls.Add(this.lbl_total_ng_piece);
            this.panel1.Controls.Add(this.btn_ok_ng);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(1117, 136);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(409, 333);
            this.panel1.TabIndex = 57;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(129, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(201, 26);
            this.label7.TabIndex = 54;
            this.label7.Text = "Inspection Data";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(56, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 19);
            this.label6.TabIndex = 51;
            this.label6.Text = "Inspection Result :";
            // 
            // lbl_total_inspected
            // 
            this.lbl_total_inspected.AutoSize = true;
            this.lbl_total_inspected.BackColor = System.Drawing.Color.Teal;
            this.lbl_total_inspected.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total_inspected.ForeColor = System.Drawing.Color.White;
            this.lbl_total_inspected.Location = new System.Drawing.Point(60, 72);
            this.lbl_total_inspected.Name = "lbl_total_inspected";
            this.lbl_total_inspected.Size = new System.Drawing.Size(146, 16);
            this.lbl_total_inspected.TabIndex = 0;
            this.lbl_total_inspected.Text = "Total  Inspected           :  ";
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(13)))), ((int)(((byte)(49)))));
            this.btn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.ForeColor = System.Drawing.Color.White;
            this.btn_reset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_reset.Location = new System.Drawing.Point(238, 180);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(125, 45);
            this.btn_reset.TabIndex = 38;
            this.btn_reset.Text = "Reset ";
            this.btn_reset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_reset.UseVisualStyleBackColor = false;
            // 
            // lbl_total_ok_piece
            // 
            this.lbl_total_ok_piece.AutoSize = true;
            this.lbl_total_ok_piece.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total_ok_piece.ForeColor = System.Drawing.Color.White;
            this.lbl_total_ok_piece.Location = new System.Drawing.Point(57, 108);
            this.lbl_total_ok_piece.Name = "lbl_total_ok_piece";
            this.lbl_total_ok_piece.Size = new System.Drawing.Size(137, 16);
            this.lbl_total_ok_piece.TabIndex = 1;
            this.lbl_total_ok_piece.Text = "Total Ok                        : ";
            // 
            // lbl_total_ng_piece
            // 
            this.lbl_total_ng_piece.AutoSize = true;
            this.lbl_total_ng_piece.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total_ng_piece.ForeColor = System.Drawing.Color.White;
            this.lbl_total_ng_piece.Location = new System.Drawing.Point(57, 144);
            this.lbl_total_ng_piece.Name = "lbl_total_ng_piece";
            this.lbl_total_ng_piece.Size = new System.Drawing.Size(138, 16);
            this.lbl_total_ng_piece.TabIndex = 2;
            this.lbl_total_ng_piece.Text = "Total Ng                        : ";
            // 
            // btn_ok_ng
            // 
            this.btn_ok_ng.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ok_ng.Location = new System.Drawing.Point(238, 242);
            this.btn_ok_ng.Name = "btn_ok_ng";
            this.btn_ok_ng.Size = new System.Drawing.Size(125, 49);
            this.btn_ok_ng.TabIndex = 36;
            this.btn_ok_ng.Text = "- - - -  -  -";
            this.btn_ok_ng.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(322, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 16);
            this.label3.TabIndex = 41;
            this.label3.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(322, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 16);
            this.label2.TabIndex = 40;
            this.label2.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(322, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 16);
            this.label4.TabIndex = 39;
            this.label4.Text = "0";
            // 
            // timer_camera_status
            // 
            this.timer_camera_status.Interval = 1000;
            this.timer_camera_status.Tick += new System.EventHandler(this.timer_camera_status_Tick);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1538, 788);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_set);
            this.Controls.Add(this.lbl_exposure_time);
            this.Controls.Add(this.numeric_exposure_time);
            this.Controls.Add(this.lbl_timer_speed);
            this.Controls.Add(this.numeric_timer_speed);
            this.Controls.Add(this.lbl_second_camera);
            this.Controls.Add(this.lbl_first_camera);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cb_ok_ng_plc);
            this.Controls.Add(this.lbl_result);
            this.Controls.Add(this.gb_trigger_mode);
            this.Controls.Add(this.btn_setOk);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.picBox2);
            this.Controls.Add(this.picboxOne);
            this.Controls.Add(this.lbl_camera_status);
            this.Name = "MainPage";
            this.Text = "MainPage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainPage_FormClosing);
            this.Load += new System.EventHandler(this.MainPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxOne)).EndInit();
            this.gb_trigger_mode.ResumeLayout(false);
            this.gb_trigger_mode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_timer_speed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_exposure_time)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_camera_status;
        private System.Windows.Forms.PictureBox picBox2;
        private System.Windows.Forms.PictureBox picboxOne;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_setOk;
        private System.Windows.Forms.Label lbl_result;
        private System.Windows.Forms.GroupBox gb_trigger_mode;
        private System.Windows.Forms.CheckBox cbhardware;
        private System.Windows.Forms.CheckBox cbsoftware;
        private System.Windows.Forms.CheckBox cb_ok_ng_plc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_first_camera;
        private System.Windows.Forms.Label lbl_second_camera;
        private System.Windows.Forms.NumericUpDown numeric_timer_speed;
        private System.Windows.Forms.Label lbl_timer_speed;
        private System.Windows.Forms.NumericUpDown numeric_exposure_time;
        private System.Windows.Forms.Label lbl_exposure_time;
        private System.Windows.Forms.Button btn_set;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_total_inspected;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Label lbl_total_ok_piece;
        private System.Windows.Forms.Label lbl_total_ng_piece;
        private System.Windows.Forms.Button btn_ok_ng;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer_camera_status;
    }
}