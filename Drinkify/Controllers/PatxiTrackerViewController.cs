// This file has been autogenerated from a class added in the UI designer.

using System;
using System.Timers;
using Foundation;
using Patxi.Models;
using UIKit;

namespace Drinkify.Storyboards
{
	public partial class PatxiTrackerViewController : UIViewController
	{
        public Pedido pedido;
        Timer timer;
		public PatxiTrackerViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad()
		{
            base.ViewDidLoad();

            SetDatos();
            SetImages();
            btnRegresar.Clicked+= delegate {
                DismissViewController(true, null);

            };
            if (pedido.IdStatus == 4 || pedido.IdStatus == 2)
                lblTiempo.Text = "00:00:00";
            else
                PrepararTimer(new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.AddMinutes(5).Hour, DateTime.Now.AddMinutes(5).Minute, DateTime.Now.AddMinutes(5).Second));


            TimerFotos();
            

        }

        void SetDatos(){
            lblDireccion.Text = pedido.Address;
            lblTotal.Text = $"${pedido.TotalPrice.ToString()}";
            lblCantidad.Text = pedido.TotalProducts.ToString();
            lblRepartidor.Text = pedido.Repartidor;
            lblStatus.Text = ((Statuses)pedido.IdStatus).ToString();
        }

        void SetImages(){
            Random rndm = new Random();
            int igRndm = rndm.Next(0, 4);
            String stringName = "s";

            switch (pedido.IdStatus)
            {
                case 0:
                    stringName = $"s1-{(igRndm+1).ToString()}";
                    imgStatus.Image = UIImage.FromBundle(stringName);
                    break;
                case 1:
                    stringName = $"s2-{(igRndm + 1).ToString()}";
                    imgStatus.Image = UIImage.FromBundle(stringName);
                    break;
                case 2:
                    stringName = $"s3-{(igRndm + 1).ToString()}";
                    imgStatus.Image = UIImage.FromBundle(stringName);
                    break;
                case 3:
                    stringName = $"s4-{(igRndm + 1).ToString()}";
                    imgStatus.Image = UIImage.FromBundle(stringName);
                    break;
                case 4:
                    stringName = $"s5-{(igRndm + 1).ToString()}";
                    imgStatus.Image = UIImage.FromBundle(stringName);
                    break;

                default:
                    imgStatus.Image = UIImage.FromBundle("beerDefault");
                    break;
            }
        }

        void PrepararTimer(DateTime fechaFin){
            //bool blink = true;
            timer = new Timer
            {
                Interval = 1000,
                Enabled = true
            };
            var min3 = fechaFin.AddMinutes(-1).Subtract(DateTime.Now);
            Random rn = new Random();
            int acepatda = 2;//rn.Next(1, 3);
            timer.Elapsed += (sender, e) =>
            {
                var cambiarstatus = fechaFin.AddMinutes(-1).Subtract(DateTime.Now);
                var tiempoRestante = fechaFin.Subtract(DateTime.Now);
                if(tiempoRestante.Minutes==min3.Minutes&&tiempoRestante.Seconds==min3.Seconds){
                    if (pedido.IdStatus == 0)
                        pedido.IdStatus = acepatda;
                    else if (pedido.IdStatus == 1)
                        pedido.IdStatus = 3;
                    else if (pedido.IdStatus == 3)
                        pedido.IdStatus = 4;
                    
                        
                    min3 = fechaFin.AddMinutes(-1).Subtract(DateTime.Now);
                    InvokeOnMainThread(SetDatos);
                    if (pedido.IdStatus == 2 || pedido.IdStatus == 4){
                        InvokeOnMainThread(() =>
                        {
                            lblTiempo.Text = "00:00:00";

                        });
                        timer.Stop();
                    }
                        
                }
                if(pedido.IdStatus==4){
                    timer.Stop();
                    timer.Enabled = false;
                    InvokeOnMainThread(() =>
                    {
                        lblTiempo.Text = "00:00:00";

                    });

                }
                var tiempoMostrar = tiempoRestante.ToString("hh") + ":"+tiempoRestante.ToString("mm") + ":" + tiempoRestante.Seconds.ToString();
                InvokeOnMainThread(() =>
                {
                    lblTiempo.Text = tiempoMostrar;

                });
            };

        }

        void TimerFotos(){
            Timer timerFoto = new Timer
            {
                Interval = 5000,
                Enabled = true
            };
            timerFoto.Elapsed += (sender, e) =>
            {
                InvokeOnMainThread(() =>
                {
                    //if (timer.Enabled)
                        SetImages();
                    //else
                      //  timerFoto.Stop();

                });
            };
        }

	}
}
