using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;


namespace Our_Game
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(new Form1());
        }
        public static int HP, maxHP, MP, maxMP, Steps, maxSteps, XP, maxXP, money, cell, weapon, armor, staff, artefuckt, Part, items, pageInventory, person, ivent, EnemyType, Enemy, enemyDamage, baseAttack = 1, weaponAttack = 0, CriticalAttack = 5, stepsWeapon = 1, helmetDef = 0, armorDef = 0, shieldDef = 0, map1 = 0, map2 = 0, map3 = 0, map4 = 0, map5 = 0, check = 0, Exp=0, maxExp=200, level=1;
        public static string text, Name, savePath, savePath2;
        public static string[] inventory = new string[35];
        public static int[] selecteditem = new int[35];
        public static string[] armorselected = new string[] { "Кожаная броня", "Кольчужная броня", "Железная броня", "Доспех Богов" };
        public static string[] helmetselected = new string[] { "Кожаный шлем", "Кольчужный шлем", "Железный шлем", "Блестящий шлем" };
        public static string[] shieldselected = new string[] { "Деревянный щит", "Бойцовский щит", "Железный щит", "Адский щит" };
        public static string[] weaponselected = new string[] { "Дубинка", "Ржавый кинжал", "Топор", "Меч", "Булава", "Кинжал ассасина", "Боевой топор", "Пика(чу)", "Палица", "Рубиновый меч", "Святой меч" };
        public static string[] artefucktselected = new string[] { "Малый амулет здоровья", "Кольцо \"Моя прелесть\"", "Браслет Удачи", "Анкх", "Кольцо некроманта", "Большой амулет здоровья", "Кольцо \"IYX\"" };
        public static string[] staffselected = new string[] { "Посох ученика", "Посох шамана", "Посох некроманта", "Рубиновый посох" };
        public static string[] PoisonSelected = new string[] { "Зелье здоровья", "Зелье маны", "Свиток ускорения", "Большое зелье здоровья", "Большое зелье маны" };
        public static bool loadError;
        public static Form1 f1 = new Form1();
        public static Form2 f2 = new Form2();
        public static Form3 f3 = new Form3();
        public static Form4 f4 = new Form4();
        public static Shop f5 = new Shop();
        public static Load LForm = new Load();
        public static Inventory inv = new Inventory();
        public static Save SForm = new Save();
        public static Map Map = new Map();//инициализация всех форм

        public static void Save(int slot) // сохранение прогресса
        {
            Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\SAVES"); //путь для сохранения
            switch (slot) // выбор слота 
            {
                case 1:
                    savePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\SAVES\\save1.txt";
                    savePath2 = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\SAVES\\save12.txt";
                    StreamWriter save1 = new StreamWriter(savePath);
                    save1.WriteLine(saveText());
                    save1.Close();
                    StreamWriter save12 = new StreamWriter(savePath2);
                    save12.WriteLine(saveText2());
                    save12.Close();
                    break;
                case 2:
                    savePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\SAVES\\save2.txt";
                    savePath2 = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\SAVES\\save22.txt";
                    StreamWriter save2 = new StreamWriter(savePath);
                    save2.WriteLine(saveText());
                    save2.Close();
                    StreamWriter save22 = new StreamWriter(savePath2);
                    save22.WriteLine(saveText2());
                    save22.Close();
                    break;
                case 3:
                    savePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\SAVES\\save3.txt";
                    savePath2 = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\SAVES\\save32.txt";
                    StreamWriter save3 = new StreamWriter(savePath);
                    save3.WriteLine(saveText());
                    save3.Close();
                    StreamWriter save32 = new StreamWriter(savePath2);
                    save32.WriteLine(saveText2());
                    save32.Close();
                    break;
                case 4:
                    savePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\SAVES\\AutoSave.txt";
                    savePath2 = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\SAVES\\AutoSave2.txt";
                    StreamWriter save4 = new StreamWriter(savePath);
                    save4.WriteLine(saveText());
                    save4.Close();
                    StreamWriter save42 = new StreamWriter(savePath2);
                    save42.WriteLine(saveText2());
                    save42.Close();
                    break;
            }

        }
        static string saveText() // текст, который будет сохранён
        {
            check = maxHP + HP + Steps + map1 + map3+ maxSteps+ money;
            return maxHP + " " + HP + " " + maxSteps + " " + Steps + " " + person + " " + map1 + " " + map2 + " " + map3 + " " + map4 + " " + map5 + " " +
                +money + " "+XP+" "+Exp+" "+maxExp+" "+level;
        }

        static string saveText2() // текст, который будет сохранён
        {
            string save = "";
            for (int i = 1; i <= 24; i++)
            {
                save += inventory[i] + ".";
            }
            for (int i = 28; i <= 33; i++)
            {
                save += inventory[i] + ".";
            }
            save += f4.comboBox1.Text + ".";
            save += f4.comboBox2.Text + ".";
            save += f4.comboBox3.Text + ".";
            save += f4.comboBox4.Text + ".";
            save += f4.comboBox5.Text + ".";
            save += Name+".";
            save += f3.comboBox1.Text;
            return save;
        }

        public static void Load(int slot)
        {
            loadError = false;
            try
            {
                switch (slot)
                {
                    case 1:
                        savePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\SAVES\\save1.txt";
                        savePath2 = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\SAVES\\save12.txt";
                        break;
                    case 2:
                        savePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\SAVES\\save2.txt";
                        savePath2 = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\SAVES\\save22.txt";
                        break;
                    case 3:
                        savePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\SAVES\\save3.txt";
                        savePath2 = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\SAVES\\save32.txt";
                        break;
                    case 4:
                        savePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\SAVES\\AutoSave.txt";
                        savePath2 = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\SAVES\\AutoSave2.txt";
                        break;
                }

                TextReader saveRead = new StreamReader(savePath);
                int[] saveMas = saveRead.ReadToEnd().Split(' ').Where(x => !string.IsNullOrWhiteSpace(x)).Select(x => int.Parse(x)).ToArray(); //создание массива по файлу
                saveRead.Close();
                maxHP = saveMas[0];
                HP = saveMas[1];
                maxSteps = saveMas[2];
                Steps = saveMas[3];
                person = saveMas[4];
                map1 = saveMas[5];
                map2 = saveMas[6];
                map3 = saveMas[7];
                map4 = saveMas[8];
                map5 = saveMas[9];
                money = saveMas[10];
                XP = saveMas[11];
                Exp = saveMas[12];
                maxExp = saveMas[13];
                level = saveMas[14];

                //распределенеие параметров по порядку в массиве

                string[] lines = File.ReadAllText(savePath2).Split('.');
                for (int i = 0; i < 24; i++)
                {
                    inventory[i + 1] = lines[i];
                }
                inventory[28] = lines[24];
                inventory[29] = lines[25];
                inventory[30] = lines[26];
                inventory[31] = lines[27];
                inventory[32] = lines[28];
                inventory[33] = lines[29];
                f4.UpgradeWeapon();
                inv.Upgrade();
                f4.UpgradeHelmet();
                f4.UpgradeArmor();
                f4.UpgradeShield();
                f4.UpgradeStaff();
                f4.UpgradeArtefucts();
                f4.comboBox1.Text = lines[30];
                f4.comboBox2.Text = lines[31];
                f4.comboBox3.Text = lines[32];
                f4.comboBox4.Text = lines[33];
                f4.comboBox5.Text = lines[34];
                Name = lines[35];
                f3.comboBox1.Text = lines[36];
            }
            catch (FileNotFoundException)
            {
                loadError = true;
                MessageBox.Show("Ошибка! Файл не найден!", "Файл не найден!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                loadError = true;
                MessageBox.Show("Ошибка! Файл повреждён!", "Файл повреждён!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }

    }
}
