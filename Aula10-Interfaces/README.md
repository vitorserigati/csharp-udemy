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
> Car Model: Civic
> Pickup (dd/MM/yyyy HH:mm): 25/02/2023 10:30
> Return (dd/MM/yyyy HH:mm): 25/02/2023 14:40
> Enter price per hour: 10.00
> Enter price per day: 130.00
> INVOICE:
> Basic payment: 50.00
> Tax> 10.00
> Total Payment: 60.00

Calculations:
Duration = (25/02/2023 14:40) - (25/02/2023 10:30) = 4:10 = 5 hours
Basic payment = 5 * 10 = 50
Tax = 50 * 20% = 50 * 0.2 = 10
