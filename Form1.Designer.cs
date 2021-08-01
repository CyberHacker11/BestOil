
namespace BestOil
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbx_GasStation = new System.Windows.Forms.GroupBox();
            this.mbx_Money = new System.Windows.Forms.MaskedTextBox();
            this.mbx_Litr = new System.Windows.Forms.MaskedTextBox();
            this.lbl_Litr = new System.Windows.Forms.Label();
            this.lbl_AZN1 = new System.Windows.Forms.Label();
            this.lbl_AZN0 = new System.Windows.Forms.Label();
            this.gbx_OilSum = new System.Windows.Forms.GroupBox();
            this.lbl_AZN2 = new System.Windows.Forms.Label();
            this.lbl_GasStationSum = new System.Windows.Forms.Label();
            this.lbl_OilsPrice = new System.Windows.Forms.Label();
            this.cbx_Oils = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbtn_Money = new System.Windows.Forms.RadioButton();
            this.rbtn_Amount = new System.Windows.Forms.RadioButton();
            this.lbl_OilsPriceText = new System.Windows.Forms.Label();
            this.lbl_Oil = new System.Windows.Forms.Label();
            this.gbx_MiniCafe = new System.Windows.Forms.GroupBox();
            this.mbx_HotdogAmount = new System.Windows.Forms.MaskedTextBox();
            this.mbx_HamburgerAmount = new System.Windows.Forms.MaskedTextBox();
            this.mbx_FreeAmount = new System.Windows.Forms.MaskedTextBox();
            this.mbx_CocaColaAmount = new System.Windows.Forms.MaskedTextBox();
            this.gbx_CafeSum = new System.Windows.Forms.GroupBox();
            this.lbl_AZN3 = new System.Windows.Forms.Label();
            this.lbl_CafeSum = new System.Windows.Forms.Label();
            this.lbl_FoodsAmountText = new System.Windows.Forms.Label();
            this.lbl_FoodsPriceText = new System.Windows.Forms.Label();
            this.lbl_CocaColaPrice = new System.Windows.Forms.Label();
            this.lbl_FreePrice = new System.Windows.Forms.Label();
            this.lbl_HamburgerPrice = new System.Windows.Forms.Label();
            this.lbl_HotdogPrice = new System.Windows.Forms.Label();
            this.cbx_CocaCola = new System.Windows.Forms.CheckBox();
            this.cbx_Free = new System.Windows.Forms.CheckBox();
            this.cbx_Hamburger = new System.Windows.Forms.CheckBox();
            this.cbx_Hotdog = new System.Windows.Forms.CheckBox();
            this.gbx_Total = new System.Windows.Forms.GroupBox();
            this.lbl_AZN4 = new System.Windows.Forms.Label();
            this.lbl_Total = new System.Windows.Forms.Label();
            this.btn_Payment = new System.Windows.Forms.Button();
            this.pbx_SmileIcon = new System.Windows.Forms.PictureBox();
            this.gbx_GasStation.SuspendLayout();
            this.gbx_OilSum.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gbx_MiniCafe.SuspendLayout();
            this.gbx_CafeSum.SuspendLayout();
            this.gbx_Total.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_SmileIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // gbx_GasStation
            // 
            this.gbx_GasStation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gbx_GasStation.Controls.Add(this.mbx_Money);
            this.gbx_GasStation.Controls.Add(this.mbx_Litr);
            this.gbx_GasStation.Controls.Add(this.lbl_Litr);
            this.gbx_GasStation.Controls.Add(this.lbl_AZN1);
            this.gbx_GasStation.Controls.Add(this.lbl_AZN0);
            this.gbx_GasStation.Controls.Add(this.gbx_OilSum);
            this.gbx_GasStation.Controls.Add(this.lbl_OilsPrice);
            this.gbx_GasStation.Controls.Add(this.cbx_Oils);
            this.gbx_GasStation.Controls.Add(this.groupBox3);
            this.gbx_GasStation.Controls.Add(this.lbl_OilsPriceText);
            this.gbx_GasStation.Controls.Add(this.lbl_Oil);
            this.gbx_GasStation.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.gbx_GasStation.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_GasStation.Location = new System.Drawing.Point(12, 12);
            this.gbx_GasStation.MaximumSize = new System.Drawing.Size(324, 410);
            this.gbx_GasStation.MinimumSize = new System.Drawing.Size(324, 410);
            this.gbx_GasStation.Name = "gbx_GasStation";
            this.gbx_GasStation.Padding = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.gbx_GasStation.Size = new System.Drawing.Size(324, 410);
            this.gbx_GasStation.TabIndex = 111;
            this.gbx_GasStation.TabStop = false;
            this.gbx_GasStation.Text = " GAS STATION";
            // 
            // mbx_Money
            // 
            this.mbx_Money.Enabled = false;
            this.mbx_Money.Location = new System.Drawing.Point(176, 236);
            this.mbx_Money.Mask = "000";
            this.mbx_Money.MaximumSize = new System.Drawing.Size(100, 25);
            this.mbx_Money.MinimumSize = new System.Drawing.Size(100, 25);
            this.mbx_Money.Name = "mbx_Money";
            this.mbx_Money.PromptChar = ' ';
            this.mbx_Money.Size = new System.Drawing.Size(100, 25);
            this.mbx_Money.TabIndex = 3;
            this.mbx_Money.ValidatingType = typeof(int);
            this.mbx_Money.TextChanged += new System.EventHandler(this.mbx_Money_TextChanged);
            // 
            // mbx_Litr
            // 
            this.mbx_Litr.Enabled = false;
            this.mbx_Litr.Location = new System.Drawing.Point(176, 195);
            this.mbx_Litr.Mask = "000";
            this.mbx_Litr.MaximumSize = new System.Drawing.Size(100, 25);
            this.mbx_Litr.MinimumSize = new System.Drawing.Size(100, 25);
            this.mbx_Litr.Name = "mbx_Litr";
            this.mbx_Litr.PromptChar = ' ';
            this.mbx_Litr.Size = new System.Drawing.Size(100, 25);
            this.mbx_Litr.TabIndex = 2;
            this.mbx_Litr.ValidatingType = typeof(int);
            this.mbx_Litr.TextChanged += new System.EventHandler(this.mbx_Litr_TextChanged);
            // 
            // lbl_Litr
            // 
            this.lbl_Litr.AutoSize = true;
            this.lbl_Litr.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Litr.Location = new System.Drawing.Point(281, 200);
            this.lbl_Litr.Name = "lbl_Litr";
            this.lbl_Litr.Size = new System.Drawing.Size(29, 16);
            this.lbl_Litr.TabIndex = 11;
            this.lbl_Litr.Text = "Litr";
            // 
            // lbl_AZN1
            // 
            this.lbl_AZN1.AutoSize = true;
            this.lbl_AZN1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_AZN1.Location = new System.Drawing.Point(282, 241);
            this.lbl_AZN1.Name = "lbl_AZN1";
            this.lbl_AZN1.Size = new System.Drawing.Size(33, 16);
            this.lbl_AZN1.TabIndex = 10;
            this.lbl_AZN1.Text = "AZN";
            this.lbl_AZN1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_AZN0
            // 
            this.lbl_AZN0.AutoSize = true;
            this.lbl_AZN0.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_AZN0.Location = new System.Drawing.Point(199, 107);
            this.lbl_AZN0.Name = "lbl_AZN0";
            this.lbl_AZN0.Size = new System.Drawing.Size(33, 16);
            this.lbl_AZN0.TabIndex = 7;
            this.lbl_AZN0.Text = "AZN";
            this.lbl_AZN0.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gbx_OilSum
            // 
            this.gbx_OilSum.Controls.Add(this.lbl_AZN2);
            this.gbx_OilSum.Controls.Add(this.lbl_GasStationSum);
            this.gbx_OilSum.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_OilSum.Location = new System.Drawing.Point(8, 300);
            this.gbx_OilSum.MaximumSize = new System.Drawing.Size(302, 100);
            this.gbx_OilSum.MinimumSize = new System.Drawing.Size(302, 100);
            this.gbx_OilSum.Name = "gbx_OilSum";
            this.gbx_OilSum.Size = new System.Drawing.Size(302, 100);
            this.gbx_OilSum.TabIndex = 111;
            this.gbx_OilSum.TabStop = false;
            this.gbx_OilSum.Text = "SUM";
            // 
            // lbl_AZN2
            // 
            this.lbl_AZN2.AutoSize = true;
            this.lbl_AZN2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_AZN2.Location = new System.Drawing.Point(249, 55);
            this.lbl_AZN2.Name = "lbl_AZN2";
            this.lbl_AZN2.Size = new System.Drawing.Size(47, 22);
            this.lbl_AZN2.TabIndex = 111;
            this.lbl_AZN2.Text = "AZN";
            this.lbl_AZN2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_GasStationSum
            // 
            this.lbl_GasStationSum.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_GasStationSum.Location = new System.Drawing.Point(20, 40);
            this.lbl_GasStationSum.MaximumSize = new System.Drawing.Size(230, 43);
            this.lbl_GasStationSum.MinimumSize = new System.Drawing.Size(230, 43);
            this.lbl_GasStationSum.Name = "lbl_GasStationSum";
            this.lbl_GasStationSum.Size = new System.Drawing.Size(230, 43);
            this.lbl_GasStationSum.TabIndex = 111;
            this.lbl_GasStationSum.Text = "0,00";
            this.lbl_GasStationSum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_OilsPrice
            // 
            this.lbl_OilsPrice.BackColor = System.Drawing.Color.Transparent;
            this.lbl_OilsPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_OilsPrice.Location = new System.Drawing.Point(93, 95);
            this.lbl_OilsPrice.MaximumSize = new System.Drawing.Size(100, 27);
            this.lbl_OilsPrice.MinimumSize = new System.Drawing.Size(100, 27);
            this.lbl_OilsPrice.Name = "lbl_OilsPrice";
            this.lbl_OilsPrice.Size = new System.Drawing.Size(100, 27);
            this.lbl_OilsPrice.TabIndex = 111;
            this.lbl_OilsPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbx_Oils
            // 
            this.cbx_Oils.FormattingEnabled = true;
            this.cbx_Oils.Items.AddRange(new object[] {
            "Ai-92",
            "Ai-95 (Premium)",
            "Ai-98 (Super Premium)",
            "Diesel",
            "LMG (Metan)",
            "LPG (Propan)"});
            this.cbx_Oils.Location = new System.Drawing.Point(93, 42);
            this.cbx_Oils.MaximumSize = new System.Drawing.Size(182, 0);
            this.cbx_Oils.MinimumSize = new System.Drawing.Size(182, 0);
            this.cbx_Oils.Name = "cbx_Oils";
            this.cbx_Oils.Size = new System.Drawing.Size(182, 25);
            this.cbx_Oils.TabIndex = 0;
            this.cbx_Oils.SelectedIndexChanged += new System.EventHandler(this.cbx_Oils_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbtn_Money);
            this.groupBox3.Controls.Add(this.rbtn_Amount);
            this.groupBox3.Location = new System.Drawing.Point(8, 169);
            this.groupBox3.MaximumSize = new System.Drawing.Size(146, 102);
            this.groupBox3.MinimumSize = new System.Drawing.Size(146, 102);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(146, 102);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // rbtn_Money
            // 
            this.rbtn_Money.AutoSize = true;
            this.rbtn_Money.Location = new System.Drawing.Point(6, 63);
            this.rbtn_Money.Name = "rbtn_Money";
            this.rbtn_Money.Size = new System.Drawing.Size(71, 21);
            this.rbtn_Money.TabIndex = 1;
            this.rbtn_Money.TabStop = true;
            this.rbtn_Money.Text = "Money";
            this.rbtn_Money.UseVisualStyleBackColor = true;
            this.rbtn_Money.CheckedChanged += new System.EventHandler(this.rbtn_Money_CheckedChanged);
            // 
            // rbtn_Amount
            // 
            this.rbtn_Amount.AutoSize = true;
            this.rbtn_Amount.Location = new System.Drawing.Point(6, 25);
            this.rbtn_Amount.Name = "rbtn_Amount";
            this.rbtn_Amount.Size = new System.Drawing.Size(80, 21);
            this.rbtn_Amount.TabIndex = 0;
            this.rbtn_Amount.TabStop = true;
            this.rbtn_Amount.Text = "Amount";
            this.rbtn_Amount.UseVisualStyleBackColor = true;
            this.rbtn_Amount.CheckedChanged += new System.EventHandler(this.rbtn_Amount_CheckedChanged);
            // 
            // lbl_OilsPriceText
            // 
            this.lbl_OilsPriceText.AutoSize = true;
            this.lbl_OilsPriceText.Location = new System.Drawing.Point(8, 101);
            this.lbl_OilsPriceText.Name = "lbl_OilsPriceText";
            this.lbl_OilsPriceText.Size = new System.Drawing.Size(45, 17);
            this.lbl_OilsPriceText.TabIndex = 1;
            this.lbl_OilsPriceText.Text = "Price";
            // 
            // lbl_Oil
            // 
            this.lbl_Oil.AutoSize = true;
            this.lbl_Oil.Location = new System.Drawing.Point(8, 45);
            this.lbl_Oil.Name = "lbl_Oil";
            this.lbl_Oil.Size = new System.Drawing.Size(26, 17);
            this.lbl_Oil.TabIndex = 0;
            this.lbl_Oil.Text = "Oil";
            // 
            // gbx_MiniCafe
            // 
            this.gbx_MiniCafe.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.gbx_MiniCafe.Controls.Add(this.mbx_HotdogAmount);
            this.gbx_MiniCafe.Controls.Add(this.mbx_HamburgerAmount);
            this.gbx_MiniCafe.Controls.Add(this.mbx_FreeAmount);
            this.gbx_MiniCafe.Controls.Add(this.mbx_CocaColaAmount);
            this.gbx_MiniCafe.Controls.Add(this.gbx_CafeSum);
            this.gbx_MiniCafe.Controls.Add(this.lbl_FoodsAmountText);
            this.gbx_MiniCafe.Controls.Add(this.lbl_FoodsPriceText);
            this.gbx_MiniCafe.Controls.Add(this.lbl_CocaColaPrice);
            this.gbx_MiniCafe.Controls.Add(this.lbl_FreePrice);
            this.gbx_MiniCafe.Controls.Add(this.lbl_HamburgerPrice);
            this.gbx_MiniCafe.Controls.Add(this.lbl_HotdogPrice);
            this.gbx_MiniCafe.Controls.Add(this.cbx_CocaCola);
            this.gbx_MiniCafe.Controls.Add(this.cbx_Free);
            this.gbx_MiniCafe.Controls.Add(this.cbx_Hamburger);
            this.gbx_MiniCafe.Controls.Add(this.cbx_Hotdog);
            this.gbx_MiniCafe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbx_MiniCafe.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_MiniCafe.Location = new System.Drawing.Point(362, 12);
            this.gbx_MiniCafe.MaximumSize = new System.Drawing.Size(336, 410);
            this.gbx_MiniCafe.MinimumSize = new System.Drawing.Size(336, 410);
            this.gbx_MiniCafe.Name = "gbx_MiniCafe";
            this.gbx_MiniCafe.Size = new System.Drawing.Size(336, 410);
            this.gbx_MiniCafe.TabIndex = 111;
            this.gbx_MiniCafe.TabStop = false;
            this.gbx_MiniCafe.Text = "MINI CAFE";
            // 
            // mbx_HotdogAmount
            // 
            this.mbx_HotdogAmount.Enabled = false;
            this.mbx_HotdogAmount.Location = new System.Drawing.Point(237, 59);
            this.mbx_HotdogAmount.Mask = "00";
            this.mbx_HotdogAmount.MaximumSize = new System.Drawing.Size(85, 25);
            this.mbx_HotdogAmount.MinimumSize = new System.Drawing.Size(85, 25);
            this.mbx_HotdogAmount.Name = "mbx_HotdogAmount";
            this.mbx_HotdogAmount.PromptChar = ' ';
            this.mbx_HotdogAmount.Size = new System.Drawing.Size(85, 25);
            this.mbx_HotdogAmount.TabIndex = 111;
            this.mbx_HotdogAmount.ValidatingType = typeof(int);
            this.mbx_HotdogAmount.TextChanged += new System.EventHandler(this.MultiplyChanged);
            // 
            // mbx_HamburgerAmount
            // 
            this.mbx_HamburgerAmount.Enabled = false;
            this.mbx_HamburgerAmount.Location = new System.Drawing.Point(237, 101);
            this.mbx_HamburgerAmount.Mask = "00";
            this.mbx_HamburgerAmount.MaximumSize = new System.Drawing.Size(85, 25);
            this.mbx_HamburgerAmount.MinimumSize = new System.Drawing.Size(85, 25);
            this.mbx_HamburgerAmount.Name = "mbx_HamburgerAmount";
            this.mbx_HamburgerAmount.PromptChar = ' ';
            this.mbx_HamburgerAmount.Size = new System.Drawing.Size(85, 25);
            this.mbx_HamburgerAmount.TabIndex = 111;
            this.mbx_HamburgerAmount.ValidatingType = typeof(int);
            this.mbx_HamburgerAmount.TextChanged += new System.EventHandler(this.MultiplyChanged);
            // 
            // mbx_FreeAmount
            // 
            this.mbx_FreeAmount.Enabled = false;
            this.mbx_FreeAmount.Location = new System.Drawing.Point(237, 143);
            this.mbx_FreeAmount.Mask = "00";
            this.mbx_FreeAmount.MaximumSize = new System.Drawing.Size(85, 25);
            this.mbx_FreeAmount.MinimumSize = new System.Drawing.Size(85, 25);
            this.mbx_FreeAmount.Name = "mbx_FreeAmount";
            this.mbx_FreeAmount.PromptChar = ' ';
            this.mbx_FreeAmount.Size = new System.Drawing.Size(85, 25);
            this.mbx_FreeAmount.TabIndex = 111;
            this.mbx_FreeAmount.ValidatingType = typeof(int);
            this.mbx_FreeAmount.TextChanged += new System.EventHandler(this.MultiplyChanged);
            // 
            // mbx_CocaColaAmount
            // 
            this.mbx_CocaColaAmount.Enabled = false;
            this.mbx_CocaColaAmount.Location = new System.Drawing.Point(237, 186);
            this.mbx_CocaColaAmount.Mask = "00";
            this.mbx_CocaColaAmount.MaximumSize = new System.Drawing.Size(85, 25);
            this.mbx_CocaColaAmount.MinimumSize = new System.Drawing.Size(85, 25);
            this.mbx_CocaColaAmount.Name = "mbx_CocaColaAmount";
            this.mbx_CocaColaAmount.PromptChar = ' ';
            this.mbx_CocaColaAmount.Size = new System.Drawing.Size(85, 25);
            this.mbx_CocaColaAmount.TabIndex = 111;
            this.mbx_CocaColaAmount.ValidatingType = typeof(int);
            this.mbx_CocaColaAmount.TextChanged += new System.EventHandler(this.MultiplyChanged);
            // 
            // gbx_CafeSum
            // 
            this.gbx_CafeSum.Controls.Add(this.lbl_AZN3);
            this.gbx_CafeSum.Controls.Add(this.lbl_CafeSum);
            this.gbx_CafeSum.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_CafeSum.Location = new System.Drawing.Point(15, 300);
            this.gbx_CafeSum.MaximumSize = new System.Drawing.Size(307, 100);
            this.gbx_CafeSum.MinimumSize = new System.Drawing.Size(307, 100);
            this.gbx_CafeSum.Name = "gbx_CafeSum";
            this.gbx_CafeSum.Size = new System.Drawing.Size(307, 100);
            this.gbx_CafeSum.TabIndex = 111;
            this.gbx_CafeSum.TabStop = false;
            this.gbx_CafeSum.Text = "SUM";
            // 
            // lbl_AZN3
            // 
            this.lbl_AZN3.AutoSize = true;
            this.lbl_AZN3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_AZN3.Location = new System.Drawing.Point(254, 55);
            this.lbl_AZN3.Name = "lbl_AZN3";
            this.lbl_AZN3.Size = new System.Drawing.Size(47, 22);
            this.lbl_AZN3.TabIndex = 111;
            this.lbl_AZN3.Text = "AZN";
            this.lbl_AZN3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_CafeSum
            // 
            this.lbl_CafeSum.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_CafeSum.Location = new System.Drawing.Point(18, 40);
            this.lbl_CafeSum.MaximumSize = new System.Drawing.Size(230, 43);
            this.lbl_CafeSum.MinimumSize = new System.Drawing.Size(230, 43);
            this.lbl_CafeSum.Name = "lbl_CafeSum";
            this.lbl_CafeSum.Size = new System.Drawing.Size(230, 43);
            this.lbl_CafeSum.TabIndex = 111;
            this.lbl_CafeSum.Text = "0,00";
            this.lbl_CafeSum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_FoodsAmountText
            // 
            this.lbl_FoodsAmountText.AutoSize = true;
            this.lbl_FoodsAmountText.Location = new System.Drawing.Point(253, 31);
            this.lbl_FoodsAmountText.Name = "lbl_FoodsAmountText";
            this.lbl_FoodsAmountText.Size = new System.Drawing.Size(62, 17);
            this.lbl_FoodsAmountText.TabIndex = 20;
            this.lbl_FoodsAmountText.Text = "Amount";
            // 
            // lbl_FoodsPriceText
            // 
            this.lbl_FoodsPriceText.AutoSize = true;
            this.lbl_FoodsPriceText.Location = new System.Drawing.Point(172, 31);
            this.lbl_FoodsPriceText.Name = "lbl_FoodsPriceText";
            this.lbl_FoodsPriceText.Size = new System.Drawing.Size(45, 17);
            this.lbl_FoodsPriceText.TabIndex = 19;
            this.lbl_FoodsPriceText.Text = "Price";
            // 
            // lbl_CocaColaPrice
            // 
            this.lbl_CocaColaPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_CocaColaPrice.Location = new System.Drawing.Point(135, 186);
            this.lbl_CocaColaPrice.MaximumSize = new System.Drawing.Size(85, 27);
            this.lbl_CocaColaPrice.MinimumSize = new System.Drawing.Size(85, 27);
            this.lbl_CocaColaPrice.Name = "lbl_CocaColaPrice";
            this.lbl_CocaColaPrice.Size = new System.Drawing.Size(85, 27);
            this.lbl_CocaColaPrice.TabIndex = 13;
            this.lbl_CocaColaPrice.Text = "4,00";
            this.lbl_CocaColaPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_FreePrice
            // 
            this.lbl_FreePrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_FreePrice.Location = new System.Drawing.Point(135, 143);
            this.lbl_FreePrice.MaximumSize = new System.Drawing.Size(85, 27);
            this.lbl_FreePrice.MinimumSize = new System.Drawing.Size(85, 27);
            this.lbl_FreePrice.Name = "lbl_FreePrice";
            this.lbl_FreePrice.Size = new System.Drawing.Size(85, 27);
            this.lbl_FreePrice.TabIndex = 12;
            this.lbl_FreePrice.Text = "2,30";
            this.lbl_FreePrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_HamburgerPrice
            // 
            this.lbl_HamburgerPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_HamburgerPrice.Location = new System.Drawing.Point(135, 101);
            this.lbl_HamburgerPrice.MaximumSize = new System.Drawing.Size(85, 27);
            this.lbl_HamburgerPrice.MinimumSize = new System.Drawing.Size(85, 27);
            this.lbl_HamburgerPrice.Name = "lbl_HamburgerPrice";
            this.lbl_HamburgerPrice.Size = new System.Drawing.Size(85, 27);
            this.lbl_HamburgerPrice.TabIndex = 11;
            this.lbl_HamburgerPrice.Text = "3,40";
            this.lbl_HamburgerPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_HotdogPrice
            // 
            this.lbl_HotdogPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_HotdogPrice.Location = new System.Drawing.Point(135, 59);
            this.lbl_HotdogPrice.MaximumSize = new System.Drawing.Size(85, 27);
            this.lbl_HotdogPrice.MinimumSize = new System.Drawing.Size(85, 27);
            this.lbl_HotdogPrice.Name = "lbl_HotdogPrice";
            this.lbl_HotdogPrice.Size = new System.Drawing.Size(85, 27);
            this.lbl_HotdogPrice.TabIndex = 10;
            this.lbl_HotdogPrice.Text = "1,50";
            this.lbl_HotdogPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbx_CocaCola
            // 
            this.cbx_CocaCola.AutoSize = true;
            this.cbx_CocaCola.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_CocaCola.Location = new System.Drawing.Point(15, 190);
            this.cbx_CocaCola.Name = "cbx_CocaCola";
            this.cbx_CocaCola.Size = new System.Drawing.Size(98, 21);
            this.cbx_CocaCola.TabIndex = 3;
            this.cbx_CocaCola.Text = "Coca Cola";
            this.cbx_CocaCola.UseVisualStyleBackColor = true;
            this.cbx_CocaCola.CheckedChanged += new System.EventHandler(this.CheckedProccess);
            // 
            // cbx_Free
            // 
            this.cbx_Free.AutoSize = true;
            this.cbx_Free.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_Free.Location = new System.Drawing.Point(15, 147);
            this.cbx_Free.Name = "cbx_Free";
            this.cbx_Free.Size = new System.Drawing.Size(58, 21);
            this.cbx_Free.TabIndex = 2;
            this.cbx_Free.Text = "Free";
            this.cbx_Free.UseVisualStyleBackColor = true;
            this.cbx_Free.CheckedChanged += new System.EventHandler(this.CheckedProccess);
            // 
            // cbx_Hamburger
            // 
            this.cbx_Hamburger.AutoSize = true;
            this.cbx_Hamburger.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_Hamburger.Location = new System.Drawing.Point(15, 105);
            this.cbx_Hamburger.Name = "cbx_Hamburger";
            this.cbx_Hamburger.Size = new System.Drawing.Size(108, 21);
            this.cbx_Hamburger.TabIndex = 1;
            this.cbx_Hamburger.Text = "Hamburger";
            this.cbx_Hamburger.UseVisualStyleBackColor = true;
            this.cbx_Hamburger.CheckedChanged += new System.EventHandler(this.CheckedProccess);
            // 
            // cbx_Hotdog
            // 
            this.cbx_Hotdog.AutoSize = true;
            this.cbx_Hotdog.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_Hotdog.Location = new System.Drawing.Point(15, 63);
            this.cbx_Hotdog.Name = "cbx_Hotdog";
            this.cbx_Hotdog.Size = new System.Drawing.Size(79, 21);
            this.cbx_Hotdog.TabIndex = 0;
            this.cbx_Hotdog.Text = "Hotdog";
            this.cbx_Hotdog.UseVisualStyleBackColor = true;
            this.cbx_Hotdog.CheckedChanged += new System.EventHandler(this.CheckedProccess);
            // 
            // gbx_Total
            // 
            this.gbx_Total.Controls.Add(this.lbl_AZN4);
            this.gbx_Total.Controls.Add(this.lbl_Total);
            this.gbx_Total.Controls.Add(this.btn_Payment);
            this.gbx_Total.Controls.Add(this.pbx_SmileIcon);
            this.gbx_Total.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_Total.Location = new System.Drawing.Point(12, 441);
            this.gbx_Total.MaximumSize = new System.Drawing.Size(686, 139);
            this.gbx_Total.MinimumSize = new System.Drawing.Size(686, 139);
            this.gbx_Total.Name = "gbx_Total";
            this.gbx_Total.Size = new System.Drawing.Size(686, 139);
            this.gbx_Total.TabIndex = 111;
            this.gbx_Total.TabStop = false;
            this.gbx_Total.Text = "TOTAL";
            // 
            // lbl_AZN4
            // 
            this.lbl_AZN4.AutoSize = true;
            this.lbl_AZN4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_AZN4.Location = new System.Drawing.Point(605, 79);
            this.lbl_AZN4.Name = "lbl_AZN4";
            this.lbl_AZN4.Size = new System.Drawing.Size(47, 22);
            this.lbl_AZN4.TabIndex = 111;
            this.lbl_AZN4.Text = "AZN";
            this.lbl_AZN4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_Total
            // 
            this.lbl_Total.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Total.Location = new System.Drawing.Point(365, 46);
            this.lbl_Total.MaximumSize = new System.Drawing.Size(234, 78);
            this.lbl_Total.MinimumSize = new System.Drawing.Size(234, 78);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(234, 78);
            this.lbl_Total.TabIndex = 111;
            this.lbl_Total.Text = "0,00";
            this.lbl_Total.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_Payment
            // 
            this.btn_Payment.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_Payment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Payment.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Payment.Location = new System.Drawing.Point(121, 46);
            this.btn_Payment.MaximumSize = new System.Drawing.Size(203, 78);
            this.btn_Payment.MinimumSize = new System.Drawing.Size(203, 78);
            this.btn_Payment.Name = "btn_Payment";
            this.btn_Payment.Size = new System.Drawing.Size(203, 78);
            this.btn_Payment.TabIndex = 5;
            this.btn_Payment.Text = "Payment";
            this.btn_Payment.UseVisualStyleBackColor = false;
            // 
            // pbx_SmileIcon
            // 
            this.pbx_SmileIcon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbx_SmileIcon.Image = global::BestOil.Properties.Resources.dollar_eyes_220;
            this.pbx_SmileIcon.Location = new System.Drawing.Point(14, 46);
            this.pbx_SmileIcon.MaximumSize = new System.Drawing.Size(87, 80);
            this.pbx_SmileIcon.MinimumSize = new System.Drawing.Size(87, 80);
            this.pbx_SmileIcon.Name = "pbx_SmileIcon";
            this.pbx_SmileIcon.Size = new System.Drawing.Size(87, 80);
            this.pbx_SmileIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbx_SmileIcon.TabIndex = 0;
            this.pbx_SmileIcon.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(710, 592);
            this.Controls.Add(this.gbx_Total);
            this.Controls.Add(this.gbx_MiniCafe);
            this.Controls.Add(this.gbx_GasStation);
            this.MaximumSize = new System.Drawing.Size(726, 631);
            this.MinimumSize = new System.Drawing.Size(726, 631);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbx_GasStation.ResumeLayout(false);
            this.gbx_GasStation.PerformLayout();
            this.gbx_OilSum.ResumeLayout(false);
            this.gbx_OilSum.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.gbx_MiniCafe.ResumeLayout(false);
            this.gbx_MiniCafe.PerformLayout();
            this.gbx_CafeSum.ResumeLayout(false);
            this.gbx_CafeSum.PerformLayout();
            this.gbx_Total.ResumeLayout(false);
            this.gbx_Total.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_SmileIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbx_GasStation;
        private System.Windows.Forms.Label lbl_OilsPrice;
        private System.Windows.Forms.ComboBox cbx_Oils;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbl_OilsPriceText;
        private System.Windows.Forms.Label lbl_Oil;
        private System.Windows.Forms.GroupBox gbx_MiniCafe;
        private System.Windows.Forms.GroupBox gbx_OilSum;
        private System.Windows.Forms.RadioButton rbtn_Money;
        private System.Windows.Forms.RadioButton rbtn_Amount;
        private System.Windows.Forms.GroupBox gbx_CafeSum;
        private System.Windows.Forms.Label lbl_FoodsAmountText;
        private System.Windows.Forms.Label lbl_FoodsPriceText;
        private System.Windows.Forms.Label lbl_CocaColaPrice;
        private System.Windows.Forms.Label lbl_FreePrice;
        private System.Windows.Forms.Label lbl_HamburgerPrice;
        private System.Windows.Forms.Label lbl_HotdogPrice;
        private System.Windows.Forms.CheckBox cbx_CocaCola;
        private System.Windows.Forms.CheckBox cbx_Free;
        private System.Windows.Forms.CheckBox cbx_Hamburger;
        private System.Windows.Forms.CheckBox cbx_Hotdog;
        private System.Windows.Forms.GroupBox gbx_Total;
        private System.Windows.Forms.Button btn_Payment;
        private System.Windows.Forms.PictureBox pbx_SmileIcon;
        private System.Windows.Forms.Label lbl_AZN3;
        private System.Windows.Forms.Label lbl_CafeSum;
        private System.Windows.Forms.Label lbl_AZN4;
        private System.Windows.Forms.Label lbl_Total;
        private System.Windows.Forms.Label lbl_AZN2;
        private System.Windows.Forms.Label lbl_GasStationSum;
        private System.Windows.Forms.Label lbl_AZN0;
        private System.Windows.Forms.Label lbl_Litr;
        private System.Windows.Forms.Label lbl_AZN1;
        private System.Windows.Forms.MaskedTextBox mbx_Litr;
        private System.Windows.Forms.MaskedTextBox mbx_Money;
        private System.Windows.Forms.MaskedTextBox mbx_CocaColaAmount;
        private System.Windows.Forms.MaskedTextBox mbx_HotdogAmount;
        private System.Windows.Forms.MaskedTextBox mbx_HamburgerAmount;
        private System.Windows.Forms.MaskedTextBox mbx_FreeAmount;
    }
}

