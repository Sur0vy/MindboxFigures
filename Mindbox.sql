/*
Comment: В данной задаче нужня свять много ко многим, разрешить ее можно используя структуру из 3-х таблиц
products, category и связывающая таблица assotiation. В таком случае связи будут 1 ко многим.
п оданному запросу получаем искомую выборку: все названия продуктов и соответствующие им категории
*/
SELECT P.Name, C.Name
FROM mindbox.products as P
LEFT JOIN mindbox.assotiation as A 
ON (P.ID = A.ID_Product)
LEFT JOIN mindbox.category as C 
ON (C.ID = A.ID_Category)