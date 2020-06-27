using Cnpj.Resources;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cnpj
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
           
        }



        private void metroButton5_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                caminholog.Text = open.FileName;

            }
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                caminho.Text = open.FileName;

            }
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            String caminhoa = caminho.Text;
            String caminhologa = caminholog.Text;
            //Thread t = new Thread(new ThreadStart(Cnpj(caminhoa,caminhologa)));
            Cnpj(caminhoa,caminhologa);
        }

        public static void Cnpj(String caminho, String caminholog)
        {
            
            
            String cnpj = "";
            String nomeempresa = "";
            String identificador = "";
            String fantasia = "";
            String datasituacao = "";
            String situacaocadastral = "";
            String dataabertura = "";
            String motivosituacao = "";
            String cnae = "";
            String tipologradouro = "";
            String endereco = "";
            String numero = "";
            String complemento = "";
            String bairro = "";
            String cep = "";
            String uf = " ";
            String cidade = "";
            String telefone1 = "";
            String email = "";
            String porte = "";
            String cnpjOld = "22";
            String naturezajuridica = "";
            String qualificacaopessoaresp = "";
            String capital = "";

            String opcaosimples = "";
            String dataopcaosimples = "";
            String dataexclusaosimles = "";
            String opcaomei = "";
            String situacaoespecial = "";
            String datasituacaoespecial = "";
            int verificacao = 0;
            

            int qtold = 0;

            Form1 fo = new Form1();

            var connectO = "Host=localhost;Username=postgres;Password=1816;Database=adonai-cnpj";
            var con = new NpgsqlConnection(connectO);
            var cons = new NpgsqlConnection(connectO);

            cons.Open();
            con.Open();



            var sql2 = "INSERT INTO socio(cnpj,Socio) VALUES(@cnpj,@socio)";
            var commands = new NpgsqlCommand(sql2, cons);

            var sql = "INSERT INTO basecnpj(cnpj,identificador,nomeempresa,fantasia,situacaocadastral," +
                "datasituacao,dataabertura,cnae,tipologradouro,endereco,numero,complemento,bairro,cep,uf,cidade," +
                "telefone1,email,porte,naturezajuridica,motivosituacao,qualificacaopessoaresp,capital,opcaosimples," +
                "dataopcaosimples,dataexclusaosimles,opcaomei,situacaoespecial,datasituacaoespecial)" +
                "" +
                " VALUES(@cnpj,@identificador,@nomeempresa,@fantasia,@situacaocadastral,@datasituacao,@dataabertura,@cnae,@tipologradouro,@endereco,@numero,@complemento,@bairro,@cep,@uf,@cidade,@telefone1,@email,@porte,@naturezajuridica,@motivosituacao,@qualificacaopessoaresp,@capital,@opcaosimples,@dataopcaosimples,@dataexclusaosimles,@opcaomei,@situacaoespecial,@datasituacaoespecial)";
            var command = new NpgsqlCommand(sql, con);


            int qt = 0;
            String linha;
            String aux;
            System.IO.StreamReader file = new System.IO.StreamReader(@caminho);
            while ((linha = file.ReadLine()) != null)
            {

                //System.Console.WriteLine(linha);
                qt++;
                int ntamanho = linha.Length;
                String[] dados = Regex.Split(linha, " ");


                situacaocadastral = linha.Substring(223, 2);
                verificacao = Convert.ToInt32(linha.Substring(0, 1));
                
                    
                cnpj = linha.Substring(3, 14);
                identificador = linha.Substring(17, 1);
                nomeempresa = linha.Substring(18, 150);
                fantasia = linha.Substring(167, 55);
                situacaocadastral = linha.Substring(223, 2);
                datasituacao = linha.Substring(225, 8);
                motivosituacao = linha.Substring(233, 2);
                naturezajuridica = linha.Substring(363, 4);
                dataabertura = linha.Substring(367, 8);
                cnae = linha.Substring(375, 7);
                tipologradouro = linha.Substring(382, 20);
                endereco = linha.Substring(402, 60);
                numero = linha.Substring(462, 6);
                complemento = linha.Substring(467, 156);
                bairro = linha.Substring(624, 50);
                cep = linha.Substring(674, 8);
                uf = linha.Substring(682, 2);
                cidade = linha.Substring(688, 50);
                telefone1 = linha.Substring(738, 36);
                email = linha.Substring(774, 115);
                qualificacaopessoaresp = linha.Substring(889, 2);
                capital = linha.Substring(891, 14);
                porte = linha.Substring(905, 2);
                opcaosimples = linha.Substring(907, 1);

                dataopcaosimples = linha.Substring(908, 8);
                dataexclusaosimles = linha.Substring(916, 8); ;
                opcaomei = linha.Substring(924, 1); ;
                situacaoespecial = linha.Substring(925, 23); ;
                datasituacaoespecial = linha.Substring(948, 8); ;



                if (verificacao == 2)
                {

                    try
                    {

                        commands.Parameters.AddWithValue("@cnpj", cnpj);
                        commands.Parameters.AddWithValue("@socio", nomeempresa.TrimEnd());
                           
                        if (cnpjOld == cnpj)
                        {
                            int validador = Util.Buscacnpj(cnpj);
                            if(validador == 1)
                            {
                                commands.ExecuteNonQuery();
                                Console.WriteLine("Sócio Cadastrado com Sucesso!!  " + qt);
                            }
                                
                        }

                        commands.Parameters.Clear();

                    }
                    catch (Exception ex)
                    {
                        using (System.IO.StreamWriter txt = new System.IO.StreamWriter(caminholog, true))
                        {
                            txt.WriteLine(ex);
                        }
                    }

                }
                else if (verificacao == 1)
                {

                    try
                    {



                        var aux1 = datasituacao.Substring(0, 4) + "-" + datasituacao.Substring(4, 2) + "-" + datasituacao.Substring(6, 2);
                        var aux2 = dataabertura.Substring(0, 4) + "-" + dataabertura.Substring(4, 2) + "-" + dataabertura.Substring(6, 2);
                        var aux3 = dataopcaosimples.Substring(0, 4) + "-" + dataopcaosimples.Substring(4, 2) + "-" + dataopcaosimples.Substring(6, 2);
                        var aux4 = dataexclusaosimles.Substring(0, 4) + "-" + dataexclusaosimles.Substring(4, 2) + "-" + dataexclusaosimles.Substring(6, 2);
                        var aux5 = datasituacaoespecial.Substring(0, 4) + "-" + datasituacaoespecial.Substring(4, 2) + "-" + datasituacaoespecial.Substring(6, 2);

                        if (dataabertura.Substring(1, 1) == "7" || dataabertura.Substring(1, 1) == "6" || dataabertura.Substring(1, 1) == "5" || dataabertura.Substring(1, 1) == "6" || dataabertura.Substring(1, 1) == "5" || dataabertura.Substring(1, 1) == "4" || dataabertura.Substring(1, 1) == "3" || dataabertura.Substring(1, 1) == "2" || dataabertura.Substring(1, 1) == "1")
                        {
                            aux2 = "1999-" + dataabertura.Substring(4, 2) + "-" + dataabertura.Substring(6, 2);
                        }
                        if (datasituacao.Substring(1, 1) == "7" || datasituacao.Substring(1, 1) == "6" || datasituacao.Substring(1, 1) == "5" || datasituacao.Substring(1, 1) == "6" || datasituacao.Substring(1, 1) == "5" || datasituacao.Substring(1, 1) == "4" || datasituacao.Substring(1, 1) == "3" || datasituacao.Substring(1, 1) == "2" || datasituacao.Substring(1, 1) == "1")
                        {
                            aux1 = "1999-" + datasituacao.Substring(4, 2) + "-" + datasituacao.Substring(6, 2);
                        }


                        if (dataopcaosimples == "00000000" || dataopcaosimples == "        ")
                        {
                            aux3 = "1900-01-01";
                        }
                        if (dataexclusaosimles == "00000000" || dataexclusaosimles == "        ")
                        {
                            aux4 = "1900-01-01";
                        }
                        if (datasituacaoespecial == "        " || datasituacaoespecial == "00000000")
                        {
                            aux5 = "1900-01-01";
                        }


                        // command.Parameters.AddWithValue("@ID", qt);
                        command.Parameters.AddWithValue("@cnpj", cnpj);
                        command.Parameters.AddWithValue("@identificador", identificador);
                        command.Parameters.AddWithValue("@nomeempresa", nomeempresa.TrimEnd());
                        command.Parameters.AddWithValue("@fantasia", fantasia.TrimEnd());
                        command.Parameters.AddWithValue("@situacaocadastral", situacaocadastral);
                        command.Parameters.AddWithValue("@datasituacao", Convert.ToDateTime(aux1));
                        command.Parameters.AddWithValue("@naturezajuridica", naturezajuridica);
                        command.Parameters.AddWithValue("@dataabertura", Convert.ToDateTime(aux2));
                        command.Parameters.AddWithValue("@cnae", cnae);
                        command.Parameters.AddWithValue("@tipologradouro", tipologradouro.TrimEnd());
                        command.Parameters.AddWithValue("@endereco", endereco.TrimEnd());
                        command.Parameters.AddWithValue("@numero", numero);
                        command.Parameters.AddWithValue("@complemento", complemento.TrimEnd());
                        command.Parameters.AddWithValue("@bairro", bairro.TrimEnd());
                        command.Parameters.AddWithValue("@cep", cep.TrimEnd());
                        command.Parameters.AddWithValue("@uf", uf);
                        command.Parameters.AddWithValue("@cidade", cidade.TrimEnd());
                        command.Parameters.AddWithValue("@telefone1", telefone1.TrimEnd());
                        command.Parameters.AddWithValue("@email", email.TrimEnd());
                        command.Parameters.AddWithValue("@porte", porte);
                        command.Parameters.AddWithValue("@motivosituacao", motivosituacao.TrimEnd());
                        command.Parameters.AddWithValue("@qualificacaopessoaresp", qualificacaopessoaresp.TrimEnd());
                        command.Parameters.AddWithValue("@capital", capital.TrimEnd());
                        command.Parameters.AddWithValue("@opcaosimples", opcaosimples.TrimEnd());
                        command.Parameters.AddWithValue("@dataopcaosimples", Convert.ToDateTime(aux3));
                        command.Parameters.AddWithValue("@dataexclusaosimles", Convert.ToDateTime(aux4));
                        command.Parameters.AddWithValue("@datasituacaoespecial", Convert.ToDateTime(aux5));
                        command.Parameters.AddWithValue("@opcaomei", opcaomei);
                        command.Parameters.AddWithValue("@situacaoespecial", situacaoespecial.TrimEnd());


                    if (situacaocadastral == "02" || situacaocadastral == "03")
                    {
                        int validador = Util.Buscacnpj(cnpj);
                        if (validador == 0)
                        {
                                command.ExecuteNonQuery();
                                Console.WriteLine("Empresa Cadastrada com sucesso com sucesso  " + qt);
                        }
                            
                    }

                        
                        
                        cnpjOld = cnpj;
                        

                    command.Parameters.Clear();


                        qtold = qt;
                    }
                    catch (Exception ex)
                    {
                        using (System.IO.StreamWriter txt = new System.IO.StreamWriter(caminholog, true))
                        {
                            txt.WriteLine(qt + " ERRRRRROOOOO " + ex);
                        }
                    }
                }
                else if (verificacao == 6)
                {

                }
                    
                
                else
                {
                    cnpjOld = cnpj;
                }

            }
            commands.Dispose();
            cons.Dispose();
            cons.Close();
            command.Dispose();
            con.Dispose();
            con.Close();
        }
    }
}
