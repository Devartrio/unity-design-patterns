using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.Facade
{
    public class FacadePatternSample : MonoBehaviour
    {
        private void Start()
        {
            BankAccountFacade bankAccount = new BankAccountFacade(12345678, 1234);

            Debug.Log("\"I want to withdraw $50 dollars!\"");
            bankAccount.WithdrawCash(50.00);

            Debug.Log("\"Mh ok now let me withdraw $5000 dollars!?\"");
            bankAccount.WithdrawCash(5000.00);

            Debug.Log("\"What tf... maybe save some cash, here are $300 bucks ;-)\"");
            bankAccount.DepositCash(300.00);
        }
    }

    public class WelcomeToBank
    {
        public WelcomeToBank()
        {
            Debug.Log("Welcome to ABC Bank");
            Debug.Log("We are happy to deposit your money :-)");
        }
    }

    public class AccountNumberCheck
    {
        private int accountNumber = 12345678;

        public int GetAccountNumber()
        {
            return accountNumber;
        }

        public bool AccountActive(int accNumber)
        {
            if (accNumber == accountNumber)
                return true;
            else
                return false;
        }
    }

    public class SecurityCodeCheck
    {
        private int securityCode = 1234;

        public int GetSecurityCode()
        {
            return securityCode;
        }

        public bool IsCodeCorrect(int code)
        {
            if (code == securityCode)
                return true;
            else
                return false;
        }
    }

    public class FundsCheck
    {
        private double cashInAccount = 1000.00;

        public double GetCashInAccount()
        {
            return cashInAccount;
        }

        protected void DecreaseCashInAccount(double cash)
        {
            cashInAccount -= cash;
        }

        protected void IncreaseCashInAccount(double cash)
        {
            cashInAccount += cash;
        }

        public bool HaveEnoughMoney(double cashToWithdraw)
        {
            if (cashToWithdraw > GetCashInAccount())
            {
                Debug.Log("You don't have enouth money.");
                return false;
            }
            else
            {
                return true;
            }
        }

        public void MakeDeposit(double cash)
        {
            IncreaseCashInAccount(cash);
            Debug.Log("Deposit complete. Current Balance is: " + GetCashInAccount());
        }

        public void WithdrawMoney(double cash)
        {
            DecreaseCashInAccount(cash);
            Debug.Log("Withdraw complete. Current Balance is: " + GetCashInAccount());
        }
    }

    public class BankAccountFacade
    {
        private int accountNumber;
        private int securityCode;

        AccountNumberCheck acctChecker;
        SecurityCodeCheck codeChecker;
        FundsCheck fundChecker;

        WelcomeToBank bankWelcome;

        public BankAccountFacade(int newAcctNum, int newSecurityCode)
        {
            accountNumber = newAcctNum;
            securityCode = newSecurityCode;

            bankWelcome = new WelcomeToBank();
            acctChecker = new AccountNumberCheck();
            codeChecker = new SecurityCodeCheck();
            fundChecker = new FundsCheck();
        }

        public int GetAccountNumber() { return accountNumber; }
        public int GetSecurityCode() { return securityCode; }

        public void WithdrawCash(double cashToGet)
        {
            if (acctChecker.AccountActive(GetAccountNumber()) &&
                               codeChecker.IsCodeCorrect(GetSecurityCode()) &&
                                              fundChecker.HaveEnoughMoney(cashToGet))
            {
                fundChecker.WithdrawMoney(cashToGet);
                Debug.Log("Transaction Complete\n");
            }
            else
            {
                Debug.Log("Transaction Failed\n");
            }
        }

        public void DepositCash(double cashToDeposit)
        {
            if (acctChecker.AccountActive(GetAccountNumber()) &&
                               codeChecker.IsCodeCorrect(GetSecurityCode()))
            {
                fundChecker.MakeDeposit(cashToDeposit);
                Debug.Log("Transaction Complete\n");
            }
            else
            {
                Debug.Log("Transaction Failed\n");
            }
        }
    }
}