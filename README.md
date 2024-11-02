# Aprenda Factory Facilmente

### O que é Factory?

Factory é um padrão de projeto em que uma classe (chamada de classe fábrica) cria instâncias de classes diferentes.

‎ 
### Mas como a classe fábrica sabe qual classe ele deve instanciar?

Através de parâmetros que o cliente fornece à classe fábrica.

‎ 
### Qual é a vantagem de criar uma classe que instancia outras classes de forma "personalizada"? 

- O Factory ajuda instanciar objetos sem expor a lógica por trás disso.
- Ele centraliza a responsabilidade de decidir qual objeto instanciar.
- Ele facilita adicionar novos tipos de objetos para o sistema, sem modificar o código do cliente.

‎ 
## Implementando a Estrutura Básica de Factory na Prática:

Criaremos uma interface chamada **IMessage** e três classes: **SMSMessage**, **EmailMessage**, e **PushNotificationMessage** (Estou criando apenas três classes como exemplo, mas você pode criar quantas você quiser).

Agora, nós temos três classes implementando a interface **IMessage**, garantindo que elas tenham o mesmo método.

Até agora, temos a seguinte estrutura:‎

![image](https://github.com/user-attachments/assets/cf39ad7d-2a07-4d6e-9e2a-83ef473c5912)
‎ 
‎
#### Exemplo prático em C# da interface e das classes:

![image](https://github.com/user-attachments/assets/ef26db35-f4d1-44f3-a036-062433536dea)



As classes que implementam IMessage mandarão mensagens de acordo com seu tipo: SMS, Email ou Notificação.

Agora, vamos criar a classe que será responsável por instanciar as classes SMSMessage, EmailMessage, e PushNotificationMessage.

Chamaremos essa classe de **MessageFactory**.
‎ 
![image](https://github.com/user-attachments/assets/636befc3-c59d-4fba-851b-98bec30995e1)


A classe MessageFactory possui o método *getMessage()*, que possui uma string como parâmetro. A depender do valor dessa string, a MessageFactory irá instanciar SMSMessage, EmailMessage, ou PushNotificationMessage.
‎ ‎
#### Exemplo prático em C# da classe MessageFactory:

![image](https://github.com/user-attachments/assets/a1e5c692-2bc3-40ba-bedc-9dd69c040b56)


_**Para quem não sabe C#:**_
_Em `public IMessage? GetMessage(string messageType)`, A interrogação (?) após `IMessage` significa que o método pode retornar uma instância das classes que implementam a interface `IMessage` ou ele pode retornar null._

`StringComparison.CurrentCultureIgnoreCase` _é um parâmetro que faz com que o método Equals() não considere letras maiúsculas e minúsculas como letras diferentes._
‎ 
## Usando Factory

Está pronto! Agora nós podemos criar uma instância da classe fábrica e a deixar responsável por criar instâncias das outras classes.

A partir de agora, tudo ficará mais fácil, portanto, o código abaixo é o suficiente para você entender como implementar o padrão Factory em seu código.

![image](https://github.com/user-attachments/assets/c344298f-1896-47d0-a922-aa92444276a1)


‎ 
### Muito Obrigado!
