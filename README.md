# CSharp-HerancaPolimorfismo
**Programa de cálculo de impostos** (empregados individuais e corporativos)

Neste pequeno exemplo, utilizo os conceitos de **herança**, **polimorfismo** e uma lógica simples para cálculo de impostos com base nas regras de negócio.

###### Exemplo de entrada:

1 - Informe a quantidade de contribuintes (informar um dado inteiro).

2 - Informe se o contribuinte é individual ou corporativo (informar um char, sendo i ou c).

3 - Com base na escolha o sistema irá solicitar determinados dados, sendo contribuinte individual:

3.1 - Nome (varchar).

3.2 - Ganho anual (double com duas casas decimais, separadas por ponto (.))

3.3 - Gasto com plano de saúde (double com duas casas decimais, separadas por ponto (.)) --> O programa irá criar um objeto do tipo Contribuinte Individual dentro da variável genérica Contribuinte (classe abstrata).

4 - Se a escolha for contribuinte coporativo:

4.1 - Nome (varchar)

4.2 - Ganho anual (double com duas casas decimais, separadas por ponto (.))

4.3 - Quantidade de empregados que trabalham na empresa (informar um dado inteiro) --> O programa irá criar um objeto do tipo Contribuinte Corporativo dentro da variável genérica Contribuinte (classe abstrata).

Após informar todos os dados, o programa realiza o cálculo de modo polimórfico e exibe o resultado com base nas regras definidas em cada subclasse.
