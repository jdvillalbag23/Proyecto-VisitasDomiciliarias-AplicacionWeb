using System;
using System.Collections.Generic;
using VisitasDomiciliarias.App.Dominio;
using VisitasDomiciliarias.App.Persistencia.AppRepositorios;

namespace VisitasDomiciliarias.App.Consola
{
    class Program
    {
        private static IRepositorioPropietario _repoPropietario = new RepositorioPropietario(new Persistencia.AppContext());
        private static IRepositorioHistoriaClinica _repoHistoria = new RepositorioHistoriaClinica(new Persistencia.AppContext());
        private static IRepositorioMascota _repoMascotas = new RepositorioMascota(new Persistencia.AppContext());
        private static IRepositorioVeterinario _repoVeterinarios = new RepositorioVeterinario(new Persistencia.AppContext());
        private static IRepositorioMascotaVeterinario _repoMascVet = new RepositorioMascotaVeterinario(new Persistencia.AppContext());
        static void Main(string[] args)
        {
            Console.WriteLine("Ya casi");
            //AddPropietarioConMascota();
            //AddHistoria();
            //AddMascota();
            //DeleteHistoria(3);
            //DeleteMascota(1);
            //AsignarMascota();
            //AsignarVeterinario();
            //DeletePropietario(2);
            //AddVeterinario();
            //UpdateHistoria(4);
            //MasVet();
            //GetVeterinario(1);
            GetAllVeterinarios();
            
        }

        // private static void AddMascota()
        // {
        //     var mascota = new Mascota
        //     {
        //         Nombre = "Gardfield",
        //         Raza = "Bengala",
        //         Edad = 2,
        //         Tipo = Tipo.Gato,
        //         Genre = Sexo.Macho,
        //         PropietarioId = 4,        //         

        //     }; _repoMascotas.AddMascota(mascota);
        // }
        private static void AddPropietarioConMascota()
        {
            var propietario = new Propietario
            {
                Identificacion = "1070954763",
                Nombres = "María Alejandra",
                Apellidos = "Prieto Peña",
                Direccion = "Calle 123 166 10",
                Telefono = "8912145",
                Mascotas = new List<Mascota>
            {
                //new Mascota{Nombre="", Raza="Siamés", Edad= 4 , Tipo=Tipo.Gato, Genre=Sexo.Macho},
                new Mascota{Nombre="Laica", Raza="Pincher", Edad= 3.5 , Tipo=Tipo.Perro, Genre=Sexo.Hembra},
                new Mascota{Nombre="Kira", Raza="Pitbull", Edad= 2 , Tipo=Tipo.Perro, Genre=Sexo.Hembra},

            }

            };
            _repoPropietario.AddPropietario(propietario);
        }

        private static void AddHistoria()
        {
            var historia = new HistoriaClinica
            {
                Temperatura = 28,
                Peso = 7.5,
                FrecRespiratoria = 26,
                FrecCardiaca = 65,
                EstadoAnimo = "Alegre",
                FechaVisita = new DateTime(2021,5,09),
                Recomendaciones = "Cortar Uñas",
                MascotaId = 1,
                VeterinarioId = 1,
                //Mascota = new Mascota{Nombre="Thor", Raza="Rottweiler", Edad= 3 , Tipo=Tipo.perro},
                //Veterinario = new Veterinario{Nombres="Antonella", Apellidos="Villalba González", Identificacion="35950818", Telefono="8438974", TarjProfesional="Abc-12753"}

            };
            _repoHistoria.AddHistoria(historia);
        }

        private static void DeleteHistoria(int idHistoria)
        {
            _repoHistoria.DeleteHistoria(idHistoria);
        }

        private static void DeletePropietario(int idPropietario)
        {
            _repoPropietario.DeletePropietario(idPropietario);
        }

        private static void DeleteMascota(int idMascota)
        {
            _repoMascotas.DeleteMascota(idMascota);
        }

        private static void AsignarMascota()
        {
            var mascota = _repoHistoria.AsignarMascota(6, 1);
            Console.WriteLine(mascota.Nombre + " " + mascota.Tipo);
        }

        private static void AsignarVeterinario()
        {
            var veterinario = _repoHistoria.AsignarVeterinario(4, 6);
            Console.WriteLine(veterinario.Nombres + " " + veterinario.Apellidos);
        }

        private static void AddVeterinario()
        {
            var veterinario = new Veterinario
            {
                Nombres = "Jaime David",
                Apellidos = "Molina Carreño",
                Identificacion = "1070951416",
                Telefono = "3153137584",
                TarjProfesional = "abc-1512"
            };
            _repoVeterinarios.AddVeterinario(veterinario);

        }

        private static void UpdateHistoria(int idHistoria)
        {
            var historiaEncontrada = _repoHistoria.GetHistoria(idHistoria);
            if (historiaEncontrada != null)
            {
                historiaEncontrada.EstadoAnimo = "Hiperactivo";
            }
            _repoHistoria.UpdateHistoria(historiaEncontrada);
        }

        private static void MasVet()
        {
            var mascota = _repoMascVet.AsignarMascota(3,2);
            Console.WriteLine(mascota.Nombre + " " + mascota.Raza);
        }

        private static void GetAllVeterinarios ()
        {
            var veremos = _repoMascotas.GetAllVeterinarios(1);
            foreach(var ojala in veremos)
            {
                Console.WriteLine(ojala.MascotaId +" "+ ojala.VeterinarioId + " " + ojala.Veterinario.Nombres + " " + ojala.Veterinario.Apellidos);
            }
        }

       
    }


}

