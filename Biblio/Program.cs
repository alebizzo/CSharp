using System;

namespace Biblio
{

    public class Utente : Persona
	{

        public string Id { get; set; }
        public int AnnoIscrizione { get; set; }

        public override string Denominazione {
            get {
                return "Id: " + Id + " / " + Nome + " " + Cognome;
            }
        }

    }

    public class Libro 
    {
    
        private string id { get; set; }
        private string titolo { get; set; }
        private string autore { get; set; }
        private Utente utente { get; set; }

        public Libro (string id, string titolo, string autore) {
            this.id = id;
            this.titolo = titolo;
            this.autore = autore;
            this.utente = null;
        }

        public string Descrizione() {
            return this.titolo + " di " + this.autore;
        }

        public void Prestito(Utente utente) {
            if (this.utente != null) {
                Console.WriteLine($"Titolo già in prestito a {this.utente.Denominazione}");
                return;
            }
            this.utente = utente;
            Console.WriteLine($"Titolo prestato a {this.utente.Denominazione}");
        }   

        public void Restituzione() {
            Console.WriteLine($"{this.utente.Denominazione} ha restituito il libro");
            this.utente = null;
        }

    }

    public class Biblioteca 
    {
    
        public static void Main(string[] arrgs) {

            Utente utente_01 = new Utente() {Id = "01", Nome = "Mario", Cognome = "Rossi", AnnoIscrizione = 2015};
            Console.WriteLine(utente_01.Denominazione);

            Utente utente_02 = new Utente() {Id = "02", Nome = "Giuseppe", Cognome = "Verdi", AnnoIscrizione = 2012};
            Console.WriteLine(utente_02.Denominazione);

            Libro libro = new Libro("L001", "Ventimila leghe sotto i mari", "Jules Verne");
            Console.WriteLine(libro.Descrizione());

            libro.Prestito(utente_01);
            libro.Prestito(utente_02);

            libro.Restituzione();
            libro.Prestito(utente_02);

        }
    }

    public class Persona 
    {

        public string Nome { get; set; }
        public string Cognome { get; set; }

        public virtual string Denominazione {
            get {
                return Nome + " " + Cognome;
            }
        }

    }
}
