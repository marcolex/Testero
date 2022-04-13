using Ingenya.DataAccess.Crud;
using Ingenya.Entities;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Ingenya.ApiCore
{
    public class ReporteManagement : BaseManagement
    {

        //double vElevation;

        //double[,] matrizCP;

        //double[,] matrizMUC;

        //double[,] matrizRAH;

        //double[,] matrizCarta;

        //double[,] matrizCompletaCP;

        //private ReporteCrud crudFactory;

        //double MUP_DBT1;
        //double MUP_DBT2;

        //double MUP_W1;
        //double MUP_W2;

        //public ReporteManagement()
        //{

        //    crudFactory = new ReporteCrud();
        //}

        //public Reporte RetrieveReporte(Reporte obj)
        //{
        //    return crudFactory.Retrieve<Reporte>(obj);
        //}
        //public void CreateReporte(Reporte obj)
        //{
        //    try
        //    {
        //        crudFactory.Create(obj);
        //    }
        //    catch (Exception)
        //    {
        //        //HandleException(ex);
        //    }

        //}
        //public void UpdateReporte(Reporte obj)
        //{

        //    crudFactory.Update(obj);
        //}
        //public void DeleteReporte(Reporte obj)
        //{

        //    crudFactory.Delete(obj);
        //}
        //public IList RetrieveAllReporte()
        //{

        //    List<Reporte> lista = crudFactory.RetrieveAll<Reporte>();
        //    return lista;
        //}

        //public string Reportes(string MUPDBT1, string MUPDBT2, string MUPW1, string MUPW2)
        //{
        //    string path = "";
        //    var grafico = new Gra();
        //    //Gra grafico = new Gra(4, CargarMUP(MUPDBT1, MUPDBT2, MUPW1, MUPW2), 3500);
        //    /*  using (Gra grafico = new Gra(4, CargarMUP(MUPDBT1, MUPDBT2, MUPW1, MUPW2), 3500))
        //      {
        //          path = grafico.GuardarReporte();
        //      }*/
        //    return path;
        //}

        //public double[,] CargarMUP(string MUPDBT1, string MUPDBT2, string MUPW1, string MUPW2)
        //{
        //    MUP_DBT1 = double.Parse(MUPDBT1);
        //    MUP_DBT2 = double.Parse(MUPDBT2);

        //    MUP_W1 = double.Parse(MUPW1);
        //    MUP_W2 = double.Parse(MUPW2);

        //    matrizCP = new double[2, 2];

        //    matrizCP[0, 0] = MUP_DBT1;

        //    matrizCP[0, 1] = MUP_W1;

        //    matrizCP[1, 0] = MUP_DBT2;

        //    matrizCP[1, 1] = MUP_W2;

        //    return matrizCP;
        //}
    }
}
