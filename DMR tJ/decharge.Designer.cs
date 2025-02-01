
namespace DMR_tJ
{
    partial class decharge
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dateDecharge = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.villeDecharge = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.iceDecharge = new System.Windows.Forms.TextBox();
            this.perioDecharge = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.designDecharge = new System.Windows.Forms.TextBox();
            this.objDecharge = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.forDecharge = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.denDecharge = new System.Windows.Forms.TextBox();
            this.Enregistrer = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.siegExpiditeur = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.forExpiditeur = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.denExpiditeur = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cnssExpiditeur = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.iceExpiditeur = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.rcExpiditeur = new System.Windows.Forms.TextBox();
            this.tpExpiditeur = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.ifExpiditeur = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(67)))), ((int)(((byte)(124)))));
            this.label1.Location = new System.Drawing.Point(954, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 105;
            this.label1.Text = "Décharge";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(67)))), ((int)(((byte)(124)))));
            this.button1.Location = new System.Drawing.Point(1040, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 32);
            this.button1.TabIndex = 106;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 34;
            this.label3.Text = "Date";
            this.label3.UseWaitCursor = true;
            // 
            // dateDecharge
            // 
            this.dateDecharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateDecharge.Location = new System.Drawing.Point(6, 105);
            this.dateDecharge.Name = "dateDecharge";
            this.dateDecharge.Size = new System.Drawing.Size(220, 22);
            this.dateDecharge.TabIndex = 2;
            this.dateDecharge.UseWaitCursor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.villeDecharge);
            this.groupBox3.Controls.Add(this.dateDecharge);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(91, 80);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(905, 139);
            this.groupBox3.TabIndex = 107;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "VILLE ET DATE";
            this.groupBox3.UseWaitCursor = true;
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // villeDecharge
            // 
            this.villeDecharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.villeDecharge.FormattingEnabled = true;
            this.villeDecharge.Items.AddRange(new object[] {
            "Casablanca",
            "Rabat",
            "Fes",
            "Salé",
            "Marrakech",
            "Agadir",
            "Tangier",
            "Meknes",
            "Oujda",
            "Kenitra",
            "Tetouan",
            "Safi",
            "Mohammedia",
            "Khouribga",
            "Beni Mellal",
            "El Jadida",
            "Taza",
            "Nador",
            "Settat",
            "Larache",
            "Ksar El Kebir",
            "Khemisset",
            "Guelmim",
            "Berrechid",
            "Oued Zem",
            "Al Fqih Ben Salah",
            "Taourirt",
            "Berkane",
            "Sidi Slimane",
            "Sidi Qacem",
            "Khenifra",
            "Taroudant",
            "Essaouira",
            "Tiflet",
            "Oulad Teima",
            "Sefrou",
            "Youssoufia",
            "Tan-Tan",
            "Ouazzane",
            "Guercif",
            "Ouarzazate",
            "Tirhanimine",
            "Tiznit",
            "Azrou",
            "Midelt",
            "Skhirat",
            "Souq Larb\'a al Gharb",
            "Jerada",
            "Kasba Tadla",
            "Sidi Bennour",
            "Martil",
            "Azemmour",
            "Tinghir",
            "Chefchaouene",
            "El Aïoun",
            "Zagora",
            "Taounate",
            "Sidi Yahia El Gharb",
            "Zaio",
            "Asilah",
            "El Hajeb",
            "Mechraa Bel Ksiri",
            "Bouznika",
            "Tahla",
            "Arfoud",
            "Setti Fatma",
            "Recani",
            "Sidi Ifni",
            "Ahfir",
            "Oulmes",
            "Bni Bouayach",
            "Ain Beni Mathar",
            "Boujniba",
            "Kelaat Mgouna",
            "Ifrane",
            "Zawyat an Nwacer",
            "Figuig (Centre)",
            "Targuist",
            "Imzouren",
            "Skoura",
            "Tamaris",
            "Bouarfa",
            "Aït Melloul",
            "Fnidek",
            "Tifnit",
            "Driouch",
            "Ben Ahmed",
            "Guercif",
            "Sidi Kacem",
            "Sidi Slimane",
            "Taza",
            "Oulad Teima",
            "Khouribga",
            "Beni Mellal",
            "Azrou",
            "Midelt",
            "Zagora",
            "Taounate",
            "Imzouren",
            "Skhirat"});
            this.villeDecharge.Location = new System.Drawing.Point(6, 59);
            this.villeDecharge.Name = "villeDecharge";
            this.villeDecharge.Size = new System.Drawing.Size(220, 24);
            this.villeDecharge.TabIndex = 1;
            this.villeDecharge.UseWaitCursor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 16);
            this.label9.TabIndex = 29;
            this.label9.Text = "Ville ";
            this.label9.UseWaitCursor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(455, 40);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 16);
            this.label12.TabIndex = 36;
            this.label12.Text = "N° ICE";
            this.label12.UseWaitCursor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.iceDecharge);
            this.groupBox2.Controls.Add(this.perioDecharge);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.designDecharge);
            this.groupBox2.Controls.Add(this.objDecharge);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.forDecharge);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.denDecharge);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(91, 370);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(905, 139);
            this.groupBox2.TabIndex = 108;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "INFO DESTINATAIRE";
            this.groupBox2.UseWaitCursor = true;
            // 
            // iceDecharge
            // 
            this.iceDecharge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.iceDecharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iceDecharge.Location = new System.Drawing.Point(458, 59);
            this.iceDecharge.Name = "iceDecharge";
            this.iceDecharge.Size = new System.Drawing.Size(180, 22);
            this.iceDecharge.TabIndex = 5;
            this.iceDecharge.UseWaitCursor = true;
            // 
            // perioDecharge
            // 
            this.perioDecharge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.perioDecharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.perioDecharge.Location = new System.Drawing.Point(668, 103);
            this.perioDecharge.Name = "perioDecharge";
            this.perioDecharge.Size = new System.Drawing.Size(230, 22);
            this.perioDecharge.TabIndex = 8;
            this.perioDecharge.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(665, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 58;
            this.label2.Text = "Période";
            this.label2.UseWaitCursor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(229, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 16);
            this.label5.TabIndex = 51;
            this.label5.Text = "Détaille de document";
            this.label5.UseWaitCursor = true;
            // 
            // designDecharge
            // 
            this.designDecharge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.designDecharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.designDecharge.Location = new System.Drawing.Point(232, 103);
            this.designDecharge.Name = "designDecharge";
            this.designDecharge.Size = new System.Drawing.Size(430, 22);
            this.designDecharge.TabIndex = 7;
            this.designDecharge.UseWaitCursor = true;
            // 
            // objDecharge
            // 
            this.objDecharge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.objDecharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.objDecharge.Location = new System.Drawing.Point(6, 103);
            this.objDecharge.Name = "objDecharge";
            this.objDecharge.Size = new System.Drawing.Size(220, 22);
            this.objDecharge.TabIndex = 6;
            this.objDecharge.UseWaitCursor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 16);
            this.label6.TabIndex = 57;
            this.label6.Text = "Type de document";
            this.label6.UseWaitCursor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 16);
            this.label7.TabIndex = 50;
            this.label7.Text = "Dénomination";
            this.label7.UseWaitCursor = true;
            // 
            // forDecharge
            // 
            this.forDecharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forDecharge.FormattingEnabled = true;
            this.forDecharge.Items.AddRange(new object[] {
            "SARL . AU",
            "SARL"});
            this.forDecharge.Location = new System.Drawing.Point(232, 57);
            this.forDecharge.Name = "forDecharge";
            this.forDecharge.Size = new System.Drawing.Size(220, 24);
            this.forDecharge.TabIndex = 4;
            this.forDecharge.UseWaitCursor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(229, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 16);
            this.label8.TabIndex = 54;
            this.label8.Text = "Forme juridique";
            this.label8.UseWaitCursor = true;
            // 
            // denDecharge
            // 
            this.denDecharge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.denDecharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.denDecharge.Location = new System.Drawing.Point(6, 59);
            this.denDecharge.Name = "denDecharge";
            this.denDecharge.Size = new System.Drawing.Size(220, 22);
            this.denDecharge.TabIndex = 3;
            this.denDecharge.UseWaitCursor = true;
            // 
            // Enregistrer
            // 
            this.Enregistrer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(67)))), ((int)(((byte)(124)))));
            this.Enregistrer.FlatAppearance.BorderSize = 0;
            this.Enregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Enregistrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enregistrer.ForeColor = System.Drawing.Color.White;
            this.Enregistrer.Location = new System.Drawing.Point(891, 515);
            this.Enregistrer.Name = "Enregistrer";
            this.Enregistrer.Size = new System.Drawing.Size(105, 28);
            this.Enregistrer.TabIndex = 109;
            this.Enregistrer.Text = "Enregistrer";
            this.Enregistrer.UseVisualStyleBackColor = false;
            this.Enregistrer.UseWaitCursor = true;
            this.Enregistrer.Click += new System.EventHandler(this.Enregistrer_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.siegExpiditeur);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.forExpiditeur);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.denExpiditeur);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cnssExpiditeur);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.iceExpiditeur);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.rcExpiditeur);
            this.groupBox1.Controls.Add(this.tpExpiditeur);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.ifExpiditeur);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(91, 225);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(905, 139);
            this.groupBox1.TabIndex = 114;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "INFO EXPEDITEUR";
            this.groupBox1.UseWaitCursor = true;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // siegExpiditeur
            // 
            this.siegExpiditeur.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.siegExpiditeur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siegExpiditeur.Location = new System.Drawing.Point(458, 60);
            this.siegExpiditeur.Name = "siegExpiditeur";
            this.siegExpiditeur.Size = new System.Drawing.Size(440, 22);
            this.siegExpiditeur.TabIndex = 11;
            this.siegExpiditeur.UseWaitCursor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(455, 41);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(95, 16);
            this.label17.TabIndex = 60;
            this.label17.Text = "Siège social";
            this.label17.UseWaitCursor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(3, 41);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(103, 16);
            this.label14.TabIndex = 56;
            this.label14.Text = "Dénomination";
            this.label14.UseWaitCursor = true;
            // 
            // forExpiditeur
            // 
            this.forExpiditeur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forExpiditeur.FormattingEnabled = true;
            this.forExpiditeur.Items.AddRange(new object[] {
            "SARL . AU",
            "SARL"});
            this.forExpiditeur.Location = new System.Drawing.Point(232, 58);
            this.forExpiditeur.Name = "forExpiditeur";
            this.forExpiditeur.Size = new System.Drawing.Size(220, 24);
            this.forExpiditeur.TabIndex = 10;
            this.forExpiditeur.UseWaitCursor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(229, 40);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(116, 16);
            this.label16.TabIndex = 58;
            this.label16.Text = "Forme juridique";
            this.label16.UseWaitCursor = true;
            // 
            // denExpiditeur
            // 
            this.denExpiditeur.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.denExpiditeur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.denExpiditeur.Location = new System.Drawing.Point(6, 60);
            this.denExpiditeur.Name = "denExpiditeur";
            this.denExpiditeur.Size = new System.Drawing.Size(220, 22);
            this.denExpiditeur.TabIndex = 9;
            this.denExpiditeur.UseWaitCursor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(723, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 34;
            this.label4.Text = "N° CNSS";
            this.label4.UseWaitCursor = true;
            // 
            // cnssExpiditeur
            // 
            this.cnssExpiditeur.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cnssExpiditeur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cnssExpiditeur.Location = new System.Drawing.Point(726, 104);
            this.cnssExpiditeur.Name = "cnssExpiditeur";
            this.cnssExpiditeur.Size = new System.Drawing.Size(172, 22);
            this.cnssExpiditeur.TabIndex = 16;
            this.cnssExpiditeur.UseWaitCursor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(3, 85);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 16);
            this.label15.TabIndex = 33;
            this.label15.Text = "N° ICE";
            this.label15.UseWaitCursor = true;
            // 
            // iceExpiditeur
            // 
            this.iceExpiditeur.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.iceExpiditeur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iceExpiditeur.Location = new System.Drawing.Point(6, 104);
            this.iceExpiditeur.Name = "iceExpiditeur";
            this.iceExpiditeur.Size = new System.Drawing.Size(180, 22);
            this.iceExpiditeur.TabIndex = 12;
            this.iceExpiditeur.UseWaitCursor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(561, 85);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 16);
            this.label10.TabIndex = 35;
            this.label10.Text = "N° RC";
            this.label10.UseWaitCursor = true;
            // 
            // rcExpiditeur
            // 
            this.rcExpiditeur.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rcExpiditeur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rcExpiditeur.Location = new System.Drawing.Point(548, 104);
            this.rcExpiditeur.Name = "rcExpiditeur";
            this.rcExpiditeur.Size = new System.Drawing.Size(172, 22);
            this.rcExpiditeur.TabIndex = 15;
            this.rcExpiditeur.UseWaitCursor = true;
            // 
            // tpExpiditeur
            // 
            this.tpExpiditeur.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpExpiditeur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpExpiditeur.Location = new System.Drawing.Point(192, 104);
            this.tpExpiditeur.Name = "tpExpiditeur";
            this.tpExpiditeur.Size = new System.Drawing.Size(172, 22);
            this.tpExpiditeur.TabIndex = 13;
            this.tpExpiditeur.UseWaitCursor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(375, 86);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 16);
            this.label11.TabIndex = 32;
            this.label11.Text = "N° IF";
            this.label11.UseWaitCursor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(189, 85);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 16);
            this.label13.TabIndex = 30;
            this.label13.Text = "N° TP";
            this.label13.UseWaitCursor = true;
            // 
            // ifExpiditeur
            // 
            this.ifExpiditeur.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ifExpiditeur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ifExpiditeur.Location = new System.Drawing.Point(370, 104);
            this.ifExpiditeur.Name = "ifExpiditeur";
            this.ifExpiditeur.Size = new System.Drawing.Size(172, 22);
            this.ifExpiditeur.TabIndex = 14;
            this.ifExpiditeur.UseWaitCursor = true;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(161)))), ((int)(((byte)(163)))));
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(1083, 0);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(5, 705);
            this.flowLayoutPanel4.TabIndex = 115;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(161)))), ((int)(((byte)(163)))));
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 700);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1083, 5);
            this.flowLayoutPanel1.TabIndex = 116;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(161)))), ((int)(((byte)(163)))));
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(5, 700);
            this.flowLayoutPanel3.TabIndex = 117;
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(161)))), ((int)(((byte)(163)))));
            this.flowLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel5.Location = new System.Drawing.Point(5, 0);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(1078, 5);
            this.flowLayoutPanel5.TabIndex = 118;
            // 
            // decharge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 705);
            this.Controls.Add(this.flowLayoutPanel5);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.flowLayoutPanel4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.Enregistrer);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "decharge";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "decharge";
            this.Load += new System.EventHandler(this.decharge_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateDecharge;
        private System.Windows.Forms.ComboBox villeDecharge;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox perioDecharge;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox designDecharge;
        private System.Windows.Forms.TextBox objDecharge;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox forDecharge;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox denDecharge;
        private System.Windows.Forms.TextBox iceDecharge;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Enregistrer;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox cnssExpiditeur;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox iceExpiditeur;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox rcExpiditeur;
        private System.Windows.Forms.TextBox tpExpiditeur;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox ifExpiditeur;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox forExpiditeur;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox denExpiditeur;
        private System.Windows.Forms.TextBox siegExpiditeur;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
    }
}