using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace EFAGT.Models
{
    public class DAL
    {
        string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;


        public List<Tickets> requeteAffiche()//debut de la fonction affichage de requete
        {
            List<Tickets> tickets = new List<Tickets>();//instanciation de la nouvelle nouvelle liste de collection 
            using (SqlConnection con = new SqlConnection(connectionString))//instanciation d'un lien sql
            {
                SqlCommand cmd = new SqlCommand("select * from TICKETS", con);//requete remontant le contenu de la table TICKETS

                cmd.CommandType = System.Data.CommandType.Text;//le type de requete sql qu'on va traiter
                con.Open();

                SqlDataReader rdr = cmd.ExecuteReader();
                while(rdr.Read())
                {

                    Tickets ticket = new Tickets();
                    if (!rdr.IsDBNull(rdr.GetOrdinal("idTicket"))) { ticket.idTicket = (int)rdr["idTickets"]; }//lis si le champ est différent de null et on stock la valeur dans la variable crée dans la classe
                    if (!rdr.IsDBNull(rdr.GetOrdinal("emplacementMaterielTicket"))) { ticket.emplacementMaterielTicket = (string)rdr["emplacementMaterielTicket"]; }
                    if (!rdr.IsDBNull(rdr.GetOrdinal("typeMaterielTicket"))) { ticket.typeMaterielTicket = (string)rdr["typeMaterielTicket"]; }
                    if (!rdr.IsDBNull(rdr.GetOrdinal("descriptionIncident"))) { ticket.descriptionIncident = (string)rdr["descriptionIncident"]; }
                    if (!rdr.IsDBNull(rdr.GetOrdinal("dateCreationIncident"))) { ticket.dateCreationIncident = (DateTime)rdr["dateCreationIncident"]; }
                    if (!rdr.IsDBNull(rdr.GetOrdinal("dateClotureIncident"))) { ticket.dateClotureIncident = (DateTime)rdr["dateClotureIncident"]; }
                    if (!rdr.IsDBNull(rdr.GetOrdinal("nomCellule"))) { ticket.nomCellule = (string)rdr["nomCellule"]; }
                    if (!rdr.IsDBNull(rdr.GetOrdinal("numeroSerieMAteriel"))) { ticket.numeroSerieMAteriel = (string)rdr["numeroSerieMAteriel"]; }
                    if (!rdr.IsDBNull(rdr.GetOrdinal("etatStatut"))) { ticket.etatStatut = (string)rdr["etatStatut"]; }




                    tickets.Add(ticket);//stock les données dans la liste
                }


            }

            return tickets;
        }

        public int insertionTickets(Tickets ticketsModel)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand comm = new SqlCommand("INSERT INTO TICKETS (idTicket, emplacementMaterielTicket, typeMaterielTicket, "
                    + "descriptionIncident, dateCreationIncident, dateClotureIncident, idUtilisateur, "
                    + "numeroSerieMAteriel, nomCellule, etatStatut) " +
                    "VALUES " +
                    "(@idTicket, @emplacementMaterielTicket, @typeMaterielTicket,@descriptionIncident,@dateCreationIncident, "
                    + "@dateClotureIncident, @idUtilisateur, @numeroSerieMAteriel,@nomCellule,@etatStatut", con);

                comm.CommandType = System.Data.CommandType.Text;

                comm.Parameters.AddWithValue("@idTicket", ((object)ticketsModel.idTicket) ?? DBNull.Value);
                comm.Parameters.AddWithValue("@emplacementMaterielTicket", ((object)ticketsModel.emplacementMaterielTicket) ?? DBNull.Value);
                comm.Parameters.AddWithValue("@typeMaterielTicket", ((object)ticketsModel.typeMaterielTicket) ?? DBNull.Value);
                comm.Parameters.AddWithValue("@descriptionIncident", ((object)ticketsModel.descriptionIncident) ?? DBNull.Value);
                comm.Parameters.AddWithValue("@dateCreationIncident", ((object)ticketsModel.dateCreationIncident) ?? DBNull.Value);
                comm.Parameters.AddWithValue("@dateClotureIncident", ((object)ticketsModel.dateClotureIncident) ?? DBNull.Value);
                comm.Parameters.AddWithValue("@numeroSerieMAteriel", ((object)ticketsModel.numeroSerieMAteriel) ?? DBNull.Value);
                comm.Parameters.AddWithValue("@nomCellule", ((object)ticketsModel.nomCellule) ?? DBNull.Value);
                comm.Parameters.AddWithValue("@etatStatut", ((object)ticketsModel.etatStatut) ?? DBNull.Value);

                con.Open();
                int i = comm.ExecuteNonQuery();
                con.Close();
                return i;

            }
        }
    }
}