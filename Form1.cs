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
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;



namespace Choco_Master_Launcher
{
    
    public partial class Form1 : Form
    {
        private System.Drawing.Image imagen1;
        private System.Drawing.Image imagen2;
        private System.Drawing.Image imagen3;
        private System.Drawing.Image imagen4;
        private System.Drawing.Image imagen5;
        private System.Drawing.Image imagen6;
        private System.Drawing.Image imagen7;
        private System.Drawing.Image imagen8;
        private System.Drawing.Image imagen9;
        private System.Drawing.Image imagen10;
        private System.Drawing.Image imagen11;
        private System.Drawing.Image imagen12;
        private System.Drawing.Image imagen13;
        private System.Drawing.Image imagen14;
        private System.Drawing.Image imagen15;
        private System.Drawing.Image imagen16;
        private System.Drawing.Image imagen17;
        private System.Drawing.Image imagen18;
        private System.Drawing.Image imagen19;
        private System.Drawing.Image imagen20;
        private System.Drawing.Image imagen21;
        private System.Drawing.Image imagen22;
        private System.Drawing.Image imagen23;
        private System.Drawing.Image imagen24;
        private System.Drawing.Image imagen25;
        private System.Drawing.Image imagen26;
        private System.Drawing.Image imagen27;
        private System.Drawing.Image imagen28;
        private System.Drawing.Image imagen29;
        private System.Drawing.Image imagen30;
        private System.Drawing.Image imagen31;
        private System.Drawing.Image imagen32;
        private System.Drawing.Image imagen33;
        private System.Drawing.Image imagen34;
        private System.Drawing.Image imagen35;
        private System.Drawing.Image imagen36;
        private System.Drawing.Image imagen37;
        private System.Drawing.Image imagen38;
        private System.Drawing.Image imagen39;
        private System.Drawing.Image imagen40;
        private System.Drawing.Image imagen41;
        private System.Drawing.Image imagen42;

        private int _lastFormSize;






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


            button1.MouseEnter += button1_MouseEnter;
            button1.MouseLeave += button1_MouseLeave;
            button2.MouseEnter += button2_MouseEnter;
            button2.MouseLeave += button2_MouseLeave;
            button3.MouseEnter += button3_MouseEnter;
            button3.MouseLeave += button3_MouseLeave;
            button4.MouseEnter += button4_MouseEnter;
            button4.MouseLeave += button4_MouseLeave;
            button5.MouseEnter += button5_MouseEnter;
            button5.MouseLeave += button5_MouseLeave;
            button6.MouseEnter += button6_MouseEnter;
            button6.MouseLeave += button6_MouseLeave;
            button7.MouseEnter += button7_MouseEnter;
            button7.MouseLeave += button7_MouseLeave;
            button8.MouseEnter += button8_MouseEnter;
            button8.MouseLeave += button8_MouseLeave;
            button9.MouseEnter += button9_MouseEnter;
            button9.MouseLeave += button9_MouseLeave;
            button10.MouseEnter += button10_MouseEnter;
            button10.MouseLeave += button10_MouseLeave;
            button11.MouseEnter += button11_MouseEnter;
            button11.MouseLeave += button11_MouseLeave;
            button12.MouseEnter += button12_MouseEnter;
            button12.MouseLeave += button12_MouseLeave;
            button13.MouseEnter += button13_MouseEnter;
            button13.MouseLeave += button13_MouseLeave;
            button14.MouseEnter += button14_MouseEnter;
            button14.MouseLeave += button14_MouseLeave;
            button15.MouseEnter += button15_MouseEnter;
            button15.MouseLeave += button15_MouseLeave;
            button16.MouseEnter += button16_MouseEnter;
            button16.MouseLeave += button16_MouseLeave;
            button17.MouseEnter += button17_MouseEnter;
            button17.MouseLeave += button17_MouseLeave;
            button18.MouseEnter += button18_MouseEnter;
            button18.MouseLeave += button18_MouseLeave;
            button19.MouseEnter += button19_MouseEnter;
            button19.MouseLeave += button19_MouseLeave;
            button20.MouseEnter += button20_MouseEnter;
            button20.MouseLeave += button20_MouseLeave;
            button21.MouseEnter += button21_MouseEnter;
            button21.MouseLeave += button21_MouseLeave;

            this.button1.Enabled = false;
            this.button2.Enabled = false;
            this.button3.Enabled = false;
            this.button4.Enabled = false;
            this.button5.Enabled = false;
            this.button6.Enabled = false;
            this.button7.Enabled = false;
            this.button8.Enabled = false;
            this.button9.Enabled = false;
            this.button10.Enabled = false;
            this.button11.Enabled = false;
            this.button12.Enabled = false;
            this.button13.Enabled = false;
            this.button14.Enabled = false;
            this.button15.Enabled = false;
            this.button16.Enabled = false;
            this.button17.Enabled = false;
            this.button18.Enabled = false;
            this.button19.Enabled = false;
            this.button20.Enabled = false;
            this.button21.Enabled = false;

            
            this.comboBox1.Enabled = false;
            this.comboBox4.Enabled = false;
            this.comboBox5.Enabled = false;
            this.comboBox6.Enabled = false;
            this.comboBox7.Enabled = false;

