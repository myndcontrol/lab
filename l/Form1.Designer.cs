namespace l
{
    partial class LAB
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.start = new System.Windows.Forms.ToolStripMenuItem();
            this.addCharacterTab = new System.Windows.Forms.TabControl();
            this.addWarriorPage = new System.Windows.Forms.TabPage();
            this.wdmgbox = new System.Windows.Forms.TextBox();
            this.wregenbox = new System.Windows.Forms.TextBox();
            this.wmaxHPbox = new System.Windows.Forms.TextBox();
            this.wnamebox = new System.Windows.Forms.TextBox();
            this.addWarrior = new System.Windows.Forms.Button();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addHealerPage = new System.Windows.Forms.TabPage();
            this.hpowerbox = new System.Windows.Forms.TextBox();
            this.hdmgbox = new System.Windows.Forms.TextBox();
            this.hregenBox = new System.Windows.Forms.TextBox();
            this.hmaxHPbox = new System.Windows.Forms.TextBox();
            this.hnamebox = new System.Windows.Forms.TextBox();
            this.addHealer = new System.Windows.Forms.Button();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.processPanel = new System.Windows.Forms.Panel();
            this.tTable = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTable = new System.Windows.Forms.DataGridView();
            this.targets = new System.Windows.Forms.ComboBox();
            this.actions = new System.Windows.Forms.ComboBox();
            this.endTurn = new System.Windows.Forms.Button();
            this.targetInfoLabel = new System.Windows.Forms.Label();
            this.chooseTargetLabel = new System.Windows.Forms.Label();
            this.chooseActionLabel = new System.Windows.Forms.Label();
            this.cCharacter = new System.Windows.Forms.Label();
            this.winnerLabel = new System.Windows.Forms.Label();
            this.qLabel = new System.Windows.Forms.Label();
            this.turnLabel = new System.Windows.Forms.Label();
            this.warningLabel = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxHP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dmg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.healP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.addCharacterTab.SuspendLayout();
            this.addWarriorPage.SuspendLayout();
            this.addHealerPage.SuspendLayout();
            this.processPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTable)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.start});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MaximumSize = new System.Drawing.Size(645, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(624, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.Color.LightBlue;
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(58, 20);
            this.start.Text = "Начать";
            this.start.Click += new System.EventHandler(this.start_click);
            // 
            // addCharacterTab
            // 
            this.addCharacterTab.Controls.Add(this.addWarriorPage);
            this.addCharacterTab.Controls.Add(this.addHealerPage);
            this.addCharacterTab.Location = new System.Drawing.Point(5, 429);
            this.addCharacterTab.Name = "addCharacterTab";
            this.addCharacterTab.SelectedIndex = 0;
            this.addCharacterTab.Size = new System.Drawing.Size(644, 468);
            this.addCharacterTab.TabIndex = 0;
            // 
            // addWarriorPage
            // 
            this.addWarriorPage.Controls.Add(this.wdmgbox);
            this.addWarriorPage.Controls.Add(this.wregenbox);
            this.addWarriorPage.Controls.Add(this.wmaxHPbox);
            this.addWarriorPage.Controls.Add(this.wnamebox);
            this.addWarriorPage.Controls.Add(this.addWarrior);
            this.addWarriorPage.Controls.Add(this.radioButton2);
            this.addWarriorPage.Controls.Add(this.radioButton1);
            this.addWarriorPage.Controls.Add(this.label5);
            this.addWarriorPage.Controls.Add(this.label4);
            this.addWarriorPage.Controls.Add(this.label3);
            this.addWarriorPage.Controls.Add(this.label2);
            this.addWarriorPage.Controls.Add(this.label1);
            this.addWarriorPage.Location = new System.Drawing.Point(4, 22);
            this.addWarriorPage.Name = "addWarriorPage";
            this.addWarriorPage.Padding = new System.Windows.Forms.Padding(3);
            this.addWarriorPage.Size = new System.Drawing.Size(636, 442);
            this.addWarriorPage.TabIndex = 0;
            this.addWarriorPage.Text = "Добавить воина";
            this.addWarriorPage.UseVisualStyleBackColor = true;
            // 
            // wdmgbox
            // 
            this.wdmgbox.Location = new System.Drawing.Point(313, 230);
            this.wdmgbox.Name = "wdmgbox";
            this.wdmgbox.Size = new System.Drawing.Size(287, 20);
            this.wdmgbox.TabIndex = 3;
            this.wdmgbox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.wdmgbox_click);
            // 
            // wregenbox
            // 
            this.wregenbox.Location = new System.Drawing.Point(313, 157);
            this.wregenbox.Name = "wregenbox";
            this.wregenbox.Size = new System.Drawing.Size(287, 20);
            this.wregenbox.TabIndex = 3;
            this.wregenbox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.wregenbox_click);
            // 
            // wmaxHPbox
            // 
            this.wmaxHPbox.Location = new System.Drawing.Point(313, 89);
            this.wmaxHPbox.Name = "wmaxHPbox";
            this.wmaxHPbox.Size = new System.Drawing.Size(287, 20);
            this.wmaxHPbox.TabIndex = 3;
            this.wmaxHPbox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.wmaxHPbox_click);
            // 
            // wnamebox
            // 
            this.wnamebox.Location = new System.Drawing.Point(313, 26);
            this.wnamebox.Name = "wnamebox";
            this.wnamebox.Size = new System.Drawing.Size(287, 20);
            this.wnamebox.TabIndex = 3;
            this.wnamebox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.wnamebox_click);
            // 
            // addWarrior
            // 
            this.addWarrior.Location = new System.Drawing.Point(438, 292);
            this.addWarrior.Name = "addWarrior";
            this.addWarrior.Size = new System.Drawing.Size(162, 43);
            this.addWarrior.TabIndex = 2;
            this.addWarrior.Text = "Добавить";
            this.addWarrior.UseVisualStyleBackColor = true;
            this.addWarrior.Click += new System.EventHandler(this.add_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(351, 306);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(31, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "2";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(220, 306);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(31, 17);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.Text = "1";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label5.Location = new System.Drawing.Point(11, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Выбор команды:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.Location = new System.Drawing.Point(11, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Урон:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(11, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(256, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Восстановление HP в ход:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(11, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Максимальное HP:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(11, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя:";
            // 
            // addHealerPage
            // 
            this.addHealerPage.Controls.Add(this.hpowerbox);
            this.addHealerPage.Controls.Add(this.hdmgbox);
            this.addHealerPage.Controls.Add(this.hregenBox);
            this.addHealerPage.Controls.Add(this.hmaxHPbox);
            this.addHealerPage.Controls.Add(this.hnamebox);
            this.addHealerPage.Controls.Add(this.addHealer);
            this.addHealerPage.Controls.Add(this.radioButton3);
            this.addHealerPage.Controls.Add(this.radioButton4);
            this.addHealerPage.Controls.Add(this.label6);
            this.addHealerPage.Controls.Add(this.label11);
            this.addHealerPage.Controls.Add(this.label7);
            this.addHealerPage.Controls.Add(this.label8);
            this.addHealerPage.Controls.Add(this.label9);
            this.addHealerPage.Controls.Add(this.label10);
            this.addHealerPage.Location = new System.Drawing.Point(4, 22);
            this.addHealerPage.Name = "addHealerPage";
            this.addHealerPage.Padding = new System.Windows.Forms.Padding(3);
            this.addHealerPage.Size = new System.Drawing.Size(636, 442);
            this.addHealerPage.TabIndex = 1;
            this.addHealerPage.Text = "Добавить целителя";
            this.addHealerPage.UseVisualStyleBackColor = true;
            // 
            // hpowerbox
            // 
            this.hpowerbox.Location = new System.Drawing.Point(313, 296);
            this.hpowerbox.Name = "hpowerbox";
            this.hpowerbox.Size = new System.Drawing.Size(287, 20);
            this.hpowerbox.TabIndex = 12;
            this.hpowerbox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.hpowerbox_click);
            // 
            // hdmgbox
            // 
            this.hdmgbox.Location = new System.Drawing.Point(313, 230);
            this.hdmgbox.Name = "hdmgbox";
            this.hdmgbox.Size = new System.Drawing.Size(287, 20);
            this.hdmgbox.TabIndex = 12;
            this.hdmgbox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.hdmgbox_click);
            // 
            // hregenBox
            // 
            this.hregenBox.Location = new System.Drawing.Point(313, 157);
            this.hregenBox.Name = "hregenBox";
            this.hregenBox.Size = new System.Drawing.Size(287, 20);
            this.hregenBox.TabIndex = 13;
            this.hregenBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.hregenbox_click);
            // 
            // hmaxHPbox
            // 
            this.hmaxHPbox.Location = new System.Drawing.Point(313, 89);
            this.hmaxHPbox.Name = "hmaxHPbox";
            this.hmaxHPbox.Size = new System.Drawing.Size(287, 20);
            this.hmaxHPbox.TabIndex = 14;
            this.hmaxHPbox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.hmaxHPbox_click);
            // 
            // hnamebox
            // 
            this.hnamebox.Location = new System.Drawing.Point(313, 27);
            this.hnamebox.Name = "hnamebox";
            this.hnamebox.Size = new System.Drawing.Size(287, 20);
            this.hnamebox.TabIndex = 15;
            this.hnamebox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.hnamebox_Click);
            // 
            // addHealer
            // 
            this.addHealer.Location = new System.Drawing.Point(438, 347);
            this.addHealer.Name = "addHealer";
            this.addHealer.Size = new System.Drawing.Size(162, 43);
            this.addHealer.TabIndex = 11;
            this.addHealer.Text = "Добавить";
            this.addHealer.UseVisualStyleBackColor = true;
            this.addHealer.Click += new System.EventHandler(this.addHealer_Click);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(364, 360);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(31, 17);
            this.radioButton3.TabIndex = 9;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "2";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(233, 360);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(31, 17);
            this.radioButton4.TabIndex = 10;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "1";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label6.Location = new System.Drawing.Point(13, 352);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "Выбор команды:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label11.Location = new System.Drawing.Point(11, 290);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(169, 25);
            this.label11.TabIndex = 5;
            this.label11.Text = "Сила исцеления:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label7.Location = new System.Drawing.Point(11, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 25);
            this.label7.TabIndex = 5;
            this.label7.Text = "Урон:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label8.Location = new System.Drawing.Point(11, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(256, 25);
            this.label8.TabIndex = 6;
            this.label8.Text = "Восстановление HP в ход:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label9.Location = new System.Drawing.Point(11, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(189, 25);
            this.label9.TabIndex = 7;
            this.label9.Text = "Максимальное HP:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label10.Location = new System.Drawing.Point(11, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 25);
            this.label10.TabIndex = 8;
            this.label10.Text = "Имя:";
            // 
            // processPanel
            // 
            this.processPanel.BackColor = System.Drawing.Color.Transparent;
            this.processPanel.Controls.Add(this.tTable);
            this.processPanel.Controls.Add(this.cTable);
            this.processPanel.Controls.Add(this.targets);
            this.processPanel.Controls.Add(this.actions);
            this.processPanel.Controls.Add(this.endTurn);
            this.processPanel.Controls.Add(this.targetInfoLabel);
            this.processPanel.Controls.Add(this.chooseTargetLabel);
            this.processPanel.Controls.Add(this.chooseActionLabel);
            this.processPanel.Controls.Add(this.cCharacter);
            this.processPanel.Controls.Add(this.winnerLabel);
            this.processPanel.Controls.Add(this.qLabel);
            this.processPanel.Controls.Add(this.turnLabel);
            this.processPanel.Enabled = false;
            this.processPanel.Location = new System.Drawing.Point(5, 27);
            this.processPanel.Name = "processPanel";
            this.processPanel.Size = new System.Drawing.Size(620, 396);
            this.processPanel.TabIndex = 2;
            this.processPanel.Visible = false;
            // 
            // tTable
            // 
            this.tTable.AllowUserToResizeColumns = false;
            this.tTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.tTable.Location = new System.Drawing.Point(-41, 315);
            this.tTable.Name = "tTable";
            this.tTable.Size = new System.Drawing.Size(643, 44);
            this.tTable.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Имя";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Макс HP";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "HP";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "DMG";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Регенерация";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Исцеление";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // cTable
            // 
            this.cTable.AllowUserToResizeColumns = false;
            this.cTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.maxHP,
            this.hp,
            this.dmg,
            this.regen,
            this.healP});
            this.cTable.Location = new System.Drawing.Point(-41, 108);
            this.cTable.Name = "cTable";
            this.cTable.Size = new System.Drawing.Size(643, 44);
            this.cTable.TabIndex = 3;
            // 
            // targets
            // 
            this.targets.FormattingEnabled = true;
            this.targets.Location = new System.Drawing.Point(470, 224);
            this.targets.Name = "targets";
            this.targets.Size = new System.Drawing.Size(132, 21);
            this.targets.TabIndex = 2;
            this.targets.SelectedIndexChanged += new System.EventHandler(this.targets_SelectedIndexChanged);
            // 
            // actions
            // 
            this.actions.FormattingEnabled = true;
            this.actions.Location = new System.Drawing.Point(11, 224);
            this.actions.Name = "actions";
            this.actions.Size = new System.Drawing.Size(132, 21);
            this.actions.TabIndex = 2;
            this.actions.SelectedIndexChanged += new System.EventHandler(this.actions_SelectedIndexChanged);
            // 
            // endTurn
            // 
            this.endTurn.Location = new System.Drawing.Point(470, 258);
            this.endTurn.Name = "endTurn";
            this.endTurn.Size = new System.Drawing.Size(132, 40);
            this.endTurn.TabIndex = 1;
            this.endTurn.Text = "Завершить ход";
            this.endTurn.UseVisualStyleBackColor = true;
            this.endTurn.Click += new System.EventHandler(this.endTurn_Click);
            // 
            // targetInfoLabel
            // 
            this.targetInfoLabel.AutoSize = true;
            this.targetInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.targetInfoLabel.Location = new System.Drawing.Point(3, 270);
            this.targetInfoLabel.Name = "targetInfoLabel";
            this.targetInfoLabel.Size = new System.Drawing.Size(223, 17);
            this.targetInfoLabel.TabIndex = 0;
            this.targetInfoLabel.Text = "Информация о выбранной цели:";
            // 
            // chooseTargetLabel
            // 
            this.chooseTargetLabel.AutoSize = true;
            this.chooseTargetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.chooseTargetLabel.Location = new System.Drawing.Point(491, 195);
            this.chooseTargetLabel.Name = "chooseTargetLabel";
            this.chooseTargetLabel.Size = new System.Drawing.Size(91, 17);
            this.chooseTargetLabel.TabIndex = 0;
            this.chooseTargetLabel.Text = "Выбор цели:";
            // 
            // chooseActionLabel
            // 
            this.chooseActionLabel.AutoSize = true;
            this.chooseActionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.chooseActionLabel.Location = new System.Drawing.Point(13, 195);
            this.chooseActionLabel.Name = "chooseActionLabel";
            this.chooseActionLabel.Size = new System.Drawing.Size(120, 17);
            this.chooseActionLabel.TabIndex = 0;
            this.chooseActionLabel.Text = "Выбор действия:";
            // 
            // cCharacter
            // 
            this.cCharacter.AutoSize = true;
            this.cCharacter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cCharacter.Location = new System.Drawing.Point(3, 69);
            this.cCharacter.Name = "cCharacter";
            this.cCharacter.Size = new System.Drawing.Size(140, 17);
            this.cCharacter.TabIndex = 0;
            this.cCharacter.Text = "Ходящий персонаж:";
            // 
            // winnerLabel
            // 
            this.winnerLabel.AutoSize = true;
            this.winnerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.winnerLabel.Location = new System.Drawing.Point(352, 5);
            this.winnerLabel.Name = "winnerLabel";
            this.winnerLabel.Size = new System.Drawing.Size(49, 17);
            this.winnerLabel.TabIndex = 0;
            this.winnerLabel.Text = "winner";
            this.winnerLabel.Visible = false;
            // 
            // qLabel
            // 
            this.qLabel.AutoSize = true;
            this.qLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.qLabel.Location = new System.Drawing.Point(159, 5);
            this.qLabel.Name = "qLabel";
            this.qLabel.Size = new System.Drawing.Size(154, 17);
            this.qLabel.TabIndex = 0;
            this.qLabel.Text = "Очередь команды №1";
            // 
            // turnLabel
            // 
            this.turnLabel.AutoSize = true;
            this.turnLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.turnLabel.Location = new System.Drawing.Point(3, 5);
            this.turnLabel.Name = "turnLabel";
            this.turnLabel.Size = new System.Drawing.Size(37, 17);
            this.turnLabel.TabIndex = 0;
            this.turnLabel.Text = "Ход:";
            // 
            // warningLabel
            // 
            this.warningLabel.AutoSize = true;
            this.warningLabel.Location = new System.Drawing.Point(73, 6);
            this.warningLabel.Name = "warningLabel";
            this.warningLabel.Size = new System.Drawing.Size(176, 13);
            this.warningLabel.TabIndex = 3;
            this.warningLabel.Text = "Необходимо больше персонажей";
            this.warningLabel.Visible = false;
            // 
            // name
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.name.DefaultCellStyle = dataGridViewCellStyle1;
            this.name.HeaderText = "Имя";
            this.name.Name = "name";
            // 
            // maxHP
            // 
            this.maxHP.HeaderText = "Макс HP";
            this.maxHP.Name = "maxHP";
            // 
            // hp
            // 
            this.hp.HeaderText = "HP";
            this.hp.Name = "hp";
            // 
            // dmg
            // 
            this.dmg.HeaderText = "DMG";
            this.dmg.Name = "dmg";
            // 
            // regen
            // 
            this.regen.HeaderText = "Регенерация";
            this.regen.Name = "regen";
            // 
            // healP
            // 
            this.healP.HeaderText = "Исцеление";
            this.healP.Name = "healP";
            // 
            // LAB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.warningLabel);
            this.Controls.Add(this.processPanel);
            this.Controls.Add(this.addCharacterTab);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(640, 480);
            this.Name = "LAB";
            this.Text = "lab №1, 2";
            this.Load += new System.EventHandler(this.LAB_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.addCharacterTab.ResumeLayout(false);
            this.addWarriorPage.ResumeLayout(false);
            this.addWarriorPage.PerformLayout();
            this.addHealerPage.ResumeLayout(false);
            this.addHealerPage.PerformLayout();
            this.processPanel.ResumeLayout(false);
            this.processPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem start;
        private System.Windows.Forms.TabControl addCharacterTab;
        private System.Windows.Forms.TabPage addWarriorPage;
        private System.Windows.Forms.TextBox wdmgbox;
        private System.Windows.Forms.TextBox wregenbox;
        private System.Windows.Forms.TextBox wmaxHPbox;
        private System.Windows.Forms.TextBox wnamebox;
        private System.Windows.Forms.Button addWarrior;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage addHealerPage;
        private System.Windows.Forms.TextBox hpowerbox;
        private System.Windows.Forms.TextBox hdmgbox;
        private System.Windows.Forms.TextBox hregenBox;
        private System.Windows.Forms.TextBox hmaxHPbox;
        private System.Windows.Forms.TextBox hnamebox;
        private System.Windows.Forms.Button addHealer;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel processPanel;
        private System.Windows.Forms.Label warningLabel;
        private System.Windows.Forms.Label qLabel;
        private System.Windows.Forms.Label turnLabel;
        private System.Windows.Forms.DataGridView cTable;
        private System.Windows.Forms.ComboBox targets;
        private System.Windows.Forms.ComboBox actions;
        private System.Windows.Forms.Button endTurn;
        private System.Windows.Forms.Label targetInfoLabel;
        private System.Windows.Forms.Label chooseTargetLabel;
        private System.Windows.Forms.Label chooseActionLabel;
        private System.Windows.Forms.Label cCharacter;
        private System.Windows.Forms.DataGridView tTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Label winnerLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxHP;
        private System.Windows.Forms.DataGridViewTextBoxColumn hp;
        private System.Windows.Forms.DataGridViewTextBoxColumn dmg;
        private System.Windows.Forms.DataGridViewTextBoxColumn regen;
        private System.Windows.Forms.DataGridViewTextBoxColumn healP;
    }
}

