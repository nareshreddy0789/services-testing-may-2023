using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ScratchTests.BankAccount
{
   public class OverDrafting
    {
    }

 [Fact]


 public void BehaviorBeforeChange()

    {

        var account = new Account();

        var openingBalance = account.GetBalance();

        var amountToWithdraw = 0.01M;



        account.Withdraw(openingBalance + amountToWithdraw);



        Assert.Equal(openingBalance - (openingBalance + amountToWithdraw), account.GetBalance());

    }






}
