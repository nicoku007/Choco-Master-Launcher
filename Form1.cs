using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace experimento
{
    public partial class Form1 : Form
    {
        private Image imagen1;
        private Image imagen2;
        private Image imagen3;
        private Image imagen4;
        private Image imagen5;
        private Image imagen6;
        private Image imagen7;
        private Image imagen8;
        private Image imagen9;
        private Image imagen10;
        private Image imagen11;
        private Image imagen12;
        private Image imagen13;
        private Image imagen14;
        private Image imagen15;
        private Image imagen16;
        private Image imagen17;
        private Image imagen18;
        private Image imagen19;
        private Image imagen20;
        private Image imagen21;
        private Image imagen22;
        private Image imagen23;
        private Image imagen24;
        private Image imagen25;
        private Image imagen26;
        private Image imagen27;
        private Image imagen28;
        private Image imagen29;
        private Image imagen30;
        private Image imagen31;
        private Image imagen32;
        private Image imagen33;
        private Image imagen34;
        private Image imagen35;
        private Image imagen36;
        private Image imagen37;
        private Image imagen38;
        private Image imagen39;
        private Image imagen40;
        private Image imagen41;
        private Image imagen42;


        public Form1()
        {
            InitializeComponent();

            imagen1 = Properties.Resources.doom2; 
            imagen2 = Properties.Resources.ATTACK;
            imagen3 = Properties.Resources.doom2;
            imagen4 = Properties.Resources.BLACKTWR;
            imagen5 = Properties.Resources.doom2;
            imagen6 = Properties.Resources.BLOODSEA;
            imagen7 = Properties.Resources.doom2;
            imagen8 = Properties.Resources.CANYON;
            imagen9 = Properties.Resources.doom2;
            imagen10 = Properties.Resources.CATWALK;
            imagen11 = Properties.Resources.doom2;
            imagen12 = Properties.Resources.COMBINE;
            imagen13 = Properties.Resources.doom2;
            imagen14 = Properties.Resources.FISTULA;
            imagen15 = Properties.Resources.doom2;
            imagen16 = Properties.Resources.GARRISON;
            imagen17 = Properties.Resources.doom2;
            imagen18 = Properties.Resources.GERYON;
            imagen19 = Properties.Resources.doom2;
            imagen20 = Properties.Resources.MANOR;
            imagen21 = Properties.Resources.doom2;
            imagen22 = Properties.Resources.MEPHISTO;
            imagen23 = Properties.Resources.doom2;
            imagen24 = Properties.Resources.MINOS;
            imagen25 = Properties.Resources.doom2;
            imagen26 = Properties.Resources.NESSUS;
            imagen27 = Properties.Resources.doom2;
            imagen28 = Properties.Resources.PARADOX;
            imagen29 = Properties.Resources.doom2;
            imagen30 = Properties.Resources.SUBSPACE;
            imagen31 = Properties.Resources.doom2;
            imagen32 = Properties.Resources.SUBTERRA;
            imagen33 = Properties.Resources.doom2;
            imagen34 = Properties.Resources.TEETH31;
            imagen35 = Properties.Resources.doom2;
            imagen36 = Properties.Resources.TTRAP;
            imagen37 = Properties.Resources.doom2;
            imagen38 = Properties.Resources.VESPERAS;
            imagen39 = Properties.Resources.doom2;
            imagen40 = Properties.Resources.VIRGIL;
            imagen41 = Properties.Resources.doom2;
            imagen42 = Properties.Resources.BAD;




            toolStripMenuItem2.MouseEnter += toolStripMenuItem2_MouseEnter;
            toolStripMenuItem2.MouseLeave += toolStripMenuItem2_MouseLeave;
            toolStripMenuItem3.MouseEnter += toolStripMenuItem3_MouseEnter;
            toolStripMenuItem3.MouseLeave += toolStripMenuItem3_MouseLeave;
            toolStripMenuItem4.MouseEnter += toolStripMenuItem4_MouseEnter;
            toolStripMenuItem4.MouseLeave += toolStripMenuItem4_MouseLeave;
            toolStripMenuItem5.MouseEnter += toolStripMenuItem5_MouseEnter;
            toolStripMenuItem5.MouseLeave += toolStripMenuItem5_MouseLeave;
            toolStripMenuItem6.MouseEnter += toolStripMenuItem6_MouseEnter;
            toolStripMenuItem6.MouseLeave += toolStripMenuItem6_MouseLeave;
            toolStripMenuItem7.MouseEnter += toolStripMenuItem7_MouseEnter;
            toolStripMenuItem7.MouseLeave += toolStripMenuItem7_MouseLeave;
            toolStripMenuItem8.MouseEnter += toolStripMenuItem8_MouseEnter;
            toolStripMenuItem8.MouseLeave += toolStripMenuItem8_MouseLeave;
            toolStripMenuItem9.MouseEnter += toolStripMenuItem9_MouseEnter;
            toolStripMenuItem9.MouseLeave += toolStripMenuItem9_MouseLeave;
            toolStripMenuItem10.MouseEnter += toolStripMenuItem10_MouseEnter;
            toolStripMenuItem10.MouseLeave += toolStripMenuItem10_MouseLeave;
            toolStripMenuItem11.MouseEnter += toolStripMenuItem11_MouseEnter;
            toolStripMenuItem11.MouseLeave += toolStripMenuItem11_MouseLeave;
            toolStripMenuItem12.MouseEnter += toolStripMenuItem12_MouseEnter;
            toolStripMenuItem12.MouseLeave += toolStripMenuItem12_MouseLeave;
            toolStripMenuItem13.MouseEnter += toolStripMenuItem13_MouseEnter;
            toolStripMenuItem13.MouseLeave += toolStripMenuItem13_MouseLeave;
            toolStripMenuItem14.MouseEnter += toolStripMenuItem14_MouseEnter;
            toolStripMenuItem14.MouseLeave += toolStripMenuItem14_MouseLeave;
            toolStripMenuItem15.MouseEnter += toolStripMenuItem15_MouseEnter;
            toolStripMenuItem15.MouseLeave += toolStripMenuItem15_MouseLeave;
            toolStripMenuItem16.MouseEnter += toolStripMenuItem16_MouseEnter;
            toolStripMenuItem16.MouseLeave += toolStripMenuItem16_MouseLeave;
            toolStripMenuItem17.MouseEnter += toolStripMenuItem17_MouseEnter;
            toolStripMenuItem17.MouseLeave += toolStripMenuItem17_MouseLeave;
            toolStripMenuItem18.MouseEnter += toolStripMenuItem18_MouseEnter;
            toolStripMenuItem18.MouseLeave += toolStripMenuItem18_MouseLeave;
            toolStripMenuItem19.MouseEnter += toolStripMenuItem19_MouseEnter;
            toolStripMenuItem19.MouseLeave += toolStripMenuItem19_MouseLeave;
            toolStripMenuItem20.MouseEnter += toolStripMenuItem20_MouseEnter;
            toolStripMenuItem20.MouseLeave += toolStripMenuItem20_MouseLeave;
            toolStripMenuItem21.MouseEnter += toolStripMenuItem21_MouseEnter;
            toolStripMenuItem21.MouseLeave += toolStripMenuItem21_MouseLeave;
            toolStripMenuItem23.MouseEnter += toolStripMenuItem23_MouseEnter;
            toolStripMenuItem23.MouseLeave += toolStripMenuItem23_MouseLeave;
            toolStripMenuItem24.MouseEnter += toolStripMenuItem24_MouseEnter;
            toolStripMenuItem24.MouseLeave += toolStripMenuItem24_MouseLeave;
            toolStripMenuItem25.MouseEnter += toolStripMenuItem25_MouseEnter;
            toolStripMenuItem25.MouseLeave += toolStripMenuItem25_MouseLeave;
            toolStripMenuItem26.MouseEnter += toolStripMenuItem26_MouseEnter;
            toolStripMenuItem26.MouseLeave += toolStripMenuItem26_MouseLeave;
            toolStripMenuItem27.MouseEnter += toolStripMenuItem27_MouseEnter;
            toolStripMenuItem27.MouseLeave += toolStripMenuItem27_MouseLeave;
            toolStripMenuItem28.MouseEnter += toolStripMenuItem28_MouseEnter;
            toolStripMenuItem28.MouseLeave += toolStripMenuItem28_MouseLeave;
            toolStripMenuItem29.MouseEnter += toolStripMenuItem29_MouseEnter;
            toolStripMenuItem29.MouseLeave += toolStripMenuItem29_MouseLeave;
            toolStripMenuItem30.MouseEnter += toolStripMenuItem30_MouseEnter;
            toolStripMenuItem30.MouseLeave += toolStripMenuItem30_MouseLeave;
            toolStripMenuItem31.MouseEnter += toolStripMenuItem31_MouseEnter;
            toolStripMenuItem31.MouseLeave += toolStripMenuItem31_MouseLeave;
            toolStripMenuItem32.MouseEnter += toolStripMenuItem32_MouseEnter;
            toolStripMenuItem32.MouseLeave += toolStripMenuItem32_MouseLeave;
            toolStripMenuItem33.MouseEnter += toolStripMenuItem33_MouseEnter;
            toolStripMenuItem33.MouseLeave += toolStripMenuItem33_MouseLeave;
            toolStripMenuItem34.MouseEnter += toolStripMenuItem34_MouseEnter;
            toolStripMenuItem34.MouseLeave += toolStripMenuItem34_MouseLeave;
            toolStripMenuItem35.MouseEnter += toolStripMenuItem35_MouseEnter;
            toolStripMenuItem35.MouseLeave += toolStripMenuItem35_MouseLeave;
            toolStripMenuItem36.MouseEnter += toolStripMenuItem36_MouseEnter;
            toolStripMenuItem36.MouseLeave += toolStripMenuItem36_MouseLeave;
            toolStripMenuItem37.MouseEnter += toolStripMenuItem37_MouseEnter;
            toolStripMenuItem37.MouseLeave += toolStripMenuItem37_MouseLeave;
            toolStripMenuItem38.MouseEnter += toolStripMenuItem38_MouseEnter;
            toolStripMenuItem38.MouseLeave += toolStripMenuItem38_MouseLeave;
            toolStripMenuItem39.MouseEnter += toolStripMenuItem39_MouseEnter;
            toolStripMenuItem39.MouseLeave += toolStripMenuItem39_MouseLeave;
            toolStripMenuItem40.MouseEnter += toolStripMenuItem40_MouseEnter;
            toolStripMenuItem40.MouseLeave += toolStripMenuItem40_MouseLeave;
            toolStripMenuItem41.MouseEnter += toolStripMenuItem41_MouseEnter;
            toolStripMenuItem41.MouseLeave += toolStripMenuItem41_MouseLeave;
            toolStripMenuItem42.MouseEnter += toolStripMenuItem42_MouseEnter;
            toolStripMenuItem42.MouseLeave += toolStripMenuItem42_MouseLeave;
            toolStripMenuItem43.MouseEnter += toolStripMenuItem43_MouseEnter;
            toolStripMenuItem43.MouseLeave += toolStripMenuItem43_MouseLeave;
            toolStripMenuItem44.MouseEnter += toolStripMenuItem44_MouseEnter;
            toolStripMenuItem44.MouseLeave += toolStripMenuItem44_MouseLeave;



            this.menuStrip2.Visible = false;
            this.menuStrip1.Visible = true;
            checkBox3.Checked = true;

        }
        
        public class Item
        {
            public string Name { get; set; }
            public string Value { get; set; }

            public Item(string name, string value)
            {
                Name = name;
                Value = value;
            }

            public override string ToString()
            {
                return Name; 
            }
        }

            private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            string param1 = comboBox1.SelectedItem?.ToString() ?? "";
            string parametros = ConstruirParametros();
            string Argument = $"{param1}";
            EjecutarExe1(parametros + Argument);
           
        }

        private string ConstruirParametros()
        {
            string parametros = "";
            if (checkBox1.Checked)
            {
                parametros += "chocolate-doom -merge wads/ATTACK.WAD -skill 1 -warp 01M ";
            }
            if (checkBox2.Checked)
            {
                parametros += "chocolate-doom -merge wads/ATTACK.WAD -skill 2 -warp 01M ";
            }
            if (checkBox3.Checked)
            {
                parametros += "chocolate-doom -merge wads/ATTACK.WAD -skill 3 -warp 01M ";
            }
            if (checkBox4.Checked)
            {
                parametros += "chocolate-doom -merge wads/ATTACK.WAD -skill 4 -warp 01M ";
            }
            if (checkBox5.Checked)
            {
                parametros += "chocolate-doom -merge wads/ATTACK.WAD -skill 5 -warp 01M ";
            }
            if (checkBox6.Checked)
            {
                parametros += "chocolate-doom -merge wads/ATTACK.WAD -fast -warp 01M ";
            }
            if (checkBox7.Checked)
            {
                parametros += "chocolate-doom -merge wads/ATTACK.WAD -nomonsters -warp 01M ";
            }
            if (checkBox8.Checked)
            {
                parametros += "chocolate-doom -merge wads/ATTACK.WAD -respawn -warp 01M ";
            }
           


            return parametros.Trim();
        }

        private void EjecutarExe1(string parametros)
        {
            try
            {
               
                ProcessStartInfo procesoInfo = new ProcessStartInfo();
                procesoInfo.FileName = "chocolate-doom.exe"; 
                procesoInfo.Arguments = parametros;
                procesoInfo.UseShellExecute = false; 
               


                Process proceso = new Process();
                proceso.StartInfo = procesoInfo;
                proceso.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar el .exe: " + ex.Message);
            }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            string param1 = comboBox1.SelectedItem?.ToString() ?? "";
            string parametros = ConstruirParametros2();
            string Argument = $"{param1}";
            EjecutarExe2(parametros + Argument);
        }

        private string ConstruirParametros2()
        {
            string parametros = "";
            if (checkBox1.Checked)
            {
                parametros += "chocolate-doom -merge wads/BLACKTWR.WAD -skill 1 -warp 025M ";
            }
            if (checkBox2.Checked)
            {
                parametros += "chocolate-doom -merge wads/BLACKTWR.WAD -skill 2 -warp 025M ";
            }
            if (checkBox3.Checked)
            {
                parametros += "chocolate-doom -merge wads/BLACKTWR.WAD -skill 3 -warp 025M ";
            }
            if (checkBox4.Checked)
            {
                parametros += "chocolate-doom -merge wads/BLACKTWR.WAD -skill 4 -warp 025M ";
            }
            if (checkBox5.Checked)
            {
                parametros += "chocolate-doom -merge wads/BLACKTWR.WAD -skill 5 -warp 025M ";
            }
            if (checkBox6.Checked)
            {
                parametros += "chocolate-doom -merge wads/BLACKTWR.WAD -fast -warp 025M ";
            }
            if (checkBox7.Checked)
            {
                parametros += "chocolate-doom -merge wads/BLACKTWR.WAD -nomonsters -warp 025M ";
            }
            if (checkBox8.Checked)
            {
                parametros += "chocolate-doom -merge wads/BLACKTWR.WAD -respawn -warp 025M ";
            }
            

            return parametros.Trim();
        }

        private void EjecutarExe2(string parametros)
        {
            try
            {
                ProcessStartInfo procesoInfo = new ProcessStartInfo();
                procesoInfo.FileName = "chocolate-doom.exe"; 
                procesoInfo.Arguments = parametros;
                procesoInfo.UseShellExecute = false; 

                Process proceso = new Process();
                proceso.StartInfo = procesoInfo;
                proceso.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar el .exe: " + ex.Message);
            }
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            string param1 = comboBox1.SelectedItem?.ToString() ?? "";
            string parametros = ConstruirParametros3();
            string Argument = $"{param1}";
            EjecutarExe3(parametros + Argument);
        }

        private string ConstruirParametros3()
        {
            string parametros = "";
            if (checkBox1.Checked)
            {
                parametros += "chocolate-doom -merge wads/BLOODSEA.WAD -skill 1 -warp 07M ";
            }
            if (checkBox2.Checked)
            {
                parametros += "chocolate-doom -merge wads/BLOODSEA.WAD -skill 2 -warp 07M ";
            }
            if (checkBox3.Checked)
            {
                parametros += "chocolate-doom -merge wads/BLOODSEA.WAD -skill 3 -warp 07M ";
            }
            if (checkBox4.Checked)
            {
                parametros += "chocolate-doom -merge wads/BLOODSEA.WAD -skill 4 -warp 07M ";
            }
            if (checkBox5.Checked)
            {
                parametros += "chocolate-doom -merge wads/BLOODSEA.WAD -skill 5 -warp 07M ";
            }
            if (checkBox6.Checked)
            {
                parametros += "chocolate-doom -merge wads/BLOODSEA.WAD -fast -warp 07M ";
            }
            if (checkBox7.Checked)
            {
                parametros += "chocolate-doom -merge wads/BLOODSEA.WAD -nomonsters -warp 07M ";
            }
            if (checkBox8.Checked)
            {
                parametros += "chocolate-doom -merge wads/BLOODSEA.WAD -respawn -warp 07M ";
            }
          

            return parametros.Trim();
        }

        private void EjecutarExe3(string parametros)
        {
            try
            {
                ProcessStartInfo procesoInfo = new ProcessStartInfo();
                procesoInfo.FileName = "chocolate-doom.exe"; 
                procesoInfo.Arguments = parametros;
                procesoInfo.UseShellExecute = false; 

                Process proceso = new Process();
                proceso.StartInfo = procesoInfo;
                proceso.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar el .exe: " + ex.Message);
            }
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            string param1 = comboBox1.SelectedItem?.ToString() ?? "";
            string parametros = ConstruirParametros4();
            string Argument = $"{param1}";
            EjecutarExe4(parametros + Argument);
        }

        private string ConstruirParametros4()
        {
            string parametros = "";
            if (checkBox1.Checked)
            {
                parametros += "chocolate-doom -merge wads/CANYON.WAD -skill 1 -warp 01M ";
            }
            if (checkBox2.Checked)
            {
                parametros += "chocolate-doom -merge wads/CANYON.WAD -skill 2 -warp 01M ";
            }
            if (checkBox3.Checked)
            {
                parametros += "chocolate-doom -merge wads/CANYON.WAD -skill 3 -warp 01M ";
            }
            if (checkBox4.Checked)
            {
                parametros += "chocolate-doom -merge wads/CANYON.WAD -skill 4 -warp 01M ";
            }
            if (checkBox5.Checked)
            {
                parametros += "chocolate-doom -merge wads/CANYON.WAD -skill 5 -warp 01M ";
            }
            if (checkBox6.Checked)
            {
                parametros += "chocolate-doom -merge wads/CANYON.WAD -fast -warp 01M ";
            }
            if (checkBox7.Checked)
            {
                parametros += "chocolate-doom -merge wads/CANYON.WAD -nomonsters -warp 01M ";
            }
            if (checkBox8.Checked)
            {
                parametros += "chocolate-doom -merge wads/CANYON.WAD -respawn -warp 01M ";
            }
           

            return parametros.Trim();
        }

        private void EjecutarExe4(string parametros)
        {
            try
            {
                ProcessStartInfo procesoInfo = new ProcessStartInfo();
                procesoInfo.FileName = "chocolate-doom.exe"; 
                procesoInfo.Arguments = parametros;
                procesoInfo.UseShellExecute = false; 

                Process proceso = new Process();
                proceso.StartInfo = procesoInfo;
                proceso.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar el .exe: " + ex.Message);
            }
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            string param1 = comboBox1.SelectedItem?.ToString() ?? "";
            string parametros = ConstruirParametros5();
            string Argument = $"{param1}";
            EjecutarExe5(parametros + Argument);
        }

        private string ConstruirParametros5()
        {
            string parametros = "";
            if (checkBox1.Checked)
            {
                parametros += "chocolate-doom -merge wads/CATWALK.WAD -skill 1 -warp 01M ";
            }
            if (checkBox2.Checked)
            {
                parametros += "chocolate-doom -merge wads/CATWALK.WAD -skill 2 -warp 01M ";
            }
            if (checkBox3.Checked)
            {
                parametros += "chocolate-doom -merge wads/CATWALK.WAD -skill 3 -warp 01M ";
            }
            if (checkBox4.Checked)
            {
                parametros += "chocolate-doom -merge wads/CATWALK.WAD -skill 4 -warp 01M ";
            }
            if (checkBox5.Checked)
            {
                parametros += "chocolate-doom -merge wads/CATWALK.WAD -skill 5 -warp 01M ";
            }
            if (checkBox6.Checked)
            {
                parametros += "chocolate-doom -merge wads/CATWALK.WAD -fast -warp 01M ";
            }
            if (checkBox7.Checked)
            {
                parametros += "chocolate-doom -merge wads/CATWALK.WAD -nomonsters -warp 01M ";
            }
            if (checkBox8.Checked)
            {
                parametros += "chocolate-doom -merge wads/CATWALK.WAD -respawn -warp 01M ";
            }
           
            return parametros.Trim();
        }

        private void EjecutarExe5(string parametros)
        {
            try
            {
                ProcessStartInfo procesoInfo = new ProcessStartInfo();
                procesoInfo.FileName = "chocolate-doom.exe"; 
                procesoInfo.Arguments = parametros;
                procesoInfo.UseShellExecute = false; 

                Process proceso = new Process();
                proceso.StartInfo = procesoInfo;
                proceso.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar el .exe: " + ex.Message);
            }
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            string param1 = comboBox1.SelectedItem?.ToString() ?? "";
            string parametros = ConstruirParametros6();
            string Argument = $"{param1}";
            EjecutarExe6(parametros + Argument);
        }

        private string ConstruirParametros6()
        {
            string parametros = "";
            if (checkBox1.Checked)
            {
                parametros += "chocolate-doom -merge wads/COMBINE.WAD -skill 1 -warp 01M ";
            }
            if (checkBox2.Checked)
            {
                parametros += "chocolate-doom -merge wads/COMBINE.WAD -skill 2 -warp 01M ";
            }
            if (checkBox3.Checked)
            {
                parametros += "chocolate-doom -merge wads/COMBINE.WAD -skill 3 -warp 01M ";
            }
            if (checkBox4.Checked)
            {
                parametros += "chocolate-doom -merge wads/COMBINE.WAD -skill 4 -warp 01M ";
            }
            if (checkBox5.Checked)
            {
                parametros += "chocolate-doom -merge wads/COMBINE.WAD -skill 5 -warp 01M ";
            }
            if (checkBox6.Checked)
            {
                parametros += "chocolate-doom -merge wads/COMBINE.WAD -fast -warp 01M ";
            }
            if (checkBox7.Checked)
            {
                parametros += "chocolate-doom -merge wads/COMBINE.WAD -nomonsters -warp 01M ";
            }
            if (checkBox8.Checked)
            {
                parametros += "chocolate-doom -merge wads/COMBINE.WAD -respawn -warp 01M ";
            }
           

            return parametros.Trim();
        }

        private void EjecutarExe6(string parametros)
        {
            try
            {
                ProcessStartInfo procesoInfo = new ProcessStartInfo();
                procesoInfo.FileName = "chocolate-doom.exe"; 
                procesoInfo.Arguments = parametros;
                procesoInfo.UseShellExecute = false; 

                Process proceso = new Process();
                proceso.StartInfo = procesoInfo;
                proceso.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar el .exe: " + ex.Message);
            }
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            string param1 = comboBox1.SelectedItem?.ToString() ?? "";
            string parametros = ConstruirParametros7();
            string Argument = $"{param1}";
            EjecutarExe7(parametros + Argument);
        }

        private string ConstruirParametros7()
        {
            string parametros = "";
            if (checkBox1.Checked)
            {
                parametros += "chocolate-doom -merge wads/FISTULA.WAD -skill 1 -warp 01M ";
            }
            if (checkBox2.Checked)
            {
                parametros += "chocolate-doom -merge wads/FISTULA.WAD -skill 2 -warp 01M ";
            }
            if (checkBox3.Checked)
            {
                parametros += "chocolate-doom -merge wads/FISTULA.WAD -skill 3 -warp 01M ";
            }
            if (checkBox4.Checked)
            {
                parametros += "chocolate-doom -merge wads/FISTULA.WAD -skill 4 -warp 01M ";
            }
            if (checkBox5.Checked)
            {
                parametros += "chocolate-doom -merge wads/FISTULA.WAD -skill 5 -warp 01M ";
            }
            if (checkBox6.Checked)
            {
                parametros += "chocolate-doom -merge wads/FISTULA.WAD -fast -warp 01M ";
            }
            if (checkBox7.Checked)
            {
                parametros += "chocolate-doom -merge wads/FISTULA.WAD -nomonsters -warp 01M ";
            }
            if (checkBox8.Checked)
            {
                parametros += "chocolate-doom -merge wads/FISTULA.WAD -respawn -warp 01M ";
            }
         

            return parametros.Trim();
        }

        private void EjecutarExe7(string parametros)
        {
            try
            {
                ProcessStartInfo procesoInfo = new ProcessStartInfo();
                procesoInfo.FileName = "chocolate-doom.exe"; 
                procesoInfo.Arguments = parametros;
                procesoInfo.UseShellExecute = false; 

                Process proceso = new Process();
                proceso.StartInfo = procesoInfo;
                proceso.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar el .exe: " + ex.Message);
            }
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            string param1 = comboBox1.SelectedItem?.ToString() ?? "";
            string parametros = ConstruirParametros8();
            string Argument = $"{param1}";
            EjecutarExe8(parametros + Argument);
        }

        private string ConstruirParametros8()
        {
            string parametros = "";
            if (checkBox1.Checked)
            {
                parametros += "chocolate-doom -merge wads/GARRISON.WAD -skill 1 -warp 01M ";
            }
            if (checkBox2.Checked)
            {
                parametros += "chocolate-doom -merge wads/GARRISON.WAD -skill 2 -warp 01M ";
            }
            if (checkBox3.Checked)
            {
                parametros += "chocolate-doom -merge wads/GARRISON.WAD -skill 3 -warp 01M ";
            }
            if (checkBox4.Checked)
            {
                parametros += "chocolate-doom -merge wads/GARRISON.WAD -skill 4 -warp 01M ";
            }
            if (checkBox5.Checked)
            {
                parametros += "chocolate-doom -merge wads/GARRISON.WAD -skill 5 -warp 01M ";
            }
            if (checkBox6.Checked)
            {
                parametros += "chocolate-doom -merge wads/GARRISON.WAD -fast -warp 01M ";
            }
            if (checkBox7.Checked)
            {
                parametros += "chocolate-doom -merge wads/GARRISON.WAD -nomonsters -warp 01M ";
            }
            if (checkBox8.Checked)
            {
                parametros += "chocolate-doom -merge wads/GARRISON.WAD -respawn -warp 01M ";
            }
           

            return parametros.Trim();
        }

        private void EjecutarExe8(string parametros)
        {
            try
            {
                ProcessStartInfo procesoInfo = new ProcessStartInfo();
                procesoInfo.FileName = "chocolate-doom.exe"; 
                procesoInfo.Arguments = parametros;
                procesoInfo.UseShellExecute = false; 

                Process proceso = new Process();
                proceso.StartInfo = procesoInfo;
                proceso.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar el .exe: " + ex.Message);
            }
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            string param1 = comboBox1.SelectedItem?.ToString() ?? "";
            string parametros = ConstruirParametros9();
            string Argument = $"{param1}";
            EjecutarExe9(parametros + Argument);
        }

        private string ConstruirParametros9()
        {
            string parametros = "";
            if (checkBox1.Checked)
            {
                parametros += "chocolate-doom -merge wads/GERYON.WAD -skill 1 -warp 08M ";
            }
            if (checkBox2.Checked)
            {
                parametros += "chocolate-doom -merge wads/GERYON.WAD -skill 2 -warp 08M ";
            }
            if (checkBox3.Checked)
            {
                parametros += "chocolate-doom -merge wads/GERYON.WAD -skill 3 -warp 08M ";
            }
            if (checkBox4.Checked)
            {
                parametros += "chocolate-doom -merge wads/GERYON.WAD -skill 4 -warp 08M ";
            }
            if (checkBox5.Checked)
            {
                parametros += "chocolate-doom -merge wads/GERYON.WAD -skill 5 -warp 08M ";
            }
            if (checkBox6.Checked)
            {
                parametros += "chocolate-doom -merge wads/GERYON.WAD -fast -warp 08M ";
            }
            if (checkBox7.Checked)
            {
                parametros += "chocolate-doom -merge wads/GERYON.WAD -nomonsters -warp 08M ";
            }
            if (checkBox8.Checked)
            {
                parametros += "chocolate-doom -merge wads/GERYON.WAD -respawn -warp 08M ";
            }
         

            return parametros.Trim();
        }
        private void EjecutarExe9(string parametros)
        {
            try
            {
                ProcessStartInfo procesoInfo = new ProcessStartInfo();
                procesoInfo.FileName = "chocolate-doom.exe"; 
                procesoInfo.Arguments = parametros;
                procesoInfo.UseShellExecute = false; 

                Process proceso = new Process();
                proceso.StartInfo = procesoInfo;
                proceso.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar el .exe: " + ex.Message);
            }
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            string param1 = comboBox1.SelectedItem?.ToString() ?? "";
            string parametros = ConstruirParametros10();
            string Argument = $"{param1}";
            EjecutarExe10(parametros + Argument);
        }

        private string ConstruirParametros10()
        {
            string parametros = "";
            if (checkBox1.Checked)
            {
                parametros += "chocolate-doom -merge wads/MANOR.WAD -skill 1 -warp 01M ";
            }
            if (checkBox2.Checked)
            {
                parametros += "chocolate-doom -merge wads/MANOR.WAD -skill 2 -warp 01M ";
            }
            if (checkBox3.Checked)
            {
                parametros += "chocolate-doom -merge wads/MANOR.WAD -skill 3 -warp 01M ";
            }
            if (checkBox4.Checked)
            {
                parametros += "chocolate-doom -merge wads/MANOR.WAD -skill 4 -warp 01M ";
            }
            if (checkBox5.Checked)
            {
                parametros += "chocolate-doom -merge wads/MANOR.WAD -skill 5 -warp 01M ";
            }
            if (checkBox6.Checked)
            {
                parametros += "chocolate-doom -merge wads/MANOR.WAD -fast -warp 01M ";
            }
            if (checkBox7.Checked)
            {
                parametros += "chocolate-doom -merge wads/MANOR.WAD -nomonsters -warp 01M ";
            }
            if (checkBox8.Checked)
            {
                parametros += "chocolate-doom -merge wads/MANOR.WAD -respawn -warp 01M ";
            }
           

            return parametros.Trim();
        }

        private void EjecutarExe10(string parametros)
        {
            try
            {
                ProcessStartInfo procesoInfo = new ProcessStartInfo();
                procesoInfo.FileName = "chocolate-doom.exe"; 
                procesoInfo.Arguments = parametros;
                procesoInfo.UseShellExecute = false; 

                Process proceso = new Process();
                proceso.StartInfo = procesoInfo;
                proceso.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar el .exe: " + ex.Message);
            }
        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            string param1 = comboBox1.SelectedItem?.ToString() ?? "";
            string parametros = ConstruirParametros11();
            string Argument = $"{param1}";
            EjecutarExe11(parametros + Argument);
        }

        private string ConstruirParametros11()
        {
            string parametros = "";
            if (checkBox1.Checked)
            {
                parametros += "chocolate-doom -merge wads/MEPHISTO.WAD -skill 1 -warp 07M ";
            }
            if (checkBox2.Checked)
            {
                parametros += "chocolate-doom -merge wads/MEPHISTO.WAD -skill 2 -warp 07M ";
            }
            if (checkBox3.Checked)
            {
                parametros += "chocolate-doom -merge wads/MEPHISTO.WAD -skill 3 -warp 07M ";
            }
            if (checkBox4.Checked)
            {
                parametros += "chocolate-doom -merge wads/MEPHISTO.WAD -skill 4 -warp 07M ";
            }
            if (checkBox5.Checked)
            {
                parametros += "chocolate-doom -merge wads/MEPHISTO.WAD -skill 5 -warp 07M ";
            }
            if (checkBox6.Checked)
            {
                parametros += "chocolate-doom -merge wads/MEPHISTO.WAD -fast -warp 07M ";
            }
            if (checkBox7.Checked)
            {
                parametros += "chocolate-doom -merge wads/MEPHISTO.WAD -nomonsters -warp 07M ";
            }
            if (checkBox8.Checked)
            {
                parametros += "chocolate-doom -merge wads/MEPHISTO.WAD -respawn -warp 07M ";
            }
            

            return parametros.Trim();
        }

        private void EjecutarExe11(string parametros)
        {
            try
            {
                ProcessStartInfo procesoInfo = new ProcessStartInfo();
                procesoInfo.FileName = "chocolate-doom.exe"; 
                procesoInfo.Arguments = parametros;
                procesoInfo.UseShellExecute = false; 

                Process proceso = new Process();
                proceso.StartInfo = procesoInfo;
                proceso.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar el .exe: " + ex.Message);
            }
        }

        private void toolStripMenuItem13_Click(object sender, EventArgs e)
        {
            string param1 = comboBox1.SelectedItem?.ToString() ?? "";
            string parametros = ConstruirParametros12();
            string Argument = $"{param1}";
            EjecutarExe12(parametros + Argument);
        }

        private string ConstruirParametros12()
        {
            string parametros = "";
            if (checkBox1.Checked)
            {
                parametros += "chocolate-doom -merge wads/MINOS.WAD -skill 1 -warp 05M ";
            }
            if (checkBox2.Checked)
            {
                parametros += "chocolate-doom -merge wads/MINOS.WAD -skill 2 -warp 05M ";
            }
            if (checkBox3.Checked)
            {
                parametros += "chocolate-doom -merge wads/MINOS.WAD -skill 3 -warp 05M ";
            }
            if (checkBox4.Checked)
            {
                parametros += "chocolate-doom -merge wads/MINOS.WAD -skill 4 -warp 05M ";
            }
            if (checkBox5.Checked)
            {
                parametros += "chocolate-doom -merge wads/MINOS.WAD -skill 5 -warp 05M ";
            }
            if (checkBox6.Checked)
            {
                parametros += "chocolate-doom -merge wads/MINOS.WAD -fast -warp 05M ";
            }
            if (checkBox7.Checked)
            {
                parametros += "chocolate-doom -merge wads/MINOS.WAD -nomonsters -warp 05M ";
            }
            if (checkBox8.Checked)
            {
                parametros += "chocolate-doom -merge wads/MINOS.WAD -respawn -warp 05M ";
            }
            

            return parametros.Trim();
        }

        private void EjecutarExe12(string parametros)
        {
            try
            {
                ProcessStartInfo procesoInfo = new ProcessStartInfo();
                procesoInfo.FileName = "chocolate-doom.exe"; 
                procesoInfo.Arguments = parametros;
                procesoInfo.UseShellExecute = false; 

                Process proceso = new Process();
                proceso.StartInfo = procesoInfo;
                proceso.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar el .exe: " + ex.Message);
            }
        }

        private void toolStripMenuItem14_Click(object sender, EventArgs e)
        {
            string param1 = comboBox1.SelectedItem?.ToString() ?? "";
            string parametros = ConstruirParametros13();
            string Argument = $"{param1}";
            EjecutarExe13(parametros + Argument);
        }

        private string ConstruirParametros13()
        {
            string parametros = "";
            if (checkBox1.Checked)
            {
                parametros += "chocolate-doom -merge wads/NESSUS.WAD -skill 1 -warp 07M ";
            }
            if (checkBox2.Checked)
            {
                parametros += "chocolate-doom -merge wads/NESSUS.WAD -skill 2 -warp 07M ";
            }
            if (checkBox3.Checked)
            {
                parametros += "chocolate-doom -merge wads/NESSUS.WAD -skill 3 -warp 07M ";
            }
            if (checkBox4.Checked)
            {
                parametros += "chocolate-doom -merge wads/NESSUS.WAD -skill 4 -warp 07M ";
            }
            if (checkBox5.Checked)
            {
                parametros += "chocolate-doom -merge wads/NESSUS.WAD -skill 5 -warp 07M ";
            }
            if (checkBox6.Checked)
            {
                parametros += "chocolate-doom -merge wads/NESSUS.WAD -fast -warp 07M ";
            }
            if (checkBox7.Checked)
            {
                parametros += "chocolate-doom -merge wads/NESSUS.WAD -nomonsters -warp 07M ";
            }
            if (checkBox8.Checked)
            {
                parametros += "chocolate-doom -merge wads/NESSUS.WAD -respawn -warp 07M ";
            }
           

            return parametros.Trim();
        }

        private void EjecutarExe13(string parametros)
        {
            try
            {
                ProcessStartInfo procesoInfo = new ProcessStartInfo();
                procesoInfo.FileName = "chocolate-doom.exe"; 
                procesoInfo.Arguments = parametros;
                procesoInfo.UseShellExecute = false; 

                Process proceso = new Process();
                proceso.StartInfo = procesoInfo;
                proceso.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar el .exe: " + ex.Message);
            }
        }

        private void toolStripMenuItem15_Click(object sender, EventArgs e)
        {
            string param1 = comboBox1.SelectedItem?.ToString() ?? "";
            string parametros = ConstruirParametros14();
            string Argument = $"{param1}";
            EjecutarExe14(parametros + Argument);
        }

        private string ConstruirParametros14()
        {
            string parametros = "";
            if (checkBox1.Checked)
            {
                parametros += "chocolate-doom -merge wads/PARADOX.WAD -skill 1 -warp 01M ";
            }
            if (checkBox2.Checked)
            {
                parametros += "chocolate-doom -merge wads/PARADOX.WAD -skill 2 -warp 01M ";
            }
            if (checkBox3.Checked)
            {
                parametros += "chocolate-doom -merge wads/PARADOX.WAD -skill 3 -warp 01M ";
            }
            if (checkBox4.Checked)
            {
                parametros += "chocolate-doom -merge wads/PARADOX.WAD -skill 4 -warp 01M ";
            }
            if (checkBox5.Checked)
            {
                parametros += "chocolate-doom -merge wads/PARADOX.WAD -skill 5 -warp 01M ";
            }
            if (checkBox6.Checked)
            {
                parametros += "chocolate-doom -merge wads/PARADOX.WAD -fast -warp 01M ";
            }
            if (checkBox7.Checked)
            {
                parametros += "chocolate-doom -merge wads/PARADOX.WAD -nomonsters -warp 01M ";
            }
            if (checkBox8.Checked)
            {
                parametros += "chocolate-doom -merge wads/PARADOX.WAD -respawn -warp 01M ";
            }
           

            return parametros.Trim();
        }

        private void EjecutarExe14(string parametros)
        {
            try
            {
                ProcessStartInfo procesoInfo = new ProcessStartInfo();
                procesoInfo.FileName = "chocolate-doom.exe"; 
                procesoInfo.Arguments = parametros;
                procesoInfo.UseShellExecute = false; 

                Process proceso = new Process();
                proceso.StartInfo = procesoInfo;
                proceso.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar el .exe: " + ex.Message);
            }
        }

        private void toolStripMenuItem16_Click(object sender, EventArgs e)
        {
            string param1 = comboBox1.SelectedItem?.ToString() ?? "";
            string parametros = ConstruirParametros15();
            string Argument = $"{param1}";
            EjecutarExe15(parametros + Argument);
        }

        private string ConstruirParametros15()
        {
            string parametros = "";
            if (checkBox1.Checked)
            {
                parametros += "chocolate-doom -merge wads/SUBSPACE.WAD -skill 1 -warp 01M ";
            }
            if (checkBox2.Checked)
            {
                parametros += "chocolate-doom -merge wads/SUBSPACE.WAD -skill 2 -warp 01M ";
            }
            if (checkBox3.Checked)
            {
                parametros += "chocolate-doom -merge wads/SUBSPACE.WAD -skill 3 -warp 01M ";
            }
            if (checkBox4.Checked)
            {
                parametros += "chocolate-doom -merge wads/SUBSPACE.WAD -skill 4 -warp 01M ";
            }
            if (checkBox5.Checked)
            {
                parametros += "chocolate-doom -merge wads/SUBSPACE.WAD -skill 5 -warp 01M ";
            }
            if (checkBox6.Checked)
            {
                parametros += "chocolate-doom -merge wads/SUBSPACE.WAD -fast -warp 01M ";
            }
            if (checkBox7.Checked)
            {
                parametros += "chocolate-doom -merge wads/SUBSPACE.WAD -nomonsters -warp 01M ";
            }
            if (checkBox8.Checked)
            {
                parametros += "chocolate-doom -merge wads/SUBSPACE.WAD -respawn -warp 01M ";
            }
          

            return parametros.Trim();
        }

        private void EjecutarExe15(string parametros)
        {
            try
            {
                ProcessStartInfo procesoInfo = new ProcessStartInfo();
                procesoInfo.FileName = "chocolate-doom.exe"; 
                procesoInfo.Arguments = parametros;
                procesoInfo.UseShellExecute = false; 

                Process proceso = new Process();
                proceso.StartInfo = procesoInfo;
                proceso.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar el .exe: " + ex.Message);
            }
        }

        private void toolStripMenuItem17_Click(object sender, EventArgs e)
        {
            string param1 = comboBox1.SelectedItem?.ToString() ?? "";
            string parametros = ConstruirParametros16();
            string Argument = $"{param1}";
            EjecutarExe16(parametros + Argument);
        }

        private string ConstruirParametros16()
        {
            string parametros = "";
            if (checkBox1.Checked)
            {
                parametros += "chocolate-doom -merge wads/SUBTERRA.WAD -skill 1 -warp 01M ";
            }
            if (checkBox2.Checked)
            {
                parametros += "chocolate-doom -merge wads/SUBTERRA.WAD -skill 2 -warp 01M ";
            }
            if (checkBox3.Checked)
            {
                parametros += "chocolate-doom -merge wads/SUBTERRA.WAD -skill 3 -warp 01M ";
            }
            if (checkBox4.Checked)
            {
                parametros += "chocolate-doom -merge wads/SUBTERRA.WAD -skill 4 -warp 01M ";
            }
            if (checkBox5.Checked)
            {
                parametros += "chocolate-doom -merge wads/SUBTERRA.WAD -skill 5 -warp 01M ";
            }
            if (checkBox6.Checked)
            {
                parametros += "chocolate-doom -merge wads/SUBTERRA.WAD -fast -warp 01M ";
            }
            if (checkBox7.Checked)
            {
                parametros += "chocolate-doom -merge wads/SUBTERRA.WAD -nomonsters -warp 01M ";
            }
            if (checkBox8.Checked)
            {
                parametros += "chocolate-doom -merge wads/SUBTERRA.WAD -respawn -warp 01M ";
            }
           

            return parametros.Trim();
        }

        private void EjecutarExe16(string parametros)
        {
            try
            {
                ProcessStartInfo procesoInfo = new ProcessStartInfo();
                procesoInfo.FileName = "chocolate-doom.exe"; 
                procesoInfo.Arguments = parametros;
                procesoInfo.UseShellExecute = false; 

                Process proceso = new Process();
                proceso.StartInfo = procesoInfo;
                proceso.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar el .exe: " + ex.Message);
            }
        }

        private void toolStripMenuItem18_Click(object sender, EventArgs e)
        {
            string param1 = comboBox1.SelectedItem?.ToString() ?? "";
            string parametros = ConstruirParametros17();
            string Argument = $"{param1}";
            EjecutarExe17(parametros + Argument);
        }

        private string ConstruirParametros17()
        {
            string parametros = "";
            if (checkBox1.Checked)
            {
                parametros += "chocolate-doom -merge wads/TEETH.WAD -skill 1 -warp 31M ";
            }
            if (checkBox2.Checked)
            {
                parametros += "chocolate-doom -merge wads/TEETH.WAD -skill 2 -warp 31M ";
            }
            if (checkBox3.Checked)
            {
                parametros += "chocolate-doom -merge wads/TEETH.WAD -skill 3 -warp 31M ";
            }
            if (checkBox4.Checked)
            {
                parametros += "chocolate-doom -merge wads/TEETH.WAD -skill 4 -warp 31M ";
            }
            if (checkBox5.Checked)
            {
                parametros += "chocolate-doom -merge wads/TEETH.WAD -skill 5 -warp 31M ";
            }
            if (checkBox6.Checked)
            {
                parametros += "chocolate-doom -merge wads/TEETH.WAD -fast -warp 31M ";
            }
            if (checkBox7.Checked)
            {
                parametros += "chocolate-doom -merge wads/TEETH.WAD -nomonsters -warp 31M ";
            }
            if (checkBox8.Checked)
            {
                parametros += "chocolate-doom -merge wads/TEETH.WAD -respawn -warp 31M ";
            }
           

            return parametros.Trim();
        }

        private void EjecutarExe17(string parametros)
        {
            try
            {
                ProcessStartInfo procesoInfo = new ProcessStartInfo();
                procesoInfo.FileName = "chocolate-doom.exe"; 
                procesoInfo.Arguments = parametros;
                procesoInfo.UseShellExecute = false; 

                Process proceso = new Process();
                proceso.StartInfo = procesoInfo;
                proceso.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar el .exe: " + ex.Message);
            }
        }

        private void toolStripMenuItem19_Click(object sender, EventArgs e)
        {
            string param1 = comboBox1.SelectedItem?.ToString() ?? "";
            string parametros = ConstruirParametros18();
            string Argument = $"{param1}";
            EjecutarExe18(parametros + Argument);
        }

        private string ConstruirParametros18()
        {
            string parametros = "";
            if (checkBox1.Checked)
            {
                parametros += "chocolate-doom -merge wads/TTRAP.WAD -skill 1 -warp 01M ";
            }
            if (checkBox2.Checked)
            {
                parametros += "chocolate-doom -merge wads/TTRAP.WAD -skill 2 -warp 01M ";
            }
            if (checkBox3.Checked)
            {
                parametros += "chocolate-doom -merge wads/TTRAP.WAD -skill 3 -warp 01M ";
            }
            if (checkBox4.Checked)
            {
                parametros += "chocolate-doom -merge wads/TTRAP.WAD -skill 4 -warp 01M ";
            }
            if (checkBox5.Checked)
            {
                parametros += "chocolate-doom -merge wads/TTRAP.WAD -skill 5 -warp 01M ";
            }
            if (checkBox6.Checked)
            {
                parametros += "chocolate-doom -merge wads/TTRAP.WAD -fast -warp 01M ";
            }
            if (checkBox7.Checked)
            {
                parametros += "chocolate-doom -merge wads/TTRAP.WAD -nomonsters -warp 01M ";
            }
            if (checkBox8.Checked)
            {
                parametros += "chocolate-doom -merge wads/TTRAP.WAD -respawn -warp 01M ";
            }
           

            return parametros.Trim();
        }

        private void EjecutarExe18(string parametros)
        {
            try
            {
                ProcessStartInfo procesoInfo = new ProcessStartInfo();
                procesoInfo.FileName = "chocolate-doom.exe"; 
                procesoInfo.Arguments = parametros;
                procesoInfo.UseShellExecute = false; 

                Process proceso = new Process();
                proceso.StartInfo = procesoInfo;
                proceso.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar el .exe: " + ex.Message);
            }
        }

        private void toolStripMenuItem20_Click(object sender, EventArgs e)
        {
            string param1 = comboBox1.SelectedItem?.ToString() ?? "";
            string parametros = ConstruirParametros19();
            string Argument = $"{param1}";
            EjecutarExe19(parametros + Argument);
        }

        private string ConstruirParametros19()
        {
            string parametros = "";
            if (checkBox1.Checked)
            {
                parametros += "chocolate-doom -merge wads/VESPERAS.WAD -skill 1 -warp 09M ";
            }
            if (checkBox2.Checked)
            {
                parametros += "chocolate-doom -merge wads/VESPERAS.WAD -skill 2 -warp 09M ";
            }
            if (checkBox3.Checked)
            {
                parametros += "chocolate-doom -merge wads/VESPERAS.WAD -skill 3 -warp 09M ";
            }
            if (checkBox4.Checked)
            {
                parametros += "chocolate-doom -merge wads/VESPERAS.WAD -skill 4 -warp 09M ";
            }
            if (checkBox5.Checked)
            {
                parametros += "chocolate-doom -merge wads/VESPERAS.WAD -skill 5 -warp 09M ";
            }
            if (checkBox6.Checked)
            {
                parametros += "chocolate-doom -merge wads/VESPERAS.WAD -fast -warp 09M ";
            }
            if (checkBox7.Checked)
            {
                parametros += "chocolate-doom -merge wads/VESPERAS.WAD -nomonsters -warp 09M ";
            }
            if (checkBox8.Checked)
            {
                parametros += "chocolate-doom -merge wads/VESPERAS.WAD -respawn -warp 09M ";
            }
            
            return parametros.Trim();
        }

        private void EjecutarExe19(string parametros)
        {
            try
            {
                ProcessStartInfo procesoInfo = new ProcessStartInfo();
                procesoInfo.FileName = "chocolate-doom.exe"; 
                procesoInfo.Arguments = parametros;
                procesoInfo.UseShellExecute = false; 

                Process proceso = new Process();
                proceso.StartInfo = procesoInfo;
                proceso.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar el .exe: " + ex.Message);
            }
        }

        private void toolStripMenuItem21_Click(object sender, EventArgs e)
        {
            string param1 = comboBox1.SelectedItem?.ToString() ?? "";
            string parametros = ConstruirParametros20();
            string Argument = $"{param1}";
            EjecutarExe20(parametros + Argument);
        }

        private string ConstruirParametros20()
        {
            string parametros = "";
            if (checkBox1.Checked)
            {
                parametros += "chocolate-doom -merge wads/VIRGIL.WAD -skill 1 -warp 03M ";
            }
            if (checkBox2.Checked)
            {
                parametros += "chocolate-doom -merge wads/VIRGIL.WAD -skill 2 -warp 03M ";
            }
            if (checkBox3.Checked)
            {
                parametros += "chocolate-doom -merge wads/VIRGIL.WAD -skill 3 -warp 03M ";
            }
            if (checkBox4.Checked)
            {
                parametros += "chocolate-doom -merge wads/VIRGIL.WAD -skill 4 -warp 03M ";
            }
            if (checkBox5.Checked)
            {
                parametros += "chocolate-doom -merge wads/VIRGIL.WAD -skill 5 -warp 03M ";
            }
            if (checkBox6.Checked)
            {
                parametros += "chocolate-doom -merge wads/VIRGIL.WAD -fast -warp 03M ";
            }
            if (checkBox7.Checked)
            {
                parametros += "chocolate-doom -merge wads/VIRGIL.WAD -nomonsters -warp 03M ";
            }
            if (checkBox8.Checked)
            {
                parametros += "chocolate-doom -merge wads/VIRGIL.WAD -respawn -warp 03M ";
            }
            

            return parametros.Trim();
        }

        private void EjecutarExe20(string parametros)
        {
            try
            {
                ProcessStartInfo procesoInfo = new ProcessStartInfo();
                procesoInfo.FileName = "chocolate-doom.exe"; 
                procesoInfo.Arguments = parametros;
                procesoInfo.UseShellExecute = false; 

                Process proceso = new Process();
                proceso.StartInfo = procesoInfo;
                proceso.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar el .exe: " + ex.Message);
            }
        }
        private void toolStripMenuItem2_MouseEnter(object sender, EventArgs e)
        {

            textBox2.Text = "Name: Attack";
            textBox3.Text = "Author: Tim Willits";
            textBox4.Text = "Level replaced: Map 01";
            

            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            pictureBox1.Image = imagen2;
        }

        private void toolStripMenuItem2_MouseLeave(object sender, EventArgs e)
        {

            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            pictureBox1.Image = imagen1;
        }

        private void toolStripMenuItem3_MouseEnter(object sender, EventArgs e)
        {
            textBox2.Text = "Name: Black Tower";
            textBox3.Text = "Author: Sverre Andre Kvernmo \"Cranium\"";
            textBox4.Text = "Level replaced: Map 25";
           
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            pictureBox1.Image = imagen4;

        }

        private void toolStripMenuItem3_MouseLeave(object sender, EventArgs e)
        {
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            pictureBox1.Image = imagen3;
        }

        private void toolStripMenuItem4_MouseEnter(object sender, EventArgs e)
        {

            textBox2.Text = "Name: Bloodsea Keep";
            textBox3.Text = "Author: Sverre Andre Kvernmo \"Cranium\"";
            textBox4.Text = "Level replaced: Map 07";
         

            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            pictureBox1.Image = imagen6;

        }

        private void toolStripMenuItem4_MouseLeave(object sender, EventArgs e)
        {
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            pictureBox1.Image = imagen5;
        }

        private void toolStripMenuItem5_MouseEnter(object sender, EventArgs e)
        {

            textBox2.Text = "Name: Canyon";
            textBox3.Text = "Author: Tim Willits";
            textBox4.Text = "Level replaced: Map 01";
           

            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            pictureBox1.Image = imagen8;
        }

        private void toolStripMenuItem5_MouseLeave(object sender, EventArgs e)
        {
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            pictureBox1.Image = imagen7;
        }

        private void toolStripMenuItem6_MouseEnter(object sender, EventArgs e)
        {
            textBox2.Text = "Name: The Catwalk";
            textBox3.Text = "Author: Christen David Klie";
            textBox4.Text = "Level replaced: Map 01";
         

            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            pictureBox1.Image = imagen10;
        }

        private void toolStripMenuItem6_MouseLeave(object sender, EventArgs e)
        {
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            pictureBox1.Image = imagen9;
        }

        private void toolStripMenuItem7_MouseEnter(object sender, EventArgs e)
        {
            textBox2.Text = "Name: The Combine";
            textBox3.Text = "Author: Christen David Klie";
            textBox4.Text = "Level replaced: Map 01";
         

            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            pictureBox1.Image = imagen12;
        }

        private void toolStripMenuItem7_MouseLeave(object sender, EventArgs e)
        {
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            pictureBox1.Image = imagen11;
        }

        private void toolStripMenuItem8_MouseEnter(object sender, EventArgs e)
        {
            textBox2.Text = "Name: The Fistula";
            textBox3.Text = "Author: Christen David Klie";
            textBox4.Text = "Level replaced: Map 01";
           

            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            pictureBox1.Image = imagen14;
        }

        private void toolStripMenuItem8_MouseLeave(object sender, EventArgs e)
        {
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            pictureBox1.Image = imagen13;
        }

        private void toolStripMenuItem9_MouseEnter(object sender, EventArgs e)
        {
            textBox2.Text = "Name: The Garrison";
            textBox3.Text = "Author: Christen David Klie";
            textBox4.Text = "Level replaced: Map 01";
          
            
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            pictureBox1.Image = imagen16;
        }

        private void toolStripMenuItem9_MouseLeave(object sender, EventArgs e)
        {
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            pictureBox1.Image = imagen15;
        }

        private void toolStripMenuItem10_MouseEnter(object sender, EventArgs e)
        {
            textBox2.Text = "Name: Geryon";
            textBox3.Text = "Author: John W. Anderson \" Dr Sleep\"";
            textBox4.Text = "Level replaced: Map 08";
         

            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            pictureBox1.Image = imagen18;
        }

        private void toolStripMenuItem10_MouseLeave(object sender, EventArgs e)
        {
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            pictureBox1.Image = imagen17;
        }

        private void toolStripMenuItem11_MouseEnter(object sender, EventArgs e)
        {
            textBox2.Text = "Name: Titan Manor";
            textBox3.Text = "Author: Jim Flynn";
            textBox4.Text = "Level replaced: Map 01";
           

            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            pictureBox1.Image = imagen20;
        }

        private void toolStripMenuItem11_MouseLeave(object sender, EventArgs e)
        {
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            pictureBox1.Image = imagen19;
        }

        private void toolStripMenuItem12_MouseEnter(object sender, EventArgs e)
        {
            textBox2.Text = "Name: Mephisto's Maosoleum";
            textBox3.Text = "Author: Sverre Andre Kvernmo \"Cranium\"";
            textBox4.Text = "Level replaced: Map 07";
        

            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            pictureBox1.Image = imagen22;


        }

        private void toolStripMenuItem12_MouseLeave(object sender, EventArgs e)
        {
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            pictureBox1.Image = imagen21;
        }

        private void toolStripMenuItem13_MouseEnter(object sender, EventArgs e)
        {
            textBox2.Text = "Name: Minos' Judgement";
            textBox3.Text = "Author: John W. Anderson \" Dr Sleep\"";
            textBox4.Text = "Level replaced: Map 05";
          

            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            pictureBox1.Image = imagen24;
        }

        private void toolStripMenuItem13_MouseLeave(object sender, EventArgs e)
        {
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            pictureBox1.Image = imagen23;
        }

        private void toolStripMenuItem14_MouseEnter(object sender, EventArgs e)
        {
            textBox2.Text = "Name: Nessus";
            textBox3.Text = "Author: John W. Anderson \" Dr Sleep\"";
            textBox4.Text = "Level replaced: Map 07";
         

            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            pictureBox1.Image = imagen26;

        }

        private void toolStripMenuItem14_MouseLeave(object sender, EventArgs e)
        {
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            pictureBox1.Image = imagen25;
        }

        private void toolStripMenuItem15_MouseEnter(object sender, EventArgs e)
        {
            textBox2.Text = "Name: Paradox";
            textBox3.Text = "Author: Tom Mustaine";
            textBox4.Text = "Level replaced: Map 01";
       

            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            pictureBox1.Image = imagen28;

        }

        private void toolStripMenuItem15_MouseLeave(object sender, EventArgs e)
        {
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            pictureBox1.Image = imagen27;


        }

        private void toolStripMenuItem16_MouseEnter(object sender, EventArgs e)
        {
            textBox2.Text = "Name: Subspace";
            textBox3.Text = "Author: Christen David Klie";
            textBox4.Text = "Level replaced: Map 01";
       

            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            pictureBox1.Image = imagen30;


        }

        private void toolStripMenuItem16_MouseLeave(object sender, EventArgs e)
        {
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            pictureBox1.Image = imagen29;


        }

        private void toolStripMenuItem17_MouseEnter(object sender, EventArgs e)
        {
            textBox2.Text = "Name: Subterra";
            textBox3.Text = "Author: Christen David Klie";
            textBox4.Text = "Level replaced: Map 01";
       

            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            pictureBox1.Image = imagen32;

        }

        private void toolStripMenuItem17_MouseLeave(object sender, EventArgs e)
        {
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            pictureBox1.Image = imagen31;

        }

        private void toolStripMenuItem18_MouseEnter(object sender, EventArgs e)
        {
            textBox2.Text = "Name: The Express Elevator to Hell";
            textBox3.Text = "Author: Sverre Andre Kvernmo \"Cranium\"";
            textBox4.Text = "Level replaced: Map 31 and 32";
         

            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            pictureBox1.Image = imagen34;

        }

        private void toolStripMenuItem18_MouseLeave(object sender, EventArgs e)
        {
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            pictureBox1.Image = imagen33;
        }

        private void toolStripMenuItem19_MouseEnter(object sender, EventArgs e)
        {
            textBox2.Text = "Name: Trapped on Titan";
            textBox3.Text = "Author: Jim Flynn";
            textBox4.Text = "Level replaced: Map 01";
       

            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            pictureBox1.Image = imagen36;


        }

        private void toolStripMenuItem19_MouseLeave(object sender, EventArgs e)
        {
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            pictureBox1.Image = imagen35;


        }

        private void toolStripMenuItem20_MouseEnter(object sender, EventArgs e)
        {
            textBox2.Text = "Name: Vesperas";
            textBox3.Text = "Author: John W. Anderson \"Dr. Sleep\"";
            textBox4.Text = "Level replaced: Map 09";
         

            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            pictureBox1.Image = imagen38;


        }

        private void toolStripMenuItem20_MouseLeave(object sender, EventArgs e)
        {
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            pictureBox1.Image = imagen37;


        }

        private void toolStripMenuItem21_MouseEnter(object sender, EventArgs e)
        {
            textBox2.Text = "Name: Virgil's lead";
            textBox3.Text = "Author: John W. Anderson \"Dr. Sleep\"";
            textBox4.Text = "Level replaced: Map 03";
        

            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            pictureBox1.Image = imagen40;


        }

        private void toolStripMenuItem21_MouseLeave(object sender, EventArgs e)
        {
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            pictureBox1.Image = imagen39;


        }

          private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add(new Item(" -turbo 10x%", "10"));
            comboBox1.Items.Add(new Item(" -turbo 20x%", "20"));
            comboBox1.Items.Add(new Item(" -turbo 30x%", "30"));
            comboBox1.Items.Add(new Item(" -turbo 40x%", "40"));
            comboBox1.Items.Add(new Item(" -turbo 50x%", "50"));
            comboBox1.Items.Add(new Item(" -turbo 60x%", "60"));
            comboBox1.Items.Add(new Item(" -turbo 70x%", "70"));
            comboBox1.Items.Add(new Item(" -turbo 80x%", "80"));
            comboBox1.Items.Add(new Item(" -turbo 90x%", "90"));
            comboBox1.Items.Add(new Item(" -turbo 100x%", "100"));
            comboBox1.Items.Add(new Item(" -turbo 110x%", "110"));
            comboBox1.Items.Add(new Item(" -turbo 120x%", "120"));
            comboBox1.Items.Add(new Item(" -turbo 130x%", "130"));
            comboBox1.Items.Add(new Item(" -turbo 140x%", "140"));
            comboBox1.Items.Add(new Item(" -turbo 150x%", "150"));
            comboBox1.Items.Add(new Item(" -turbo 160x%", "160"));
            comboBox1.Items.Add(new Item(" -turbo 170x%", "170"));
            comboBox1.Items.Add(new Item(" -turbo 180x%", "180"));
            comboBox1.Items.Add(new Item(" -turbo 190x%", "190"));
            comboBox1.Items.Add(new Item(" -turbo 200x%", "200"));
            comboBox1.Items.Add(new Item(" -turbo 210x%", "210"));
            comboBox1.Items.Add(new Item(" -turbo 220x%", "220"));
            comboBox1.Items.Add(new Item(" -turbo 230x%", "230"));
            comboBox1.Items.Add(new Item(" -turbo 240x%", "240"));
            comboBox1.Items.Add(new Item(" -turbo 250x%", "250"));
            comboBox1.Items.Add(new Item(" -turbo 260x%", "260"));
            comboBox1.Items.Add(new Item(" -turbo 270x%", "270"));
            comboBox1.Items.Add(new Item(" -turbo 280x%", "280"));
            comboBox1.Items.Add(new Item(" -turbo 290x%", "290"));
            comboBox1.Items.Add(new Item(" -turbo 300x%", "300"));
            comboBox1.Items.Add(new Item(" -turbo 310x%", "310"));
            comboBox1.Items.Add(new Item(" -turbo 320x%", "320"));
            comboBox1.Items.Add(new Item(" -turbo 330x%", "330"));
            comboBox1.Items.Add(new Item(" -turbo 340x%", "340"));
            comboBox1.Items.Add(new Item(" -turbo 350x%", "350"));
            comboBox1.Items.Add(new Item(" -turbo 360x%", "360"));
            comboBox1.Items.Add(new Item(" -turbo 370x%", "370"));
            comboBox1.Items.Add(new Item(" -turbo 380x%", "380"));
            comboBox1.Items.Add(new Item(" -turbo 390x%", "390"));
            comboBox1.Items.Add(new Item(" -turbo 400x%", "400"));
            comboBox2.Items.Add(new Item("-skill 1", " I'm too young to die"));
            comboBox2.Items.Add(new Item("-skill 2", "Hey, not too rough"));
            comboBox2.Items.Add(new Item("-skill 3", "Hurt me plenty"));
            comboBox2.Items.Add(new Item("-skill 4", "Ultra-Violence"));
            comboBox2.Items.Add(new Item("-skill 5", "Nightmare!"));
            comboBox3.Items.Add(new Item(" -iwad DOOM.WAD", "The Ultimate Doom"));
            comboBox3.Items.Add(new Item(" -IWAD DOOM2.WAD", "Doom II: Hell on Earth"));
            comboBox3.Items.Add(new Item(" -IWAD TNT.WAD", "Final Doom: TNT Evilution"));
            comboBox3.Items.Add(new Item(" -IWAD PLUTONIA.WAD -file plutmidi.wad", "Final Doom: Plutonia Experiment"));
            comboBox4.Items.Add(new Item(" -file mods/ICARUS.WAD", "Icarus Alien Vanguard (for Doom II)"));
            comboBox4.Items.Add(new Item(" -merge mods/HR.WAD -file mods/HRMUS.WAD", "Hell Revealed (for Doom II)"));
            comboBox4.Items.Add(new Item(" -file mods/BTSX_E1.wad ", "Back to Saturn X (for Doom II)"));
            comboBox4.Items.Add(new Item(" -file mods/AV.WAD", "Alien Vendetta (for Doom ii)"));
            comboBox4.Items.Add(new Item(" -file mods/D2RELOAD.WAD", "Doom II: Reloaded (for Doom II)"));
            comboBox4.Items.Add(new Item(" -merge mods/TVR!.WAD -file mods/tvr!midi.wad", "Revolution! (for Doom II)"));
            comboBox4.Items.Add(new Item(" -merge mods/REQUIEM.WAD -file mods/REQMUS.WAD", "Requien (for Doom II)"));
            comboBox4.Items.Add(new Item(" -file mods/50monstr.wad", "50 Monsters (for Doom II)"));
            comboBox4.Items.Add(new Item(" -file mods/akeldama.wad", "Akeldama (for Doom II)"));
            comboBox4.Items.Add(new Item(" -file mods/AR.wad", "Anomaly Report (for Doom II)"));
            comboBox4.Items.Add(new Item(" -file mods/CPHOBOS5.WAD", "Castle Phobos (for Doom II)"));
            comboBox4.Items.Add(new Item(" -file mods/CYGNUSIV.WAD", "Cygnus IV - Version 2.0 (for Doom II)"));
            comboBox4.Items.Add(new Item(" -file mods/AZGTHTH4.wad", "Azagthoth (for Doom II)"));
            comboBox4.Items.Add(new Item(" -file mods/DCV.wad", "Doom core (for Doom II)"));
            comboBox4.Items.Add(new Item(" -merge mods/DRN.wad -file mods/DRN_MUS.wad", "Down the Drain (for Doom II)"));
            comboBox4.Items.Add(new Item(" -file mods/intercep.wad", "Interception (for Doom II)"));
            comboBox4.Items.Add(new Item(" -file mods/INVASIO2.WAD", "Invasion II (for Doom II)"));
            comboBox4.Items.Add(new Item(" -file mods/WORLD.WAD", "The World of Deth: From Heaven To Hell (for Doom II)"));
            comboBox4.Items.Add(new Item(" -file mods/MARSW301.WAD", "Mars War V3.01 (for Doom II)"));
            comboBox4.Items.Add(new Item(" -file mods/RetroEps.wad", "CH Retro Episode (for Ultimate Doom)"));
            comboBox4.Items.Add(new Item(" -file mods/Class_Ep.wad", "The Classic Episode (episode 2 for Ultimate Doom)"));
            comboBox4.Items.Add(new Item(" -file mods/TEUTIC.WAD", "The Evil Unleashed (episode 3 for Ultimate Doom)"));
            comboBox4.Items.Add(new Item(" -file mods/pd1-anom.wad", "PhobosDeimos Anomaly (for Ultimate Doom)"));
            comboBox4.Items.Add(new Item(" -file mods/RETURN01.WAD", "Return to Phobos (for Ultimate Doom)"));
            comboBox4.Items.Add(new Item("  -merge mods/SERENITY.WAD -file mods/SERMUSIC.WAD ", "SERENITY v2.01 (episode 3 for Ultimate Doom)"));
            comboBox5.Items.Add(new Item(" -warp 01M", "Map 1"));
            comboBox5.Items.Add(new Item(" -warp 02M", "Map 2"));
            comboBox5.Items.Add(new Item(" -warp 03M", "Map 3"));
            comboBox5.Items.Add(new Item(" -warp 04M", "Map 4"));
            comboBox5.Items.Add(new Item(" -warp 05M", "Map 5"));
            comboBox5.Items.Add(new Item(" -warp 06M", "Map 6"));
            comboBox5.Items.Add(new Item(" -warp 07M", "Map 7"));
            comboBox5.Items.Add(new Item(" -warp 08M", "Map 8"));
            comboBox5.Items.Add(new Item(" -warp 09M", "Map 9"));
            comboBox5.Items.Add(new Item(" -warp 10M", "Map 10"));
            comboBox5.Items.Add(new Item(" -warp 11M", "Map 11"));
            comboBox5.Items.Add(new Item(" -warp 12M", "Map 12"));
            comboBox5.Items.Add(new Item(" -warp 13M", "Map 13"));
            comboBox5.Items.Add(new Item(" -warp 14M", "Map 14"));
            comboBox5.Items.Add(new Item(" -warp 15M", "Map 15"));
            comboBox5.Items.Add(new Item(" -warp 16M", "Map 16"));
            comboBox5.Items.Add(new Item(" -warp 17M", "Map 17"));
            comboBox5.Items.Add(new Item(" -warp 18M", "Map 18"));
            comboBox5.Items.Add(new Item(" -warp 19M", "Map 19"));
            comboBox5.Items.Add(new Item(" -warp 20M", "Map 20"));
            comboBox5.Items.Add(new Item(" -warp 21M", "Map 21"));
            comboBox5.Items.Add(new Item(" -warp 22M", "Map 22"));
            comboBox5.Items.Add(new Item(" -warp 23M", "Map 23"));
            comboBox5.Items.Add(new Item(" -warp 24M", "Map 24"));
            comboBox5.Items.Add(new Item(" -warp 25M", "Map 25"));
            comboBox5.Items.Add(new Item(" -warp 26M", "Map 26"));
            comboBox5.Items.Add(new Item(" -warp 27M", "Map 27"));
            comboBox5.Items.Add(new Item(" -warp 28M", "Map 28"));
            comboBox5.Items.Add(new Item(" -warp 29M", "Map 29"));
            comboBox5.Items.Add(new Item(" -warp 30M", "Map 30"));
            comboBox5.Items.Add(new Item(" -warp 31M", "Map 31"));
            comboBox5.Items.Add(new Item(" -warp 32M", "Map 32"));
            comboBox6.Items.Add(new Item(" -warp 1 1", "E1M1"));
            comboBox6.Items.Add(new Item(" -warp 1 2", "E1M2"));
            comboBox6.Items.Add(new Item(" -warp 1 3", "E1M3"));
            comboBox6.Items.Add(new Item(" -warp 1 4", "E1M4"));
            comboBox6.Items.Add(new Item(" -warp 1 5", "E1M5"));
            comboBox6.Items.Add(new Item(" -warp 1 6", "E1M6"));
            comboBox6.Items.Add(new Item(" -warp 1 7", "E1M7"));
            comboBox6.Items.Add(new Item(" -warp 1 8", "E1M8"));
            comboBox6.Items.Add(new Item(" -warp 1 9", "E1M9"));
            comboBox6.Items.Add(new Item(" -warp 2 1", "E2M1"));
            comboBox6.Items.Add(new Item(" -warp 2 2", "E2M2"));
            comboBox6.Items.Add(new Item(" -warp 2 3", "E2M3"));
            comboBox6.Items.Add(new Item(" -warp 2 4", "E2M4"));
            comboBox6.Items.Add(new Item(" -warp 2 5", "E2M5"));
            comboBox6.Items.Add(new Item(" -warp 2 6", "E2M6"));
            comboBox6.Items.Add(new Item(" -warp 2 7", "E2M7"));
            comboBox6.Items.Add(new Item(" -warp 2 8", "E2M8"));
            comboBox6.Items.Add(new Item(" -warp 2 9", "E2M9"));
            comboBox6.Items.Add(new Item(" -warp 3 1", "E3M1"));
            comboBox6.Items.Add(new Item(" -warp 3 2", "E3M2"));
            comboBox6.Items.Add(new Item(" -warp 3 3", "E3M3"));
            comboBox6.Items.Add(new Item(" -warp 3 4", "E3M4"));
            comboBox6.Items.Add(new Item(" -warp 3 5", "E3M5"));
            comboBox6.Items.Add(new Item(" -warp 3 6", "E3M6"));
            comboBox6.Items.Add(new Item(" -warp 3 7", "E3M7"));
            comboBox6.Items.Add(new Item(" -warp 3 8", "E3M8"));
            comboBox6.Items.Add(new Item(" -warp 3 9", "E3M9"));
            comboBox6.Items.Add(new Item(" -warp 4 1", "E4M1"));
            comboBox6.Items.Add(new Item(" -warp 4 2", "E4M2"));
            comboBox6.Items.Add(new Item(" -warp 4 3", "E4M3"));
            comboBox6.Items.Add(new Item(" -warp 4 4", "E4M4"));
            comboBox6.Items.Add(new Item(" -warp 4 5", "E4M5"));
            comboBox6.Items.Add(new Item(" -warp 4 6", "E4M6"));
            comboBox6.Items.Add(new Item(" -warp 4 7", "E4M7"));
            comboBox6.Items.Add(new Item(" -warp 4 8", "E4M8"));
            comboBox6.Items.Add(new Item(" -warp 4 9", "E4M9"));
            comboBox7.Items.Add(new Item(" -turbo 10x%", "10"));
            comboBox7.Items.Add(new Item(" -turbo 20x%", "20"));
            comboBox7.Items.Add(new Item(" -turbo 30x%", "30"));
            comboBox7.Items.Add(new Item(" -turbo 40x%", "40"));
            comboBox7.Items.Add(new Item(" -turbo 50x%", "50"));
            comboBox7.Items.Add(new Item(" -turbo 60x%", "60"));
            comboBox7.Items.Add(new Item(" -turbo 70x%", "70"));
            comboBox7.Items.Add(new Item(" -turbo 80x%", "80"));
            comboBox7.Items.Add(new Item(" -turbo 90x%", "90"));
            comboBox7.Items.Add(new Item(" -turbo 100x%", "100"));
            comboBox7.Items.Add(new Item(" -turbo 110x%", "110"));
            comboBox7.Items.Add(new Item(" -turbo 120x%", "120"));
            comboBox7.Items.Add(new Item(" -turbo 130x%", "130"));
            comboBox7.Items.Add(new Item(" -turbo 140x%", "140"));
            comboBox7.Items.Add(new Item(" -turbo 150x%", "150"));
            comboBox7.Items.Add(new Item(" -turbo 160x%", "160"));
            comboBox7.Items.Add(new Item(" -turbo 170x%", "170"));
            comboBox7.Items.Add(new Item(" -turbo 180x%", "180"));
            comboBox7.Items.Add(new Item(" -turbo 190x%", "190"));
            comboBox7.Items.Add(new Item(" -turbo 200x%", "200"));
            comboBox7.Items.Add(new Item(" -turbo 210x%", "210"));
            comboBox7.Items.Add(new Item(" -turbo 220x%", "220"));
            comboBox7.Items.Add(new Item(" -turbo 230x%", "230"));
            comboBox7.Items.Add(new Item(" -turbo 240x%", "240"));
            comboBox7.Items.Add(new Item(" -turbo 250x%", "250"));
            comboBox7.Items.Add(new Item(" -turbo 260x%", "260"));
            comboBox7.Items.Add(new Item(" -turbo 270x%", "270"));
            comboBox7.Items.Add(new Item(" -turbo 280x%", "280"));
            comboBox7.Items.Add(new Item(" -turbo 290x%", "290"));
            comboBox7.Items.Add(new Item(" -turbo 300x%", "300"));
            comboBox7.Items.Add(new Item(" -turbo 310x%", "310"));
            comboBox7.Items.Add(new Item(" -turbo 320x%", "320"));
            comboBox7.Items.Add(new Item(" -turbo 330x%", "330"));
            comboBox7.Items.Add(new Item(" -turbo 340x%", "340"));
            comboBox7.Items.Add(new Item(" -turbo 350x%", "350"));
            comboBox7.Items.Add(new Item(" -turbo 360x%", "360"));
            comboBox7.Items.Add(new Item(" -turbo 370x%", "370"));
            comboBox7.Items.Add(new Item(" -turbo 380x%", "380"));
            comboBox7.Items.Add(new Item(" -turbo 390x%", "390"));
            comboBox7.Items.Add(new Item(" -turbo 400x%", "400"));






            comboBox1.DisplayMember = "value";
            comboBox2.DisplayMember = "value";
            comboBox3.DisplayMember = "value";
            comboBox4.DisplayMember = "value";
            comboBox5.DisplayMember = "value";
            comboBox6.DisplayMember = "value";
            comboBox7.DisplayMember = "value";
            comboBox2.SelectedIndex = 2;
            comboBox3.SelectedIndex = 1;


            this.comboBox1.Enabled = false;
            this.comboBox7.Enabled = false;
            this.comboBox5.Enabled = false;
            this.comboBox6.Enabled = false;


        }

        private string ConstruirParametros22()
        {
            string parametros2 = "";
            if (checkBox10.Checked)
            {
                parametros2 += "chocolate-doom -respawn ";
            }
            if (checkBox11.Checked)
            {
                parametros2 += "chocolate-doom -fast ";
            }
            if (checkBox12.Checked)
            {
                parametros2 += "chocolate-doom -nomonsters ";
            }


            return parametros2.Trim();

        }



            private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            this.comboBox1.Enabled = checkBox9.Checked;
                comboBox1.SelectedIndex = -1;
                checkBox7.Checked = false;


        }

        
        
        
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox2.Checked = false;
            }

            if (checkBox1.Checked)
            {
                checkBox3.Checked = false;
            }
            if (checkBox1.Checked)
            {
                checkBox4.Checked = false;
            }
            if (checkBox1.Checked)
            {
                checkBox5.Checked = false;
            }
            if (checkBox1.Checked)
            {
                checkBox7.Checked = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox1.Checked = false;
            }

            if (checkBox2.Checked)
            {
                checkBox3.Checked = false;
            }
            if (checkBox2.Checked)
            {
                checkBox4.Checked = false;
            }
            if (checkBox2.Checked)
            {
                checkBox5.Checked = false;
            }
            if (checkBox2.Checked)
            {
                checkBox7.Checked = false;
            }


        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                checkBox1.Checked = false;
            }

            if (checkBox3.Checked)
            {
                checkBox2.Checked = false;
            }
            if (checkBox3.Checked)
            {
                checkBox4.Checked = false;
            }
            if (checkBox3.Checked)
            {
                checkBox5.Checked = false;
            }
            if (checkBox3.Checked)
            {
                checkBox7.Checked = false;
            }


        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                checkBox1.Checked = false;
            }

            if (checkBox4.Checked)
            {
                checkBox2.Checked = false;
            }
            if (checkBox4.Checked)
            {
                checkBox3.Checked = false;
            }
            if (checkBox4.Checked)
            {
                checkBox5.Checked = false;
            }
            if (checkBox4.Checked)
            {
                checkBox7.Checked = false;
            }

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                checkBox1.Checked = false;
            }

            if (checkBox5.Checked)
            {
                checkBox2.Checked = false;
            }
            if (checkBox5.Checked)
            {
                checkBox3.Checked = false;
            }
            if (checkBox5.Checked)
            {
                checkBox4.Checked = false;
            }
            if (checkBox5.Checked)
            {
                checkBox7.Checked = false;
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked)
            {
                checkBox6.Checked = false;
            }

            if (checkBox7.Checked)
            {
                checkBox8.Checked = false;
            }
            if (checkBox7.Checked)
            {
                checkBox9.Checked = false;
            }
            if (checkBox7.Checked)
            {
                checkBox1.Checked = false;
            }
            if (checkBox7.Checked)
            {
                checkBox2.Checked = false;
            }
            if (checkBox7.Checked)
            {
                checkBox3.Checked = false;
            }
            if (checkBox7.Checked)
            {
                checkBox4.Checked = false;
            }
            if (checkBox7.Checked)
            {
                checkBox5.Checked = false;
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox6.Checked)
            {
                checkBox7.Checked = false;
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox8.Checked)
            {
                checkBox7.Checked = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string parametros2 = ConstruirParametros22();
            string param2 = comboBox2.SelectedItem?.ToString() ?? "";
            string param3 = comboBox3.SelectedItem?.ToString() ?? "";
            string param4 = comboBox4.SelectedItem?.ToString() ?? "";
            string param5 = comboBox5.SelectedItem?.ToString() ?? "";
            string param6 = comboBox6.SelectedItem?.ToString() ?? "";
            string param7 = comboBox7.SelectedItem?.ToString() ?? "";
            string Argument2 = $"{param2} {param3} {param4} {param5} {param6} {param7}"; 



            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "chocolate-doom.exe", 
                Arguments = Argument2 + parametros2,
                UseShellExecute = false,
                RedirectStandardOutput = true, 
                CreateNoWindow = true 

            };

            try
            {
                using (Process process = Process.Start(psi))
                {
                    string output = process.StandardOutput.ReadToEnd();
                    process.WaitForExit();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar el proceso: " + ex.Message);
            }
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            comboBox2.Enabled = !checkBox16.Checked;
            comboBox2.SelectedIndex = -1;
            comboBox5.SelectedIndex = -1;
            comboBox6.SelectedIndex = -1;
            comboBox7.SelectedIndex = -1;
          ;
            checkBox14.Checked = false;
            checkBox15.Checked = false;
            checkBox10.Checked = false;
            checkBox11.Checked = false;
            checkBox12.Checked = false;
            checkBox13.Checked = false;
            checkBox1.Checked =  false;
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            this.comboBox5.Enabled = checkBox14.Checked;
            comboBox5.SelectedIndex = -1;
            checkBox15.Checked = false;
            checkBox16.Checked = false;
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            this.comboBox6.Enabled = checkBox15.Checked;
            comboBox6.SelectedIndex = -1;
            checkBox14.Checked = false;
            checkBox16.Checked = false;
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            this.comboBox7.Enabled = checkBox13.Checked;
            comboBox7.SelectedIndex = -1;
            checkBox12.Checked = false;
            checkBox16.Checked = false;
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            checkBox12.Checked = false;
            checkBox16.Checked = false;
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            checkBox12.Checked = false;
            checkBox16.Checked = false;
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            checkBox11.Checked = false;
            checkBox13.Checked = false;
            checkBox16.Checked = false;
            checkBox10.Checked = false;
            comboBox2.Enabled = !checkBox12.Checked;
            comboBox2.SelectedIndex = -1;
            comboBox5.SelectedIndex = -1;
            comboBox6.SelectedIndex = -1;
            comboBox7.SelectedIndex = -1;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem23_Click(object sender, EventArgs e)
        {
            
            string chocolateDoomPath = "chocolate-doom.exe";

          
            string wadResourceName = "experimento.D_RUNNIN.WAD";

            string param1 = comboBox1.SelectedItem?.ToString() ?? "";
            string Argument = $"{param1}";
            string tempWadPath = Path.Combine(Path.GetTempPath(), "D_RUNNIN.WAD");
            string parametros = ConstruirParametros();


            using (Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(wadResourceName))
            {
                if (stream != null)
                {
                    using (FileStream fileStream = new FileStream(tempWadPath, FileMode.Create, FileAccess.Write))
                    {
                        stream.CopyTo(fileStream);
                    }
                }
                else
                {
                    MessageBox.Show("No se pudo encontrar el recurso WAD.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }


           
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = chocolateDoomPath;
            startInfo.Arguments = $" -file \"{tempWadPath}\" {parametros}  {Argument} "; 

            startInfo.UseShellExecute = false; 
            startInfo.CreateNoWindow = true; 

            try
            {
                
                Process.Start(startInfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al iniciar Chocolate Doom: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void toolStripMenuItem24_Click(object sender, EventArgs e)
        {
           
            string chocolateDoomPath = "chocolate-doom.exe";

           
            string wadResourceName = "experimento.D_SHAWN2.WAD"; 

            string param1 = comboBox1.SelectedItem?.ToString() ?? "";
            string Argument = $"{param1}";
            string tempWadPath = Path.Combine(Path.GetTempPath(), "D_SHAWN2.WAD");
            string parametros = ConstruirParametros2();


            using (Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(wadResourceName))
            {
                if (stream != null)
                {
                    using (FileStream fileStream = new FileStream(tempWadPath, FileMode.Create, FileAccess.Write))
                    {
                        stream.CopyTo(fileStream);
                    }
                }
                else
                {
                    MessageBox.Show("No se pudo encontrar el recurso WAD.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }


           
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = chocolateDoomPath;
            startInfo.Arguments = $" -file \"{tempWadPath}\" {parametros} {Argument} ";   

            startInfo.UseShellExecute = false; 
            startInfo.CreateNoWindow = true; 

            try
            {
                
                Process.Start(startInfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al iniciar Chocolate Doom: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripMenuItem25_Click(object sender, EventArgs e)
        {
           
            string chocolateDoomPath = "chocolate-doom.exe";

            
            string wadResourceName = "experimento.D_DDTBL2.WAD";


            string param1 = comboBox1.SelectedItem?.ToString() ?? "";
            string Argument = $"{param1}";
            string tempWadPath = Path.Combine(Path.GetTempPath(), "D_DDTBL2.WAD");
            string parametros = ConstruirParametros3();


            using (Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(wadResourceName))
            {
                if (stream != null)
                {
                    using (FileStream fileStream = new FileStream(tempWadPath, FileMode.Create, FileAccess.Write))
                    {
                        stream.CopyTo(fileStream);
                    }
                }
                else
                {
                    MessageBox.Show("No se pudo encontrar el recurso WAD.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }


           
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = chocolateDoomPath;
            startInfo.Arguments = $" -file \"{tempWadPath}\" {parametros}  {Argument}";  

            startInfo.UseShellExecute = false; 
            startInfo.CreateNoWindow = true; 

            try
            {
                
                Process.Start(startInfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al iniciar Chocolate Doom: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripMenuItem26_Click(object sender, EventArgs e)
        {
            
            string chocolateDoomPath = "chocolate-doom.exe";

            
            string wadResourceName = "experimento.D_STALKS.WAD"; 


            string param1 = comboBox1.SelectedItem?.ToString() ?? "";
            string Argument = $"{param1}";
            string tempWadPath = Path.Combine(Path.GetTempPath(), "D_STALKS.WAD");
            string parametros = ConstruirParametros4();


            using (Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(wadResourceName))
            {
                if (stream != null)
                {
                    using (FileStream fileStream = new FileStream(tempWadPath, FileMode.Create, FileAccess.Write))
                    {
                        stream.CopyTo(fileStream);
                    }
                }
                else
                {
                    MessageBox.Show("No se pudo encontrar el recurso WAD.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }


            
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = chocolateDoomPath;
            startInfo.Arguments = $" -file \"{tempWadPath}\" {parametros}  {Argument}"; 

            startInfo.UseShellExecute = false; 
            startInfo.CreateNoWindow = true; 

            try
            {
                
                Process.Start(startInfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al iniciar Chocolate Doom: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripMenuItem27_Click(object sender, EventArgs e)
        {
            
            string chocolateDoomPath = "chocolate-doom.exe";

            
            string wadResourceName = "experimento.D_COUNTD.WAD"; 


            string param1 = comboBox1.SelectedItem?.ToString() ?? "";
            string Argument = $"{param1}";
            string tempWadPath = Path.Combine(Path.GetTempPath(), "D_COUNTD.WAD");
            string parametros = ConstruirParametros5();


            using (Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(wadResourceName))
            {
                if (stream != null)
                {
                    using (FileStream fileStream = new FileStream(tempWadPath, FileMode.Create, FileAccess.Write))
                    {
                        stream.CopyTo(fileStream);
                    }
                }
                else
                {
                    MessageBox.Show("No se pudo encontrar el recurso WAD.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }


           
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = chocolateDoomPath;
            startInfo.Arguments = $" -file \"{tempWadPath}\" {parametros}  {Argument}";  
            startInfo.UseShellExecute = false; 
            startInfo.CreateNoWindow = true; 

            try
            {
                
                Process.Start(startInfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al iniciar Chocolate Doom: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }

        private void toolStripMenuItem28_Click(object sender, EventArgs e)
        {
            
            string chocolateDoomPath = "chocolate-doom.exe";

            
            string wadResourceName = "experimento.D_BETWEE.WAD"; // Cambia el nombre del espacio de nombres y del archivo


            string param1 = comboBox1.SelectedItem?.ToString() ?? "";
            string Argument = $"{param1}";
            string tempWadPath = Path.Combine(Path.GetTempPath(), "D_BETWEE.WAD");
            string parametros = ConstruirParametros6();


            using (Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(wadResourceName))
            {
                if (stream != null)
                {
                    using (FileStream fileStream = new FileStream(tempWadPath, FileMode.Create, FileAccess.Write))
                    {
                        stream.CopyTo(fileStream);
                    }
                }
                else
                {
                    MessageBox.Show("No se pudo encontrar el recurso WAD.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }


           
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = chocolateDoomPath;
            startInfo.Arguments = $" -file \"{tempWadPath}\" {parametros}  {Argument}";  
            
            startInfo.UseShellExecute = false; 
            startInfo.CreateNoWindow = true; 
            
            try
            {
                
                Process.Start(startInfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al iniciar Chocolate Doom: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }

        private void toolStripMenuItem29_Click(object sender, EventArgs e)
        {
           
            string chocolateDoomPath = "chocolate-doom.exe";

           
            string wadResourceName = "experimento.D_DOOM.WAD";


            string param1 = comboBox1.SelectedItem?.ToString() ?? "";
            string Argument = $"{param1}";
            string tempWadPath = Path.Combine(Path.GetTempPath(), "D_DOOM.WAD");
            string parametros = ConstruirParametros7();


            using (Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(wadResourceName))
            {
                if (stream != null)
                {
                    using (FileStream fileStream = new FileStream(tempWadPath, FileMode.Create, FileAccess.Write))
                    {
                        stream.CopyTo(fileStream);
                    }
                }
                else
                {
                    MessageBox.Show("No se pudo encontrar el recurso WAD.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }


           
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = chocolateDoomPath;
            startInfo.Arguments = $" -file \"{tempWadPath}\" {parametros}  {Argument}";  

            startInfo.UseShellExecute = false; 
            startInfo.CreateNoWindow = true; 

            try
            {
                
                Process.Start(startInfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al iniciar Chocolate Doom: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }

        private void toolStripMenuItem30_Click(object sender, EventArgs e)
        {
           
            string chocolateDoomPath = "chocolate-doom.exe";

           
            string wadResourceName = "experimento.D_THE_DA.WAD";


            string param1 = comboBox1.SelectedItem?.ToString() ?? "";
            string Argument = $"{param1}";
            string tempWadPath = Path.Combine(Path.GetTempPath(), "D_THE_DA.WAD");
            string parametros = ConstruirParametros8();


            using (Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(wadResourceName))
            {
                if (stream != null)
                {
                    using (FileStream fileStream = new FileStream(tempWadPath, FileMode.Create, FileAccess.Write))
                    {
                        stream.CopyTo(fileStream);
                    }
                }
                else
                {
                    MessageBox.Show("No se pudo encontrar el recurso WAD.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }


           
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = chocolateDoomPath;
            startInfo.Arguments = $" -file \"{tempWadPath}\" {parametros}  {Argument}";  

            startInfo.UseShellExecute = false; 
            startInfo.CreateNoWindow = true; 

            try
            {
                
                Process.Start(startInfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al iniciar Chocolate Doom: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }

        private void toolStripMenuItem31_Click(object sender, EventArgs e)
        {
           
            string chocolateDoomPath = "chocolate-doom.exe";

           
            string wadResourceName = "experimento.D_STLKS3.WAD";


            string param1 = comboBox1.SelectedItem?.ToString() ?? "";
            string Argument = $"{param1}";
            string tempWadPath = Path.Combine(Path.GetTempPath(), "D_STLKS3.WAD");
            string parametros = ConstruirParametros9();


            using (Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(wadResourceName))
            {
                if (stream != null)
                {
                    using (FileStream fileStream = new FileStream(tempWadPath, FileMode.Create, FileAccess.Write))
                    {
                        stream.CopyTo(fileStream);
                    }
                }
                else
                {
                    MessageBox.Show("No se pudo encontrar el recurso WAD.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }


            
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = chocolateDoomPath;
            startInfo.Arguments = $" -file \"{tempWadPath}\" {parametros}  {Argument}";  

            startInfo.UseShellExecute = false; 
            startInfo.CreateNoWindow = true; 

            try
            {
                
                Process.Start(startInfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al iniciar Chocolate Doom: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         
        }

        private void toolStripMenuItem32_Click(object sender, EventArgs e)
        {
            
            string chocolateDoomPath = "chocolate-doom.exe";

           
            string wadResourceName = "experimento.D_SHAWN.WAD";


            string param1 = comboBox1.SelectedItem?.ToString() ?? "";
            string Argument = $"{param1}";
            string tempWadPath = Path.Combine(Path.GetTempPath(), "D_SHAWN.WAD");
            string parametros = ConstruirParametros10();


            using (Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(wadResourceName))
            {
                if (stream != null)
                {
                    using (FileStream fileStream = new FileStream(tempWadPath, FileMode.Create, FileAccess.Write))
                    {
                        stream.CopyTo(fileStream);
                    }
                }
                else
                {
                    MessageBox.Show("No se pudo encontrar el recurso WAD.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }


           
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = chocolateDoomPath;
            startInfo.Arguments = $" -file \"{tempWadPath}\" {parametros}  {Argument}";  

            startInfo.UseShellExecute = false; 
            startInfo.CreateNoWindow = true; 

            try
            {
                
                Process.Start(startInfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al iniciar Chocolate Doom: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         
        }

        private void toolStripMenuItem33_Click(object sender, EventArgs e)
        {
            
            string chocolateDoomPath = "chocolate-doom.exe";

            
            string wadResourceName = "experimento.D_RUNNI2.WAD";


            string param1 = comboBox1.SelectedItem?.ToString() ?? "";
            string Argument = $"{param1}";
            string tempWadPath = Path.Combine(Path.GetTempPath(), "D_RUNNI2.WAD");
            string parametros = ConstruirParametros11();


            using (Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(wadResourceName))
            {
                if (stream != null)
                {
                    using (FileStream fileStream = new FileStream(tempWadPath, FileMode.Create, FileAccess.Write))
                    {
                        stream.CopyTo(fileStream);
                    }
                }
                else
                {
                    MessageBox.Show("No se pudo encontrar el recurso WAD.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }


           
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = chocolateDoomPath;
            startInfo.Arguments = $" -file \"{tempWadPath}\" {parametros}  {Argument}"; 

            startInfo.UseShellExecute = false; 
            startInfo.CreateNoWindow = true; 

            try
            {
               
                Process.Start(startInfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al iniciar Chocolate Doom: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         
        }

        private void toolStripMenuItem34_Click(object sender, EventArgs e)
        {
           
            string chocolateDoomPath = "chocolate-doom.exe";

            
            string wadResourceName = "experimento.D_DOOM2.WAD";


            string param1 = comboBox1.SelectedItem?.ToString() ?? "";
            string Argument = $"{param1}";
            string tempWadPath = Path.Combine(Path.GetTempPath(), "D_DOOM2.WAD");
            string parametros = ConstruirParametros12();


            using (Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(wadResourceName))
            {
                if (stream != null)
                {
                    using (FileStream fileStream = new FileStream(tempWadPath, FileMode.Create, FileAccess.Write))
                    {
                        stream.CopyTo(fileStream);
                    }
                }
                else
                {
                    MessageBox.Show("No se pudo encontrar el recurso WAD.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }


            
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = chocolateDoomPath;
            startInfo.Arguments = $" -file \"{tempWadPath}\" {parametros}  {Argument}";  

            startInfo.UseShellExecute = false; 
            startInfo.CreateNoWindow = true; 

            try
            {
                
                Process.Start(startInfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al iniciar Chocolate Doom: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         
        }

        private void toolStripMenuItem35_Click(object sender, EventArgs e)
        {
           
            string chocolateDoomPath = "chocolate-doom.exe";

            
            string wadResourceName = "experimento.D_DEAD2.WAD";


            string param1 = comboBox1.SelectedItem?.ToString() ?? "";
            string Argument = $"{param1}";
            string tempWadPath = Path.Combine(Path.GetTempPath(), "D_DEAD2.WAD");
            string parametros = ConstruirParametros13();


            using (Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(wadResourceName))
            {
                if (stream != null)
                {
                    using (FileStream fileStream = new FileStream(tempWadPath, FileMode.Create, FileAccess.Write))
                    {
                        stream.CopyTo(fileStream);
                    }
                }
                else
                {
                    MessageBox.Show("No se pudo encontrar el recurso WAD.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }


            
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = chocolateDoomPath;
            startInfo.Arguments = $" -file \"{tempWadPath}\" {parametros}  {Argument}"; 

            startInfo.UseShellExecute = false; 
            startInfo.CreateNoWindow = true; 

            try
            {
                
                Process.Start(startInfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al iniciar Chocolate Doom: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         
        }

        private void toolStripMenuItem36_Click(object sender, EventArgs e)
        {
            
            string chocolateDoomPath = "chocolate-doom.exe";

           
            string wadResourceName = "experimento.D_DDTBLU.WAD";

            string param1 = comboBox1.SelectedItem?.ToString() ?? "";
            string Argument = $"{param1}";
            string tempWadPath = Path.Combine(Path.GetTempPath(), "D_DDTBLU.WAD");
            string parametros = ConstruirParametros14();


            using (Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(wadResourceName))
            {
                if (stream != null)
                {
                    using (FileStream fileStream = new FileStream(tempWadPath, FileMode.Create, FileAccess.Write))
                    {
                        stream.CopyTo(fileStream);
                    }
                }
                else
                {
                    MessageBox.Show("No se pudo encontrar el recurso WAD.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }


            
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = chocolateDoomPath;
            startInfo.Arguments = $" -file \"{tempWadPath}\" {parametros}  {Argument}"; 

            startInfo.UseShellExecute = false; 
            startInfo.CreateNoWindow = true; 

            try
            {
               
                Process.Start(startInfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al iniciar Chocolate Doom: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }

        private void toolStripMenuItem37_Click(object sender, EventArgs e)
        {
            
            string chocolateDoomPath = "chocolate-doom.exe";

            
            string wadResourceName = "experimento.D_IN_CIT.WAD";

            string param1 = comboBox1.SelectedItem?.ToString() ?? "";
            string Argument = $"{param1}";
            string tempWadPath = Path.Combine(Path.GetTempPath(), "D_IN_CIT.WAD");
            string parametros = ConstruirParametros15();


            using (Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(wadResourceName))
            {
                if (stream != null)
                {
                    using (FileStream fileStream = new FileStream(tempWadPath, FileMode.Create, FileAccess.Write))
                    {
                        stream.CopyTo(fileStream);
                    }
                }
                else
                {
                    MessageBox.Show("No se pudo encontrar el recurso WAD.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }


           
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = chocolateDoomPath;
            startInfo.Arguments = $" -file \"{tempWadPath}\" {parametros}  {Argument}";  

            startInfo.UseShellExecute = false; 
            startInfo.CreateNoWindow = true; 

            try
            {
                
                Process.Start(startInfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al iniciar Chocolate Doom: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         
        }

        private void toolStripMenuItem38_Click(object sender, EventArgs e)
        {
            
            string chocolateDoomPath = "chocolate-doom.exe";

            
            string wadResourceName = "experimento.D_DEAD.WAD";

            string param1 = comboBox1.SelectedItem?.ToString() ?? "";
            string Argument = $"{param1}";
            string tempWadPath = Path.Combine(Path.GetTempPath(), "D_DEAD.WAD");
            string parametros = ConstruirParametros16();


            using (Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(wadResourceName))
            {
                if (stream != null)
                {
                    using (FileStream fileStream = new FileStream(tempWadPath, FileMode.Create, FileAccess.Write))
                    {
                        stream.CopyTo(fileStream);
                    }
                }
                else
                {
                    MessageBox.Show("No se pudo encontrar el recurso WAD.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }


           
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = chocolateDoomPath;
            startInfo.Arguments = $" -file \"{tempWadPath}\" {parametros}  {Argument}";  

            startInfo.UseShellExecute = false; 
            startInfo.CreateNoWindow = true; 

            try
            {
                
                Process.Start(startInfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al iniciar Chocolate Doom: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void toolStripMenuItem39_Click(object sender, EventArgs e)
        {
            
            string chocolateDoomPath = "chocolate-doom.exe";

           
            string wadResourceName = "experimento.D_MESSAG.WAD";

            string param1 = comboBox1.SelectedItem?.ToString() ?? "";
            string Argument = $"{param1}";
            string tempWadPath = Path.Combine(Path.GetTempPath(), "D_MESSAG.WAD");
            string parametros = ConstruirParametros17();


            using (Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(wadResourceName))
            {
                if (stream != null)
                {
                    using (FileStream fileStream = new FileStream(tempWadPath, FileMode.Create, FileAccess.Write))
                    {
                        stream.CopyTo(fileStream);
                    }
                }
                else
                {
                    MessageBox.Show("No se pudo encontrar el recurso WAD.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }


            
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = chocolateDoomPath;
            startInfo.Arguments = $" -file \"{tempWadPath}\" {parametros}  {Argument}"; 

            startInfo.UseShellExecute = false; 
            startInfo.CreateNoWindow = true; 

            try
            {
                
                Process.Start(startInfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al iniciar Chocolate Doom: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void toolStripMenuItem40_Click(object sender, EventArgs e)
        {
            
            string chocolateDoomPath = "chocolate-doom.exe";

            
            string wadResourceName = "experimento.D_STLKS2.WAD";

            string param1 = comboBox1.SelectedItem?.ToString() ?? "";
            string Argument = $"{param1}";
            string tempWadPath = Path.Combine(Path.GetTempPath(), "D_STLKS2.WAD");
            string parametros = ConstruirParametros18();


            using (Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(wadResourceName))
            {
                if (stream != null)
                {
                    using (FileStream fileStream = new FileStream(tempWadPath, FileMode.Create, FileAccess.Write))
                    {
                        stream.CopyTo(fileStream);
                    }
                }
                else
                {
                    MessageBox.Show("No se pudo encontrar el recurso WAD.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }


            
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = chocolateDoomPath;
            startInfo.Arguments = $" -file \"{tempWadPath}\" {parametros}  {Argument}"; 

            startInfo.UseShellExecute = false; 
            startInfo.CreateNoWindow = true; 

            try
            {
               
                Process.Start(startInfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al iniciar Chocolate Doom: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void toolStripMenuItem41_Click(object sender, EventArgs e)
        {
            
            string chocolateDoomPath = "chocolate-doom.exe";

            
            string wadResourceName = "experimento.D_ROMERO.WAD";

            string param1 = comboBox1.SelectedItem?.ToString() ?? "";
            string Argument = $"{param1}";
            string tempWadPath = Path.Combine(Path.GetTempPath(), "D_ROMERO.WAD");
            string parametros = ConstruirParametros19();


            using (Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(wadResourceName))
            {
                if (stream != null)
                {
                    using (FileStream fileStream = new FileStream(tempWadPath, FileMode.Create, FileAccess.Write))
                    {
                        stream.CopyTo(fileStream);
                    }
                }
                else
                {
                    MessageBox.Show("No se pudo encontrar el recurso WAD.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }


           
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = chocolateDoomPath;
            startInfo.Arguments = $" -file \"{tempWadPath}\" {parametros}  {Argument}"; 

            startInfo.UseShellExecute = false; 
            startInfo.CreateNoWindow = true; 

            try
            {
                
                Process.Start(startInfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al iniciar Chocolate Doom: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void toolStripMenuItem42_Click(object sender, EventArgs e)
        {
            
            string chocolateDoomPath = "chocolate-doom.exe";

            
            string wadResourceName = "experimento.D_THEDA2.WAD";

            string param1 = comboBox1.SelectedItem?.ToString() ?? "";
            string Argument = $"{param1}";
            string tempWadPath = Path.Combine(Path.GetTempPath(), "D_THEDA2.WAD");
            string parametros = ConstruirParametros20();


            using (Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(wadResourceName))
            {
                if (stream != null)
                {
                    using (FileStream fileStream = new FileStream(tempWadPath, FileMode.Create, FileAccess.Write))
                    {
                        stream.CopyTo(fileStream);
                    }
                }
                else
                {
                    MessageBox.Show("No se pudo encontrar el recurso WAD.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }


            
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = chocolateDoomPath;
            startInfo.Arguments = $" -file \"{tempWadPath}\" {parametros}  {Argument}"; 

            startInfo.UseShellExecute = false; 
            startInfo.CreateNoWindow = true; 

            try
            {
                
                Process.Start(startInfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al iniciar Chocolate Doom: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox17.Checked)
            {
                menuStrip1.Visible = false;
            }
            else
            {
                menuStrip1.Visible = true;
            }
            if (checkBox17.Checked)
            {
                menuStrip2.Visible = true;
            }
            else
            {
                menuStrip2.Visible = false;
            }
        }
        private void toolStripMenuItem23_MouseEnter(object sender, EventArgs e)
        {

            textBox2.Text = "Name: Attack";
            textBox3.Text = "Author: Tim Willits";
            textBox4.Text = "Level replaced: Map 01";


            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            pictureBox1.Image = imagen2;
        }

        private void toolStripMenuItem23_MouseLeave(object sender, EventArgs e)
        {

            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            pictureBox1.Image = imagen1;
        }

        private void toolStripMenuItem24_MouseEnter(object sender, EventArgs e)
        {
            textBox2.Text = "Name: Black Tower";
            textBox3.Text = "Author: Sverre Andre Kvernmo \"Cranium\"";
            textBox4.Text = "Level replaced: Map 25";

            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            pictureBox1.Image = imagen4;

        }

        private void toolStripMenuItem24_MouseLeave(object sender, EventArgs e)
        {
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            pictureBox1.Image = imagen3;
        }

        private void toolStripMenuItem25_MouseEnter(object sender, EventArgs e)
        {

            textBox2.Text = "Name: Bloodsea Keep";
            textBox3.Text = "Author: Sverre Andre Kvernmo \"Cranium\"";
            textBox4.Text = "Level replaced: Map 07";


            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            pictureBox1.Image = imagen6;

        }

        private void toolStripMenuItem25_MouseLeave(object sender, EventArgs e)
        {
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            pictureBox1.Image = imagen5;
        }

        private void toolStripMenuItem26_MouseEnter(object sender, EventArgs e)
        {

            textBox2.Text = "Name: Canyon";
            textBox3.Text = "Author: Tim Willits";
            textBox4.Text = "Level replaced: Map 01";


            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            pictureBox1.Image = imagen8;
        }

        private void toolStripMenuItem26_MouseLeave(object sender, EventArgs e)
        {
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            pictureBox1.Image = imagen7;
        }

        private void toolStripMenuItem27_MouseEnter(object sender, EventArgs e)
        {
            textBox2.Text = "Name: The Catwalk";
            textBox3.Text = "Author: Christen David Klie";
            textBox4.Text = "Level replaced: Map 01";


            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            pictureBox1.Image = imagen10;
        }

        private void toolStripMenuItem27_MouseLeave(object sender, EventArgs e)
        {
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            pictureBox1.Image = imagen9;
        }

        private void toolStripMenuItem28_MouseEnter(object sender, EventArgs e)
        {
            textBox2.Text = "Name: The Combine";
            textBox3.Text = "Author: Christen David Klie";
            textBox4.Text = "Level replaced: Map 01";


            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            pictureBox1.Image = imagen12;
        }

        private void toolStripMenuItem28_MouseLeave(object sender, EventArgs e)
        {
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            pictureBox1.Image = imagen11;
        }

        private void toolStripMenuItem29_MouseEnter(object sender, EventArgs e)
        {
            textBox2.Text = "Name: The Fistula";
            textBox3.Text = "Author: Christen David Klie";
            textBox4.Text = "Level replaced: Map 01";


            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            pictureBox1.Image = imagen14;
        }

        private void toolStripMenuItem29_MouseLeave(object sender, EventArgs e)
        {
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            pictureBox1.Image = imagen13;
        }

        private void toolStripMenuItem30_MouseEnter(object sender, EventArgs e)
        {
            textBox2.Text = "Name: The Garrison";
            textBox3.Text = "Author: Christen David Klie";
            textBox4.Text = "Level replaced: Map 01";


            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            pictureBox1.Image = imagen16;
        }

        private void toolStripMenuItem30_MouseLeave(object sender, EventArgs e)
        {
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            pictureBox1.Image = imagen15;
        }

        private void toolStripMenuItem31_MouseEnter(object sender, EventArgs e)
        {
            textBox2.Text = "Name: Geryon";
            textBox3.Text = "Author: John W. Anderson \" Dr Sleep\"";
            textBox4.Text = "Level replaced: Map 08";


            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            pictureBox1.Image = imagen18;
        }

        private void toolStripMenuItem31_MouseLeave(object sender, EventArgs e)
        {
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            pictureBox1.Image = imagen17;
        }

        private void toolStripMenuItem32_MouseEnter(object sender, EventArgs e)
        {
            textBox2.Text = "Name: Titan Manor";
            textBox3.Text = "Author: Jim Flynn";
            textBox4.Text = "Level replaced: Map 01";


            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            pictureBox1.Image = imagen20;
        }

        private void toolStripMenuItem32_MouseLeave(object sender, EventArgs e)
        {
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            pictureBox1.Image = imagen19;
        }

        private void toolStripMenuItem33_MouseEnter(object sender, EventArgs e)
        {
            textBox2.Text = "Name: Mephisto's Maosoleum";
            textBox3.Text = "Author: Sverre Andre Kvernmo \"Cranium\"";
            textBox4.Text = "Level replaced: Map 07";


            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            pictureBox1.Image = imagen22;


        }

        private void toolStripMenuItem33_MouseLeave(object sender, EventArgs e)
        {
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            pictureBox1.Image = imagen21;
        }

        private void toolStripMenuItem34_MouseEnter(object sender, EventArgs e)
        {
            textBox2.Text = "Name: Minos' Judgement";
            textBox3.Text = "Author: John W. Anderson \" Dr Sleep\"";
            textBox4.Text = "Level replaced: Map 05";


            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            pictureBox1.Image = imagen24;
        }

        private void toolStripMenuItem34_MouseLeave(object sender, EventArgs e)
        {
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            pictureBox1.Image = imagen23;
        }

        private void toolStripMenuItem35_MouseEnter(object sender, EventArgs e)
        {
            textBox2.Text = "Name: Nessus";
            textBox3.Text = "Author: John W. Anderson \" Dr Sleep\"";
            textBox4.Text = "Level replaced: Map 07";


            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            pictureBox1.Image = imagen26;

        }

        private void toolStripMenuItem35_MouseLeave(object sender, EventArgs e)
        {
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            pictureBox1.Image = imagen25;
        }

        private void toolStripMenuItem36_MouseEnter(object sender, EventArgs e)
        {
            textBox2.Text = "Name: Paradox";
            textBox3.Text = "Author: Tom Mustaine";
            textBox4.Text = "Level replaced: Map 01";


            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            pictureBox1.Image = imagen28;

        }

        private void toolStripMenuItem36_MouseLeave(object sender, EventArgs e)
        {
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            pictureBox1.Image = imagen27;


        }

        private void toolStripMenuItem37_MouseEnter(object sender, EventArgs e)
        {
            textBox2.Text = "Name: Subspace";
            textBox3.Text = "Author: Christen David Klie";
            textBox4.Text = "Level replaced: Map 01";


            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            pictureBox1.Image = imagen30;


        }

        private void toolStripMenuItem37_MouseLeave(object sender, EventArgs e)
        {
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            pictureBox1.Image = imagen29;


        }

        private void toolStripMenuItem38_MouseEnter(object sender, EventArgs e)
        {
            textBox2.Text = "Name: Subterra";
            textBox3.Text = "Author: Christen David Klie";
            textBox4.Text = "Level replaced: Map 01";


            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            pictureBox1.Image = imagen32;

        }

        private void toolStripMenuItem38_MouseLeave(object sender, EventArgs e)
        {
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            pictureBox1.Image = imagen31;

        }

        private void toolStripMenuItem39_MouseEnter(object sender, EventArgs e)
        {
            textBox2.Text = "Name: The Express Elevator to Hell";
            textBox3.Text = "Author: Sverre Andre Kvernmo \"Cranium\"";
            textBox4.Text = "Level replaced: Map 31 and 32";


            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            pictureBox1.Image = imagen34;

        }

        private void toolStripMenuItem39_MouseLeave(object sender, EventArgs e)
        {
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            pictureBox1.Image = imagen33;
        }

        private void toolStripMenuItem40_MouseEnter(object sender, EventArgs e)
        {
            textBox2.Text = "Name: Trapped on Titan";
            textBox3.Text = "Author: Jim Flynn";
            textBox4.Text = "Level replaced: Map 01";


            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            pictureBox1.Image = imagen36;


        }

        private void toolStripMenuItem40_MouseLeave(object sender, EventArgs e)
        {
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            pictureBox1.Image = imagen35;


        }

        private void toolStripMenuItem41_MouseEnter(object sender, EventArgs e)
        {
            textBox2.Text = "Name: Vesperas";
            textBox3.Text = "Author: John W. Anderson \"Dr. Sleep\"";
            textBox4.Text = "Level replaced: Map 09";


            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            pictureBox1.Image = imagen38;


        }

        private void toolStripMenuItem41_MouseLeave(object sender, EventArgs e)
        {
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            pictureBox1.Image = imagen37;


        }

        private void toolStripMenuItem42_MouseEnter(object sender, EventArgs e)
        {
            textBox2.Text = "Name: Virgil's lead";
            textBox3.Text = "Author: John W. Anderson \"Dr. Sleep\"";
            textBox4.Text = "Level replaced: Map 03";


            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            pictureBox1.Image = imagen40;


        }

        private void toolStripMenuItem42_MouseLeave(object sender, EventArgs e)
        {
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            pictureBox1.Image = imagen39;


        }

        private void toolStripMenuItem43_MouseEnter(object sender, EventArgs e)
        {
            textBox2.Text = "Name: Bad dream";
            textBox3.Text = "Author: Sverre Andre Kvernmo \"Cranium\"";
            textBox4.Text = "Level replaced: Map 32";


            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            pictureBox1.Image = imagen42;


        }

        private void toolStripMenuItem43_MouseLeave(object sender, EventArgs e)
        {
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            pictureBox1.Image = imagen41;


        }

        private void toolStripMenuItem44_MouseEnter(object sender, EventArgs e)
        {
            textBox2.Text = "Name: Bad dream";
            textBox3.Text = "Author: Sverre Andre Kvernmo \"Cranium\"";
            textBox4.Text = "Level replaced: Map 32";


            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            pictureBox1.Image = imagen42;


        }

        private void toolStripMenuItem44_MouseLeave(object sender, EventArgs e)
        {
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            pictureBox1.Image = imagen41;


        }


          private void toolStripMenuItem43_Click(object sender, EventArgs e)
        {
            string param1 = comboBox1.SelectedItem?.ToString() ?? "";
            string parametros = ConstruirParametros21();
            string Argument = $"{param1}";
            EjecutarExe21(parametros + Argument);
        }

        private string ConstruirParametros21()
        {
            string parametros = "";
            if (checkBox1.Checked)
            {
                parametros += "chocolate-doom -merge wads/TEETH.WAD -skill 1 -warp 32M ";
            }
            if (checkBox2.Checked)
            {
                parametros += "chocolate-doom -merge wads/TEETH.WAD -skill 2 -warp 32M ";
            }
            if (checkBox3.Checked)
            {
                parametros += "chocolate-doom -merge wads/TEETH.WAD -skill 3 -warp 32M ";
            }
            if (checkBox4.Checked)
            {
                parametros += "chocolate-doom -merge wads/TEETH.WAD -skill 4 -warp 32M ";
            }
            if (checkBox5.Checked)
            {
                parametros += "chocolate-doom -merge wads/TEETH.WAD -skill 5 -warp 32M ";
            }
            if (checkBox6.Checked)
            {
                parametros += "chocolate-doom -merge wads/TEETH.WAD -fast -warp 32M ";
            }
            if (checkBox7.Checked)
            {
                parametros += "chocolate-doom -merge wads/TEETH.WAD -nomonsters -warp 32M ";
            }
            if (checkBox8.Checked)
            {
                parametros += "chocolate-doom -merge wads/TEETH.WAD -respawn -warp 32M ";
            }


            return parametros.Trim();
        }

        private void EjecutarExe21(string parametros)
        {
            try
            {
                ProcessStartInfo procesoInfo = new ProcessStartInfo();
                procesoInfo.FileName = "chocolate-doom.exe";
                procesoInfo.Arguments = parametros;
                procesoInfo.UseShellExecute = false;

                Process proceso = new Process();
                proceso.StartInfo = procesoInfo;
                proceso.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar el .exe: " + ex.Message);
            }
        }

        private void toolStripMenuItem44_Click(object sender, EventArgs e)
        {

            string chocolateDoomPath = "chocolate-doom.exe";


            string wadResourceName = "experimento.D_COUNT2.WAD";

            string param1 = comboBox1.SelectedItem?.ToString() ?? "";
            string Argument = $"{param1}";
            string tempWadPath = Path.Combine(Path.GetTempPath(), "D_COUNT2.WAD");
            string parametros = ConstruirParametros21();


            using (Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(wadResourceName))
            {
                if (stream != null)
                {
                    using (FileStream fileStream = new FileStream(tempWadPath, FileMode.Create, FileAccess.Write))
                    {
                        stream.CopyTo(fileStream);
                    }
                }
                else
                {
                    MessageBox.Show("No se pudo encontrar el recurso WAD.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }



            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = chocolateDoomPath;
            startInfo.Arguments = $" -file \"{tempWadPath}\" {parametros}  {Argument}";

            startInfo.UseShellExecute = false;
            startInfo.CreateNoWindow = true;

            try
            {

                Process.Start(startInfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al iniciar Chocolate Doom: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}