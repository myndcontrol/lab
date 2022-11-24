using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace l
{
    public partial class LAB : Form
    {
        private List<character> team1 = new List<character>();
        private List<character> team2 = new List<character>();
        private int team1_counter = 0;
        private int team2_counter = 0;
        private int turn = 1;
        public LAB()
        {
            InitializeComponent();
        }

        
        private void add_Click(object sender, EventArgs e)
        {           
            if (wnamebox.Text != "" && !wmaxHPbox.Text.Contains('-')
                && wmaxHPbox.Text != "" && wmaxHPbox.Text != "0" && wmaxHPbox.Text[0] != '0' && !wregenbox.Text.Contains('-') 
                && wregenbox.Text != "" && wregenbox.Text != "0" && wregenbox.Text[0] != '0' && !wdmgbox.Text.Contains('-')
                && wdmgbox.Text != "" && wdmgbox.Text != "0" && wdmgbox.Text[0] != '0')
            {
                character newCharacter = new character();
                newCharacter.Name = wnamebox.Text;
                newCharacter.maxHP = Convert.ToInt32(wmaxHPbox.Text);
                newCharacter.HP = newCharacter.maxHP;
                newCharacter.regenHP = Convert.ToInt32(wregenbox.Text);
                newCharacter.Damage = Convert.ToInt32(wdmgbox.Text);
                newCharacter.Type = false;
                if (radioButton1.Checked)
                {
                    team1.Add(newCharacter);
                    addWarrior.Text = "Успешно";

                }
                    
                else if (radioButton2.Checked)
                {
                    team2.Add(newCharacter);
                    addWarrior.Text = "Успешно";
                }                  
                else
                    addWarrior.Text = "Выберите команду";
            }
            else
                addWarrior.Text = "Заполните все данные корректно";
        }

        private void addHealer_Click(object sender, EventArgs e)
        {
            if (hnamebox.Text != "0" && hnamebox.Text != "" && hmaxHPbox.Text != "0" && hmaxHPbox.Text != "" && hmaxHPbox.Text[0] != '0'
                && !hmaxHPbox.Text.Contains('-') && hdmgbox.Text != "0" && hdmgbox.Text != "" && hdmgbox.Text[0] != '0'
                && !hdmgbox.Text.Contains('-') && hregenBox.Text != "0" && hregenBox.Text != "" && hregenBox.Text[0] != '0'
                && !hregenBox.Text.Contains('-') && hpowerbox.Text != "0" && hpowerbox.Text != "" && hpowerbox.Text[0] != '0'
                && !hpowerbox.Text.Contains('-'))
            {
                character newCharacter = new character();
                newCharacter.Name = hnamebox.Text;
                newCharacter.maxHP = Convert.ToInt32(hmaxHPbox.Text);
                newCharacter.HP = newCharacter.maxHP;
                newCharacter.Damage = Convert.ToInt32(hdmgbox.Text);
                newCharacter.regenHP = Convert.ToInt32(hregenBox.Text);
                newCharacter.HealP = Convert.ToInt32(hpowerbox.Text);
                newCharacter.Type = true;
                if (radioButton4.Checked)
                {
                    team1.Add(newCharacter);
                    addHealer.Text = "Успешно";
                }
                    
                else if (radioButton3.Checked)
                {
                    team2.Add(newCharacter);
                    addHealer.Text = "Успешно";
                }
                    
                else
                    addHealer.Text = "Выберите команду";
            }
            else
                addHealer.Text = "Заполните все данные корректно";
        }

        private void start_click(object sender, EventArgs e)
        {
            if (team1.Count() != 0 && team2.Count() != 0)
            {
                turnLabel.Text = "Ход: " + turn;
                addCharacterTab.Visible = false;
                addCharacterTab.Enabled = false;
                start.Enabled = false;
                processPanel.Visible = true;
                processPanel.Enabled = true;
                warningLabel.Visible = false;
                if (team1[0].Type == true)
                {
                    actions.Items.Clear();
                    actions.Items.Add("Атаковать");
                    actions.Items.Add("Исцелить");
                    cTable.Rows[0].Cells[5].Value = team1[0].HealP;
                }
                else
                {
                    actions.Items.Clear();
                    actions.Items.Add("Атаковать");
                    cTable.Rows[0].Cells[5].Value = "-";
                }
                if (actions.Text == "Исцелить")
                    for (int i = 0; i < team1.Count; i++)
                        targets.Items.Add(team1[i]);
                if (actions.Text == "Атаковать")
                    for (int i = 0; i < team2.Count; i++)
                        targets.Items.Add(team2[i]);

                cTable.Rows[0].Cells[0].Value = team1[0].Name;
                cTable.Rows[0].Cells[1].Value = team1[0].maxHP;
                cTable.Rows[0].Cells[2].Value = team1[0].HP;
                cTable.Rows[0].Cells[3].Value = team1[0].Damage;
                cTable.Rows[0].Cells[4].Value = team1[0].regenHP;
                cTable.Refresh();                  
            }
            else 
                warningLabel.Visible = true;
        }

        private void endTurn_Click(object sender, EventArgs e)
        {
            
            if (turn % 2 != 0)
            {
                
                actions.Items.Clear();
                if (team2.Count > 0)
                {
                    if (team2[team2_counter].Type == true)
                    {                      
                        actions.Items.Add("Атаковать");
                        actions.Items.Add("Исцелить");
                        cTable.Rows[0].Cells[5].Value = team1[team1_counter].HealP;
                        cTable.Refresh();
                        if (actions.Text == "Исцелить")
                        {
                            for (int i = 0; i < team1.Count; i++)
                                targets.Items.Add(team1[i]);
                            team1[team1_counter].heal(team1[targets.SelectedIndex]);
                        }                       
                        else if (actions.Text == "Атаковать")
                        {
                            for (int i = 0; i < team2.Count; i++)
                                targets.Items.Add(team2[i]);
                            team1[team1_counter].attack(team2[targets.SelectedIndex]);
                            tTable.Rows[0].Cells[2].Value = team2[targets.SelectedIndex].HP;
                            if (team2[targets.SelectedIndex].HP <= 0)
                                team2.RemoveAt(targets.SelectedIndex);
                        }
                    }
                    else
                    {
                        actions.Items.Clear();
                        actions.Items.Add("Атаковать");
                        if (actions.Text == "Исцелить")
                        {
                            for (int i = 0; i < team1.Count; i++)
                                targets.Items.Add(team1[i]);
                            team1[team1_counter].heal(team1[targets.SelectedIndex]);
                        }
                        if (actions.Text == "Атаковать")
                        {
                            for (int i = 0; i < team2.Count; i++)
                                targets.Items.Add(team2[i]);
                            team1[team1_counter].attack(team2[targets.SelectedIndex]);
                            tTable.Rows[0].Cells[2].Value = team1[targets.SelectedIndex].HP;
                            if (team2[targets.SelectedIndex].HP <= 0)
                            {
                                team2.RemoveAt(targets.SelectedIndex);
                            }
                        }
                    }
                    team1_counter++;
                    turn++;
                    turnLabel.Text = "Ход: " + turn;
                    if (team1_counter > team1.Count() - 1)
                        team1_counter--;
                    tTable.Rows[0].Cells[0].Value = "";
                    tTable.Rows[0].Cells[1].Value = "";
                    tTable.Rows[0].Cells[2].Value = "";
                    tTable.Rows[0].Cells[3].Value = "";
                    tTable.Rows[0].Cells[4].Value = "";
                    targets.Items.Clear();
                    for (int i = 0; i < team1.Count; i++)
                        team1[i].regen();
                    for (int i = 0; i < team2.Count; i++)
                        team2[i].regen();
                    actions.Text = "";
                    targets.Text = "";
                    if (team2.Count <= 0)
                    {
                        winnerLabel.Text = "Победила команда №1";
                        winnerLabel.Visible = true;
                        endTurn.Enabled = false;
                        targets.Enabled = false;
                        actions.Enabled = false;
                        endTurn.Text = "Игра окончена.";
                    }
                    else
                    {
                        cTable.Rows[0].Cells[0].Value = team2[team2_counter].Name;
                        cTable.Rows[0].Cells[1].Value = team2[team2_counter].maxHP;
                        cTable.Rows[0].Cells[2].Value = team2[team2_counter].HP;
                        cTable.Rows[0].Cells[3].Value = team2[team2_counter].Damage;
                        cTable.Rows[0].Cells[4].Value = team2[team2_counter].regenHP;
                        cTable.Refresh();
                    }
                    actions.Text = "";
                }
                else
                {
                    winnerLabel.Text = "Победила команда №1";
                    winnerLabel.Visible = true;
                    endTurn.Enabled = false;
                    targets.Enabled = false;
                    actions.Enabled = false;
                    endTurn.Text = "Игра окончена.";
                }
                
            }
            else if (turn % 2 == 0)
            {
                
                actions.Items.Clear();
                if (team1.Count > 0)
                {
                    if (team1[team1_counter].Type == true)
                    {
                        actions.Items.Add("Атаковать");
                        actions.Items.Add("Исцелить");
                        cTable.Rows[0].Cells[5].Value = team1[team1_counter].HealP;
                        cTable.Refresh();
                        if (actions.Text == "Исцелить")
                        {
                            for (int i = 0; i < team2.Count; i++)
                                targets.Items.Add(team2[i]);
                            team2[team2_counter].heal(team2[targets.SelectedIndex]);
                        }
                        else if (actions.Text == "Атаковать")
                        {
                            for (int i = 0; i < team1.Count; i++)
                                targets.Items.Add(team1[i]);
                            team2[team2_counter].attack(team1[targets.SelectedIndex]);
                            tTable.Rows[0].Cells[2].Value = team1[targets.SelectedIndex].HP;
                            if (team1[targets.SelectedIndex].HP <= 0)
                                team1.RemoveAt(targets.SelectedIndex);
                        }
                    }
                    else
                    {
                        
                        actions.Items.Add("Атаковать");
                        if (actions.Text == "Исцелить")
                        {
                            for (int i = 0; i < team2.Count; i++)
                                targets.Items.Add(team2[i]);
                            team2[team2_counter].heal(team2[targets.SelectedIndex]);
                        }
                        if (actions.Text == "Атаковать")
                        {
                            for (int i = 0; i < team1.Count; i++)
                                targets.Items.Add(team1[i]);
                            team2[team2_counter].attack(team1[targets.SelectedIndex]);
                            tTable.Rows[0].Cells[2].Value = team1[targets.SelectedIndex].HP;
                            if (team1[targets.SelectedIndex].HP <= 0)
                                team1.RemoveAt(targets.SelectedIndex);
                        }
                    }
                    team2_counter++;
                    turn++;
                    turnLabel.Text = "Ход: " + turn;
                    if (team2_counter > team2.Count() - 1)
                        team2_counter--;
                    tTable.Rows[0].Cells[0].Value = "";
                    tTable.Rows[0].Cells[1].Value = "";
                    tTable.Rows[0].Cells[2].Value = "";
                    tTable.Rows[0].Cells[3].Value = "";
                    tTable.Rows[0].Cells[4].Value = "";
                    targets.Items.Clear();
                    for (int i = 0; i < team1.Count; i++)
                        team1[i].regen();
                    for (int i = 0; i < team2.Count; i++)
                        team2[i].regen();
                }
                actions.Text = "";
                targets.Text = "";
                if (team1.Count <= 0)
                {
                    winnerLabel.Text = "Победила команда №2";
                    winnerLabel.Visible = true;
                    endTurn.Enabled = false;
                    targets.Enabled = false;
                    actions.Enabled = false;
                    endTurn.Text = "Игра окончена.";
                }
                else
                {
                    cTable.Rows[0].Cells[0].Value = team1[team1_counter].Name;
                    cTable.Rows[0].Cells[1].Value = team1[team1_counter].maxHP;
                    cTable.Rows[0].Cells[2].Value = team1[team1_counter].HP;
                    cTable.Rows[0].Cells[3].Value = team1[team1_counter].Damage;
                    cTable.Rows[0].Cells[4].Value = team1[team1_counter].regenHP;
                    cTable.Refresh();
                }
                actions.Text = "";
            }
            else
            {
                winnerLabel.Text = "Победила команда №2";
                winnerLabel.Visible = true;
                endTurn.Enabled = false;
                targets.Enabled = false;
                actions.Enabled = false;
                endTurn.Text = "Игра окончена.";
            }
        }

        private void actions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (turn % 2 != 0)
            {
                if (team1[team1_counter].Type)
                {
                    if (actions.SelectedIndex == 0)
                        for (int i = 0; i < team2.Count; i++)
                            targets.Items.Add(team2[i].Name);
                    else
                        for (int i = 0; i < team1.Count; i++)
                            targets.Items.Add(team1[i].Name);
                }
                else
                {
                    for (int i = 0; i < team2.Count; i++)
                        targets.Items.Add(team2[i].Name);
                }
            }
            else
            {
                if (team2[team2_counter].Type)
                {
                    if (actions.SelectedIndex == 0)
                        for (int i = 0; i < team1.Count; i++)
                            targets.Items.Add(team1[i].Name);
                    else
                        for (int i = 0; i < team2.Count; i++)
                            targets.Items.Add(team2[i].Name);
                }
                else
                {
                    for (int i = 0; i < team1.Count; i++)
                        targets.Items.Add(team1[i].Name);
                }
            }
        }
        private void targets_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (turn % 2 != 0)
            {
                if (actions.SelectedIndex == 0)
                {
                    tTable.Rows[0].Cells[0].Value = team2[targets.SelectedIndex].Name;
                    tTable.Rows[0].Cells[1].Value = team2[targets.SelectedIndex].maxHP;
                    tTable.Rows[0].Cells[2].Value = team2[targets.SelectedIndex].HP;
                    tTable.Rows[0].Cells[3].Value = team2[targets.SelectedIndex].Damage;
                    tTable.Rows[0].Cells[4].Value = team2[targets.SelectedIndex].regenHP;
                    tTable.Refresh();
                    if (team2[targets.SelectedIndex].Type == true)
                        tTable.Rows[0].Cells[5].Value = team2[targets.SelectedIndex].HealP;
                    else
                        tTable.Rows[0].Cells[5].Value = "-";
                }
                else
                {
                    tTable.Rows[0].Cells[0].Value = team1[targets.SelectedIndex].Name;
                    tTable.Rows[0].Cells[1].Value = team1[targets.SelectedIndex].maxHP;
                    tTable.Rows[0].Cells[2].Value = team1[targets.SelectedIndex].HP;
                    tTable.Rows[0].Cells[3].Value = team1[targets.SelectedIndex].Damage;
                    tTable.Rows[0].Cells[4].Value = team1[targets.SelectedIndex].regenHP;
                    tTable.Refresh();
                    if (team1[targets.SelectedIndex].Type == true)
                        tTable.Rows[0].Cells[5].Value = team1[targets.SelectedIndex].HealP;
                    else
                        tTable.Rows[0].Cells[5].Value = "-";
                }
                
            }
            else
            {
                if (actions.SelectedIndex == 0)
                {
                    tTable.Rows[0].Cells[0].Value = team1[targets.SelectedIndex].Name;
                    tTable.Rows[0].Cells[1].Value = team1[targets.SelectedIndex].maxHP;
                    tTable.Rows[0].Cells[2].Value = team1[targets.SelectedIndex].HP;
                    tTable.Rows[0].Cells[3].Value = team1[targets.SelectedIndex].Damage;
                    tTable.Rows[0].Cells[4].Value = team1[targets.SelectedIndex].regenHP;
                    tTable.Refresh();
                    if (team1[targets.SelectedIndex].Type == true)
                        tTable.Rows[0].Cells[5].Value = team1[targets.SelectedIndex].HealP;
                    else
                        tTable.Rows[0].Cells[5].Value = "-";
                }
                else
                {
                    tTable.Rows[0].Cells[0].Value = team2[targets.SelectedIndex].Name;
                    tTable.Rows[0].Cells[1].Value = team2[targets.SelectedIndex].maxHP;
                    tTable.Rows[0].Cells[2].Value = team2[targets.SelectedIndex].HP;
                    tTable.Rows[0].Cells[3].Value = team2[targets.SelectedIndex].Damage;
                    tTable.Rows[0].Cells[4].Value = team2[targets.SelectedIndex].regenHP;
                    tTable.Refresh();
                    if (team2[targets.SelectedIndex].Type == true)
                        tTable.Rows[0].Cells[5].Value = team2[targets.SelectedIndex].HealP;
                    else
                        tTable.Rows[0].Cells[5].Value = "-";
                }
            }
            
        }
        private void LAB_Load(object sender, EventArgs e)
        {
            addCharacterTab.Location = new Point(4, 25);
        }

        private void hmaxHPbox_click(object sender, MouseEventArgs e)
        {
            addHealer.Text = "Добавить";
        }

        private void hregenbox_click(object sender, MouseEventArgs e)
        {
            addHealer.Text = "Добавить";
        }

        private void hdmgbox_click(object sender, MouseEventArgs e)
        {
            addHealer.Text = "Добавить";
        }

        private void hpowerbox_click(object sender, MouseEventArgs e)
        {
            addHealer.Text = "Добавить";
        }

        private void hnamebox_Click(object sender, MouseEventArgs e)
        {
            addHealer.Text = "Добавить";
        }

        private void wnamebox_click(object sender, MouseEventArgs e)
        {
            addWarrior.Text = "Добавить";
        }

        private void wmaxHPbox_click(object sender, MouseEventArgs e)
        {
            addWarrior.Text = "Добавить";
        }

        private void wregenbox_click(object sender, MouseEventArgs e)
        {
            addWarrior.Text = "Добавить";
        }

        private void wdmgbox_click(object sender, MouseEventArgs e)
        {
            addWarrior.Text = "Добавить";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            addWarrior.Text = "Добавить";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            addWarrior.Text = "Добавить";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            addHealer.Text = "Добавить";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            addHealer.Text = "Добавить";
        }
    }
}
