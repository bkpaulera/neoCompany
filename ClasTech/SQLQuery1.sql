
INSERT INTO pedido(Nome, Descricao, ValorTotal, DataPedido, Ativo)
VALUES
    ('Pedido1', 'Descrição do Pedido 1', 10.50, '2017-01-01', 1),
    ('Pedido2', 'Descrição do Pedido 2', 21.00, '2017-01-01', 1),
    ('Pedido3', 'Descrição do Pedido 3', 31.50, '2017-01-01', 0),
    ('Pedido4', 'Descrição do Pedido 4', 42.00, '2017-01-01', 0),
    ('Pedido5', 'Descrição do Pedido 5', 52.50, '2018-01-01', 1);

INSERT INTO pedidoItem(PedidoViewModelId, Nome, Descricao, Valor, Ativo)
VALUES
    (4, 'Item1', 'Descrição do Item 1', 5.75, 1),
    (5, 'Item2', 'Descrição do Item 2', 11.50, 1),
    (1, 'Item3', 'Descrição do Item 3', 17.25, 1),
    (2, 'Item1', 'Descrição do Item 1', 5.75, 1),
    (2, 'Item2', 'Descrição do Item 2', 11.50, 1),
    (5, 'Item1', 'Descrição do Item 1', 5.75, 1),
    (5, 'Item2', 'Descrição do Item 2', 11.50, 1);

