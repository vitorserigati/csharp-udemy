# Interfaces

Interface é um tipo que define um conjunto de operações que uma classe (ou struct) deve implementar.

A interface estabelece um **Contrato** que a classe (ou struct) deve cumprir.

Pra queê interfaces?

- Para criar sistemas com **baixo acoplamento** e **flexíveis**.

> Para entendermos a utilidade, construíremos 2 programas. Um sem interfaces, e o outro com.
>> Uma locadora brasileira de carros cobra um valor por hora para locações de até 12 horas. Porém, se a duração da locação ultrapassar 12 horas, a locação será cobrada com base em um valor diário. Além do valor da locação, é acrescido no preço o valor do imposto conforme regras do país que, no caso do Brasil, é 20% para valores até 100.00, ou 15% para valores acima de 100.00.
>> Fazer um programa que lê os dados da locação (modelo do carro, instante inicial e final da locação), bem como o valor por hora e o valor diário de locação. O programa deve então gerar a nota de pagamento (contendo valor da locação, valor do imposto e valor total do pagamento) e informar os dados na tela.

Exemplo 1:

> Enter rental data:
>
> Car Model: Civic
>
> Pickup (dd/MM/yyyy HH:mm): 25/02/2023 10:30
>
> Return (dd/MM/yyyy HH:mm): 25/02/2023 14:40
>
> Enter price per hour: 10.00
>
> Enter price per day: 130.00
>
> INVOICE:
>
> Basic payment: 50.00
>
> Tax> 10.00
>
> Total Payment: 60.00

Calculations:
Duration = (25/02/2023 14:40) - (25/02/2023 10:30) = 4:10 = 5 hours
Basic payment = 5 * 10 = 50
Tax = 50 * 20% = 50 * 0.2 = 10

## Injeção de dependência por meio de construtor

```csharp

    class Program
    {
        static void Main(string[] args)
        {
            // Some code
            RentalService rentalService = new RentalService(hour, day, new BrazilTaxService()); // Objeto instanciado diretamente no construtor da classe.
        }
    }

    class rentalService
    {
        private ITaxService _taxService;

        public RentalService(doube pricePerHour, double pricePerDay, ITaxService taxService) // Aceita qualquer objeto que implemente a interface ITaxService
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
            _taxService = taxService;
        }
    }
```
### Inversão de controle

- Inversão de controle

  Padrão de desenvolvimento que consistem em retirar da classe a responsabilidade de instanciar suas dependências.

- Injeção de dependência

  É uma forma de realizar a inversão de controle: um componente externo instancia a dependência, que é então injetada no objeto "pai". Pode ser implementada de várias formas:

   - construtor
   - Objeto de instanciação (builder / factory)
   - Container / framework


### Herdar vs Cumprir Contrato

Aspectos comuns entre herança e interfaces:

- Relação é um.
- Generalização/especialização.
- Polimorfismo.

### Diferença Fundamental

- Herança => reuso.
- Interface => Contrato a ser cumprido.

### Problema do diamante

A herança múltipla pode gerar o problema do diamante: Uma ambiguidade causada pela existência do mesmo método em mais de uma superclasse.

Herança múltipla não é permitida na maioria das linguages!

## Interface IComparable

```csharp

public interface IComparable 
{
    int CompareTo(object other);
}
```
Interface usada internamente dentro da linguagem.
Implementa um método que aceita um objeto e retorna um inteiro para dizer se a comparação é maior, menor ou igual ao objeto comparado.
