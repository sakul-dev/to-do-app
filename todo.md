## tables for my to do app

| table | user |
|-------|------|
| int   | id (unique) | 
| string | userName | 
| string | mail | 
| string | password |

| table | task |
|-------|------|
| int | id (unique) |
| string | title |
| string | description |
| date | deadLine |
| bool | isDone | 

## sql queries for the creation of tbls
### create tables

```sql
CREATE TABLE users (
    id INT AUTO_INCREMENT PRIMARY KEY,
    userName VARCHAR(100),
    mail VARCHAR(200),
    password VARCHAR(200)
);


CREATE TABLE task (
    id INT AUTO_INCREMENT PRIMARY KEY,
    title VARCHAR(100),
    description VARCHAR(200),
    deadline DATETIME,
    isDone bool
);
```
