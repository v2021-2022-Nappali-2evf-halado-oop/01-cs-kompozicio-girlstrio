using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpectatorteamProject.model
{
    class CreditCard
    {
        /// <summary>
        /// lejárati dátum adatmező
        /// </summary>
        private DateTime expireDate;
        /// <summary>
        /// kártyaszám adat
        /// </summary>
        private string cardNumber;

        /// <summary>
        /// konstruktor
        /// </summary>
        /// <param name="expireDate"></param>
        /// <param name="cardNumber"></param>
        public CreditCard(DateTime expireDate, string cardNumber)
        {
            this.expireDate = expireDate;
            this.cardNumber = cardNumber;
        }

        public DateTime ExpireDate { get => expireDate; set => expireDate = value; }
        public string CardNumber { get => cardNumber; set => cardNumber = value; }

        /// <summary>
        /// lejárat tulajdonság meghatározása
        /// </summary>
        public bool Expired
        {
            get
            {
                if (expireDate < DateTime.Now)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
