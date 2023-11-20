namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button3 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.yöneticiyiÇağırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.süresizMasaAçmaİsteğiGönderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.süreliMasaAçmaİsteğiGönderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dakşkaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dakikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.daToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saatToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saatToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.saatToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.masaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button21 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.İstekID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MasaID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Masa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.İstekTuru = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Aciklama = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tarih = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.ContextMenuStrip = this.contextMenuStrip1;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = global::WindowsFormsApp1.Properties.Resources._19702157991557740339_64;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.Location = new System.Drawing.Point(131, 8);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 83);
            this.button3.TabIndex = 0;
            this.button3.Text = "MASA : 2";
            this.button3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yöneticiyiÇağırToolStripMenuItem,
            this.süresizMasaAçmaİsteğiGönderToolStripMenuItem,
            this.süreliMasaAçmaİsteğiGönderToolStripMenuItem,
            this.masaToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(207, 92);
            // 
            // yöneticiyiÇağırToolStripMenuItem
            // 
            this.yöneticiyiÇağırToolStripMenuItem.Name = "yöneticiyiÇağırToolStripMenuItem";
            this.yöneticiyiÇağırToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.yöneticiyiÇağırToolStripMenuItem.Text = "Yöneticiyi Çağır";
            // 
            // süresizMasaAçmaİsteğiGönderToolStripMenuItem
            // 
            this.süresizMasaAçmaİsteğiGönderToolStripMenuItem.Name = "süresizMasaAçmaİsteğiGönderToolStripMenuItem";
            this.süresizMasaAçmaİsteğiGönderToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.süresizMasaAçmaİsteğiGönderToolStripMenuItem.Text = "Süresiz Masa Açma İsteği";
            this.süresizMasaAçmaİsteğiGönderToolStripMenuItem.Click += new System.EventHandler(this.süresizMasaAçmaİsteğiGönderToolStripMenuItem_Click);
            // 
            // süreliMasaAçmaİsteğiGönderToolStripMenuItem
            // 
            this.süreliMasaAçmaİsteğiGönderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dakşkaToolStripMenuItem,
            this.dakikaToolStripMenuItem,
            this.daToolStripMenuItem,
            this.saatToolStripMenuItem,
            this.saatToolStripMenuItem1,
            this.saatToolStripMenuItem2,
            this.saatToolStripMenuItem3});
            this.süreliMasaAçmaİsteğiGönderToolStripMenuItem.Name = "süreliMasaAçmaİsteğiGönderToolStripMenuItem";
            this.süreliMasaAçmaİsteğiGönderToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.süreliMasaAçmaİsteğiGönderToolStripMenuItem.Text = "Süreli Masa Açma İsteği ";
            // 
            // dakşkaToolStripMenuItem
            // 
            this.dakşkaToolStripMenuItem.Name = "dakşkaToolStripMenuItem";
            this.dakşkaToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.dakşkaToolStripMenuItem.Text = "20 Dakika";
            // 
            // dakikaToolStripMenuItem
            // 
            this.dakikaToolStripMenuItem.Name = "dakikaToolStripMenuItem";
            this.dakikaToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.dakikaToolStripMenuItem.Text = "30 Dakika";
            // 
            // daToolStripMenuItem
            // 
            this.daToolStripMenuItem.Name = "daToolStripMenuItem";
            this.daToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.daToolStripMenuItem.Text = "40 Dakika";
            // 
            // saatToolStripMenuItem
            // 
            this.saatToolStripMenuItem.Name = "saatToolStripMenuItem";
            this.saatToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.saatToolStripMenuItem.Text = "1 Saat";
            // 
            // saatToolStripMenuItem1
            // 
            this.saatToolStripMenuItem1.Name = "saatToolStripMenuItem1";
            this.saatToolStripMenuItem1.Size = new System.Drawing.Size(124, 22);
            this.saatToolStripMenuItem1.Text = "1.30 Saat";
            // 
            // saatToolStripMenuItem2
            // 
            this.saatToolStripMenuItem2.Name = "saatToolStripMenuItem2";
            this.saatToolStripMenuItem2.Size = new System.Drawing.Size(124, 22);
            this.saatToolStripMenuItem2.Text = "2 Saat";
            // 
            // saatToolStripMenuItem3
            // 
            this.saatToolStripMenuItem3.Name = "saatToolStripMenuItem3";
            this.saatToolStripMenuItem3.Size = new System.Drawing.Size(124, 22);
            this.saatToolStripMenuItem3.Text = "3 Saat";
            // 
            // masaToolStripMenuItem
            // 
            this.masaToolStripMenuItem.Name = "masaToolStripMenuItem";
            this.masaToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.masaToolStripMenuItem.Text = "Masa Değiştirme İsteği";
            this.masaToolStripMenuItem.Click += new System.EventHandler(this.masaToolStripMenuItem_Click);
            // 
            // button4
            // 
            this.button4.ContextMenuStrip = this.contextMenuStrip1;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Image = global::WindowsFormsApp1.Properties.Resources._19702157991557740339_64;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.Location = new System.Drawing.Point(233, 8);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(96, 83);
            this.button4.TabIndex = 0;
            this.button4.Text = "MASA : 3";
            this.button4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.ContextMenuStrip = this.contextMenuStrip1;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Image = global::WindowsFormsApp1.Properties.Resources._19702157991557740339_64;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button5.Location = new System.Drawing.Point(335, 8);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(96, 83);
            this.button5.TabIndex = 0;
            this.button5.Text = "MASA : 4";
            this.button5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.ContextMenuStrip = this.contextMenuStrip1;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Image = global::WindowsFormsApp1.Properties.Resources._19702157991557740339_64;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button6.Location = new System.Drawing.Point(437, 8);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(96, 83);
            this.button6.TabIndex = 0;
            this.button6.Text = "MASA : 5";
            this.button6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.ContextMenuStrip = this.contextMenuStrip1;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Image = global::WindowsFormsApp1.Properties.Resources._19702157991557740339_64;
            this.button7.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button7.Location = new System.Drawing.Point(539, 8);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(96, 83);
            this.button7.TabIndex = 0;
            this.button7.Text = "MASA : 6";
            this.button7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.ContextMenuStrip = this.contextMenuStrip1;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Image = global::WindowsFormsApp1.Properties.Resources._19702157991557740339_64;
            this.button10.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button10.Location = new System.Drawing.Point(641, 8);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(96, 83);
            this.button10.TabIndex = 0;
            this.button10.Text = "MASA : 7";
            this.button10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.ContextMenuStrip = this.contextMenuStrip1;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Image = global::WindowsFormsApp1.Properties.Resources._19702157991557740339_64;
            this.button8.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button8.Location = new System.Drawing.Point(743, 8);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(96, 83);
            this.button8.TabIndex = 0;
            this.button8.Text = "MASA : 8";
            this.button8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.ContextMenuStrip = this.contextMenuStrip1;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Image = global::WindowsFormsApp1.Properties.Resources._19702157991557740339_64;
            this.button9.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button9.Location = new System.Drawing.Point(845, 8);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(96, 83);
            this.button9.TabIndex = 0;
            this.button9.Text = "MASA : 9";
            this.button9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button8_Click);
            // 
            // button11
            // 
            this.button11.ContextMenuStrip = this.contextMenuStrip1;
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Image = global::WindowsFormsApp1.Properties.Resources._19702157991557740339_64;
            this.button11.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button11.Location = new System.Drawing.Point(947, 8);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(96, 83);
            this.button11.TabIndex = 0;
            this.button11.Text = "MASA : 10";
            this.button11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button8_Click);
            // 
            // button12
            // 
            this.button12.ContextMenuStrip = this.contextMenuStrip1;
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Image = global::WindowsFormsApp1.Properties.Resources._19702157991557740339_64;
            this.button12.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button12.Location = new System.Drawing.Point(29, 407);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(96, 84);
            this.button12.TabIndex = 0;
            this.button12.Text = "MASA : 11";
            this.button12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button8_Click);
            // 
            // button13
            // 
            this.button13.ContextMenuStrip = this.contextMenuStrip1;
            this.button13.FlatAppearance.BorderSize = 0;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Image = global::WindowsFormsApp1.Properties.Resources._19702157991557740339_64;
            this.button13.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button13.Location = new System.Drawing.Point(131, 407);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(96, 84);
            this.button13.TabIndex = 0;
            this.button13.Text = "MASA : 12";
            this.button13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.button8_Click);
            // 
            // button14
            // 
            this.button14.ContextMenuStrip = this.contextMenuStrip1;
            this.button14.FlatAppearance.BorderSize = 0;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Image = global::WindowsFormsApp1.Properties.Resources._19702157991557740339_64;
            this.button14.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button14.Location = new System.Drawing.Point(233, 407);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(96, 84);
            this.button14.TabIndex = 0;
            this.button14.Text = "MASA : 13";
            this.button14.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.button8_Click);
            // 
            // button15
            // 
            this.button15.ContextMenuStrip = this.contextMenuStrip1;
            this.button15.FlatAppearance.BorderSize = 0;
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button15.Image = global::WindowsFormsApp1.Properties.Resources._19702157991557740339_64;
            this.button15.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button15.Location = new System.Drawing.Point(335, 407);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(96, 84);
            this.button15.TabIndex = 0;
            this.button15.Text = "MASA : 14";
            this.button15.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.button8_Click);
            // 
            // button17
            // 
            this.button17.ContextMenuStrip = this.contextMenuStrip1;
            this.button17.FlatAppearance.BorderSize = 0;
            this.button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button17.Image = global::WindowsFormsApp1.Properties.Resources._19702157991557740339_64;
            this.button17.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button17.Location = new System.Drawing.Point(437, 407);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(96, 84);
            this.button17.TabIndex = 0;
            this.button17.Text = "MASA : 15";
            this.button17.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.button8_Click);
            // 
            // button16
            // 
            this.button16.ContextMenuStrip = this.contextMenuStrip1;
            this.button16.FlatAppearance.BorderSize = 0;
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button16.Image = global::WindowsFormsApp1.Properties.Resources._19702157991557740339_64;
            this.button16.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button16.Location = new System.Drawing.Point(539, 407);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(96, 84);
            this.button16.TabIndex = 0;
            this.button16.Text = "MASA : 16";
            this.button16.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.button8_Click);
            // 
            // button2
            // 
            this.button2.ContextMenuStrip = this.contextMenuStrip1;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::WindowsFormsApp1.Properties.Resources._19702157991557740339_64;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.Location = new System.Drawing.Point(641, 407);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 84);
            this.button2.TabIndex = 0;
            this.button2.Text = "MASA : 17";
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button8_Click);
            // 
            // button19
            // 
            this.button19.ContextMenuStrip = this.contextMenuStrip1;
            this.button19.FlatAppearance.BorderSize = 0;
            this.button19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button19.Image = global::WindowsFormsApp1.Properties.Resources._19702157991557740339_64;
            this.button19.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button19.Location = new System.Drawing.Point(743, 407);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(96, 84);
            this.button19.TabIndex = 0;
            this.button19.Text = "MASA : 18";
            this.button19.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button19.UseVisualStyleBackColor = false;
            this.button19.Click += new System.EventHandler(this.button8_Click);
            // 
            // button18
            // 
            this.button18.ContextMenuStrip = this.contextMenuStrip1;
            this.button18.FlatAppearance.BorderSize = 0;
            this.button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button18.Image = global::WindowsFormsApp1.Properties.Resources._19702157991557740339_64;
            this.button18.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button18.Location = new System.Drawing.Point(845, 407);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(96, 84);
            this.button18.TabIndex = 0;
            this.button18.Text = "MASA : 19";
            this.button18.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.button8_Click);
            // 
            // button20
            // 
            this.button20.ContextMenuStrip = this.contextMenuStrip1;
            this.button20.FlatAppearance.BorderSize = 0;
            this.button20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button20.Image = global::WindowsFormsApp1.Properties.Resources._19702157991557740339_64;
            this.button20.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button20.Location = new System.Drawing.Point(947, 407);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(96, 84);
            this.button20.TabIndex = 0;
            this.button20.Text = "MASA : 20";
            this.button20.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button20.UseVisualStyleBackColor = false;
            this.button20.Click += new System.EventHandler(this.button8_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "19702157991557740339-128.png");
            this.ımageList1.Images.SetKeyName(1, "19702157991557740339-64.png");
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(15, 207);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(912, 182);
            this.dataGridView2.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(947, 130);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(96, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(955, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Boş Masalar";
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(933, 295);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(152, 86);
            this.button21.TabIndex = 7;
            this.button21.Text = "Masayı Aç";
            this.button21.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton8);
            this.panel1.Controls.Add(this.radioButton7);
            this.panel1.Controls.Add(this.radioButton6);
            this.panel1.Controls.Add(this.radioButton5);
            this.panel1.Controls.Add(this.radioButton4);
            this.panel1.Controls.Add(this.radioButton3);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Location = new System.Drawing.Point(933, 157);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(152, 132);
            this.panel1.TabIndex = 8;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(72, 72);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(56, 17);
            this.radioButton8.TabIndex = 0;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "3 Saat";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(72, 49);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(71, 17);
            this.radioButton7.TabIndex = 0;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "1.30 Saat";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(72, 26);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(74, 17);
            this.radioButton6.TabIndex = 0;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "40 Dakika";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(72, 3);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(74, 17);
            this.radioButton5.TabIndex = 0;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "20 Dakika";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged_1);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(3, 72);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(56, 17);
            this.radioButton4.TabIndex = 0;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "2 Saat";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(3, 49);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(56, 17);
            this.radioButton3.TabIndex = 0;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "1 Saat";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(3, 26);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(74, 17);
            this.radioButton2.TabIndex = 0;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "30 Dakika";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(4, 3);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(59, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Süresiz";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.ContextMenuStrip = this.contextMenuStrip1;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::WindowsFormsApp1.Properties.Resources._19702157991557740339_64;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.Location = new System.Drawing.Point(29, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 83);
            this.button1.TabIndex = 0;
            this.button1.Text = "MASA : 1";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.İstekID,
            this.MasaID,
            this.Masa,
            this.İstekTuru,
            this.Aciklama,
            this.Tarih});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(29, 103);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(902, 97);
            this.listView1.TabIndex = 9;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // İstekID
            // 
            this.İstekID.Text = "İstekID";
            this.İstekID.Width = 137;
            // 
            // MasaID
            // 
            this.MasaID.Text = "MasaID";
            this.MasaID.Width = 146;
            // 
            // Masa
            // 
            this.Masa.Text = "Masa";
            this.Masa.Width = 133;
            // 
            // İstekTuru
            // 
            this.İstekTuru.Text = "İstekTuru";
            this.İstekTuru.Width = 166;
            // 
            // Aciklama
            // 
            this.Aciklama.Text = "Aciklama";
            this.Aciklama.Width = 148;
            // 
            // Tarih
            // 
            this.Tarih.Text = "Tarih";
            this.Tarih.Width = 152;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 499);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader İstekID;
        private System.Windows.Forms.ColumnHeader MasaID;
        private System.Windows.Forms.ColumnHeader Masa;
        private System.Windows.Forms.ColumnHeader İstekTuru;
        private System.Windows.Forms.ColumnHeader Aciklama;
        private System.Windows.Forms.ColumnHeader Tarih;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem yöneticiyiÇağırToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem süresizMasaAçmaİsteğiGönderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem süreliMasaAçmaİsteğiGönderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dakşkaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dakikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem daToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saatToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saatToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem saatToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem masaToolStripMenuItem;
    }
}

