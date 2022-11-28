using Microsoft.OData.Edm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoEcole
{
    class Moniteur
    {
        public string nom { get; set; }
        public string prenom { get; set; }
        public string cin { get; set; }
        public string telephone { get; set; }
        public Date dateNaiss { get; set; }
        public string adresse { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public Date dateRec { get; set; }
        public int nbrConge { get; set; }
        public double salaire { get; set; }
        public int rib { get; set; }
        public string NumCnss { get; set; }
        public string role { get; set; }

        public Moniteur(string nom, string prenom, string cin, string telephone, Date dateNaiss, string adresse, string username, string password, Date dateRec, int nbrConge, double salaire, int rib, string numCnss, string role)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.cin = cin;
            this.telephone = telephone;
            this.dateNaiss = dateNaiss;
            this.adresse = adresse;
            this.username = username;
            this.password = password;
            this.dateRec = dateRec;
            this.nbrConge = nbrConge;
            this.salaire = salaire;
            this.rib = rib;
            NumCnss = numCnss;
            this.role = role;
        }
    }
}
