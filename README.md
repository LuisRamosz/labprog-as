Link do Texto Acadêmico: https://docs.google.com/document/d/1wuJh5JqXRaW-CJU3GDrtGANlMt82EG33pel0bN8oKtk/edit?usp=sharing

Link do Vídeo: https://drive.google.com/file/d/15eOGodaMhfYjy0hLUvqljERsi1SHaayr/view?usp=sharing

Dicas para usar:

Baixe os arquivos do projeto.
Abra o terminal e escreva: dotnet run
O terminal vai mostrar a url, exemplo: http://localhost:5042.
Copie essa url e use no Postman, Swagger ou outro programa para testar.

No Postman (Programa em que eu utilizei) nós podemos:

Ver a lista de pedidos:
[GET /pedido](http://localhost:5042/pedido)

Criar um novo pedido:
[POST/pedidos](http://localhost:5042/pedido)
Exemplo no body:
{
	  "Id": 10,
    "Data": "2024-05-11",
    "ValorTotal": 15.99,
    "Status": "Pronto",
    "Descricao": "Bom"
}

Listar pelo Id:
[GET /pedidos/{id}](http://localhost:5042/pedido/10)
Mude o {id} pelo número do pedido.

Atualizar a lista:
[PUT /pedidos/{id}](http://localhost:5042/pedido/10)
Mude o {id} para o número do pedido que quer alterar.

Deletar o pedido:
[DELETE /api/pedidos/{id}](http://localhost:5042/pedido/10)
Mude o {id} pelo número do pedido que quer apagar.
