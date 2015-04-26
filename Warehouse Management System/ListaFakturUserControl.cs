using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Warehouse_Management_System
{
    public partial class ListaFakturUserControl : UserControl
    {
        private HomeForm homeForm;
        private Faktury f;

        public ListaFakturUserControl()
        {
            InitializeComponent();
        }

        public ListaFakturUserControl(HomeForm homeForm, Faktury f)
        {
            InitializeComponent();
            this.homeForm = homeForm;
            this.f = f;
            wczytajDane();
        }

        private void wczytajDane()
        {
            numerFakturyTb.Text = f.Nr_faktury.ToString();
            nazwaFirmyTb.Text = f.Klienci.Nazwa;
            nipTb.Text = f.Klienci.Nip;
            dataWystawienia.Value = f.Data_wystawienia;
        }

        private void edytujFaktureBtn_Click(object sender, EventArgs e)
        {
            NowaFakturaForm nff = new NowaFakturaForm(homeForm, f);
            nff.Show();
        }

        private void HtmlBtn_Click(object sender, EventArgs e)
        {
            string fileName = "C:\\Users\\pc1\\Desktop\\faktura numer " + f.Nr_faktury+ ".html";
            StreamWriter sw = new StreamWriter(fileName);

            sw.WriteLine("<html>");
                sw.WriteLine("<head>");
                    sw.WriteLine("<meta http-equiv=\"Content-Type\" content=\"text/html; charset=utf-8\"/>");
                sw.WriteLine("</head>");
                sw.WriteLine("<body style=\"font-family: dejavu sans; \">");
                    sw.WriteLine("<div style=\"width:700px\">");
                        sw.WriteLine("<h2 style=\"text-align: center; margin: 0px; padding: 0px\">Numer faktury: "+f.Nr_faktury+" </h2>");
                        sw.WriteLine("<p style=\"text-align: center; margin: 0px; padding: 0px; color: #bf800c\">Data wystawienia: " + f.Data_wystawienia.ToShortDateString() + "</p>");
                        sw.WriteLine("<p style=\"text-align: center; margin: 0px; padding: 0px; color: #bf800c\">Data sprzedaży: " + f.Data_sprzedazy.ToShortDateString() + "</p>");
                        sw.WriteLine("<p style=\"text-align: center; margin: 0px; padding: 0px; color: #bf800c\">Termin płatności: " + f.Termin_zaplaty.ToShortDateString() + "</p>");
                    
                        sw.WriteLine("<table style=\"color: #444\">");
                            sw.WriteLine("<tr>");
                                sw.WriteLine("<td style=\"vertical-align: top; width: 480px; font-size: 12px\">");
                                    sw.WriteLine("<p style=\"color: #428bca; font-size: 17px; font-weight: bold; margin: 0\">Nabywca</p>");
                                    sw.WriteLine("<b>" + f.Klienci.Nazwa + "</b><br>");
                                    sw.WriteLine("ul. "+f.Klienci.Ulica + " " + f.Klienci.Nr_budynku + " " + (f.Klienci.Nr_mieszkania != string.Empty?"m"+f.Klienci.Nr_mieszkania:null) + "<br>");
                                    sw.WriteLine(f.Klienci.Kod_pocztowy + " " + f.Klienci.Miasto + "<br>");
                                    sw.WriteLine("NIP: " + f.Klienci.Nip + "<br>");
                                sw.WriteLine("</td>");
                                sw.WriteLine("<td style=\"text-align: right; vertical-align: top; width: 210px; font-size: 12px\">");
                                    sw.WriteLine("<p style=\"color: #428bca; font-size: 17px; font-weight: bold; margin: 0\">Sprzedawca</p>");
                                    sw.WriteLine("<b>" + f.DaneFirmy.Nazwa + "</b><br>");
                                    sw.WriteLine("ul. " + f.DaneFirmy.Ulica + " " + f.DaneFirmy.Nr_budynku + " " + (f.DaneFirmy.Nr_mieszkania != string.Empty ? "m" + f.DaneFirmy.Nr_mieszkania : null) + "<br>");
                                    sw.WriteLine(f.DaneFirmy.Kod_pocztowy + " " + f.DaneFirmy.Miasto + "<br>");
                                    sw.WriteLine("NIP: " + f.DaneFirmy.Nip + "<br>");
                                sw.WriteLine("</td>");
                            sw.WriteLine("</tr>");
                        sw.WriteLine("</table>");
                    sw.WriteLine("</div>");
                    sw.WriteLine("<table style=\"border-spacing: 0px; font-size: 14px; margin-top: 20px;\">");
                        sw.WriteLine("<thead>");
                            sw.WriteLine("<tr style=\"background-color: #858585;\">");
                                sw.WriteLine("<th style=\"width: 10px; color: #EBF3EC; padding: 2px;\">Lp.</th>");
                                sw.WriteLine("<th style=\"text-align: left; width: 210px; color: #EBF3EC; padding-left: 5px;\">Nazwa towaru</th>");
                                sw.WriteLine("<th style=\"width: 35px; color: #EBF3EC; padding: 2px;\">Ilość</th>");
                                sw.WriteLine("<th style=\"width: 90px; color: #EBF3EC; padding: 2px;\">Cena netto</th>");
                                sw.WriteLine("<th style=\"width: 90px; color: #EBF3EC; padding: 2px;\">Wartość netto</th>");
                                sw.WriteLine("<th style=\"width: 50px; color: #EBF3EC; padding: 2px;\">VAT</th>");
                                sw.WriteLine("<th style=\"width: 80px; color: #EBF3EC; padding: 2px;\">Kwota VAT</th>");
                                sw.WriteLine("<th style=\"width: 90px; color: #EBF3EC; padding: 2px;\">Cena brutto</th>");
                            sw.WriteLine("</tr>");
                        sw.WriteLine("</thead>");
                        sw.WriteLine("<tbody>");
                            int i = 1;
                            decimal war_netto = 0;
                            decimal kwota_vat = 0;
                            decimal war_brutto = 0;
                            foreach (var Produkt in f.Produkty_sprzedanes)
                            {
                                war_netto += Math.Round(Produkt.Cena_jednostkowa_netto * Produkt.Ilosc, 2);
                                war_brutto += Math.Round(((Produkt.vat * Produkt.Cena_jednostkowa_netto / 100) + Produkt.Cena_jednostkowa_netto) * Produkt.Ilosc, 2);
                                kwota_vat += Math.Round((Produkt.vat * Produkt.Cena_jednostkowa_netto / 100) * Produkt.Ilosc, 2);

                                sw.WriteLine("<tr style=\"text-align: center;\">");
                                    sw.WriteLine("<td style=\"border-top: 1px solid #999\">"+ i++ +"</td>");
                                    sw.WriteLine("<td style=\"padding-left: 5px; text-align: left; border-top: 1px solid #999\">" + Produkt.Nazwa_produktu + "</td>");
                                    sw.WriteLine("<td style=\"border-top: 1px solid #999\">" + Produkt.Ilosc + "</td>");
                                    sw.WriteLine("<td style=\"border-top: 1px solid #999\">" + Math.Round(Produkt.Cena_jednostkowa_netto, 2) + " zł</td>");
                                    sw.WriteLine("<td style=\"border-top: 1px solid #999\">" + Math.Round(Produkt.Cena_jednostkowa_netto * Produkt.Ilosc, 2) + " zł</td>");
                                    sw.WriteLine("<td style=\"border-top: 1px solid #999\">" + Produkt.vat + "%</td>");
                                    sw.WriteLine("<td style=\"border-top: 1px solid #999\">" + Math.Round((Produkt.vat * Produkt.Cena_jednostkowa_netto / 100) * Produkt.Ilosc, 2) + " zł</td>");
                                    sw.WriteLine("<td style=\"border-top: 1px solid #999\">" + Math.Round(((Produkt.vat * Produkt.Cena_jednostkowa_netto / 100) + Produkt.Cena_jednostkowa_netto) * Produkt.Ilosc, 2) + " zł</td>");
                                sw.WriteLine("</tr>");
                            }

                            sw.WriteLine("<tr style=\"text-align: center; color: #EBF3EC;\">");
                                sw.WriteLine("<td></td>");
                                sw.WriteLine("<td></td>");
                                sw.WriteLine("<td></td>");

                                sw.WriteLine("<td style=\"background-color: #858585;\"><b>RAZEM:</b></td>");

                                sw.WriteLine("<td style=\"background-color: #858585;\">" + war_netto + " zł</td>");
                                sw.WriteLine("<td style=\"background-color: #858585;\"></td>");
                                sw.WriteLine("<td style=\"background-color: #858585;\">" + kwota_vat + " zł</td>");
                                sw.WriteLine("<td style=\"background-color: #858585;\">" + war_brutto + " zł</td>");

                            sw.WriteLine("</tr>");

                        sw.WriteLine("</tbody>");
                    sw.WriteLine("</table>");
                    sw.WriteLine("<br>");
                    sw.WriteLine("<br>");
                    sw.WriteLine("<h3 style=\"margin-left:20px;\">Razem do zapłaty: " + war_brutto + " zł</h3>");
                sw.WriteLine("</body>");
            sw.WriteLine("</html>");
            Process.Start(fileName);


            sw.Close();
        }
    }
}
