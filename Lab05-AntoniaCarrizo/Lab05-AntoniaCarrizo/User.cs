using System;
namespace Solucion_Lab_21_abril
{
    public class User
    {
        public User()
        {
        }
        //Definir delegate:
        public delegate void VerifiedEmailEventHandler(object source, EventArgs args);
        //Definir el evento:
        public event VerifiedEmailEventHandler EmailVerified;
        //Disparar el evento:
        protected virtual void OnEmailVerified()
        {
            //Revisar si existen suscriptores
            if (EmailVerified != null)
            {
                EmailVerified(this, new EventArgs());
            }
        }
        public void OnEmailSent(object source, EventArgs e)
        {
         
            int i = 0;
            while (i < 1)
            {
                Console.WriteLine("Quiere verificar su correo?:  \n1)Si \n2)No");
                string op = Console.ReadLine();
                int option = Convert.ToInt32(op);
                switch (option)
                {
                    case 1:
                        OnEmailVerified();
                        i++;
                        break;
                    case 2:
                        i++;
                        break;
                    default:
                        Console.WriteLine("Opcion no valida");   
                        break;

                }
            }
            

        }
    }
}
