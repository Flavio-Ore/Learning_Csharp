using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThreadsLockJoinIIICs
{
    public class CuentaBancaria
    {
        //para usar lock(_balanceLock){}
        private readonly object _balanceLock = new();
        //balance is Saldo in english
        private double _balance;
        public double Balance { get => _balance; }
        public CuentaBancaria(double balance)
        {
            this._balance = balance;
        }
        public double WithdrawBalance(double amount)
        {
            if ((this._balance - amount) < 0) 
            {
                Console.WriteLine($"Hay {this._balance} de saldo. No puede retirar más. Thread: {Thread.CurrentThread.Name}");
                
                return this._balance;
            }
            //no da tiempo a ejecutar esta instrucción
            //!mientras un thread está realizando determinada instrucción dentro del lock, ningún otro thread podrá realizar dicha instrucción hasta que termine el otro.
            lock(_balanceLock) //lock negative balances
            {
                if (this._balance >= amount)
                {
                    Console.WriteLine($"Retirado {amount} por el thread {Thread.CurrentThread.Name}, queda {this._balance-amount} en la cuenta.");
                    this._balance -= amount;
                }
                return this._balance;
            }
        }
        public void DrawingBalance()
        {
            Console.WriteLine($"Hilo presente: {Thread.CurrentThread.Name}");

            for (int i = 0; i < 2; i++)
                WithdrawBalance(500);
        }
    }
}