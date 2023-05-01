using Banking;



namespace ScratchTests.BankAccount;

public class MakingDeposits
{

    [Fact]
    public void DepositsIncreaseTheBalance()
    {
        // Given
        var account = new Account();
        var openingBalance = account.GetBalance();
        var amountToDeposit = 100.12M;
        // When
        account.Deposit(amountToDeposit);
        // Then
        Assert.Equal(openingBalance + amountToDeposit, account.GetBalance());
    }
}
