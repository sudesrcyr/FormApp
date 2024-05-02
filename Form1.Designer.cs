
namespace FormsApp
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
            this.lblFont = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.cmbFont = new System.Windows.Forms.ComboBox();
            this.btnColor = new System.Windows.Forms.Button();
            this.lblColor1 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.chkBold = new System.Windows.Forms.CheckBox();
            this.chkItalic = new System.Windows.Forms.CheckBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.lblMessage2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnTopCenter = new System.Windows.Forms.Button();
            this.btnTopRight = new System.Windows.Forms.Button();
            this.btnTopLeft = new System.Windows.Forms.Button();
            this.btnCenter = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnBottomLeft = new System.Windows.Forms.Button();
            this.btnBottomCenter = new System.Windows.Forms.Button();
            this.btnBottomRight = new System.Windows.Forms.Button();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.lblMessageBottom = new System.Windows.Forms.Label();
            this.lblBottomMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFont
            // 
            this.lblFont.AutoSize = true;
            this.lblFont.Location = new System.Drawing.Point(12, 20);
            this.lblFont.Name = "lblFont";
            this.lblFont.Size = new System.Drawing.Size(36, 17);
            this.lblFont.TabIndex = 0;
            this.lblFont.Text = "Font";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(12, 58);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(41, 17);
            this.lblColor.TabIndex = 1;
            this.lblColor.Text = "Color";
            // 
            // cmbFont
            // 
            this.cmbFont.FormattingEnabled = true;
            this.cmbFont.Location = new System.Drawing.Point(83, 20);
            this.cmbFont.Name = "cmbFont";
            this.cmbFont.Size = new System.Drawing.Size(121, 24);
            this.cmbFont.TabIndex = 2;
            this.cmbFont.SelectedIndexChanged += new System.EventHandler(this.cmbFont_SelectedIndexChanged);
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(83, 50);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(121, 32);
            this.btnColor.TabIndex = 3;
            this.btnColor.Text = "Choose color";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // lblColor1
            // 
            this.lblColor1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblColor1.Location = new System.Drawing.Point(210, 50);
            this.lblColor1.Name = "lblColor1";
            this.lblColor1.Size = new System.Drawing.Size(37, 32);
            this.lblColor1.TabIndex = 4;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(213, 20);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 5;
            // 
            // chkBold
            // 
            this.chkBold.AutoSize = true;
            this.chkBold.Location = new System.Drawing.Point(348, 19);
            this.chkBold.Name = "chkBold";
            this.chkBold.Size = new System.Drawing.Size(58, 21);
            this.chkBold.TabIndex = 6;
            this.chkBold.Text = "Bold";
            this.chkBold.UseVisualStyleBackColor = true;
            // 
            // chkItalic
            // 
            this.chkItalic.AutoSize = true;
            this.chkItalic.Location = new System.Drawing.Point(412, 19);
            this.chkItalic.Name = "chkItalic";
            this.chkItalic.Size = new System.Drawing.Size(58, 21);
            this.chkItalic.TabIndex = 7;
            this.chkItalic.Text = "Italic";
            this.chkItalic.UseVisualStyleBackColor = true;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblMessage.Location = new System.Drawing.Point(45, 144);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(115, 17);
            this.lblMessage.TabIndex = 8;
            this.lblMessage.Text = "Enter a message";
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(48, 164);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(633, 174);
            this.txtMessage.TabIndex = 9;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(606, 344);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 10;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lblMessage2
            // 
            this.lblMessage2.AutoSize = true;
            this.lblMessage2.Location = new System.Drawing.Point(507, 19);
            this.lblMessage2.Name = "lblMessage2";
            this.lblMessage2.Size = new System.Drawing.Size(70, 17);
            this.lblMessage2.TabIndex = 11;
            this.lblMessage2.Text = "Alignment";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.btnBottomRight, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnTopCenter, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnBottomCenter, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnTopRight, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnBottomLeft, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnTopLeft, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnLeft, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnCenter, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnRight, 2, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(579, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(227, 120);
            this.tableLayoutPanel1.TabIndex = 12;
            this.tableLayoutPanel1.Click += new System.EventHandler(this.button_Click);
            // 
            // btnTopCenter
            // 
            this.btnTopCenter.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnTopCenter.Location = new System.Drawing.Point(78, 3);
            this.btnTopCenter.Name = "btnTopCenter";
            this.btnTopCenter.Size = new System.Drawing.Size(69, 33);
            this.btnTopCenter.TabIndex = 13;
            this.btnTopCenter.UseVisualStyleBackColor = false;
            this.btnTopCenter.Click += new System.EventHandler(this.button_Click);
            // 
            // btnTopRight
            // 
            this.btnTopRight.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnTopRight.Location = new System.Drawing.Point(153, 3);
            this.btnTopRight.Name = "btnTopRight";
            this.btnTopRight.Size = new System.Drawing.Size(71, 33);
            this.btnTopRight.TabIndex = 14;
            this.btnTopRight.UseVisualStyleBackColor = false;
            this.btnTopRight.Click += new System.EventHandler(this.button_Click);
            // 
            // btnTopLeft
            // 
            this.btnTopLeft.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnTopLeft.Location = new System.Drawing.Point(3, 3);
            this.btnTopLeft.Name = "btnTopLeft";
            this.btnTopLeft.Size = new System.Drawing.Size(69, 33);
            this.btnTopLeft.TabIndex = 15;
            this.btnTopLeft.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTopLeft.UseVisualStyleBackColor = false;
            this.btnTopLeft.Click += new System.EventHandler(this.button_Click);
            // 
            // btnCenter
            // 
            this.btnCenter.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnCenter.Location = new System.Drawing.Point(78, 42);
            this.btnCenter.Name = "btnCenter";
            this.btnCenter.Size = new System.Drawing.Size(69, 33);
            this.btnCenter.TabIndex = 16;
            this.btnCenter.UseVisualStyleBackColor = false;
            this.btnCenter.Click += new System.EventHandler(this.button_Click);
            // 
            // btnRight
            // 
            this.btnRight.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnRight.Location = new System.Drawing.Point(153, 42);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(71, 33);
            this.btnRight.TabIndex = 17;
            this.btnRight.UseVisualStyleBackColor = false;
            this.btnRight.Click += new System.EventHandler(this.button_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnLeft.Location = new System.Drawing.Point(3, 42);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(69, 33);
            this.btnLeft.TabIndex = 18;
            this.btnLeft.UseVisualStyleBackColor = false;
            this.btnLeft.Click += new System.EventHandler(this.button_Click);
            // 
            // btnBottomLeft
            // 
            this.btnBottomLeft.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnBottomLeft.Location = new System.Drawing.Point(3, 81);
            this.btnBottomLeft.Name = "btnBottomLeft";
            this.btnBottomLeft.Size = new System.Drawing.Size(69, 36);
            this.btnBottomLeft.TabIndex = 19;
            this.btnBottomLeft.UseVisualStyleBackColor = false;
            this.btnBottomLeft.Click += new System.EventHandler(this.button_Click);
            // 
            // btnBottomCenter
            // 
            this.btnBottomCenter.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnBottomCenter.Location = new System.Drawing.Point(78, 81);
            this.btnBottomCenter.Name = "btnBottomCenter";
            this.btnBottomCenter.Size = new System.Drawing.Size(69, 36);
            this.btnBottomCenter.TabIndex = 20;
            this.btnBottomCenter.UseVisualStyleBackColor = false;
            this.btnBottomCenter.Click += new System.EventHandler(this.button_Click);
            // 
            // btnBottomRight
            // 
            this.btnBottomRight.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnBottomRight.Location = new System.Drawing.Point(153, 81);
            this.btnBottomRight.Name = "btnBottomRight";
            this.btnBottomRight.Size = new System.Drawing.Size(71, 36);
            this.btnBottomRight.TabIndex = 21;
            this.btnBottomRight.UseVisualStyleBackColor = false;
            this.btnBottomRight.Click += new System.EventHandler(this.button_Click);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(657, 164);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(24, 174);
            this.vScrollBar1.TabIndex = 13;
            // 
            // lblMessageBottom
            // 
            this.lblMessageBottom.AutoSize = true;
            this.lblMessageBottom.Location = new System.Drawing.Point(53, 371);
            this.lblMessageBottom.Name = "lblMessageBottom";
            this.lblMessageBottom.Size = new System.Drawing.Size(0, 17);
            this.lblMessageBottom.TabIndex = 14;
            // 
            // lblBottomMessage
            // 
            this.lblBottomMessage.BackColor = System.Drawing.SystemColors.Control;
            this.lblBottomMessage.Location = new System.Drawing.Point(48, 370);
            this.lblBottomMessage.Name = "lblBottomMessage";
            this.lblBottomMessage.Size = new System.Drawing.Size(633, 117);
            this.lblBottomMessage.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 524);
            this.Controls.Add(this.lblBottomMessage);
            this.Controls.Add(this.lblMessageBottom);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lblMessage2);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.chkItalic);
            this.Controls.Add(this.chkBold);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.lblColor1);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.cmbFont);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblFont);
            this.Name = "Form1";
            this.Text = "Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFont;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.ComboBox cmbFont;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Label lblColor1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.CheckBox chkBold;
        private System.Windows.Forms.CheckBox chkItalic;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label lblMessage2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnBottomRight;
        private System.Windows.Forms.Button btnTopCenter;
        private System.Windows.Forms.Button btnBottomCenter;
        private System.Windows.Forms.Button btnTopRight;
        private System.Windows.Forms.Button btnBottomLeft;
        private System.Windows.Forms.Button btnTopLeft;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnCenter;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Label lblMessageBottom;
        private System.Windows.Forms.Label lblBottomMessage;
    }
}

