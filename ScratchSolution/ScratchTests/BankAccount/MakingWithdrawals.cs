
namespace ScratchTests.BankAccount
{
    public class MakingWithdrawals
    {



        [Fact]
        public void MakingWithdrawalsLowersBalance()
        {
            var account = new Account();
            var openingBalance = account.GetBalance();
            var amountToWithdraw = 100M;



            account.Withdraw(amountToWithdraw);



            Assert.Equal(openingBalance - amountToWithdraw, account.GetBalance());




        }


        [Fact]
        public void CanTakeAllMoneyFromAccount()
        {
            var account = new Account();
            var openingBalance = account.GetBalance();




            account.Withdraw(openingBalance);



            Assert.Equal(0M, account.GetBalance());
        }
    }
}