            checkBox3.Checked = true;

            this.Resize += new EventHandler(Form1_Resize);
            _lastFormSize = GetFormArea(this.Size);


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






        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox11.Checked)
            {
                string chocolateDoomPath = "chocolate-doom.exe";


                string wadResourceName = "Choco_Master_Launcher.D_RUNNIN.WAD";



                string tempWadPath = Path.Combine(Path.GetTempPath(), "D_RUNNIN.WAD");
                string parametros = ConstruirParametros();
                string param1 = comboBox1.SelectedItem?.ToString() ?? "";
                string Argument = $"{param1}";

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

            else
            {

                string param1 = comboBox1.SelectedItem?.ToString() ?? "";
                string parametros = ConstruirParametros();
                string Argument = $"{param1}";
                EjecutarExe1(parametros + Argument);
                ;
                {

                }

            }

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

            {

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkBox11.Checked)
            {
                string chocolateDoomPath = "chocolate-doom.exe";


                string wadResourceName = "Choco_Master_Launcher.D_SHAWN2.WAD";



                string tempWadPath = Path.Combine(Path.GetTempPath(), "D_SHAWN2.WAD");
                string parametros = ConstruirParametros2();
                string param1 = comboBox1.SelectedItem?.ToString() ?? "";
                string Argument = $"{param1}";


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

            else
            {

                string param1 = comboBox1.SelectedItem?.ToString() ?? "";
                string parametros = ConstruirParametros2();
                string Argument = $"{param1}";
                EjecutarExe2(parametros + Argument);
                {

                }

            }

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

            {

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (checkBox11.Checked)
            {
                string chocolateDoomPath = "chocolate-doom.exe";


                string wadResourceName = "Choco_Master_Launcher.D_DDTBL2.WAD";



                string tempWadPath = Path.Combine(Path.GetTempPath(), "D_DDTBL2.WAD");
                string parametros = ConstruirParametros3();
                string param1 = comboBox1.SelectedItem?.ToString() ?? "";
                string Argument = $"{param1}";


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

            else
            {

                string param1 = comboBox1.SelectedItem?.ToString() ?? "";
                string parametros = ConstruirParametros3();
                string Argument = $"{param1}";
                EjecutarExe3(parametros + Argument);
                {

                }

            }

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

            {

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (checkBox11.Checked)
            {
                string chocolateDoomPath = "chocolate-doom.exe";


                string wadResourceName = "Choco_Master_Launcher.D_STALKS.WAD";



                string tempWadPath = Path.Combine(Path.GetTempPath(), "D_STALKS.WAD");
                string parametros = ConstruirParametros4();
                string param1 = comboBox1.SelectedItem?.ToString() ?? "";
                string Argument = $"{param1}";


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

            else
            {

                string param1 = comboBox1.SelectedItem?.ToString() ?? "";
                string parametros = ConstruirParametros4();
                string Argument = $"{param1}";
                EjecutarExe4(parametros + Argument);
                {

                }

            }

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

            {

            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (checkBox11.Checked)
            {
                string chocolateDoomPath = "chocolate-doom.exe";


                string wadResourceName = "Choco_Master_Launcher.D_COUNTD.WAD";



                string tempWadPath = Path.Combine(Path.GetTempPath(), "D_COUNTD.WAD");
                string parametros = ConstruirParametros5();
                string param1 = comboBox1.SelectedItem?.ToString() ?? "";
                string Argument = $"{param1}";


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

            else
            {

                string param1 = comboBox1.SelectedItem?.ToString() ?? "";
                string parametros = ConstruirParametros5();
                string Argument = $"{param1}";
                EjecutarExe5(parametros + Argument); ;
                {

                }

            }

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

            {

            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (checkBox11.Checked)
            {
                string chocolateDoomPath = "chocolate-doom.exe";


                string wadResourceName = "Choco_Master_Launcher.D_BETWEE.WAD";



                string tempWadPath = Path.Combine(Path.GetTempPath(), "D_BETWEE.WAD");
                string parametros = ConstruirParametros6();
                string param1 = comboBox1.SelectedItem?.ToString() ?? "";
                string Argument = $"{param1}";



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

            else
            {
                string param1 = comboBox1.SelectedItem?.ToString() ?? "";
                string parametros = ConstruirParametros6();
                string Argument = $"{param1}";
                EjecutarExe6(parametros + Argument);
                {

                }

            }

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

            {

            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (checkBox11.Checked)
            {
                string chocolateDoomPath = "chocolate-doom.exe";


                string wadResourceName = "Choco_Master_Launcher.D_DOOM.WAD";



                string tempWadPath = Path.Combine(Path.GetTempPath(), "D_DOOM.WAD");
                string parametros = ConstruirParametros7();
                string param1 = comboBox1.SelectedItem?.ToString() ?? "";
                string Argument = $"{param1}";


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

            else
            {

                string param1 = comboBox1.SelectedItem?.ToString() ?? "";
                string parametros = ConstruirParametros7();
                string Argument = $"{param1}";
                EjecutarExe7(parametros + Argument);
                {

                }

            }

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

            {

            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (checkBox11.Checked)
            {
                string chocolateDoomPath = "chocolate-doom.exe";


                string wadResourceName = "Choco_Master_Launcher.D_THE_DA.WAD";



                string tempWadPath = Path.Combine(Path.GetTempPath(), "D_THE_DA.WAD");
                string parametros = ConstruirParametros8();
                string param1 = comboBox1.SelectedItem?.ToString() ?? "";
                string Argument = $"{param1}";



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
                startInfo.Arguments = $" -file \"{tempWadPath}\" {parametros} {Argument}";

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

            else
            {

                string param1 = comboBox1.SelectedItem?.ToString() ?? "";
                string parametros = ConstruirParametros8();
                string Argument = $"{param1}";
                EjecutarExe8(parametros + Argument);
                {

                }

            }

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

            {

            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (checkBox11.Checked)
            {
                string chocolateDoomPath = "chocolate-doom.exe";


                string wadResourceName = "Choco_Master_Launcher.D_STLKS3.WAD";



                string tempWadPath = Path.Combine(Path.GetTempPath(), "D_STLKS3.WAD");
                string parametros = ConstruirParametros9();
                string param1 = comboBox1.SelectedItem?.ToString() ?? "";
                string Argument = $"{param1}";


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
                startInfo.Arguments = $" -file \"{tempWadPath}\" {parametros} {Argument}";

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

            else
            {
                string param1 = comboBox1.SelectedItem?.ToString() ?? "";
                string parametros = ConstruirParametros9();
                string Argument = $"{param1}";
                EjecutarExe9(parametros + Argument);
                {

                }

            }

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

            {

            }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (checkBox11.Checked)
            {
                string chocolateDoomPath = "chocolate-doom.exe";


                string wadResourceName = "Choco_Master_Launcher.D_SHAWN.WAD";



                string tempWadPath = Path.Combine(Path.GetTempPath(), "D_SHAWN.WAD");
                string parametros = ConstruirParametros10();
                string param1 = comboBox1.SelectedItem?.ToString() ?? "";
                string Argument = $"{param1}";


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
                startInfo.Arguments = $" -file \"{tempWadPath}\" {parametros} {Argument}";

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

            else
            {

                string param1 = comboBox1.SelectedItem?.ToString() ?? "";
                string parametros = ConstruirParametros10();
                string Argument = $"{param1}";
                EjecutarExe10(parametros + Argument);
                {

                }

            }

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

            {

            }

        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (checkBox11.Checked)
            {
                string chocolateDoomPath = "chocolate-doom.exe";


                string wadResourceName = "Choco_Master_Launcher.D_RUNNI2.WAD";



                string tempWadPath = Path.Combine(Path.GetTempPath(), "D_RUNNI2.WAD");
                string parametros = ConstruirParametros11();
                string param1 = comboBox1.SelectedItem?.ToString() ?? "";
                string Argument = $"{param1}";


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
                startInfo.Arguments = $" -file \"{tempWadPath}\" {parametros} {Argument}";

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

            else
            {

                string param1 = comboBox1.SelectedItem?.ToString() ?? "";
                string parametros = ConstruirParametros11();
                string Argument = $"{param1}";
                EjecutarExe11(parametros + Argument);
                {

                }

            }

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

            {

            }

        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (checkBox11.Checked)
            {
                string chocolateDoomPath = "chocolate-doom.exe";


                string wadResourceName = "Choco_Master_Launcher.D_DOOM2.WAD";



                string tempWadPath = Path.Combine(Path.GetTempPath(), "D_DOOM2.WAD");
                string parametros = ConstruirParametros12();
                string param1 = comboBox1.SelectedItem?.ToString() ?? "";
                string Argument = $"{param1}";


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
                startInfo.Arguments = $" -file \"{tempWadPath}\" {parametros} {Argument}";

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

            else
            {


                string param1 = comboBox1.SelectedItem?.ToString() ?? "";
                string parametros = ConstruirParametros12();
                string Argument = $"{param1}";
                EjecutarExe12(parametros + Argument);
                {

                }

            }

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

            {

            }

        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (checkBox11.Checked)
            {
                string chocolateDoomPath = "chocolate-doom.exe";


                string wadResourceName = "Choco_Master_Launcher.D_DEAD2.WAD";



                string tempWadPath = Path.Combine(Path.GetTempPath(), "D_DEAD2.WAD");
                string parametros = ConstruirParametros13();
                string param1 = comboBox1.SelectedItem?.ToString() ?? "";
                string Argument = $"{param1}";


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
                startInfo.Arguments = $" -file \"{tempWadPath}\" {parametros} {Argument}";

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

            else
            {

                string param1 = comboBox1.SelectedItem?.ToString() ?? "";
                string parametros = ConstruirParametros13();
                string Argument = $"{param1}";
                EjecutarExe13(parametros + Argument);
                {

                }

            }

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

            {

            }

        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (checkBox11.Checked)
            {
                string chocolateDoomPath = "chocolate-doom.exe";


                string wadResourceName = "Choco_Master_Launcher.D_DDTBLU.WAD";



                string tempWadPath = Path.Combine(Path.GetTempPath(), "D_DDTBLU.WAD");
                string parametros = ConstruirParametros14();
                string param1 = comboBox1.SelectedItem?.ToString() ?? "";
                string Argument = $"{param1}";


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
                startInfo.Arguments = $" -file \"{tempWadPath}\" {parametros} {Argument}";

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

            else
            {

                string param1 = comboBox1.SelectedItem?.ToString() ?? "";
                string parametros = ConstruirParametros14();
                string Argument = $"{param1}";
                EjecutarExe14(parametros + Argument);
                {

                }

            }

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

            {

            }

        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (checkBox11.Checked)
            {
                string chocolateDoomPath = "chocolate-doom.exe";


                string wadResourceName = "Choco_Master_Launcher.D_IN_CIT.WAD";



                string tempWadPath = Path.Combine(Path.GetTempPath(), "D_IN_CIT.WAD");
                string parametros = ConstruirParametros15();
                string param1 = comboBox1.SelectedItem?.ToString() ?? "";
                string Argument = $"{param1}";


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
                startInfo.Arguments = $" -file \"{tempWadPath}\" {parametros} {Argument}";

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

            else
            {

                string param1 = comboBox1.SelectedItem?.ToString() ?? "";
                string parametros = ConstruirParametros15();
                string Argument = $"{param1}";
                EjecutarExe15(parametros + Argument);
                {

                }

            }

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

            {

            }

        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (checkBox11.Checked)
            {
                string chocolateDoomPath = "chocolate-doom.exe";


                string wadResourceName = "Choco_Master_Launcher.D_DEAD.WAD";



                string tempWadPath = Path.Combine(Path.GetTempPath(), "D_DEAD.WAD");
                string parametros = ConstruirParametros16();
                string param1 = comboBox1.SelectedItem?.ToString() ?? "";
                string Argument = $"{param1}";


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
                startInfo.Arguments = $" -file \"{tempWadPath}\" {parametros} {Argument}";

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

            else
            {

                string param1 = comboBox1.SelectedItem?.ToString() ?? "";
                string parametros = ConstruirParametros16();
                string Argument = $"{param1}";
                EjecutarExe16(parametros + Argument);
                {

                }

            }

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

            {

            }

        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (checkBox11.Checked)
            {
                string chocolateDoomPath = "chocolate-doom.exe";


                string wadResourceName = "Choco_Master_Launcher.D_MESSAG.WAD";



                string tempWadPath = Path.Combine(Path.GetTempPath(), "D_MESSAG.WAD");
                string parametros = ConstruirParametros17();
                string param1 = comboBox1.SelectedItem?.ToString() ?? "";
                string Argument = $"{param1}";


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
                startInfo.Arguments = $" -file \"{tempWadPath}\" {parametros} {Argument}";

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

            else
            {

                string param1 = comboBox1.SelectedItem?.ToString() ?? "";
                string parametros = ConstruirParametros17();
                string Argument = $"{param1}";
                EjecutarExe17(parametros + Argument);
                {

                }

            }

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

            {

            }

        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (checkBox11.Checked)
            {
                string chocolateDoomPath = "chocolate-doom.exe";


                string wadResourceName = "Choco_Master_Launcher.D_STLKS2.WAD";



                string tempWadPath = Path.Combine(Path.GetTempPath(), "D_STLKS2.WAD");
                string parametros = ConstruirParametros18();
                string param1 = comboBox1.SelectedItem?.ToString() ?? "";
                string Argument = $"{param1}";


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
                startInfo.Arguments = $" -file \"{tempWadPath}\" {parametros} {Argument}";

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

            else
            {

                string param1 = comboBox1.SelectedItem?.ToString() ?? "";
                string parametros = ConstruirParametros18();
                string Argument = $"{param1}";
                EjecutarExe18(parametros + Argument);
                {

                }
            }
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

            {

            }

        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (checkBox11.Checked)
            {
                string chocolateDoomPath = "chocolate-doom.exe";


                string wadResourceName = "Choco_Master_Launcher.D_ROMERO.WAD";



                string tempWadPath = Path.Combine(Path.GetTempPath(), "D_ROMERO.WAD");
                string parametros = ConstruirParametros19();
                string param1 = comboBox1.SelectedItem?.ToString() ?? "";
                string Argument = $"{param1}";


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
                startInfo.Arguments = $" -file \"{tempWadPath}\" {parametros} {Argument}";

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

            else
            {

                string param1 = comboBox1.SelectedItem?.ToString() ?? "";
                string parametros = ConstruirParametros19();
                string Argument = $"{param1}";
                EjecutarExe19(parametros + Argument); ;
                {

                }

            }

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

            {

            }

        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (checkBox11.Checked)
            {
                string chocolateDoomPath = "chocolate-doom.exe";


                string wadResourceName = "Choco_Master_Launcher.D_THEDA2.WAD";



                string tempWadPath = Path.Combine(Path.GetTempPath(), "D_THEDA2.WAD");
                string parametros = ConstruirParametros20();
                string param1 = comboBox1.SelectedItem?.ToString() ?? "";
                string Argument = $"{param1}";


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
                startInfo.Arguments = $" -file \"{tempWadPath}\" {parametros} {Argument}";

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

            else
            {

                string param1 = comboBox1.SelectedItem?.ToString() ?? "";
                string parametros = ConstruirParametros20();
                string Argument = $"{param1}";
                EjecutarExe20(parametros + Argument); 
                {

                }

            }

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

            {

            }

        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (checkBox11.Checked)
            {
                string chocolateDoomPath = "chocolate-doom.exe";


                string wadResourceName = "Choco_Master_Launcher.D_COUNT2.WAD";



                string tempWadPath = Path.Combine(Path.GetTempPath(), "D_COUNT2.WAD");
                string parametros = ConstruirParametros21();
                string param1 = comboBox1.SelectedItem?.ToString() ?? "";
                string Argument = $"{param1}";


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
                startInfo.Arguments = $" -file \"{tempWadPath}\" {parametros} {Argument}";
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

            else
            {

                string param1 = comboBox1.SelectedItem?.ToString() ?? "";
                string parametros = ConstruirParametros21();
                string Argument = $"{param1}";
                EjecutarExe21(parametros + Argument);
                {

                }

            }

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

            {

            }

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

        private void button1_MouseEnter(object sender, EventArgs e)
        {

            textBox2.Text = "Name: Attack";
            textBox3.Text = "Author: Tim Willits";
            textBox4.Text = "Level replaced: Map 01";


            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            pictureBox1.Image = imagen2;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {

            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            pictureBox1.Image = imagen1;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            textBox2.Text = "Name: Black Tower";
            textBox3.Text = "Author: Sverre Andre Kvernmo \"Cranium\"";
            textBox4.Text = "Level replaced: Map 25";

            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            pictureBox1.Image = imagen4;

        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            pictureBox1.Image = imagen3;
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {

            textBox2.Text = "Name: Bloodsea Keep";
            textBox3.Text = "Author: Sverre Andre Kvernmo \"Cranium\"";
            textBox4.Text = "Level replaced: Map 07";


            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            pictureBox1.Image = imagen6;

        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            pictureBox1.Image = imagen5;
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {

            textBox2.Text = "Name: Canyon";
            textBox3.Text = "Author: Tim Willits";
            textBox4.Text = "Level replaced: Map 01";


            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            pictureBox1.Image = imagen8;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            pictureBox1.Image = imagen7;
        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {
            textBox2.Text = "Name: The Catwalk";
            textBox3.Text = "Author: Christen David Klie";
            textBox4.Text = "Level replaced: Map 01";


            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            pictureBox1.Image = imagen10;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            pictureBox1.Image = imagen9;
        }

        private void button6_MouseEnter(object sender, EventArgs e)
        {
            textBox2.Text = "Name: The Combine";
            textBox3.Text = "Author: Christen David Klie";
            textBox4.Text = "Level replaced: Map 01";


            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            pictureBox1.Image = imagen12;
        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            pictureBox1.Image = imagen11;
        }

        private void button7_MouseEnter(object sender, EventArgs e)
        {
            textBox2.Text = "Name: The Fistula";
            textBox3.Text = "Author: Christen David Klie";
            textBox4.Text = "Level replaced: Map 01";


            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            pictureBox1.Image = imagen14;
        }

        private void button7_MouseLeave(object sender, EventArgs e)
        {
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            pictureBox1.Image = imagen13;
        }

        private void button8_MouseEnter(object sender, EventArgs e)
        {
            textBox2.Text = "Name: The Garrison";
            textBox3.Text = "Author: Christen David Klie";
            textBox4.Text = "Level replaced: Map 01";


            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            pictureBox1.Image = imagen16;
        }

        private void button8_MouseLeave(object sender, EventArgs e)
        {
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            pictureBox1.Image = imagen15;
        }

        private void button9_MouseEnter(object sender, EventArgs e)
        {
            textBox2.Text = "Name: Geryon";
            textBox3.Text = "Author: John W. Anderson \" Dr Sleep\"";
            textBox4.Text = "Level replaced: Map 08";


            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            pictureBox1.Image = imagen18;
        }

        private void button9_MouseLeave(object sender, EventArgs e)
        {
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            pictureBox1.Image = imagen17;
        }

        private void button10_MouseEnter(object sender, EventArgs e)
        {
            textBox2.Text = "Name: Titan Manor";
            textBox3.Text = "Author: Jim Flynn";
            textBox4.Text = "Level replaced: Map 01";


            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            pictureBox1.Image = imagen20;
        }

        private void button10_MouseLeave(object sender, EventArgs e)
        {
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            pictureBox1.Image = imagen19;
        }

        private void button11_MouseEnter(object sender, EventArgs e)
        {
            textBox2.Text = "Name: Mephisto's Maosoleum";
            textBox3.Text = "Author: Sverre Andre Kvernmo \"Cranium\"";
            textBox4.Text = "Level replaced: Map 07";


            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            pictureBox1.Image = imagen22;


        }

        private void button11_MouseLeave(object sender, EventArgs e)
        {
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            pictureBox1.Image = imagen21;
        }

        private void button12_MouseEnter(object sender, EventArgs e)
        {
            textBox2.Text = "Name: Minos' Judgement";
            textBox3.Text = "Author: John W. Anderson \" Dr Sleep\"";
            textBox4.Text = "Level replaced: Map 05";


            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            pictureBox1.Image = imagen24;
        }

        private void button12_MouseLeave(object sender, EventArgs e)
        {
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            pictureBox1.Image = imagen23;
        }

        private void button13_MouseEnter(object sender, EventArgs e)
        {
            textBox2.Text = "Name: Nessus";
            textBox3.Text = "Author: John W. Anderson \" Dr Sleep\"";
            textBox4.Text = "Level replaced: Map 07";


            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            pictureBox1.Image = imagen26;

        }

        private void button13_MouseLeave(object sender, EventArgs e)
        {
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            pictureBox1.Image = imagen25;
        }

        private void button14_MouseEnter(object sender, EventArgs e)
        {
            textBox2.Text = "Name: Paradox";
            textBox3.Text = "Author: Tom Mustaine";
            textBox4.Text = "Level replaced: Map 01";


            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            pictureBox1.Image = imagen28;

        }

        private void button14_MouseLeave(object sender, EventArgs e)
        {
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            pictureBox1.Image = imagen27;


        }

        private void button15_MouseEnter(object sender, EventArgs e)
        {
            textBox2.Text = "Name: Subspace";
            textBox3.Text = "Author: Christen David Klie";
            textBox4.Text = "Level replaced: Map 01";


            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            pictureBox1.Image = imagen30;


        }

        private void button15_MouseLeave(object sender, EventArgs e)
        {
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            pictureBox1.Image = imagen29;


        }

        private void button16_MouseEnter(object sender, EventArgs e)
        {
            textBox2.Text = "Name: Subterra";
            textBox3.Text = "Author: Christen David Klie";
            textBox4.Text = "Level replaced: Map 01";


            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            pictureBox1.Image = imagen32;

        }

        private void button16_MouseLeave(object sender, EventArgs e)
        {
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            pictureBox1.Image = imagen31;

        }

        private void button17_MouseEnter(object sender, EventArgs e)
        {
            textBox2.Text = "Name: The Express Elevator to Hell";
            textBox3.Text = "Author: Sverre Andre Kvernmo \"Cranium\"";
            textBox4.Text = "Level replaced: Map 31";


            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            pictureBox1.Image = imagen34;

        }

        private void button17_MouseLeave(object sender, EventArgs e)
        {
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            pictureBox1.Image = imagen33;
        }

        private void button18_MouseEnter(object sender, EventArgs e)
        {
            textBox2.Text = "Name: Trapped on Titan";
            textBox3.Text = "Author: Jim Flynn";
            textBox4.Text = "Level replaced: Map 01";


            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            pictureBox1.Image = imagen36;


        }

        private void button18_MouseLeave(object sender, EventArgs e)
        {
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            pictureBox1.Image = imagen35;


        }

        private void button19_MouseEnter(object sender, EventArgs e)
        {
            textBox2.Text = "Name: Vesperas";
            textBox3.Text = "Author: John W. Anderson \"Dr. Sleep\"";
            textBox4.Text = "Level replaced: Map 09";


            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            pictureBox1.Image = imagen38;


        }

        private void button19_MouseLeave(object sender, EventArgs e)
        {
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            pictureBox1.Image = imagen37;


        }

        private void button20_MouseEnter(object sender, EventArgs e)
        {
            textBox2.Text = "Name: Virgil's lead";
            textBox3.Text = "Author: John W. Anderson \"Dr. Sleep\"";
            textBox4.Text = "Level replaced: Map 03";


            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            pictureBox1.Image = imagen40;


        }

        private void button20_MouseLeave(object sender, EventArgs e)
        {
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            pictureBox1.Image = imagen39;


        }

        private void button21_MouseEnter(object sender, EventArgs e)
        {
            textBox2.Text = "Name: Bad dream";
            textBox3.Text = "Author: Sverre Andre Kvernmo \"Cranium\"";
            textBox4.Text = "Level replaced: Map 32";


            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            pictureBox1.Image = imagen42;


        }

        private void button21_MouseLeave(object sender, EventArgs e)
        {
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            pictureBox1.Image = imagen41;


        }

        private string ConstruirParametros22()
        {
            string parametros2 = "";
            if (checkBox14.Checked)
            {
                parametros2 += "chocolate-doom -respawn ";
            }
            if (checkBox15.Checked)
            {
                parametros2 += "chocolate-doom -fast ";
            }
            if (checkBox16.Checked)
            {
                parametros2 += "chocolate-doom -nomonsters ";
            }


            return parametros2.Trim();

        }

        private void button22_Click(object sender, EventArgs e)
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
            if (checkBox1.Checked)
            {

                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;
                button9.Enabled = true;
                button10.Enabled = true;
                button11.Enabled = true;
                button12.Enabled = true;
                button13.Enabled = true;
                button14.Enabled = true;
                button15.Enabled = true;
                button16.Enabled = true;
                button17.Enabled = true;
                button18.Enabled = true;
                button19.Enabled = true;
                button20.Enabled = true;
                button21.Enabled = true;
               
            }
            else
            {

                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button10.Enabled = false;
                button11.Enabled = false;
                button12.Enabled = false;
                button13.Enabled = false;
                button14.Enabled = false;
                button15.Enabled = false;
                button16.Enabled = false;
                button17.Enabled = false;
                button18.Enabled = false;
                button19.Enabled = false;
                button20.Enabled = false;
                button21.Enabled = false;
               
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
            if (checkBox2.Checked)
            {

                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;
                button9.Enabled = true;
                button10.Enabled = true;
                button11.Enabled = true;
                button12.Enabled = true;
                button13.Enabled = true;
                button14.Enabled = true;
                button15.Enabled = true;
                button16.Enabled = true;
                button17.Enabled = true;
                button18.Enabled = true;
                button19.Enabled = true;
                button20.Enabled = true;
                button21.Enabled = true;

            }
            else
            {

                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button10.Enabled = false;
                button11.Enabled = false;
                button12.Enabled = false;
                button13.Enabled = false;
                button14.Enabled = false;
                button15.Enabled = false;
                button16.Enabled = false;
                button17.Enabled = false;
                button18.Enabled = false;
                button19.Enabled = false;
                button20.Enabled = false;
                button21.Enabled = false;

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
            if (checkBox3.Checked)
            {

                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;
                button9.Enabled = true;
                button10.Enabled = true;
                button11.Enabled = true;
                button12.Enabled = true;
                button13.Enabled = true;
                button14.Enabled = true;
                button15.Enabled = true;
                button16.Enabled = true;
                button17.Enabled = true;
                button18.Enabled = true;
                button19.Enabled = true;
                button20.Enabled = true;
                button21.Enabled = true;

            }
            else
            {

                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button10.Enabled = false;
                button11.Enabled = false;
                button12.Enabled = false;
                button13.Enabled = false;
                button14.Enabled = false;
                button15.Enabled = false;
                button16.Enabled = false;
                button17.Enabled = false;
                button18.Enabled = false;
                button19.Enabled = false;
                button20.Enabled = false;
                button21.Enabled = false;

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
            if (checkBox4.Checked)
            {

                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;
                button9.Enabled = true;
                button10.Enabled = true;
                button11.Enabled = true;
                button12.Enabled = true;
                button13.Enabled = true;
                button14.Enabled = true;
                button15.Enabled = true;
                button16.Enabled = true;
                button17.Enabled = true;
                button18.Enabled = true;
                button19.Enabled = true;
                button20.Enabled = true;
                button21.Enabled = true;

            }
            else
            {

                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button10.Enabled = false;
                button11.Enabled = false;
                button12.Enabled = false;
                button13.Enabled = false;
                button14.Enabled = false;
                button15.Enabled = false;
                button16.Enabled = false;
                button17.Enabled = false;
                button18.Enabled = false;
                button19.Enabled = false;
                button20.Enabled = false;
                button21.Enabled = false;

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
            if (checkBox5.Checked)
            {

                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;
                button9.Enabled = true;
                button10.Enabled = true;
                button11.Enabled = true;
                button12.Enabled = true;
                button13.Enabled = true;
                button14.Enabled = true;
                button15.Enabled = true;
                button16.Enabled = true;
                button17.Enabled = true;
                button18.Enabled = true;
                button19.Enabled = true;
                button20.Enabled = true;
                button21.Enabled = true;

            }
            else
            {

                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button10.Enabled = false;
                button11.Enabled = false;
                button12.Enabled = false;
                button13.Enabled = false;
                button14.Enabled = false;
                button15.Enabled = false;
                button16.Enabled = false;
                button17.Enabled = false;
                button18.Enabled = false;
                button19.Enabled = false;
                button20.Enabled = false;
                button21.Enabled = false;

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
            if (checkBox7.Checked)
            {

                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;
                button9.Enabled = true;
                button10.Enabled = true;
                button11.Enabled = true;
                button12.Enabled = true;
                button13.Enabled = true;
                button14.Enabled = true;
                button15.Enabled = true;
                button16.Enabled = true;
                button17.Enabled = true;
                button18.Enabled = true;
                button19.Enabled = true;
                button20.Enabled = true;
                button21.Enabled = true;

            }
            else
            {

                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button10.Enabled = false;
                button11.Enabled = false;
                button12.Enabled = false;
                button13.Enabled = false;
                button14.Enabled = false;
                button15.Enabled = false;
                button16.Enabled = false;
                button17.Enabled = false;
                button18.Enabled = false;
                button19.Enabled = false;
                button20.Enabled = false;
                button21.Enabled = false;

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

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox9.Checked)
            {
                comboBox1.Enabled = true;
               
            }
            else 
            {
                comboBox1.Enabled = false;
                comboBox1.SelectedIndex = -1;
            }
            if (checkBox9.Checked)
            {

                checkBox16.Checked = false;
            }
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox10.Checked)
            {
                comboBox7.Enabled = true;

            }
            else
            {
                comboBox7.Enabled = false;
                comboBox7.SelectedIndex = -1;
            }
        }


        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox18.Checked)
            {
                comboBox4.Enabled = true;

            }
            else
            {
                comboBox4.Enabled = false;
                comboBox4.SelectedIndex = -1;
            }
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox12.Checked)
            {
                comboBox5.Enabled = true;

            }
            else
            {
                comboBox5.Enabled = false;
                comboBox5.SelectedIndex = -1;
            }
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox13.Checked)
            {
                comboBox6.Enabled = true;

            }
            else
            {
                comboBox6.Enabled = false;
                comboBox6.SelectedIndex = -1;
            }
        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox17.Checked)
            {
                comboBox2.Enabled = false;
                comboBox2.SelectedIndex = -1;
            
            
            }
            else
            {
                comboBox2.Enabled = true;
                
            }
            if (checkBox17.Checked)
            {
                checkBox14.Checked = false;
                checkBox15.Checked = false;
                checkBox16.Checked = false;
            }
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox14.Checked)
            {
                
                checkBox16.Checked = false;
                checkBox17.Checked = false;
            }
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox15.Checked)
            {

                checkBox16.Checked = false;
                checkBox17.Checked = false;
            }
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox16.Checked)
            {

                checkBox10.Checked = false;
                checkBox14.Checked = false;
                checkBox15.Checked = false;
                checkBox17.Checked = false;
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }











        private int GetFormArea(Size size)
        {
            return size.Width;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            Control control = (Control)sender;

            float scaleFactor = (float)GetFormArea(control.Size) / (float)_lastFormSize;

            ResizeFont(this.Controls, scaleFactor);

            _lastFormSize = GetFormArea(control.Size);

        }

        private void ResizeFont(Control.ControlCollection coll, float scaleFactor)
        {
            foreach (Control c in coll)
            {
                if (c.HasChildren)
                {
                    ResizeFont(c.Controls, scaleFactor);
                }
                else
                {
                    //if (c.GetType().ToString() == "System.Windows.Form.Label")
                    if (true)
                    {
                        // scale font
                        c.Font = new Font(c.Font.FontFamily.Name, c.Font.Size * scaleFactor);
                    }
                }
            }
        }
    }
}