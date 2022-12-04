namespace scientific_calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnBackSpace = new System.Windows.Forms.Button();
            this.btnClearEntry = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAddSub = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnDot = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnSquare = new System.Windows.Forms.Button();
            this.btnSqrt = new System.Windows.Forms.Button();
            this.btnLog = new System.Windows.Forms.Button();
            this.btnPi = new System.Windows.Forms.Button();
            this.btnCube = new System.Windows.Forms.Button();
            this.btnDec = new System.Windows.Forms.Button();
            this.btnSin = new System.Windows.Forms.Button();
            this.btnSinh = new System.Windows.Forms.Button();
            this.btnFraction = new System.Windows.Forms.Button();
            this.btnBin = new System.Windows.Forms.Button();
            this.btnCos = new System.Windows.Forms.Button();
            this.btnCosh = new System.Windows.Forms.Button();
            this.btnLn = new System.Windows.Forms.Button();
            this.btnHex = new System.Windows.Forms.Button();
            this.btnTan = new System.Windows.Forms.Button();
            this.btnTanh = new System.Windows.Forms.Button();
            this.btnPercent = new System.Windows.Forms.Button();
            this.btnOct = new System.Windows.Forms.Button();
            this.btnMod = new System.Windows.Forms.Button();
            this.btnExp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtResult
            // 
            this.txtResult.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtResult.Location = new System.Drawing.Point(12, 41);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(517, 30);
            this.txtResult.TabIndex = 0;
            this.txtResult.Text = "0";
            this.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnBackSpace
            // 
            this.btnBackSpace.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBackSpace.Location = new System.Drawing.Point(12, 78);
            this.btnBackSpace.Name = "btnBackSpace";
            this.btnBackSpace.Size = new System.Drawing.Size(56, 54);
            this.btnBackSpace.TabIndex = 1;
            this.btnBackSpace.Text = "⌫";
            this.btnBackSpace.UseVisualStyleBackColor = true;
            this.btnBackSpace.Click += new System.EventHandler(this.btnBackSpace_Click);
            // 
            // btnClearEntry
            // 
            this.btnClearEntry.Location = new System.Drawing.Point(74, 78);
            this.btnClearEntry.Name = "btnClearEntry";
            this.btnClearEntry.Size = new System.Drawing.Size(56, 54);
            this.btnClearEntry.TabIndex = 2;
            this.btnClearEntry.Text = "CE";
            this.btnClearEntry.UseVisualStyleBackColor = true;
            this.btnClearEntry.Click += new System.EventHandler(this.btnClearEntry_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(136, 78);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(56, 54);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAddSub
            // 
            this.btnAddSub.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddSub.Location = new System.Drawing.Point(198, 78);
            this.btnAddSub.Name = "btnAddSub";
            this.btnAddSub.Size = new System.Drawing.Size(56, 54);
            this.btnAddSub.TabIndex = 4;
            this.btnAddSub.Text = "±";
            this.btnAddSub.UseVisualStyleBackColor = true;
            this.btnAddSub.Click += new System.EventHandler(this.btnAddSub_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(12, 138);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(56, 54);
            this.btn7.TabIndex = 5;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.EnterNumbers);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(74, 138);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(56, 54);
            this.btn8.TabIndex = 6;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.EnterNumbers);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(136, 138);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(56, 54);
            this.btn9.TabIndex = 7;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.EnterNumbers);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(198, 138);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(56, 54);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.Operators);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(12, 198);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(56, 54);
            this.btn4.TabIndex = 9;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.EnterNumbers);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(74, 198);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(56, 54);
            this.btn5.TabIndex = 10;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.EnterNumbers);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(136, 198);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(56, 54);
            this.btn6.TabIndex = 11;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.EnterNumbers);
            // 
            // btnSubtract
            // 
            this.btnSubtract.Location = new System.Drawing.Point(198, 198);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(56, 54);
            this.btnSubtract.TabIndex = 12;
            this.btnSubtract.Text = "-";
            this.btnSubtract.UseVisualStyleBackColor = true;
            this.btnSubtract.Click += new System.EventHandler(this.Operators);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(12, 258);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(56, 54);
            this.btn1.TabIndex = 13;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.EnterNumbers);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(74, 258);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(56, 54);
            this.button14.TabIndex = 14;
            this.button14.Text = "2";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.EnterNumbers);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(136, 258);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(56, 54);
            this.btn3.TabIndex = 15;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.EnterNumbers);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Location = new System.Drawing.Point(198, 258);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(56, 54);
            this.btnMultiply.TabIndex = 16;
            this.btnMultiply.Text = "*";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.Operators);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(12, 318);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(56, 54);
            this.btn0.TabIndex = 17;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.EnterNumbers);
            // 
            // btnDot
            // 
            this.btnDot.Location = new System.Drawing.Point(74, 318);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(56, 54);
            this.btnDot.TabIndex = 18;
            this.btnDot.Text = ".";
            this.btnDot.UseVisualStyleBackColor = true;
            this.btnDot.Click += new System.EventHandler(this.EnterNumbers);
            // 
            // btnEqual
            // 
            this.btnEqual.Location = new System.Drawing.Point(136, 318);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(56, 54);
            this.btnEqual.TabIndex = 19;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = true;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Location = new System.Drawing.Point(200, 318);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(56, 54);
            this.btnDivide.TabIndex = 20;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.Operators);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(612, 24);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnSquare
            // 
            this.btnSquare.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSquare.Location = new System.Drawing.Point(473, 79);
            this.btnSquare.Name = "btnSquare";
            this.btnSquare.Size = new System.Drawing.Size(56, 54);
            this.btnSquare.TabIndex = 25;
            this.btnSquare.Text = "x²";
            this.btnSquare.UseVisualStyleBackColor = true;
            this.btnSquare.Click += new System.EventHandler(this.btnSquare_Click);
            // 
            // btnSqrt
            // 
            this.btnSqrt.Location = new System.Drawing.Point(411, 79);
            this.btnSqrt.Name = "btnSqrt";
            this.btnSqrt.Size = new System.Drawing.Size(56, 54);
            this.btnSqrt.TabIndex = 24;
            this.btnSqrt.Text = "√";
            this.btnSqrt.UseVisualStyleBackColor = true;
            this.btnSqrt.Click += new System.EventHandler(this.btnSqrt_Click);
            // 
            // btnLog
            // 
            this.btnLog.Location = new System.Drawing.Point(349, 79);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(56, 54);
            this.btnLog.TabIndex = 23;
            this.btnLog.Text = "log";
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // btnPi
            // 
            this.btnPi.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPi.Location = new System.Drawing.Point(287, 79);
            this.btnPi.Name = "btnPi";
            this.btnPi.Size = new System.Drawing.Size(56, 54);
            this.btnPi.TabIndex = 22;
            this.btnPi.Text = "π";
            this.btnPi.UseVisualStyleBackColor = true;
            this.btnPi.Click += new System.EventHandler(this.btnPi_Click);
            // 
            // btnCube
            // 
            this.btnCube.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCube.Location = new System.Drawing.Point(473, 139);
            this.btnCube.Name = "btnCube";
            this.btnCube.Size = new System.Drawing.Size(56, 54);
            this.btnCube.TabIndex = 29;
            this.btnCube.Text = "x³";
            this.btnCube.UseVisualStyleBackColor = true;
            this.btnCube.Click += new System.EventHandler(this.btnCube_Click);
            // 
            // btnDec
            // 
            this.btnDec.Location = new System.Drawing.Point(411, 139);
            this.btnDec.Name = "btnDec";
            this.btnDec.Size = new System.Drawing.Size(56, 54);
            this.btnDec.TabIndex = 28;
            this.btnDec.Text = "dec";
            this.btnDec.UseVisualStyleBackColor = true;
            this.btnDec.Click += new System.EventHandler(this.btnDec_Click);
            // 
            // btnSin
            // 
            this.btnSin.Location = new System.Drawing.Point(349, 139);
            this.btnSin.Name = "btnSin";
            this.btnSin.Size = new System.Drawing.Size(56, 54);
            this.btnSin.TabIndex = 27;
            this.btnSin.Text = "sin";
            this.btnSin.UseVisualStyleBackColor = true;
            this.btnSin.Click += new System.EventHandler(this.btnSin_Click);
            // 
            // btnSinh
            // 
            this.btnSinh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSinh.Location = new System.Drawing.Point(287, 139);
            this.btnSinh.Name = "btnSinh";
            this.btnSinh.Size = new System.Drawing.Size(56, 54);
            this.btnSinh.TabIndex = 26;
            this.btnSinh.Text = "sinh";
            this.btnSinh.UseVisualStyleBackColor = true;
            this.btnSinh.Click += new System.EventHandler(this.btnSinh_Click);
            // 
            // btnFraction
            // 
            this.btnFraction.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFraction.Location = new System.Drawing.Point(473, 198);
            this.btnFraction.Name = "btnFraction";
            this.btnFraction.Size = new System.Drawing.Size(56, 54);
            this.btnFraction.TabIndex = 33;
            this.btnFraction.Text = "1/x";
            this.btnFraction.UseVisualStyleBackColor = true;
            this.btnFraction.Click += new System.EventHandler(this.btnFraction_Click);
            // 
            // btnBin
            // 
            this.btnBin.Location = new System.Drawing.Point(411, 198);
            this.btnBin.Name = "btnBin";
            this.btnBin.Size = new System.Drawing.Size(56, 54);
            this.btnBin.TabIndex = 32;
            this.btnBin.Text = "bin";
            this.btnBin.UseVisualStyleBackColor = true;
            this.btnBin.Click += new System.EventHandler(this.btnBin_Click);
            // 
            // btnCos
            // 
            this.btnCos.Location = new System.Drawing.Point(348, 198);
            this.btnCos.Name = "btnCos";
            this.btnCos.Size = new System.Drawing.Size(56, 54);
            this.btnCos.TabIndex = 31;
            this.btnCos.Text = "cos";
            this.btnCos.UseVisualStyleBackColor = true;
            this.btnCos.Click += new System.EventHandler(this.btnCos_Click);
            // 
            // btnCosh
            // 
            this.btnCosh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCosh.Location = new System.Drawing.Point(287, 198);
            this.btnCosh.Name = "btnCosh";
            this.btnCosh.Size = new System.Drawing.Size(56, 54);
            this.btnCosh.TabIndex = 30;
            this.btnCosh.Text = "cosh";
            this.btnCosh.UseVisualStyleBackColor = true;
            this.btnCosh.Click += new System.EventHandler(this.btnCosh_Click);
            // 
            // btnLn
            // 
            this.btnLn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLn.Location = new System.Drawing.Point(473, 258);
            this.btnLn.Name = "btnLn";
            this.btnLn.Size = new System.Drawing.Size(56, 54);
            this.btnLn.TabIndex = 37;
            this.btnLn.Text = "ln x";
            this.btnLn.UseVisualStyleBackColor = true;
            this.btnLn.Click += new System.EventHandler(this.btnLn_Click);
            // 
            // btnHex
            // 
            this.btnHex.Location = new System.Drawing.Point(411, 258);
            this.btnHex.Name = "btnHex";
            this.btnHex.Size = new System.Drawing.Size(56, 54);
            this.btnHex.TabIndex = 36;
            this.btnHex.Text = "hex";
            this.btnHex.UseVisualStyleBackColor = true;
            this.btnHex.Click += new System.EventHandler(this.btnHex_Click);
            // 
            // btnTan
            // 
            this.btnTan.Location = new System.Drawing.Point(349, 258);
            this.btnTan.Name = "btnTan";
            this.btnTan.Size = new System.Drawing.Size(56, 54);
            this.btnTan.TabIndex = 35;
            this.btnTan.Text = "tan";
            this.btnTan.UseVisualStyleBackColor = true;
            this.btnTan.Click += new System.EventHandler(this.btnTan_Click);
            // 
            // btnTanh
            // 
            this.btnTanh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTanh.Location = new System.Drawing.Point(287, 258);
            this.btnTanh.Name = "btnTanh";
            this.btnTanh.Size = new System.Drawing.Size(56, 54);
            this.btnTanh.TabIndex = 34;
            this.btnTanh.Text = "tanh";
            this.btnTanh.UseVisualStyleBackColor = true;
            this.btnTanh.Click += new System.EventHandler(this.btnTanh_Click);
            // 
            // btnPercent
            // 
            this.btnPercent.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPercent.Location = new System.Drawing.Point(473, 318);
            this.btnPercent.Name = "btnPercent";
            this.btnPercent.Size = new System.Drawing.Size(56, 54);
            this.btnPercent.TabIndex = 41;
            this.btnPercent.Text = "%";
            this.btnPercent.UseVisualStyleBackColor = true;
            this.btnPercent.Click += new System.EventHandler(this.btnPercent_Click);
            // 
            // btnOct
            // 
            this.btnOct.Location = new System.Drawing.Point(411, 318);
            this.btnOct.Name = "btnOct";
            this.btnOct.Size = new System.Drawing.Size(56, 54);
            this.btnOct.TabIndex = 40;
            this.btnOct.Text = "oct";
            this.btnOct.UseVisualStyleBackColor = true;
            this.btnOct.Click += new System.EventHandler(this.btnOct_Click);
            // 
            // btnMod
            // 
            this.btnMod.Location = new System.Drawing.Point(349, 318);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(56, 54);
            this.btnMod.TabIndex = 39;
            this.btnMod.Text = "mod";
            this.btnMod.UseVisualStyleBackColor = true;
            this.btnMod.Click += new System.EventHandler(this.Operators);
            // 
            // btnExp
            // 
            this.btnExp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExp.Location = new System.Drawing.Point(287, 318);
            this.btnExp.Name = "btnExp";
            this.btnExp.Size = new System.Drawing.Size(56, 54);
            this.btnExp.TabIndex = 38;
            this.btnExp.Text = "exp";
            this.btnExp.UseVisualStyleBackColor = true;
            this.btnExp.Click += new System.EventHandler(this.Operators);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 392);
            this.Controls.Add(this.btnPercent);
            this.Controls.Add(this.btnOct);
            this.Controls.Add(this.btnMod);
            this.Controls.Add(this.btnExp);
            this.Controls.Add(this.btnLn);
            this.Controls.Add(this.btnHex);
            this.Controls.Add(this.btnTan);
            this.Controls.Add(this.btnTanh);
            this.Controls.Add(this.btnFraction);
            this.Controls.Add(this.btnBin);
            this.Controls.Add(this.btnCos);
            this.Controls.Add(this.btnCosh);
            this.Controls.Add(this.btnCube);
            this.Controls.Add(this.btnDec);
            this.Controls.Add(this.btnSin);
            this.Controls.Add(this.btnSinh);
            this.Controls.Add(this.btnSquare);
            this.Controls.Add(this.btnSqrt);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.btnPi);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.btnDot);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnSubtract);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnAddSub);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnClearEntry);
            this.Controls.Add(this.btnBackSpace);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtResult;
        private Button btnBackSpace;
        private Button btnClearEntry;
        private Button btnClear;
        private Button btnAddSub;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btnAdd;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btnSubtract;
        private Button btn1;
        private Button button14;
        private Button btn3;
        private Button btnMultiply;
        private Button btn0;
        private Button btnDot;
        private Button btnEqual;
        private Button btnDivide;
        private MenuStrip menuStrip1;
        private Button btnSquare;
        private Button btnSqrt;
        private Button btnLog;
        private Button btnPi;
        private Button btnCube;
        private Button btnDec;
        private Button btnSin;
        private Button btnSinh;
        private Button btnFraction;
        private Button btnBin;
        private Button btnCos;
        private Button btnCosh;
        private Button btnLn;
        private Button btnHex;
        private Button btnTan;
        private Button btnTanh;
        private Button btnPercent;
        private Button btnOct;
        private Button btnMod;
        private Button btnExp;
    }
}