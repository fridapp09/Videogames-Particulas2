namespace GV_LAB_4
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
            this.PCT_CANVAS = new System.Windows.Forms.PictureBox();
            this.TIMER = new System.Windows.Forms.Timer(this.components);
            this.BTN_ADD_EMITTER = new System.Windows.Forms.Button();
            this.gravtxt = new System.Windows.Forms.TextBox();
            this.BTN_UPDATE_GRAVITY = new System.Windows.Forms.Button();
            this.yValtxt = new System.Windows.Forms.TextBox();
            this.xValtxt = new System.Windows.Forms.TextBox();
            this.xPostxt = new System.Windows.Forms.TextBox();
            this.yPostxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PCT_CANVAS)).BeginInit();
            this.SuspendLayout();
            // 
            // PCT_CANVAS
            // 
            this.PCT_CANVAS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PCT_CANVAS.Location = new System.Drawing.Point(8, 8);
            this.PCT_CANVAS.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PCT_CANVAS.Name = "PCT_CANVAS";
            this.PCT_CANVAS.Size = new System.Drawing.Size(827, 422);
            this.PCT_CANVAS.TabIndex = 0;
            this.PCT_CANVAS.TabStop = false;
            // 
            // TIMER
            // 
            this.TIMER.Enabled = true;
            this.TIMER.Tick += new System.EventHandler(this.TIMER_Tick);
            // 
            // BTN_ADD_EMITTER
            // 
            this.BTN_ADD_EMITTER.Location = new System.Drawing.Point(20, 441);
            this.BTN_ADD_EMITTER.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTN_ADD_EMITTER.Name = "BTN_ADD_EMITTER";
            this.BTN_ADD_EMITTER.Size = new System.Drawing.Size(63, 20);
            this.BTN_ADD_EMITTER.TabIndex = 1;
            this.BTN_ADD_EMITTER.Text = "EMITTER";
            this.BTN_ADD_EMITTER.UseVisualStyleBackColor = true;
            this.BTN_ADD_EMITTER.Click += new System.EventHandler(this.BTN_ADD_EMITTER_Click);
            // 
            // gravtxt
            // 
            this.gravtxt.Location = new System.Drawing.Point(285, 440);
            this.gravtxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gravtxt.Name = "gravtxt";
            this.gravtxt.Size = new System.Drawing.Size(68, 20);
            this.gravtxt.TabIndex = 2;
            // 
            // BTN_UPDATE_GRAVITY
            // 
            this.BTN_UPDATE_GRAVITY.Location = new System.Drawing.Point(87, 441);
            this.BTN_UPDATE_GRAVITY.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTN_UPDATE_GRAVITY.Name = "BTN_UPDATE_GRAVITY";
            this.BTN_UPDATE_GRAVITY.Size = new System.Drawing.Size(113, 20);
            this.BTN_UPDATE_GRAVITY.TabIndex = 3;
            this.BTN_UPDATE_GRAVITY.Text = "EMITTER UPDATE";
            this.BTN_UPDATE_GRAVITY.UseVisualStyleBackColor = true;
            this.BTN_UPDATE_GRAVITY.Click += new System.EventHandler(this.BTN_UPDATE_GRAVITY_Click);
            // 
            // yValtxt
            // 
            this.yValtxt.Location = new System.Drawing.Point(523, 441);
            this.yValtxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.yValtxt.Name = "yValtxt";
            this.yValtxt.Size = new System.Drawing.Size(68, 20);
            this.yValtxt.TabIndex = 4;
            // 
            // xValtxt
            // 
            this.xValtxt.Location = new System.Drawing.Point(453, 441);
            this.xValtxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.xValtxt.Name = "xValtxt";
            this.xValtxt.Size = new System.Drawing.Size(68, 20);
            this.xValtxt.TabIndex = 5;
            // 
            // xPostxt
            // 
            this.xPostxt.Location = new System.Drawing.Point(638, 441);
            this.xPostxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.xPostxt.Name = "xPostxt";
            this.xPostxt.Size = new System.Drawing.Size(68, 20);
            this.xPostxt.TabIndex = 6;
            // 
            // yPostxt
            // 
            this.yPostxt.Location = new System.Drawing.Point(709, 441);
            this.yPostxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.yPostxt.Name = "yPostxt";
            this.yPostxt.Size = new System.Drawing.Size(68, 20);
            this.yPostxt.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(388, 442);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Velocidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(607, 441);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Pos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(222, 441);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Gravedad";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(35, 465);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 20);
            this.button1.TabIndex = 11;
            this.button1.Text = "F1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(102, 465);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(63, 20);
            this.button2.TabIndex = 12;
            this.button2.Text = "F2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(339, 465);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(56, 19);
            this.button3.TabIndex = 13;
            this.button3.Text = "Borrar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(843, 487);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.yPostxt);
            this.Controls.Add(this.xPostxt);
            this.Controls.Add(this.xValtxt);
            this.Controls.Add(this.yValtxt);
            this.Controls.Add(this.BTN_UPDATE_GRAVITY);
            this.Controls.Add(this.gravtxt);
            this.Controls.Add(this.BTN_ADD_EMITTER);
            this.Controls.Add(this.PCT_CANVAS);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PCT_CANVAS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PCT_CANVAS;
        private System.Windows.Forms.Timer TIMER;
        private System.Windows.Forms.Button BTN_ADD_EMITTER;
        private System.Windows.Forms.TextBox gravtxt;
        private System.Windows.Forms.Button BTN_UPDATE_GRAVITY;
        private System.Windows.Forms.TextBox yValtxt;
        private System.Windows.Forms.TextBox xValtxt;
        private System.Windows.Forms.TextBox xPostxt;
        private System.Windows.Forms.TextBox yPostxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

