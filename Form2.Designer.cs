namespace _1A2B
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.picB_Mute = new System.Windows.Forms.PictureBox();
            this.imgls_Mute = new System.Windows.Forms.ImageList(this.components);
            this.lbl_input = new System.Windows.Forms.Label();
            this.txtB_input = new System.Windows.Forms.TextBox();
            this.btn_input = new System.Windows.Forms.Button();
            this.lbl_output = new System.Windows.Forms.Label();
            this.txtB_output = new System.Windows.Forms.TextBox();
            this.btn_output = new System.Windows.Forms.Button();
            this.lbl_errormsg = new System.Windows.Forms.Label();
            this.lbl_back = new System.Windows.Forms.Label();
            this.lbl_outcome = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picB_Mute)).BeginInit();
            this.SuspendLayout();
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(495, 408);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(96, 48);
            this.axWindowsMediaPlayer1.TabIndex = 2;
            // 
            // picB_Mute
            // 
            this.picB_Mute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picB_Mute.Location = new System.Drawing.Point(0, 428);
            this.picB_Mute.Name = "picB_Mute";
            this.picB_Mute.Size = new System.Drawing.Size(40, 40);
            this.picB_Mute.TabIndex = 3;
            this.picB_Mute.TabStop = false;
            this.picB_Mute.Click += new System.EventHandler(this.picB_Mute_Click);
            // 
            // imgls_Mute
            // 
            this.imgls_Mute.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgls_Mute.ImageStream")));
            this.imgls_Mute.TransparentColor = System.Drawing.Color.Transparent;
            this.imgls_Mute.Images.SetKeyName(0, "Mute.png");
            this.imgls_Mute.Images.SetKeyName(1, "UnMute.png");
            // 
            // lbl_input
            // 
            this.lbl_input.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_input.Location = new System.Drawing.Point(12, 29);
            this.lbl_input.Name = "lbl_input";
            this.lbl_input.Size = new System.Drawing.Size(179, 61);
            this.lbl_input.TabIndex = 4;
            this.lbl_input.Text = "請輸入題目:";
            this.lbl_input.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtB_input
            // 
            this.txtB_input.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtB_input.Font = new System.Drawing.Font("新細明體", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtB_input.Location = new System.Drawing.Point(217, 39);
            this.txtB_input.Name = "txtB_input";
            this.txtB_input.Size = new System.Drawing.Size(207, 42);
            this.txtB_input.TabIndex = 5;
            this.txtB_input.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtB_input_KeyPress);
            // 
            // btn_input
            // 
            this.btn_input.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_input.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_input.Location = new System.Drawing.Point(480, 43);
            this.btn_input.Name = "btn_input";
            this.btn_input.Size = new System.Drawing.Size(96, 36);
            this.btn_input.TabIndex = 6;
            this.btn_input.Text = "確定";
            this.btn_input.UseVisualStyleBackColor = true;
            this.btn_input.Click += new System.EventHandler(this.btn_intput_Click);
            // 
            // lbl_output
            // 
            this.lbl_output.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_output.Location = new System.Drawing.Point(12, 29);
            this.lbl_output.Name = "lbl_output";
            this.lbl_output.Size = new System.Drawing.Size(179, 61);
            this.lbl_output.TabIndex = 7;
            this.lbl_output.Text = "請輸入答案:";
            this.lbl_output.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtB_output
            // 
            this.txtB_output.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtB_output.Font = new System.Drawing.Font("新細明體", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtB_output.Location = new System.Drawing.Point(217, 39);
            this.txtB_output.Name = "txtB_output";
            this.txtB_output.Size = new System.Drawing.Size(207, 42);
            this.txtB_output.TabIndex = 8;
            this.txtB_output.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtB_output_KeyPress);
            // 
            // btn_output
            // 
            this.btn_output.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_output.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_output.Location = new System.Drawing.Point(480, 43);
            this.btn_output.Name = "btn_output";
            this.btn_output.Size = new System.Drawing.Size(96, 36);
            this.btn_output.TabIndex = 9;
            this.btn_output.TabStop = false;
            this.btn_output.Text = "輸入";
            this.btn_output.UseVisualStyleBackColor = true;
            this.btn_output.Click += new System.EventHandler(this.btn_output_Click);
            // 
            // lbl_errormsg
            // 
            this.lbl_errormsg.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_errormsg.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_errormsg.Location = new System.Drawing.Point(424, 156);
            this.lbl_errormsg.Name = "lbl_errormsg";
            this.lbl_errormsg.Size = new System.Drawing.Size(179, 61);
            this.lbl_errormsg.TabIndex = 11;
            this.lbl_errormsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_back
            // 
            this.lbl_back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_back.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_back.Location = new System.Drawing.Point(412, 334);
            this.lbl_back.Name = "lbl_back";
            this.lbl_back.Size = new System.Drawing.Size(179, 61);
            this.lbl_back.TabIndex = 12;
            this.lbl_back.Text = "回主選單";
            this.lbl_back.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_back.Click += new System.EventHandler(this.lbl_back_Click);
            this.lbl_back.MouseEnter += new System.EventHandler(this.lbl_back_MouseEnter);
            this.lbl_back.MouseLeave += new System.EventHandler(this.lbl_back_MouseLeave);
            // 
            // lbl_outcome
            // 
            this.lbl_outcome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_outcome.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_outcome.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_outcome.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_outcome.Location = new System.Drawing.Point(65, 90);
            this.lbl_outcome.Name = "lbl_outcome";
            this.lbl_outcome.Size = new System.Drawing.Size(359, 356);
            this.lbl_outcome.TabIndex = 13;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 468);
            this.Controls.Add(this.lbl_outcome);
            this.Controls.Add(this.lbl_back);
            this.Controls.Add(this.lbl_errormsg);
            this.Controls.Add(this.btn_output);
            this.Controls.Add(this.txtB_output);
            this.Controls.Add(this.lbl_output);
            this.Controls.Add(this.btn_input);
            this.Controls.Add(this.txtB_input);
            this.Controls.Add(this.lbl_input);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.picB_Mute);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picB_Mute)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.PictureBox picB_Mute;
        private System.Windows.Forms.ImageList imgls_Mute;
        private System.Windows.Forms.Label lbl_input;
        private System.Windows.Forms.TextBox txtB_input;
        private System.Windows.Forms.Button btn_input;
        private System.Windows.Forms.Label lbl_output;
        private System.Windows.Forms.TextBox txtB_output;
        private System.Windows.Forms.Button btn_output;
        private System.Windows.Forms.Label lbl_errormsg;
        private System.Windows.Forms.Label lbl_back;
        private System.Windows.Forms.Label lbl_outcome;
    }
}