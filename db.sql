CREATE TABLE IF NOT EXISTS products (
    product_id INT PRIMARY KEY AUTO_INCREMENT,
    name VARCHAR(50) NOT NULL,
    description VARCHAR(255),
    price DECIMAL(10,2),
    quantity INT,
    created_at DATETIME DEFAULT CURRENT_TIMESTAMP,
    updated_at DATETIME
);

CREATE TABLE IF NOT EXISTS staff (
    staff_id INT PRIMARY KEY AUTO_INCREMENT,
    name VARCHAR(255) NOT NULL,
    email VARCHAR(255) NOT NULL,
    role VARCHAR(50) NOT NULL,
    password VARCHAR(255) NOT NULL,
    created_at DATETIME DEFAULT CURRENT_TIMESTAMP,
    updated_at DATETIME
);

CREATE USER salesync@localhost identified by 'salesync';

ALTER USER salesync@localhost identified by 'salesync';

GRANT ALL PRIVILEGES ON *.* TO 'salesync'@'localhost' WITH GRANT OPTION;


CREATE  TABLE IF NOT EXISTS sale (
    sale_id INT PRIMARY KEY AUTO_INCREMENT,
    date_of_purchase DATETIME DEFAULT CURRENT_TIMESTAMP,
    total_price DECIMAL(10, 2),
    served_by INT,
    updated_at DATETIME,
    FOREIGN KEY (served_by) REFERENCES staff(staff_id)
);

CREATE  TABLE IF NOT EXISTS sale_item (
    sale_item_id INT PRIMARY KEY AUTO_INCREMENT,
    product INT,
    unit_price DECIMAL(10, 2),
    quantity INT,
    sale INT,
    updated_at DATETIME,
    FOREIGN KEY (sale) REFERENCES sale(sale_id),
    FOREIGN KEY (product) REFERENCES products(product_id)
);
