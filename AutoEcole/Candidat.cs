using Microsoft.OData.Edm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoEcole
{
    class Candidat
    {
        public string nom { get; set; }
        public string prenom { get; set; }
        public string cin { get; set; }
        public string telephone { get; set; }
        public Date dateNaiss { get; set; }
        public string adresse { get; set; }
        public string cat_permis { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string situation { get; set; }
        public string typeinscription { get; set; }
        public string role { get; set; }
        public DateTime dateIncription { get; set; }
        

        public Candidat(string nom, string prenom, string cin, string telephone, Date dateNaiss, string adresse, string cat_permis, string username, string password, string situation, string typeinscription, string role, DateTime dateIncription)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.cin = cin;
            this.telephone = telephone;
            this.dateNaiss = dateNaiss;
            this.adresse = adresse;
            this.cat_permis = cat_permis;
            this.username = username;
            this.password = password;
            this.situation = situation;
            this.typeinscription = typeinscription;
            this.role = role;
            this.dateIncription = dateIncription; 
        }
    }
}
