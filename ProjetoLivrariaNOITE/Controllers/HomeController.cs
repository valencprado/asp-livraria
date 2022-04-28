using MySql.Data.MySqlClient;
using ProjetoLivrariaNOITE.Dados;
using ProjetoLivrariaNOITE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoLivrariaNOITE.Controllers
{
    public class HomeController : Controller
    {
        ClLivros cl = new ClLivros();
        clLivrosAcoes ac = new clLivrosAcoes();
       
        public void carregaAutores()
        {
            List<SelectListItem> autores = new List<SelectListItem>();
            using (MySqlConnection con = new MySqlConnection("Server=localhost;DataBase:bdLivrariaNoite;User=root;pwd=Figure.09"))
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("select * from tbAutor where codStatus=1", con);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while(rdr.Read())
                {
                    autores.Add(new SelectListItem
                    {
                        Text = rdr[1].ToString(),
                        Value = rdr[0].ToString()
                    });
                }
                con.Close();

            }
            ViewBag.autores = new SelectList(autores, "Value", "Text");
        }

        public void carregaStatus()
        {
            List<SelectListItem> status = new List<SelectListItem>();
            using (MySqlConnection con = new MySqlConnection("Server=localhost;DataBase:bdLivrariaNoite;User=root;pwd=12345678"))
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("select * from tbStatus", con);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    status.Add(new SelectListItem
                    {
                        Text = rdr[1].ToString(),
                        Value = rdr[0].ToString()
                    });
                }
                con.Close();

            }
            ViewBag.autores = new SelectList(status, "Value", "Text");
        }


        public ActionResult CadLivro()
        {
            carregaAutores();
            return View();
        } 
        [HttpPost] // cadastro só acontece quando o botão é ativado
        public ActionResult CadLivro(ClLivros cm)// passar as variáveis com os dados para o cadastro
        {
            carregaAutores();
            cm.codStatus = Request["status"];
            ac.inserirLivro(cm);
            return View();
        }
        public ActionResult CadAutor()
        {
            carregaStatus();
            return View();
        }
        [HttpPost] // cadastro só acontece quando o botão é ativado
        public ActionResult CadAutor(ClLivros cm)// passar as variáveis com os dados para o cadastro
        {
            carregaStatus();
            cm.codStatus = Request["status"];
            ac.inserirLivro(cm);
            return View();
        }

        public ActionResult Cadstatus()
        {
          
            return View();
        }
        [HttpPost] // cadastro só acontece quando o botão é ativado
        public ActionResult CadStatus(ClLivros cm)// passar as variáveis com os dados para o cadastro
        {
          

            ac.inserirStatus(cm);
            return View();
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}