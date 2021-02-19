# Funcionario-DigitalBank


Project AspNet MVC
Foi escolhido o MVC em primeiro lugar pelo facto de permitir a separação de tarefas.
Base de dados/Modelo, Ações, e Páginas/Views. Com isso consegue-se obter maior 
organização, escalabilidade, entre outras vantagens.

Em segundo lugar pelo facto do ponto 2 do documento de especificação do teste mencionar utilizar o MVC
Em terceiro por ser o padrão AspNet que tenho o maior domínio

Foi utilizado o ORM entity framework pelo facto de haver um casamento natural com a plataforma .NET
e para agilizar e acelerar o desenvolvimento do projecto, e por ter mais domínio.
No entanto considerei utilizar o Micro ORM Dapper, não o fiz devido o tempo de desenvolvimento.


Foi utilizado o HTML para apresentar as informações, CSS para modelar e 
Razor Views (Razor Syntax HTML e CSS) devido ao mapeamento nativo com os modelos e fácil
geração de código HTML/CSS.

JQuery/AJAX para chamadas assíncronas.


Foi utilizado o VC (Version Control) git, em primeiro lugar por ser um dos requisitos do projecto.
Em segundo lugar devido a dimensão da plataforma e fácil acesso.

Foi criada uma segunda brancha para as novas alterações.

Funcionamento:

A solução está separada em três projectos: 
Funcionario.Models - onde contêm os modelos da base de dados
Funcionario.DataAccess - onde contêm o código para acesso de dados
FuncionarioWeb - o website em si, contendo os controladores e as páginas que serão visualizadas.

A divisão foi feita na perspectiva de cada projecto ficar independente e encarregue
somente de uma tarefa ou uma série de tarefas relacionadas, e do projecto poder ser expandido.
Onde poderiam ser efeitas actualizações em cada projecto e não haver interferência com
a versão em utilização.




