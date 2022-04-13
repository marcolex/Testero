using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ingenya.Utilities
{
    public enum Acciones { Insertar , Modificar , Eliminar , Listar , Cargar };

    public enum TabActiva { TabGeneralInformation, TabOutsideAir, TabParticleConc, TabMUP, TabMUC, TabMUH, TabRAH, TabCarta };

    public enum TabActivaGeneralInfo
    {
        TabDesignCond, TabInternalSHL, TabInternalLHL
    };

    public class Formulas
    {
        //***** PRESION ATMOSFERICA*****
        //altitud en ft
        //patm en psia

        /*function PATM(altitude)

        PATM = 14.696 * (1 - altitude*6.8753E-6)^5.2559

        End function*/
        public static double PATM(double altitude)
        {
            double PATM = 14.696 * Math.Pow((1 - altitude * 6.8753E-6), 5.2559);
            return PATM;
        }

        //***** Presion Parcial de Vapor******
        /*Function PPW(W, pat)

        REM calcula la presion parcial de vapor a partir de la relacion de humedad y la presion atmosferica

        c = 0.62198

        REM c = 0.621945

        PPW = pat /(1 + c/(W+0.0000000001))

        End Function*/

        public static double PPW(double W, double pat)
        {
            double c = 0.62198;

            //double c = 0.621945;

            double PPW = pat / (1 + c / (W + 0.0000000001));
            return PPW;
        }


        //Presion Saturacion Vapor******
        /*Function PSW(T)

        REM Convert the Temp in °F to Rankine
        RT = T + 459.67

        c8 = -10440.397
        c9 = -11.29465
        c10 = -0.027022355
        c11 = 0.00001289036
        c12 = -0.0000000024780681
        c13 = 6.5459673

        PSW = Exp(c8/RT + c9 + c10* RT + c11* RT^2 + c12* RT^3 + c13* Log(RT))

        End Function*/

        public static double PSW(double T)
        {
            double RT = T + 459.67;

            double c8 = -10440.397;
            double c9 = -11.29465;
            double c10 = -0.027022355;
            double c11 = 0.00001289036;
            double c12 = -0.0000000024780681;
            double c13 = 6.5459673;

            double PSW = Math.Exp(c8 / RT + c9 + c10 * RT + c11 * Math.Pow(RT, 2) + c12 * Math.Pow(RT, 3) + c13 * Math.Log(RT));
            return PSW;
        }

        //RAZON DE HUMEDAD******
        // usando Humedad Relativa******

        /*Function HUMRATHR(DbT, HR, ElevInFt)

        pat = PATM(ElevInFt)

        pws = PSW(DbT)

        pw = HR* pws

        pa = pat - pw

        c = 0.621945

        HUMRATHR = c* pw / pa

        End Function*/

        public static double HUMRATHR(double DbT, double HR, double ElevInFt)
        {
            double pat = PATM(ElevInFt);

            double pws = PSW(DbT);

            double pw = HR * pws;

            double pa = pat - pw;

            double c = 0.621945;

            double HUMRATHR = c * pw / pa;

            return HUMRATHR;
        }

        //****** RAZON DE HUMEDAD******
        //****** usando bulbo humedo******

        /*Function HUMRAT(db, wb, ElevInFt)

        REM Find the atmospheric pressure
        AtmPress = patm(ElevInFt)

        REM Use Function to find the saturation pressure at	if Ttest > 212 then Ttest = 212 wet-bulb temperature

        pws = PSW(wb)

        REM Use Equation to find the saturated humidity ratio at the wet bulb-temperature
        wsat = (pws * 0.62198) / (AtmPress - pws)

        REM Use Equation 7 to find the humidity ratio
        HUMRAT = ((1093 - 0.556 * wb) * wsat - 0.24 * (db - wb)) / (1093 + 0.444 * db - wb)

        REM Evitar valores negativos

        if HUMRAT< 0 then

            rem msg = msgbox("Contenido muy bajo de humedad!",0)
	        HUMRAT = 0
	        End if      

        if wb > db then

            rem msg = msgbox("WBT debe ser mayor o igual al DBT!", 0)

            HUMRAT = -1
	        End if
	                                                   
        End Function*/

        public static double HUMRAT(double db, double wb, double ElevInFt)
        {
            //Find the atmospheric pressure
            double AtmPress = PATM(ElevInFt);

            //Use Function to find the saturation pressure at if Ttest > 212 then Ttest = 212 wet - bulb temperature
            double pws = PSW(wb);

            //Use Equation to find the saturated humidity ratio at the wet bulb - temperature
            double wsat = (pws * 0.62198) / (AtmPress - pws);

            // Use Equation 7 to find the humidity ratio
            double HUMRAT = ((1093 - 0.556 * wb) * wsat - 0.24 * (db - wb)) / (1093 + 0.444 * db - wb);

            // Evitar valores negativos
            if (HUMRAT < 0)
            {
                //msg = msgbox("Contenido muy bajo de humedad!", 0)
                HUMRAT = 0;
            }

            if (wb > db)
            {
                //msg = msgbox("WBT debe ser mayor o igual al DBT!", 0)
                HUMRAT = -1;
            }

            return HUMRAT;

        }

        //****** RAZON DE HUMEDAD******
        // *****usando punto de rocio******


        /*Function HUMRATTD(TD, Elev)

       REM Calcular el W Utilizado el bulbo seco con 100 % humedad(bulbo seco = punto de rocio)

       HUMRATTD = HUMRATHR(TD, 1, Elev)

       End Function*/

        public static double HUMRATTD(double TD, double Elev)
        {
            //Calcular el W Utilizado el bulbo seco con 100 % humedad(bulbo seco = punto de rocio)

            double HUMRATTD = HUMRATHR(TD, 1, Elev);

            return HUMRATTD;
        }


        //****** RAZON DE HUMEDAD******
        //****** usando Temperatura y entalpia******


        /*Function HUMRATH(Dbt, H)

           HUMRATH =  (H - 0.24 * Dbt) /  (1061 + 0.444 * Dbt)

        End function*/
        public static double HUMRATH(double Dbt, double H)
        {
            double HUMRATH = (H - 0.24 * Dbt) / (1061 + 0.444 * Dbt);

            return HUMRATH;
        }



        //***** Entalpias******

        /*Function ENT(Dbt, Wbt, Elev)

        W = HUMRAT(Dbt, Wbt, Elev)
        ENT = ENTW(Dbt, W)

        End function*/
        public static double ENT(double Dbt, double Wbt, double Elev)
        {
            double W = HUMRAT(Dbt, Wbt, Elev);

            double ENT = ENTW(Dbt, W);

            return ENT;
        }

        /*Function ENTW(Dbt, W)

        ENTW = 0.24 * Dbt + W* (1061 + 0.444 * Dbt)

        End function*/

        public static double ENTW(double Dbt, double W)
        {
            double ENTW = 0.24 * Dbt + W * (1061 + 0.444 * Dbt);

            return ENTW;
        }


        /* Function ENTHR(Dbt, HR, Elev)

         W = humrathr(Dbt, HR, Elev)

         ENTHR = ENTW(Dbt, W)

         End function*/

        public static double ENTHR(double Dbt, double HR, double Elev)
        {
            double W = HUMRATHR(Dbt, HR, Elev);

            double ENTHR = ENTW(Dbt, W);

            return ENTHR;
        }

        //***** Humedad Relativa******

        /*Function HR(Dbt, Wbt, Elev)

        W = HumRat(Dbt, Wbt, Elev)
        Pat = patm(Elev)
        Ppvap = Ppw(W, Pat)
        Psat = PSW(Dbt)
        HR = Ppvap/Psat

        End function*/
        public static double HR(double Dbt, double Wbt, double Elev)
        {
            double W = HUMRAT(Dbt, Wbt, Elev);

            double Pat = PATM(Elev);

            double Ppvap = PPW(W, Pat);

            double Psat = PSW(Dbt);

            double HR = Ppvap / Psat;

            return HR;
        }

        /*Function HRW(Dbt, W, Elev)

        Pat = patm(Elev)
        Ppvap = Ppw(W, Pat)
        Psat = PSW(Dbt)
        HRW = Ppvap/Psat

        End function*/
        public static double HRW(double Dbt, double W, double Elev)
        {
            double Pat = PATM(Elev);

            double Ppvap = PPW(W, Pat);

            double Psat = PSW(Dbt);

            double HRW = Ppvap / Psat;

            return HRW;
        }


        //****** PUNTO DE ROCIO******
        //Punto de Rocio en F

        /*Function TDW(W, Elev)

        Pat = PATM(Elev)

        REM se agrego "0.00000001" para evitar el log de cero
        pw = PPW(W, Pat) + 0.0000001
        lnpw = log(pw)

        if pw > 0.0886 then

            TDW = 100.45 + 33.193 * lnpw + 2.319 * lnpw ^ 2 + 0.17074 * lnpw ^ 3 + 1.2063 * pw ^ 0.1984

	        else


            TDW = 90.12 + 26.142 * lnpw + 0.8927 * lnpw^2
	
	        end if

        End function*/
        public static double TDW(double W, double Elev)
        {
            double Pat = PATM(Elev);

            //se agrego "0.00000001" para evitar el log de cero
            double pw = PPW(W, Pat) + 0.0000001;

            double lnpw = Math.Log(pw);

            double TDW;

            if (pw > 0.0886)
            {
                TDW = 100.45 + 33.193 * lnpw + 2.319 * Math.Pow(lnpw, 2) + 0.17074 * Math.Pow(lnpw, 3) + 1.2063 * Math.Pow(pw, 0.1984);
            }
            else
            {
                TDW = 90.12 + 26.142 * lnpw + 0.8927 * Math.Pow(lnpw, 2);
            }

            return TDW;

        }

        /*Function TDP(Dbt, Wbt, Elev)

        W = HUMRAT(Dbt, Wbt, Elev)
        TDP = TDW(W, Elev)

        End function*/

        public static double TDP(double Dbt, double Wbt, double Elev)
        {
            double W = HUMRAT(Dbt, Wbt, Elev);

            double TDP = TDW(W, Elev);

            return TDP;
        }


        /*Function TdHR(Dbt, HR)

        Psat = PSW(Dbt)
        Pw = HR* Psat + 0.0000001

        lnpw = log(Pw)

        if pw > 0.0886 then

            TDHR = 100.45 + 33.193 * lnpw + 2.319 * lnpw ^ 2 + 0.17074 * lnpw ^ 3 + 1.2063 * pw ^ 0.1984

	        else


            TDHR = 90.12 + 26.142 * lnpw + 0.8927 * lnpw^2
	
	        end if

        End function*/

        public static double TdHR(double Dbt, double HR)
        {
            double Psat = PSW(Dbt);

            double Pw = HR * Psat + 0.0000001;

            double lnpw = Math.Log(Pw);

            double TdHR;

            if (Pw > 0.0886)
            {
                TdHR = 100.45 + 33.193 * lnpw + 2.319 * Math.Pow(lnpw, 2) + 0.17074 * Math.Pow(lnpw, 3) + 1.2063 * Math.Pow(Pw, 0.1984);
            }
            else
            {
                TdHR = 90.12 + 26.142 * lnpw + 0.8927 * Math.Pow(lnpw, 2);
            }
            return TdHR;
        }


        //****** Bulbo humedo******

        /*function WbtHR(Dbt, HR, Elev)

        W = HUMRATHR(Dbt, HR, Elev)

        WbtHr = WbtW(Dbt, W, Elev)

        end function*/

        public static double WbtHR(double Dbt, double HR, double Elev)
        {
            double W = HUMRATHR(Dbt, HR, Elev);

            double WbtHR = WbtW(Dbt, W, Elev);

            return WbtHR;
        }


        /*  function WbtW(Dbt, W, Elev)

          REM Entalpia

          H = ENTW(Dbt, W)

          REM Se busta la temperatura de saturacion que resulte en la misma entalpia

          Ttest = TSAT(H, Elev)

          Tincr = 0.01

          REM Ajustar la temperatura de bulbo humedo para reducir el error

          i = 0

          MaxErr = 0.00001

          Do
              REM se calcula la entalpia con los valores de prueba

              ENTtest = ENT(Dbt, Ttest, Elev)



              REM Calcular y comparar el error


              e = H - ENTtest

               i = i + 1


              REM Ajustar nuevamente utilizando la nueva temperatura

              wbtw = Ttest


              Ttest = Ttest + sgn(e) * Tincr

          Loop until(abs(e)<MaxErr) or(i > 100)

          if wbtw > Dbt then wbtw = Dbt

          end function*/

        public static double WbtW(double Dbt, double W, double Elev)
        {
            //Entalpia
            double H = ENTW(Dbt, W);

            //Se busta la temperatura de saturacion que resulte en la misma entalpia
            double Ttest = TSAt(H, Elev);

            double Tincr = 0.01;

            //Ajustar la temperatura de bulbo humedo para reducir el error
            double i = 0;

            double MaxErr = 0.00001;

            double e, WbtW;

            do
            {
                //se calcula la entalpia con los valores de prueba
                double ENTtest = ENT(Dbt, Ttest, Elev);

                //Calcular y comparar el error
                e = H - ENTtest;

                i += 1;

                //Ajustar nuevamente utilizando la nueva temperatura
                WbtW = Ttest;

                try
                {
                    Ttest += Math.Sign(e) * Tincr;
                }
                catch (Exception)
                {
                    Ttest += Math.Sign(1) * Tincr;
                }
                

            } while (Math.Abs(e) < MaxErr || i > 100);

            if (WbtW > Dbt)
            {
                WbtW = Dbt;
            }

            return WbtW;
        }

        /*Function WbtTd(Dbt, Td, Elev)

        W = HUMRATTD(Td, Elev)

        WbtTd = WbtW(Dbt, W, Elev)

        End function*/

        public static double WbtTd(double Dbt, double Td, double Elev)
        {
            double W = HUMRATTD(Td, Elev);
                
            double WbtTd = WbtW(Dbt, W, Elev);

            return WbtTd;
        }

        //****** Densidad******
        // lb/ft3

        /*function DENS(Dbt, Wbt, Elev)

        W = HUMRAT(Dbt, Wbt, Elev)
        Pat = PATM(Elev)

        VE = 0.370486 * (Dbt + 459.67) * (1 + 1.607858 * W ) / pat


        DENS = 1 / VE

        End function*/
        public static double DENS(double Dbt, double Wbt, double Elev)
        {
            double W = HUMRAT(Dbt, Wbt, Elev);

            double Pat = PATM(Elev);

            double VE = 0.370486 * (Dbt + 459.67) * (1 + 1.607858 * W) / Pat;

            double DENS = 1 / VE;

            return DENS;
        }

        /*function DENSW(Dbt, W, Elev)

        Pat = PATM(Elev)

        VE = 0.370486 * (Dbt + 459.67) * (1 + 1.607858 * W ) / pat

        DENSW = 1 / VE

        End function*/

        public static double DENSW(double Dbt, double W, double Elev)
        {
            double Pat = PATM(Elev);

            double VE = 0.370486 * (Dbt + 459.67) * (1 + 1.607858 * W) / Pat;

            double DENSW = 1 / VE;

            return DENSW;
        }

        //****** Calor Especifico******

        /*Function Cp(Dbt, Wbt, Elev)

        W = HumRat(Dbt, Wbt, Elev)
        Cp = 0.24 + 0.444 * W

        End function*/

        public static double Cp(double Dbt, double Wbt, double Elev)
        {
            double W = HUMRAT(Dbt, Wbt, Elev);

            double Cp = 0.24 + 0.444 * W;

            return Cp;
        }

        /*Function CPW(Dbt, W, Elev)

        CPW = 0.24 + 0.444 * W

        End function*/

        public static double CPW(double Dbt, double W, double Elev)
        {
            double CPW = 0.24 + 0.444 * W;

            return CPW;
        }


        //****** Bulbo Seco******


        /*Function DbtHW(Ent, W)

        REM ENTW = 0.24 * Dbt + W * (1061 + 0.444 * Dbt)

        DbtHW = (Ent - 1061 * W) / (0.24 + 0.444*W)
 
        end function*/

        public static double DbtHW(double Ent, double W)
        {
            double DbtHW = (Ent - 1061 * W) / (0.24 + 0.444 * W);

            return DbtHW;
        }

        //****** Temperatura de Saturacion******


        /*Function TSAt(Ent, Elev)

        Ttest = 50
        Tincr = 100

        i = 0

        MaxErr = 0.00001

        Do
            REM se calcula la entalpia con los valores de prueba

            ENTtest = ENTHR(Ttest, 1, Elev)



            REM Calcular y comparar el error


            e = ENT - ENTtest

             i = i + 1


            REM Ajustar nuevamente utilizando la nueva temperatura

            Tsat = Ttest


            Ttest = Ttest + sgn(e) * Tincr

            REM Revisar que la prueba no excesa la curva de saturacion
	
	        if patm(Elev) < psw(Ttest) then Ttest = Tsat


            REM Disminuir el factor de ajuste


            Tincr = Tincr / 1.25
	
        Loop until(abs(e)<MaxErr) or(i > 100)


        End function*/

        public static double TSAt(double Ent, double Elev)
        {

            double Ttest = 50;

            double Tincr = 100;

            double i = 0;

            double MaxErr = 0.00001;

            double e;

            double TSAt;

            do
            {
                //se calcula la entalpia con los valores de prueba
                double ENTtest = ENTHR(Ttest, 1, Elev);

                //Calcular y comparar el error
                e = Ent - ENTtest;

                i += 1;

                //Ajustar nuevamente utilizando la nueva temperatura
                TSAt = Ttest;

                try
                {
                    Ttest += Math.Sign(e) * Tincr;
                }
                catch (Exception)
                {

                    Ttest += Math.Sign(1) * Tincr;
                }
               

                //Revisar que la prueba no excesa la curva de saturacion
                if (PATM(Elev) < PSW(Ttest))
                {
                    Ttest = TSAt;
                }

                //Disminuir el factor de ajuste
                Tincr = Tincr / 1.25;

            } while (Math.Abs(e) < MaxErr || i > 100);

            return TSAt;
        }
    }

}
