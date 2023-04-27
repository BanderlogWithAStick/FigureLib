-- ------------------------------------------------------
-- Таблицы
-- ------------------------------------------------------

CREATE TABLE `products` (
  `id` int(10) NOT NULL,
  `title` varchar(255) CHARACTER SET utf8 NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

ALTER TABLE `products`
  ADD PRIMARY KEY (`id`);

ALTER TABLE `products`
  MODIFY `id` int(10) NOT NULL AUTO_INCREMENT;

-- ------------------------------------------------------

CREATE TABLE `tags` (
  `id` int(11) NOT NULL,
  `title` varchar(255) CHARACTER SET utf8 NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

ALTER TABLE `tags`
  ADD PRIMARY KEY (`id`);

ALTER TABLE `tags`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

-- ------------------------------------------------------

CREATE TABLE `products_ref_tags` (
  `id_ref` int(11) NOT NULL,
  `id_product` int(11) NOT NULL,
  `id_tag` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

ALTER TABLE `products_ref_tags`
  ADD PRIMARY KEY (`id_ref`);

ALTER TABLE `products_ref_tags`
  MODIFY `id_ref` int(11) NOT NULL AUTO_INCREMENT;

-- ------------------------------------------------------
-- Запрос
-- ------------------------------------------------------

SELECT
products.title as Товар,
tags.title as Категория
FROM products
LEFT OUTER JOIN products_ref_tags ON products.id = products_ref_tags.id_product
LEFT OUTER JOIN tags ON tags.id = products_ref_tags.id_tag
ORDER BY products.title
