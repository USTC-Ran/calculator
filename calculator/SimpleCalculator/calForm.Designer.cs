namespace SimpleCalculator
{
    partial class calForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(calForm));
            this.displayText = new System.Windows.Forms.TextBox();
            this.resultText = new System.Windows.Forms.TextBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.buttonDivide = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.buttonMul = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.buttonCal = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.buttonDot = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonCalHiden = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioBtnScience = new System.Windows.Forms.RadioButton();
            this.radioBtnNormal = new System.Windows.Forms.RadioButton();
            this.toolTipSci = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipNorl = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // displayText
            // 
            this.displayText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.displayText.Font = new System.Drawing.Font("黑体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.displayText.ForeColor = System.Drawing.Color.Black;
            this.displayText.Location = new System.Drawing.Point(-1, -1);
            this.displayText.Margin = new System.Windows.Forms.Padding(4);
            this.displayText.Multiline = true;
            this.displayText.Name = "displayText";
            this.displayText.ReadOnly = true;
            this.displayText.Size = new System.Drawing.Size(308, 40);
            this.displayText.TabIndex = 0;
            this.displayText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // resultText
            // 
            this.resultText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resultText.Font = new System.Drawing.Font("黑体", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.resultText.ForeColor = System.Drawing.Color.Black;
            this.resultText.Location = new System.Drawing.Point(-1, 39);
            this.resultText.Margin = new System.Windows.Forms.Padding(4, 4, 0, 4);
            this.resultText.Multiline = true;
            this.resultText.Name = "resultText";
            this.resultText.ReadOnly = true;
            this.resultText.Size = new System.Drawing.Size(308, 41);
            this.resultText.TabIndex = 1;
            this.resultText.Text = "0";
            this.resultText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(0)))));
            this.buttonBack.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonBack.Location = new System.Drawing.Point(269, 188);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(55, 40);
            this.buttonBack.TabIndex = 2;
            this.buttonBack.Text = "←";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            this.buttonBack.Enter += new System.EventHandler(this.button_Enter);
            this.buttonBack.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calc_KeyDown);
            this.buttonBack.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonColor2_MouseDown);
            this.buttonBack.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonColor2_MouseUp);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(0)))));
            this.buttonClear.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonClear.Location = new System.Drawing.Point(269, 140);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(4);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(55, 40);
            this.buttonClear.TabIndex = 3;
            this.buttonClear.Text = "C";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            this.buttonClear.Enter += new System.EventHandler(this.button_Enter);
            this.buttonClear.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calc_KeyDown);
            this.buttonClear.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonColor2_MouseDown);
            this.buttonClear.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonColor2_MouseUp);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.button7.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button7.Location = new System.Drawing.Point(17, 140);
            this.button7.Margin = new System.Windows.Forms.Padding(4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(55, 40);
            this.button7.TabIndex = 2;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.btnNumber_Click);
            this.button7.Enter += new System.EventHandler(this.button_Enter);
            this.button7.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calc_KeyDown);
            this.button7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonColor1_MouseDown);
            this.button7.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonColor1_MouseUp);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.button9.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button9.Location = new System.Drawing.Point(143, 140);
            this.button9.Margin = new System.Windows.Forms.Padding(4);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(55, 40);
            this.button9.TabIndex = 3;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.btnNumber_Click);
            this.button9.Enter += new System.EventHandler(this.button_Enter);
            this.button9.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calc_KeyDown);
            this.button9.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonColor1_MouseDown);
            this.button9.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonColor1_MouseUp);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.button8.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button8.Location = new System.Drawing.Point(80, 140);
            this.button8.Margin = new System.Windows.Forms.Padding(4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(55, 40);
            this.button8.TabIndex = 4;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.btnNumber_Click);
            this.button8.Enter += new System.EventHandler(this.button_Enter);
            this.button8.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calc_KeyDown);
            this.button8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonColor1_MouseDown);
            this.button8.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonColor1_MouseUp);
            // 
            // buttonDivide
            // 
            this.buttonDivide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(0)))));
            this.buttonDivide.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonDivide.Location = new System.Drawing.Point(206, 140);
            this.buttonDivide.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDivide.Name = "buttonDivide";
            this.buttonDivide.Size = new System.Drawing.Size(55, 40);
            this.buttonDivide.TabIndex = 5;
            this.buttonDivide.Text = "/";
            this.buttonDivide.UseVisualStyleBackColor = false;
            this.buttonDivide.Click += new System.EventHandler(this.btnOperator_Click);
            this.buttonDivide.Enter += new System.EventHandler(this.button_Enter);
            this.buttonDivide.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calc_KeyDown);
            this.buttonDivide.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonColor2_MouseDown);
            this.buttonDivide.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonColor2_MouseUp);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.button4.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button4.Location = new System.Drawing.Point(17, 187);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(55, 40);
            this.button4.TabIndex = 2;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.btnNumber_Click);
            this.button4.Enter += new System.EventHandler(this.button_Enter);
            this.button4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calc_KeyDown);
            this.button4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonColor1_MouseDown);
            this.button4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonColor1_MouseUp);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.button6.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button6.Location = new System.Drawing.Point(143, 188);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(55, 40);
            this.button6.TabIndex = 3;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.btnNumber_Click);
            this.button6.Enter += new System.EventHandler(this.button_Enter);
            this.button6.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calc_KeyDown);
            this.button6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonColor1_MouseDown);
            this.button6.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonColor1_MouseUp);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.button5.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button5.Location = new System.Drawing.Point(80, 188);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(55, 40);
            this.button5.TabIndex = 4;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.btnNumber_Click);
            this.button5.Enter += new System.EventHandler(this.button_Enter);
            this.button5.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calc_KeyDown);
            this.button5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonColor1_MouseDown);
            this.button5.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonColor1_MouseUp);
            // 
            // buttonMul
            // 
            this.buttonMul.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(0)))));
            this.buttonMul.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonMul.Location = new System.Drawing.Point(206, 188);
            this.buttonMul.Margin = new System.Windows.Forms.Padding(4);
            this.buttonMul.Name = "buttonMul";
            this.buttonMul.Size = new System.Drawing.Size(55, 40);
            this.buttonMul.TabIndex = 5;
            this.buttonMul.Text = "*";
            this.buttonMul.UseVisualStyleBackColor = false;
            this.buttonMul.Click += new System.EventHandler(this.btnOperator_Click);
            this.buttonMul.Enter += new System.EventHandler(this.button_Enter);
            this.buttonMul.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calc_KeyDown);
            this.buttonMul.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonColor2_MouseDown);
            this.buttonMul.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonColor2_MouseUp);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.button1.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(17, 235);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnNumber_Click);
            this.button1.Enter += new System.EventHandler(this.button_Enter);
            this.button1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calc_KeyDown);
            this.button1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonColor1_MouseDown);
            this.button1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonColor1_MouseUp);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.button3.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.Location = new System.Drawing.Point(143, 235);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(55, 40);
            this.button3.TabIndex = 3;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.btnNumber_Click);
            this.button3.Enter += new System.EventHandler(this.button_Enter);
            this.button3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calc_KeyDown);
            this.button3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonColor1_MouseDown);
            this.button3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonColor1_MouseUp);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.button2.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(80, 235);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(55, 40);
            this.button2.TabIndex = 4;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btnNumber_Click);
            this.button2.Enter += new System.EventHandler(this.button_Enter);
            this.button2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calc_KeyDown);
            this.button2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonColor1_MouseDown);
            this.button2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonColor1_MouseUp);
            // 
            // buttonMinus
            // 
            this.buttonMinus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(0)))));
            this.buttonMinus.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonMinus.Location = new System.Drawing.Point(206, 235);
            this.buttonMinus.Margin = new System.Windows.Forms.Padding(4);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(55, 40);
            this.buttonMinus.TabIndex = 5;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = false;
            this.buttonMinus.Click += new System.EventHandler(this.btnOperator_Click);
            this.buttonMinus.Enter += new System.EventHandler(this.button_Enter);
            this.buttonMinus.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calc_KeyDown);
            this.buttonMinus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonColor2_MouseDown);
            this.buttonMinus.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonColor2_MouseUp);
            // 
            // buttonCal
            // 
            this.buttonCal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(0)))));
            this.buttonCal.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonCal.Location = new System.Drawing.Point(269, 235);
            this.buttonCal.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCal.Name = "buttonCal";
            this.buttonCal.Size = new System.Drawing.Size(55, 88);
            this.buttonCal.TabIndex = 6;
            this.buttonCal.Text = "=";
            this.buttonCal.UseVisualStyleBackColor = false;
            this.buttonCal.Click += new System.EventHandler(this.buttonCal_Click);
            this.buttonCal.Enter += new System.EventHandler(this.button_Enter);
            this.buttonCal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calc_KeyDown);
            this.buttonCal.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonColor2_MouseDown);
            this.buttonCal.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonColor2_MouseUp);
            // 
            // button0
            // 
            this.button0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.button0.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button0.Location = new System.Drawing.Point(17, 283);
            this.button0.Margin = new System.Windows.Forms.Padding(4);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(118, 40);
            this.button0.TabIndex = 2;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = false;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            this.button0.Enter += new System.EventHandler(this.button_Enter);
            this.button0.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calc_KeyDown);
            this.button0.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonColor1_MouseDown);
            this.button0.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonColor1_MouseUp);
            // 
            // buttonDot
            // 
            this.buttonDot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.buttonDot.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonDot.Location = new System.Drawing.Point(143, 283);
            this.buttonDot.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDot.Name = "buttonDot";
            this.buttonDot.Size = new System.Drawing.Size(55, 40);
            this.buttonDot.TabIndex = 3;
            this.buttonDot.Text = ".";
            this.buttonDot.UseVisualStyleBackColor = false;
            this.buttonDot.Click += new System.EventHandler(this.buttonDot_Click);
            this.buttonDot.Enter += new System.EventHandler(this.button_Enter);
            this.buttonDot.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calc_KeyDown);
            this.buttonDot.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonColor1_MouseDown);
            this.buttonDot.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonColor1_MouseUp);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(0)))));
            this.buttonAdd.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonAdd.Location = new System.Drawing.Point(206, 283);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(55, 40);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "+";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.btnOperator_Click);
            this.buttonAdd.Enter += new System.EventHandler(this.button_Enter);
            this.buttonAdd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calc_KeyDown);
            this.buttonAdd.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonColor2_MouseDown);
            this.buttonAdd.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonColor2_MouseUp);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.displayText);
            this.panel1.Controls.Add(this.buttonCalHiden);
            this.panel1.Controls.Add(this.resultText);
            this.panel1.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(17, 34);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(307, 81);
            this.panel1.TabIndex = 7;
            // 
            // buttonCalHiden
            // 
            this.buttonCalHiden.Location = new System.Drawing.Point(113, 2);
            this.buttonCalHiden.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCalHiden.Name = "buttonCalHiden";
            this.buttonCalHiden.Size = new System.Drawing.Size(124, 29);
            this.buttonCalHiden.TabIndex = 9;
            this.buttonCalHiden.UseVisualStyleBackColor = false;
            this.buttonCalHiden.Click += new System.EventHandler(this.buttonCal_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioBtnScience);
            this.groupBox1.Controls.Add(this.radioBtnNormal);
            this.groupBox1.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(17, 337);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(307, 60);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "计算器模式";
            // 
            // radioBtnScience
            // 
            this.radioBtnScience.AutoSize = true;
            this.radioBtnScience.ForeColor = System.Drawing.Color.Black;
            this.radioBtnScience.Location = new System.Drawing.Point(189, 26);
            this.radioBtnScience.Margin = new System.Windows.Forms.Padding(4);
            this.radioBtnScience.Name = "radioBtnScience";
            this.radioBtnScience.Size = new System.Drawing.Size(60, 19);
            this.radioBtnScience.TabIndex = 1;
            this.radioBtnScience.Text = "科学";
            this.toolTipSci.SetToolTip(this.radioBtnScience, "First multiplication and division, then addition and subtraction");
            this.radioBtnScience.UseVisualStyleBackColor = true;
            this.radioBtnScience.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            this.radioBtnScience.Enter += new System.EventHandler(this.button_Enter);
            // 
            // radioBtnNormal
            // 
            this.radioBtnNormal.AutoSize = true;
            this.radioBtnNormal.Checked = true;
            this.radioBtnNormal.ForeColor = System.Drawing.Color.Black;
            this.radioBtnNormal.Location = new System.Drawing.Point(58, 26);
            this.radioBtnNormal.Margin = new System.Windows.Forms.Padding(4);
            this.radioBtnNormal.Name = "radioBtnNormal";
            this.radioBtnNormal.Size = new System.Drawing.Size(60, 19);
            this.radioBtnNormal.TabIndex = 0;
            this.radioBtnNormal.TabStop = true;
            this.radioBtnNormal.Text = "普通";
            this.toolTipNorl.SetToolTip(this.radioBtnNormal, "Ignore the order of operations");
            this.radioBtnNormal.UseVisualStyleBackColor = true;
            this.radioBtnNormal.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            this.radioBtnNormal.Enter += new System.EventHandler(this.button_Enter);
            // 
            // calForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 416);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonCal);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonMinus);
            this.Controls.Add(this.buttonMul);
            this.Controls.Add(this.buttonDivide);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.buttonDot);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.buttonBack);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "calForm";
            this.Text = "计算器";
            this.Load += new System.EventHandler(this.calForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox displayText;
        private System.Windows.Forms.TextBox resultText;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button buttonDivide;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button buttonMul;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Button buttonCal;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button buttonDot;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioBtnScience;
        private System.Windows.Forms.RadioButton radioBtnNormal;
        private System.Windows.Forms.ToolTip toolTipSci;
        private System.Windows.Forms.ToolTip toolTipNorl;
        private System.Windows.Forms.Button buttonCalHiden;

    }
}

