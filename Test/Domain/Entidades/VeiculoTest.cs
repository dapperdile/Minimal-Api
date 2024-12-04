using MinimalApi.Dominio.Entidades;

namespace Test.Domain.Entidades;

[TestClass]
public class VeiculoTest
{
    [TestMethod]
    public void TestarGetSetPropriedades()
    {
        // Arrange
        var veiculo = new Veiculo();

        // Act
        veiculo.Id = 1;
        veiculo.Nome = "Camaro";
        veiculo.Marca = "Chevrolet";
        veiculo.Ano = 2020;

        // Assert
        Assert.AreEqual(1, veiculo.Id);
        Assert.AreEqual("Camaro", veiculo.Nome);
        Assert.AreEqual("Chevrolet", veiculo.Marca);
        Assert.AreEqual(2020, veiculo.Ano);
    }
}
