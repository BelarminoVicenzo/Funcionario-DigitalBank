# Funcionario-DigitalBank


Project AspNet MVC
Foi escolhido o MVC em primeiro lugar pelo facto de permitir a separa��o de tarefas.
Base de dados/Modelo, A��es, e P�ginas/Views. Com isso consegue-se obter maior 
organiza��o, escalabilidade, entre outras vantagens.

Em segundo lugar pelo facto do ponto 2 do documento de especifica��o do teste mencionar utilizar o MVC
Em terceiro por ser o padr�o AspNet que tenho o maior dom�nio

Foi utilizado o ORM entity framework pelo facto de haver um casamento natural com a plataforma .NET
e para agilizar e acelerar o desenvolvimento do projecto, e por ter mais dom�nio.
No entanto considerei utilizar o Micro ORM Dapper, n�o o fiz devido o tempo de desenvolvimento.


Foi utilizado o HTML para apresentar as informa��es, CSS para modelar e 
Razor Views (Razor Syntax HTML e CSS) devido ao mapeamento nativo com os modelos e f�cil
gera��o de c�digo HTML/CSS.

JQuery/AJAX para chamadas ass�ncronas.


Foi utilizado o VC (Version Control) git, em primeiro lugar por ser um dos requisitos do projecto.
Em segundo lugar devido a dimens�o da plataforma e f�cil acesso.

Foi criada uma segunda brancha para as novas altera��es.

Funcionamento:

A solu��o est� separada em tr�s projectos: 
Funcionario.Models - onde cont�m os modelos da base de dados
Funcionario.DataAccess - onde cont�m o c�digo para acesso de dados
FuncionarioWeb - o website em si, contendo os controladores e as p�ginas que ser�o visualizadas.

A divis�o foi feita na perspectiva de cada projecto ficar independente e encarregue
somente de uma tarefa ou uma s�rie de tarefas relacionadas, e do projecto poder ser expandido.
Onde poderiam ser efeitas actualiza��es em cada projecto e n�o haver interfer�ncia com
a vers�o em utiliza��o.




